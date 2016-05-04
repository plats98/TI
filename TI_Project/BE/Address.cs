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
            string word = "";
            switch (_WordType)
            {
                case WORDTYPE.INT:
                    word = "MW";
                    break;
                case WORDTYPE.DINT:
                    word = "MD";
                    break;
                case WORDTYPE.FLOAT:
                    word = "MF";
                    break;
                case WORDTYPE.BOOL:
                    word = "M";
                    break;
                default:
                    word = "ERR";
                    break;
            }

            string bit = "";
            if (_Bit != -1)
                bit = String.Format(":{0}", _Bit);


            return String.Format("{0}, {1}{2}{3}",
                Enum.GetName(typeof(DEVICETYPE), _DeviceType),
                word,
                _Address,
                bit
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
