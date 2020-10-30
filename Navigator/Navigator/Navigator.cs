using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Navigator
{
     class Navigator
    {
        public string destination;
        public int Xloc, Yloc;
        public double route;

       public void SetCurrentLocation() { MessageBox.Show("Twoje położenie to: "+Xloc.ToString()+" "+Yloc.ToString()); }
       public string SetDestination(string dst) { destination = dst; return string.Format("Cel Podróży to:"+ destination); }

        public void ModifyRouteToAvoid(string avoid)
        {
            route = route * 1.25;
            string.Format("Znaleziono szybszą trasę");
        }
        public void ModifyRouteToInclude() { }
        public double TotalDistance() { Random x = new Random(); route = x.Next(0, 100); return route; }
        public void GetTImeToDestination() { }
        public string GetRoute() { return "obliczanie trasy"; }


        public Navigator() { Xloc = 65; Yloc = 45; }
       
    }
}