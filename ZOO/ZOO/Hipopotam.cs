using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    class Hipopotam :Animal
    {
     override   public string MakeNoise() { return "Hippo makes wheez"; }
        public void Swim() { }
        override public string Eat() { return "Hipp likes fish"; }
    }
}
