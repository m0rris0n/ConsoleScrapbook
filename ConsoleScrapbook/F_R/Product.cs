using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.F_R
{
    public class Product : IProduct
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        IProductRepository _repository;
        public Product(IProductRepository repository)
        {
            _repository = repository;
            Id = Guid.NewGuid();
        }
        public void Save()
        {
            _repository.Save(this);
        }
    }
}
