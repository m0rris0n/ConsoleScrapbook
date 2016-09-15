using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.Main
{
    /*
    class LeaderSorted
    {
        public int solution(int[] A)
        {
            int n = A.Length;

            int[] L = new int[n + 1];

            L[0] = -1;

            for (int i = 0; i < n; i++)
            {
                L[i + 1] = A[i];
            }

//             int count = 0; -1

            int maj = (n + 1)/2;

            int candidate = L[0];
     
            for (int k = 1; k < n+1; k++) //1
            {
                int count = 0; //2
                candidate = L[k]; //3
                if (L[k] != L[k-1]) //4
                {
//                    for (int i = k; i < n; i++) -2
                    int i = k; //5
                    while ((i<L.Length)&&(L[i++] == L[k]))
                    {
                        if (L[i-1] == candidate)
                            count = count + 1;
                    }
                    if ((count > L[0]) && (count >= maj)) //6
                        L[0] = candidate; //7
                }
            }

//            if (count > pos) -3
 //               return candidate; -4

            return (L[0]);
        }
    }
     * */
    class LeaderSorted
    {
        public int solution(int[] A)
        {
            int n = A.Length;
            int[] L = new int[n + 1];
            L[0] = -1;

            for (int i = 0; i < n; i++)
            {
                L[i + 1] = A[i];
            }

            int count = 0;
            int pos = (n + 1) / 2;
            int candidate = L[pos];

            for (int i = 1; i <= n; i++)
            {
                if (L[i] == candidate)
                    count = count + 1;
            }

            if (2 * count > pos) //fix is "2 * "
                return candidate;

            return (-1);
        }
    }
    

}
            /* LEADER CHECKER INPUTS
            int[] pD = { 1, 2, 2, 2, 2, 2, 3, 4, 4, 6 };
            int[] pB = { 1, 1, 1, 1, 50 };
            int[] fB = { 0, 0, 0, 0, 0, 0, 0, 0 };
             * */