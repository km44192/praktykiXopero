using System;
using System.Collections.Generic;
using System.Text;

namespace Moj_Nowy_Dom
{
    class Room:Location
    {

    
        private string decoration;


        

        public Room(string name,string deco):base(name) { decoration = deco; }
        public override string Description { get { return base.Description + "\n Widzisz tutaj " + decoration + "."; } }
    }
}
