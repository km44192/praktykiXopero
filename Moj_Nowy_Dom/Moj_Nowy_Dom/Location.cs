using System;
using System.Collections.Generic;
using System.Text;

namespace Moj_Nowy_Dom
{
abstract class Location
    { public Location(string name)
        {
            this.Name = name;
        }

        public Location[] Exits;
        public string Name { get; set; }
      

        public virtual string Description
        {

            get
            { 
                string description = " Stoisz w " + Name + ".\n Widzisz wyjście na następujące lokacje: \n";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += " " + Exits[i].Name;
                    if (i != Exits.Length - 1)
                    {
                        description += " , ";
                    }
                }
                description += ".";
                return description;

            }
        }

    }
}
