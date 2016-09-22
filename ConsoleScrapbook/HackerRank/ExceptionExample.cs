using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.HackerRank
{
    class ExceptionExample
    {
        public ExceptionExample()
        {
            string S = Console.ReadLine();
            int n;

            try
            {
                n = Convert.ToInt32(S);
                Console.WriteLine(n);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bad String");
            }
        }

        public void throwExample()
        {
            Calculator myCalculator = new Calculator();
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }
        }
    }

    class Calculator
    {
        public int power(int n, int p)
        {
            if (n < 0 || p < 0)
                throw new Exception("n and p should be non-negative");
            else
            {
                var result = Math.Pow(n, p);
                return Convert.ToInt32(result);
            }
        }
    }

}
