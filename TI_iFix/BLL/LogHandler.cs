using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI.iFix.BE;

namespace TI.iFix.BLL
{
    public class LogHandler
    {
        public LogHandler()
        {
        }



        public List<BEChangeLog> TestData()
        {
            List<BEChangeLog> logs = new List<BEChangeLog>();

            logs.Add(new BEChangeLog("rasmus", "test 1"));
            logs.Add(new BEChangeLog("plats", "test 2"));
            logs.Add(new BEChangeLog("kasper", "test 3"));
            logs.Add(new BEChangeLog("mikkel", "test 4"));

            return logs;
        }

    }
}
