﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Idz_na_ryby
{
        public class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;




        public Player(string name,Random random,TextBox textBox)
        {
            this.name = name;
            this.random = random;
           textBoxOnForm = textBox;
            this.cards = new Deck(new Card[] { });
            textBoxOnForm.Text = this.name + " dołączył do gry "+Environment.NewLine;
        }
      
        public Values GetRanodmValue() { Values wartosc =(Values)random.Next(1, 14); return wartosc; }
        public Deck DoYouHaveAny(Values value)
        {
            Deck cardsIHave = cards.PullOutValues(value);
            textBoxOnForm.Text = Name + " ma  " + cardsIHave.Count + " " + Card.Plural(value, cardsIHave.Count) + Environment.NewLine;
            return cardsIHave;



        }
        public void AskForACard(List<Player> players,int myIndex,Deck stock) {
            if (stock.Count > 0) {
                if (cards.Count == 0)
                    cards.Add(stock.Deal());
                Values randomValue = GetRanodmValue();
                AskForACard(players, myIndex, stock, randomValue);
            }
            
        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock,Values value) {

            textBoxOnForm.Text += Name + "pyta, czy ktoś ma " + Card.Plural(value, 1) + Environment.NewLine;
            int totalCardsGiven = 0;
            for(int i = 0; i < players.Count; i++)
            {
                if (i != myIndex)
                {
                    Player player = players[i];
                    Deck CardsGiven = player.DoYouHaveAny(value);
                    totalCardsGiven += CardsGiven.Count;
                    while (CardsGiven.Count > 0)
                        cards.Add(CardsGiven.Deal());
                }
            }
            if (totalCardsGiven == 0)
            {
                textBoxOnForm.Text += Name + " pobrał kartę z kupki. " + Environment.NewLine;
                cards.Add(stock.Deal());
            }

        }
     
        public Card Peek(int cardNumber)
        {
            return cards.Peek(cardNumber);
        }



        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.Add(card); }
        public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }
       
        public void SortHand() { cards.SortByValue(); }
      




        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> book = new List<Values>();
            for (int i = 0; i <= 13; i++)
            {
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)

                    if (cards.Peek(card).Value == value)
                        howMany++;
                if (howMany == 4)
                {
                    book.Add(value);
                    for (int card = cards.Count - 1; card >= 0; card--)
                        cards.Deal(card);
                }
              
            }
            return book;
        }

       

     

    }
}
