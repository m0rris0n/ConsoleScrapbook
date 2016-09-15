using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.Poker
{
    class Poker
    {
        static Random rand = new Random();
        Deck deck = new Deck();

        public Poker()
        {

            //initialise players*

            //assign blind location
            //pay blinds
            //deal cards
            //display cards to each player
            //place bets {in a round}
            //IF (!TOTALFOLD) {display river 3}
            //place bets {in a round}
            //IF (!TOTALFOLD) {display river 4th}
            //place bets {in a round}
            //IF (!TOTALFOLD) {display river 5th}
            //place bets {in a round}
            //else skip to end ->
            //IF (!TOTALFOLD) Display all remaining hands
            //calculate winning hands + determine winner
            //assign winner bet funds
            
            //repeat?*



        }

        void display()
        {
            for (int i = 0;i<5;i++)
            {
                //Console.
            }
        }

        void deal()
        {

        }



        

    }
    
    public class Seat
    {
        public int funds;
        public string name;
        public bool isBlind;

    }



    class Opponent : Seat
    {
        public void cardAnalysis()
        {
            //check cards and make weighted detrmination to bet, check or fold
            
        }
    }


    

    
}
