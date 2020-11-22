using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyGreatSite.Domain;
using MyGreatSite.Domain.Entities;
using MyGreatSite.Models;
using MyGreatSite.Service;

namespace MyGreatSite.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly DataManager dataManager;
        public FeedbackController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public int PageSize = 4;
        public IActionResult Index(Guid id, int page = 1)
        {
            if (id != default)
                return View("Show", dataManager.FeedbackRepository.GetFeedbackById(id));
            ViewBag.TextField = dataManager.TextFieldsRepository.GetTextFieldByCodeWord("PageFeedback");
            return View(new ListViewModel
            {
                Items = dataManager.FeedbackRepository.GetAllFeedback()
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

        public IActionResult Write()
        {
            var entity = new Feedback();
            return View(entity);
        }

        [HttpPost]
        public IActionResult Write(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                dataManager.FeedbackRepository.SaveFeedback(feedback);
            }
            return RedirectToAction(nameof(FeedbackController.Index), nameof(FeedbackController).CutController());

        }
    }
}