using David.BooksStore.Domain.Abstract;
using David.BooksStore.Domain.Entities;
using System.Collections.Generic;

namespace David.BooksStore.Domain.Mock
{
    public class MockProductsRepository : IProductsRepository
    {
        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product { Title = "Think in C", Price = 125 },
                    new Product { Title = "Think in Java", Price = 179 },
                    new Product { Title = "Think in C#", Price = 205 }
                };
            }
        }
    }
}
