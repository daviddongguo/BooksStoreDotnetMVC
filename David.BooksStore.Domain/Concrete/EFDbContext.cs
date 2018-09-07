using David.BooksStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David.BooksStore.Domain.Concrete
{
    /// <summary>
    /// Using entity framework.
    /// </summary>
    public class EFDbContext : DbContext 
    {
        // Declare a list
        public DbSet<Product> Products { get; set; }


    }
}
