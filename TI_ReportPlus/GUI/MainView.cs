using TI.ReportPlus.BE;
using TI.ReportPlus.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.Deployment.Application;

namespace TI.ReportPlus.GUI
{
    public partial class MainView : Form
    {
        private DBHandler dbHandler = new DBHandler();
        private Settings settings = new Settings();

        public MainView()
        {
            InitializeComponent();

          //  Version version = Assembly.GetExecutingAssembly().GetName().Version;
         //   Text = Text + " " + version.Major + "." + version.Minor + "." + version.Build + " (rev " + version.Revision + ")"; //change form title

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment cd = ApplicationDeployment.CurrentDeployment;
                Version version = cd.CurrentVersion;
                Text = Text + " " + version.Major + "." + version.Minor + "." + version.Build + " (rev " + version.Revision + ")";
            }

            Helper.Setup();
            Logger.Setup();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            // Add data to combobox
            foreach (CatalogItem ci in dbHandler.GetCatalogs())
            {
                cb_catalogs.Items.Add(ci.Name);
            }
            foreach (String p in dbHandler.GetPrinters())
            {
                cb_printers.Items.Add(p);
            }

            // Select first item in each combox
            if (cb_catalogs.Items.Count > 0)
                cb_catalogs.SelectedIndex = 0;

            if (cb_printers.Items.Count > 0)
            {
                cb_printers.SelectedIndex = cb_printers.FindStringExact(Property.Get("Setting_PrinterPath"));
                if (cb_printers.SelectedIndex < 0)
                    cb_printers.SelectedIndex = 0;
            }

            // Printer
            timePicker_Printer.Value = DateTime.Parse(Property.Get("Printer_TimeOfDay"));
            datePicker_Printer.Value = DateTime.Parse(Property.Get("Printer_Date"));
            txt_Printer_Interval.Text = Property.Get("Printer_Interval");

            // PDF
            timePicker_PDF.Value = DateTime.Parse(Property.Get("PDF_TimeOfDay"));
            datePicker_PDF.Value = DateTime.Parse(Property.Get("PDF_Date"));
            txt_PDF_Interval.Text = Property.Get("PDF_Interval");


        }

