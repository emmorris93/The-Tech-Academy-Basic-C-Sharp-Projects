using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Deck deck = new Deck();




            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }       
    }
}

//int count = deck.Cards.Count(x => x.Face == Face.Ace);

//List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

//List<int> numberList = new List<int> { 1, 2, 3, 5, 7, 18, 29 };
//int sum = numberList.Sum();
//Console.WriteLine(sum);