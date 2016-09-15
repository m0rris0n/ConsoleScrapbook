using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.Exceptions
{
    class FnfException : Exception
    {
        public FnfException()
            :base()
        {

        }

        public FnfException(string message) 
            : base(message)
        {

        }

        public FnfException(string message, Exception innerException) 
            : base(message, innerException)
        {
            
        }

    }
}
