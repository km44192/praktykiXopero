using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie_Ul
{
    class NectarCollector:Robotnica
    {
        public int Nektar { get; set; }
        public void FindFlowers() { }
        public void GatherNectar() { }
        public void ReturnToHive() { }
        public NectarCollector(string[] work,int masa) : base(work, masa) { }
    }
}
