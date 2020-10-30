using System;

namespace Fabryka_batonow
{
    class Program
    {
        static void Main(string[] args)
        {
            Maszyna_Bat w = new Maszyna_Bat();
            while (true)
            {
               
               
                w.DoMaintanceTests();
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
            }
          //  Console.Read();
            
        }
    }
}
