using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kopiowanie
{
    public partial class Form1 : Form
    {
        Copiing_Operator copiing = new Copiing_Operator();
        public Form1()
        {
            
            InitializeComponent();
            
        }
        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = @"C:\";
            folderBrowserDialog1.ShowDialog();
            string k = folderBrowserDialog1.SelectedPath;
        //    MessageBox.Show(k);
            textBox1.Text = k;   
        }
        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            folderBrowserDialog2.SelectedPath = @"C:\";
            folderBrowserDialog2.ShowDialog();
            string k = folderBrowserDialog2.SelectedPath;
          //  MessageBox.Show(k);
            textBox2.Text = k;
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if (textBox2.Text==folderBrowserDialog2.SelectedPath)
            {
               copiing=copiing.ReadfromFile(@"D:/json.txt");
                Form2 form = new Form2(textBox1.Text, textBox2.Text,copiing);
                form.ShowDialog();
            }
            else
                MessageBox.Show("Nie podano ścieżki docelowej");
            
        }
    }
}
