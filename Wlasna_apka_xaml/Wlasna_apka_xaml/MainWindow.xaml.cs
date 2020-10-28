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

namespace Wlasna_apka_xaml
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void b_loop_Click(object sender, RoutedEventArgs e)
        {
            int policz = 100;

            while(policz>0)
            {
                policz -= 1;

            }

            for(int i=0;i<10;i++)
            {
                policz = policz + 1 * 5;
            
               
            }
            komunikat.Text = "Zmienna policz wynosi: " + policz;

        }

        private void b_condition_Click(object sender, RoutedEventArgs e)
        {
            int x = 5;
            if(x==10)
            {
                komunikat.Text = "x jest równe 10";
            }
            else
            {
                komunikat.Text = "x nie jest równe 10";

            }

        }

        private void b_komunikat_Click(object sender, RoutedEventArgs e)
        {
         string  s = "Marcin";
            int x = 80;
            double d = Math.PI * 2;
            x = x % 4;

            komunikat.Text = "Jestem " + s + "\nx równa się: " + x + "\nd jest równe: " + d;
        }

        private void b_nextcondition_Click(object sender, RoutedEventArgs e)
        {
            int jakasWartosc = 4;
            string name = "Paweł";
            if (jakasWartosc == 3 && name.Equals("Piotrek"))
            {
                komunikat.Text = "jakasWartosc wynosi 3 i imie jest równe Piotrek";

            }
            komunikat.Text = "Ten komunikat wyswietla sie bez wzgledu na warunek";
        }
    }
}
