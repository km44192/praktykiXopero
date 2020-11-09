using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Planowanie_przyjęcia
{
    class DinnerParty:Party
    {
     
 
        public bool fit { get; set; }
    
     

   public DinnerParty(int numofpeople,bool healthyOption,bool deco) { IloscGosci = numofpeople;  fit = healthyOption; this.deco = deco; }

        private decimal ZdroweJedzenie()
        {
            decimal costOfdrinks;
            if (fit)
             costOfdrinks = 5.00M;
            else
             costOfdrinks = 20.00M;
            return costOfdrinks;
            
        }
  
        override public decimal Cost
        {
            get {
                decimal totalCost;
                if (fit)
                {
                    totalCost = ((ZdroweJedzenie() + 25) * IloscGosci) * 0.95M;
                    return totalCost;
                }
                else
                {
                    totalCost = ((ZdroweJedzenie() + 25) * IloscGosci);
                    return totalCost;
                }
            }
        }
       

    }
}
