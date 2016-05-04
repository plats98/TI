using TI.ReportPlus.BE;
using TI.ReportPlus.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TI.ReportPlus.GUI
{
    public partial class MainView : Form
    {
        private DBHandler dbHandler = new DBHandler();

        public MainView()
        {
            InitializeComponent();
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
            backgroundWorker.RunWorkerAsync();

            CatalogItem catalog = dbHandler.GetCatalogs().Where(c => c.Name.Equals(cb_catalogs.SelectedItem)).FirstOrDefault();
            string printer = dbHandler.GetPrinters().Where(p => p.Equals(cb_printers.SelectedItem)).FirstOrDefault();
            DateTime datetime = datePicker_Printer.Value.Date + timePicker_Printer.Value.TimeOfDay;

            // init variables
            List<Subscription> subs = new List<Subscription>();
            Subscription subscription;

            // Create subscription (Daily)
            subscription = new Subscription(
                catalog,
                SubscriptionPeriode.Day,
                new Schedule(datetime, SchedulePeriode.Daily),
                SubscriptionType.Printer
            );
            if (dbHandler.CreateJob(ref subscription, printer)) subs.Add(subscription);

            // Create subscription (Monthly)
            subscription = new Subscription(
                catalog,
                SubscriptionPeriode.Month,
                new Schedule(datetime, SchedulePeriode.Monthly),
                SubscriptionType.Printer
            );
            if (dbHandler.CreateJob(ref subscription, printer)) subs.Add(subscription);

            // Create subscription (Yearly)
            subscription = new Subscription(
                catalog,
                SubscriptionPeriode.Year,
                new Schedule(datetime, SchedulePeriode.Yearly),
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
        }

        private void btn_PDF_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();

            CatalogItem catalog = dbHandler.GetCatalogs().Where(c => c.Name.Equals(cb_catalogs.SelectedItem)).FirstOrDefault();
            DateTime datetime = datePicker_Printer.Value.Date + timePicker_Printer.Value.TimeOfDay;

            // init variables
            List<Subscription> subs = new List<Subscription>();
            Subscription subscription;

            // Create subscription (Daily)
            subscription = new Subscription(
                catalog,
                SubscriptionPeriode.Day,
                new Schedule(datetime, SchedulePeriode.Daily),
                SubscriptionType.PDF
            );
            if (dbHandler.CreateJob(ref subscription)) subs.Add(subscription);

            // Create subscription (Monthly)
            subscription = new Subscription(
                catalog,
                SubscriptionPeriode.Month,
                new Schedule(datetime, SchedulePeriode.Monthly),
                SubscriptionType.PDF
            );
            if (dbHandler.CreateJob(ref subscription)) subs.Add(subscription);

            // Create subscription (Yearly)
            subscription = new Subscription(
                catalog,
                SubscriptionPeriode.Year,
                new Schedule(datetime, SchedulePeriode.Yearly),
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
        }

        private void btn_QuickLink_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();

            CatalogItem ci = dbHandler.GetCatalogs().Where(c => c.Name.Equals(cb_catalogs.SelectedItem)).FirstOrDefault();

            if (ci != null)
            {
                toolStripStatusLabel.Text = "Created " + dbHandler.CreateLinks(ci) + " Quicklink(s) on " + ci.Name;
            }
        }

        private void toolStripStatusLabel_TextChanged(object sender, EventArgs e)
        {
            timerStatusLabel.Interval = 10*1000;
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
            for (int j = 1; j < 100000; j++)
            {
                backgroundWorker.ReportProgress((j * 100) / 100000);
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
            new Settings().Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpProvider.GetShowHelp(this);
        }
    }



}
