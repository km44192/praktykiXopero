using System;
using System.Collections.Generic;
using System.Text;

namespace Moj_Nowy_Dom
{
    class RoomWithDoor:Room,IHasExteriorDoor
    {
        public string doorDescription { get; private set; }
        public Location DoorLocation { get; set; }

        public RoomWithDoor(string pokoj,string decoration,string doordescritino) : base(decoration,pokoj) { doorDescription = doordescritino; }
    }
}
