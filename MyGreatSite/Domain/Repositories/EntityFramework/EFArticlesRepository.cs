using MyGreatSite.Domain.Entities;
using MyGreatSite.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGreatSite.Domain.Repositories.EntityFramework
{
    public class EFArticlesRepository : IArticlesRepository
    {
        private readonly AppDbContext appDbContext;

        public EFArticlesRepository(AppDbContext context)
        {
            appDbContext = context;
        }

        public void DeleteArticle(Guid id)
        {
            var entity = appDbContext.Articles.Where(e => e.Id == id).FirstOrDefault();
           appDbContext.Articles.Remove(entity);
            appDbContext.SaveChanges();
        }

        public Article GetArticleById(Guid id)
        {
            return appDbContext.Articles.Where(a => a.Id == id).FirstOrDefault();
        }

        public IQueryable<Article> GetArticles()
        {
            return appDbContext.Articles;
        }

        public void SaveArticle(Article entity)
        {
            if (entity.Id == default)
                appDbContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            else
                appDbContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            appDbContext.SaveChanges();
        }
    }
}
