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


        public void UpdateLabels() {   moj_przycisk.Text = imie + " ma na koncie " + konto + " zł"; }
        public void ClearBet() { bet.zakład = 0; bet.Rybka = ""; }
        public void Collect(string ryba) { konto = konto + bet.PayOut(ryba); }
        public bool PlaceBet(int ammount,string whotowin) { if (ammount != 0 && whotowin != "") {  bet.zakład=ammount;  bet.Rybka=whotowin;return true; }   else return false; }

        public Osoba(string Imie, int kwota) { imie = Imie; konto = kwota; bet = new Betting() { zakład = 0, Rybka = "", kto =this}; }

        
    }
}
