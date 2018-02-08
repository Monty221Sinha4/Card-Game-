using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckofCards
{
    public class Cards
    {
        private string face;
        private string suit;
        public Cards (string cardFace,string cardSuit)
        {
            face = cardFace;
            suit = cardSuit;
        }
        public override string ToString()
        {
            return face+ "of"+ suit;
        }

    }
}
