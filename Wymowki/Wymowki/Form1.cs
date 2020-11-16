﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void openfi_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = selectedFolder;
            openFileDialog1.Filter = "Pliki tekstowe(*.txt)|*.txt| wszystkie pliki(*.*) |*.*";
            openFileDialog1.FileName = textBox1.Text + ".txt";
            DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
            {
                currentExcuse = new Excuse(openFileDialog1.FileName);
                UpdateForm(false);
            }
        }

        private void saveFi_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textBox1.Text)| String.IsNullOrEmpty(textBox2.Text)){
                MessageBox.Show("Określ wymówkę i rezultat", "Nie można zapisać pliku", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveFileDialog1.InitialDirectory = selectedFolder;
            saveFileDialog1.Filter = "Pliki tekstowe(*.txt)|*.txt| wszystkie pliki(*.*) |*.*";
            saveFileDialog1.FileName = textBox1.Text + ".txt";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK) ;
            {
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
            if(form)

        }
    }
}
