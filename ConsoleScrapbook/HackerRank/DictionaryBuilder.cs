using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.HackerRank
{
    class PhoneBook
    {
        public void Bookem()
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            List<string> queries = new List<string>();
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string entry = Console.ReadLine();
                string[] hold = entry.Split(' ');
                phoneBook.Add(hold[0], hold[1]);
            }
            for (int i = 0; i < n; i++)
            {
                queries.Add(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                string report;
                if (phoneBook.TryGetValue(queries[i], out report))
                    Console.WriteLine(queries[i] + '=' + report);
                else
                    Console.WriteLine("Not found");
            }
        }
    }
}
