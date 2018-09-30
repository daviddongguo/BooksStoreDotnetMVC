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

        [Required(ErrorMessage = "Please enter a product name")]
        public string Title { get; set; }
        public string Author { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive price")]
        public decimal Price { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please specify a category")]
        public string CategoryId { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter a description")]    
        public string Description { get; set; }
    }
}
