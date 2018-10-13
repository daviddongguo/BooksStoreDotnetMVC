using David.BooksStore.Domain.Entities;
using System.Collections.Generic;

namespace David.BooksStore.Domain.Abstract
{
    /// <summary>
    /// Create an abstract repository 
    /// </summary>
    public interface IProductsRepository
    {
        // Declare a collection class that can be used with the foreach statement. .
        IEnumerable<Product> Products { get; }

        void SaveProduct(Product product);  // Add a new product or update an older product

        Product DeleteProduct(int productId);
    }
}
