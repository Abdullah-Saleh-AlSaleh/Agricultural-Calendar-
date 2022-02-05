using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Agricultural_Calendar
{
   public  class Heartbeat
    { 
        private readonly System.Timers.Timer _timer;
        public Heartbeat()
        {
            _timer = new System.Timers.Timer(600500) { AutoReset=true};
            _timer.Elapsed += _timer_Elapsed;
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {

            new Task(() => {
                while (true)
                {
                    NotifyIcon notifyIcon1 = new NotifyIcon();
                    CultureInfo AE = CultureInfo.GetCultureInfo("ar-AE");
                    CultureInfo SA = CultureInfo.GetCultureInfo("ar-SA");
                    HijriCalendar hijriCalendar = new HijriCalendar();

                    // string text = DateTime.Now.ToString("yyyy", SA);
                    int NewYear = hijriCalendar.GetYear(Convert.ToDateTime(DateTime.Now.AddYears(1)));

                    int Now = hijriCalendar.GetYear(DateTime.Now);
                    DateTime IFDATE1 = new DateTime(Now, 12, 2, hijriCalendar);
                    DateTime IFDATE2 = new DateTime(Now, 12, 3, hijriCalendar);
                    int IfDates1 = Convert.ToInt32(IFDATE1.ToString("yyyyMMdd"));
                    int IfDates2 = Convert.ToInt32(IFDATE2.ToString("yyyyMMdd"));
                    if (IfDates2 < IfDates1)
                    {

                        DateTime dt1 = new DateTime(NewYear, 1, 1, hijriCalendar);
                        DateTime dt2 = new DateTime(NewYear, 2, 1, hijriCalendar);
                        DateTime dt3 = new DateTime(NewYear, 3, 2, hijriCalendar);
                        DateTime dt4 = new DateTime(NewYear, 4, 1, hijriCalendar);
                        DateTime dt5 = new DateTime(NewYear, 5, 2, hijriCalendar);
                        DateTime dt6 = new DateTime(NewYear, 6, 2, hijriCalendar);
                        DateTime dt7 = new DateTime(NewYear, 7, 2, hijriCalendar);
                        DateTime dt8 = new DateTime(NewYear, 8, 2, hijriCalendar);
                        DateTime dt9 = new DateTime(NewYear, 9, 1, hijriCalendar);
                        DateTime dt10 = new DateTime(NewYear, 10, 1, hijriCalendar);
                        DateTime dt11 = new DateTime(NewYear, 11, 1, hijriCalendar);
                        DateTime dt12 = new DateTime(NewYear, 12, 1, hijriCalendar);


                        var Date1 = new List<Date>()
            {
                new Date(){Id=1,Month1=dt1,Month2=dt2,Month3=dt3,Month4=dt4,Month5=dt5,Month6=dt6,Month7=dt7,Month8=dt8,Month9=dt9,Month10=dt10,Month11=dt11,Month12=dt12}


            };

                        foreach (var item in Date1)
                        {

                            int DateNow, ToInt1, ToInt2, ToInt3, ToInt4, ToInt5, ToInt6, ToInt7, ToInt8, ToInt9, ToInt10, ToInt11, ToInt12;
                            DateNow = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));
                            ToInt1 = Convert.ToInt32(item.Month1.ToString("yyyyMMdd"));
                            ToInt2 = Convert.ToInt32(item.Month2.ToString("yyyyMMdd"));
                            ToInt3 = Convert.ToInt32(item.Month3.ToString("yyyyMMdd"));
                            ToInt4 = Convert.ToInt32(item.Month4.ToString("yyyyMMdd"));
                            ToInt5 = Convert.ToInt32(item.Month5.ToString("yyyyMMdd"));
                            ToInt6 = Convert.ToInt32(item.Month6.ToString("yyyyMMdd"));
                            ToInt7 = Convert.ToInt32(item.Month7.ToString("yyyyMMdd"));
                            ToInt8 = Convert.ToInt32(item.Month8.ToString("yyyyMMdd"));
                            ToInt9 = Convert.ToInt32(item.Month9.ToString("yyyyMMdd"));
                            ToInt10 = Convert.ToInt32(item.Month10.ToString("yyyyMMdd"));
                            ToInt11 = Convert.ToInt32(item.Month11.ToString("yyyyMMdd"));
                            ToInt12 = Convert.ToInt32(item.Month12.ToString("yyyyMMdd"));


                            if (DateNow == ToInt1)
                            {

                                //this.Hide();
                                notifyIcon1.ShowBalloonTip(1000, item.Month1.ToString("MMM"), "شهر جديد ", ToolTipIcon.Info);
                            }
                            if (DateNow == ToInt2)
                            {
                                //  this.Hide();

                                notifyIcon1.ShowBalloonTip(1000, item.Month2.ToString("MMM"), "فلفل ", ToolTipIcon.Info);
                            }
                            if (DateNow == ToInt3)
                            {
                                //  this.Hide();
                                notifyIcon1.ShowBalloonTip(1000, item.Month3.ToString("MMM"), "الملوخية,شمام ", ToolTipIcon.Info);
                            }
                            if (DateNow == ToInt4)
                            {
                                //  this.Hide();
                                notifyIcon1.ShowBalloonTip(1000, item.Month4.ToString("MMM"), "شهر جديد  ", ToolTipIcon.Info);
                            }
                            if (DateNow == ToInt5)
                            {
                                // this.Hide();
                                notifyIcon1.ShowBalloonTip(1000, item.Month5.ToString("MMM"), "الملوخية ", ToolTipIcon.Info);
                            }
                            if (DateNow == ToInt6)
                            {
                                //this.Hide();
                                notifyIcon1.ShowBalloonTip(1000, item.Month6.ToString("MMM"), "شهر جديد  ", ToolTipIcon.Info);
                            }
                            if (DateNow == ToInt7)
                            {
                                //  this.Hide();
                                notifyIcon1.ShowBalloonTip(1000, item.Month7.ToString("MMM"), "شهر جديد  ", ToolTipIcon.Info);
                            }
                            if (DateNow == ToInt8)
                            {
                                //this.Hide();
                                notifyIcon1.ShowBalloonTip(1000, item.Month8.ToString("MMM"), "الفراولة,خيار,الزهرة,الملفوف", ToolTipIcon.Info);
                            }
                            if (DateNow == ToInt9)
                            {
                                // this.Hide();
                                notifyIcon1.ShowBalloonTip(1000, item.Month9.ToString("MMM"), "طماطم و باذنجان و فلفل ", ToolTipIcon.Info);
                            }
                            if (DateNow == ToInt10)
                            {
                                // this.Hide();
                                notifyIcon1.ShowBalloonTip(1000, item.Month10.ToString("MMM"), "كزبرة بقدونس ", ToolTipIcon.Info);
                            }
                            if (DateNow == ToInt11)
                            {
                                //  this.Hide();
                                notifyIcon1.ShowBalloonTip(1000, item.Month11.ToString("MMM"), "شمندر سبائخ ", ToolTipIcon.Info);
                            }
                            if (DateNow == ToInt12)
                            {
                                //  this.Hide();
                                notifyIcon1.ShowBalloonTip(1000, item.Month12.ToString("MMM"), "شهر جديد  ", ToolTipIcon.Info);
                            }

                        }
                    }
                }
            
            
            });

      

        }
        public void Start()
        {
            _timer.Start();
        }
        public void Stop()
        {
            _timer.Stop(); 
        }
    }
}
