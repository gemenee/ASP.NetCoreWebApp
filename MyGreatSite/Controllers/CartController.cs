using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MyGreatSite.Domain;
using MyGreatSite.Domain.Entities;
using MyGreatSite.Models;
using MyGreatSite.Service;

namespace MyGreatSite.Controllers
{
    public class CartController : Controller
    {
        private DataManager DataManager;
        private Cart cart;
        public CartController(DataManager manager, Cart cartService)
        {
            DataManager = manager;
            cart = cartService;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel { Cart = cart, ReturnUrl = returnUrl });
        }
        public IActionResult AddToCart(Guid Id, string returnUrl)
        {
            Product product = DataManager.ProductsRepository.GetProducts().FirstOrDefault(p => p.Id == Id);
            cart.AddItem(product, 1);

            Console.WriteLine($"productId = {Id}, returnUrl = {returnUrl}, /n {product.Title.ToString()}");
            
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromCart(Guid Id, string returnUrl)
        {
            cart.RemoveLine(Id);
            if (cart.Lines.Count() == 0)
            {
                return RedirectToAction(nameof(ProductsController.Index), nameof(ProductsController).CutController());
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        private void SaveCart(Cart cart)
        {
           HttpContext.Session.SetJson("Cart", cart);
        }

        private Cart GetCart()
        {
            Cart cart = HttpContext.Session.GetJson<Cart>("Cart") ?? new Cart();
            return cart;
        }
    }
}