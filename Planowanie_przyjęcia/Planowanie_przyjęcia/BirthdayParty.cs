using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Windows.Forms;

namespace Planowanie_przyjęcia
{
    class BirthdayParty : DinnerParty
    {
        public const int stalaOplata = 25;

       public string CakeWriting { get; set; }
       public int IloscGosci { get; set; }

        public BirthdayParty(int numberofguests,bool ozdoby,string napisNaTort) { Partyamm(numberofguests); deco = ozdoby;CakeWriting = napisNaTort; IloscGosci = numberofguests; }

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
        public bool CakeWritingTooLong { get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return true;
                else return false;
            } }
      
        private decimal CakeCost { get { if (CakeSize() == 20) return 25.00M; else return 75.00M; } }
        public decimal KosztimprezyUrodzinowe()
        {
            decimal totalCost = 0;
            totalCost = KosztOzdob()+CakeCost+(IloscGosci*stalaOplata);
            
             totalCost += (ActualLength * 0.25M);
            if (IloscGosci > 12)
                totalCost += 100;
         
            return totalCost;
        }

        public string WriteAlert() { if (CakeWritingTooLong) return "Napis za długi"; else return "OK"; }
    }
}
