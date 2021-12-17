using System;
using System.Collections.Generic;

namespace deckOfCards
{
    class Deck
    {
        private List<Card> cards = new List<Card>();
        public Deck()
        {
            Reset();
        }

        public List<Card> Reset()
        {
            cards.Clear();
            for(int i = 0; i < 4; i++)
            {
                int j = 1;
                while(j < 14)
                {
                    cards.Add(new Card(Card.Suits[i], j));
                    j++;
                }
            }
            return cards;
        }

        public List<Card> Cards
        {
            get { return this.cards; }
        }

        public void ShowDeck()
        {
            foreach (Card c in cards)
            {
                c.SayCard();
            }
        }

        public Card Deal()
        {
            Card theCard = cards[0];
            cards.RemoveAt(0);
            return theCard;
        }

        public void Shuffle()
        {
            List<Card> cardsShuffle = this.cards;
            List<Card> shuffled = new List<Card>();
            Random randy = new Random();
            while(cardsShuffle.Count > 0)
            {
                int idx = randy.Next(0, cardsShuffle.Count);
                shuffled.Add(cardsShuffle[idx]);
                cardsShuffle.RemoveAt(idx);
            }
            this.cards = shuffled;
        }
    }

}
