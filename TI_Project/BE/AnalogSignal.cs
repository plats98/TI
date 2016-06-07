using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIProject.BLL;

namespace TIProject.BE
{
    public class AnalogSignal
    {
        private string _KKS;
        private PLC_Address _Address;
        private Area _Area1;
        private Area _Area2;
        private Area _Area3; 
        private string _Description;
        private bool _LowHigh;
        private bool _LowLowHighHigh;
        private string _EGU;
        private bool _Historian;

        public AnalogSignal()
        {
            _Address = new PLC_Address();
            //_KKS = "KKS: " + MemberInfoGetting.RandomNumber();
            //_EGU = new Factory().GetEGU()[MemberInfoGetting.RandomInt(0, new Factory().GetEGU().Count-1)];
        }

        [DisplayName("KKS")]
        [Browsable(true)]
        [ReadOnly(true)]
        public string KKS
        {
            get
            {
                return _KKS;
            }

            set
            {
                _KKS = value;
            }
        }

        [DisplayName("Address")]
        [Browsable(true)]
        public PLC_Address Address
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

        [DisplayName("Beskrivelse")]
        [Browsable(true)]
        public string Description
        {
            get
            {
                return _Description;
            }

            set
            {
                _Description = value;
            }
        }

        [DisplayName("Lav / Høj")]
        [Browsable(true)]
        public bool LowHigh
        {
            get
            {
                return _LowHigh;
            }

            set
            {
                _LowHigh = value;
            }
        }

        [DisplayName("LavLav / HøjHøj")]
        [Browsable(true)]
        public bool LowLowHighHigh
        {
            get
            {
                return _LowLowHighHigh;
            }

            set
            {
                _LowLowHighHigh = value;
            }
        }

        [DisplayName("EGU")]
        [Browsable(false)]
        public string EGU
        {
            get
            {
                return _EGU;
            }

            set
            {
                _EGU = value;
            }
        }

        [DisplayName("Historian")]
        [Browsable(true)]
        public bool Historian
        {
            get
            {
                return _Historian;
            }

            set
            {
                _Historian = value;
            }
        }
        
        [Browsable(false)]
        public Area Area1
        {
            get
            {
                return _Area1;
            }

            set
            {
                _Area1 = value;
            }
        }
        
        [Browsable(false)]
        public Area Area2
        {
            get
            {
                return _Area2;
            }

            set
            {
                _Area2 = value;
            }
        }
        
        [Browsable(false)]
        public Area Area3
        {
            get
            {
                return _Area3;
            }

            set
            {
                _Area3 = value;
            }
        }
    }
}

