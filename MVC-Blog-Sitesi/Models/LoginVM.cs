using Microsoft.AspNetCore.Mvc;
using MVC_Blog_Sitesi.Models.ModelMetaData;

namespace MVC_Blog_Sitesi.Models
{
    [ModelMetadataType(typeof(LoginMetaData))]
    public class LoginVM
    {
        public string Email{ get; set; }
        
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
