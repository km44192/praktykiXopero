using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    class Pies:Animal
    {
        override public string MakeNoise() { return "Dog makes wof wof"; }
      
        override public string Eat() { return "Dog likes tasty meats and  treats"; }

        public void CatchAndFetch() { }
    }

}
