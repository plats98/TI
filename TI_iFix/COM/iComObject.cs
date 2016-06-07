using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TI.iFix.COM
{
    [ComVisible(true)]
    [Guid("18070F36-8BE8-414E-A832-EE75AA437713")]
    public interface iComObject
    {
        void ShowForm();

        void ChangeValueForm(string name);

        string GetValue();
    }
}
