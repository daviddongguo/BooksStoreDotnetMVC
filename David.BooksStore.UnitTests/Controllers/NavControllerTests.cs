using David.BooksStore.Domain.Abstract;
using David.BooksStore.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace David.BooksStore.WebApp.Controllers.Tests
{
    [TestClass()]
    public class NavControllerTests
    {
        [TestMethod()]
        public void MenuTest()
        {
            // Arrange
            // - create the mock repository
            Mock<IProductsRepository> mock = new Mock<IProductsRepository>();
            mock.Setup(m => m.Products).Returns(new Product[]
            {
                new Product {ProductId = 1, Title = "P1", CategoryId = "Apples"},
                new Product {ProductId = 2, Title = "P2", CategoryId = "Apples"},
                new Product {ProductId = 3, Title = "P3", CategoryId = "Plums"},
                new Product {ProductId = 4, Title = "P4", CategoryId = "Oranges"},
            });


            // Arrange - create the controller
            NavController target = new NavController(mock.Object);

            // Act = get the set of categories
            string[] results = ((IEnumerable<string>)target.Menu().Model).ToArray();

            // Assert
            Assert.AreEqual(results.Length, 3);
            Assert.AreEqual(results[0], "Apples");
            Assert.AreEqual(results[1], "Oranges");
            Assert.AreEqual(results[2], "Plums");
        }
    }
}