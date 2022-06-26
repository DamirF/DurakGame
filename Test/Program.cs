using Durak_BL.Enums;
using Durak_BL.Model;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card firstCard = new Card((int)CardSuit.Hearts, (int)CardRank.Six, true);
            Card secondCard = new Card((int)CardSuit.Diamonds, (int)CardRank.Nine, true);

            Console.WriteLine(firstCard > secondCard);
        }
    }
}