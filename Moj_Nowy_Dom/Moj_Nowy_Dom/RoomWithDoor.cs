using System;
using System.Collections.Generic;
using System.Text;

namespace Moj_Nowy_Dom
{
    class RoomWithDoor:RoomWithHidingPlace,IHasExteriorDoor
    {
        public string doorDescription { get; private set; }
        public Location DoorLocation { get; set; }

        public RoomWithDoor(string pokoj,string decoration,string hidingPlaceName,string doordescritino) : base(pokoj,decoration,hidingPlaceName) { doorDescription = doordescritino; }
    }
}
