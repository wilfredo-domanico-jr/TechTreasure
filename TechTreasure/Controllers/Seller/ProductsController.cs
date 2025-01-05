using Microsoft.AspNetCore.Mvc;
using TechTreasure.Models;
using TechTreasure.Services;

namespace TechTreasure.Controllers.Seller
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext context;

        public ProductsController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var products = context.Products.OrderByDescending(p => p.Id).ToList();
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductDto productDto)
        {

            // validate product
            return View();
        }
    }
}
