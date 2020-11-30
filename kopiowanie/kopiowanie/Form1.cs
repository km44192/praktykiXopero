using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            if (Directory.Exists(textBox2.Text))
            {
               copiing=copiing.ReadfromFile(@"D:/json.txt");
                Form2 form = new Form2(textBox1.Text, textBox2.Text,copiing);
                form.ShowDialog();
            }
            else if (!Directory.Exists(textBox2.Text))
            {
                DialogResult result =MessageBox.Show("Taka ścieżka nie istnieje \n czy utworzyć?", "Ostrzeżenie", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    try
                    {
                        Directory.CreateDirectory(textBox2.Text);
                       
                        Form2 form = new Form2(textBox1.Text, textBox2.Text, copiing);
                        form.ShowDialog();
                    }
                    catch (Exception bld)
                    {
                        MessageBox.Show("Wykryto błędny folder,Folder docelowy To: " + folderBrowserDialog2.SelectedPath.ToString());
                        textBox2.Text = folderBrowserDialog2.SelectedPath;
                        throw bld;
                    }
                    
                    

                    
            }
            else if(textBox2.Text=="")
                MessageBox.Show("Nie podano ścieżki docelowej");
            
        }
    }
}
