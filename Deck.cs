using System;
using System.Collections.Generic;

namespace Deck_Of_Cards
{
    class Deck
    {
        //cards is a list of Card objects
        public List<Card> cards;
        public List<string> stringValues = new List<string>{"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
        public List<string> suits = new List<string>{"Hearts", "Aces", "Clubs", "Diamonds"};
        public List<int> intValues = new List<int>{1,2,3,4,5,6,7,8,9,10,11,12,13};

        public Deck()
        {
            cards = new List<Card>();
                foreach(string suit in suits){
                    string Suit = suit;
                    for (int i = 0; i<=12; i++)
                    {
                        string sValue = stringValues[i];
                        int iValue = intValues[i];
                        cards.Add(new Card(sValue, Suit, iValue));
                    }
                }
                return;
        }
        
    }
}