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
    public class ProductsController : Controller
    {
        private DataManager dataManager;
        private IWebHostEnvironment webHostEnvironment;

        public ProductsController(DataManager dataManager, IWebHostEnvironment webHostEnvironment)
        {
            this.dataManager = dataManager;
            this.webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new Product() : dataManager.ProductsRepository.GetProductById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Product model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                //добавить проверку файла
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

                        fileName = "Product" + uniqueFileName + ext;
                        model.TitleImagePath = fileName;
                        using (var stream = new FileStream(Path.Combine(webHostEnvironment.WebRootPath, "images/", fileName), FileMode.Create))
                        {
                            ImageResizeService.resizeTo1080(titleImageFile.OpenReadStream()).CopyTo(stream);
                        }
                    }
                }
                dataManager.ProductsRepository.SaveProduct(model);
                TempData["message"] = $"{model.Title} сохранён.";
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            Product deletedProduct = dataManager.ProductsRepository.DeleteProduct(id);
            if (deletedProduct != null)
            {
                TempData["message"] = $"{deletedProduct.Title} удалён.";
            }
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}