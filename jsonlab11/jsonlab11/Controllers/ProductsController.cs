// Controllers/ProductsController.cs
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ProductAPI.Models;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // Sample list of products
        private List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1200.00m },
            new Product { Id = 2, Name = "Smartphone", Price = 800.00m },
            new Product { Id = 3, Name = "Tablet", Price = 600.00m }
        };

        // GET: api/products
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(products); // Returns the list of products in JSON format
        }
    }
}