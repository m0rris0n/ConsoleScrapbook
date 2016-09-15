using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.F_R
{
    public interface IProduct
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        double Price { get; set; }
    }

}
