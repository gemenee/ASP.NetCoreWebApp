using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyGreatSite.Domain;

namespace MyGreatSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            return View(dataManager.TextFieldsRepository.GetTextFieldByCodeWord("PageIndex"));
        }
        public IActionResult Contacts()
        {
            return View(dataManager.TextFieldsRepository.GetTextFieldByCodeWord("PageContacts"));
        }

        public IActionResult About()
        {
            return View(dataManager.TextFieldsRepository.GetTextFieldByCodeWord("PageAbout"));
        }

        public IActionResult Feedback()
        {
            return View(dataManager.TextFieldsRepository.GetTextFieldByCodeWord("PageFeedback"));
        }

        public IActionResult Articles()
        {
            return View(dataManager.TextFieldsRepository.GetTextFieldByCodeWord("PageArticles"));
        }
    }
}