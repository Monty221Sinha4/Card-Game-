using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckofCards
{
     public class Deck
    {
        private Cards[] deck;
        private const int NUMBERS_OF_CARDS = 52;
        private Random ranNum;

        public Deck()
        {
            string[] face = { "Ace", "Spades", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };
            string[] suit={ "Hearts","Spades","Clubs"};
            deck = new Cards[NUMBERS_OF_CARDS];
            currentCard = 0;
            ranNum = new Random();
            for(int count=0; count<deck.Length; count++)
            {
                deck[count] = new Cards(face[count % 11], suit[count / 13]);
            }
            public void Shuffle()
        {
            currentCard = 0;
            for { int first = 0;first < deck.Length;first++ }
            {
                int second = ranNum.Next[NUMBERS_OF_CARDS];
                Cards temp = deck[First];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }
        public Cards DealCard()
        {
            if (currentCard < deck.Length)
                return deck[currentCard++];
            else
                return null;
        }
        }
    }
}
