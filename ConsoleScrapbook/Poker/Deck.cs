using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.Poker
{
    class Deck
    {
        static Random rand = new Random();
        public Card[] card = new Card[52];

        public Deck()
        {
            int n = 0;
            for (int i = 1; i < 14; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i < 11)
                    {
                        card[n] = new Card(j, i, false);
                    }
                    else
                    {
                        card[n] = new Card(j, i, true);
                    }
                    n++;

                }
            }
        }
        public int shuffle()
        {
            for (int i = 0; i < card.Length; i++)
            {
                int r = i + (int)(rand.NextDouble() * (card.Length - i));
                Card t = card[r];
                card[r] = card[i];
                card[i] = t;
                card[i].Burnt = false;
            }
            //for (int i = 0; i < card.Length;i++)
            //{
            //    card[i].Burnt = false;       all unnecessary
            //}
            return 0;
        }
        void order()
        {
            //for (int i = 0; i < deck.Length; i++)
            //{

            //}
        }

        public void burn(int n)
        {
            card[n].Burnt = true;
        }

    }

    class Card
    {
        public Card(int suit, int value, bool face)
        {
            this.suit = suit;
            this.value = value;
            this.face = face;
            Burnt = false;

        }
        private int suit;
        public int Suit
        {
            get { return suit; }
        }
        private int value;
        public int Value
        {
            get { return value; }
        }
        private bool face;
        public bool Face
        {
            get { return face; }
        }
        public bool Burnt;
      

     }   
}
