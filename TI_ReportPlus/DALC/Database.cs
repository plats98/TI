using TI.ReportPlus.BE;
using TI.ReportPlus.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using log4net;

namespace TI.ReportPlus.DALC
{
    internal class Database
    {
        ILog log = LogManager.GetLogger(typeof(Database));

        internal List<CatalogItem> GetCatalogs()
        {

            // In a using statement, acquire the SqlConnection
            using (SqlConnection con = new SqlConnection(Helper.CONNECTION_SQL_REPORTS))
            {
                // Open the SqlConnection.
                con.Open();


                string query = "" +
                    "SELECT " +
                        "ItemID, " +
                        "ParentID, " +
                        "Name, " +
                        "Description " +
                    "FROM " +
                        "Catalog " +
                    "WHERE " +
                        "ParentID='0AF5E0A1-FDFB-4600-B447-6926EB1A3B76'"; //Reports


                List<CatalogItem> reportList = new List<CatalogItem>();

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Guid itemID = Helper.SafeGetGUID(reader, "ItemID");
                            Guid parentID = Helper.SafeGetGUID(reader, "ParentID");
                            string name = Helper.SafeGetString(reader, "Name");
                            string description = Helper.SafeGetString(reader, "Description");

                            Debug.Print(itemID + " " + parentID + " name:" + name + " " + description);

                            reportList.Add(new CatalogItem(itemID, parentID, name, description));
                            log.Info(itemID + " " + parentID + " name:" + name + " " + description);
                        }
                        return reportList;
                    }
                }
            }
        }

        internal bool CreateQuickLink(QuickLink QL)
        {
            // In a using statement, acquire the SqlConnection
            using (SqlConnection con = new SqlConnection(Helper.CONNECTION_NOVOTEK_REPORTPLUS))
            {
                // Open the SqlConnection.
                con.Open();

                string query = ""
                + "INSERT INTO QuickLinks("
                    + "ReportId, "
                    + "Name, "
                    + "Description, "
                    + "StartTimeId, "
                    + "DurationId, "
                    + "SampleIntervalId) "
                + "VALUES("
                    + "@ReportId, "
                    + "@Name, "
                    + "@Description, "
                    + "@StartTimeId, "
                    + "@DurationId, "
                    + "@SampleIntervalId)";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@ReportId", QL.GUID);
                    command.Parameters.AddWithValue("@Name", QL.Name);
                    command.Parameters.AddWithValue("@Description", QL.Description);
                    command.Parameters.AddWithValue("@StartTimeId", QL.StartTime);
                    command.Parameters.AddWithValue("@DurationId", QL.Duration);
                    command.Parameters.AddWithValue("@SampleIntervalId", QL.Interval);

                    //Rows affected
                    return command.ExecuteNonQuery() > 0 ? true : false;
                }
            }
        }

        internal bool CreateSubscriptionSetting(int ID, string key, string value)
        {
            // In a using statement, acquire the SqlConnection
            using (SqlConnection con = new SqlConnection(Helper.CONNECTION_NOVOTEK_REPORTPLUS))
            {
                // Open the SqlConnection.
                con.Open();

                string query = ""
                + "INSERT INTO SubscriptionSettings("
                    + "SubscriptionId, "
                    + "SettingName, "
                    + "SettingValue) "
                + "VALUES("
                    + "@SubscriptionId, "
                    + "@SettingName, "
                    + "@SettingValue)";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@SubscriptionId", ID);
                    command.Parameters.AddWithValue("@SettingName", key);
                    command.Parameters.AddWithValue("@SettingValue", value);

                    //Rows affected
                    return command.ExecuteNonQuery() > 0 ? true : false;
                }
            }
        }

        internal bool CreateSchedule(ref Subscription subscription)
        {
            // In a using statement, acquire the SqlConnection
            using (SqlConnection con = new SqlConnection(Helper.CONNECTION_NOVOTEK_REPORTPLUS))
            {
                // Open the SqlConnection.
                con.Open();

                string query = ""
                    + "INSERT INTO Schedules("
                        + "Name, "
                        + "StartTime, "
                        + "RecurrencyType, "
                        //+ "Interval, "
                        + "DaysOfWeek, "
                        + "DaysOfMonth, "
                        + "EndTime, "
                        + "LastRun, "
                        + "NextRun, "
                        + "LastDayOfMonth) "
                    + "OUTPUT INSERTED.ID "
                    + "VALUES("
                        + "@Name, "
                        + "@StartTime, "
                        + "@RecurrencyType, "
                        //+ "@Interval, "
                        + "@DaysOfWeek, "
                        + "@DaysOfMonth, "
                        + "@EndTime, "
                        + "@LastRun, "
                        + "@NextRun, "
                        + "@LastDayOfMonth)";



                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Name", subscription.Schedule.Name);
                    command.Parameters.AddWithValue("@StartTime", subscription.Schedule.StartTime);
                    command.Parameters.AddWithValue("@RecurrencyType", subscription.Schedule.RecurrencyType);
                    //command.Parameters.AddWithValue("@Interval", subscription.Schedule.Interval);
                    command.Parameters.AddWithValue("@DaysOfWeek", subscription.Schedule.DaysOfWeek);
                    command.Parameters.AddWithValue("@DaysOfMonth", subscription.Schedule.DaysOfMonth);
                    command.Parameters.AddWithValue("@EndTime", subscription.Schedule.EndTime);
                    command.Parameters.AddWithValue("@LastRun", subscription.Schedule.LastRun);
                    command.Parameters.AddWithValue("@NextRun", subscription.Schedule.NextRun);
                    command.Parameters.AddWithValue("@LastDayOfMonth", subscription.Schedule.LastDayOfMonth);

                    foreach (SqlParameter parameter in command.Parameters)
                    {
                        if (parameter.Value == null)
                        {
                            parameter.Value = DBNull.Value;
                        }
                    }

                    // Get primary key
                    subscription.Schedule.ID = (int)command.ExecuteScalar();

                    if (subscription.Schedule.ID > 0)
                        return true;
                    else
                        return false;
                }

            }

        }


        internal bool CreateSubscription(ref Subscription subscription)
        {
            // In a using statement, acquire the SqlConnection
            using (SqlConnection con = new SqlConnection(Helper.CONNECTION_NOVOTEK_REPORTPLUS))
            {
                // Open the SqlConnection.
                con.Open();

                string query = ""
                    + "INSERT INTO Subscriptions("
                        + "ReportId, "
                        + "StartTimeId, "
                        + "DurationId, "
                        + "SampleIntervalId, "
                        + "ScheduleId, "
                        + "Type) "
                    + "OUTPUT INSERTED.ID "
                    + "VALUES("
                        + "@ReportId, "
                        + "@StartTimeId, "
                        + "@DurationId, "
                        + "@SampleIntervalId, "
                        + "@ScheduleId, "
                        + "@Type)";


                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@ReportId", subscription.Catalog.ItemID);
                    command.Parameters.AddWithValue("@StartTimeId", subscription.StartTimeID);
                    command.Parameters.AddWithValue("@DurationId", subscription.DuratonID);
                    command.Parameters.AddWithValue("@SampleIntervalId", subscription.SampleIntervalID);
                    command.Parameters.AddWithValue("@ScheduleId", subscription.Schedule.ID);
                    command.Parameters.AddWithValue("@Type", subscription.Type);

                    // Get primary key
                    subscription.ID = (int)command.ExecuteScalar();

                    if (subscription.ID > 0)
                        return true;
                    else
                        return false;
                }

            }

        }

        
    }
}
