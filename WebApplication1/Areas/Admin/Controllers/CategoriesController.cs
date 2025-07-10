using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public IActionResult Index()
        {
            var categories = context.Categories.ToList();
            return View(categories);
        }
        public IActionResult Delete(int id)
        {
            var category = context.Categories.Find(id);
            if (category == null)
            {
                return View("Index");
            }
            context.Categories.Remove(category);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View(new Category());
        }
        public IActionResult Add(Category requst)
        {
            if (!ModelState.IsValid)
            {
                return View("Create",requst);
            }
            context.Add(requst);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var category = context.Categories.Find(id);
            return View(category);
        }
        public IActionResult Update(Category request)
        {
            context.Categories.Update(request);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
