using Microsoft.AspNetCore.Identity;
using MVC_Blog_Sitesi.Entites;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MVC_Blog_Sitesi.Repository
{
    public interface IArticleRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetByID(int id);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);

        IEnumerable<T> GetWhere(Expression<Func<T, bool>> Predicate); 
        T SingleOrDefault(Expression<Func<T, bool>> Predicate);
        IEnumerable<AppAuthor> GetAllIncludeAuthors();

        AppAuthor GetByIdIncludeAuthors(string id);
    }
}
