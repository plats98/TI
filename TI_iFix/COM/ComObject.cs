using RGiesecke.DllExport;
using System;
using System.Runtime.InteropServices;
using TI.iFix.GUI;

namespace TI.iFix.COM
{
    [Guid("9E7777B5-BCA9-4395-BAA5-28DF6BCA3AE6")]
    [ComVisible(true), ClassInterface(ClassInterfaceType.None)]
    public class ComObject : iComObject
    {

        [return: MarshalAs(UnmanagedType.BStr)]
        public string MessageFromTI(string message)
        {
            return new TI().MessageFromTI(message);
        }


        public string GetValue()
        {
            return new TI().GetValue();
        }

        public void ShowForm()
        {
            new TI().showForm();
        }

        public void ChangeValueForm(string name)
        {
            ChangeValue cv = new ChangeValue();
            cv.Text = name;
            cv.ShowDialog();
        }

    }

}
