using System;
using System.Reflection.Emit;
using System.Windows.Forms;
namespace zakład_buchmakerski
{
    class Wlepy
    {
        public System.Windows.Forms.PictureBox obrazek;

        public bool goingForward = true;
        Random kierunek;
        public void Move()
        {
            if (obrazek != null)
            {
                if (goingForward == true)
                {
                    kierunek = new Random();
                    obrazek.Left += kierunek.Next(1, 5);
                    if (obrazek.Left >= obrazek.Parent.Width - obrazek.Width - 100)
                    {
                        goingForward = false;

                        MessageBox.Show(obrazek.Name + " wygrała wyścig");
                        


                    }


                }



            }

        }            
        
        public void Reset() {
            if (obrazek != null) { obrazek.Left = 0; goingForward = true; } }
    }
}
