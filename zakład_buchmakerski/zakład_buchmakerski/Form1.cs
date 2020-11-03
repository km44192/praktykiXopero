using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zakład_buchmakerski
{
    public partial class Form1 : Form
    {
        string winner;
        Osoba Dominik = new Osoba("Dominik", 100);
        Osoba Pawel = new Osoba("Paweł", 200);
        Osoba Dariusz = new Osoba("Darek", 150);
        public Form1()
        {
            InitializeComponent(); 
            

          infoGuy1.Text= Dominik.UpdateLabels();
            Pawel.UpdateLabels();
            Dariusz.UpdateLabels();
            
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
        }

        private void setGuyBet2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void setGuyBet3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bet_Click(object sender, EventArgs e)
        {
            Betting bet = new Betting();

        }
    }
}
