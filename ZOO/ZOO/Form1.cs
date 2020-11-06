using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZOO
{
    public partial class Form1 : Form
    {
        Hipopotam hip = new Hipopotam();
        Tygrys tiger = new Tygrys();
        Wilk wolf = new Wilk();
        Lew lion = new Lew();
        Kot cat = new Kot();
        Pies dog = new Pies();
      

        int i = 0;
        public Form1()
        {
            InitializeComponent();
           
        
        }

        private void TryIt_Click(object sender, EventArgs e)
        {
            displayAnimal();
        }
        private void displayAnimal() {
            i++;
            switch (i)
            {
                case 1:
                    label1.Text = hip.MakeNoise();

                    break;
                case 2:
                    label1.Text = tiger.MakeNoise();

                    break;
                case 3:
                    label1.Text = wolf.MakeNoise();

                    break;
                case 4:
                    label1.Text = lion.MakeNoise();
                    break;
                case 5:
                    label1.Text = cat.MakeNoise();

                    break;
                case 6:
                    label1.Text = dog.MakeNoise();
                    i = 0;
                    break;
            }
        }
    }
}
