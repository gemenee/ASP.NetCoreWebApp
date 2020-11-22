using MyGreatSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGreatSite.Domain.Repositories.Abstract
{
    public interface IProductsRepository
    {
        IQueryable<Product> GetProducts();
        Product GetProductById(Guid id);

        void SaveProduct(Product entity);
        Product DeleteProduct(Guid id);
    }
}
