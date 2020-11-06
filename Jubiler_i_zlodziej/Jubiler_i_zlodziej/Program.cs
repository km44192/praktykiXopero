using System;

namespace Jubiler_i_zlodziej
{
    class Program
    {
        static void Main(string[] args)
        {
            Jubiler content = new Jubiler();
            Wlasciciel wlasciciel = new Wlasciciel();
            Sejf sejf = new Sejf();
            Zlodziej zlodziej = new Zlodziej();
            Ślusarz ślusarz = new Ślusarz();
            zlodziej.OpenSafe(sejf, wlasciciel);
            ślusarz.zwrocZawartosc(content,wlasciciel);
            Console.ReadLine();
        }
    }
}
