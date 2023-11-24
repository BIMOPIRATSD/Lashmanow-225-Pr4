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
    /// Логика взаимодействия для Page8.xaml
    /// </summary>
    public partial class Page8 : Page
    {
        public Page8()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(Text1.Text, out int x) && 100 <= x && x <= 999)
            {
                MessageBox.Show("Введите число!");
            }

            switch (x / 100)
            {
                case 1: Text2.Text += "сто"; break;
                case 2: Text2.Text += "двести"; break;
                case 3: Text2.Text += "триста"; break;
                case 4: Text2.Text += "четыреста"; break;
                case 5: Text2.Text += "пятьсот"; break;
                case 6: Text2.Text += "шестьсот"; break;
                case 7: Text2.Text += "семьсот"; break;
                case 8: Text2.Text += "восемьсот"; break;
                case 9: Text2.Text += "девятьсот"; break;
            }
            if (x % 100 / 10 == 1)
            {
                switch (x)
                {
                    case 10: Text2.Text += "десять"; break;
                    case 11: Text2.Text += "одинадцать"; break;
                    case 12: Text2.Text += "двенадцать"; break;
                    case 13: Text2.Text += "тринадцать"; break;
                    case 14: Text2.Text += "четырнадцать"; break;
                    case 15: Text2.Text += "пятнадцать"; break;
                    case 16: Text2.Text += "шестнадцаь"; break;
                    case 17: Text2.Text += "семнадцать"; break;
                    case 18: Text2.Text += "восемнадцать"; break;
                    case 19: Text2.Text += "девятнадцать"; break;
                }
            }
            else
            {
                switch (x % 100 / 10)
                {
                    case 2: Text2.Text += " двадцать"; break;
                    case 3: Text2.Text += " тридцать"; break;
                    case 4: Text2.Text += " сорок"; break;
                    case 5: Text2.Text += " пятьдесят"; break;
                    case 6: Text2.Text += " шестьдесят"; break;
                    case 7: Text2.Text += " семьдесят"; break;
                    case 8: Text2.Text += " восемьдесят"; break;
                    case 9: Text2.Text += " девяносто"; break;
                }
                switch (x % 10)
                {
                    case 1: Text2.Text += " один\n"; break;
                    case 2: Text2.Text += " два\n"; break;
                    case 3: Text2.Text += " три\n"; break;
                    case 4: Text2.Text += " четыре\n"; break;
                    case 5: Text2.Text += " пять\n"; break;
                    case 6: Text2.Text += " шесть\n"; break;
                    case 7: Text2.Text += " семь\n"; break;
                    case 8: Text2.Text += " восемь\n"; break;
                    case 9: Text2.Text += " девять\n"; break;
                }
            }
        }
    }
}
