using Microsoft.AspNetCore.Mvc;

namespace Amoisuntke.Web.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Aromas()
        {
            return View();
        }

        public IActionResult Humidifiers()
        {
            return View();
        }
    }
}
