using MyGreatSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGreatSite.Domain.Repositories.Abstract
{
    public interface IFeedbackRepository
    {
        IQueryable<Feedback> GetAllFeedback();
        Feedback GetFeedbackById(Guid id);

        void SaveFeedback(Feedback entity);
        void DeleteFeedback(Guid id);
    }
}
