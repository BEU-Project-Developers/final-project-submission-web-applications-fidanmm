﻿using Microsoft.AspNetCore.Mvc;

namespace BeautyProduct.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
