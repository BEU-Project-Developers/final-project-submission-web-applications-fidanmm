using Microsoft.AspNetCore.Mvc;

namespace BeautyProduct.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
