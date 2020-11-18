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
using System.Runtime.Serialization.Formatters.Binary;

namespace Wymowki
{
    public partial class Form1 : Form
    {//do skończenia
        private Excuse currentExcuse = new Excuse();
        private string selectedFolder = "";
        private bool formChanged = false;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                currentExcuse = new Excuse(random, selectedFolder);
                UpdateForm(false);
            }

        }

        private void openfi_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = selectedFolder;
            openFileDialog1.Filter = "Pliki tekstowe(*.txt)|*.txt| wszystkie pliki(*.*) |*.*";
            openFileDialog1.FileName = textBox1.Text + ".txt";
            DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
            {
               using(Stream input = File.OpenRead(openFileDialog1.FileName))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    currentExcuse = (Excuse)bf.Deserialize(input);
                }
                
                UpdateForm(false);
            }
        }

        private void saveFi_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox1.Text)|| !String.IsNullOrEmpty(textBox2.Text)){
                MessageBox.Show("Określ wymówkę i rezultat", "Nie można zapisać pliku", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveFileDialog1.InitialDirectory = selectedFolder;
            saveFileDialog1.Filter = "Pliki tekstowe(*.txt)|*.txt| wszystkie pliki(*.*) |*.*";
            saveFileDialog1.FileName = textBox1.Text + ".txt";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK) ;
            {
                using (Stream output = File.OpenWrite(saveFileDialog1.FileName))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(output, currentExcuse);
                }
                UpdateForm(false);
                MessageBox.Show("Wymówka zapisana");
            }


        }

        private void choose_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = selectedFolder;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result ==DialogResult.OK)
            {
                selectedFolder = folderBrowserDialog1.SelectedPath;
                saveFi.Enabled = true;
                openfi.Enabled = true;
                button4.Enabled = true;
            }

        }

        private bool CheckChanged()
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show("Bieżąca wymówka nie została zapisana. Czy kontynuować?", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return false;

            }
            return true;
        }
        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                textBox1.Text = currentExcuse.Description;
                textBox2.Text = currentExcuse.Results;
                lastUsed.Value = currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                    textBox3.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                this.Text = "Program do zarządzania wymówkami*";

            }
            else
                this.Text = "Program do zarządzania wymówkami*";
            this.formChanged = changed;
        }

        private void description_textChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = textBox1.Text;
            UpdateForm(true);
        }

        private void Result_textChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = textBox2.Text;
            UpdateForm(true);
        }

        private void lastUsed_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = lastUsed.Value;
            UpdateForm(true);
        }
    }
}
