using MyGreatSite.Domain.Entities;
using MyGreatSite.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGreatSite.Domain.Repositories.EntityFramework
{
    public class EFFeedbackRepository : IFeedbackRepository
    {
        private readonly AppDbContext appDbContext;

        public EFFeedbackRepository(AppDbContext context)
        {
            appDbContext = context;
        }

        public void DeleteFeedback(Guid id)
        {
            var entity = appDbContext.Feedback.Where(e => e.Id == id).FirstOrDefault();
            appDbContext.Feedback.Remove(entity);
            appDbContext.SaveChanges();
        }

        public Feedback GetFeedbackById(Guid id)
        {
            return appDbContext.Feedback.Where(a => a.Id == id).FirstOrDefault();
        }

        public IQueryable<Feedback> GetAllFeedback()
        {
            return appDbContext.Feedback;
        }

        public void SaveFeedback(Feedback entity)
        {
            if (entity.Id == default)
                appDbContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            else
                appDbContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            appDbContext.SaveChanges();
        }
    }
}
