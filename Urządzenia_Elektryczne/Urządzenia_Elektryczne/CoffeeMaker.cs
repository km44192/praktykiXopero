using System;
using System.Collections.Generic;
using System.Text;

namespace Urządzenia_Elektryczne
{
    class CoffeeMaker:Appliance
    {
        public int CoffeLeft { get; set; }

        override public string ConsumePower() { return " Ekspres do kawy pobiera 2kW prądu "; }
        public void FillTheWater() { }
        public void MakeTheCoffe() { Console.Write("Robię kawusię\n"); }


    }
}
