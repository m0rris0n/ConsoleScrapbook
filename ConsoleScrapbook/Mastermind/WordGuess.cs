using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleScrapbook.Exceptions;

namespace ConsoleScrapbook.Mastermind
{
    public class WordGuess
    {
        int guesses;
        string[] guessDisplay;
        string answer;

        /*
        public WordGuess(out string[] guessDisplayIni)
        {
            guesses = 4;
            WordGenerator wordGenerator = new WordGenerator();
            List<string> words = wordGenerator.Generate();
            guessDisplayIni = new string[words.Count / 2];
            answer = answerGen(words);
            display(words);

        }*/

        int wordCheck(string answer, string guess)
        {
            int result = 0;
            for (int i = 0; i < (answer.Length); i++)
                if (answer.ElementAt(i) == guess.ElementAt(i))
                    result++;
            return result;
        }

        void display(List<string> wordSet)
        {
            for (int i = 0; i< guesses;i++)
            {
                Console.Write((char)9616 + " ");
            }
            Console.WriteLine();
            int words = wordSet.Count();
            guessDisplay = new string[wordSet.Count() / 2];

            for (int i = 0; i < words; i += 2)
            {
                Console.WriteLine(wordSet.ElementAt(i) + " " + wordSet.ElementAt(i + 1) + " "+guessDisplay[i]);
                Console.WriteLine();
            }
            //show words, remaining guesses, words guessed
        }

        string input(List<string> wordSet)
        {
            string guess = Console.ReadLine();
            if (!wordSet.Contains(guess))
            {
                Console.WriteLine("'{0}' is not on the list. Please enter an item from the list.");
            }
            return guess; //what fucking shit is this? sure is a waste of resources in here
        }

        string answerGen(List<string> wordSet)
        {
            Random rand = new Random();
            string answer = wordSet.ElementAt(rand.Next(wordSet.Count) - 1);
            return answer; //perchance this should be i nthe constructor method?
        }
    }

    public class WordGenerator
    {
        //public void wordGen(int len)
        //{
        //    string[] lines = null;
        //    try
        //    {
        //        lines = File.ReadAllLines(@"\Users\Tristan Morrison\Documents\Visual Studio 2013\Projects\ConsoleScrapbook\ConsoleScrapbook\Mastermind\enable1.txt");
                
        //    }
        //    catch(FileNotFoundException fnfex)
        //    {
        //        Console.WriteLine(fnfex.ToString());
                
        //    }
        //    finally
        //    {
        //        string[] holder = { "apple","banana","cherry" };
        //        lines = holder;
        //    }

        //    Random rnd = new Random();



        //    Console.WriteLine("Word: " + lines[lines.Length / 2]);
        //    Console.WriteLine("Array Length: " + lines.Length);
        //    Console.ReadLine();
        //}

            
    }
}
