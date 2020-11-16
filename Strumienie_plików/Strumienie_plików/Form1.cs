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

namespace Strumienie_plików
{
    public partial class Form1 : Form
    {
        private string name;   
        public Form1()
        {
            InitializeComponent();
            
        }

        private void openF_Click(object sender, EventArgs e)
        {
            openFile.InitialDirectory = @"C:\Users\";
            openFile.Filter = "Pliki tekstowe(*.txt)|*.txt| Pliki z wartościami oddzielonymi przecinkiem(*.csv)|*.csv| wszystkie pliki(*.*) |*.*";
            openFile.FileName = "";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                name = openFile.FileName;
                
            }
            text.Clear();
            text.Text=File.ReadAllText(name);

        }

        private void saveF_Click(object sender, EventArgs e)
        {
            saveFl.InitialDirectory = @"C:\Documents and Settings";
            saveFl.Filter= "Pliki tekstowe(*.txt)|*.txt";
            saveFl.FileName = "";
            saveFl.Title="Zapisy dla chętnych";
            if(saveFl.ShowDialog()==DialogResult.OK)
            {
                name = saveFl.FileName;
                File.WriteAllText(name,text.Text);
            }

        }

     
    }
}
