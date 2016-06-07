using System;
using TI.ReportPlus.BLL;

namespace TI.ReportPlus.BE
{
    public class QuickLink
    {
        private Guid _GUID;
        private string _Name;
        private string _Description;
        private int _StartTime;
        private int _Duration;
        private int _Interval;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="GUID"></param>
        /// <param name="Name"></param>
        /// <param name="Description"></param>
        public QuickLink(Guid GUID, int index)
        {
            this._GUID = GUID;


            if (index < 1)
                throw new IndexOutOfRangeException();


            string number = "";
            if (index < 10)
                number = "0" + index.ToString();
            else
                number = index.ToString();



            this._Name = Property.Get("QuickLink_"+ number+"_Name");
            this._Description = Property.Get("QuickLink_" + number + "_Desc");

            if (!Int32.TryParse(Property.Get(Property.Get("QuickLink_" + number + "_Time")), out this._StartTime))
            {
                // TODO: The parsing attempt failed
            }
            if (!Int32.TryParse(Property.Get(Property.Get("QuickLink_" + number + "_Interval")), out this._Duration))
            {
                // TODO: The parsing attempt failed
            }
            if (!Int32.TryParse(Property.Get(Property.Get("QuickLink_" + number + "_Interval")), out this._Interval))
            {
                // TODO: The parsing attempt failed
            }
        }

        public Guid GUID
        {
            get
            {
                return _GUID;
            }

            set
            {
                _GUID = value;
            }
        }

        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }
        }

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

        public int StartTime
        {
            get
            {
                return _StartTime;
            }

            set
            {
                _StartTime = value;
            }
        }

        public int Duration
        {
            get
            {
                return _Duration;
            }

            set
            {
                _Duration = value;
            }
        }

        public int Interval
        {
            get
            {
                return _Interval;
            }

            set
            {
                _Interval = value;
            }
        }
    }
}
