using System;
using System.Collections.Generic;
using System.Text;

namespace Cyrk_Interfacy
{
    public interface IScaryClown:IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChildren() { }

    }
}
