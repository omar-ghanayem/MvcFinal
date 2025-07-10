using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        ApplicationDbContext context=new ApplicationDbContext();
        public IActionResult Index()
        {
            ViewBag.Categories = context.Categories.ToList();
            var products = context.Products.ToList();
            return View(products);

        }
        public IActionResult Delete(int id)
        {
            var product = context.Products.Find(id);

            if (product == null)
            {
                return View("Index");
            }

            if (product.Image != null) {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\img", product.Image);
                System.IO.File.Delete(filePath);
            }
            context.Products.Remove(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            ViewBag.Categories = context.Categories.ToList();
            return View(new Product());
        }
        public IActionResult Add(Product request, IFormFile Image)
        {
            //ModelState.Remove("Category");
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = context.Categories.ToList();
                return View("Create", request);
            }
            var fileName = Guid.NewGuid().ToString();
            fileName += Path.GetExtension(Image.FileName);
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\img",fileName);
            using(var stream = System.IO.File.OpenWrite(filePath))
            {
                Image.CopyTo(stream);
            }
            request.Image = fileName;
            context.Add(request);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {
            ViewBag.Categories = context.Categories.ToList();
            var product = context.Products.Find(id);
            return View(product);
        }
        public IActionResult Update(Product request, IFormFile Image)
        {
            var product = context.Products.Find(request.Id);

            product.Name = request.Name;
            product.Description = request.Description;
            product.Price = request.Price;
            product.Quantity = request.Quantity;
            product.CategoryId = request.CategoryId;

            if (Image is not null)
            {
                var fullPath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\img", product.Image);
                System.IO.File.Delete(fullPath);
                var fileName = Guid.NewGuid().ToString();
                fileName += Path.GetExtension(Image.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\img", fileName);
                using (var stream = System.IO.File.OpenWrite(filePath))
                {
                    Image.CopyTo(stream);
                }

                product.Image = fileName;
            }
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
