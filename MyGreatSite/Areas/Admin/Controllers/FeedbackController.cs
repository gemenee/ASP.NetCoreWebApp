using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
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
    public class FeedbackController : Controller
    {
        private DataManager dataManager;
        private IWebHostEnvironment webHostEnvironment;
        public FeedbackController(DataManager manager, IWebHostEnvironment environment, HtmlEncoder htmlEncoder)
        {
            dataManager = manager;
            webHostEnvironment = environment;
        }

        public IActionResult Index()
        {
            ViewBag.TextField = dataManager.TextFieldsRepository.GetTextFieldByCodeWord("PageFeedback");
            return View(dataManager.FeedbackRepository.GetAllFeedback());
        }
        public IActionResult Edit(Guid id)
        {
            Feedback entity = id == default ? new Feedback() : dataManager.FeedbackRepository.GetFeedbackById(id);
            ViewBag.Message = "Допустимы файлы типов \".jpg\", \".jpeg\", \".gif\", \".png\"";
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Feedback model, IFormFile titleImageFile)
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
                        fileName = "Feedback" + uniqueFileName + ext;
                        model.TitleImagePath = fileName;
                        using (var stream = new FileStream(Path.Combine(webHostEnvironment.WebRootPath, "images/", fileName), FileMode.Create))
                        {
                            titleImageFile.CopyTo(stream);
                        }
                    }
                }

                dataManager.FeedbackRepository.SaveFeedback(model);
                return RedirectToAction(nameof(FeedbackController.Index), nameof(FeedbackController).CutController());
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.FeedbackRepository.DeleteFeedback(id);
            return RedirectToAction(nameof(FeedbackController.Index), nameof(FeedbackController).CutController());
        }
    }
}