using System;
using System.Collections.Generic;
using System.Text;

namespace Moj_Nowy_Dom
{
    interface IHasExteriorDoor
    {
        string doorDescription { get;  }
     Location DoorLocation { get; set; }


    }
}
