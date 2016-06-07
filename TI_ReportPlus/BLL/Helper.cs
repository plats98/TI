using System;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceProcess;

namespace TI.ReportPlus.BLL
{
    public static class Helper
    {
        public static string CONNECTION_SQL_REPORTS = "";
        public static string CONNECTION_NOVOTEK_REPORTPLUS = "";

        internal static void Setup()
        {
            DefaultProperties();

            CONNECTION_SQL_REPORTS = "" +
               "Data Source=" + Property.Get("SQL_REPORT_Server") + ";" +
               "Initial Catalog=" + Property.Get("SQL_REPORT_Database") + ";" +
               "User id=" + Property.Get("SQL_REPORT_User") + ";" +
               "Password=" + Property.Get("SQL_REPORT_Password") + ";";

            CONNECTION_NOVOTEK_REPORTPLUS = "" +
               "Data Source=" + Property.Get("NRP_REPORT_Server") + ";" +
               "Initial Catalog=" + Property.Get("NRP_REPORT_Database") + ";" +
               "User id=" + Property.Get("NRP_REPORT_User") + ";" +
               "Password=" + Property.Get("NRP_REPORT_Password") + ";";
        }

        private static void DefaultProperties()
        {
            // System info
            Property.Set("SQL_REPORT_Server", Property.Get("SQL_REPORT_Server", "SCADA01"));
            Property.Set("SQL_REPORT_Database", Property.Get("SQL_REPORT_Database", "ReportServer$SQLEXPRESS"));
            Property.Set("SQL_REPORT_User", Property.Get("SQL_REPORT_User", "ti"));
            Property.Set("SQL_REPORT_Password", Property.Get("SQL_REPORT_Password", "ti"));

            Property.Set("NRP_REPORT_Server", Property.Get("NRP_REPORT_Server", "SCADA01"));
            Property.Set("NRP_REPORT_Database", Property.Get("NRP_REPORT_Database", "NovotekReportPlusConfiguration"));
            Property.Set("NRP_REPORT_User", Property.Get("NRP_REPORT_User", "ti"));
            Property.Set("NRP_REPORT_Password", Property.Get("NRP_REPORT_Password", "ti"));

            Property.Set("LoggerLevel_INFO", Property.Get("LoggerLevel_INFO", true.ToString()));
            Property.Set("LoggerLevel_WARN", Property.Get("LoggerLevel_WARN", false.ToString()));
            Property.Set("LoggerLevel_DEBUG", Property.Get("LoggerLevel_DEBUG", false.ToString()));

            // Subscription Settings
            Property.Set("Setting_PrinterPath", Property.Get("Setting_PrinterPath", new DBHandler().GetPrinters().FirstOrDefault()));

            // SQL - namedTimes
            Property.Set("NamedTimes_LastHour", Property.Get("NamedTimes_LastHour", "1001"));
            Property.Set("NamedTimes_LastDay", Property.Get("NamedTimes_LastDay", "1"));
            Property.Set("NamedTimes_LastWeek", Property.Get("NamedTimes_LastWeek", "2"));
            Property.Set("NamedTimes_LastMonth", Property.Get("NamedTimes_LastMonth", "5"));
            Property.Set("NamedTimes_LastYear", Property.Get("NamedTimes_LastYear", "8"));
            Property.Set("NamedTimes_ThisDay", Property.Get("NamedTimes_ThisDay", "4"));
            Property.Set("NamedTimes_ThisWeek", Property.Get("NamedTimes_ThisWeek", "3"));
            Property.Set("NamedTimes_ThisMonth", Property.Get("NamedTimes_ThisMonth", "6")); 
            Property.Set("NamedTimes_ThisYear", Property.Get("NamedTimes_ThisYear", "7"));

            // SQL - NamedIntervals
            Property.Set("NamedIntervals_Minute", Property.Get("NamedIntervals_Minute", "6"));
            Property.Set("NamedIntervals_Hour", Property.Get("NamedIntervals_Hour", "5"));
            Property.Set("NamedIntervals_Day", Property.Get("NamedIntervals_Day", "1"));
            Property.Set("NamedIntervals_Week", Property.Get("NamedIntervals_Week", "2"));
            Property.Set("NamedIntervals_Month", Property.Get("NamedIntervals_Month", "3"));
            Property.Set("NamedIntervals_Year", Property.Get("NamedIntervals_Year", "4"));

            // SQL - RecurrencyType
            Property.Set("RecurrencyType_Daily", Property.Get("RecurrencyType_Daily", "1"));
            Property.Set("RecurrencyType_Weekly", Property.Get("RecurrencyType_Weekly", "2"));
            Property.Set("RecurrencyType_Monthly", Property.Get("RecurrencyType_Monthly", "3"));
            Property.Set("RecurrencyType_Yearly", Property.Get("RecurrencyType_Yearly", "4"));
            Property.Set("RecurrencyType_Trigged", Property.Get("RecurrencyType_Trigged", "5"));

            // SQL - SubscriptionType
            Property.Set("SubscriptionType_Print", Property.Get("SubscriptionType_Print", "0"));
            Property.Set("SubscriptionType_File", Property.Get("SubscriptionType_File", "1"));

            //Quicklinks
            Property.Set("QuickLink_Count", Property.Get("QuickLink_Count", "9"));

            Property.Set("QuickLink_01_Name", Property.Get("QuickLink_01_Name", "1. Sidste time"));
            Property.Set("QuickLink_01_Desc", Property.Get("QuickLink_01_Desc", ""));
            Property.Set("QuickLink_01_Time", Property.Get("QuickLink_01_Time", "NamedTimes_LastHour"));
            Property.Set("QuickLink_01_Interval", Property.Get("QuickLink_01_Interval", "NamedIntervals_Hour"));

            Property.Set("QuickLink_02_Name", Property.Get("QuickLink_02_Name", "2. I går"));
            Property.Set("QuickLink_02_Desc", Property.Get("QuickLink_02_Desc", ""));
            Property.Set("QuickLink_02_Time", Property.Get("QuickLink_02_Time", "NamedTimes_LastDay"));
            Property.Set("QuickLink_02_Interval", Property.Get("QuickLink_02_Interval", "NamedIntervals_Day"));

            Property.Set("QuickLink_03_Name", Property.Get("QuickLink_03_Name", "3. I dag"));
            Property.Set("QuickLink_03_Desc", Property.Get("QuickLink_03_Desc", ""));
            Property.Set("QuickLink_03_Time", Property.Get("QuickLink_03_Time", "NamedTimes_ThisDay"));
            Property.Set("QuickLink_03_Interval", Property.Get("QuickLink_03_Interval", "NamedIntervals_Day"));

            Property.Set("QuickLink_04_Name", Property.Get("QuickLink_04_Name", "4. Sidste uge"));
            Property.Set("QuickLink_04_Desc", Property.Get("QuickLink_04_Desc", ""));
            Property.Set("QuickLink_04_Time", Property.Get("QuickLink_04_Time", "NamedTimes_LastWeek"));
            Property.Set("QuickLink_04_Interval", Property.Get("QuickLink_04_Interval", "NamedIntervals_Week"));

            Property.Set("QuickLink_05_Name", Property.Get("QuickLink_05_Name", "5. Denne uge"));
            Property.Set("QuickLink_05_Desc", Property.Get("QuickLink_05_Desc", ""));
            Property.Set("QuickLink_05_Time", Property.Get("QuickLink_05_Time", "NamedTimes_ThisWeek"));
            Property.Set("QuickLink_05_Interval", Property.Get("QuickLink_05_Interval", "NamedIntervals_Week"));

            Property.Set("QuickLink_06_Name", Property.Get("QuickLink_06_Name", "6. Sidste måned"));
            Property.Set("QuickLink_06_Desc", Property.Get("QuickLink_06_Desc", ""));
            Property.Set("QuickLink_06_Time", Property.Get("QuickLink_06_Time", "NamedTimes_LastMonth"));
            Property.Set("QuickLink_06_Interval", Property.Get("QuickLink_06_Interval", "NamedIntervals_Month"));

            Property.Set("QuickLink_07_Name", Property.Get("QuickLink_07_Name", "7. Denne måned"));
            Property.Set("QuickLink_07_Desc", Property.Get("QuickLink_07_Desc", ""));
            Property.Set("QuickLink_07_Time", Property.Get("QuickLink_07_Time", "NamedTimes_ThisMonth"));
            Property.Set("QuickLink_07_Interval", Property.Get("QuickLink_07_Interval", "NamedIntervals_Month"));

            Property.Set("QuickLink_08_Name", Property.Get("QuickLink_08_Name", "8. Sidste år"));
            Property.Set("QuickLink_08_Desc", Property.Get("QuickLink_08_Desc", ""));
            Property.Set("QuickLink_08_Time", Property.Get("QuickLink_08_Time", "NamedTimes_LastYear"));
            Property.Set("QuickLink_08_Interval", Property.Get("QuickLink_08_Interval", "NamedIntervals_Year"));

            Property.Set("QuickLink_09_Name", Property.Get("QuickLink_09_Name", "9. Dette år"));
            Property.Set("QuickLink_09_Desc", Property.Get("QuickLink_09_Desc", ""));
            Property.Set("QuickLink_09_Time", Property.Get("QuickLink_09_Time", "NamedTimes_ThisYear"));
            Property.Set("QuickLink_09_Interval", Property.Get("QuickLink_09_Interval", "NamedIntervals_Year"));

            Property.Set("QuickLink_10_Name", Property.Get("QuickLink_10_Name", ""));
            Property.Set("QuickLink_10_Desc", Property.Get("QuickLink_10_Desc", ""));
            Property.Set("QuickLink_10_Time", Property.Get("QuickLink_10_Time", ""));
            Property.Set("QuickLink_10_Interval", Property.Get("QuickLink_10_Interval", ""));

            Property.Set("QuickLink_11_Name", Property.Get("QuickLink_11_Name", ""));
            Property.Set("QuickLink_11_Desc", Property.Get("QuickLink_11_Desc", ""));
            Property.Set("QuickLink_11_Time", Property.Get("QuickLink_11_Time", ""));
            Property.Set("QuickLink_11_Interval", Property.Get("QuickLink_11_Interval", ""));

            Property.Set("QuickLink_12_Name", Property.Get("QuickLink_12_Name", ""));
            Property.Set("QuickLink_12_Desc", Property.Get("QuickLink_12_Desc", ""));
            Property.Set("QuickLink_12_Time", Property.Get("QuickLink_12_Time", ""));
            Property.Set("QuickLink_12_Interval", Property.Get("QuickLink_12_Interval", ""));

            // Printer
            Property.Set("Printer_TimeOfDay", Property.Get("Printer_TimeOfDay", "05:00:00"));
            Property.Set("Printer_Date", Property.Get("Printer_Date", DateTime.Now.Date.ToString()));
            Property.Set("Printer_Interval", Property.Get("Printer_Interval", "15"));

            // PDF
            Property.Set("PDF_TimeOfDay", Property.Get("PDF_TimeOfDay", "06:00:00")); //DateTime.Now.TimeOfDay.ToString()
            Property.Set("PDF_Date", Property.Get("PDF_Date", DateTime.Now.Date.ToString()));
            Property.Set("PDF_Interval", Property.Get("PDF_Interval", "15"));


            Property.Save();
        }

