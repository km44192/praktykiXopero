using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    class Wilk:Animal
    {
        override public string MakeNoise() { return "Wolf makes auuu"; }
       
        override public string Eat() { return "Wolf likes lamb"; }
    }

}
