using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Elephant
{
    class Elephant
    {
        public int Earsize;
        public string Name;
        public void WhoAmI() { MessageBox.Show("Moje uszy mają " + Earsize + " centymetrów długości", Name + " mówi..."); }

        public void TellMe(string message,Elephant Whospeaks) { MessageBox.Show(Whospeaks.Name + " mówi: " + message); }

        public void SpeakTo(Elephant whoto, string message) { whoto.TellMe(message, this); }
    }
}
