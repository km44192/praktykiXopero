using System;
using System.Collections.Generic;
using System.Text;

namespace Cyrk_Interfacy
{
   public class FunnyFunny:IClown
    {
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }
        private string funnyThingIHave;
        public string FunnyThingIHave { get { return "Cześć Dzieciaki mam " + funnyThingIHave; } }
        public void Honk() { Console.WriteLine(FunnyThingIHave); }
    }
}
