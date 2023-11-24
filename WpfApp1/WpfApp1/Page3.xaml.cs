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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(Text1.Text, out double x))
            {

            }
            if (!double.TryParse(Text2.Text, out double y))
            {

            }
            double a, c, h, S;
            switch(x)
            {
                case 1:
                    c = y * Sqrt(2);
                    h = c / 2;
                    S = c * h / 2;
                    Text3.Text += $"Катет равен {y}см\nГипотенуза равна {c:f2}см\nВысота опущенная на гипотенузу равна {h:f2}\nПлощадь равна {S:f2}см в квадрате\n";
                    break;
                case 2:
                    a = y / Sqrt(2);
                    h = y / 2;
                    S = y * h / 2;
                    Text3.Text += $"Катет равен {a:f2}см\nГипотенуза равна {y}см\nВысота опущенная на гипотенузу равна {h:f2}\nПлощадь равна {S:f2}см в квадрате\n";
                    break;
                case 3:
                    c = y * 2;
                    a = c / Sqrt(2);
                    S = c * y / 2;
                    Text3.Text += $"Катет равен {a:f2}см\nГипотенуза равна {c:f2}см\nВысота опущенная на гипотенузу равна {y}\nПлощадь равна {S:f2}см в квадрате\n";
                    break;
                case 4:
                    h = Sqrt(y);
                    c = h * 2;
                    a = c / Sqrt(2);
                    Text3.Text += $"Катет равен {a:f2}см\nГипотенуза равна {c:f2}см\nВысота опущенная на гипотенузу равна {h:f2}\nПлощадь равна {y}см в квадрате\n";
                    break;
            }
        }
    }
}
