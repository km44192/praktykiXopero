using System;
using System.Collections.Generic;
using System.Text;

namespace Urządzenia_Elektryczne
{
    class Microwave:Appliance,ICookFood
    {

        public int Capacity { get; set; }

        public void HeatUp() { }
        public void ReHeat() { }
        public void MakePopcorn() { }

    }
}
