using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.Main
{
    class NoStrings
    {
        public string solution (string text, string subtext)
        {
            int tCount = 0;
            string locations = null;
            List<int> resultsList = new List<int>();

            foreach(char c in text)
            {
                tCount++;
            }
            int[] tCode = new int[tCount];
            tCount = 0;
            foreach (char c in text)
            {
                tCode[tCount] = c;
                if (tCode[tCount] > 90)
                    tCode[tCount] = tCode[tCount] - 32;
                tCount++;
            }

            int sCount = 0;
            foreach (char c in subtext)
            {
                sCount++;
            }
            int[] sCode = new int[sCount];
            sCount = 0;
            foreach (char c in subtext)
            {
                sCode[sCount] = c;
                if (sCode[sCount] > 90)
                    sCode[sCount] = sCode[sCount] - 32;
                sCount++;
            }

            /*
            for (int i = 0; i < tCount; i++)
            {
                Console.Out.Write(tCode[i] + "|");
            }
            Console.Out.WriteLine();
            for(int i=0;i<sCount;i++)
            {
                Console.Out.Write(sCode[i]+"|");
            }
             */ 
            
            int limit = tCode.Length - sCode.Length +1;
            for (int i=0;i<limit;i++)
            {
                for(int j=0;j<sCode.Length;j++)
                {
                    if (sCode[j] == tCode[i + j]) 
                    {
                        if (j == sCode.Length - 1)
                        {
                            resultsList.Add(i+1);
                        }
                            //add to string count thing
                    }
                    else
                    {
                        break;
                    }
                }
             }

            if (resultsList.Any())
            {
                locations = "" + resultsList[0];
                if (resultsList.Count() > 1)
                    for (int i = 1; i < resultsList.Count(); i++)
                        locations += "," + resultsList[i];
            }
            else
                locations = "There is no output";
             
            return locations;
        }
    }
}
