using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Poker Scores
9 Straight Flush
8 Four of a kind nf
7 Full House nf
6 Flush 
5 Straight 
4 Three of a kind 
3 Two Pair 
2 One Pair 
1 High Card 
*/

namespace ConsoleScrapbook.Poker
{
    class VideoPoker
    {
        static Random rand = new Random();
        Deck deck = new Deck();
        private List<Card> playerHand = new List<Card>();
        int count; //keeps track of how many cards have been dealt
        string[] mark = {" "," "," "," "," "};
        //List<Card> marked = new List<Card>();
        
        public VideoPoker()
        {
            count = deck.shuffle();
            singleDeal(playerHand);
            handSort();
            display(playerHand);
            //int w = input();
            perform(2); //w
            Console.Clear();
            display(playerHand);
            Console.WriteLine(handCheck(playerHand));
            //Console.WriteLine(fullHandCheck(playerHand));

        }

        /// <summary>
        /// Creates the visual display of the cards [suits, numbers] hand identifiers, marks, and command words
        /// </summary>
        void display(List<Card> hand)
        {
            for (int i= 0; i < 5; i++)
            {
                string dCard;
                switch(hand[i].Value)
                {
                    case 1:
                        dCard = "A" + suitCharacter(hand[i].Suit) + "  ";
                        break;
                    case 10:
                        dCard = hand[i].Value + "" + suitCharacter(hand[i].Suit) + " ";
                        break;
                    case 11:
                        dCard = "J" + suitCharacter(hand[i].Suit) + "  ";
                        break;
                    case 12:
                        dCard = "Q" + suitCharacter(hand[i].Suit) + "  ";
                        break;
                    case 13:
                        dCard = "K" + suitCharacter(hand[i].Suit) + "  ";
                        break;
                    default:
                        dCard = hand[i].Value + "" + suitCharacter(hand[i].Suit) + "  ";
                        break;
                }
                           
                Console.Write(dCard);
            }
            Console.WriteLine();
            Console.WriteLine("1{0}  2{1}  3{2}  4{3}  5{4}",mark[0],mark[1],mark[2],mark[3],mark[4]);
            Console.WriteLine("\nCheck   Swap   Quit\n");
            
        }

        /// <summary>
        /// Burns the first card and then adds 5 cards one by one to the hand list
        /// </summary>
        void singleDeal(List<Card> hand)
        {
            deck.burn(count);
            count++; //burn
            for (int i = count; i < count + 5; i++)
            {
                hand.Add(deck.card[i]);
            }
            count+=5;
        }

        //void 



        /// <summary>
        /// Checks against which strings in the mark array contain the required character and deletes the respective card from the hand list.
        /// A new card is taken from the deck and is inserted into the list.
        /// </summary>
        void swap()
        {
            for(int i = 4;i >-1;i--)
            {
                /*dead
                if (playerHand[i] == marked.FirstOrDefault())
                {
                    playerHand.RemoveAt(i);
                    playerHand.Add(deck.card[count]);
                    count++;
                    mark[i] = " ";
                    marked.RemoveAt(0);
                }*/

                if(mark[i] == ("" + (char)171))
                {
                    playerHand.RemoveAt(i);
                    playerHand.Add(deck.card[count]);
                    count++;
                    mark[i] = " ";
                }

                mark[i] = " ";

            }
            handSort();
        }
        /// <summary>
        /// Requests and accepts user input. Once received input is parsed through the verify method an action code is produced and returned
        /// </summary>
        /// <returns>An int representing an action code</returns>
        int input()
        {
            Console.WriteLine("What would you like to do?");
            string input = Console.ReadLine().ToLower();
            int action = inputVerify(input);
            while (action == 0)
            {
                Console.Clear();
                display(playerHand);
                Console.WriteLine("Sorry, {0} is not a valid instruction. Please enter a valid input.",input);
                Console.Write(">");
                input = Console.ReadLine().ToLower();
                action = inputVerify(input);
            }
            return action;            
        }

        /// <summary>
        /// Takes action input code and runs the required methods and processes
        /// </summary>
        /// <param name="action">int between 1 - 3 </param>
        void perform(int action)
        {
            switch(action)
            {
                case 1: //check
                    break;
                case 2: //select
                    cardSelect();
                    swap();
                    break;
                case 3: //raise //null for the moment
                    
                default: //do nothing
                    break;
            }
        }

