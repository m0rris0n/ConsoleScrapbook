using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.Main
{
    public static class GameOfThrees
    {
        public static void gimmieThree(this int input)
        {
            Console.Write(input);
            while(input > 1)
            {
                int remainder = input % 3;
                switch (remainder)
                {
                    case 0:
                        input = input / 3;
                        Console.Write(" 0 \n" + input );
                        break;
                    case 1:
                        input = (input -1) / 3;
                        Console.Write(" -1 \n" + input);
                        break;
                    case 2:
                        input = (input + 1) / 3;
                        Console.Write(" +1 \n" + input);
                        break;
                    default:
                        Console.Write("Somthing's gone wrong...");
                        break;
                 }

            }
            
        }
    }
}
