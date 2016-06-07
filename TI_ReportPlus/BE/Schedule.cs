using System;
using TI.ReportPlus.BLL;

namespace TI.ReportPlus.BE
{
    public enum SchedulePeriode
    {
        Daily = 0,
        Weekly = 1,
        Monthly = 2,
        Yearly = 3,
        Trigged = 4
    }

    public class Schedule
    {
        private int _ID;
        private string _Name;
        private int _RecurrencyType;
        private DateTime _Interval;
        private DateTime _StartTime = DateTime.Now;
        private DateTime _EndTime = DateTime.Now;
        private DateTime _LastRun = DateTime.Now;
        private DateTime _NextRun = DateTime.Now;
        private int _DaysOfWeek = 127; // Value for all days in a week (Bit value)
        private int _DaysOfMonth = 1;
        private bool _LastDayOfMonth = false;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="StartTime"></param>
        /// <param name="Periode"></param>
        public Schedule(DateTime StartTime, SchedulePeriode Periode)
        {
            _StartTime = new DateTime(StartTime.Year, StartTime.Month, StartTime.Day, StartTime.Hour, StartTime.Minute, StartTime.Second, StartTime.Kind);
            _NextRun = new DateTime(StartTime.Year, StartTime.Month, StartTime.Day, StartTime.Hour, StartTime.Minute, StartTime.Second, StartTime.Kind);


            switch (Periode)
            {
                case SchedulePeriode.Daily:
                    if (!Int32.TryParse(Property.Get("RecurrencyType_Daily"), out _RecurrencyType)) { } // TODO: The parsing attempt failed
                    break;
                case SchedulePeriode.Weekly:
                    if (!Int32.TryParse(Property.Get("RecurrencyType_Weekly"), out _RecurrencyType)) { } // TODO: The parsing attempt failed
                    break;
                case SchedulePeriode.Monthly:
                    if (!Int32.TryParse(Property.Get("RecurrencyType_Monthly"), out _RecurrencyType)) { } // TODO: The parsing attempt failed
                    break;
                case SchedulePeriode.Yearly:
                    if (!Int32.TryParse(Property.Get("RecurrencyType_Yearly"), out _RecurrencyType)) { } // TODO: The parsing attempt failed
                    break;
                case SchedulePeriode.Trigged:
                    if (!Int32.TryParse(Property.Get("RecurrencyType_Trigged"), out _RecurrencyType)) { } // TODO: The parsing attempt failed
                    break;
                default:
                    break;
            }



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

        public int RecurrencyType
        {
            get
            {
                return _RecurrencyType;
            }

            set
            {
                _RecurrencyType = value;
            }
        }

        public DateTime Interval
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

        public DateTime StartTime
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

        public DateTime EndTime
        {
            get
            {
                return _EndTime;
            }

            set
            {
                _EndTime = value;
            }
        }

        public DateTime LastRun
        {
            get
            {
                return _LastRun;
            }

            set
            {
                _LastRun = value;
            }
        }

        public DateTime NextRun
        {
            get
            {
                return _NextRun;
            }

            set
            {
                _NextRun = value;
            }
        }

        public int DaysOfWeek
        {
            get
            {
                return _DaysOfWeek;
            }

            set
            {
                _DaysOfWeek = value;
            }
        }

        public int DaysOfMonth
        {
            get
            {
                return _DaysOfMonth;
            }

            set
            {
                _DaysOfMonth = value;
            }
        }

        public bool LastDayOfMonth
        {
            get
            {
                return _LastDayOfMonth;
            }

            set
            {
                _LastDayOfMonth = value;
            }
        }
    }
}
