using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.Scrap
{
    class RefExample
    {
        public void MethodR(ref int i)
        {
            i++;
        }

        //public string MethodO(out int i)
        //{
        //    i = i;
        //    string foo = ("this string yo and the number " + i);
        //    return foo;
        //}

        public int Main()
        {
            int val = 1;
            MethodR(ref val);
            //MethodO(out val);


            Console.WriteLine(val);
            Console.ReadLine();
            return val;
        }

    }

    class OutExample
    {
        public void SplitPath(string path, out string dir, out string name)
        {
            int i = path.Length;
            while (i > 0)
            {
                char ch = path[i - 1];
                if (ch == '\\' || ch == '/' || ch == ':') break;
                i--;
            }
            dir = path.Substring(0, i);
            name = path.Substring(i);
        }
        public void Main()
        {
            string dir, name;
            SplitPath("c:\\Windows\\System\\hello.txt", out dir, out name);
            Console.WriteLine(dir);
            Console.WriteLine(name);
        }
    }



}
