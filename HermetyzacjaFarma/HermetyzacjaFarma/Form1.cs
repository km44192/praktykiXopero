using System;
using System.Windows.Forms;

namespace HermetyzacjaFarma
{
    public partial class Form1 : Form
    {
       // Farma Marcin = new Farma(12,10);
        public Form1()
        {
            InitializeComponent();

        }
        Farma x = new Farma(10, 20);
        private void Button1_Click(object sender, EventArgs e)
        {
          
           // Marcin.IleKrow = (int)numericUpDown1.Value;

            System.Diagnostics.Debug.WriteLine("Farmer ma {0} krów i potrzebuje {1} worków paszy ",x.IleKrow,x.izleWorków);
            
        }
    }
}
