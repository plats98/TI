using RGiesecke.DllExport;
using System;
using System.Runtime.InteropServices;

namespace TI.iFix.COM
{
    static class UnmanagedExports
    {
        [DllExport]
        [return: MarshalAs(UnmanagedType.IDispatch)]
        static Object TI_Object()
        {
            return new ComObject();
        }
    }
}
