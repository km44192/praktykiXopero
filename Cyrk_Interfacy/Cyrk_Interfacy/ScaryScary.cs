using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Cyrk_Interfacy
{
    class ScaryScary:FunnyFunny,IScaryClown
    {
        public string ScaryThingIHave { get { return "Mam " + numOfScaryThings + " Pająków"; } }
        private int numOfScaryThings;
        public void ScareLittleChildren() { Console.WriteLine("Buu! Mam Cię!"); }

        public ScaryScary(string x,int height):base(x) { numOfScaryThings = height; }

    }
}
