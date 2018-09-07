
using David.BooksStore.Domain.Abstract;
using David.BooksStore.Domain.Entities;
using David.BooksStore.WebApp.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace David.BooksStore.WebApp.Controllers.Tests
{
    [TestClass()]
    public class ProductControllerTests
    {
        [TestMethod()]
        public void ListTest()
        {
            // Arrange
            Mock<IProductsRepository> mock = new Mock<IProductsRepository>();
            mock.Setup(m => m.Products).Returns(new Product[]
            {
                new Product {ProductId = 1, Title = "P1", CategoryId = "Apples"},
                new Product {ProductId = 2, Title = "P2", CategoryId = "Apples"},
                new Product {ProductId = 3, Title = "P3", CategoryId = "Plums"},
                new Product {ProductId = 4, Title = "P4", CategoryId = "Oranges"},
            });
            // Arrange
            ProductController controller = new ProductController(mock.Object);

            controller.PageSize = 3;
            // Act
            // ProductsListViewModel result = (ProductsListViewModel)controller.List("Apples", 2).Model;
            // Assert
            //PagingInfo pageInfo = result.PagingInfo;
            //Assert.AreEqual(pageInfo.CurrentPage, 2);
            //Assert.AreEqual(pageInfo.ItemsPerPage, 3);
            //Assert.AreEqual(pageInfo.TotalItems, 5);
            //Assert.AreEqual(pageInfo.TotalPages, 2);
        }
    }
}