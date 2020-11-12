using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;

namespace Pola_Wyliczeniowe
{
    enum Suits
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts,

    }
    enum Values
    {
        Ace=1,
        Two=2,
        Three=3,
        Four=4,
        Five=5,
        Six=6,
        Seven=7,
        Eight=8,
        Nine=9,
        Ten=10,
        Jack=11,
        Queen=12,
        King=13,
    }
    //enum Name
    //{
    //    Ace_of_Spades,
    //    Five_of_Diamonds,

    //}
    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }
      
      public Card(Suits suit,Values value) { Suit = suit;Value = value; }
       
        public string Name { get { return Value.ToString() + " of " + Suit.ToString(); } }

     
        
    }
}
