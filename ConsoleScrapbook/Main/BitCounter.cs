using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.Main
{
    class BitCounter
    {
        public int solution(int A, int B)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int bits = 0;
            int bits2 = 0;
            int answer = A * B;

            string binary = Convert.ToString(answer, 2);
            foreach (char c in binary)
            {
                if (c == '1')
                    bits2++;
            }
            
            if ((answer == 0) || (answer == 1))
                return answer;
            int bMax = 1;
            while (answer >= bMax)
            {
                bMax = bMax * 2;
            }
            bMax = bMax / 2;
            while (answer > 0)
            {
                if (bMax <= answer)
                {
                    answer -= bMax;

                    bits++;
                }
                bMax = bMax / 2;
            }

            

            if (bits == bits2)
                return bits;
            else
                return 1;
        }
    }
}
