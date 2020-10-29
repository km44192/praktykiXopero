using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Popup_i_zakotwiczenie_WFApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void kotwica_Click(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                if (napis.Text == "" || napis.Text == "do Prawej") {
                    napis.Text = "do Lewej";
                    napis.TextAlign = ContentAlignment.TopLeft; }
                else
                {
                    napis.Text = "do Prawej";
                    napis.TextAlign = ContentAlignment.TopRight;
                }
            }
            else { napis.Text = "Możliowść zmiany została wyłączona";
                napis.TextAlign = ContentAlignment.TopCenter;
            }


        }
        private void wiadomosc_Click(object sender,EventArgs e)
        {
            pictureBox1.Visible = !pictureBox1.Visible;
            wiadomosci.Open();

        }

     

      
    
    }
}
