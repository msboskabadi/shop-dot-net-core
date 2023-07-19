using Microsoft.AspNetCore.Mvc;
using ShopUI.Models;

namespace ShopUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productRepository;
        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }


        public IActionResult Index()
        {
            return View(productRepository.GetAll());
        }
    }
}
