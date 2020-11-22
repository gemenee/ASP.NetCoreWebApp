using Microsoft.EntityFrameworkCore;
using MyGreatSite.Domain.Entities;
using MyGreatSite.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGreatSite.Domain.Repositories.EntityFramework
{
    public class EFProductsRepository : IProductsRepository
    {
        private readonly AppDbContext context;
        public EFProductsRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Product DeleteProduct(Guid id)
        {
            Product dbEntry = context.Products.FirstOrDefault(p => p.Id == id);
            if (dbEntry != null)
            {
                context.Products.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public Product GetProductById(Guid id)
        {
            return context.Products.FirstOrDefault(x=> x.Id == id);
        }

        public IQueryable<Product> GetProducts()
        {
            return context.Products;
        }

        public void SaveProduct(Product entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
