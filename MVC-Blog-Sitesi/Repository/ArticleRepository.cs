using Microsoft.EntityFrameworkCore;
using MVC_Blog_Sitesi.AppDbContext;
using MVC_Blog_Sitesi.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MVC_Blog_Sitesi.Repository
{
    public class ArticleRepository<T> : IArticleRepository<T> where T : class
    {
        private readonly AppIdentityDbContext db;

        public ArticleRepository(AppIdentityDbContext db) 
        {
            this.db = db;
        }
       

        public AppAuthor GetByIdIncludeAuthors(string id)
        {
            return db.Users.Include(a=>a.Articles).FirstOrDefault(a => a.Id==id);
        }

        public IEnumerable<T> GetAll()
        {
            return db.Set<T>();
        }

        public T GetByID(int id)
        {
            return db.Set<T>().Find(id); 
        }

        public bool Add(T entity)
        {
            try
            {
                db.Set<T>().Add(entity);
                return db.SaveChanges() > 0;
            }
            catch
            {

                return false;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                db.Set<T>().Update(entity);
                return db.SaveChanges() > 0;
            }
            catch
            {

                return false;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                db.Set<T>().Remove(entity);
                return db.SaveChanges() > 0;
            }
            catch
            {

                return false;
            }
        }


        public IEnumerable<T> GetWhere(Expression<Func<T, bool>> Predicate)
        {
            return db.Set<T>().Where(Predicate);
        }

        public T SingleOrDefault(Expression<Func<T, bool>> Predicate)
        {
            return db.Set<T>().SingleOrDefault(Predicate);
        }

        IEnumerable<AppAuthor> IArticleRepository<T>.GetAllIncludeAuthors()
        {
            return db.Users.Include(a => a.Articles);
        }
    }
}
