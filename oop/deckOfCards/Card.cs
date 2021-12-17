using System;
using System.Collections.Generic;

namespace deckOfCards
{
    class Card
    {
        private string suitVal;
        private int value;

        private string suit;

        public static string[] Suits = new string[4] {"Spades", "Hearts", "Diamonds", "Clubs"};
        public Card(string s, int val)
        {
            switch(val)
            {
                case 11:
                    suitVal = "Jack";
                    break;
                case 12:
                    suitVal = "Queen";
                    break;
                case 13:
                    suitVal = "King";
                    break;
                case 1:
                    suitVal = "Ace";
                    break;
                default:
                    suitVal = val.ToString();
                    break;
            }
            suit = s;
            value = val;
        }

        public void SayCard()
        {
            System.Console.WriteLine("The {0} of {1}", suitVal, suit);
        }

    }
}
