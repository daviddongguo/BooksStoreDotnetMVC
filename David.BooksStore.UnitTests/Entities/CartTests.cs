using Microsoft.VisualStudio.TestTools.UnitTesting;
using David.BooksStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David.BooksStore.Domain.Entities.Tests
{
    [TestClass()]
    public class CartTests
    {
        [TestMethod()]
        public void AddItemTest()
        {
            // Arrange - create some test products
            Product p1 = new Product { ProductId = 1, Title = "P1" };
            Product p2 = new Product { ProductId = 2, Title = "P2" };
            // Arrange - create a new cart
            Cart target = new Cart();
            // Act
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            CartLine[] results = target.Lines.ToArray();
            // Assert
            Assert.AreEqual(results.Length, 2);
            Assert.AreEqual(results[0].Product, p1);
            Assert.AreEqual(results[1].Product, p2);
        }

        [TestMethod()]
        public void RemoveLineTest()
        {
            // Arrange - create some test products
            Product p1 = new Product { ProductId = 1, Title = "P1" };
            Product p2 = new Product { ProductId = 2, Title = "P2" };
            Product p3 = new Product { ProductId = 3, Title = "P3" };
            // Arrange - create a new cart
            Cart target = new Cart();
            // Arrange - add some products to the cart
            target.AddItem(p1, 1);
            target.AddItem(p2, 3);
            target.AddItem(p3, 5);
            target.AddItem(p2, 1);
            // Act
            target.RemoveLine(p2);
            // Assert
            Assert.AreEqual(target.Lines.Where(c => c.Product == p2).Count(), 0);
            Assert.AreEqual(target.Lines.Count(), 2);
        }

        [TestMethod()]
        public void ComputeTotalValueTest()
        {
            // Arrange - create some test products
            Product p1 = new Product { ProductId = 1, Title = "P1", Price = 100M };
            Product p2 = new Product { ProductId = 2, Title = "P2", Price = 50M };
            // Arrange - create a new cart
            Cart target = new Cart();
            // Act
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            target.AddItem(p1, 3);
            decimal result = target.ComputeTotalValue();
            // Assert
            Assert.AreEqual(result, 450M); 
        }

        [TestMethod()]
        public void ClearTest()
        {
            // Arrange - create some test products
            Product p1 = new Product { ProductId = 1, Title = "P1", Price = 100M };
            Product p2 = new Product { ProductId = 2, Title = "P2", Price = 50M };
            // Arrange - create a new cart
            Cart target = new Cart();
            // Arrange - add some items
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            // Act - reset the cart
            target.Clear();
            // Assert
            Assert.AreEqual(target.Lines.Count(), 0);
        }
    }
}