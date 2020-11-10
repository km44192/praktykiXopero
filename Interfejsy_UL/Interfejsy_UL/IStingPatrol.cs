using System;
using System.Collections.Generic;
using System.Text;

namespace Interfejsy_UL
{
    interface IStingPatrol
    {
        int AlertLevel { get; set; }
        int StingLength { get; set; }
        bool LookForEnemies();
        int SharpenStinger(int Length);
    }
}
