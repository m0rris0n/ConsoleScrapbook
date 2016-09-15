using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.Main
{
    class WordMash
    {
        string prefix;
        string suffix;
        int maxLength;
        public WordMash(List<string> wordList)
        {
            for (int i = 0; i < wordList.Count; i++)
            {
                for (int j = i; j < wordList.Count; j++)
                {
                    uniqueLetters(wordList.ElementAt(i), wordList.ElementAt(j));
                }
            }
        }

        public bool uniqueLetters(string x, string y)
        {
            for(int i = 0;i<x.Length;i++)
            {
                for(int j = i;j<y.Length;j++)
                {
                    if (x.ElementAt(i) == y.ElementAt(j))
                        return false;
                }
            }
            return true;
        }
    }
}
