using Durak_BL.Model;
using Durak_BL.Enums;
using System;
using System.Collections.Generic;

namespace Durak_BL.Controller
{
    public class PackController
    {
        private List<Card> CardsForDeal;
        private List<Card>[] DealedCards;
        public Pack Pack { get; }

        public PackController(int PlayerCount)
        {
            if(PlayerCount <= 1 || PlayerCount > 6)
            {
                throw new ArgumentException("Недопустимое количество игроков.", nameof(PlayerCount));
            }
            DealedCards = new List<Card>[PlayerCount];
            GenerateCards();
            Card.SpecifyTrump(ref CardsForDeal);
            Pack = new Pack(ref CardsForDeal);
        }

        private void GenerateCards()
        {
            CardsForDeal = new List<Card>();
            for (int suit = (int)CardSuit.Diamonds; suit < (int)CardSuit.Spades; suit++)
            {
                for (int rank = (int)CardRank.Six; rank < (int)CardRank.Ace; rank++)
                {
                    CardsForDeal.Add(new Card(suit, rank, false));
                }
            }
        }
    }
}
