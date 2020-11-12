using System;
using System.Collections.Generic;

namespace Lista_butów
{
    public class Shoe
    {
        public Style Style;
        public string Color;

    } 
    public enum Style {
    Sneakers,
    Loafers,
    Sandals,
    FlipFlops,
    Wingtips,
    Clogs,
    
    }


    class Program
    {
        public static void PrintDucks(List<Duck> x)
        {
            foreach (Duck kaczka in x)
                Console.WriteLine(kaczka.ToString());
            Console.WriteLine("Koniec Kaczek!");
        }
        static void Main()
        {
            
            List<Shoe> buty= new List<Shoe>();

            buty.Add(new Shoe()
            { Style = Style.Sneakers, Color = "Czarny" });

            buty.Add(new Shoe()
            { Style = Style.Clogs, Color = "Brązowy" });
            buty.Add(new Shoe()
            { Style = Style.Wingtips, Color ="Czarny" });
            buty.Add(new Shoe()
            { Style = Style.Loafers, Color = "Biały" });
            buty.Add(new Shoe()
            { Style = Style.Loafers, Color = "Czerwony" });
            buty.Add(new Shoe()
            { Style = Style.Sneakers, Color = "Zielony" });



            int numOfShoes = buty.Count;
            foreach(Shoe but in buty)
            {
                but.Style = Style.FlipFlops;
                but.Color = "Pomarańczowy";

            }


            buty.RemoveAt(4);

            Shoe thirdshoe = buty[2];
            Shoe secondshoe = buty[1];
            buty.Clear();


            buty.Add(thirdshoe);
            if (buty.Contains(secondshoe))
                Console.WriteLine("A to Ci niespodzianka ");


            ///zadanie z kaczkami

            List<Duck> kaczki = new List<Duck>
            {
                new Duck() {Kind=KindOfDuck.Decoy,size=17 },
                new Duck(){Kind=KindOfDuck.Mallord,size=10},
                 new Duck(){Kind=KindOfDuck.Muscovy,size=11},
                  new Duck(){Kind=KindOfDuck.Decoy,size=19},
                   new Duck(){Kind=KindOfDuck.Mallord,size=16},
                    new Duck(){Kind=KindOfDuck.Muscovy,size=20},


            };

            
            DuckComparer comparer = new DuckComparer();
            comparer.SortBy = SortCriteria.KindThenSize;
            kaczki.Sort(comparer);
            
            PrintDucks(kaczki);
            comparer.SortBy = SortCriteria.SizeThenKind;
            kaczki.Sort(comparer);
            PrintDucks(kaczki);
            Console.ReadKey();
        }
    }
}
