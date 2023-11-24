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
    /// Логика взаимодействия для Page7.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        public Page7()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(Text1.Text, out int x) && 10 <= x && x <= 40)
            {
                MessageBox.Show("Введите число!");
            }

            if (x / 10 == 1)
            {
                switch (x)
                {
                    case 10: Text2.Text += "десять учебных задания\n"; break;
                    case 11: Text2.Text += "одинадцать учебных задания\n"; break;
                    case 12: Text2.Text += "двенадцать учебных задания\n"; break;
                    case 13: Text2.Text += "тринадцать учебных задания\n"; break;
                    case 14: Text2.Text += "четырнадцать учебных задания\n"; break;
                    case 15: Text2.Text += "пятнадцать учебных задания\n"; break;
                    case 16: Text2.Text += "шестнадцаь учебных задания\n"; break;
                    case 17: Text2.Text += "семнадцать учебных задания\n"; break;
                    case 18: Text2.Text += "восемнадцать учебных задания\n"; break;
                    case 19: Text2.Text += "девятнадцать учебных задания\n"; break;
                }
            }
            else
            {
                switch (x / 10)
                {
                    case 2: Text2.Text += "двадцать"; break;
                    case 3: Text2.Text += "тридцать"; break;
                    case 4: Text2.Text += "сорок"; break;
                }
                switch (x % 10)
                {
                    case 1: Text2.Text += " один учебных задания\n"; break;
                    case 2: Text2.Text += " два учебных задания\n"; break;
                    case 3: Text2.Text += " три учебных задания\n"; break;
                    case 4: Text2.Text += " четыре учебных задания\n"; break;
                    case 5: Text2.Text += " пять учебных задания\n"; break;
                    case 6: Text2.Text += " шесть учебных задания\n"; break;
                    case 7: Text2.Text += " семь учебных задания\n"; break;
                    case 8: Text2.Text += " восемь учебных задания\n"; break;
                    case 9: Text2.Text += " девять учебных задания\n"; break;
                }
            }
        }
    }
}
