using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.Main
{
    class Permutation
    {
        
        public int solution(int[] A)
        {
            int result = 1;
            for (int i = 1; i<(A.Length+1);i++)
            {
                for (int k = 0;k<A.Length;k++)
                {
                    if (A[k]>A.Length)
                    {
                        result = 0;
                        break;

                    }
                    else if (i == A[k])
                    {
                        break;
                    }
                    else if (k == (A.Length - 1))
                    {
                        result = 0;
                    }
                }
                if(result == 0)
                {
                    break;
                }
            }

            return result;
        }
    }
}
