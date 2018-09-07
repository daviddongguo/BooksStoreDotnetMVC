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
                    //new Product { Title = "Think in C", Author = "Mic", Price = 125, CategoryId =1, Description = "A good book" },
                    //new Product { Title = "Think in Java", Author = "J", Price = 179, CategoryId =2, Description = "Great"  },
                    //new Product { Title = "Think in C#",  Author = "Mic",Price = 205, CategoryId =1, Description = "Not bad expect the price"  }
                };
            }
        }
    }
}
