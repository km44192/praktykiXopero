using System;
using System.Collections.Generic;

namespace Talia_Kart
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Card> talia1 = new List<Card>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                talia1.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
            }
           foreach(Card karta in talia1)
            {
                Console.WriteLine(karta.Name);
            }
            CardComparer_byValue comparer = new CardComparer_byValue();
            Console.WriteLine("\n\n");
            talia1.Sort(comparer);
            foreach (Card karta in talia1)
            {
                Console.WriteLine(karta.ToString()); ;
            }


            Console.ReadKey();
        }
    }
}
