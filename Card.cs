using System;
using System.Collections.Generic;

namespace Deck_Of_Cards
{
    class Card
    {
            //Fields
            public string stringVal;//stringVal holds the value, Ace through King
            public string suit;//suit holds the suit
            public int val;//val holds the int value 1-13


            //Constructor
            public Card(string sV, string s, int v)
            {
                stringVal = sV;
                suit = s;
                val = v;
            }
    }
}