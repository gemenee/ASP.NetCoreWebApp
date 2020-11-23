using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGreatSite.Controllers
{
    public class SynthKeyboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
