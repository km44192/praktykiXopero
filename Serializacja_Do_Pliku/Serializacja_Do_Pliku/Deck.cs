using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Serializacja_Do_Pliku
{[Serializable]
    class Deck
    {
       private List<Card> talia;
        public Random random = new Random();

        public Deck()
        {
            talia = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
                for (int value = 1; value <= 13; value++)
                    talia.Add(new Card((Suits)suit, (Values)value));
        }
        /*public Deck(string FileName)
        {
            talia = new List<Card>();
            StreamReader reader = new StreamReader(FileName);
            while (!reader.EndOfStream)
            {
                bool invalidCard = false;
                string nextCard = reader.ReadLine();
                string[] cardParts = nextCard.Split(new char[] { ' ' });
                Values value = Values.Ace;
                switch (cardParts[0])
                {
                    case "Ace": value = Values.Ace; break;
                    case "Two": value = Values.Two; break;
                    case "Three": value = Values.Three; break;
                    case "Four": value = Values.Four; break;
                    case "Five": value = Values.Five; break;
                    case "Six": value = Values.Six; break;
                    case "Seven": value = Values.Seven; break;
                    case "Nine": value = Values.Nine; break;
                    case "Ten": value = Values.Ten; break;
                    case "Jack": value = Values.Jack; break;
                    case "Queen": value = Values.Queen; break;
                    case "King": value = Values.King; break;
                    default: invalidCard = true; break;
                }
                Suits suit = Suits.Clubs;
                switch (cardParts[1])
                {
                    case "Spades": suit = Suits.Spades; break;
                    case "Clubs": suit = Suits.Clubs; break;
                    case "Hearts": suit = Suits.Hearts; break;
                    case "Diamonds": suit = Suits.Diamonds; break;
                    default: invalidCard = true; break;
    
                }
                if(!invalidCard)
                {
                    talia.Add(new Card(suit, value));
                }
            }

        }*/
        public Deck(IEnumerable<Card> initialCards)
        {
            talia = new List<Card>(initialCards);
        }
        public int Count { get { return talia.Count; } }
        public void Add(Card cardToAdd)
        {
            talia.Add(cardToAdd);
        }
        public Card Deal(int Index)
        {
            Card CardToDeal = talia[Index];
            talia.RemoveAt(Index);
            return CardToDeal;
        }
        public void Shuffle() {
            List<Card> nowaTalia = new List<Card>();
            while (talia.Count > 0)
            {
                int CardToMove = random.Next(talia.Count);
                nowaTalia.Add(talia[CardToMove]);
                talia.RemoveAt(CardToMove);
            }
            talia = nowaTalia;
        }

        public IEnumerable<string> GetCardNames()
        {
            string[] CardName = new string[talia.Count];
            for(int i = 0; i < talia.Count; i++)
            {
                CardName[i] = talia[i].Name;
            }
            return CardName;
        }
        public void Sort() { talia.Sort(new CardComparer_byValue()); }

    }
}
