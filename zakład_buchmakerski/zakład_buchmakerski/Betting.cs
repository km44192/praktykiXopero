using System;
using System.Collections.Generic;
using System.Text;

namespace zakład_buchmakerski
{
    class Betting
    {
        public int zakład;
        public string Rybka;
        public Osoba kto;

          public string GetDescription() { if (zakład > 0) { return string.Format(kto.imie + " obstawił " + zakład + " zł na rybkę " + Rybka); }
            else return string.Format(kto.imie + " nie złożył oferty");
                }
        public int PayOut(string winner) {if (Rybka != null) if (Rybka == winner) { return zakład; }
                else { return -zakład; }
            else return 0;
        }
    }
}
