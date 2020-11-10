using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace Moj_Nowy_Dom
{
    class OutsideWithDoor:OutSide,IHasExteriorDoor
    {
        public string doorDescription { get; private set; }
        public Location DoorLocation { get; set; }
        

        public OutsideWithDoor(string Nazwa,bool hot,string doordescription) : base(hot,Nazwa) { doorDescription = doordescription; }
    }
}
