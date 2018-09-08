using David.BooksStore.Domain.Abstract;
using David.BooksStore.WebApp.Models;
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

        public int PageSize = 5;

        public ProductController(IProductsRepository repository)
        {
            this.repository = repository;
        }

  
        /// <summary>
        /// Display the the products bye the category 
        /// And use the pagination
        /// </summary>
        /// <param name="categoryId"></param> the name of the categorey
        /// <param name="page"></param> the order of the page
        /// <returns></returns>
        public ActionResult List(string categoryId, int page = 1)
        {
            ProductsListViewModel productsModel = new ProductsListViewModel
            {
                // Filter the products 
                Products = repository
                        .Products
                        .Where(p => categoryId == null || p.CategoryId == categoryId)
                        .OrderBy(p => p.ProductId)
                        .Skip( (page - 1) * PageSize )
                        .Take( PageSize ),

                // 
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    // Get the products remaind
                    TotalItems = repository
                            .Products
                            .Where(p => categoryId == null || p.CategoryId == categoryId)
                            .Count()
                },

                CurrentCategory = categoryId
            };

            return View(productsModel);
        }
    }
}