using System;
using System.Collections.Generic;
using System.Text;

namespace Urządzenia_Elektryczne
{
    class Oven:Appliance,ICookFood
    {
        public int Capacity { get; set; }

        public void Preheat()
        {

        }
        
        public void HeatUp() { }
        public void ReHeat() { }
      //  override public string ConsumePower() { return " Piekarnik pobiera 2.5kW prądu "; }
        

    }
}
