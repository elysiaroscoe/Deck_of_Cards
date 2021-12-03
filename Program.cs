using System;
using System.Collections.Generic;

namespace Deck_Of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player("Roscoe");
            Deck myDeck = new Deck();
            newPlayer.draw(myDeck);
            newPlayer.draw(myDeck);
            System.Console.WriteLine($"{newPlayer.Name}'s hand contains as follows:");
            foreach (Card cardInHand in newPlayer.hand)
            {
                System.Console.WriteLine(cardInHand.stringVal + cardInHand.suit);
            }
            newPlayer.discard(0);
        }

    }
}
