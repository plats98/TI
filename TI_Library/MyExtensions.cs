using FixDataSystems;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.Library
{
    public static class MyExtensions
    {

        public static string SafeGetString(this OdbcDataReader reader, int colIndex)
        {
            //Debug.Print("" + reader.GetFieldType(colIndex));
            //Debug.Print("" + reader.GetDataTypeName(colIndex));

            if (!reader.IsDBNull(colIndex))
                if (reader.GetFieldType(colIndex) == typeof(String))
                    return reader.GetString(colIndex);
                else // if(reader.GetFieldType(colIndex) == typeof(Single) )
                    return string.Empty;
            else
                return string.Empty;
        }

    }
}
