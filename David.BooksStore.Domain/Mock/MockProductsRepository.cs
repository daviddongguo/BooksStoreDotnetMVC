using David.BooksStore.Domain.Abstract;
using David.BooksStore.Domain.Entities;
using System.Collections.Generic;

namespace David.BooksStore.Domain.Mock
{
    /// <summary>
    /// Make a Mock Repository. 
    /// </summary>
    public class MockProductsRepository : IProductsRepository
    {
        // Create the simulated objects that mimic the behavior of real object.
        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product {Title = "Think in c", Price = 105},
                    new Product {Title = "Think in J", Price = 125}
                };
            }
        }

        public Product DeleteProduct(int productId)
        {
            return new Product();
        }

        public void SaveProduct(Product product)
        {
        }
    }
}
