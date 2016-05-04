using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIProject.BE
{
    public class Area
    {
        private readonly string _GUID;
        private Area _Parrent;
        private string _Description;


        public Area(string guid, string description)
        {
            _GUID = guid;
            _Description = description;
            Parrent = null;
        }

        [JsonConstructor]
        public Area(string guid, string description, Area parrent)
        {
            _GUID = guid;
            _Description = description;
            Parrent = parrent;
        }



        public override string ToString()
        {
            return String.Format("{0}", Description);
        }
        
        public string GUID
        {
            get
            {
                return _GUID;
            }
        }

        public Area Parrent
        {
            get
            {
                return _Parrent;
            }

            set
            {
                _Parrent = value;
            }
        }

        public string Description
        {
            get
            {
                return _Description;
            }

            set
            {
                _Description = value;
            }
        }

    }
}
