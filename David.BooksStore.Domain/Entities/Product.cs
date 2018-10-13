using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace David.BooksStore.Domain.Entities
{
    public class Product
    {
        [Key]
        [HiddenInput(DisplayValue = false)]   // render the property as a hidden form element        
        public long ProductId { get; set; }

        private string _title;
        [Required(ErrorMessage = "Please enter a product name")]
        public string Title
        {
            get; set;
            //get
            //{
            //    return _title;
            //}
            //set
            //{
            //    if (String.IsNullOrWhiteSpace(value) || value.Length < 5)
            //    {
            //        throw new InvalidDataException("Title has not a correct value.");
            //    }
            //    _title = value;
            //}
        }


        public string Author { get; set; }

        [Required]
        [Range(0.01, 300.00, ErrorMessage = "Please enter a positive price")]
        public decimal Price { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please specify a category")]
        public string CategoryId { get; set; }

        [DataType(DataType.MultilineText)] // specify how a value is presented and edited
        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }
    }
}
