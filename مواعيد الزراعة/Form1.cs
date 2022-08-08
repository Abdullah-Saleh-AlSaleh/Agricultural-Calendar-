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
using System.Timers;
using System.Windows.Forms;
using CommunityToolkit.WinUI.Notifications;
using Microsoft.Win32;
using Topshelf;

namespace Agricultural_Calendar
{
    public partial class Form1 : Form
    {
        private static System.Timers.Timer aTimer;
        public Form1()
        {
            InitializeComponent();
            aTimer = new System.Timers.Timer(10000);
            // Hook up the Elapsed event for the timer.
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            // Set the Interval to 2 seconds (2000 milliseconds).
            aTimer.Interval = 1000;
            aTimer.Enabled = true;
            aTimer.Start();


        }


        public void OnTimedEvent(object sender, ElapsedEventArgs e)
        {

            double Timer = Convert.ToDouble(e.SignalTime.ToString("yyyyMMddHHmmss"));
            double TimerDD = Convert.ToDouble(e.SignalTime.ToString("yyyyMMdd"));
            CultureInfo AE = CultureInfo.GetCultureInfo("ar-AE");
            CultureInfo SA = CultureInfo.GetCultureInfo("ar-SA");
            foreach (var Data in db.GetDates())
            {
                double ss = Convert.ToDouble(Data.dateTime.ToString("yyyyMMddHHmmss"));
                if (Timer == ss)
                {

                    new ToastContentBuilder()
                        .AddArgument("action", "viewConversation")
                        .AddArgument("conversationId", 9813)
                        .AddText(Data.dateTime.ToString("M", AE) + "مـ ||" + Data.dateTime.ToString("M", SA) + "هــ")
                        .AddText(Data.Text)
                        .Show();

                }
                else
                {
                    Console.WriteLine("No ok");
                }


            }

            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
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
            datey.Text = DateTime.Now.ToString("yyyy", CurrentCulture) + "-" + hijri1.GetYear(DateTime.Now).ToString();
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

            foreach (var item in db.GetDates())
            {
                GregorianCalendar gregorianCalendar = new GregorianCalendar();
                switch (item.Id)
                {
                    case 1:
                        Month1.Text = item.dateTime.ToString("MMM", SA) + "(" + item.dateTime.ToString("MMM", CurrentCulture) + ")";
                        break;
                    case 2:
                        Month2.Text = item.dateTime.ToString("MMM", SA) + "(" + item.dateTime.ToString("MMM", CurrentCulture) + ")";
                        break;
                    case 3:
                        Month3.Text = item.dateTime.ToString("MMM", SA) + "(" + item.dateTime.ToString("MMM", CurrentCulture) + ")";
                        break;

                    case 4:
                        Month4.Text = item.dateTime.ToString("MMM", SA) + "(" + item.dateTime.ToString("MMM", CurrentCulture) + ")";
                        break;
                    case 5:
                        Month5.Text = item.dateTime.ToString("MMM", SA) + "(" + item.dateTime.ToString("MMM", CurrentCulture) + ")";
                        break;
                    case 6:
                        Month6.Text = item.dateTime.ToString("MMM", SA) + "(" + item.dateTime.ToString("MMM", CurrentCulture) + ")";
                        break;
                    case 7:
                        Month7.Text = item.dateTime.ToString("MMM", SA) + "(" + item.dateTime.ToString("MMM", CurrentCulture) + ")";
                        break;
                    case 8:
                        Month8.Text = item.dateTime.ToString("MMM", SA) + "(" + item.dateTime.ToString("MMM", CurrentCulture) + ")";
                        break;

                    case 9:
                        Month9.Text = item.dateTime.ToString("MMM", SA) + "(" + item.dateTime.ToString("MMM", CurrentCulture) + ")";
                        break;
                    case 10:
                        Month10.Text = item.dateTime.ToString("MMM", SA) + "(" + item.dateTime.ToString("MMM", CurrentCulture) + ")";
                        break;
                    case 11:
                        Month11.Text = item.dateTime.ToString("MMM", SA) + "(" + item.dateTime.ToString("MMM", CurrentCulture) + ")";
                        break;
                    case 12:
                        Month12.Text = item.dateTime.ToString("MMM", SA) + "(" + item.dateTime.ToString("MMM", CurrentCulture) + ")";
                        break;



                    default:
                        break;
                }

                foreach (var item1 in db.GetStrings())
                {
                    switch (item1.Id)
                    {
                        case 1:
                            D1.Text = item1.dateTime;
                            break;
                        case 2:
                            D2.Text = item1.dateTime;
                            break;
                        case 3:
                            D3.Text = item1.dateTime;
                            break;
                        case 4:
                            D4.Text = item1.dateTime;
                            break;
                        case 5:
                            D5.Text = item1.dateTime;
                            break;
                        case 6:
                            D6.Text = item1.dateTime;
                            break;
                        case 7:
                            D7.Text = item1.dateTime;
                            break;
                        case 8:
                            D8.Text = item1.dateTime;
                            break;
                        case 9:
                            D9.Text = item1.dateTime;
                            break;
                        case 10:
                            D10.Text = item1.dateTime;
                            break;
                        case 11:
                            D11.Text = item1.dateTime;
                            break;
                        case 12:
                            D12.Text = item1.dateTime;
                            break;
                        default:
                            break;
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
                registry.SetValue("My Agricultural Calendar", Application.ExecutablePath.ToString());
                this.Hide();






            }
        }

        private void Month1_Click(object sender, EventArgs e)
        {

        }
    }
}
