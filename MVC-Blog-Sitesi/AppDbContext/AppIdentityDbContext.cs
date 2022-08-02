using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_Blog_Sitesi.Entites;

namespace MVC_Blog_Sitesi.AppDbContext
{
    public class AppIdentityDbContext: IdentityDbContext<AppAuthor>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> db) : base(db)
        {

        }

        public DbSet<Article> Articles { get; set; }
    }
    
    
}
