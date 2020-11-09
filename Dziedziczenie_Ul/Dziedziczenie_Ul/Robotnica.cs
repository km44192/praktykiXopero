using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace Dziedziczenie_Ul
{
    class Robotnica:Bee
    {
        public Robotnica(string[] coMogeZrobic,double waga):base(waga) { jobsICanDo = coMogeZrobic; }
        
      

        private string currentJob="";
        public string CurrentJob { get { return currentJob; } }
        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;
        public int ShiftsLeft { get { return shiftsToWork - shiftsWorked; } }

            public bool DoThisJob(string job,int numofshifts) {
            if (!string.IsNullOrEmpty(CurrentJob)) return false;
            for(int i = 0; i < jobsICanDo.Length; i++)
                if (jobsICanDo[i] == job) 
                { currentJob = job; 
                    shiftsToWork = numofshifts; 
                    shiftsWorked = 0; 
                    return true; 
                }
            return false; 
        }
       
        public void WorkOneShift() { }
        public bool DidYouFinish() { 
            if (string.IsNullOrEmpty(currentJob))
                return false;shiftsWorked++;
            if (shiftsWorked > shiftsToWork) 
            { shiftsWorked = 0; 
                shiftsToWork = 0; 
                currentJob = ""; 
                return true; 
            }else 
                return false; 
        }

        override public double HoneyConsumptionRate() { double consumption = base.HoneyConsumptionRate();
            consumption += shiftsWorked * HoneyConsumedPerMg;
            return consumption;
        }
    }
}
