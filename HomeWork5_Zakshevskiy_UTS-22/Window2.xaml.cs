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
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        public string mc_hour;
        public string mc_minute;
        public string mc_second;
        public void BtChange_Click(object sender, RoutedEventArgs e)
        {
            string hour = Tb1.Text;
            string minute = Tb2.Text;
            string second = Tb3.Text;
            int exam;
            if ((int.TryParse(hour, out exam)) || (int.TryParse(minute, out exam)) || (int.TryParse(second, out exam)))
            {
                mc_hour = hour;
                mc_minute = minute;
                mc_second = second;
                DialogResult = true;
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
