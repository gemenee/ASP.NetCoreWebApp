using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyGreatSite.Domain;
using MyGreatSite.Models;

namespace MyGreatSite.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly DataManager dataManager;
        public ArticlesController(DataManager manager)
        {
            dataManager = manager;
        }

        public int PageSize = 4;
        public IActionResult Index(Guid id, int page = 1)
        {
            if (id != default)
                return View("Show", dataManager.ArticlesRepository.GetArticleById(id));
            ViewBag.TextField = dataManager.TextFieldsRepository.GetTextFieldByCodeWord("PageArticles");

            return View(new ListViewModel
            {
                Items = dataManager.ArticlesRepository.GetArticles()
                .OrderBy(a => a.Id)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = dataManager.ArticlesRepository.GetArticles().Count()
                }
            });
        }
    }
}