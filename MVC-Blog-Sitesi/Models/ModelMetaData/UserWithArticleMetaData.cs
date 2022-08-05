using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MVC_Blog_Sitesi.Models.ModelMetaData
{
    public class UserWithArticleMetaData
    {
        [Required(ErrorMessage = "Başlık girişi zorunludur.")]
        [StringLength(100, ErrorMessage = "İsim uzunluğu en fazla 100 karakter olmalıdır.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Başlık girişi zorunludur.")]
        [MinLength(50, ErrorMessage = "İçerik uzunluğu en az 50 karakter olmalıdır.")]
        public string Content { get; set; }

        [Required(ErrorMessage = "İsim girişi zorunludur.")]
       
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soy İsim girişi zorunludur.")]
        
        public string LastName { get; set; }
        public string Image { get; set; }
        [MinLength(20, ErrorMessage = "İçerik uzunluğu en az 20 karakter olmalıdır.")]
        public string Description { get; set; }
    }
}
