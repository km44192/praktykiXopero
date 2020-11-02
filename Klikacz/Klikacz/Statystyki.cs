using System;
using System.Collections.Generic;
using System.Text;

namespace Klikacz
{
    class Statystyki
    {
        public int Total=0;
        public int Missed=0;
        public int correct=0;
        public int accuracy = 0;



        public void Update(bool iscorrect) {
            Total++;

            if (!iscorrect) { Missed++; }
            else { correct++; }

            accuracy = 100 * correct / Total;
        }
    }
}
