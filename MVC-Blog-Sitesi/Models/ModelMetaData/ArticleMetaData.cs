using System.ComponentModel.DataAnnotations;

namespace MVC_Blog_Sitesi.Models.ModelMetaData
{
    public class ArticleMetaData
    {
        [Required(ErrorMessage = "Başlık girişi zorunludur.")]
        [StringLength(100, ErrorMessage = "İsim uzunluğu en fazla 100 karakter olmalıdır.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Başlık girişi zorunludur.")]
        [MinLength(50, ErrorMessage = "İçerik uzunluğu en az 50 karakter olmalıdır.")]
        public string Content { get; set; }
        public string Image { get; set; }
    }
}
