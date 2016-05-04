using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.iFix.BE
{
    public class BEChangeLog : BELog
    {
        [DisplayName("Node")]
        public string Node { get; set; }


        public BEChangeLog(string user, string description) : base(user, description)
        {
            StartTime = DateTime.Now.ToString();
        }



    }
}
