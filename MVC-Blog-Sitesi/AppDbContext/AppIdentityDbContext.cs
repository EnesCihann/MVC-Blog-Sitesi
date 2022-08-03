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

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Article>().Property(x => x.Title).HasMaxLength(100).IsRequired();
            modelbuilder.Entity<Article>().Property(x => x.Content).IsRequired();
            modelbuilder.Entity<Article>().Property(a => a.Image).HasColumnType("image");
            modelbuilder.Entity<AppAuthor>().Property(a => a.Image).HasColumnType("image");
            modelbuilder.Entity<AppAuthor>().Property(a => a.FirstName).HasMaxLength(256).IsRequired();
            modelbuilder.Entity<AppAuthor>().Property(a => a.LastName).HasMaxLength(256).IsRequired();
            modelbuilder.Entity<AppAuthor>().Property(a => a.Description).IsRequired();
            modelbuilder.Entity<AppAuthor>().Property(a => a.Image).HasColumnType("image");
            

            base.OnModelCreating(modelbuilder); //Bu olmadan null referance exception yedik.





        }
    }
    
    
}
