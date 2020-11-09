using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Dzidziczenie_rozdzial6
{
    class PodKlasa:KlasaBazowa
    {
        public PodKlasa(string podbaza,int value):base(podbaza) { MessageBox.Show("To jest klasa Pochodna: " + podbaza + " i " + value); }
    }
}
