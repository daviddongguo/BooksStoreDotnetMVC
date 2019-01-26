using David.BooksStore.Domain.Abstract;
using David.BooksStore.Domain.Concrete;
using David.BooksStore.Domain.Entities;
using David.BooksStore.WebApp.Controllers;
using Moq;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web.Mvc;

namespace David.BooksStore.DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            // DisplayPorduct();
            Console.WriteLine(HashMD5("pwd"));

            Console.ReadKey();

        }


        public static string HashMD5(string text)
        {
            var source = Encoding.UTF8.GetBytes(text);

            using (MD5 hasher = MD5.Create())
            {
                var result = hasher.ComputeHash(source);

                return Convert.ToBase64String(result);
            }
        }

        private static void DisplayPorduct()
        {
            using (var ctx = new EFDbContext())
            {
                foreach (var item in ctx.Products)
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void PopulateDate()
        {
            using (var ctx = new EFDbContext())
            {
                for (int i = 1; i < 50; i++)
                {
                    var product = new Product()
                    {
                        Title = "Think in " + i,
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
