using David.BooksStore.Domain.Abstract;
using David.BooksStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David.BooksStore.Domain.Mock
{
    class MockProductsRepository : IProductsRepository
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
