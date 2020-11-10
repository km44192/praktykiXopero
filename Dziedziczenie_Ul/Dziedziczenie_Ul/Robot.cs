using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie_Ul
{
    public class Robot
    {
        public void ConsumeGas() { }
    }

    public class RoboBee:Robot,IWorker
    {


        private int shiftsToWork;
        private int shiftsWorked;
        public int ShiftsLeft { get { return shiftsToWork - shiftsWorked; } }
        public string Job { get; }
      public  void DoThisJob(string[] job, int shifts)
        {
           
           
        }
        public void WorkOneShift() { }
    }
}
