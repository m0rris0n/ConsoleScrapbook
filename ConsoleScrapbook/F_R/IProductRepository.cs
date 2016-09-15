using System;
using System.Collections.Generic;

namespace ConsoleScrapbook.F_R
{
    public interface IProductRepository
    {
        IEnumerable<IProduct> GetProducts();
        IProduct GetProduct(Guid id);
        void Save(Product product);
    }
}