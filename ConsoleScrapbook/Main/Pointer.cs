using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.Main
{
    class Pointer
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int k = 0;
            int i = 0;
            while (k != -1)
            {
                k = A[k];
                i++;
            }
            return i;

        }
    }
}
