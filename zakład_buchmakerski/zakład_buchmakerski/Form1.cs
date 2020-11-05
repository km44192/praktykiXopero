using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace zakład_buchmakerski
{
    public partial class Form1 : Form
    {
        string winner;
        Osoba Dominik = new Osoba("Dominik", 100);
        Osoba Pawel = new Osoba("Paweł", 200);
        Osoba Dariusz = new Osoba("Darek", 150);
        Osoba tymcz;
        Betting obstawa;
        public Form1()
        {
            InitializeComponent();

            Dominik.moj_przycisk = setGuyBet1;
            Pawel.moj_przycisk = setGuyBet2;
            Dariusz.moj_przycisk = setGuyBet3;

            Dominik.moja_etykieta = infoGuy1;
            Pawel.moja_etykieta = infoGuy2;
            Dariusz.moja_etykieta = infoGuy3;

            Dominik.UpdateLabels();
            Pawel.UpdateLabels();
            Dariusz.UpdateLabels();

            Dominik.moja_etykieta.Text = Dominik.bet.GetDescription();
            Pawel.moja_etykieta.Text = Pawel.bet.GetDescription();
            Dariusz.moja_etykieta.Text = Dariusz.bet.GetDescription();

        }
        Wlepy[] biegacz = new Wlepy[4];

            
        private void move1(int index,PictureBox info)
        {
            if (biegacz[index] == null) { biegacz[index] = new Wlepy();
                biegacz[index].obrazek = info;
            }
            else { biegacz[index] = null; }

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (biegacz[i] != null)
                {


                    if (!(biegacz[i].goingForward))
                    {
                        winner = biegacz[i].obrazek.Name;
                        Dominik.Collect(Dominik.bet.Rybka);
                        Pawel.Collect(Pawel.bet.Rybka);
                        Dariusz.Collect(Dariusz.bet.Rybka);

                        Dominik.UpdateLabels();
                        Pawel.UpdateLabels();
                        Dariusz.UpdateLabels();
                        
                        timer1.Enabled = false;
                        biegacz[0].Reset();
                        biegacz[1].Reset();
                        biegacz[2].Reset();
                        biegacz[3].Reset();
                    }
                    else
                    {
                        biegacz[i].Move();
                    }
           

                }
             
            }
            move1(0, ryba1);
            move1(1, ryba2);
            move1(2, ryba3);
            move1(3, ryba4);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool x = timer1.Enabled;

            timer1.Enabled = !x ;
          
        }

    

     

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bettingGuyName.Text = Dominik.imie;
            tymcz = Dominik;
            Dominik.bet = obstawa;
        }

        private void setGuyBet2_CheckedChanged(object sender, EventArgs e)
        {
            bettingGuyName.Text = Pawel.imie;
            tymcz = Pawel;
            Pawel.bet = obstawa;

        }

        private void setGuyBet3_CheckedChanged(object sender, EventArgs e)
        {
            bettingGuyName.Text = Dariusz.imie;
            tymcz = Dariusz;
            Dariusz.bet = obstawa;
        }

        private void bet_Click(object sender, EventArgs e)
        {   
            Osoba tmp1 = tymcz;
           obstawa = new Betting() { zakład = (int)ammountof.Value, Rybka = who1.Text,kto =tymcz};
            tmp1.bet = obstawa;
            MessageBox.Show(Pawel.bet.Rybka);
            MessageBox.Show(Dominik.bet.Rybka);
            MessageBox.Show(Dariusz.bet.Rybka);
            tmp1.PlaceBet(obstawa.zakład, obstawa.Rybka);
            tmp1.moja_etykieta.Text=obstawa.GetDescription();
            tymcz = tmp1;
        

            
        }

      
    }
}
