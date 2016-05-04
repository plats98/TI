using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIProject.BE
{
    public class Area
    {
        private int _ID;
        private string _Name;
        
        public Area(int ID, string Name)
        {
            _ID = ID;
            _Name = Name;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} ", _ID, _Name);
        }

        public int ID
        {
            get
            {
                return _ID;
            }

            set
            {
                _ID = value;
            }
        }

        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }
        }
        
    }
}
