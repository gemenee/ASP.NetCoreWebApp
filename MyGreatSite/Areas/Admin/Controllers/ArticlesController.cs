using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyGreatSite.Domain;
using MyGreatSite.Domain.Entities;
using MyGreatSite.Service;

namespace MyGreatSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticlesController : Controller
    {
        private DataManager dataManager;
        private IWebHostEnvironment webHostEnvironment;

        public ArticlesController(DataManager manager, IWebHostEnvironment environment)
        {
            dataManager = manager;
            webHostEnvironment = environment;
        }

        public IActionResult Index()
        {
            ViewBag.TextField = dataManager.TextFieldsRepository.GetTextFieldByCodeWord("PageArticles");
            return View(dataManager.ArticlesRepository.GetArticles());
        }
        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new Article() : dataManager.ArticlesRepository.GetArticleById(id);
            ViewBag.Message = "Допустимы файлы типов \".jpg\", \".jpeg\", \".gif\", \".png\"";
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Article model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    string[] permittedExtensions = { ".jpg", ".jpeg", ".gif", ".png" };
                    string fileName = titleImageFile.FileName;
                    string uniqueFileName = Guid.NewGuid().ToString().Substring(0, 4);
                    var ext = Path.GetExtension(fileName).ToLowerInvariant();

                    if (string.IsNullOrEmpty(ext) || !permittedExtensions.Contains(ext))
                    {
                        ViewBag.Message = "Выберите файл с подходящим расширением";
                        return RedirectToAction();
                    }

                    else
                    {
                        
                        fileName = "Article" + uniqueFileName + ext;
                        model.TitleImagePath = fileName;
                        using (var stream = new FileStream(Path.Combine(webHostEnvironment.WebRootPath, "images/", fileName), FileMode.Create))
                        {
                            ImageResizeService.resizeTo1080(titleImageFile.OpenReadStream()).CopyTo(stream);
                        }
                    }
                }

                dataManager.ArticlesRepository.SaveArticle(model);
                return RedirectToAction(nameof(ArticlesController.Index), nameof(ArticlesController).CutController());
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.ArticlesRepository.DeleteArticle(id);
            return RedirectToAction(nameof(ArticlesController.Index), nameof(ArticlesController).CutController());
        }
    }
}