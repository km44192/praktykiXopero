using System;
using System.Collections.Generic;
using System.Text;

namespace Klauny
{
    class clown
    {
        public string imie;
        public int height;


        public void TalkAboutYourself()
        {
            Console.Write("Nazywam się {0} i mam {1} centymetów wzorstu\n", imie, height);
        }
        public clown() { imie = ""; height = 0; }
    }
}
