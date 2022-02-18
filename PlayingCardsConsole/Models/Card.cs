using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayingCards.Interfaces;

namespace PlayingCards.Models
{
    public class Card:ICard
    {
        public Suit Suit { get; set; }
        public CardNumber CardNumber { get; set; }
    }
}
