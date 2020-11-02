using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rachunki_za_paliwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void licz(object sender, EventArgs e)
        {
            int start = (int)pole1.Value;
            int stop = (int)pole2.Value;
            float wynik;
            if (stop > start)
            {
                wynik = (stop - start) * (float)0.0425*7;
                kwota.Text = wynik.ToString() + " zł";
            }
            else { MessageBox.Show("Przebieg końcowy nie może byc mniejszy niż początkowy"); }
        }
        private void dist(object sender, EventArgs e) { int begin = (int)pole1.Value;int end= (int)pole2.Value;
            int wynik = end - begin;
            MessageBox.Show(wynik.ToString() + " km");
        }
    }
}
