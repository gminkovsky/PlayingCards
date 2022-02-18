using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards.Interfaces
{
    public interface IDeck
    {
        void Shuffle();
        void PrintCards();
        void Reset();

    }
}
