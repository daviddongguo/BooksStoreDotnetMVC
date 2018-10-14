using Autofac;
using Autofac.Integration.Mvc;
using David.BooksStore.Domain.Abstract;
using David.BooksStore.Domain.Concrete;
using David.BooksStore.Domain.Entities;
using David.BooksStore.Domain.Mock;
using David.BooksStore.WebApp.Infrastructure.Abstract;
using David.BooksStore.WebApp.Infrastructure.Concrete;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace David.BooksStore.WebApp.App_Start
{
    public class AutofacConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();


            // Create mock data by using MOQ directly

            //Mock<IProductsRepository> mock = new Mock<IProductsRepository>();
            //mock.Setup(m => m.Products).Returns(new List<Product>
            //{
            //    new Product { Title = "Think in X", Price = 25 },
            //    new Product { Title = "Think in Y", Price = 179 },
            //    new Product { Title = "Think in Z", Price = 95 }
            //});
            //builder.RegisterInstance<IProductsRepository>(mock.Object);

            // Register all controllers. 
            builder.RegisterControllers(AppDomain.CurrentDomain.GetAssemblies());

            // Use the mock data
            builder.RegisterInstance<IProductsRepository>(new EFProductRepository()).PropertiesAutowired();

            builder.RegisterInstance<IOrderProcessor>(new EmailOrderProcessor(new EmailSettings()));

            builder.RegisterInstance<IAuthProvider>(new FormsAuthProvider()).PropertiesAutowired();

            builder.RegisterType<EFDbContext>();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
        
    }
}