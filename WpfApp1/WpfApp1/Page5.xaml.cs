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
using static System.Math;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(Text1.Text, out double P))
            {

            }
            int k = 0;
            double S = 0;
            double distance = 10;
            while(S <= 200)
            {
                k++;
                S += distance;
                distance = distance + (distance * P / 100);
            }
            Text2.Text += $"Колличество дней {k}\n";
            Text2.Text += $"Суммарный пробег {S:f2}км\n";
        }
    }
}
