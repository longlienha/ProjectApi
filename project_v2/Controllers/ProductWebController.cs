using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using project_v2.Models;
using Microsoft.Extensions.Logging;

namespace project_v2.Controllers
{
    public class ProductWebController : Controller
    {
        private readonly ILogger<ProductWebController> _logger;
        public ProductWebController(ILogger<ProductWebController> logger)
        {
            _logger = logger;
        }
        [Route("Product/Insert")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("Product/Insert")]
        public IActionResult Index(string name, string info,string brand,float price,float selling_price){
            // WebContext context = new WebContext();
            // Product oneProduct = new Product();
            // oneProduct.Name = name;
            // oneProduct.Info = info;
            // oneProduct.Brand = brand;
            // oneProduct.Price = (decimal)price;
            // oneProduct.Selling_Price = (decimal)selling_price;
            // context.Products.AddAsync(oneProduct);
            // context.SaveChangesAsync();
            return View();
        }
    }
}
