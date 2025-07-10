using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Areas.User.Controllers
{
    [Area("User")]
    
    public class HomeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            ViewBag.categories = context.Categories.ToList();
            ViewBag.products = context.Products.ToList();
            return View();
        }

    }
}
