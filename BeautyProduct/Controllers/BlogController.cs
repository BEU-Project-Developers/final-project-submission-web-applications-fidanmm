using Microsoft.AspNetCore.Mvc;

namespace BeautyProduct.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
