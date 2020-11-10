using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetMission
{
    class Mars:PlanetMission
    {
        public Mars() {
            SetMissionInfo(75000000, 100000, 25000);
        }
        public override void SetMissionInfo(int MilesToPlanet, int RocketFuelPerMile, long RocketSpeedMPH)
        {
            this.MilesToPlanet = MilesToPlanet;
            this.RocketFuelPerMile = RocketFuelPerMile;
            this.RocketSpeedMPH = RocketSpeedMPH;
        }
    }
}
