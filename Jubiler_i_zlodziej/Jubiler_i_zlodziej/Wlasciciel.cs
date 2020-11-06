using System;
using System.Collections.Generic;
using System.Text;

namespace Jubiler_i_zlodziej
{
    class Wlasciciel
    {
        private Jubiler zwroconyContent;
        public void OtrzymanaZawartosc(Jubiler zawartosc) { zwroconyContent = zawartosc;
            Console.WriteLine("Dziękuję za zwrócenie klejnotów!" + zwroconyContent.Lsnij());
        }
    }
}
