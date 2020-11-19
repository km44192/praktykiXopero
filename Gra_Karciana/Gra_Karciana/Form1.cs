using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Talia_Kart;

namespace Gra_Karciana
{
    public partial class Form1 : Form
    {
        Deck talia1,talia2;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void ResetDeck(int deckNumber)
        {
            openFileDialog1.InitialDirectory = @"C\Users";
            openFileDialog1.Filter = "Pliki tekstowe (*.txt)|*.txt| Wszystkie pliki (*.*)|*.*";
            openFileDialog1.FileName = "";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {


                if (deckNumber == 1)
                {
                //    int numberOfCards = random.Next(1, 11);
                    talia1 = new Deck(openFileDialog1.FileName);
                 //   for (int i = 0; i < numberOfCards; i++)
               //         talia1.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));

                    talia1.Sort();
                }
                else talia2 = new Deck();
            }
        }

        private void Reset1_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void Reset2_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void Mix1_Click(object sender, EventArgs e)
        {
            talia1.Shuffle();
            RedrawDeck(1);
        }

        private void Mix2_Click(object sender, EventArgs e)
        {
            talia2.Shuffle();
            RedrawDeck(2);

        }

        private void SwapRight_Click(object sender, EventArgs e)
        {
            if (dec1.SelectedIndex >= 0)
                if (talia1.Count > 0)
                    talia2.Add(talia1.Deal(dec1.SelectedIndex));
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void SwapLeft_Click(object sender, EventArgs e)
        {
            if(dec2.SelectedIndex>=0)
                if (talia2.Count > 0)
                {
                    talia1.Add(talia2.Deal(dec2.SelectedIndex));
                }
            RedrawDeck(1);
            RedrawDeck(2);
        }

     

        public void RedrawDeck(int Decknumber)
        {
            if (Decknumber == 1)
            {
                dec1.Items.Clear();
                foreach(string cardname in talia1.GetCardNames())
                {
                    dec1.Items.Add(cardname);

                }
                label1.Text = "Zestaw 1.(" + talia1.Count + " kart)";
            }
            else
            {
                dec2.Items.Clear();
                foreach (string cardname in talia2.GetCardNames())
                    dec2.Items.Add(cardname);
                label2.Text="Zestaw 2.(" + talia2.Count + " kart)";

            }
        }
    }
}
