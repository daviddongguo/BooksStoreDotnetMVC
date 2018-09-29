using David.BooksStore.Domain.Abstract;
using David.BooksStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace David.BooksStore.WebApp.Controllers
{
    public class AdminController : Controller
    {
        private IProductsRepository repository;
        public AdminController(IProductsRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View(repository.Products);
        }

        public ViewResult Edit(int productId)
        {
            Product product = repository
            .Products
            .FirstOrDefault(p => p.ProductId == productId);
            return View(product);
        }
    }
}