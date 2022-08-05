using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_Blog_Sitesi.Models.ModelMetaData;

namespace MVC_Blog_Sitesi.Models
{
    [ModelMetadataType(typeof(UserMetaData))]
    public class UserVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public string Password { get; set; }
    }
}
