using System;
using System.Collections.Generic;
using System.Text;

namespace Moj_Nowy_Dom
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        public RoomWithHidingPlace(string name,string decoration,string HidingPlaceName) : base(name, decoration) { this.HidingPlaceName = HidingPlaceName; }

 public string HidingPlaceName { get;set; }
        public override string Description { get { return base.Description + "Ktoś może ukrywać się: " + HidingPlaceName + ".\n"; } }

    }
}
