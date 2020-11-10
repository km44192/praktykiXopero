using System;

namespace Urządzenia_Elektryczne
{
    class Program
    {
        
        static void Main()
        {
            /* Oven Piekarnik = new Oven();
             CoffeeMaker ekspres = new CoffeeMaker();
             ekspres.MonitorPower(ekspres);

             Appliance[] kuchnia = new Appliance[2];

             kuchnia[0] = Piekarnik;
             kuchnia[1] = ekspres;

             Appliance power = new CoffeeMaker();
             power.ConsumePower();
             //power.MakeTheCoffe();
             if (power is CoffeeMaker)
             {
                 CoffeeMaker ekspres2 = power as CoffeeMaker;
                 ekspres2.MakeTheCoffe();


             }*/

            Oven toster = new Oven();
            toster.Capacity = 10;
            ICookFood grzalka;
            if(toster is ICookFood)
            {
                grzalka = toster as ICookFood;
                grzalka.Capacity = 12;
            }

            Appliance pozeracz;
            if(toster is Appliance)
            {
                pozeracz = toster as Appliance;
                pozeracz.Color = "Magenta";
            }
            Console.WriteLine("Hello World!");
        }
    }
}
