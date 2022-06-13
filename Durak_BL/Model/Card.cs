using System;
using System.Collections.Generic;
using Durak_BL.Enums;


namespace Durak_BL.Model
{
    public class Card
    {
        //Pack - колода
        // Beat - бита (бить карту)
        public int Suit { get; }
        public int Rank { get; }
        public bool IsTrump { get; private set; }

        public Card(int suit, int rank, bool isTrump)
        {
            if (suit < 0 || suit > 3)
            {
                throw new ArgumentException("Недопустимое значение", nameof(suit));
            }
            if (rank < 6 || rank > 14)
            {
                throw new ArgumentException("Недопустимое значение", nameof(rank));
            }
            Suit = suit;
            Rank = rank;
            IsTrump = isTrump;
        } 

        public bool CardIsCovered(ref Card CoveredCard, ref Card CoveringCard)
        {
            var result = false;
            if(!CoveringCard.IsTrump)
            {
                    result = true ? (CoveredCard.Suit == CoveringCard.Suit &&
                    CoveredCard.Rank < CoveringCard.Rank) : false;
            }
            else
            {
                if(CoveredCard.IsTrump)
                {
                    result = true ? (CoveredCard.Rank < CoveringCard.Rank) : false;
                }
                else
                {
                    result = true;
                }
            }
            return result;
        }

        public static void SpecifyTrump(List<Card> cards, int trumpSuit)
        {
            foreach(var card in cards)
            {
                card.IsTrump = true ? (card.Suit == trumpSuit) : false;
            }
        }
    }
}
