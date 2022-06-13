using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak_BL.Model
{
    public class Player
    {
        public string Name { get; }
        public List<Card> Cards { get; }
        public bool IsPlaying { get; set; }

        public Player(string name, ref Card[] cards, bool isPlaying )
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Недопустимое имя.", nameof(name));
            }

            if(cards.Length != 6)
            {
                throw new ArgumentException("Некорректный набор карт.", nameof(cards));
            }

            Name = name;
            Cards = Cards.ToList();
            IsPlaying = isPlaying;
        }
    }
}
