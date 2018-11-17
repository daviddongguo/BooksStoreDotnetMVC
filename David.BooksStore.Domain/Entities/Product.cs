﻿using System;
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


        [Required]
        [StringLength(150, ErrorMessage = "Please enter a title of book")]
        public string Title { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Please enter the author of book")]
        public string Author { get; set; }

        [Required]
        [Range(0.01, 300.00, ErrorMessage = "Please enter a positive price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please specify a category")]
        public string CategoryId { get; set; }

        [DataType(DataType.MultilineText)] // specify how a value is presented and edited
        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }

        public byte[] ImageData { get; set; }

        public string ImageMimeType { get; set; }
    }
}
