using System;
using System.Collections.Generic;
using System.Text;

namespace Interfejsy_UL
{
    class Bee:IStingPatrol
    {
        public int AlertLevel { get; set; }
        public int StingLength { get; set; }
        public bool LookForEnemies() { return false; }
        public int SharpenStinger(int Length) { return Length; }
    }
}
