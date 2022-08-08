using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agricultural_Calendar
{
    

    public class db
    {
        public static List<StringDate> stringDate;

       // public static List<StringDate> StringDates { get; set;}
        public static List<Date> GetDates()
        {
            CultureInfo CurrentCulture = CultureInfo.GetCultureInfo("ar-AE");
            CultureInfo SA = CultureInfo.GetCultureInfo("ar-SA");
            HijriCalendar hijri1 = new HijriCalendar();
            GregorianCalendar gregorianCalendar = new GregorianCalendar();  
            string text = DateTime.Now.ToString("yyyy", CurrentCulture);
            int m = Convert.ToInt32(text);
            DateTime date = DateTime.Now;
            int Now = hijri1.GetYear(date);           
            string Addhijri1 = hijri1.AddYears(DateTime.Now, 1).ToString("yyyy");
            DateTime IFDATE1 = DateTime.Now;
            DateTime IFDATE2 = new DateTime(m, 12, 28);
            int IfDates1 = Convert.ToInt32(IFDATE1.ToString("yyyyMMdd"));
            int IfDates2 = Convert.ToInt32(IFDATE2.ToString("yyyyMMdd"));
            if (IfDates1 > IfDates2)
            {
                HijriCalendar hijri = new HijriCalendar();
                //int NewYears = Convert.ToInt32(AddYears);
                int NewYears = Convert.ToInt32(Addhijri1);
                DateTime dt1 = new DateTime(Now, 1, 2, 16, 00, 00, hijri1);
                DateTime dt2 = new DateTime(Now, 2, 1, 16, 00, 00, hijri1);
                DateTime dt3 = new DateTime(Now, 3, 2, 16, 00, 00, hijri1);
                DateTime dt4 = new DateTime(Now, 4, 1, 16, 00, 00, hijri1);
                DateTime dt5 = new DateTime(Now, 5, 2, 16, 00, 00, hijri1);
                DateTime dt6 = new DateTime(Now, 6, 2, 16, 00, 00, hijri1);
                DateTime dt7 = new DateTime(Now, 7, 2, 16, 00, 00, hijri1);
                DateTime dt8 = new DateTime(Now, 8, 2, 16, 00, 00, hijri1);
                DateTime dt9 = new DateTime(Now, 9, 1, 16, 00, 00, hijri1);
                DateTime dt10 = new DateTime(Now, 10, 1, 16, 00, 00, hijri1);
                DateTime dt11 = new DateTime(Now, 11, 1, 16, 00, 00, hijri1);
                DateTime dt12 = new DateTime(Now, 12, 1, 16, 00, 00, hijri1);
                
                var Data1 = new List<Date>()
            {
                new Date(){Id=1,dateTime=dt1,Text = ""},
                new Date(){Id=2,dateTime=dt2,Text = " فلفل"},
                new Date(){Id=3,dateTime=dt3,Text = "الملوخية,شمام"},
                new Date(){Id=4,dateTime=dt4,Text = ""},
                new Date(){Id=5,dateTime=dt5,Text = "الملوخية"},
                new Date(){Id=6,dateTime=dt6,Text = ""},
                new Date(){Id=7,dateTime=dt7,Text = ""},
                new Date(){Id=8,dateTime=dt8,Text = " الفراولة,خيار,الزهرة,الملفوف"},
                new Date(){Id=9,dateTime=dt9,Text = "طماطم و باذنجان و فلفل"},
                new Date(){Id=10,dateTime=dt10,Text = " كزبرة بقدونس "},
                new Date(){Id=11,dateTime=dt11,Text = " شمندر سبائخ"},
                new Date(){Id=12,dateTime=dt12,Text = ""},



            };
                return Data1;
            }
            else
            {
                DateTime dt1 = new DateTime(Now, 1, 2, 16, 00, 00, hijri1);
                DateTime dt2 = new DateTime(Now, 2, 1, 16, 00, 00, hijri1);
                DateTime dt3 = new DateTime(Now, 3, 2, 16, 00, 00, hijri1);
                DateTime dt4 = new DateTime(Now, 4, 1, 16, 00, 00, hijri1);
                DateTime dt5 = new DateTime(Now, 5, 2, 16, 00, 00, hijri1);
                DateTime dt6 = new DateTime(Now, 6, 2, 16, 00, 00, hijri1);
                DateTime dt7 = new DateTime(Now, 7, 2, 16, 00, 00, hijri1);
                DateTime dt8 = new DateTime(Now, 8, 2, 16, 00, 00, hijri1);
                DateTime dt9 = new DateTime(Now, 9, 1, 16, 00, 00, hijri1);
                DateTime dt10 = new DateTime(Now, 10, 1, 16, 00, 00, hijri1);
                DateTime dt11 = new DateTime(Now, 11, 1, 16, 00, 00, hijri1);
                DateTime dt12 = new DateTime(Now, 12, 1,16,00,00, hijri1);
                var Data1 = new List<Date>()
            {
                new Date(){Id=1,dateTime=dt1,Text = ""},
                new Date(){Id=2,dateTime=dt2,Text = " فلفل"},
                new Date(){Id=3,dateTime=dt3,Text = "الملوخية,شمام"},
                new Date(){Id=4,dateTime=dt4,Text = ""},
                new Date(){Id=5,dateTime=dt5,Text = "الملوخية"},
                new Date(){Id=6,dateTime=dt6,Text = ""},
                new Date(){Id=7,dateTime=dt7,Text = ""},
                new Date(){Id=8,dateTime=dt8,Text = " الفراولة,خيار,الزهرة,الملفوف"},
                new Date(){Id=9,dateTime=dt9,Text = "طماطم و باذنجان و فلفل"},
                new Date(){Id=10,dateTime=dt10,Text = " كزبرة بقدونس "},
                new Date(){Id=11,dateTime=dt11,Text = " شمندر سبائخ"},
                new Date(){Id=12,dateTime=dt12,Text = ""},



            };
                return Data1;
            }
        }
        public static List<StringDate> GetStrings()
        {
            stringDate = new List<StringDate>();
            foreach (var item in db.GetDates())
            {
                var Date1 = DateTimeAgo.TimeAgo(item.dateTime);




                stringDate.Add(new StringDate() { Id = item.Id, dateTime = Date1.Replace("-", " ") ,Text=item.Text});

            }
            return stringDate;  
       

        }

    }
    public class Date
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime dateTime { get; set; }
       

    }


    public class StringDate
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string dateTime { get; set; }

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





