using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LumberJack
{
    public partial class Form1 : Form
    {//JESZCZE NIE SKOŃCZONE 13-11-2020
        public Form1()
        {
            InitializeComponent();
        }
        Queue<Lumberjack> kolejkasniadanie = new Queue<Lumberjack>();
       

        private void AddLumber_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textImie.Text)) return;
            kolejkasniadanie.Enqueue(new Lumberjack(textImie.Text));

        }
        private void RedrawList()
        {
            int number = 1;
           text.C
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Flapjack food;
            if (Op1.Checked == true)
                food = Flapjack.Chrupkiego;
            else if (Op2.Checked == true)
                food = Flapjack.Wilgotnego;
            else if (Op3.Checked == true)
                food = Flapjack.Rumianego;
            else 
                food = Flapjack.Bananowego;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
