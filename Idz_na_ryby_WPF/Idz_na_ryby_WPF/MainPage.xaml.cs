using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace Idz_na_ryby_WPF
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private Game game;


        private void UpdateForm()
        {

            Hand.Items.Clear();
            foreach (String cardName in game.GetPlayersCardName())
                Hand.Items.Add(cardName);
            text.Text = game.DescribeBooks();
           Progress.Text += game.DescribePlayerHands();
            Progress.SelectionStart = Progress.Text.Length;
           // Progress.ScrollToCaret();

        }

     

       

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(Imie.Text))
            {
                // MessageBox.Show(" Wpisz swoje imie ", " Nie możesz jeszcze rozpocząć gry! ");
                return;
            }
            game = new Game(Imie.Text, new List<string>() { "Janek", "Bartek" }, Progress);
            StartGame.IsEnabled = false;
            Imie.IsEnabled = false;
            requestB.IsEnabled = true;
            UpdateForm();
        }

        private void requestB_Click(object sender, RoutedEventArgs e)
        {
            Progress.Text = " ";
            if (Hand.SelectedIndex < 0)
            {
                //  Flyout.
                return;
            }
            if (game.PlayOneRound(Hand.SelectedIndex))
            {
                Progress.Text += "Zwycięczcą jest..." + game.GetWinnername();
                text.Text = game.DescribeBooks();
                requestB.IsEnabled = false;
            }
            else UpdateForm();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
