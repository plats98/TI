using TI.iFix.GUI;
using System.Runtime.InteropServices;
using TI.iFix.BE;

namespace TI.iFix.COM
{
    public class TI
    {
        public LogList gui;


        public TI()
        {
            gui = new LogList();
        }


        public string MessageFromTI(string message)
        {
            message = "Your message is alted by a DLL: " + message;
            return message;
        }

        public string GetValue()
        {
            return gui.getValue();
        }

        public void showForm()
        {
            gui.ShowDialog();
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MyStruct
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public string[] s1;
        }

        public object[] GetStringArray()
        {
            string[] fiskArr = { "fisk1", "fisk2", "fisk3" };
            object[] arr = { "arr1", "arr2", "arr3", "arr4", fiskArr };

            return arr;
        }

        /*
        [return: MarshalAs(UnmanagedType.IDispatch)]
        public BETest GetCustomObject()
        {
            BETest test = new BETest();

            return test;
        }
        */
    }
}