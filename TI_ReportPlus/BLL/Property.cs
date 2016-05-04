using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TI.ReportPlus.BLL
{
    public static class Property
    {
        private static Object _lock = new Object();
        private static SortedDictionary<string, string> list;
        private static string filename = "TI_CONF.ini";

        static Property()
        {
            Property.Reload();
        }

        public static SortedDictionary<string, string> GetList()
        {
            return list;
        }

        public static string Get(string field, string defaultValue)
        {
            return (Get(field) == null) ? (defaultValue) : (Get(field));
        }

        public static string Get(string field)
        {
            return (list.ContainsKey(field)) ? (list[field]) : (null);
        }

        public static void Set(string field, Object value)
        {
            if (!list.ContainsKey(field))
                list.Add(field, value.ToString());
            else
                list[field] = value.ToString();
        }

        public static void Save()
        {
            Save(Property.filename);
        }

        public static void Save(string filename)
        {
            Property.filename = filename;

            lock (_lock)
            {
                using (FileStream fs = File.Create(filename)) { }

                using (StreamWriter file = new StreamWriter(filename))
                {
                    foreach (string prop in list.Keys.ToArray()) { 
                     //   if (!String.IsNullOrWhiteSpace(list[prop]))
                            file.WriteLine(prop + "=" + list[prop]);
                    }
                }

            }
        }

        public static void Reload()
        {
            Reload(Property.filename);
        }

        public static void Reload(string filename)
        {
            Property.filename = filename;
            list = new SortedDictionary<string, string>();

            lock (_lock)
            {
                if (File.Exists(filename))
                    LoadFromFile(filename);
                else
                    using (FileStream fs = File.Create(filename)) { }
            }
        }

        private static void LoadFromFile(string file)
        {
            lock (_lock)
            {
                foreach (string line in File.ReadAllLines(file))
                {
                    if ((!string.IsNullOrEmpty(line)) &&
                        (!line.StartsWith(";")) &&
                        (!line.StartsWith("#")) &&
                        (!line.StartsWith("'")) &&
                        (line.Contains('=')))
                    {
                        int index = line.IndexOf('=');
                        string key = line.Substring(0, index).Trim();
                        string value = line.Substring(index + 1).Trim();

                        if ((value.StartsWith("\"") && value.EndsWith("\"")) ||
                            (value.StartsWith("'") && value.EndsWith("'")))
                        {
                            value = value.Substring(1, value.Length - 2);
                        }

                        try
                        {
                            //ignore dublicates
                            list.Add(key, value);
                        }
                        catch { }
                    }
                }
            }
        }


    }
}
