using System;
using System.Collections.Generic;
using System.Text;

namespace Jubiler_i_zlodziej
{
    class Sejf
    {
        private Jubiler zawartosc = new Jubiler();
        private string haslo = "12345";
        public Jubiler Open(string hack) { if (hack == haslo) return zawartosc; else return null; }
        public void PickLock(Ślusarz ślusarz)
        { 
            ślusarz.Przepiszhaslo(haslo);
          
        

        }
    }
}
