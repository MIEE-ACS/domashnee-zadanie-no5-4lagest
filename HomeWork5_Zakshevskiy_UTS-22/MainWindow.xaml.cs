using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomeWork5_Zakshevskiy_UTS_22
{
    public partial class MainWindow : Window
    {
        public class Time
        {
            private int m_hour;
            public int hour
            {
                set
                {
                    if ((value > 0)&&(value < 24))
                        m_hour = value;
                }
                get { return m_hour; }
            }
            private int m_minute;
            public int minute
            {
                set
                {
                    if ((value > 0) && (value < 60))
                        m_minute = value;
                }
                get { return m_minute; }
            }
            private int m_second;
            public int second
            {
                set
                {
                    if ((value > 0) && (value < 60))
                        m_second = value;
                }
                get { return m_second; }
            }
            public Time(string h, string m, string s)
            {
                SetHour(int.Parse(h));
                SetMinute(int.Parse(m));
                SetSecond(int.Parse(s));
            }
            public void SetHour(int hour)
            {
                if ((hour < 0) || (hour > 24))
                {
                    MessageBox.Show("Формат ввода от 0 до 24 часов. Повторите ввод");
                    throw new Exception("Так низя!");
                }
                else
                {
                    m_hour = hour;
                }
            } 
            public void SetMinute(int minute)
            {
                if ((minute < 0) || (minute > 60))
                {
                    MessageBox.Show("Формат ввода от 0 до 60 минут. Повторите ввод");
                    throw new Exception();
                }
                else
                {
                    m_minute = minute;
                }
            }
            public void SetSecond(int second)
            {
                if ((second < 0) || (second > 60))
                {
                    MessageBox.Show("Формат ввода от 0 до 60 секунд. Повторите ввод");
                    throw new Exception();
                }
                else
                {
                    m_second=second;
                }
            }
        }
        public void printArrTime(Time[] ArrTime)
        {
            Lb_Number.Content = String.Format("");
            Lb_Hour.Content = String.Format("");
            Lb_Minute.Content = String.Format("");
            Lb_Second.Content = String.Format("");
            for (int i = 1; i <= ArrTime.Length; i++)
            {
                Lb_Number.Content += String.Format("\n{0}", i);
                Lb_Hour.Content += String.Format("\n{0}", ArrTime[i-1].hour);
                Lb_Minute.Content += String.Format("\n{0}", ArrTime[i-1].minute);
                Lb_Second.Content += String.Format("\n{0}", ArrTime[i-1].second);
            }
        }
        public static int SizeOfArrTime = 5;
        public Time[] ArrTime = new Time[SizeOfArrTime];
        public MainWindow()
        {
            InitializeComponent();
            Random r = new Random();
            for (int i = 0; i < ArrTime.Length; i++)
            {
                Time t = new Time(r.Next(0, 24).ToString(), r.Next(0, 60).ToString(), r.Next(0, 60).ToString());
                ArrTime[i] = t;
            }
            printArrTime(ArrTime);
        }

        private void Bt_1_Click(object sender, RoutedEventArgs e)
        {
            Window2 Add = new Window2();
            Add.ShowDialog();
            Add.Owner = this;
            if (Add.DialogResult==true)
            {
                Time timeAdd = new Time(Add.mc_hour, Add.mc_minute, Add.mc_second);
                Array.Resize(ref ArrTime, ArrTime.Length + 1);
                ArrTime[ArrTime.Length-1] = timeAdd;
                printArrTime(ArrTime);
                SizeOfArrTime += 1;
            }

        }
        private void Bt_2_Click(object sender, RoutedEventArgs e)
        {
            Window1 Change = new Window1();
            Change.ShowDialog();
            Change.Owner = this;
            if (Change.DialogResult==true)
            {
                ArrTime[int.Parse(Change.ma_number) - 1] = new Time(Change.ma_hour, Change.ma_minute, Change.ma_second);
                printArrTime(ArrTime);
            }
        }
    }
}
