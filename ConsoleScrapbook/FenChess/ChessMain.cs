using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.FenChess
{
    public class ChessMain
    {
        bool bOw = true;
        bool gg = false;
        string Fen;
        string MoveFrom;
        string MoveTo;
        bool check = false;
        ///////////////
        //Current piece
        private int X; //destination in FEN
        private int Y; //destination in FEN
        private int N; //destination in FEN
        private int A; //start in FEN
        private int B; //start in FEN
        private int S; //start in FEN
        private string Piece; // Moving piece
        private string Target; // Target piece (if relevent)
        ////////////////


        public ChessMain()
        {
            Fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";
            while(gg == false)
            {
                drawBoard(Fen);
                input(out MoveFrom, out MoveTo);
                move(ref Fen);
                endTurn(ref Fen);
                Console.Clear();
            }
        }
        void drawBoard(string fen)
        {
            int k = 8;
            Console.Write("  ABCDEFGH\n" + k + "|");
            foreach (char c in fen)
            {       
                if (char.IsDigit(c))
                {
                    for (int i = 0; i < (int)char.GetNumericValue(c); i++) //prints a row space for number of defined spaces
                    {
                        if (bOw == true)
                            Console.Write((char)9616); //prints white space
                        else
                            Console.Write((char)9617); //prints black space
                        bOw = !bOw;
                    }
                }
                else if (c == 32) //check if a space is encountered. 
                {
                    Console.Write("|"+k+"\n  ABCDEFGH\n");
                    bOw = !bOw; //inverts black/white space monitor
                    break; //termintates loop as firat space indicates end of visually displayed board
                }
                else if (c == 47) //checks for forward slash which indicates end of row
                {
                    if ((check == true)&&(k==1))
                        Console.Write("|" + k + "      CHECK\n" + (k-1) + "|");
                    else
                        Console.Write("|" + k + "\n" + (k-1)+"|");
                    k--;
                    bOw = !bOw; //inverts black/white space monitor
                }
                else if (c > 65)
                {
                    Console.Write(c); //Draw a gamepiece
                    bOw = !bOw; //inverts black/white space monitor
                }
                
                #region garbageswitch
                //does not work as intended. for educational reference only
                //switch/case cannot be used in this way (dropping down)
                /*switch ((int)c)
                {
                    case 32:
                        //space
                        break;
                    case 45:
                        //castling check
                        break;
                    case 47:
                        Console.Write("\n");
                        level++;
                        break;
                    case 48-57:
                        //Draw a board square for each number
                        for (int i = 0; i < (int)Char.GetNumericValue(c); i++)
                        {
                            if (bOw == true)
                                Console.Write((char)9616);
                            else
                                Console.Write(" ");
                            bOw = !bOw;
                        }
                        break;
                    case 65 - 122:
                        Console.Write(c); //Draw a gamepiece
                        bOw = !bOw;
                        break;
                    

                }*/
                #endregion
                //Console.Write()
            }
            Console.WriteLine("\n" + Fen);

        }

        void input(out string moveFrom, out string moveTo)
        {
            string error;
            Console.WriteLine("It is {0}'s turn.", determineTurn(Fen));
            Console.Write("Please enter the coordinates of the piece you wish to move: ");
            moveFrom = Console.ReadLine();
            while (legalSelect(moveFrom,ref Piece,out error) == false)
            {
                Console.Clear();
                drawBoard(Fen);
                Console.WriteLine("It is {0}'s turn.", determineTurn(Fen));
                Console.Write(error);
                Console.Write("Please enter the coordinates of the piece you wish to move: ");
                moveFrom = Console.ReadLine();
            }

            Console.Write("Please enter the coordinates you wish to move this piece to: ");
            moveTo = Console.ReadLine();
            while ((legalMove(moveTo, ref Target,out error) == false)||(moveTo == moveFrom))
            {
                Console.Clear();
                drawBoard(Fen);
                Console.WriteLine("It is {0}'s turn.", determineTurn(Fen));
                Console.WriteLine("Please enter the coordinates you wish to move this piece to: {0}",moveFrom);
                Console.Write(error);
                moveTo = Console.ReadLine();
            }
        }

        void move(ref string fen)
        {
            StringBuilder sb = new StringBuilder(fen);
            string insert;
            int head = -1;
            int temp = 0;
            int temp2 = X;
            int exNum = 1;
            //int rep = 1; //number of characters to replace

            //Removal
            if (S != 0)
            {
                if(char.IsDigit(fen.ElementAt(S-1)))
                {
                    exNum += (int)char.GetNumericValue(fen.ElementAt(S - 1));
                    if (S < N)
                    {
                        N--;
                        temp2--;
                    }
                    
                    //
                    sb.Remove(S-1,1);
                    S--;
                    //rep++;
                    fen = sb.ToString();
                }
            }
            if (S != (fen.Length - 1))
            {
                if (char.IsDigit(fen.ElementAt(S + 1)))
                {
                    exNum += (int)char.GetNumericValue(fen.ElementAt(S + 1));
                    {
                        N--;
                        temp2--;
                    }
                    sb.Remove(S + 1, 1);
                    //rep++;
                    fen = sb.ToString();
                }
            }
            insert = exNum.ToString();

            sb.Replace(fen.ElementAt(S).ToString(), insert, S, 1);

            fen = sb.ToString();

            int i = N;

            //If placing the piece on a an empty square
            if (char.IsDigit(fen.ElementAt(N)))
            {
                //Determine the head
                if (i == 0)
                    temp = temp2;
                else
                {
                    do
                    {
                        i--;
                        if (fen.ElementAt(i) == 47)
                        {
                            head = i + 1;
                        }
                        else if (i == 0)
                        {
                            head = i;
                        }
                    }
                    while (head == -1);
                    temp = head + temp2;
                }

                //Remove the numerical character
                exNum = (int)char.GetNumericValue(fen.ElementAt(N));
                if ((temp > N)&& 0 < (exNum - (temp - N) - 1))
                {
                    insert = ((temp - N) + Piece + (exNum - (temp - N) - 1));
                }
                else if(temp > N)
                {
                    insert = ((temp - N) + Piece);
                }
                else
                {
                    if (exNum > 1)
                        insert = (Piece + (exNum - 1));
                    else
                        insert = (Piece);
                }

                sb.Replace(fen.ElementAt(N).ToString(), insert, N,1);

            }
            else //if placing the piece on another piece
            {
                sb.Replace(fen.ElementAt(N).ToString(), Piece, N, 1);
            }

            fen = sb.ToString();

                

            
        }

        /// <summary>
        /// Reads the FEN as a virtual grid and returns a string containing the contents of a specific square
        /// </summary>
        /// <param name="fen">The FEN string containing the current game status</param>
        /// <param name="x">The virtual x coordinate of a piece on the board</param>
        /// <param name="y">The virtual y coordinate of a piece on the board</param>
        /// <param name="n">The piece's location in the FEN string</param>
        /// <returns>string containing the chosen character from the fen string</returns>
        string determineOccupant(ref string fen, ref int x, ref int y, ref int n)
        {
            int i = 0;
            int j = 0;
            n = 0;
            foreach(char c in fen)
            {
                if (i == y)
                {
                    if (j != x)
                    {
                        if (c > 65)
                            j++;
                        else if (char.IsDigit(c))
                        {
                            if ((int)char.GetNumericValue(c) + j > x)
                            {
                                return "!";
                            }
                            else
                                j += (int)char.GetNumericValue(c);
                        }
                    }
                    else
                        return c.ToString();
                }
                if (c == 47)
                {
                    i++;
                    j = 0;
                }
                n++;

            }
            return "OOBF";


        }

        /// <summary>
        /// Transforms game coordinates (a-h,1-8) into zero indexed array coordinates(0-7,0-7)
        /// It changes class scoped properties via reference and returns a bool confirming input is valid
        /// </summary>
        /// <param name="stringCoords">User input coordinates</param>
        /// <param name="x">Class property denoting virtual position</param>
        /// <param name="y">Class property denoting virtual position</param>
        /// <returns>True or False depending on stringCoords input</returns>
        bool coordsToIntValid(string stringCoords, ref int x, ref int y)
        {
            stringCoords.ToLower();
            if (stringCoords.Length != 2)
                return false;
            if (((stringCoords.ElementAt(0) < 97) || (stringCoords.ElementAt(0) > 104)) || ((stringCoords.ElementAt(1) < 49) || (stringCoords.ElementAt(1) > 56)))
                return false;

            y = ((int)char.GetNumericValue(stringCoords.ElementAt(1)) - 8)* -1;
            x = stringCoords.ElementAt(0) - 49;
            x = (int)char.GetNumericValue((char)x);
            return true;
        }

        /// <summary>
        /// Returns string denoting the active player (either "black" or "white")
        /// </summary>
        /// <param name="fen"></param>
        /// <returns>"black" or "white"</returns>
        string determineTurn(string fen)
        {
            string[] result = fen.Split((char)32); //splits the string by " " (or space character)
            if (result[1] == "w")
            {
                return "white";
            }
            return "black";

        }

        void endTurn(ref string fen)
        {
            StringBuilder sb = new StringBuilder(fen);
            string turn = determineTurn(fen);
            if (turn == "white")
                sb.Replace(" w", " b");
            else
                sb.Replace(" b", " w");
            fen = sb.ToString();
        }

        bool legalSelect(string xy, ref string piece, out string errorMessage)
        {
            //Check to see if the exit code has been provided (closes the program instantly) 
            if (xy == "gg")
                Environment.Exit(0);
            //Check to see if the coords supplied are within the bounds of the gameboard
            if (!coordsToIntValid(xy, ref A, ref B))
            {
                errorMessage = "The coordinates you provided are invalid. You must enter two character reference coordinates, i.e. 'H1' or 'C7'";
                return false;
            }



            //provided adequte coordinates are provided, a gamepiece is identified
            piece = determineOccupant(ref Fen, ref A, ref B, ref N);

            //Check to determine there is a piece in the coords supplied 

            if ((piece == "!") || (char.IsDigit(piece.ElementAtOrDefault(0))))
            {
                errorMessage = "There is no gamepiece in the coordinates specified. You must select a space containing one of your game pieces";
                return false;
            }

            if (((determineTurn(Fen) == "white") && (char.IsLower(piece.ElementAt(0))))^((determineTurn(Fen) == "black")&& (char.IsUpper(piece.ElementAt(0)))))
            {
                errorMessage = "That is not one of your piece. Remember White is represented Upper-case letters, whereas Black is represented by Lower-case letters.";
                return false;
            }

            //confirm piece is actually free to move (not smothered/blocked etc) method?

            switch(piece.ToLower())
            {
                case "p":
                    if ((pathCheck(A, B, A, B + 1))&&(determineTurn(Fen) == "black"))
                    {
                        S = N;
                        errorMessage = null;
                        return true;
                    }
                    else if ((pathCheck(A, B, A, B - 1)) && (determineTurn(Fen) == "white"))
                    {
                        S = N;
                        errorMessage = null;
                        return true;
                    }
                    else
                    {
                        S = N;
                        errorMessage = "This piece has no legal moves. You must select another piece";
                        return false;
                    }
                //pawns +1  ahead or enpassant/attack
                case "q":
                //queen any 1 space around
                case "b":
                //bishop any 1 space in the four diagonals
                case "r":
                //rook any 1 space in the four cardinals
                case "n":
                //knight technical
                case "k":
                //king any 1 space in the four cardinals
                default:
                    errorMessage = "There is no gamepiece in the coordinates specified. Please select a space containing one of your game pieces";
                    return false;

            }
                        
            if (check == true)//&& chosen piece != the king
                return false;
            //Check

            S = N;
            errorMessage = null;
            return true;
        }

        bool legalMove(string xy, ref string target, out string errorMessage)
        {
            //Check to see if the exit code has been provided (closes the program instantly) 
            if (xy == "gg")
                Environment.Exit(0);
            //Check to see if the coords supplied are within the bounds of the gameboard
            if (!coordsToIntValid(xy, ref X, ref Y))
            {
                errorMessage = "The coordinates you provided are invalid. Please enter two character reference coordinates, i.e. 'H1' or 'C7'";
                return false;
            }
            target = determineOccupant(ref Fen, ref X, ref Y, ref N);
            //PIECE MOVEMENT RESTRICTIONS
            //return or alter the conditions:
            //castling
            //en passant
            //pawn 2x
            //promotion
            //check - maybe a check confirmation after every move
            errorMessage = null;
            return true;
        }



        bool pathCheck(int a, int b, int x, int y)
        {
            int dump = 0;
            if (a == x)
            {
                if (b > y)
                {
                    for (int i = b - 1; i > y; i--)
                        if (determineOccupant(ref Fen, ref a, ref i, ref dump) != "!")
                            return false;
                    return true;
                }
                else //(b < y)
                {
                    for (int i = b+ 1; i < y; i++)
                        if (determineOccupant(ref Fen, ref a, ref i, ref dump) != "!")
                            return false;
                    return true;
                }
            }
            else if(a > x)
            {
                if (b > y)
                {
                    int j = a;
                    for (int i = b - 1; i > y; i--)
                    {
                        if (determineOccupant(ref Fen, ref j, ref i, ref dump) != "!")
                            return false;
                        j--;
                    }
                    return true;
                }
                else if (b < y)
                {
                    int j = a;
                    for (int i = b +1 ; i < y; i++)
                    {
                        if (determineOccupant(ref Fen, ref j, ref i, ref dump) != "!")
                            return false;
                        j--;
                    }
                    return true;
                }
                else //(b == y)
                {
                    for (int j = a - 1; j > y; j--)
                    {
                        if (determineOccupant(ref Fen, ref j, ref b, ref dump) != "!")
                            return false;
                    }
                    return true;
                }
            }
            else //(a < x )
            {
                if (b > y)
                {
                    int j = a;
                    for (int i = b -1 ; i > y; i--)
                    {
                        if (determineOccupant(ref Fen, ref j, ref i, ref dump) != "!")
                            return false;
                        j++;
                    }
                    return true;
                }
                else if (b < y)
                {
                    int j = a;
                    for (int i = b+ 1; i < y; i++)
                    {
                        if (determineOccupant(ref Fen, ref j, ref i, ref dump) != "!")
                            return false;
                        j++;
                    }
                    return true;
                }
                else //(b == y)
                {
                    for (int j = a -1; j > y; j++)
                    {
                        if (determineOccupant(ref Fen, ref j, ref b, ref dump) != "!")
                            return false;
                    }
                    return true;
                }
            }
            
        }




    }
}
/*
"{0} is not a legal move for this piece. Please select legal coordinates:", moveTo
"Your King is in check. You must protect the King!"
"{0} does not contain one of your pieces. Remember white pieces are represented as Upper-Case letters, whereas black pieces are represented as lower-case letters."
    "Please reselect the coordinates of the piece you wish to move: "
    */