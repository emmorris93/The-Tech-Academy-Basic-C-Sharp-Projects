using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
 
    public class Card
    {
        public string Suit { get; set; }
        public string Face { get; set; }

        public Card() 
        {
            Suit = "Spades";
            Face = "Two";
        }

        public Card(string Suit, string Face)
        {
            this.Suit = Suit;
            this.Face = Face;
        }
    }
}
