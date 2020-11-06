using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    class Lew:Animal
    {
        override public string MakeNoise() { return "Lion makes big rooar"; }
     
        override public string Eat() { return "Lion likes raw meat"; }
    }
}

