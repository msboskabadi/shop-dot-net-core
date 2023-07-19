using Microsoft.AspNetCore.Mvc;

namespace ShopUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
