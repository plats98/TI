using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TI.iFix.BE
{
    //[ComVisible(true), ClassInterface(ClassInterfaceType.None)]
    public class BELog
    {
        [DisplayName("Start tid")]
        public string StartTime { get; set; }
        [DisplayName("Bruger")]
        public string User { get; set; }
        [DisplayName("Område 1")]
        public string Area1 { get; set; }
        [DisplayName("Område 2")]
        public string Area2 { get; set; }
        [DisplayName("Beskrivelse")]
        public string Description { get; set; }

        public BELog()
        {
            // Empty constructor
        }

        public BELog(string user, string description)
        {
            this.User           = user;
            this.Description    = description;
        }

    }
}
