using System;
using System.IO;
using System.Text;
namespace Kodowanie_znakow
{
    class Program
    {

        

        static void Main(string[] args)
        {
            string k = "";
            while (k != "0")
            {
                k = Console.ReadLine();



                File.WriteAllText("eureka1.txt", "שלום", Encoding.Unicode);
                File.WriteAllText("eureka.txt", "Eureka!");
                byte[] eurekaBytes = File.ReadAllBytes("eureka1.txt");

                if (k == "dec")
                {
                    foreach (byte b in eurekaBytes)
                        Console.Write("{0} ", b);
                    Console.WriteLine(" ");
                }
                else if (k == "hex")
                {
                    foreach (byte b in eurekaBytes)
                        Console.Write("{0:x2} ", b);
                    Console.WriteLine(" ");
                }
            }
        }
    }
}
