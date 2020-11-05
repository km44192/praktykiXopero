using System;
using System.Collections.Generic;
using System.Text;

namespace HermetyzacjaFarma
{
    class Farma
    {

        public const int paszaNaJednostke=30;
        public int ileWorków;
        private int ileKrow;
        public int IleKrow { get { return ileKrow; } set { ileKrow = value; ileWorków = ileKrow * paszaNaJednostke;  } }
    }
}
