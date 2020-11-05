using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KodAgent
{
    public partial class Form1 : Form
    {
        CiaAgent american = new CiaAgent();
        KGBAgent putin = new KGBAgent();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string test="";
            putin.greet = textBox1.Text;
            for(int i = 0; i < putin.greet.Length; i++)
            {
                test =test+string.Format("." + putin.greet[i]);
            }
            MessageBox.Show(test);
            american.greet = putin.greet;
            label2.Text = american.AgentGreeting();

            
        }
    }
}
