using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyGreatSite.Domain.Entities;
using MyGreatSite.Domain.Repositories.Abstract;
using MyGreatSite.Models;
using MyGreatSite.Service;

namespace MyGreatSite.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repository;
        private Cart cart;
        public OrderController(IOrderRepository repoService, Cart cartService)
        {
            repository = repoService;
            cart = cartService;
        }

        public ViewResult CheckOut() => View(new Order());
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Корзина пуста!");
            }

            if (ModelState.IsValid)
            {
                order.Lines = cart.Lines.ToArray();
                repository.SaveOrder(order);
                return RedirectToAction(nameof(Completed));
            }
            else return View(order);
        }

        public IActionResult Cancel()
        {
            return RedirectToAction(nameof(CartController.Index), nameof(CartController).CutController());

        }
        public ViewResult Completed()
        {
            cart.Clear();
            return View();
        }
    }
}