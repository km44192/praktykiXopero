using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking
{
    public partial class Form1 : Form
    {
        
            Guy Pawel = new Guy("Pawel", 100);
            Guy Roman = new Guy("Roman", 300);
        public Form1()
        {
            InitializeComponent();
            opisPawel.Text = Pawel.NameInfo() + " posiada " + Pawel.AccountInf() + " zł \n";
            opisRoman.Text = Roman.NameInfo() + " posiada " + Roman.AccountInf() + " zł \n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OpPawel.Checked) { Pawel.ReciveMoney(int.Parse(textBox1.Text));}
            else if (opRoman.Checked) { Roman.ReciveMoney(int.Parse(textBox1.Text)); }
            opisPawel.Text = Pawel.NameInfo() + " posiada " + Pawel.AccountInf() + " zł \n";
            opisRoman.Text = Roman.NameInfo() + " posiada " + Roman.AccountInf() + " zł \n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (OpPawel.Checked && opRoman.Checked) { MessageBox.Show("Zabroniona operacja"); }
            else if (OpPawel.Checked) { Roman.giveMoney(int.Parse(textBox1.Text)); Pawel.ReciveMoney(int.Parse(textBox1.Text)); }
            else if (opRoman.Checked)
            { Pawel.giveMoney(int.Parse(textBox1.Text)); Roman.ReciveMoney(int.Parse(textBox1.Text)); }
            else
                MessageBox.Show("Brak operacji");
            opisPawel.Text = Pawel.NameInfo() + " posiada " + Pawel.AccountInf() + " zł \n";
            opisRoman.Text = Roman.NameInfo() + " posiada " + Roman.AccountInf() + " zł \n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(OpPawel.Checked && opRoman.Checked) { Pawel.takeout(int.Parse(textBox1.Text)); Roman.takeout(int.Parse(textBox1.Text)); }
            else if(OpPawel.Checked) Pawel.takeout(int.Parse(textBox1.Text));
            else if(opRoman.Checked) Roman.takeout(int.Parse(textBox1.Text));
            opisPawel.Text = Pawel.NameInfo() + " posiada " + Pawel.AccountInf() + " zł \n";
            opisRoman.Text = Roman.NameInfo() + " posiada " + Roman.AccountInf() + " zł \n";
        }
    }
}
