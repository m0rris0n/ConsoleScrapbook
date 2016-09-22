using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.HackerRank
{
    class Generics
    {
        void printArray<T>(T[] objectArray)
        {
            foreach (T t in objectArray)
            {
                Console.WriteLine(t);
            }
        }

        void run()
        {
            int[] vInt = new int[] { 1, 2, 3 };
            string[] vString = new string[] { "Hello", "World" };

            printArray<int>(vInt);
            printArray<string>(vString);
        }
    }
}
