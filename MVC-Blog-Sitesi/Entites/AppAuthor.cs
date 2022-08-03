using Microsoft.AspNetCore.Identity;
using System;
using System.Collections;
using System.Collections.Generic;

namespace MVC_Blog_Sitesi.Entites
{
    public class AppAuthor:IdentityUser
    {
        public AppAuthor()
        {
            Articles = new HashSet<Article>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Image { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
        public string Description { get; set; }

        public  ICollection<Article> Articles { get; set; }
        
    }
}
