using System;

using System.Collections.Generic;

namespace Kolekcje
{
    class Program
    {
        static void Main(string[] args)
        {
            Slownik slownik = new Slownik();
            Kolejka kolejka = new Kolejka();
            Stack<string> stos = new Stack<string>();
            if (slownik.słownik.ContainsKey("Klucz"))
                Console.WriteLine("\nklucz\n"+slownik.słownik["Klucz"]);
    


           stos.Push("pierwszy w stosie");
            stos.Push("drugi w stosie");
            stos.Push("trzeci w stosie");
            stos.Push("ostatni w stosie");
            string takeAloog = stos.Peek();
            string getFirst = stos.Pop();
            string getNext = stos.Pop();
            int howMany = stos.Count;
            stos.Clear();
            Console.Write("Peak() zwróciło " + takeAloog + "\n" + "Pierwsze Dequeue() zwróciło: " + getFirst + "\n" + "Drugie Dequeue() zwróciło: " + getNext + "\n" + "Count przed clear zwróciło " + howMany + "\n" + "count po clear zwróciło: " + stos.Count + "\n");
            Console.ReadLine();
        }
    }
}
