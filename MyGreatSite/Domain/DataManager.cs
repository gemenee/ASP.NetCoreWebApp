using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyGreatSite.Domain.Repositories.Abstract;

namespace MyGreatSite.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFieldsRepository { get; set; }
        public IProductsRepository ProductsRepository { get; set; }
        public IArticlesRepository ArticlesRepository { get; set; }
        public IFeedbackRepository FeedbackRepository { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IProductsRepository productsRepository, IArticlesRepository articlesRepository, IFeedbackRepository feedbackRepository)
        {
            TextFieldsRepository = textFieldsRepository;
            ProductsRepository = productsRepository;
            ArticlesRepository = articlesRepository;
            FeedbackRepository = feedbackRepository;

        }
    }
}
