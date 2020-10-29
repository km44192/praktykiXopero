using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diaboliczne_kolory
{
    public partial class Form1 : Form
    { bool begin = false;
        int c = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            bool flag = true;
            begin = !begin;
            while (begin)
            { button1.Text = "Stop";
                if (flag==true)
                {
                    c++;
                   
                }
                else { c--; }
                if (c == 254|| c==0) flag = !flag;
                    BackColor = Color.FromArgb(c, 254 - c, c);
                    Application.DoEvents();
                     System.Threading.Thread.Sleep(10);
                
               

           
            }
            button1.Text = "Start";
        }
    }
}
