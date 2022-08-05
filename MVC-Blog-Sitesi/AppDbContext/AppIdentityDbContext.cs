using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_Blog_Sitesi.Entites;
using System;

namespace MVC_Blog_Sitesi.AppDbContext
{
    public class AppIdentityDbContext: IdentityDbContext<AppUser>
    {
        

        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> db) : base(db)
        {
           
        }

        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Article>().Property(x => x.Title).HasMaxLength(100).IsRequired();
            modelbuilder.Entity<Article>().Property(x => x.Content).IsRequired();
            modelbuilder.Entity<AppUser>().Property(a => a.FirstName).HasMaxLength(256).IsRequired();
            modelbuilder.Entity<AppUser>().Property(a => a.LastName).HasMaxLength(256).IsRequired();
          
   
            base.OnModelCreating(modelbuilder); //Bu olmadan null referance exception yedik.





        }
       
    }
    
    
}