        public static Guid SafeGetGUID(this SqlDataReader reader, string colName)
        {
            int colIndex = reader.GetOrdinal(colName);

            if (!reader.IsDBNull(colIndex))
                return reader.GetGuid(colIndex);
            else
                return Guid.Empty;
        }

        public static string SafeGetString(this SqlDataReader reader, string colName)
        {
            int colIndex = reader.GetOrdinal(colName);

            if (!reader.IsDBNull(colIndex))
                return reader.GetString(colIndex);
            else
                return string.Empty;
        }

        public static int SafeGetInt(this SqlDataReader reader, string colName)
        {
            int colIndex = reader.GetOrdinal(colName);

            if (!reader.IsDBNull(colIndex))
                return reader.GetInt32(colIndex);
            else
                return -1;
        }


        public static void RestartService(string serviceName, int timeoutMilliseconds)
        {
            // https://msdn.microsoft.com/en-us/library/system.serviceprocess.servicecontroller.aspx
            ServiceController service = new ServiceController(serviceName);
            try
            {
                int millisec1 = Environment.TickCount;
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);

                // count the rest of the timeout
                int millisec2 = Environment.TickCount;
                timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds - (millisec2 - millisec1));

                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
            }
            catch
            {
                // ...
            }
        }

    }
}
