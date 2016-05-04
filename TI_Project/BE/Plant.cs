using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIProject.BE
{
    public class Plant
    {
        private string _Name;
        private string _Case;

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

        public string Case
        {
            get
            {
                return _Case;
            }

            set
            {
                _Case = value;
            }
        }
    }
}
