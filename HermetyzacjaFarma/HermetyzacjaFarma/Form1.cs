using System;
using System.Windows.Forms;

namespace HermetyzacjaFarma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Farma Marcin = new Farma();
            Marcin.IleKrow = (int)numericUpDown1.Value;

            System.Diagnostics.Debug.WriteLine("Farmer ma {0} krów i potrzebuje {1} worków paszy ", Marcin.IleKrow, Marcin.ileWorków);
            
        }
    }
}
