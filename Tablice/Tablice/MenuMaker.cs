using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Tablice
{
    class MenuMaker
    {
        public Random Randomizer;

        string[] Meats = { "Wołowina", "wieprzowina", "baranina", "dziczyzna", "karkówka", "kurczak", "indyk" };
        string[] Condiments = { "musztarda", "ketchup", "majonez", "sól", "pieprz", "przyprawy", "sos" };
        string[] Breads = { "chleb ryżowy", "chleb żytni", "chleb pszenny", "falafel", "bułka", "tortilla" };

      public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCond = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBr = Breads[Randomizer.Next(Breads.Length)];
            return randomMeat + ", " + randomCond + ", " + randomBr;

        }
    }
}
