using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.HackerRank
{
    public class DoubleString
    {
        public void run()
        {
            int totalCases = Convert.ToInt32(Console.ReadLine());
            List<string> testCases = new List<string>();

            for (int i = 0; i < totalCases; i++)
            {
                testCases.Add(Console.ReadLine());
            }

            foreach (string s in testCases)
            {
                StringBuilder oddSb = new StringBuilder();
                StringBuilder evenSb = new StringBuilder();
                for (int j = 0; j < s.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        evenSb.Append(s[j]);
                    }
                    else
                    {
                        oddSb.Append(s[j]);
                    }
                }
                Console.WriteLine(evenSb.ToString() + " " + oddSb.ToString());
            }
        }
    }
}
