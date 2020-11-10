using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie_Ul
{
    class NectarStinger : Robotnica, INectarCollector, IStingPatrol { 
        public int AlertLevel { get; private set; }
        public string Job { get; }
        public int StingerLength { get; set; }
        public int Nectar { get; set; }

        public bool LookForEnemies
        {
            get;
            
        }

        public int SharpenStinger(int Length) { return Length; }

        public void DoThisJob(string[] job, int shifts) { }
        public void FindFlowers() { }
        public void GatherNectar() { }
        public void ReturnToHive() { }

public NectarStinger(string[] whatToDo,int masa) : base(whatToDo,masa) { }

    }
}
