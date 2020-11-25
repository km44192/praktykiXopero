using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace Dostep_asynch
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Question.Text = "Czy jesteś szczęśliwy";
            moment.IsReadOnly = true;
        }

        DispatcherTimer timer = new DispatcherTimer();
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            timer.Tick += timer_Tick;
            timer.Interval = TimeSpan.FromMilliseconds(50);
            timer.Start();
            CheckHappiness();
        }


        int i = 0;

        void timer_Tick(object sender, object e)
        {
            moment.Text = "Chwila nr " + i++;
        }
        private async void CheckHappiness() {
            MessageDialog dialog = new MessageDialog("Czy jesteś szczęśliwy");
            dialog.Commands.Add(new UICommand("Mocno zmęczony i smutny"));
            dialog.Commands.Add(new UICommand("Szczęśliwy i radosny!"));
         
            dialog.DefaultCommandIndex = 1;
            UICommand result = await dialog.ShowAsync() as UICommand;
            if (result != null && result.Label == "Szczęśliwy i radosny!")
                Question.Text = "Użytkownik jest szczęśliwy.";
            else
                Question.Text = "Użytkownik jest smutny.";
            timer.Stop();
        }
    }
}
