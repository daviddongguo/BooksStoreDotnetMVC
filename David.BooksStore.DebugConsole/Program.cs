using David.BooksStore.Domain.Abstract;
using David.BooksStore.Domain.Entities;
using David.BooksStore.WebApp.Controllers;
using David.BooksStore.WebApp.Controllers;
using Moq;
using System;
using System.Linq;
using System.Web.Mvc;

namespace David.BooksStore.DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var ctx = new EFDbContext())
            //{
            //    for ( int i = 1; i < 50; i++)
            //    {
            //        var product = new Product()
            //        { Title = "Think in " + i,
            //            Author = "J",
            //            Price = 100 + i,
            //            CategoryId = (i % 4).ToString(),
            //            Description = " " + i + " Great!"
            //        };

            //        ctx.Products.Add(product);
            //        ctx.SaveChanges();
            //    }
            //}

            // Arrange - create a mock order processor
            Mock<IOrderProcessor> mock = new Mock<IOrderProcessor>();
            // Arrange - create a cart with an item
            Cart cart = new Cart();
            // Arrange - create an instance of the controller
            CartController target = new CartController(null, mock.Object);

            // Act - try to checkout
            //ViewResult result = target.Checkout(cart, new ShippingDetails());
            ViewResult result = target.Completed();

            Console.WriteLine("\n\n************************CompletedTest***************************\n\n");
            Console.WriteLine(result.ViewName);
            Console.WriteLine(result.MasterName);
            Console.WriteLine(result.ToString());
            Console.WriteLine(result.Model);
            Console.WriteLine(result.ViewData);
            Console.WriteLine(result.View);
            Console.WriteLine("\n\n*************************CompletedTest**************************\n\n");

            Console.ReadKey();

        }
    }
}
