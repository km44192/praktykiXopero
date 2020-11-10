using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetMission
{
    abstract class PlanetMission
    {
        public long RocketFuelPerMile;
        public long RocketSpeedMPH;
        public int MilesToPlanet;


        public long UnitsOfFuelNeeded()
        {
            return MilesToPlanet * RocketFuelPerMile;

        }
        public int TimeNeeded() { return MilesToPlanet / (int)RocketSpeedMPH; }
        public string FuelNeeded()
        {

            return "Będe potrzebował" + UnitsOfFuelNeeded() + "jednostek paliwa, aby tam się dostać. Zajmie Ci to: " + TimeNeeded() + " godzin\n";
        }
        public abstract void SetMissionInfo(int MilesToPlanet, int RocketFuelPerMile, long RocketSpeedMPH);
    }
}
