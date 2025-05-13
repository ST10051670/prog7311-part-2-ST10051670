using Microsoft.AspNetCore.Mvc;
using MUHAMMED_ZIA_DESAI.ST10051670.POE.Models;
using MUHAMMED_ZIA_DESAI.ST10051670.POE.Services;
using Microsoft.AspNetCore.Http;

namespace MUHAMMED_ZIA_DESAI.ST10051670.POE.Controllers
{
    public class FarmerController : Controller
    {
        private readonly ProductService _productService;

        public FarmerController(ProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            var userId = HttpContext.Session.GetString("UserEmail");  
            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Login", "Account"); 
            }

            var products = _productService.GetProductsByUserId(userId);
            return View(products);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            var userId = HttpContext.Session.GetString("UserEmail");  
            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Login", "Account"); 
            }

            _productService.AddProduct(product, userId); 
            return RedirectToAction("Index"); 
        }
    }
}
