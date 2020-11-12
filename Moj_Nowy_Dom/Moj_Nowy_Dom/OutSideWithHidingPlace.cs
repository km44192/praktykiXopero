using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Moj_Nowy_Dom
{
    class OutSideWithHidingPlace:OutSide,IHidingPlace
    {
        public OutSideWithHidingPlace(string name, bool hot, string hidingPlaceName) : base(hot, name) { HidingPlaceName = hidingPlaceName; }

        public string HidingPlaceName { get; set; }

        public override string Description { get { return base.Description + "Ktoś może ukrywać się " + HidingPlaceName + ".\n"; } }
    }
}
