using Microsoft.EntityFrameworkCore;
using MVC_Blog_Sitesi.AppDbContext;
using MVC_Blog_Sitesi.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVC_Blog_Sitesi.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly AppIdentityDbContext db;

        public ArticleRepository(AppIdentityDbContext db) 
        {
            this.db = db;
        }
        IEnumerable<AppAuthor> IArticleRepository.GetAllIncludeAuthors()
        {
            return db.Users.Include(a => a.Articles);
        }

       

        public async Task<AppAuthor> GetByIdIncludeAuthors(string id)
        {
            return db.Users.Include(a=>a.Articles).FirstOrDefaultAsync(a => a.Id==id);
        }

        
    }
}
