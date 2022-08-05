using System.ComponentModel.DataAnnotations;

namespace MVC_Blog_Sitesi.Models.ModelMetaData
{
    public class LoginMetaData
    {
        [Required]
        public string Email{ get; set; }
        [Required]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}

