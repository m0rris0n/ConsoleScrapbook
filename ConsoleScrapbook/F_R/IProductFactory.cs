using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.F_R
{
    public interface IProductFactory
    {
        Product GetProduct(Guid id);
        IEnumerable<Product> GetProducts();
    }
}
