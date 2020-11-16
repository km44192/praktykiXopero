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
namespace Okno_dialogowe
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        private void OpenSomeFile(string name)
        {
            richTextBox1.Text = "";
            StreamReader x = new StreamReader(name);
            while (!x.EndOfStream)
                richTextBox1.Text = richTextBox1.Text + x.ReadLine() + "\n";


        }
        private void SaveFile(string name)
        {
        StreamWriter x = new StreamWriter(name, true);
            x.WriteLine(richTextBox1.Text);
            x.Close();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            dialogOpener.InitialDirectory = @"C:\Users\";
            dialogOpener.Filter = "Pliki tekstowe (*.txt)|*.txt| Pliki z wartościami oddzielonymi przecinkiem (*.csv)|*.csv| wszystkie pliki (*.*)|*.*";
            dialogOpener.FileName = "plk_domyślny.txt";
            dialogOpener.CheckFileExists = true;
            dialogOpener.CheckPathExists = false;

            DialogResult result = dialogOpener.ShowDialog();
            if (result == DialogResult.OK)
            {
                OpenSomeFile(dialogOpener.FileName);
            }

        }

        private void saveTo_Click(object sender, EventArgs e)
        {
            saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = @"C:\Users\";
            saveFile.Filter = "Pliki tekstowe (*.txt)|*.txt| Pliki z wartościami oddzielonymi przecinkiem (*.csv)|*.csv| wszystkie pliki (*.*)|*.*";
            DialogResult result = saveFile.ShowDialog();
            if(result == DialogResult.OK)
            {
                SaveFile(saveFile.FileName);
            }
        }
    }
}