        private void cb_catalogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: handle change catelog event
        }


        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cb_printers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: handle change printer event
        }

        private void btn_Printer_Click(object sender, EventArgs e)
        {
            createSubscription_Printer();
        }

        private void btn_PDF_Click(object sender, EventArgs e)
        {
            createSubscription_PDF();
        }

        private void btn_QuickLink_Click(object sender, EventArgs e)
        {
            createQuickLinks();
        }

        private void toolStripStatusLabel_TextChanged(object sender, EventArgs e)
        {
            timerStatusLabel.Interval = 10 * 1000;
            timerStatusLabel.Start();
        }

        private void timerStatusLabel_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = string.Empty;
            toolStripStatusLabel.BackColor = Color.White;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker backgroundWorker = sender as BackgroundWorker;

            backgroundWorker.WorkerReportsProgress = true;
            for (int j = 1; j < 10000; j++)
            {
                backgroundWorker.ReportProgress((j * 100) / 10000);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar.Visible = true;
            toolStripProgressBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripProgressBar.Value = 0;
            toolStripProgressBar.Visible = false;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //settings.Show();
            settings.ShowDialog(this);
            this.WindowState = FormWindowState.Normal;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpProvider.GetShowHelp(this);
        }

        private void createQuickLinks()
        {
            backgroundWorker.RunWorkerAsync();

            CatalogItem ci = dbHandler.GetCatalogs().Where(c => c.Name.Equals(cb_catalogs.SelectedItem)).FirstOrDefault();

            if (ci != null)
            {
                toolStripStatusLabel.Text = "Created " + dbHandler.CreateLinks(ci) + " Quicklink(s) on " + ci.Name;
            }

            // Save settings
            saveCustomSettings();
        }

        private void createSubscription_Printer()
        {
            backgroundWorker.RunWorkerAsync();

            CatalogItem catalog = dbHandler.GetCatalogs().Where(c => c.Name.Equals(cb_catalogs.SelectedItem)).FirstOrDefault();
            string printer = dbHandler.GetPrinters().Where(p => p.Equals(cb_printers.SelectedItem)).FirstOrDefault();
            DateTime datetime = datePicker_Printer.Value.Date + timePicker_Printer.Value.TimeOfDay;
            DateTime newDate;

            int interval;
            if (!Int32.TryParse(Property.Get("Printer_Interval"), out interval))
            {
                // TODO: The parsing attempt failed
                interval = 15;
            }

            // init variables
            List<Subscription> subs = new List<Subscription>();
            Subscription subscription;

            // Create subscription (Daily)
            newDate = new DateTime(datetime.Year, datetime.Month, datetime.Day, datetime.Hour, datetime.Minute, datetime.Second, datetime.Kind);
            newDate = newDate.AddDays(1);
            subscription = new Subscription(
                catalog,
                SubscriptionPeriode.Day,
                new Schedule(newDate, SchedulePeriode.Daily),
                SubscriptionType.Printer
            );
            if (dbHandler.CreateJob(ref subscription, printer)) subs.Add(subscription);

            // Create subscription (Monthly)
            newDate = new DateTime(datetime.Year, datetime.Month, 1, datetime.Hour, datetime.Minute, datetime.Second, datetime.Kind);
            newDate = newDate.AddMinutes(interval);
            newDate = newDate.AddMonths(1);
            subscription = new Subscription(
                catalog,
                SubscriptionPeriode.Month,
                new Schedule(newDate, SchedulePeriode.Monthly),
                SubscriptionType.Printer
            );
            if (dbHandler.CreateJob(ref subscription, printer)) subs.Add(subscription);

            // Create subscription (Yearly)
            newDate = new DateTime(datetime.Year, 1, 1, datetime.Hour, datetime.Minute, datetime.Second, datetime.Kind);
            newDate = newDate.AddMinutes(interval + interval);
            newDate = newDate.AddYears(1);
            subscription = new Subscription(
                catalog,
                SubscriptionPeriode.Year,
                new Schedule(newDate, SchedulePeriode.Yearly),
                SubscriptionType.Printer
            );
            if (dbHandler.CreateJob(ref subscription, printer)) subs.Add(subscription);


            // Update GUI status
            int count = 0;
            bool hasError = false;
            string errorText = "";
            foreach (Subscription sub in subs)
            {
                if (sub.ID > 0)
                    count++;
                else {
                    if (hasError) errorText += ", ";
                    errorText += subscription.Periode.ToString();
                    hasError = true;
                }
            }

            if (hasError)
            {
                if (count > 0)
                    toolStripStatusLabel.Text = "Created " + count + " but, Failed to create: " + subscription.Periode.ToString() + " subscription";
                else
                    toolStripStatusLabel.Text = "Failed to create: " + subscription.Periode.ToString() + " subscription";
                toolStripStatusLabel.BackColor = Color.Red;
            }
            else {
                toolStripStatusLabel.Text = "Created " + count + " Printer Subscription(s)";
                toolStripStatusLabel.BackColor = Color.White;
            }

            Helper.RestartService("NRPScheduler", 15 * 1000);

            // Save settings
            saveCustomSettings();
        }

        private void saveCustomSettings()
        {
            // Printer
            string printer = dbHandler.GetPrinters().Where(p => p.Equals(cb_printers.SelectedItem)).FirstOrDefault();
            Property.Set("Setting_PrinterPath", printer);
            Property.Set("Printer_TimeOfDay", timePicker_Printer.Value);
            Property.Set("Printer_Date", datePicker_Printer.Value);
            Property.Set("Printer_Interval", txt_Printer_Interval.Text);

            // PDF
            Property.Set("PDF_TimeOfDay", timePicker_PDF.Value);
            Property.Set("PDF_Date", datePicker_PDF.Value);
            Property.Set("PDF_Interval", txt_PDF_Interval.Text);

            // Save
            Property.Save();
        }

        private void createSubscription_PDF()
        {
            backgroundWorker.RunWorkerAsync();

            CatalogItem catalog = dbHandler.GetCatalogs().Where(c => c.Name.Equals(cb_catalogs.SelectedItem)).FirstOrDefault();
            DateTime datetime = datePicker_Printer.Value.Date + timePicker_Printer.Value.TimeOfDay;
            DateTime newDate;

            int interval;
            if (!Int32.TryParse(Property.Get("PDF_Interval"), out interval))
            {
                // TODO: The parsing attempt failed
                interval = 15;
            }

            // init variables
            List<Subscription> subs = new List<Subscription>();
            Subscription subscription;

            // Create subscription (Daily)
            newDate = new DateTime(datetime.Year, datetime.Month, datetime.Day, datetime.Hour, datetime.Minute, datetime.Second, datetime.Kind);
            newDate = newDate.AddDays(1);
            subscription = new Subscription(
                catalog,
                SubscriptionPeriode.Day,
                new Schedule(newDate, SchedulePeriode.Daily),
                SubscriptionType.PDF
            );
            if (dbHandler.CreateJob(ref subscription)) subs.Add(subscription);

            // Create subscription (Monthly)
            newDate = new DateTime(datetime.Year, datetime.Month, 1, datetime.Hour, datetime.Minute, datetime.Second, datetime.Kind);
            newDate = newDate.AddMinutes(interval);
            newDate = newDate.AddMonths(1);
            subscription = new Subscription(
                catalog,
                SubscriptionPeriode.Month,
                new Schedule(newDate, SchedulePeriode.Monthly),
                SubscriptionType.PDF
            );
            if (dbHandler.CreateJob(ref subscription)) subs.Add(subscription);

            // Create subscription (Yearly)
            newDate = new DateTime(datetime.Year, 1, 1, datetime.Hour, datetime.Minute, datetime.Second, datetime.Kind);
            newDate = newDate.AddMinutes(interval + interval);
            newDate = newDate.AddYears(1);
            subscription = new Subscription(
                catalog,
                SubscriptionPeriode.Year,
                new Schedule(newDate, SchedulePeriode.Yearly),
                SubscriptionType.PDF
            );
            if (dbHandler.CreateJob(ref subscription)) subs.Add(subscription);


            // Update GUI status
            int count = 0;
            bool hasError = false;
            string errorText = "";
            foreach (Subscription sub in subs)
            {
                if (sub.ID > 0)
                    count++;
                else {
                    if (hasError) errorText += ", ";
                    errorText += subscription.Periode.ToString();
                    hasError = true;
                }
            }

            if (hasError)
            {
                if (count > 0)
                    toolStripStatusLabel.Text = "Created " + count + " but, Failed to create: " + errorText + " subscription";
                else
                    toolStripStatusLabel.Text = "Failed to create: " + errorText + " subscription";
                toolStripStatusLabel.BackColor = Color.Red;
            }
            else {
                toolStripStatusLabel.Text = "Created " + count + " PDF Subscription(s)";
                toolStripStatusLabel.BackColor = Color.White;
            }

            Helper.RestartService("NRPScheduler", 15 * 1000);

            // Save settings
            saveCustomSettings();
        }

        private void createALL()
        {
            //TODO: Fix toolstripStatusText
            createQuickLinks();
            createSubscription_PDF();
            createSubscription_Printer();
        }

        private void btn_CreateALL_Click(object sender, EventArgs e)
        {
            createALL();
        }
    }



}
