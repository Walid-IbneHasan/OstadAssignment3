using Microsoft.AspNetCore.Mvc;
using EcommerceShop.Models;

namespace EcommerceShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Description = "Description of product 1", Price = 29.99m, ImageUrl = "/images/product1.jpg" },
                new Product { Id = 2, Name = "Product 2", Description = "Description of product 2", Price = 49.99m, ImageUrl = "/images/product2.jpg" },
                new Product { Id = 3, Name = "Product 3", Description = "Description of product 3", Price = 19.99m, ImageUrl = "/images/product3.jpg" }
            };
            return View(products);
        }
    }
}
