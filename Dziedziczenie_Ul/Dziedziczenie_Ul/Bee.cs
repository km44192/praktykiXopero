using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie_Ul
{
    class Bee
    {
        public const double HoneyConsumedPerMg = .25;
        public double WeightMg { get; private set; }

        public Bee(double weightMg)
        {
            WeightMg = weightMg;
        }
        virtual public double HoneyConsumptionRate() { return WeightMg * HoneyConsumedPerMg; }

    }
}
