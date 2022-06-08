using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class SnippetController : Controller
    {
        public IActionResult Index()
        {
            ViewData["title"] = "Consulta trechos";
            return View();
        }

        public IActionResult New()
        {
            ViewData["title"] = "Novo trecho";
            return View();
        }
    }
}
