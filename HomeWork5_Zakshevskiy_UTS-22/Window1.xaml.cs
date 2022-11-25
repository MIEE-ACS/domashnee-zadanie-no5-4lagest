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
using System.Windows.Shapes;

namespace HomeWork5_Zakshevskiy_UTS_22
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        public string ma_number;
        public string ma_hour;
        public string ma_minute;
        public string ma_second;
        public void BtAdd_Click(object sender, RoutedEventArgs e)
        {
            string number = TbNumber.Text;
            string hour = TbHour.Text;
            string minute = TbMinute.Text;
            string second = TbSecond.Text;
            int exam;
            if ((int.TryParse(hour, out exam)) || (int.TryParse(minute, out exam)) || (int.TryParse(second, out exam))|| (int.TryParse(number, out exam)))
            {
                int examNumber = MainWindow.SizeOfArrTime;
                if ((int.Parse(number)>0)&&(int.Parse(number) <= examNumber))
                {
                    ma_hour = hour;
                    ma_minute = minute;
                    ma_second = second;
                    ma_number = number;
                    DialogResult = true;
                }
                else
                {
                    MessageBox.Show("Такого номера не существует. Введите его заново.");
                }
            }
            else
            {
                MessageBox.Show("Некорректный ввод. Введите значения заново!");
            }
        }

        private void BtCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
