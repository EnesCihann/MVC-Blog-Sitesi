using Microsoft.AspNetCore.Identity;
using MVC_Blog_Sitesi.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVC_Blog_Sitesi.Repository
{
    public interface IArticleRepository
     {
        IEnumerable<AppAuthor> GetAllIncludeAuthors();

        Task<Article> GetByIdIncludeAuthors(string id);
    }
}
