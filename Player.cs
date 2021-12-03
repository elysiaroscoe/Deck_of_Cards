using System;
using System.Collections.Generic;

namespace Deck_Of_Cards
{
    class Player
    {
        public string Name;
        public List<Card> hand = new List<Card>();


        public Player(string n)
        {
            Name = n;
            hand = new List<Card>();
        }




        public void draw(Deck myDeck)
        {
            Random rand = new Random();
            int randomNum = rand.Next(52);
            Card drawCard = myDeck.cards[randomNum];
            hand.Add(new Card(drawCard.stringVal, drawCard.suit, drawCard.val));
        }


        public Card discard(int position)
        {
            Card discardedCard = hand[position];
            hand.RemoveAt(position);
            System.Console.WriteLine($"You have discarded {discardedCard.stringVal} of {discardedCard.suit}. The deck is now as follows:");
            foreach (Card cardInHand in hand)
            {
                if(hand!=null)
                {
                    Console.WriteLine($"{hand[0].stringVal} of {hand[0].suit}");
                }
                else
                {
                    System.Console.WriteLine("Your hand is now empty!");
                }
            
            }
            return discardedCard;

        }
    }
}