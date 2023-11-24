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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(Text1.Text, out int x))
            {

            }
            if (!double.TryParse(Text2.Text, out double y))
            {

            }
            string c = "";
            string z = "";
            switch (x)
            {
                case 1:
                    c = "пики";
                    break;
                case 2:
                    c = "трефы";
                    break;
                case 3:
                    c = "бубны";
                    break;
                case 4:
                    c = "червы";
                    break;
            }
            switch (y)
            {
                case 6:
                    z = "шестёрка";
                    Text3.Text += $"{z} {c}\n";
                    break;
                case 7:
                    z = "семёрка";
                    Text3.Text += $"{z} {c}\n";
                    break;
                case 8:
                    z = "восьмёрка";
                    Text3.Text += $"{z} {c}\n";
                    break;
                case 9:
                    z = "девятка";
                    Text3.Text += $"{z} {c}\n";
                    break;
                case 10:
                    z = "десятка";
                    Text3.Text += $"{z} {c}\n";
                    break;
                case 11:
                    z = "валет";
                    Text3.Text += $"{z} {c}\n";
                    break;
                case 12:
                    z = "дама";
                    Text3.Text += $"{z} {c}\n";
                    break;
                case 13:
                    z = "король";
                    Text3.Text += $"{z} {c}\n";
                    break;
                case 14:
                    z = "туз";
                    Text3.Text += $"{z} {c}\n";
                    break;
            }
        }
    }
}
