using Microsoft.AspNetCore.Mvc;
using ShopUI.Models;

namespace ShopUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productRepository;
        private int pageSize = 2;
        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Index(int pageNumber = 1)
        {
            return View(productRepository.GetAll(pageNumber, pageSize));
        }
    }
}
