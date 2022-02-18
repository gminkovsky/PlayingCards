using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlayingCards.Interfaces;
using System.Threading.Tasks;

namespace PlayingCards.Models
{
    public class Deck: IDeck
    {
        public Deck()
        {
            Reset();
        }
        public List<Card> Cards { get; set; }
        /// <summary>
        ///   LINQ way
        /// </summary>
        public void Shuffle()
        {
            Cards = Cards.OrderBy(c => Guid.NewGuid()).ToList();
        }
        
        public void PrintCards()
        {
            
            Cards.ForEach(x => Console.WriteLine(Cards.IndexOf(x)+1 + ". " +  x.Suit  + " " + x.CardNumber));
                       
        }
        /// <summary>
        /// reset out 40 
        /// </summary> 
        public void Reset()
        {
            Cards = Enumerable.Range(1, 4).SelectMany(s => Enumerable.Range(1, 10).Select(c => new Card()//13 for 52
            {
                Suit = (Suit)s,
                CardNumber = (CardNumber)c

            })).ToList();
        }
       
    }
}
