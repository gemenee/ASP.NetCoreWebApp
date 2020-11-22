using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGreatSite.Models.ViewComponents
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart Cart { get; set; }
        public CartSummaryViewComponent(Cart cartService)
        {
            Cart = cartService;
        }

        public IViewComponentResult Invoke()
        {
            return View(Cart);
        }
    }
}
