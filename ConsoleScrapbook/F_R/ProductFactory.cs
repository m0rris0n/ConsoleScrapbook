using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.F_R
{
    public class ProductFactory : IProductFactory
    {
        IProductRepository _repository;
        public ProductFactory(IProductRepository repository)
        {
            _repository = repository;
        }

        public Product GetProduct(Guid id)
        {
            IProduct product = _repository.GetProduct(id);
            return MapToDomain(product);
        }

        public IEnumerable<Product> GetProducts()
        {
            IEnumerable<IProduct> products = _repository.GetProducts();
            return MapToDomain(products);
        }
        
        IEnumerable<Product> MapToDomain(IEnumerable<IProduct> products)
        {
            return products.ToList().Select(x => MapToDomain(x));
        }

        Product MapToDomain(IProduct product)
        {
            if (product == null) return null;
            return new Product(_repository)
            {
                Description = product.Description,
                Id = product.Id,
                Name = product.Name,
                Price = product.Price
            };
        }

    }
}
