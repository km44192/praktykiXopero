using System;
using System.Collections.Generic;
using System.Text;

namespace Urządzenia_Elektryczne
{
    public interface ICookFood
    {
       int Capacity { get; set; }

       void HeatUp();
        void ReHeat();

    }
}
