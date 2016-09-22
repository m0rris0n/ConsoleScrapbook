using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleScrapbook.Main;
using ConsoleScrapbook.Mastermind;
using ConsoleScrapbook.Scrap;
using ConsoleScrapbook.FenChess;
using ConsoleScrapbook.Poker;
using ConsoleScrapbook.FormBuilderAPI;
using ConsoleScrapbook.HackerRank;
namespace ConsoleScrapbook
{
    class Program
    {
        static void Main(string[] args)
        {
            NodeLinkedList nll = new NodeLinkedList();
            nll.run();
            

            #region Dictionaryfunction
            //Person mcDicks = new Person(12);
            //mcDicks.amIOld();
            //Console.ReadLine();
            #endregion

            //int V = Convert.ToInt32(Console.ReadLine());
            //int n = Convert.ToInt32(Console.ReadLine());
            //string ar = Console.ReadLine();

            //int[] array = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    array[i] = ar.Split(' ').Select(Int32.Parse).FirstOrDefault();
            //    //array[i] = 
            //}

            //DummyAPI dummy = new DummyAPI();

            //Class1 classA = new Class1()
            //{
            //    a = "stuff",
            //    b = "thing"
            //};
            //Class1 classB = new Class1()
            //{
            //    c = 3
            //};

            //classA = classB;

            //Console.ReadLine();


            //Transpose transpose = new Transpose();
            //transpose.addString("Who even reads this stuff?");
            //transpose.addString("Certainly not me!");
            //transpose.transpose();
            //Console.ReadLine();

            //Threadz threadz = new Threadz();
            //threadz.Run(); August

            //string insertion = Console.ReadLine();
            //Console.WriteLine(insertion);
            //Console.ReadLine();

            #region ModelMatch Loop
            //ModelPropertyMatch mpm = new ModelPropertyMatch();
            //StudentPartial sP = mpm.mockStudentPartial();
            //StudentFull sF = mpm.buildJson(sP);
            //Console.WriteLine(sF.Id);
            //Console.WriteLine(sF.Name);
            //Console.WriteLine(sF.Thing);
            //Console.ReadLine();
            //Console.WriteLine(sF.OtherThing);
            //Console.WriteLine(sF.Boolean);
            #endregion





            //Console.WriteLine(IsPalindrome("Noel sees Leon."));


            #region Poker
            //string joe;

            //joe = "pool";
            //joe = joe + "pool";

            //joe = joe.Substring(0,1);

            //joe = "" + 1 + 3;

            //Console.WriteLine(joe);




            //VideoPoker vidP = new VideoPoker();



            #endregion

            #region ref example
            /*
            RefExample reffer = new RefExample();

            //reffer.Main();

            OutExample outter = new OutExample();

            outter.Main();
            */
            #endregion

            #region charjunk
            /* 
            char c = (char)157;
            Console.WriteLine("♝here♝ ⃞ ██ "+c);
            Console.ReadLine();
            WordGenerator test = new WordGenerator();

            for (int i = 0; i < 250; i++)
            {
                //string box = "██";
                //foreach (char b in box)
                //{
                //    int i = (int)b;
                //    Console.WriteLine("box: " + i);
                //}
                c = (char)i;
                Console.WriteLine(c + " " + i);
            }

            /*
            //test.wordGen(2);
            int doot = 0;
            for (int i = 0;i<8;i++)
            {

                for (int k = 0;k<8;k++)
                {
                    switch(doot)
                    {
                        case 0:
                            Console.Write((char)9616);
                            doot = 1;
                            break;
                        case 1:
                            Console.Write(" ");
                            doot = 0;
                            break;
                    }                
                }
                Console.Write("\n");
                if (doot == 0)
                    doot = 1;
                else
                    doot = 0;

            }*/

            #endregion

            #region BoardTest
            /*
            string fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";
            string behting = "8/8/7p/3KNN1k/2p4p/8/3P2p1/8 w - -";
            string laskerReichhelm = "8/k7/3p4/p2P1p2/P2P1P2/8/8/K7 w - -";
            string djaja = "6R1/P2k4/r7/5N1P/r7/p7/7K/8 w - -";

            ChessMain chess = new ChessMain();
            chess.drawBoard(fen);
            Console.WriteLine();
            chess.drawBoard(behting);
            Console.WriteLine();
            chess.drawBoard(laskerReichhelm);
            Console.WriteLine();
            chess.drawBoard(djaja);
            */
            #endregion

            #region Chess

            //ChessMain chess = new ChessMain();

            #endregion

            //String readline = null;

            #region LeaderSort
            /*
            int[] segsA = { 1, 3, 7, 9, 9 };
            int[] segsB = { 5, 6, 8, 9, 10 };

            int[] nA = { 0, 0, 1, 1, 4, 5, 6, 3, 8, 9 };
            int[] nB = { 0, 1, 2, 3, 4, 7, 7, 8, 10, 10 };
             */
            #endregion

            #region NoStrings
            //Array.add(segsB, 5);
            /*List<int> itemList = segsA.ToList<int>();
            itemList.AddRange(segsB);
            List<int> itemListF = segsB.ToList<int>();
            itemList.AddRange(segsA);
            int n = 10;


            for(int i=0;i<n;i++){
                //Console.Out.WriteLine(itemList[i]);
                Console.Out.WriteLine("Wat"+i);
                n++;
                if (n == 100)
                    break;
            }*/

            /*
            string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we’ll all have tea";
            //string text = "abcdefghi";
            string subtext = "Polly";
            */



            //Console.Out.WriteLine(s.solution(segsA,segsB));
            /* 
            string textY = "Here's some text including a \u00ff non-ASCII character";
            foreach (char c in textY)
            {

                int unicode = c;
                Console.WriteLine(unicode < 128 ? "ASCII: {0}" : "Non-ASCII: {0} 4", unicode);
                Console.WriteLine()
            }
            int bob = 9;
            string beans = "here: " + bob;*/

            #endregion

            #region Palindromic

            /*
            while (readline != "exit")
            {
                Console.Clear();
                Console.Out.WriteLine("Please enter a number");
                readline = Console.In.ReadLine();
                if((readline == "exit") || (readline == "quit"))
                    break;

                int i;
                if (int.TryParse(readline,out i))
                {
                    Palindromic s = new Palindromic();
                    Console.Out.WriteLine(s.solution(readline));
                    Console.In.ReadLine();

                }                           

            }
            */
            #endregion

            #region Fibonacci
            /*
            Fibonacci fibo = new Fibonacci();
            int n = 5;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(fibo.solution(i));
            }
            Console.ReadLine();
            */
            #endregion

            #region Permutation
            /*
            int[] A = { 1, 3, 2, 5, 4 }; //1
            int[] B = { 3, 4, 1, 5, 2 }; //1
            int[] C = { 4, 3, 2, 5, 4 }; //0
            int[] D = { 1, 3, 6, 5, 4 }; //0
            int[] E = { 1, 2, 3, 4, 5 }; //1
            int[] F = { 5, 4, 3, 2, 1 }; //1

            int[] Y = { 14, 4, 8, 7, 13, 11, 5, 3, 6, 12, 20, 18, 9, 10, 19, 15, 17, 16, 1, 2 }; //1
            int[] Z = { 14, 4, 8, 1, 13, 2, 5, 3, 6, 12, 20, 100, 9, 10, 19, 15, 17, 16, 1, 2 }; //0

            //Console.WriteLine(A.Length);





            Permutation perm = new Permutation();

            //Console.WriteLine(perm.solution(A));
            //Console.WriteLine(perm.solution(B));
            //Console.WriteLine(perm.solution(C));
            //Console.WriteLine(perm.solution(D));
            //Console.WriteLine(perm.solution(E));
            //Console.WriteLine(perm.solution(F));
            Console.WriteLine(perm.solution(Y));
            Console.WriteLine(perm.solution(Z));
            Console.ReadLine();
            */

            #endregion

            #region Pointer
            //Pointer point = new Pointer();

            ////int[] B = { 2, 4, 1, -1, 3 };
            ////int[] Y = { 14, 4, 8, 7, 13, 11, 5, 3, 6, 12, -1, 18, 9, 10, 19, 15, 17, 16, 1, 2 };

            //Console.WriteLine(point.solution(3,7));
            //Console.ReadLine();
            #endregion

            #region ChainBuster

            //int[] intArrayA = new int[6] { 5, 2, 4, 6, 3, 7 }; //5
            //int[] intArrayB = new int[7] { 100, 1, 1, 4, 6, 3, 7 }; //4
            //int[] intArrayC = new int[6] { 2, 2, 3, 3, 1, 1 }; //3
            //int[] intArrayD = new int[6] { 5, 4, 3, 3, 3, 7 }; //6

            //Chains chains = new Chains();
            //Console.Out.WriteLine("intArray A: " +chains.solution(intArrayA));
            //Console.Out.WriteLine("intArray B: " + chains.solution(intArrayB));
            //Console.Out.WriteLine("intArray C: " + chains.solution(intArrayC));
            //Console.Out.WriteLine("intArray D: " + chains.solution(intArrayD));
            //Console.ReadLine();

            #endregion

            #region AsciiBuilder
            /*
            Console.WriteLine("How many floors does the house have?");
            Builder b = new Builder();
            int num = Convert.ToInt32(Console.ReadLine());
            var floorStack = b.bluePrints(num);

            int n = floorStack.Length / num;
            for (int i = 0; i < num; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (floorStack[k, i] == true)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            */
            #endregion

            #region GameOfThrees

            //Console.Write("Please enter your starting number: ");
            //int i = Convert.ToInt32(Console.ReadLine());
            //i.gimmieThree();
            //Console.ReadLine();
            #endregion

            //for (int i=0;i<)


        }
    }
}
