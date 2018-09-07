using David.BooksStore.Domain.Concrete;
using David.BooksStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David.BooksStore.DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new EFDbContext())
            {
                for ( int i = 1; i < 50; i++)
                {
                    var product = new Product()
                    { Title = "Think in " + i,
                        Author = "J",
                        Price = 100 + i,
                        CategoryId = (i % 4).ToString(),
                        Description = " " + i + " Great!"
                    };

                    ctx.Products.Add(product);
                    ctx.SaveChanges();

                }

            }

        }
    }
}
