using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Diagnostics;

namespace TI.iFix.BLL
{
    public static class iFix
    {

        public static void Test2()
        {
            String connStr = "DSN=FIX Dynamics Real Time Data;Uid=sa";

            OdbcConnection DbConnection = new OdbcConnection(connStr);

            try
            {
                DbConnection.Open();
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("connection to the DSN '" + connStr + "' failed.");
                Console.WriteLine("The OdbcConnection returned the following message");
                Console.WriteLine(ex.Message);
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
                Console.WriteLine("Executing the query '" + query + "' failed.");
                Console.WriteLine("The OdbcCommand returned the following message");
                Console.WriteLine(ex.Message);
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
                    col = col + SafeGetString(DbReader, i)+ " : " ;
                }
                Debug.Print(col + "");
                Debug.Print("");
            }
            

            DbReader.Close();
            DbCommand.Dispose();
            DbConnection.Close();
        }


        public static string SafeGetString(this OdbcDataReader reader, int colIndex)
        {
            //Debug.Print("" + reader.GetFieldType(colIndex));
            //Debug.Print("" + reader.GetDataTypeName(colIndex));

            if (!reader.IsDBNull(colIndex))
                if(reader.GetFieldType(colIndex) == typeof(String) )
                    return reader.GetString(colIndex);
                else // if(reader.GetFieldType(colIndex) == typeof(Single) )
                    return string.Empty;
            else
                return string.Empty;
        }


    }
}
