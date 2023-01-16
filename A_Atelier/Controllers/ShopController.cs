using Microsoft.AspNetCore.Mvc;

namespace A_Atelier.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
    }
}
