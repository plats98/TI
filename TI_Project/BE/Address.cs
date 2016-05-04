using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIProject.BE
{
    public enum WORDTYPE
    {
        INT = 0,
        DINT = 1,
        FLOAT = 2,
        BOOL = 3
    }

    public enum DEVICETYPE
    {
        STB = 0,
        PL7 = 1,
        UNITY = 2,
        OPC = 3
    }

    public class PLC_Address
    {
        private int _ID;
        private WORDTYPE _WordType;
        private DEVICETYPE _DeviceType;
        private int _Address;
        private int _Bit;
        private string _DeviceName;
        private string _DeviceIP;


        public PLC_Address()
        {

        }

        public override string ToString()
        {
            return String.Format("{0}, {1} {2}:{3}",
                Enum.GetName(typeof(DEVICETYPE), _DeviceType),
                Enum.GetName(typeof(WORDTYPE), _WordType),
                _Address,
                _Bit
            );
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

        public WORDTYPE WordType
        {
            get
            {
                return _WordType;
            }

            set
            {
                _WordType = value;
            }
        }

        public DEVICETYPE DeviceType
        {
            get
            {
                return _DeviceType;
            }

            set
            {
                _DeviceType = value;
            }
        }

        public int Address
        {
            get
            {
                return _Address;
            }

            set
            {
                _Address = value;
            }
        }

        public int Bit
        {
            get
            {
                return _Bit;
            }

            set
            {
                _Bit = value;
            }
        }

        public string DeviceName
        {
            get
            {
                return _DeviceName;
            }

            set
            {
                _DeviceName = value;
            }
        }

        public string DeviceIP
        {
            get
            {
                return _DeviceIP;
            }

            set
            {
                _DeviceIP = value;
            }
        }



    }
}
