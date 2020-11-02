using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elephant
{
    public partial class Form1 : Form
    {
        Elephant piotr,michal;

        private void button2_Click(object sender, EventArgs e)
        {
            michal.WhoAmI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            piotr.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant dominik;
            dominik = piotr;
            piotr = michal;
            michal = dominik;
            MessageBox.Show("Obiekty Zamienione");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            piotr = michal;
            piotr.Earsize = 4451;
            piotr.WhoAmI();
            michal.SpeakTo(piotr, "witam");
        }

        public Form1()
        {
            InitializeComponent();
            piotr = new Elephant { Name = "Piotrek", Earsize = 100 };
            michal = new Elephant { Name = "Michał", Earsize = 70 };
        }

    }
}
