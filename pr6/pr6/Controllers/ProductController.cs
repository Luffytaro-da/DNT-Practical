using Microsoft.AspNetCore.Mvc;
using pr6.Models;
using System.Collections.Generic;
using System.Linq;

namespace pr6.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> GetSampleProducts()
        {
            return new List<Product>
            {
                new Product { ProductId = 1, ProductName = "Wireless Mouse", Price = 19.99m, Category = "Accessories" },
                new Product { ProductId = 2, ProductName = "Mechanical Keyboard", Price = 49.99m, Category = "Accessories" },
                new Product { ProductId = 3, ProductName = "HD Monitor", Price = 129.99m, Category = "Displays" },
                new Product { ProductId = 4, ProductName = "USB-C Hub", Price = 29.99m, Category = "Accessories" },
                new Product { ProductId = 5, ProductName = "In-ear monitors", Price = 29.99m, Category = "Furniture" }
            };
        }

        public IActionResult Index()
        {
            var products = GetSampleProducts();
            return View(products);
        }

        public IActionResult Dashboard()
        {
            // Simple welcome/dashboard page for the catalog
            return View();
        }

        public IActionResult Details(int id)
        {
            var product = GetSampleProducts().FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
