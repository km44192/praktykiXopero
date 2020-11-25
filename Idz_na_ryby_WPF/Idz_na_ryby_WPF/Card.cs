using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Idz_na_ryby_WPF
{
    public enum Suits
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts,

    }
    public  enum Values
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }
    //enum Name
    //{
    //    Ace_of_Spades,
    //    Five_of_Diamonds,

    //}
    public class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public Card(Suits suit, Values value) { Suit = suit; Value = value; }

        public string Name { get { return names[(int)Value] + " of " + suit[(int)Suit]; } }

        public override string ToString()
        {
            return Name;
        }
        private static string[] suit = new string[] { "pik", "trefl", "karo", "kier" };
        private static string[] names = new string[] { "", "As", "Dwójka", "Trójka", "Czwórka", "Piątka", "Szóstka", "Siódemka", "Ósemka", "Dziewiątka",
        "Dziesiątka","Jopek","Dama"};

        private static string[] names0 = new string[]
            {"","asów","dwójek","trójek","czwórek","piątek","szóstek","siódemek","ósemek","dziewiątek","dziesiątek","jopków","dam","królów"};
        private static string[] names1 = new string[]
        {
            "","asa","dwójkę","trójkę","czwórkę","piątkę","szóstkę","siódemkę","ósemkę","dziewiątkę","dziesiątkę","jopka","damę","króla"
        };
        private static string[] names2AndMore = new string[]
        {
            "","asy","dwójki","trójki","czwórki","piątki","szóstki","siódemki","ósemki","dziewiątki","dziesiątki","jopki","damy","króle"

        };

        public static string Plural(Values value,int count)
        {
            if (count == 0)
            { return names0[(int)value]; }
            if (count == 1)
                return names1[(int)value];
                return names2AndMore[(int)value];
        }
 

    }

    public class CardComparer_byValue:IComparer<Card>
    {
        public int Compare(Card x,Card y)
        {
            if (x.Value > y.Value)
                return 1;
            else if (x.Value < y.Value)
                return -1;
            else
                return 0;
        }
        
    }   
    public class CardComparer_bySuit:IComparer<Card>
    {
        public int Compare(Card x,Card y)
        {
            if (x.Suit > y.Suit)
                return 1;
            if (x.Suit < y.Suit)
                return -1;
            if (x.Value > y.Value)
                return 1;
            if (x.Value < y.Value)
                return -1;
            return 0;


        }
    }
}
