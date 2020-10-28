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

namespace Zmiana_Zakotwiczenia
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (enable.IsChecked == true)
            {

                if (objekt.HorizontalAlignment == HorizontalAlignment.Center)
                {
                    objekt.HorizontalAlignment = HorizontalAlignment.Left;
                    objekt.Text = "Kotwica do lewej";
                }
                else if (objekt.HorizontalAlignment == HorizontalAlignment.Left)
                {
                    objekt.HorizontalAlignment = HorizontalAlignment.Right;
                    objekt.Text = "Kotwica do prawej";
                }
                else
                {
                    objekt.HorizontalAlignment = HorizontalAlignment.Center;
                    objekt.Text = "Kotwica wyśrodkowana";
                }

            }
            else
                objekt.Text = "Możliwośc zmiany wyłączona";
        }
        
    }
}
