using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_Blog_Sitesi.Entites;
using MVC_Blog_Sitesi.Models.ModelMetaData;
using System.Collections;
using System.Collections.Generic;

namespace MVC_Blog_Sitesi.Models
{
    [ModelMetadataType(typeof(UserWithArticleMetaData))]
    public class UserWithArticleVM:IdentityUser
    {
        public UserWithArticleVM()
        {
            Articles=new List<Article>();
            AppUsers=new List<AppUser>();
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public IEnumerable<Article> Articles { get; set; }
        public IEnumerable<AppUser> AppUsers { get; set; }
    }
}
