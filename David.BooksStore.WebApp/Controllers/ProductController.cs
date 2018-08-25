using David.BooksStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace David.BooksStore.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository repository;

        public ProductController(IProductsRepository repository)
        {
            this.repository = repository;
        }

        // Display all the products in the collection.
        public ActionResult List()
        {
            return View(repository.Products);
        }
    }
}