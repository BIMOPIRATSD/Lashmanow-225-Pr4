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
    /// Логика взаимодействия для Page6.xaml
    /// </summary>
    public partial class Page6 : Page
    {
        public Page6()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(Text1.Text, out int N))
            {

            }
            bool mir = false;
            while (N > 0)
            {
                int digit = N % 10;
                if (digit % 2 == 0)
                {
                    mir = true;
                    break;
                }
                N /= 10;
            }
            Text2.Text += $"{mir}\n";
        }   
    }
}
