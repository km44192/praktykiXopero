using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie_Ul
{
     public interface IWorker
    {
        string Job { get; }
        void DoThisJob(string[] job, int shifts);
        void WorkOneShift();
    }
}
