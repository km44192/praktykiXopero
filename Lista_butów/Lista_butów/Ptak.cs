using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_butów
{
   public class Ptak
    {
        public string Name { get; set; }

       virtual public void Fly() { Console.WriteLine("Frr..   Frr..."); }
        public override string ToString()
        {
            return "Ptak " + Name; 
                
        }
    }
}
