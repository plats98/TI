using log4net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using TI.ReportPlus.BE;
using TI.ReportPlus.DALC;

//'internal' control what expensive promises Method A is making about features, lifetime, compatibility, and so on. 


namespace TI.ReportPlus.BLL
{
    public class DBHandler
    {
        ILog log = LogManager.GetLogger(typeof(DBHandler));
        Database db = new Database();

        private List<CatalogItem> catalogs = null;
        private List<string> printers = null;


        public List<CatalogItem> GetCatalogs()
        {
            return db.GetCatalogs();
        }

        internal int CreateLinks(CatalogItem ci)
        {
            QuickLink ql;
            int count = -1;
            bool success = true;

            if (!Int32.TryParse(Property.Get("QuickLink_Count"), out count))
            {
                // TODO: The parsing attempt failed
            }

            if (count <= 1)
                return count;

            for (int i = 1; i <= count; i++)
            {
                if (success == false)
                    return i;

                ql = new QuickLink(ci.ItemID, i);
                success = db.CreateQuickLink(ql);
            }
            return count;
        }

        public List<string> GetPrinters()
        {
            List<string> list = new List<string>();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                Debug.Print(printer);
                list.Add(printer);
            }
            LogPrinterData();
            return list;
        }

        private void LogPrinterData()
        {
            var printerQuery = new System.Management.ManagementObjectSearcher("SELECT * from Win32_Printer");
            foreach (var printer in printerQuery.Get())
            {
                var name = printer.GetPropertyValue("Name");
                var status = printer.GetPropertyValue("Status");
                var isDefault = printer.GetPropertyValue("Default");
                var isNetworkPrinter = printer.GetPropertyValue("Network");

                Debug.Print("{0} (Status: {1}, Default: {2}, Network: {3})",
                            name, status, isDefault, isNetworkPrinter);
            }

        }

        internal bool CreateJob(ref Subscription subscription, string printer)
        {
            if (db.CreateSchedule(ref subscription))
                if (db.CreateSubscription(ref subscription))
                    if (CreateSubscriptionSettings(subscription, printer))
                        return true;
            return false;
        }

        internal bool CreateJob(ref Subscription subscription)
        {
            if (db.CreateSchedule(ref subscription))
                if (db.CreateSubscription(ref subscription))
                    if (CreateSubscriptionSettings(subscription))
                        return true;
            return false;
        }

        private bool CreateSubscriptionSettings(Subscription subscription, string printer)
        {
            if (String.IsNullOrWhiteSpace(printer))
                printer = Property.Get("Setting_PrinterPath");

            return db.CreateSubscriptionSetting(subscription.ID, "PrinterPath", printer);
        }

        private bool CreateSubscriptionSettings(Subscription subscription)
        {
            bool success = true;

            switch (subscription.Periode)
            {
                case SubscriptionPeriode.Day:
                    if (success) success = db.CreateSubscriptionSetting(subscription.ID, "FileName", "DagsRapport");
                    if (success) success = db.CreateSubscriptionSetting(subscription.ID, "FilePath", "D:\\Rapporter\\Dagsrapporter");
                    break;
                case SubscriptionPeriode.Week:
                    if (success) success = db.CreateSubscriptionSetting(subscription.ID, "FileName", "UgeRapport");
                    if (success) success = db.CreateSubscriptionSetting(subscription.ID, "FilePath", "D:\\Rapporter\\Ugerapporter");
                    break;
                case SubscriptionPeriode.Month:
                    if (success) success = db.CreateSubscriptionSetting(subscription.ID, "FileName", "MaanedsRapport");
                    if (success) success = db.CreateSubscriptionSetting(subscription.ID, "FilePath", "D:\\Rapporter\\Maanedsrapporter");
                    break;
                case SubscriptionPeriode.Year:
                    if (success) success = db.CreateSubscriptionSetting(subscription.ID, "FileName", "AarsRapport");
                    if (success) success = db.CreateSubscriptionSetting(subscription.ID, "FilePath", "D:\\Rapporter\\Aarsrapporter");
                    break;
                default:
                    break;
            }

            if (success) success = db.CreateSubscriptionSetting(subscription.ID, "FileFormat", "PDF");
            if (success) success = db.CreateSubscriptionSetting(subscription.ID, "UserName", "administrator");
            if (success) success = db.CreateSubscriptionSetting(subscription.ID, "Password", "Ko86PVMHw64=");
            if (success) success = db.CreateSubscriptionSetting(subscription.ID, "AppendDate", "true");

            return success;
        }
    }
}

