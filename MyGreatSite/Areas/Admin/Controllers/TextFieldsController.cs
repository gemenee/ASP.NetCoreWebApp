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
    public class TextFieldsController : Controller
    {
        private readonly DataManager dataManager;
        private IWebHostEnvironment webHostEnvironment;

        public TextFieldsController(DataManager dataManager, IWebHostEnvironment webHostEnvironment)
        {
            this.dataManager = dataManager;
            this.webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Edit(string codeWord)
        {
            var entity = dataManager.TextFieldsRepository.GetTextFieldByCodeWord(codeWord);
            ViewBag.Message = "Допустимы файлы типов \".jpg\", \".jpeg\", \".gif\", \".png\"";
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(TextField model, IFormFile titleImageFile)
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

                        fileName = "Page" + uniqueFileName + ext;
                        model.TitleImagePath = fileName;
                        using (var stream = new FileStream(Path.Combine(webHostEnvironment.WebRootPath, "images/", fileName), FileMode.Create))
                        {
                            ImageResizeService.resizeTo1080(titleImageFile.OpenReadStream()).CopyTo(stream);
                        }
                    }
                }
                dataManager.TextFieldsRepository.SaveTextField(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
    }
}