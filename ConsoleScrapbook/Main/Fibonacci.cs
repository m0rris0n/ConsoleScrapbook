using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.Main
{
    class Fibonacci
    {
        public int j;
        public int k;
        public int f;
        public int solution(int n)
        {
            j = 0;
            k = 1;
            for (int i =0; i< n;i++)
            {
                f = j + k;
                k = j;
                j = f;
            }
            return f;
        }
    }
#region javascript
    /*
    var myself = {
    fibonacci : function(n) {
        var f = 0;
        var j = 0;
        var k = 1;
        if ((n == 0)||(n == 1)) {
            return n;
        }
        else {
			for (i =0; i < n;i++)
            {
                f = j + k;
                k = j;
                j = f;
            }
            return  f;
        }
    }
    

};*/
#endregion


}
