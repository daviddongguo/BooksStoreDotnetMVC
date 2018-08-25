using David.BooksStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David.BooksStore.Domain.Concrete
{
    public class EFDbContext : DbContext 
    {
        public DbSet<Product> Products { get; set; }

        public EFDbContext()
        {
            using (var ctx = new EFDbContext())
            {
                var product = new Product() { };

                ctx.Products.Add(product);
                ctx.SaveChanges();
            }

        }
    }
}
