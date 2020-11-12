using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;

namespace Talia_Kart
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

        public string Name { get { return Value.ToString() + " of " + Suit.ToString(); } }

        public override string ToString()
        {
            return Name;
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
}
