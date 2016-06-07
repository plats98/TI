using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIProject.BE
{
    public class AI
    {
        private const string _NAME = "AI"; //BLOCK TYPE
        private string _TAG;    //TAG
        private string _NEXT;   //NEXT BLK
        private string _DESC; //DESCRIPTION
        private string _ISCAN = "ON"; //INITIAL SCAN
        private int _SCANT = 1; //SCAN TIME
        private int _SMOTH = 0; //SMOOTHING
        private string _IODV = "MBE"; //I/O DEVICE
        private string _IOHT = "Float"; //H/W OPTIONS
        private string _IOAD; //I/O ADDRESS
        private string _IOSC = "None"; //SIGNAL CONDITIONING
        private string _ELO; //LOW EGU LIMIT
        private string _EHI; //HIGH EGU LIMIT
        private string _EGUDESC; //EGU TAG
        private string _IAM = "AUTO"; //INITIAL A/M STATUS
        private string _IENAB = "DISABLE"; //ALARM ENABLE
        private string _ADI = "NONE"; //ALARM AREA(S)
        private string _LOLO; //LO LO ALARM LIMIT
        private string _LO; //LO ALARM LIMIT
        private string _HI; //HI ALARM LIMIT
        private string _HIHI; //HI HI ALARM LIMIT
        private int _ROC = 0; //ROC ALARM LIMIT
        private int _DBAND = 0; //DEAD BAND
        private string _PRI = "LOW"; //ALARM PRIORITY
        private string _EOUT = "YES"; //ENABLE OUTPUT
        private string _SA1 = "NONE"; //SECURITY AREA 1
        private string _SA2 = "NONE"; //SECURITY AREA 2
        private string _SA3 = "NONE"; //SECURITY AREA 3
        private string _AREA1; //ALARM AREA 1
        private string _AREA2; //ALARM AREA 2
        private string _AREA3; //ALARM AREA 3
        private string _AREA4; //ALARM AREA 4
        private string _AREA5; //ALARM AREA 5
        private string _AREA6; //ALARM AREA 6
        private string _AREA7; //ALARM AREA 7
        private string _AREA8; //ALARM AREA 8
        private string _AREA9; //ALARM AREA 9
        private string _AREA10; //ALARM AREA 10
        private string _AREA11; //ALARM AREA 11
        private string _AREA12; //ALARM AREA 12
        private string _AREA13; //ALARM AREA 13
        private string _AREA14; //ALARM AREA 14
        private string _AREA15; //ALARM AREA 15
        private string _ALMEXT1; //USER FIELD 1
        private string _ALMEXT2; //USER FIELD 2
        private string _ESIGTYPE = "NONE"; //ESIG TYPE
        private string _ESIGCONT = "YES"; //ESIG ALLOW CONT USE
        private string _ESIGACK = "NO"; //ESIG XMPT ALARM ACK
        private string _ESIGTRAP = "REJECT"; //ESIG UNSIGNED WRITES
        private float _PDR_UPDATERATE = 1.000F; //PDR Update Rate
        private float _PDR_ACCESSTIME = 300.000F; //PDR Access Time
        private int _PDR_DEADBAND = 0; //PDR Deadband
        private string _PDR_LATCHDATA = "NO"; //PDR Latch
        private string _PDR_DISABLEOUT = "NO"; //PDR Disable Output
        private int _PDR_ARRAYLENGTH = 0; //PDR Array Length
        private string _HIST_DESC; //Hist Description
        private string _HIST_COLLECT; //Hist Collect
        private float _HIST_INTERVAL = 5000.00F; //Hist Interval
        private int _HIST_OFFSET = 0; //Hist Offset
        private string _HIST_TIMERES = "Milliseconds"; //Hist Time Res
        private string _HIST_COMPRESS; //Hist Compress
        private float _HIST_DEADBAND = 0.01F; //Hist Deadband
        private string _HIST_COMPTYPE = "Absolute"; //Hist Comp Type
        private float _HIST_COMPTIME = 600.000F; //Hist Comp Time
        private string _SCALE_ENABLED = "NO"; //Scale Enabled
        private string _SCALE_CLAMP = "NO"; //Scale Clamping
        private string _SCALE_USEEGU = "NO"; //Scale Use EGU
        private int _SCALE_RAWLOW = 0; //Scale Raw Low
        private int _SCALE_RAWHIGH = 65535; //Scale Raw High
        private int _SCALE_LOW = 0; //Scale Low
        private int _SCALE_HIGH = 65535; //Scale High


        public AI(string desc)
        {
            _DESC = desc;
        }




        #region GET / SET


        public string NAME
        {
            get
            {
                return _NAME;
            }
        }

        public string TAG
        {
            get
            {
                return _TAG;
            }

            set
            {
                _TAG = value;
            }
        }

        public string NEXT
        {
            get
            {
                return _NEXT;
            }

            set
            {
                _NEXT = value;
            }
        }

        public string DESC
        {
            get
            {
                return _DESC;
            }

            set
            {
                _DESC = value;
            }
        }

        public string ISCAN
        {
            get
            {
                return _ISCAN;
            }

            set
            {
                _ISCAN = value;
            }
        }

        public int SCANT
        {
            get
            {
                return _SCANT;
            }

            set
            {
                _SCANT = value;
            }
        }

        public int SMOTH
        {
            get
            {
                return _SMOTH;
            }

            set
            {
                _SMOTH = value;
            }
        }

        public string IODV
        {
            get
            {
                return _IODV;
            }

            set
            {
                _IODV = value;
            }
        }

        public string IOHT
        {
            get
            {
                return _IOHT;
            }

            set
            {
                _IOHT = value;
            }
        }

        public string IOAD
        {
            get
            {
                return _IOAD;
            }

            set
            {
                _IOAD = value;
            }
        }

        public string IOSC
        {
            get
            {
                return _IOSC;
            }

            set
            {
                _IOSC = value;
            }
        }

        public string ELO
        {
            get
            {
                return _ELO;
            }

            set
            {
                _ELO = value;
            }
        }

        public string EHI
        {
            get
            {
                return _EHI;
            }

            set
            {
                _EHI = value;
            }
        }

        public string EGUDESC
        {
            get
            {
                return _EGUDESC;
            }

            set
            {
                _EGUDESC = value;
            }
        }

        public string IAM
        {
            get
            {
                return _IAM;
            }

            set
            {
                _IAM = value;
            }
        }

        public string IENAB
        {
            get
            {
                return _IENAB;
            }

            set
            {
                _IENAB = value;
            }
        }

        public string ADI
        {
            get
            {
                return _ADI;
            }

            set
            {
                _ADI = value;
            }
        }

        public string LOLO
        {
            get
            {
                return _LOLO;
            }

            set
            {
                _LOLO = value;
            }
        }

        public string LO
        {
            get
            {
                return _LO;
            }

            set
            {
                _LO = value;
            }
        }

        public string HI
        {
            get
            {
                return _HI;
            }

            set
            {
                _HI = value;
            }
        }

        public string HIHI
        {
            get
            {
                return _HIHI;
            }

            set
            {
                _HIHI = value;
            }
        }

        public int ROC
        {
            get
            {
                return _ROC;
            }

            set
            {
                _ROC = value;
            }
        }

        public int DBAND
        {
            get
            {
                return _DBAND;
            }

            set
            {
                _DBAND = value;
            }
        }

        public string PRI
        {
            get
            {
                return _PRI;
            }

            set
            {
                _PRI = value;
            }
        }

        public string EOUT
        {
            get
            {
                return _EOUT;
            }

            set
            {
                _EOUT = value;
            }
        }

        public string SA1
        {
            get
            {
                return _SA1;
            }

            set
            {
                _SA1 = value;
            }
        }

        public string SA2
        {
            get
            {
                return _SA2;
            }

            set
            {
                _SA2 = value;
            }
        }

        public string SA3
        {
            get
            {
                return _SA3;
            }

            set
            {
                _SA3 = value;
            }
        }

        public string AREA1
        {
            get
            {
                return _AREA1;
            }

            set
            {
                _AREA1 = value;
            }
        }

        public string AREA2
        {
            get
            {
                return _AREA2;
            }

            set
            {
                _AREA2 = value;
            }
        }

        public string AREA3
        {
            get
            {
                return _AREA3;
            }

            set
            {
                _AREA3 = value;
            }
        }

        public string AREA4
        {
            get
            {
                return _AREA4;
            }

            set
            {
                _AREA4 = value;
            }
        }

        public string AREA5
        {
            get
            {
                return _AREA5;
            }

            set
            {
                _AREA5 = value;
            }
        }

        public string AREA6
        {
            get
            {
                return _AREA6;
            }

            set
            {
                _AREA6 = value;
            }
        }

        public string AREA7
        {
            get
            {
                return _AREA7;
            }

            set
            {
                _AREA7 = value;
            }
        }

        public string AREA8
        {
            get
            {
                return _AREA8;
            }

            set
            {
                _AREA8 = value;
            }
        }

        public string AREA9
        {
            get
            {
                return _AREA9;
            }

            set
            {
                _AREA9 = value;
            }
        }

        public string AREA10
        {
            get
            {
                return _AREA10;
            }

            set
            {
                _AREA10 = value;
            }
        }

        public string AREA11
        {
            get
            {
                return _AREA11;
            }

            set
            {
                _AREA11 = value;
            }
        }

        public string AREA12
        {
            get
            {
                return _AREA12;
            }

            set
            {
                _AREA12 = value;
            }
        }

        public string AREA13
        {
            get
            {
                return _AREA13;
            }

            set
            {
                _AREA13 = value;
            }
        }

        public string AREA14
        {
            get
            {
                return _AREA14;
            }

            set
            {
                _AREA14 = value;
            }
        }

        public string AREA15
        {
            get
            {
                return _AREA15;
            }

            set
            {
                _AREA15 = value;
            }
        }

        public string ALMEXT1
        {
            get
            {
                return _ALMEXT1;
            }

            set
            {
                _ALMEXT1 = value;
            }
        }

        public string ALMEXT2
        {
            get
            {
                return _ALMEXT2;
            }

            set
            {
                _ALMEXT2 = value;
            }
        }

        public string ESIGTYPE
        {
            get
            {
                return _ESIGTYPE;
            }

            set
            {
                _ESIGTYPE = value;
            }
        }

        public string ESIGCONT
        {
            get
            {
                return _ESIGCONT;
            }

            set
            {
                _ESIGCONT = value;
            }
        }

        public string ESIGACK
        {
            get
            {
                return _ESIGACK;
            }

            set
            {
                _ESIGACK = value;
            }
        }

        public string ESIGTRAP
        {
            get
            {
                return _ESIGTRAP;
            }

            set
            {
                _ESIGTRAP = value;
            }
        }

        public float PDR_UPDATERATE
        {
            get
            {
                return _PDR_UPDATERATE;
            }

            set
            {
                _PDR_UPDATERATE = value;
            }
        }

        public float PDR_ACCESSTIME
        {
            get
            {
                return _PDR_ACCESSTIME;
            }

            set
            {
                _PDR_ACCESSTIME = value;
            }
        }

        public int PDR_DEADBAND
        {
            get
            {
                return _PDR_DEADBAND;
            }

            set
            {
                _PDR_DEADBAND = value;
            }
        }

        public string PDR_LATCHDATA
        {
            get
            {
                return _PDR_LATCHDATA;
            }

            set
            {
                _PDR_LATCHDATA = value;
            }
        }

        public string PDR_DISABLEOUT
        {
            get
            {
                return _PDR_DISABLEOUT;
            }

            set
            {
                _PDR_DISABLEOUT = value;
            }
        }

        public int PDR_ARRAYLENGTH
        {
            get
            {
                return _PDR_ARRAYLENGTH;
            }

            set
            {
                _PDR_ARRAYLENGTH = value;
            }
        }

        public string HIST_DESC
        {
            get
            {
                return _HIST_DESC;
            }

            set
            {
                _HIST_DESC = value;
            }
        }

        public string HIST_COLLECT
        {
            get
            {
                return _HIST_COLLECT;
            }

            set
            {
                _HIST_COLLECT = value;
            }
        }

        public float HIST_INTERVAL
        {
            get
            {
                return _HIST_INTERVAL;
            }

            set
            {
                _HIST_INTERVAL = value;
            }
        }

        public int HIST_OFFSET
        {
            get
            {
                return _HIST_OFFSET;
            }

            set
            {
                _HIST_OFFSET = value;
            }
        }

        public string HIST_TIMERES
        {
            get
            {
                return _HIST_TIMERES;
            }

            set
            {
                _HIST_TIMERES = value;
            }
        }

        public string HIST_COMPRESS
        {
            get
            {
                return _HIST_COMPRESS;
            }

            set
            {
                _HIST_COMPRESS = value;
            }
        }

        public float HIST_DEADBAND
        {
            get
            {
                return _HIST_DEADBAND;
            }

            set
            {
                _HIST_DEADBAND = value;
            }
        }

        public string HIST_COMPTYPE
        {
            get
            {
                return _HIST_COMPTYPE;
            }

            set
            {
                _HIST_COMPTYPE = value;
            }
        }

        public float HIST_COMPTIME
        {
            get
            {
                return _HIST_COMPTIME;
            }

            set
            {
                _HIST_COMPTIME = value;
            }
        }

        public string SCALE_ENABLED
        {
            get
            {
                return _SCALE_ENABLED;
            }

            set
            {
                _SCALE_ENABLED = value;
            }
        }

        public string SCALE_CLAMP
        {
            get
            {
                return _SCALE_CLAMP;
            }

            set
            {
                _SCALE_CLAMP = value;
            }
        }

        public string SCALE_USEEGU
        {
            get
            {
                return _SCALE_USEEGU;
            }

            set
            {
                _SCALE_USEEGU = value;
            }
        }

        public int SCALE_RAWLOW
        {
            get
            {
                return _SCALE_RAWLOW;
            }

            set
            {
                _SCALE_RAWLOW = value;
            }
        }

        public int SCALE_RAWHIGH
        {
            get
            {
                return _SCALE_RAWHIGH;
            }

            set
            {
                _SCALE_RAWHIGH = value;
            }
        }

        public int SCALE_LOW
        {
            get
            {
                return _SCALE_LOW;
            }

            set
            {
                _SCALE_LOW = value;
            }
        }

        public int SCALE_HIGH
        {
            get
            {
                return _SCALE_HIGH;
            }

            set
            {
                _SCALE_HIGH = value;
            }
        }

        #endregion
    }
}

