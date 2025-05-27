using Microsoft.AspNetCore.Mvc;

namespace BeautyProduct.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
