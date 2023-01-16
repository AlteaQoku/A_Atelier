using Microsoft.AspNetCore.Mvc;

namespace A_Atelier.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
    }
}
