using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ConsoleScrapbook.Main
//{
//    class LineOverlap
//    {
//        public int solution(int[] a, int[] b)
//        {
//            int maxSize = 0;
//            int n = a.Length;
//            int m = n - 1;
//            int doop = n + 7;
//            List<int> startList;
//            //Constructs and fills a new single 2D array with al lthe data from a and B
//            int[,] bigArray = new int[n, n + 7];
//            for (int i = 0; i < n; i++)
//            {
//                bigArray[i, 0] = a[i];
//                bigArray[i, 1] = b[i];
//                bigArray[i, 2] = 0;
//                bigArray[i, 3] = -1;
//                bigArray[i, 4] = -1;
//                bigArray[i, 5] = -1;
//                bigArray[i, 6] = -1;
//            }
//            //Identifies the first and last nodes as a start and a finish respectively
//            bigArray[0, 3] = 1;
//            startList.Add
//            bigArray[m, 4] = 1;
//            //Determines what nodes each nodes can see
//            for (int i = 0; i < n - 1; i++)
//            {
//                int pointer = 7;
//                int limit = bigArray[m, 1];
//                for (int k = i + 1; k < n; k++)
//                {
//                    if ((bigArray[i, 1] < bigArray[k, 0]) && (bigArray[k, 0] <= limit))
//                    {
//                        if (bigArray[k, 1] < limit)
//                        {
//                            limit = bigArray[k, 1];
//                        }
//                        bigArray[i, 2]++;
//                        bigArray[i, pointer] = k;
//                        pointer++;
//                    }
//                }
//                if (bigArray[i, 2] == 0)
//                    bigArray[i, 4] = 1;
//                if (bigArray[i, 0] <= bigArray[0, 1])
//                    bigArray[1, 3] = 1;
//            }
//            if ((a[i] <= a[j] <= b[i]) || (a[j] <= a[i] <= b[j]))
//                overlap;
//            Console.Out.WriteLine("|A|B|M|S|E|f|b|");
//            for (int i = 0; i < n; i++)
//            {
//                for (int k = 0; k < n + 7; k++)
//                {
//                    Console.Out.Write("|" + bigArray[i, k]);
//                }
//                Console.Out.WriteLine("|");
//            }
//            return maxSize;
//        }
//    }
//}