        /// <summary>
        /// input int determines the suit character
        /// </summary>
        /// <param name="num">an int btween 0 and 3 </param>
        /// <returns>a character representing a card suit</returns>
        string suitCharacter(int num)
        {
            switch(num)
            {
                case 0:
                    return ((char)6).ToString();
                case 1:
                    return ((char)3).ToString();
                case 2:
                    return ((char)5).ToString();
                case 3:
                    return ((char)4).ToString();
                default:
                    return ((char)246).ToString();
            }
        }

        /// <summary>
        /// Used to confirm the input string is a recognised command
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Returns an int used to detrmine which instruction has been requested, or a 0 for a failed entry</returns>
        int inputVerify(string input)
        {
            switch (input)
            {
                case "check":
                    return 1;
                case "swap":
                    return 2;
                case "raise":
                    return 3;
                case "quit":
                    Console.Clear();
                    Console.WriteLine("Thanks for playing!\nPress any key to terminate the program");
                    Console.ReadKey();
                    Environment.Exit(0);
                    return -1;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Creates a loop which records individual key presses. 
        /// All key presses berak the loop without perfomning any further function with the exception of the number keys 1 through to 5.
        /// if 1, 2, 3, 4, 5 are pressed the corropsonding string the i nthe mark array is toggled between " " and an arrow symbol.
        /// </summary>
        void cardSelect()
        {
            Console.Clear();
            display(playerHand);
            Console.WriteLine("Which cards do you want to swap?");
            //Console.ReadLine();

            while(true)
            {
                ConsoleKeyInfo line = Console.ReadKey();
                if ((line.KeyChar > 48)&&(line.KeyChar < 54))
                {
                    if (mark[line.KeyChar - 49] == " ")
                    {
                        mark[line.KeyChar - 49] = "" + (char)171;
                    }
                    else
                        mark[line.KeyChar - 49] = " ";
                    Console.Clear();
                    display(playerHand);
                    Console.WriteLine("Which cards do you want to swap?");
                }
                else
                    break;
            }

            /*dead
            for(int i= 0;i<5;i++)
            {
                if (mark[i] == ("" + (char)171))
                {
                    marked.Add(playerHand[i]);
                }
            }*/


        }

        /// <summary>
        /// Five Card hand check
        /// Sorts through card list to determine winning poker hands
        /// </summary>
        /// <param name="hand">A list of cards</param>
        /// <returns>A three digit int based on value of hand</returns>
        int handCheck(List<Card> hand)
        {
            int straightCount = 0;
            int flushCount = 0;
            int highCard = 0;

            int pairCount = 0;
            List<int> pairList = new List<int>();
                        
            #region HighCard
            if (hand[0].Value == 1)
            {
                highCard = 14;
            }
            else
                highCard = hand[4].Value;
            #endregion
            #region Flush
            for(int i = 0;i<4;i++)
            {
                if (hand[i].Suit == hand[i + 1].Suit)
                {
                    flushCount++;
                }
                else
                    break;
            }
            #endregion
            #region Straight
            for(int i = 0;i<4;i++)
            {

                if (hand[i].Value + 1 == hand[i + 1].Value)
                {
                    straightCount++;
                }
                else
                    break;
            }
            #endregion

            if ((flushCount == 4)||(straightCount == 4))
            {
                if (straightCount < 4)
                    return 600 + highCard; //[6] Flush
                else if (flushCount < 4)
                    return 500 + highCard; //[5] Straight
                else
                    return 900 + highCard; //[9] Straight Flush
            }

            #region Pairs
            for(int i = 0;i<4;i++)
            {
                if(hand[i].Value == hand[i+1].Value)
                {
                    pairCount++;
                }
                else if(pairCount > 0)
                {
                    pairList.Add(pairCount);
                    pairList.Add(hand[i - 1].Value);
                    pairCount = 0;
                }
            }
            if(pairCount > 0)
            {
                pairList.Add(pairCount);
                pairList.Add(hand[4].Value);
                pairCount = 0;
            }

            if(pairList.Count == 2)
            {
                switch(pairList[0])
                {
                    case 1:
                        return 200 + highCard; //[2] 1 Pair
                    case 2:
                        return 400 + highCard; //[4] 3 of a kind
                    case 3:
                        return 800 + highCard; //[8] 4 of a kind
                    default:
                        break; //shits broke yo
                }        
                //if(pairList.Count == 4)
            }
            else if(pairList.Count == 4)
            {
                if (pairList[0] == pairList[2])
                    if (highCard < 14)
                        return 300 + pairList[3]; //[3]2 Pair
                    else
                        return 300 + highCard; //[3] 2 Pair Ace high
                else if (pairList[0] < pairList[2])
                    return 700 + pairList[3]; //[7] Full House (Last Three)
                else
                    if (highCard < 14)
                        return 700 + pairList[1];//[7] Full House (First Three)
                    else
                        return 700 + highCard;//[7] Full House Ace High
            }
            #endregion

            return 100 + highCard;//[1] high Card
        }


        /// <summary>
        /// Improved hand check that can scan through >5 cards to find the highest 5 card hand combination.
        /// Hopefully can replace current handCheck method.
        /// </summary>
        int fullHandCheck(List<Card> river)
        {
            int[] suits = { 0, 0, 0, 0 };
            int straightCount = 0;
            int straightHigh = 0;
            int flushCount = 0;
            int flushHigh = 0;
            int flushSuit = -1;
            int highCard = 0;

            int pairCount = 0;
            List<int> pairList = new List<int>();

            #region Straight/Flush
            for (int i = 0; i < (river.Count - 1); i++) //sorts through full river and counts the suit occurences
            {
                switch (river[i].Suit)
                {
                    case 0:
                        suits[0]++;
                        break;
                    case 1:
                        suits[1]++;
                        break;
                    case 2:
                        suits[2]++;
                        break;
                    case 3:
                        suits[3]++;
                        break;
                    default: //wildcard (subject to abuse?)
                        suits[0]++;
                        suits[1]++;
                        suits[2]++;
                        suits[3]++;
                        break;
                }
            }
            if (suits.Max() > 4) //if a flush has been detected
            {
                for (int i = 0; i < 4;i++) //
                {
                    if(suits[i] == suits.Max())
                    {
                        flushSuit = i;
                    }
                }
                for(int i = 0; i<3;i++)
                {
                    if ((river[i].Suit == flushSuit) && (river[i].Value == 1))
                        flushHigh = 14;
                }
            }







            /*
                if (hand[i].Suit == hand[i + 1].Suit)
                {
                    flushCount++;
                }
                else if ((i>3)&&(flushCount == 0)) 
                    break; //if you dont have a flush going by the third card check it's GG
                else
                    flushCount = 0;

                if(flushCount >= 4) //if a flush is complete or increased, set the newest hard as the high card
                {
                    flushHigh = hand[i+1].Value;
                    flushSuit = hand[i].Suit;
                }

                
            }*/
            //if((flushHigh > -1)&&())
            















            for (int i = 0; i < (river.Count - 1); i++)
            {
                if (river[i].Value + 1 == river[i + 1].Value)
                {
                    straightCount++;
                }
                else if ((i > 3) && (straightCount == 0)) 
                    break; //if you dont have a straight going by the third card check it's GG
                else
                    straightCount = 0;

                if (straightCount >= 4) //if a straight is complete or increased, set the newest hard as the high card
                {
                    straightHigh = river[i + 1].Value;
                }
            }

            if ((flushHigh > 0) || (straightHigh > 0))
            {
                if (straightHigh < flushHigh)
                    return 600 + flushHigh; //[6] Flush
                else if (flushHigh == 0)
                    return 500 + straightHigh; //[5] Straight
                else 
                    return 900 + flushHigh; //[9] Straight Flush
            }

            #endregion



            return 100 + highCard;
        }
        
        /// <summary>
        /// Sorts card objects in hand list into numerical order
        /// </summary>
        void handSort()
        {
            bool repeat;
            do
            {
                repeat = false;
                for (int i = 0; i < 4; i++)
                {
                    while (playerHand[i].Value > playerHand[i + 1].Value)
                    {
                        repeat = true;
                        Card hold = playerHand[i];
                        playerHand.RemoveAt(i);
                        playerHand.Add(hold);
                    }
                }
            } while (repeat);
        }

        /// <summary>
        /// Sorts river and 2 hold card numerically and combines them in a full 7 card list to be passed straight to the 7 card score checker
        /// </summary>
        /// <param name="river">List holding the river cards</param>
        /// <param name="hand">List holding the two hand cards</param>
        /// <returns>A combined list of all the input cards</returns>
        List<Card> fullHandSort(List<Card> river,List<Card> hand)
        {
            for (int k = 0; k < hand.Count; k++)
                river.Add(hand[k]);
            bool repeat;
            do
            {
                repeat = false;
                for (int i = 0; i < river.Count; i++)
                {
                    while (river[i].Value > river[i + 1].Value)
                    {
                        repeat = true;
                        Card hold = river[i];
                        river.RemoveAt(i);
                        river.Add(hold);
                    }
                }
            } while (repeat);
            return river;
        }


    }
}
