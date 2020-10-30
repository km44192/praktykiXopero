using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Powtarzanie_slow
{
    public partial class Form1 : Form
    {
   

        public Form1()
        {
            InitializeComponent();
        }

     private void klik(object sender,EventArgs e) 
        {
             
            MessageBox.Show("Długość tekstu wynosi: "+gadacz.papuga(textBox1.Text, Int32.Parse((string)comboBox1.SelectedItem)).ToString());


        }


       

    }



       
}
