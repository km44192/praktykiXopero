using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Windows.Forms;

namespace Planowanie_przyjęcia
{
    class BirthdayParty : Party
    {


        public string CakeWriting { get; set; }



        public BirthdayParty(int numberofguests, bool ozdoby, string napisNaTort) { IloscGosci = numberofguests; deco = ozdoby; CakeWriting = napisNaTort; }
        private int ActualLength
        {

            get { if (CakeWriting.Length > MaxWritingLength()) return MaxWritingLength(); else return CakeWriting.Length; }


        }
        private int CakeSize()
        {
            if (IloscGosci <= 4) return 20;
            else return 40;
        }
        private int MaxWritingLength() { if (CakeSize() == 20) return 16; else return 40; }
        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return true;
                else return false;
            }
        }


        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                decimal CakeCost;
                if (CakeSize() == 20) CakeCost = 25.00M; else CakeCost = 75.00M;
                totalCost += CakeCost;

                totalCost += (ActualLength * 0.25M);


                return totalCost;
            }
        }

        public string WriteAlert() { if (CakeWritingTooLong) return "Napis za długi"; else return "OK"; }

    }
}
