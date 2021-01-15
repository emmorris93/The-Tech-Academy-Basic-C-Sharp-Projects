using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    /// <summary>
    /// 
    /// </summary>
    public class Card
    {
        public string Suit { get; set; }
        public string Face { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Card() 
        {
            Suit = "Spades";
            Face = "Two";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Suit"></param>
        /// <param name="Face"></param>
        public Card(string Suit, string Face)
        {
            this.Suit = Suit;
            this.Face = Face;
        }
    }
}
