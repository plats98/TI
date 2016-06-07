using FixDataSystems;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI.Library;

namespace TI.Library
{
    public class FixTester
    {
        public FixTester()
        {

        }

        public void Test2()
        {
            String connStr = "DSN=FIX Dynamics Real Time Data;Uid=sa";

            OdbcConnection DbConnection = new OdbcConnection(connStr);

            try
            {
                DbConnection.Open();
            }
            catch (OdbcException ex)
            {
                Debug.Print("connection to the DSN '" + connStr + "' failed.");
                Debug.Print("The OdbcConnection returned the following message");
                Debug.Print(ex.Message);
                return;
            }

            String query = "SELECT * FROM SCADA01";
            OdbcCommand DbCommand = DbConnection.CreateCommand();
            DbCommand.CommandText = query;

            OdbcDataReader DbReader;
            try
            {
                DbReader = DbCommand.ExecuteReader();
                // rest of the code to process the result set
            }
            catch (OdbcException ex)
            {
                Debug.Print("Executing the query '" + query + "' failed.");
                Debug.Print("The OdbcCommand returned the following message");
                Debug.Print(ex.Message);
                return;
            }

            int fCount = DbReader.FieldCount;
            Debug.Print("");
            for (int i = 0; i < fCount; i++)
            {
                String fName = DbReader.GetName(i);
                Debug.Print(fName + ":");
            }
            Debug.Print("");



            while (DbReader.Read())
            {
                String col = "";
                for (int i = 0; i < fCount; i++)
                {
                    col = col + DbReader.SafeGetString(i) + " : ";
                }
                Debug.Print(col + "");
                Debug.Print("");
            }


            DbReader.Close();
            DbCommand.Dispose();
            DbConnection.Close();
        }

        
        public void FDS()
        {
            // Create the Data System OCX
            FixDataSystem fixDataSystem = new FixDataSystem();

            // Get the servers collection
            DataServers dataServers = fixDataSystem.DataServers;
            Debug.Print("FixDataSystem.DataServers.Count: {" + dataServers.Count + "}");

            // Get the groups collection
            Groups groups = fixDataSystem.Groups;
            Debug.Print("FixDataSystem.Groups.Count: {" + groups.Count + "}");



            // Get server info
            foreach (DataServer dataServer in dataServers)
            {
                Debug.Print("FixDataSystem.DataServers.DataServer.DefaultServer: {" + dataServer.DefaultServer + "}");
                Debug.Print("FixDataSystem.DataServers.DataServer.Name: {" + dataServer.Name + "}");
                Debug.Print("FixDataSystem.DataServers.DataServer.OpcAccessPath: {" + dataServer.OpcAccessPath + "}");
                Debug.Print("FixDataSystem.DataServers.DataServer.OpcDataSource: {" + dataServer.OpcDataSource + "}");
                Debug.Print("FixDataSystem.DataServers.DataServer.OpcProgID: {" + dataServer.OpcProgID + "}");
                Debug.Print("FixDataSystem.DataServers.DataServer.OpcServerMachineName: {" + dataServer.OpcServerMachineName + "}");
            }




            // Add a group to the Groups collection
            Group group = groups.Add("DataGroup1");
            Debug.Print("FixDataSystem.Groups.Group.Name: {" + group.Name + "}");


            DataItems dataItems = group.DataItems;
            Debug.Print("FixDataSystem.Groups.Group.DataItems.Count: {" + dataItems.Count + "}");

            DataItem dataItem = dataItems.Add("Fix32.SCADA01.SMS_BLOKERINGS_TID.A_DESC");
            Debug.Print("Reading from iFix database before (READ)");
            ReadDataItem(dataItem);

            foreach (DataItem dataItem2 in dataItems)
            {
                dataItem2.Value = 1;
            }
            group.Write();


            dataItem.Read();
            Debug.Print("Reading from iFix database after (READ)");
            ReadDataItem(dataItem);

            dataItem.Write("Rasmus");
            Debug.Print("Reading from iFix database after (WRITE)");
            dataItem.Read();
            ReadDataItem(dataItem);
        }

        public void ReadDataItem(DataItem dataItem)
        {
            Debug.Print("FixDataSystem.Groups.Group.DataItems.dataItem.Name: {" + dataItem.Name + "}");
            Debug.Print("FixDataSystem.Groups.Group.DataItems.dataItem.Quality: {" + dataItem.Quality + "}");
            Debug.Print("FixDataSystem.Groups.Group.DataItems.dataItem.Timestamp: {" + dataItem.Timestamp + "}");
            string value = "Empty";
            try
            {
                value = "" + dataItem.Value;
            }
            catch (Exception)
            {

                throw;
            }

            if (string.IsNullOrWhiteSpace(value))
                value = "Empty";
            Debug.Print("FixDataSystem.Groups.Group.DataItems.dataItem.Value: {" + value + "}");
        }
    }
}
