using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyścig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Wlepy[] biegacz = new Wlepy[3];

        private void move1(int index,Label info)
        {
            if (biegacz[index] == null) { biegacz[index] = new Wlepy();
                biegacz[index].MyLabel = info;
            }
            else { biegacz[index] = null; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            move1(0, label1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            move1(1, label2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            move1(2, label3);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < 3; i++)
            {
                if (biegacz[i] != null) { biegacz[i].move(); }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true ;
        }
    }
}
