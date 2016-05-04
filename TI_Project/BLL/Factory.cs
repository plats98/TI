using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TIProject.BE;
using System.Windows.Forms;
using System.ComponentModel;

namespace TIProject.BLL
{
    internal class Factory
    {
        internal BindingList<string> GetEGU()
        {
            BindingList<string> list = new BindingList<string>();
            list.Add("%");
            list.Add("°C");
            list.Add("A");
            list.Add("bar");
            list.Add("kW");
            list.Add("kWh");
            list.Add("liter");
            list.Add("m / s");
            list.Add("m³");
            list.Add("m³/ h");
            list.Add("min");
            list.Add("mm");
            list.Add("mmVs");
            list.Add("MW");
            list.Add("Nm³");
            list.Add("Pa");
            list.Add("ppm");
            list.Add("timer");
            list.Add("ttmm");
            list.Add("V");
            list.Add("Vol %");
            list.Add("W / m³");

            return list;
        }

        internal BindingList<string> GetBitsPLC()
        {
            BindingList<string> list = new BindingList<string>();

            for (int i = 0; i <= 16; i++)
            {
                list.Add(i.ToString());
            }

            return list;
        }

        internal List<Area> GetAreas(Area area)
        {
            List<Area> list = new List<Area>();

            if (area == null)
            {
                list.Add(new Area(1, "Vejnavn1"));
                list.Add(new Area(2, "Vejnavn2"));
                list.Add(new Area(3, "Vejnavn3"));
                list.Add(new Area(4, "Vejnavn4"));
                list.Add(new Area(5, "Vejnavn5"));
                list.Add(new Area(6, "Vejnavn6"));
                list.Add(new Area(7, "Vejnavn7"));
            }
            else
            {
                list.Add(new Area(1, "Fællesanlæg1"));
                list.Add(new Area(2, "Fællesanlæg2"));
                list.Add(new Area(3, "Fællesanlæg3"));
                list.Add(new Area(4, "Fællesanlæg4"));
                list.Add(new Area(5, "Fællesanlæg5"));
                list.Add(new Area(6, "Fællesanlæg6"));
            }




            return list;
        }

        internal Project LoadList()
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"json.txt"))
                {
                    //List<AnalogSignal> list = (List<AnalogSignal>)JsonConvert.DeserializeObject(sr.ReadToEnd());
                    Project project = (Project)JsonConvert.DeserializeObject(sr.ReadToEnd(), typeof(Project));
                    return project;
                }
            }
            catch (FileNotFoundException e)
            {
                // thrown by StreamReader constructor

                Project project = new Project();
                Save(project);
                return project;
            }
            catch (DirectoryNotFoundException e)
            {
                // thrown by StreamReader constructor
            }
            catch (IOException e)
            {
                // some other fatal IO error occured
            }
            
            return new Project();
        }

        internal void Save(Project project)
        {
            string json = JsonConvert.SerializeObject(project, Formatting.Indented);
            using (StreamWriter sw = new StreamWriter(@"json.txt")) //@"c:\Development\"
            {
                sw.Write(json);
            }
        }
    }





    public static class MemberInfoGetting
    {
        public static string GetMemberName<T>(Expression<Func<T>> memberExpression)
        {
            MemberExpression expressionBody = (MemberExpression)memberExpression.Body;
            return expressionBody.Member.Name;
        }

        static Random rdm = new Random();
        public static double RandomNumber()
        {
            return rdm.NextDouble() * 100;
        }
        public static int RandomInt(int min, int max)
        {
            return rdm.Next(min, max);
        }

        /// <summary>
        /// Determines whether the collection is null or contains no elements.
        /// </summary>
        /// <typeparam name="T">The IEnumerable type.</typeparam>
        /// <param name="enumerable">The enumerable, which may be null or empty.</param>
        /// <returns>
        ///     <c>true</c> if the IEnumerable is null or empty; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                return true;
            }
            /* If this is a list, use the Count property for efficiency. 
             * The Count property is O(1) while IEnumerable.Count() is O(N). */
            var collection = enumerable as ICollection<T>;
            if (collection != null)
            {
                return collection.Count < 1;
            }
            return !enumerable.Any();
        }
    }
}
