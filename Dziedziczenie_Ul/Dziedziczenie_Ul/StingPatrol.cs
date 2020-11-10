using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Dziedziczenie_Ul
{
    class StingPatrol:Robotnica
    {
        public int StingerLength { get; private set; }
        public int AlertLevel { get; set; }
        public bool SharpenStinger(int Length)
        {
            if (Length > 0)
                return true;

            return false;
        }
        public bool LookForEnemies(int isEnemy) { 
        if(isEnemy==0)
            return true;
        else
            return false;
        }
        public void Sting() {
            Random xx = new Random();
          
           int  isEnemy = xx.Next(0, 1);

            if (LookForEnemies(isEnemy))
            {
                AlertLevel = xx.Next(0, 5);
      
            switch (AlertLevel)
                {
                    case 1:
                        MessageBox.Show("mrówki zaatakowały ul");
                       
                        break;
                    case 2:
                        MessageBox.Show("Osy zaatakowały ul");
                        break;
                    case 3:
                        MessageBox.Show("Pająki zaatakowały ul");
                        break;
                    case 4:
                        MessageBox.Show("Szerszenie zaatakowały ul");
                        break;
                    case 5:
                        MessageBox.Show("Królowa w niebezpieczeństwie");
                        break;
                    default:
                        break;
                }
               
            } 
            MessageBox.Show("Obszar bezpieczny");
        }
        override public double HoneyConsumptionRate()
        {
            double consumption = base.HoneyConsumptionRate();
            consumption += AlertLevel * HoneyConsumedPerMg;
            return consumption;
        }
        public StingPatrol(string[] work, int masa) : base(work, masa) { }
        
    }
}
