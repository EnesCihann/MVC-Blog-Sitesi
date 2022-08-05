using System.ComponentModel.DataAnnotations;

namespace MVC_Blog_Sitesi.Models.ModelMetaData
{
    public class UserMetaData
    {
        [Required(ErrorMessage = "İsim girişi zorunludur.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soy İsim girişi zorunludur.")]
        public string LastName { get; set; }
        public string Image { get; set; }
        [MinLength(20, ErrorMessage = "İçerik uzunluğu en az 20 karakter olmalıdır.")]
        public string Description { get; set; }
    }
}
