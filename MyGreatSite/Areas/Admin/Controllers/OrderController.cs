using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyGreatSite.Domain.Entities;
using MyGreatSite.Domain.Repositories.Abstract;
using MyGreatSite.Models;

namespace MyGreatSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        private IOrderRepository repository;
        private Cart cart;
        public OrderController(IOrderRepository repoService, Cart cartService)
        {
            repository = repoService;
            cart = cartService;
        }

        public ViewResult Index() => View(repository.Orders);

        [HttpPost]
        public IActionResult MarkShipped(int orderId)
        {
            Order order = repository.Orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order != null)
            {
                order.Shipped = true;
                repository.SaveOrder(order);
            }
            return RedirectToAction(nameof(Index));
        }

        public ViewResult Details(int orderId)
        {
            Order order = repository.Orders.FirstOrDefault(o => o.OrderId == orderId);
            return order == null ? View("Ошибка!") : View(order);
        }
    }
}