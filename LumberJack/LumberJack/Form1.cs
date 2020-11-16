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
            groupBox1.Enabled = false;
        }
      private  Queue<Lumberjack> kolejkasniadanie = new Queue<Lumberjack>();
       

        private void AddLumber_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textImie.Text)) return;
            kolejkasniadanie.Enqueue(new Lumberjack(textImie.Text));
            textImie.Text = "";
            RedrawList();

        }
        private void RedrawList()
        {
            int number = 1;
            text.Items.Clear();
            foreach (Lumberjack lumberjack in kolejkasniadanie)
            {
                text.Items.Add(number + ". " + lumberjack.Name);
                number++;
            }
            if(kolejkasniadanie.Count==0)
            {
                groupBox1.Enabled = false;
                LamberInfo.Text = "";
            }
            else
            {
                groupBox1.Enabled = true;
                Lumberjack currJack = kolejkasniadanie.Peek();
                LamberInfo.Text = currJack.Name + " ma " + currJack.FlapjackCount + " naleśników";
                
            }




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

            Lumberjack currJack = kolejkasniadanie.Peek();
            currJack.TakeFlapjacks(food, (int)Ile.Value);
            RedrawList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (kolejkasniadanie.Count == 0) return;
            Lumberjack nextjack = kolejkasniadanie.Dequeue();
            nextjack.EatFlapjacks();
            LamberInfo.Text = "";
            RedrawList();
        }
    }
}
