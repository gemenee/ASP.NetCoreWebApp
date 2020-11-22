using MyGreatSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGreatSite.Domain.Repositories.Abstract
{
    public interface IArticlesRepository
    {
        IQueryable<Article> GetArticles();
        Article GetArticleById(Guid id);

        void SaveArticle(Article entity);
        void DeleteArticle(Guid id);
    }
}
