using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agricultural_Calendar
{
    public class Date
    {
        public int Id { get; set; }
        public DateTime Month1 { get; set; }
        public DateTime Month2 { get; set; }
        public DateTime Month3 { get; set; }
        public DateTime Month4 { get; set; }
        public DateTime Month5 { get; set; }
        public DateTime Month6 { get; set; }
        public DateTime Month7 { get; set; }
        public DateTime Month8 { get; set; }
        public DateTime Month9 { get; set; }
        public DateTime Month10 { get; set; }
        public DateTime Month11 { get; set; }
        public DateTime Month12 { get; set; }

    }


    public class StringDate
    {
        public int Id { get; set; }
        public string Month1 { get; set; }
        public string Month2 { get; set; }
        public string Month3 { get; set; }
        public string Month4 { get; set; }
        public string Month5 { get; set; }
        public string Month6 { get; set; }
        public string Month7 { get; set; }
        public string Month8 { get; set; }
        public string Month9 { get; set; }
        public string Month10 { get; set; }
        public string Month11 { get; set; }
        public string Month12 { get; set; }

    }

    public class DateTimeAgo
    {

        public static string TimeAgo(DateTime dt)
        {
            TimeSpan span = DateTime.Now - dt;
            if (span.Days > 365)
            {
                int years = (span.Days / 365);
                if (span.Days % 365 != 0)
                    years += 1;
                return String.Format("قبل {0} {1} ",
                years, years == 1 ? "عام" : "سنوات");
            }
            if (span.Days > 30)
            {
                int months = (span.Days / 30);
                if (span.Days % 31 != 0)
                    months += 1;
                return String.Format("قبل {0} {1} ",
                months, months == 1 ? "شهر" : "الشهور");
            }
            if (span.Days > 0)
                return String.Format("قبل {0} {1} ",
                span.Days, span.Days == 2 ? "أيام" : " يوم");
            if (span.Hours > 0)
                return String.Format("قبل {0} {1} ",
                span.Hours, span.Hours == 1 ? "ساعة" : "ساعات");
            if (span.Minutes > 0)
                return String.Format("قبل {0} {1} ",
                span.Minutes, span.Minutes == 1 ? "دقيقة" : "الدقائق");
            if (span.Seconds > 5)
                return String.Format(" {0} قبل ثوانى", span.Seconds);
            if (span.Seconds >= 5)
                return "الآن";
            if (span.Days < 0)
                return String.Format("باقي {0} {1} ",
                span.Days, span.Days == 2 ? "أيام" : " يوم");
            if (span.Hours < 0)
                return String.Format("باقي {0} {1} ",
                span.Hours, span.Hours == 1 ? "ساعة" : "ساعات");
            if (span.Minutes < 0)
                return String.Format("باقي {0} {1} ",
                span.Minutes, span.Minutes == 1 ? "دقيقة" : "الدقائق");
            if (span.Seconds < 5)
                return String.Format(" {0} باقي ثوانى", span.Seconds);
            if (span.Seconds >= 5)
                return "الآن";

            return string.Empty;
        }

    }
}



