using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Idz_na_ryby
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Game game;
      

    private void UpdateForm()
        {

            listHand.Items.Clear();
            foreach (String cardName in game.GetPlayersCardName())
                listHand.Items.Add(cardName);
            text.Text = game.DescribeBooks();
            textProgress.Text += game.DescribePlayerHands();
            textProgress.SelectionStart = textProgress.Text.Length;
            textProgress.ScrollToCaret();

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textImie.Text))
            {
                MessageBox.Show(" Wpisz swoje imie ", " Nie możesz jeszcze rozpocząć gry! ");
                return;
            }
            game = new Game(textImie.Text, new List<string>() { "Janek", "Bartek" }, textProgress);
            buttonStart.Enabled = false;
            textImie.Enabled = false;
            buttonAsk.Enabled = true;
            UpdateForm();

        }

        private void buttonAsk_Click(object sender, EventArgs e)
        {
            textProgress.Text = " ";
            if (listHand.SelectedIndex < 0)
            {
                MessageBox.Show("Wybierz kartę.");
                return;
            }
            if (game.PlayOneRound(listHand.SelectedIndex))
            {
                textProgress.Text += "Zwycięczcą jest..." + game.GetWinnername();
                text.Text = game.DescribeBooks();
                buttonAsk.Enabled = false;
            }
            else UpdateForm();
        }
      
    }
}
