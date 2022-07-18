using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Topshelf;

namespace Agricultural_Calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
      
        
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CultureInfo CurrentCulture = CultureInfo.GetCultureInfo("ar-AE");
            CultureInfo SA = CultureInfo.GetCultureInfo("ar-SA");
            HijriCalendar hijri1 = new HijriCalendar();
            string text = DateTime.Now.ToString("yyyy", CurrentCulture);
            int m = Convert.ToInt32(text);
            DateTime date = DateTime.Now;
            int Now = hijri1.GetYear(date);
           datey.Text= DateTime.Now.ToString("yyyy", CurrentCulture) +"-"+ hijri1.GetYear(DateTime.Now).ToString();
            T1.Text = "";

            T2.Text = " فلفل";
            T3.Text = "الملوخية,شمام";
            T4.Text = "";
            T5.Text = "الملوخية";
            T6.Text = "";
            T7.Text = "";
            T8.Text = " الفراولة,خيار,الزهرة,الملفوف";
            T9.Text = "طماطم و باذنجان و فلفل";
            T10.Text = " كزبرة بقدونس ";
            T11.Text = " شمندر سبائخ";
            T12.Text = "";
            /*
            CultureInfo CurrentCulture = CultureInfo.GetCultureInfo("ar-AE");
            string text = DateTime.Now.ToString("yyyy", CurrentCulture);
            int Now = Convert.ToInt32(text);
            string AddYears = DateTime.Now.AddYears(1).ToString("yyyy", CurrentCulture);
            DateTime IFDATE1 = DateTime.Now;
            DateTime IFDATE2 = new DateTime(Now, 12, 28);
            */
            
            //string AddYears = DateTime.Now.AddYears(1).ToString("yyyy", CurrentCulture);
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
                DateTime dt1 = new DateTime(NewYears, 1, 2, hijri);
                DateTime dt2 = new DateTime(NewYears, 2, 1, hijri);
                DateTime dt3 = new DateTime(NewYears, 3, 2, hijri);
                DateTime dt4 = new DateTime(NewYears, 4, 1, hijri);
                DateTime dt5 = new DateTime(NewYears, 5, 2, hijri);
                DateTime dt6 = new DateTime(NewYears, 6, 2, hijri);
                DateTime dt7 = new DateTime(NewYears, 7, 2, hijri);
                DateTime dt8 = new DateTime(NewYears, 8, 2, hijri);
                DateTime dt9 = new DateTime(NewYears, 9, 1, hijri);
                DateTime dt10 = new DateTime(NewYears, 10, 1, hijri);
                DateTime dt11 = new DateTime(NewYears, 11, 1, hijri);
                DateTime dt12 = new DateTime(NewYears, 12, 1, hijri);
                var Data1 = new List<Date>()
            {
                new Date(){Id=1,Month1=dt1,Month2=dt2,Month3=dt3,Month4=dt4,Month5=dt5,Month6=dt6,Month7=dt7,Month8=dt8,Month9=dt9,Month10=dt10,Month11=dt11,Month12=dt12}


            };
            foreach (var item in Data1)
            {
                    Month1.Text = item.Month1.ToString("MMM", SA) + "(" + item.Month1.ToString("MMM", CurrentCulture) + ")";
                    Month2.Text = item.Month2.ToString("MMM", SA) + "(" + item.Month2.ToString("MMM", CurrentCulture) + ")";
                    Month3.Text = item.Month3.ToString("MMM", SA) + "(" + item.Month3.ToString("MMM", CurrentCulture) + ")";
                    Month4.Text = item.Month4.ToString("MMM", SA) + "(" + item.Month4.ToString("MMM", CurrentCulture) + ")";
                    Month5.Text = item.Month5.ToString("MMM", SA) + "(" + item.Month5.ToString("MMM", CurrentCulture) + ")";
                    Month6.Text = item.Month6.ToString("MMM", SA) + "(" + item.Month6.ToString("MMM", CurrentCulture) + ")";
                    Month7.Text = item.Month7.ToString("MMM", SA) + "(" + item.Month7.ToString("MMM", CurrentCulture) + ")";
                    Month8.Text = item.Month8.ToString("MMM", SA) + "(" + item.Month8.ToString("MMM", CurrentCulture) + ")";
                    Month9.Text = item.Month9.ToString("MMM", SA) + "(" + item.Month9.ToString("MMM", CurrentCulture) + ")";
                    Month10.Text = item.Month10.ToString("MMM", SA) + "(" + item.Month10.ToString("MMM", CurrentCulture) + ")";
                    Month11.Text = item.Month11.ToString("MMM", SA) + "(" + item.Month11.ToString("MMM", CurrentCulture) + ")";
                    Month12.Text = item.Month12.ToString("MMM", SA) + "(" + item.Month12.ToString("MMM", CurrentCulture) + ")";


                    var Date1 = DateTimeAgo.TimeAgo(item.Month1);
                var Date2 = DateTimeAgo.TimeAgo(item.Month2);
                var Date3 = DateTimeAgo.TimeAgo(item.Month3);
                var Date4 = DateTimeAgo.TimeAgo(item.Month4);
                var Date5 = DateTimeAgo.TimeAgo(item.Month5);
                var Date6 = DateTimeAgo.TimeAgo(item.Month6);
                var Date7 = DateTimeAgo.TimeAgo(item.Month7);
                var Date8 = DateTimeAgo.TimeAgo(item.Month8);
                var Date9 = DateTimeAgo.TimeAgo(item.Month9);
                var Date10 = DateTimeAgo.TimeAgo(item.Month10);
                var Date11 = DateTimeAgo.TimeAgo(item.Month11);
                var Date12 = DateTimeAgo.TimeAgo(item.Month12);
                var StringDate = new List<StringDate>()
            {
                new StringDate {
                    Id=1,Month1=Date1.Replace("-", " "),Month2=Date2.Replace("-", " "),Month3= Date3.Replace("-", " "),Month4= Date4.Replace("-", " "),Month5=Date5.Replace("-", " "),Month6=Date6.Replace("-", " "),Month7 =Date7.Replace("-", " "),Month8=Date8.Replace("-", " "),Month9=Date9.Replace("-", " "),Month10=Date10.Replace("-", " "),Month11=Date11.Replace("-", " "),Month12=Date12.Replace("-", " ")
                }


            };
                foreach (var item1 in StringDate)
                {
                    D1.Text = item1.Month1;
                    D2.Text = item1.Month2;
                    D3.Text = item1.Month3;
                    D4.Text = item1.Month4;
                    D5.Text = item1.Month5;
                    D6.Text = item1.Month6;
                    D7.Text = item1.Month7;
                    D8.Text = item1.Month8;
                    D9.Text = item1.Month9;
                    D10.Text = item1.Month10;
                    D11.Text = item1.Month11;
                    D12.Text = item1.Month12;
                }
            }
        }
            else
            {
                DateTime dt1 = new DateTime(Now, 1, 2, hijri1);
                DateTime dt2 = new DateTime(Now, 2, 1, hijri1);
                DateTime dt3 = new DateTime(Now, 3, 2, hijri1);
                DateTime dt4 = new DateTime(Now, 4, 1, hijri1);
                DateTime dt5 = new DateTime(Now, 5, 2, hijri1);
                DateTime dt6 = new DateTime(Now, 6, 2, hijri1);
                DateTime dt7 = new DateTime(Now, 7, 2, hijri1);
                DateTime dt8 = new DateTime(Now, 8, 2, hijri1);
                DateTime dt9 = new DateTime(Now, 9, 1, hijri1);
                DateTime dt10 = new DateTime(Now, 10, 1, hijri1);
                DateTime dt11 = new DateTime(Now, 11, 1, hijri1);
                DateTime dt12 = new DateTime(Now, 12, 1, hijri1);
                var Data1 = new List<Date>()
            {
                new Date(){Id=1,Month1=dt1,Month2=dt2,Month3=dt3,Month4=dt4,Month5=dt5,Month6=dt6,Month7=dt7,Month8=dt8,Month9=dt9,Month10=dt10,Month11=dt11,Month12=dt12}


            };
                foreach (var item in Data1)
                {
                    Month1.Text = item.Month1.ToString("MMM", SA) + "(" + item.Month1.ToString("MMM", CurrentCulture) + ")";
                    Month2.Text = item.Month2.ToString("MMM", SA) + "(" + item.Month2.ToString("MMM", CurrentCulture) + ")";
                    Month3.Text = item.Month3.ToString("MMM", SA) + "(" + item.Month3.ToString("MMM", CurrentCulture) + ")";
                    Month4.Text = item.Month4.ToString("MMM", SA) + "(" + item.Month4.ToString("MMM", CurrentCulture) + ")";
                    Month5.Text = item.Month5.ToString("MMM", SA) + "(" + item.Month5.ToString("MMM", CurrentCulture) + ")";
                    Month6.Text = item.Month6.ToString("MMM", SA) + "(" + item.Month6.ToString("MMM", CurrentCulture) + ")";
                    Month7.Text = item.Month7.ToString("MMM", SA) + "(" + item.Month7.ToString("MMM", CurrentCulture) + ")";
                    Month8.Text = item.Month8.ToString("MMM", SA) + "(" + item.Month8.ToString("MMM", CurrentCulture) + ")";
                    Month9.Text = item.Month9.ToString("MMM", SA) + "(" + item.Month9.ToString("MMM", CurrentCulture) + ")";
                    Month10.Text = item.Month10.ToString("MMM", SA) + "(" + item.Month10.ToString("MMM", CurrentCulture) + ")";
                    Month11.Text = item.Month11.ToString("MMM", SA) + "(" + item.Month11.ToString("MMM", CurrentCulture) + ")";
                    Month12.Text = item.Month12.ToString("MMM", SA) + "(" + item.Month12.ToString("MMM", CurrentCulture) + ")";

                    var Date1 = DateTimeAgo.TimeAgo(item.Month1);
                    var Date2 = DateTimeAgo.TimeAgo(item.Month2);
                    var Date3 = DateTimeAgo.TimeAgo(item.Month3);
                    var Date4 = DateTimeAgo.TimeAgo(item.Month4);
                    var Date5 = DateTimeAgo.TimeAgo(item.Month5);
                    var Date6 = DateTimeAgo.TimeAgo(item.Month6);
                    var Date7 = DateTimeAgo.TimeAgo(item.Month7);
                    var Date8 = DateTimeAgo.TimeAgo(item.Month8);
                    var Date9 = DateTimeAgo.TimeAgo(item.Month9);
                    var Date10 = DateTimeAgo.TimeAgo(item.Month10);
                    var Date11 = DateTimeAgo.TimeAgo(item.Month11);
                    var Date12 = DateTimeAgo.TimeAgo(item.Month12);
                    var StringDate = new List<StringDate>()
            {
                new StringDate {
                    Id=1,Month1=Date1.Replace("-", " "),Month2=Date2.Replace("-", " "),Month3= Date3.Replace("-", " "),Month4= Date4.Replace("-", " "),Month5=Date5.Replace("-", " "),Month6=Date6.Replace("-", " "),Month7 =Date7.Replace("-", " "),Month8=Date8.Replace("-", " "),Month9=Date9.Replace("-", " "),Month10=Date10.Replace("-", " "),Month11=Date11.Replace("-", " "),Month12=Date12.Replace("-", " ")
                }


            };
                    foreach (var item1 in StringDate)
                    {
                        D1.Text = item1.Month1;
                        D2.Text = item1.Month2;
                        D3.Text = item1.Month3;
                        D4.Text = item1.Month4;
                        D5.Text = item1.Month5;
                        D6.Text = item1.Month6;
                        D7.Text = item1.Month7;
                        D8.Text = item1.Month8;
                        D9.Text = item1.Month9;
                        D10.Text = item1.Month10;
                        D11.Text = item1.Month11;
                        D12.Text = item1.Month12;
                    }
                }
            }


        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
                
        }

        private void Form1_Move(object sender, EventArgs e)
        {
       

            if (this.WindowState == FormWindowState.Minimized)
            {
                RegistryKey registry = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\windows\\CurrentVersion\\Run", true);
                registry.SetValue("My Application", Application.ExecutablePath.ToString());

                this.Hide();

                CultureInfo CurrentCulture = CultureInfo.GetCultureInfo("ar-AE");
                CultureInfo SA = CultureInfo.GetCultureInfo("ar-SA");
                HijriCalendar hijri1 = new HijriCalendar();
                int m = Convert.ToInt32(DateTime.Now.ToString("yyyy", CurrentCulture));
                DateTime date = DateTime.Now;
                int Now = hijri1.GetYear(date);
                int NewYear;

                string Addhijri1 = hijri1.AddYears(DateTime.Now, 1).ToString("yyyy");
                DateTime IFDATE1 = DateTime.Now;
                DateTime IFDATE2 = new DateTime(m, 12, 28);
                int IfDates1 = Convert.ToInt32(IFDATE1.ToString("yyyyMMdd"));
                int IfDates2 = Convert.ToInt32(IFDATE2.ToString("yyyyMMdd"));
                        //string AddYears = DateTime.Now.AddYears(1).ToString("yyyy", CurrentCulture);
                   
                if (IfDates1 > IfDates2)
                {
                    HijriCalendar hijri = new HijriCalendar();
                    //int NewYears = Convert.ToInt32(AddYears);
                    int NewYears = Convert.ToInt32(Addhijri1);
                    DateTime dt1 = new DateTime(NewYears, 1, 1, hijri);
                    DateTime dt2 = new DateTime(NewYears, 2, 1, hijri);
                    DateTime dt3 = new DateTime(NewYears, 3, 1, hijri);
                    DateTime dt4 = new DateTime(NewYears, 4, 1, hijri);
                    DateTime dt5 = new DateTime(NewYears, 5, 1, hijri);
                    DateTime dt6 = new DateTime(NewYears, 6, 1, hijri);
                    DateTime dt7 = new DateTime(NewYears, 7, 1, hijri);
                    DateTime dt8 = new DateTime(NewYears, 8, 1, hijri);
                    DateTime dt9 = new DateTime(NewYears, 9, 1, hijri);
                    DateTime dt10 = new DateTime(NewYears, 10, 1, hijri);
                    DateTime dt11 = new DateTime(NewYears, 11, 1, hijri);
                    DateTime dt12 = new DateTime(NewYears, 12, 1, hijri);
                    var Data1 = new List<Date>()
            {
                new Date(){Id=1,Month1=dt1,Month2=dt2,Month3=dt3,Month4=dt4,Month5=dt5,Month6=dt6,Month7=dt7,Month8=dt8,Month9=dt9,Month10=dt10,Month11=dt11,Month12=dt12}


            };
                    foreach (var item in Data1)
                    {
                        int DateNow, ToInt1, ToInt2, ToInt3, ToInt4, ToInt5, ToInt6, ToInt7, ToInt8, ToInt9, ToInt10, ToInt11, ToInt12;
                        //   DateNow = Convert.ToInt32(Convert.ToString(hijri.GetYear(DateTime.Now)+hijri.GetMonth(DateTime.Now)+hijri.GetDayOfMonth(DateTime.Now)).Replace("+",""));
                        DateNow = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd", SA));
                        ToInt1 = Convert.ToInt32(item.Month1.ToString("yyyyMMdd", SA));
                        ToInt2 = Convert.ToInt32(item.Month2.ToString("yyyyMMdd", SA));
                        ToInt3 = Convert.ToInt32(item.Month3.ToString("yyyyMMdd", SA));
                        ToInt4 = Convert.ToInt32(item.Month4.ToString("yyyyMMdd", SA));
                        ToInt5 = Convert.ToInt32(item.Month5.ToString("yyyyMMdd", SA));
                        ToInt6 = Convert.ToInt32(item.Month6.ToString("yyyyMMdd", SA));
                        ToInt7 = Convert.ToInt32(item.Month7.ToString("yyyyMMdd", SA));
                        ToInt8 = Convert.ToInt32(item.Month8.ToString("yyyyMMdd", SA));
                        ToInt9 = Convert.ToInt32(item.Month9.ToString("yyyyMMdd", SA));
                        ToInt10 = Convert.ToInt32(item.Month10.ToString("yyyyMMdd", SA));
                        ToInt11 = Convert.ToInt32(item.Month11.ToString("yyyyMMdd", SA));
                        ToInt12 = Convert.ToInt32(item.Month12.ToString("yyyyMMdd", SA));
                        T1.Text = "";
                        T2.Text = " فلفل";
                        T3.Text = "الملوخية,شمام";
                        T4.Text = "";
                        T5.Text = "الملوخية";
                        T6.Text = "";
                        T7.Text = "";
                        T8.Text = " الفراولة,خيار,الزهرة,الملفوف";
                        T9.Text = "طماطم و باذنجان و فلفل";
                        T10.Text = " كزبرة بقدونس ";
                        T11.Text = " شمندر سبائخ";
                        T12.Text = "";

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
                            this.Hide();
                            notifyIcon1.ShowBalloonTip(1000, item.Month6.ToString("MMM"), "شهر جديد  ", ToolTipIcon.Info);
                        }
                        if (DateNow == ToInt7)
                        {
                            //  this.Hide();
                            notifyIcon1.ShowBalloonTip(1000, item.Month7.ToString("MMM"), "شهر جديد  ", ToolTipIcon.Info);
                        }
                        if (DateNow == ToInt8)
                        {
                            this.Hide();
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
                else
                {
                    DateTime dt1 = new DateTime(Now, 1, 1, hijri1);
                    DateTime dt2 = new DateTime(Now, 2, 1, hijri1);
                    DateTime dt3 = new DateTime(Now, 3, 1, hijri1);
                    DateTime dt4 = new DateTime(Now, 4, 1, hijri1);
                    DateTime dt5 = new DateTime(Now, 5, 1, hijri1);
                    DateTime dt6 = new DateTime(Now, 6, 1, hijri1);
                    DateTime dt7 = new DateTime(Now, 7, 1, hijri1);
                    DateTime dt8 = new DateTime(Now, 8, 1, hijri1);
                    DateTime dt9 = new DateTime(Now, 9, 1, hijri1);
                    DateTime dt10 = new DateTime(Now, 10, 1, hijri1);
                    DateTime dt11 = new DateTime(Now, 11, 1, hijri1);
                    DateTime dt12 = new DateTime(Now, 12, 1, hijri1);
                    var Data1 = new List<Date>()
            {
                new Date(){Id=1,Month1=dt1,Month2=dt2,Month3=dt3,Month4=dt4,Month5=dt5,Month6=dt6,Month7=dt7,Month8=dt8,Month9=dt9,Month10=dt10,Month11=dt11,Month12=dt12}


            };
                    foreach (var item in Data1)
                    {
                        int DateNow, ToInt1, ToInt2, ToInt3, ToInt4, ToInt5, ToInt6, ToInt7, ToInt8, ToInt9, ToInt10, ToInt11, ToInt12;
                        //   DateNow = Convert.ToInt32(Convert.ToString(hijri.GetYear(DateTime.Now)+hijri.GetMonth(DateTime.Now)+hijri.GetDayOfMonth(DateTime.Now)).Replace("+",""));
                        DateNow = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd", SA));
                        ToInt1 = Convert.ToInt32(item.Month1.ToString("yyyyMMdd", SA));
                        ToInt2 = Convert.ToInt32(item.Month2.ToString("yyyyMMdd", SA));
                        ToInt3 = Convert.ToInt32(item.Month3.ToString("yyyyMMdd", SA));
                        ToInt4 = Convert.ToInt32(item.Month4.ToString("yyyyMMdd", SA));
                        ToInt5 = Convert.ToInt32(item.Month5.ToString("yyyyMMdd", SA));
                        ToInt6 = Convert.ToInt32(item.Month6.ToString("yyyyMMdd", SA));
                        ToInt7 = Convert.ToInt32(item.Month7.ToString("yyyyMMdd", SA));
                        ToInt8 = Convert.ToInt32(item.Month8.ToString("yyyyMMdd", SA));
                        ToInt9 = Convert.ToInt32(item.Month9.ToString("yyyyMMdd", SA));
                        ToInt10 = Convert.ToInt32(item.Month10.ToString("yyyyMMdd", SA));
                        ToInt11 = Convert.ToInt32(item.Month11.ToString("yyyyMMdd", SA));
                        ToInt12 = Convert.ToInt32(item.Month12.ToString("yyyyMMdd", SA));
                        T1.Text = "";
                        T2.Text = " فلفل";
                        T3.Text = "الملوخية,شمام";
                        T4.Text = "";
                        T5.Text = "الملوخية";
                        T6.Text = "";
                        T7.Text = "";
                        T8.Text = " الفراولة,خيار,الزهرة,الملفوف";
                        T9.Text = "طماطم و باذنجان و فلفل";
                        T10.Text = " كزبرة بقدونس ";
                        T11.Text = " شمندر سبائخ";
                        T12.Text = "";

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
                            this.Hide();
                            notifyIcon1.ShowBalloonTip(1000, item.Month6.ToString("MMM"), "شهر جديد  ", ToolTipIcon.Info);
                        }
                        if (DateNow == ToInt7)
                        {
                            //  this.Hide();
                            notifyIcon1.ShowBalloonTip(1000, item.Month7.ToString("MMM"), "شهر جديد  ", ToolTipIcon.Info);
                        }
                        if (DateNow == ToInt8)
                        {
                            this.Hide();
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
        }

        private void Month1_Click(object sender, EventArgs e)
        {

        }
    }
}
