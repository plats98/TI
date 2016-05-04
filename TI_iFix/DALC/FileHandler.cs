using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TI.iFix.BE;
using System.Diagnostics;

namespace TI.iFix.DALC
{
    public class FileHandler
    {
        string path = "C:\\Users\\prep\\Desktop\\Logs\\";
        string log = "151011.ALM";

        public FileHandler()
        {
            var typedSequence = from line in ReadFrom(path+log)
                                let items = line.Split(new[] { " " }, StringSplitOptions.None)
                                where !line.StartsWith("#")
                                select String.Format("{0}{1}{2}{3}{4}",
                                    items[1],
                                    items[2],
                                    items[3],
                                    items[4],
                                    items[5]);

            Debug.Print("Fest");
        }


        static IEnumerable<string> ReadFrom(string file)
        {
            string line;
            using (var reader = File.OpenText(file))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }

    }
}
