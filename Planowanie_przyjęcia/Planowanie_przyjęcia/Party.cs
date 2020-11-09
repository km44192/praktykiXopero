using System;
using System.Collections.Generic;
using System.Text;

namespace Planowanie_przyjęcia
{
    class Party
    {
        public int IloscGosci { get; set; }
   
        public bool deco { get; set; }
        

        private decimal KosztOzdob()
        {
            decimal costOfDecoration;
            if (deco)
            {
                costOfDecoration = (IloscGosci * 15.00M) + 50M; 
            }
            else
            {
                costOfDecoration = (IloscGosci * 7.50M) + 30M;
            }
            
            return costOfDecoration;

        }


        virtual public decimal Cost { get
            {
                decimal totalCost = KosztOzdob();
                totalCost += 25 * IloscGosci;

                if (IloscGosci > 12)
                    totalCost += 100;
                return totalCost;
            } }

    }
}
