using Microsoft.AspNetCore.Mvc;

namespace BeautyProduct.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
