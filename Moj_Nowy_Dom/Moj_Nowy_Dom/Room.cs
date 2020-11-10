using System;
using System.Collections.Generic;
using System.Text;

namespace Moj_Nowy_Dom
{
    class Room:Location
    {

    
        private string decoration;


        

        public Room(string deco,string name):base(name) { decoration = deco; }
        public override string Description { get { return base.Description+"Widzisz tutaj "+decoration+"."} }
    }
}
