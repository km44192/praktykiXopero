using System;
using System.Collections.Generic;
using System.Text;

namespace Jubiler_i_zlodziej
{
    class Ślusarz
    {
        public void OpenSafe(Sejf sejf,Wlasciciel wlasciciel) 
        { 
            sejf.PickLock(this);
            Jubiler bezpiecznaZawartosc = sejf.Open(sHaslo);
            zwrocZawartosc(bezpiecznaZawartosc, wlasciciel);            
        }
        private string sHaslo = null;
        public void Przepiszhaslo(string haslo) {
            sHaslo = haslo;
        }
        public virtual void zwrocZawartosc(Jubiler zawartosc,Wlasciciel wlasciciel) { wlasciciel.OtrzymanaZawartosc(zawartosc); }

    }
}
