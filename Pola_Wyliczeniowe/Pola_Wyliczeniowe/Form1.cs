using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pola_Wyliczeniowe
{
    public partial class Form1 : Form
    {
        List<Card> talia = new List<Card>();
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();

        private void Show_Click(object sender, EventArgs e)
        {
           

            if (i < 14) {
                
                talia.Add(new Card((Suits)random.Next(4), (Values)(i+1)));
                label1.Text = talia[i].Name;
                i++;
            }
           
                 
           
        }
    }
}
