using System.Collections.Generic;
using System.Linq;


namespace ConsoleScrapbook.Main
{
    class Chains
    {
        public int solution(int[] mainChain)
        {
            if (mainChain.Length == 5)
                return mainChain[1] + mainChain[3];

            var list = new List<int>(mainChain);
            
            list.RemoveAt(mainChain.Length - 1);
            list.RemoveAt(0);
            
            list.Sort();
            if (list.ElementAt(1) == list.ElementAt(3))
                return list.ElementAt(0) + list.ElementAt(3);

            mainChain[0] = -1;
            mainChain[mainChain.Length - 1] = -1;
            int P = list.ElementAt(0);

            if ((mainChain[1] == list.ElementAt(0)) && (mainChain[2] == list.ElementAt(1))/**/||/**/(mainChain[mainChain.Length - 1] == list.ElementAt(0)) && (mainChain[mainChain.Length - 2] == list.ElementAt(1)))
                return list.ElementAt(0) + list.ElementAt(2);
            

            for (int i = 1; i < (mainChain.Length - 1); i++)
            {
                if (mainChain[i] == P)
                    if ((mainChain[i - 1] == list.ElementAt(1)) || (mainChain[i + 1] == list.ElementAt(1)))
                    {
                        if ((mainChain[i - 1] == list.ElementAt(1)) && (mainChain[i + 1] == list.ElementAt(2)))
                        {
                            if (list.ElementAt(1) + list.ElementAt(2) < list.ElementAt(0) + list.ElementAt(4))
                                return list.ElementAt(1) + list.ElementAt(2);
                            else
                                return list.ElementAt(0) + list.ElementAt(4);
                        }
                        else if ((mainChain[i - 1] == list.ElementAt(2)) && (mainChain[i + 1] == list.ElementAt(1)))
                        {
                            if (list.ElementAt(1) + list.ElementAt(2) < list.ElementAt(0) + list.ElementAt(4))
                                return list.ElementAt(1) + list.ElementAt(2);
                            else
                                return list.ElementAt(0) + list.ElementAt(4);
                        }
                        else
                        {
                            return list.ElementAt(0) + list.ElementAt(2);
                        }
                    }
                   
            }

            return list.ElementAt(0) + list.ElementAt(1);
        }
    }
}
