using System;
using System.Collections.Generic;
using System.Text;

namespace Urządzenia_Elektryczne
{
    class Appliance
    {
        public bool PluggedIn;
        public string Color;

       virtual public string ConsumePower() { return "1"; }
        public void MonitorPower(Appliance appliance) { Console.WriteLine(ConsumePower()); }
    }
}
