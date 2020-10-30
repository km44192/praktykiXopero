using System;
using System.Collections.Generic;
using System.Text;

namespace Fabryka_batonow
{
    class Maker
    {
        public void CheckAirSystem() { }
        public int CheckNaughtTemperature() { int temp;
            Random x = new Random();
            temp = x.Next(0, 200);
            return temp;
        }
    }
}
