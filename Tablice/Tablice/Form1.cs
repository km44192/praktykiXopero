using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tablice
{
    public partial class Form1 : Form
    {
        MenuMaker dm= new MenuMaker() { Randomizer = new Random()};
        public Form1()
        {
            InitializeComponent();
         label1.Text=   dm.GetMenuItem();
          label2.Text=   dm.GetMenuItem();
           label3.Text= dm.GetMenuItem();
            label4.Text=dm.GetMenuItem();
          label5.Text=  dm.GetMenuItem();

        }
    }
}
