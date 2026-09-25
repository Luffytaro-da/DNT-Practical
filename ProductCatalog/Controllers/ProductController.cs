using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        // Sample products stored in a list (no database)
        private static List<Product> GetSampleProducts()
        {
            return new List<Product>
            {
                new Product { ProductId = 1, ProductName = "Wireless Mouse", Price = 19.99m, Category = "Accessories" },
                new Product { ProductId = 2, ProductName = "Mechanical Keyboard", Price = 49.99m, Category = "Accessories" },
                new Product { ProductId = 3, ProductName = "HD Monitor", Price = 129.99m, Category = "Displays" }
            };
        }

        // GET: /Product/ or /Product/Index
        public ActionResult Index()
        {
            var products = GetSampleProducts();
            return View(products);
        }

        // GET: /Product/Details/{id}
        public ActionResult Details(int id)
        {
            var product = GetSampleProducts().FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
    }
}
