using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.Main
{
    class Transpose
    {
        List<string> strings;
        List<string> tStrings;
        int max;
        public Transpose()
        {
            strings = new List<string>();
            tStrings = new List<string>();
            max = 0;
        }

        public void addString(string s)
        {
            strings.Add(s);
            Console.WriteLine(s.Length);
            if (s.Length > max)
                max = s.Length;
        }

        public void transpose()
        {
            string dump;
            for(int i = 0; i < max; i++)
            {
                dump = "";
                foreach(string s in strings)
                {
                    if (i < s.Length)
                    {
                        dump = dump + s.ElementAt(i) + " ";
                    }
                    else
                        dump = dump + "  ";
                }
                string hold = dump;
                tStrings.Add(hold);
            }
            foreach (string t in tStrings)
                Console.Out.WriteLine(t);
        }

    }
}
