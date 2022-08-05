using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Blog_Sitesi.Models.ModelMetaData;

namespace MVC_Blog_Sitesi.Models
{
    [ModelMetadataType(typeof(ArticleMetaData))]
    public class ArticleVM
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public IFormFile Image { get; set; }
    }
}
