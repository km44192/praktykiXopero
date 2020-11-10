using System;

namespace Cyrk_Interfacy
{
    partial class Program
    {
        static void Main(string[] args)
        {
            ScaryScary fingersTheClown = new ScaryScary("duże buty",20);
            FunnyFunny jakisklaun = fingersTheClown;
            IScaryClown innyKlaun = jakisklaun as ScaryScary;
            innyKlaun.Honk();
            innyKlaun.ScareLittleChildren();
            Console.WriteLine(innyKlaun.ScaryThingIHave);


            Console.Read();
        }
    }
}
