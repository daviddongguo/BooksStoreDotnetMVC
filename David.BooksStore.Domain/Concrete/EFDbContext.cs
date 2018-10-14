using David.BooksStore.Domain.Entities;
using System.Data.Entity;

namespace David.BooksStore.Domain.Concrete
{
    /// <summary>
    /// Using entity framework.
    /// </summary>
    public class EFDbContext : DbContext 
    {
        // Declare a list
        public DbSet<Product> Products { get; set; }


        public DbSet<User> Users { get; set; }

    }
}
