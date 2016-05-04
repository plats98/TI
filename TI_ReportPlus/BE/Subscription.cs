using System;
using TI.ReportPlus.BLL;

namespace TI.ReportPlus.BE
{
    public enum SubscriptionType
    {
        Printer = 0,
        PDF = 1
    }
    public enum SubscriptionPeriode
    {
        Day = 0,
        Week = 1,
        Month = 2,
        Year = 3
    }

    public class Subscription
    {
        private int _ID;
        private CatalogItem _Catalog;
        private int _StartTimeID;
        private int _DuratonID;
        private int _SampleIntervalID;
        private Schedule _Schedule;
        private SubscriptionType _Type;
        private SubscriptionPeriode _Periode;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Catalog"></param>
        /// <param name="Periode"></param>
        /// <param name="Schedule"></param>
        /// <param name="Type"></param>
        public Subscription(CatalogItem Catalog, SubscriptionPeriode Periode, Schedule Schedule, SubscriptionType Type)
        {
            _Catalog = Catalog;
            _Type = Type;
            _Schedule = Schedule;
            this.Periode = Periode;


            switch (Periode)
            {
                case SubscriptionPeriode.Day:
                    if (!Int32.TryParse(Property.Get("NamedTimes_LastDay"), out _StartTimeID)) { } // TODO: The parsing attempt failed
                    if (!Int32.TryParse(Property.Get("NamedIntervals_Day"), out _DuratonID)) { } // TODO: The parsing attempt failed
                    if (!Int32.TryParse(Property.Get("NamedIntervals_Day"), out _SampleIntervalID)) { } // TODO: The parsing attempt failed
                    break;
                case SubscriptionPeriode.Week:
                    if (!Int32.TryParse(Property.Get("NamedTimes_LastWeek"), out _StartTimeID)) { } // TODO: The parsing attempt failed
                    if (!Int32.TryParse(Property.Get("NamedIntervals_Week"), out _DuratonID)) { } // TODO: The parsing attempt failed
                    if (!Int32.TryParse(Property.Get("NamedIntervals_Week"), out _SampleIntervalID)) { } // TODO: The parsing attempt failed
                    break;
                case SubscriptionPeriode.Month:
                    if (!Int32.TryParse(Property.Get("NamedTimes_LastMonth"), out _StartTimeID)) { } // TODO: The parsing attempt failed
                    if (!Int32.TryParse(Property.Get("NamedIntervals_Month"), out _DuratonID)) { } // TODO: The parsing attempt failed
                    if (!Int32.TryParse(Property.Get("NamedIntervals_Month"), out _SampleIntervalID)) { } // TODO: The parsing attempt failed
                    break;
                case SubscriptionPeriode.Year:
                    if (!Int32.TryParse(Property.Get("NamedTimes_LastYear"), out _StartTimeID)) { } // TODO: The parsing attempt failed
                    if (!Int32.TryParse(Property.Get("NamedIntervals_Year"), out _DuratonID)) { } // TODO: The parsing attempt failed
                    if (!Int32.TryParse(Property.Get("NamedIntervals_Year"), out _SampleIntervalID)) { } // TODO: The parsing attempt failed
                    break;
                default:
                    break;
            }
        }

        public CatalogItem Catalog
        {
            get
            {
                return _Catalog;
            }

            set
            {
                _Catalog = value;
            }
        }

        public int StartTimeID
        {
            get
            {
                return _StartTimeID;
            }

            set
            {
                _StartTimeID = value;
            }
        }

        public int DuratonID
        {
            get
            {
                return _DuratonID;
            }

            set
            {
                _DuratonID = value;
            }
        }

        public int SampleIntervalID
        {
            get
            {
                return _SampleIntervalID;
            }

            set
            {
                _SampleIntervalID = value;
            }
        }

        public Schedule Schedule
        {
            get
            {
                return _Schedule;
            }

            set
            {
                _Schedule = value;
            }
        }

        public SubscriptionType Type
        {
            get
            {
                return _Type;
            }

            set
            {
                _Type = value;
            }
        }

        public SubscriptionPeriode Periode
        {
            get
            {
                return _Periode;
            }

            set
            {
                _Periode = value;
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
    }
}
