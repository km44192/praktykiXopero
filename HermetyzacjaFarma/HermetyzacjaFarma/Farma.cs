using System;
using System.Collections.Generic;
using System.Text;

namespace HermetyzacjaFarma
{
    class Farma
    {

        //public const int paszaNaJednostke=30;
        public int ileWorków;
        private int ileKrow;
        private int paszaNaJednostke;
        public int paszaNajednostke { get { return paszaNaJednostke; }set {  paszaNaJednostke= value; } }
        public int IleKrow { get { return ileKrow; } set { ileKrow = value; ileWorków = ileKrow * paszaNajednostke;  } }
        
        public Farma(int ilekrow,int paszanajednostke)
        {
            paszaNajednostke = paszanajednostke;
            IleKrow = ilekrow;

        }

    }
}
