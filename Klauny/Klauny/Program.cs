using System;
using System.Net.WebSockets;

namespace Klauny
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            clown klaun1 = new clown();
            klaun1.imie = "Michał";
            klaun1.height = 170;
            clown klaun2 = new clown();
            klaun2.imie = "Szymon";
            klaun2.height = 190;
            clown klon = new clown();
            klon.imie = klaun2.imie;
            klon.height = klaun1.height*2;


            klaun1.TalkAboutYourself();
            klaun2.TalkAboutYourself();
            klon.TalkAboutYourself();
        }
    }
}
