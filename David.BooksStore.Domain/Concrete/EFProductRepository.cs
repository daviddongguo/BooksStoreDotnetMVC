using David.BooksStore.Domain.Abstract;
using David.BooksStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David.BooksStore.Domain.Concrete
{
    public class EFProductRepository : IProductsRepository
    {
        // Link to the database by using the entity framework
        //public class EFDbContext : DbContext
        //{
        //    // Declare a list
        //    public DbSet<Product> Products { get; set; }
        //}

        private EFDbContext context = new EFDbContext();

        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }

        public Product DeleteProduct(int productId)
        {
            // find an entity with the primary key value
            Product dbEntry = context.Products.Find(productId);   
            if ( dbEntry != null)
            {
                context.Products.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public void SaveProduct(Product product)
        {
            if (product.ProductId == 0)  // a new product
            {
                context.Products.Add(product);
            }
            else                   // an old product whose productId is exists
            {
                Product dbEntry = context.Products.Find(product.ProductId);
                if (dbEntry != null)  // entity found
                {
                    dbEntry.Title = product.Title;
                    dbEntry.Description = product.Description;
                    dbEntry.Author = product.Author;
                    dbEntry.Price = product.Price;
                    dbEntry.CategoryId = product.CategoryId;
                    dbEntry.ImageData = product.ImageData;
                    dbEntry.ImageMimeType = product.ImageMimeType;

                }
            }
            context.SaveChanges();
        }
    }
}
