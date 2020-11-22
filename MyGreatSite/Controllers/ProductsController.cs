using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyGreatSite.Domain;
using MyGreatSite.Models;

namespace MyGreatSite.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DataManager dataManager;
        public ProductsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public int PageSize = 4;

        public IActionResult Index(Guid id, int productPage = 1)
        {
            if (id != default)
                return View("Show", dataManager.ProductsRepository.GetProductById(id));
            ViewBag.TextField = dataManager.TextFieldsRepository.GetTextFieldByCodeWord("PageProducts");
            return View(new ProductsListViewModel
            {
                Products = dataManager.ProductsRepository.GetProducts()
                        .OrderBy(p => p.Id)
                        .Skip((productPage - 1) * PageSize)
                        .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = dataManager.ProductsRepository.GetProducts().Count()
                }
            });
        }
    }
}