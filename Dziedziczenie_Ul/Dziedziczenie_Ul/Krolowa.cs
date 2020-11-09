using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie_Ul
{
    class Krolowa:Bee
    {
        public Krolowa(Robotnica[] x,double masa) : base(masa) { robotnice = x; }

        private Robotnica[] robotnice;
        private int NumerZmiany=0;

        
        public bool AssignWork(string job,int numofShifts) {
             for(int i = 0; i < robotnice.Length; i++)
                if (robotnice[i].DoThisJob(job, numofShifts))
                    return true;
               
                return false;
        }
       public string WorkTheNextShift() {

            double honeyConsumed = HoneyConsumptionRate();
            NumerZmiany++;
            string report = "Raport zmiany numer: " + NumerZmiany + "\r\n"; 
            for(int i = 0; i < robotnice.Length; i++) 
            {
                honeyConsumed += robotnice[i].HoneyConsumptionRate();
                if (robotnice[i].DidYouFinish())
                    report += "Robotnica numer " + (i + 1) + " zakończyła swoje zadanie \r\n";
                if (string.IsNullOrEmpty(robotnice[i].CurrentJob))
                    report += "Robotnica numer " + (i + 1) + " nie pracuje \r\n";
                else
                    if (robotnice[i].ShiftsLeft > 0)
                    report += "Robotnica numer " + (i + 1) + " robi " + robotnice[i].CurrentJob + " jeszcze przez " + robotnice[i].ShiftsLeft + " zmiany \r\n";
                else
                    report += "Robotnica numer " + (i + 1) + " zakończy " + robotnice[i].CurrentJob + " po tej zmianie\r\n";

                
            }



             report+="Całkowite spożycie miodu "+honeyConsumed+" jednostek \r\n";
            return report;
        }
    }
}
