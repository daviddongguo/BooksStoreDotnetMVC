using David.BooksStore.Domain.Abstract;
using David.BooksStore.Domain.Entities;
using David.BooksStore.WebApp.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;

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
            mock.Setup(m => m.Products).Returns
                (
                    new Product[] 
                    {
                        new Product {ProductId = 1, CategoryId = "1", Title = "P1"},
                        new Product {ProductId = 2, CategoryId = "1", Title = "P2"},
                        new Product {ProductId = 3, CategoryId = "1", Title = "P3"},
                        new Product {ProductId = 4, CategoryId = "1", Title = "P4"},
                        new Product {ProductId = 5, CategoryId = "1", Title = "P5"}
                     }
                );
            ProductController controller = new ProductController(mock.Object);
            controller.PageSize = 3;
            // Act 
            //             // Arrange - create the controller
            // NavController target = new NavController(mock.Object);

            // Act = get the set of categories
            // string[] results = ((IEnumerable<string>)target.Menu().Model).ToArray();


            // var result = (ProductsListViewModel)controller.List("", 2).Model;
            // string[] results = ((IEnumerable<string>)target.Menu().Model).ToArray();

            // Product[] prodArray = ((ProductsListViewModel)(controller.List("1", 2)).Model).Products.ToArray();
            // Assert
            // Product[] prodArray = result.Products.ToArray();

            // Assert.IsTrue(prodArray.Length == 2);
            // Assert.AreEqual(prodArray[0].Title, "P4");
            // Assert.AreEqual(prodArray[1].Title, "P5");
        }
    }
}