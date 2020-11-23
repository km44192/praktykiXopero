using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Talia_Kart
{
    class Deck
    {
       private List<Card> talia;
        private Random random = new Random();

        public Deck()
        {
            talia = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
                for (int value = 1; value <= 13; value++)
                    talia.Add(new Card((Suits)suit, (Values)value));
        }
        public Deck(string FileName)
        {
            talia = new List<Card>();
            StreamReader reader = new StreamReader(FileName);
            while (!reader.EndOfStream)
            {
                bool invalidCard = false;
                string nextCard = reader.ReadLine();
                string[] cardParts = nextCard.Split(new char[] { ' ' });
                Values value;
                if (Enum.TryParse(cardParts[0], out value))
                { }

                else
                {
                    invalidCard = true;
                    break;
                }
                Suits suit;

                if (Enum.TryParse(cardParts[1], out suit))
                { }
                else
                {
                    invalidCard = true; break;
                }
                    
                    if (!invalidCard)
                    {
                        talia.Add(new Card(suit, value));
                    }
                
            }

        }
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
