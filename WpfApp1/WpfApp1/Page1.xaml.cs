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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!int.TryParse(Text1.Text, out int x))
            {

            }
            if(!double.TryParse(Text2.Text, out double y))
            {

            }
            double c;
            switch (x)
            {
                case 1:
                    c = y;
                    Text3.Text += $"Масса тела равна {c}кг\n"; break;
                case 2:
                    c = y / 1000000;
                    Text3.Text += $"Масса тела равна {c}кг\n";
                    break;
                case 3:
                    c = y / 1000;
                    Text3.Text += $"Масса тела равна {c}кг\n";
                    break;
                case 4:
                    c = y * 1000;
                    Text3.Text += $"Масса тела равна {c}кг\n";
                    break;
                case 5:
                    c = y * 100;
                    Text3.Text += $"Масса тела равна {c}кг\n";
                    break;
            }
        }
    }
}
