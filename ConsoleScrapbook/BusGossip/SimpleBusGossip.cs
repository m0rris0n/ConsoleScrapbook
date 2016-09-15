using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.BusGossip
{
    class SimpleBusGossip
    {
        public void exchange(List<int> a, List<int> b)
        {
            int i=0;
            int j = 0;
            List<int> x = new List<int>();
            List<int> y = new List<int>();
            while (i<a.Count && j<b.Count)
            {
                if (a[i] < b[j])
                {
                    y.Add(a[i]);
                    i++;
                }
                else if (a[i] > b[j])
                {
                    x.Add(b[j]);
                    j++;
                }
                else
                {
                    i++;
                    j++;
                }
                

            }
        }
    }
}
