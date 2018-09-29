using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace David.BooksStore.Domain.Entities
{
    public class Product
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public long ProductId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public string CategoryId { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
    }
}
