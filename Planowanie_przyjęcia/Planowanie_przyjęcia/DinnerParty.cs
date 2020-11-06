using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Planowanie_przyjęcia
{
    class DinnerParty
    {
        private const int stalaoplata = 25;
        private int numOfGuests;
        public bool fit { get; set; }
        public bool deco { get; set; }
     

        private int GetNumOfGuests()
        {
            return numOfGuests;
        }

        public void Partyamm(int goscie){ numOfGuests = goscie; GetNumOfGuests();   }

        private decimal ZdroweJedzenie()
        {
            decimal costOfdrinks;
            if (fit)
             costOfdrinks = 5.00M;
            else
             costOfdrinks = 20.00M;
            return costOfdrinks;
            
        }
        public decimal KosztOzdob() {
            decimal costOfDecoration,decocost;
            if (deco) 
            {
                costOfDecoration = 50.00M; decocost = 15.00M; 
            }
            else 
            {
                costOfDecoration = 30.00M;
                 decocost = 7.5M; 
            }
            decocost = decocost * numOfGuests;
            costOfDecoration = decocost + costOfDecoration;
            return costOfDecoration;
            
        }
        public decimal KosztImprezy(bool fit)
        {
           decimal totalcost = 0;
            if (fit)
            {
                totalcost = (((ZdroweJedzenie() + stalaoplata) * numOfGuests) + KosztOzdob()) * 0.95M;
                return totalcost;
            }
            else
                {
                totalcost = ((ZdroweJedzenie()+stalaoplata) * numOfGuests) + KosztOzdob();
                return totalcost;
            }
        }
       

    }
}
