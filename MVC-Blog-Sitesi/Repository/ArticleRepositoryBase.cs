using Microsoft.EntityFrameworkCore;
using MVC_Blog_Sitesi.Entites;
using System.Threading.Tasks;

namespace MVC_Blog_Sitesi.Repository
{
    public class ArticleRepositoryBase
    {



        public async Task<Article> GetByIdIncludeAuthors(string id)
        {
            AppAuthor appAuthor = await db.Users.Include(a => a.Articles).FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}