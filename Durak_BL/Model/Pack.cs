using System;
using System.Collections.Generic;
using Durak_BL.Enums;

namespace Durak_BL.Model
{
    public class Pack
    {
        private Random rnd = new Random();
        public List<Card> Cards { get; }
        public int TrumpSuit { get; }

        public Pack(List<Card> cards)
        {
            if(cards.Count != 36 || cards == null)
            {
                throw new ArgumentException("", nameof(cards));
            }
            Cards = cards;
            TrumpSuit = rnd.Next((int)CardSuit.Diamonds, (int)CardSuit.Spades + 1);
            Card.SpecifyTrump(Cards, TrumpSuit);
        }
    }
}
