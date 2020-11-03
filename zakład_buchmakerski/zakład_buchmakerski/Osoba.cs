using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace zakład_buchmakerski
{
    class Osoba
    {
        public string imie;
        public int konto;
        public Betting bet;
        public RadioButton moj_przycisk;
        public Label moja_etykieta;


        public void UpdateLabels() {   moj_przycisk.Text = imie + " ma na koncie" + konto + " zł"; }
        public void ClearBet() { bet.zakład = 0; bet.Rybka = ""; }
        public void Collect() { konto = konto + bet.PayOut(bet.Rybka); }
        public bool PlaceBet(int ammount,string whotowin) { if (ammount != 0 && whotowin != "") { ammount = bet.zakład; whotowin = bet.Rybka;return true; }   else return false; }

        public Osoba(string Imie, int kwota, Label label, RadioButton radio) { imie = Imie; konto = kwota; moja_etykieta = label; moj_przycisk = radio; }
    }
}
