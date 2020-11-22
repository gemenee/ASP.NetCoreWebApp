using Microsoft.EntityFrameworkCore;
using MyGreatSite.Domain.Entities;
using MyGreatSite.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGreatSite.Domain.Repositories.EntityFramework
{
    public class EFOrderRepository : IOrderRepository
    {
        private readonly AppDbContext appDbContext;
        public EFOrderRepository(AppDbContext context)
        {
            appDbContext = context;
        }

        public IQueryable<Order> Orders => appDbContext.Orders
            .Include(o => o.Lines)
            .ThenInclude(l => l.Product);

        public void SaveOrder(Order order)
        {
            appDbContext.AttachRange(order.Lines.Select(l => l.Product));
            if (order.OrderId == default)
            {
                appDbContext.Orders.Add(order);
            }
            appDbContext.SaveChanges();
        }
    }
}
