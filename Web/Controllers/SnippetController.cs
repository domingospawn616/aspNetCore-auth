﻿using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class SnippetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
