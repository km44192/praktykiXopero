using System;
using System.Collections.Generic;
using System.Text;

namespace Jubiler_i_zlodziej
{
    class Zlodziej:Ślusarz
    {
        private Jubiler ukradzione = null;
       new public  void zwrocZawartosc(Jubiler zawartosc,Wlasciciel wlasciciel) { ukradzione = zawartosc; Console.WriteLine("Kradnę zawartośc sejfu! " + zawartosc.Lsnij()); }
    }
}
