using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleTester
{
    class Program
    {
        static void Main(string[] args)
        {
            // ConsoleTester

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TI.iFix.GUI.AppletViewer());
            
        }
    }
}
