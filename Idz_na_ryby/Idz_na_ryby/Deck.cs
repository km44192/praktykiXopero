using System;
using System.Collections.Generic;
using System.Text;

namespace Idz_na_ryby
{
    public class Deck
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
        public Deck(IEnumerable<Card> initialCards)
        {
            talia = new List<Card>(initialCards);
        }
        public int Count { get { return talia.Count; } }
        public void Add(Card cardToAdd)
        {
            talia.Add(cardToAdd);
        }
        public Card Deal()
        { return Deal(0); }
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

        public Card Peek(int cardNimber)
        {
            return talia[cardNimber];
        }
        public void SortByValue() { talia.Sort(new CardComparer_byValue()); }


        public bool ContainsValue(Values value)
        {
            foreach (Card card in talia)
                if( card.Value == value)
            return true;
          return false;
        }

        public Deck PullOutValues(Values value)
        {
            Deck deckToReturn = new Deck(new Card[] { });
            for (int i = talia.Count - 1; i >= 0; i--)
                if (talia[i].Value == value)
                    deckToReturn.Add(Deal(i));
            return deckToReturn;
        }
        public bool HasBook(Values value)
        {
            int NumberOfCards = 0;
            foreach (Card card in talia)
                if (card.Value == value)
                    NumberOfCards++;
            if (NumberOfCards == 4)
                return true;
            else
                return false;

        }
      

    }
}
