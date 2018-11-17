using System.ComponentModel.DataAnnotations;

namespace David.BooksStore.WebApp.Areas.Admin.Models
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}