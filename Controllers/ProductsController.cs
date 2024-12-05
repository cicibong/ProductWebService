using Microsoft.AspNetCore.Mvc;
using ProductWebService.Models;
using System.Collections.Generic;

namespace ProductWebService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static readonly List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 3500 },
            new Product { Id = 2, Name = "Phone", Price = 1500 },
            new Product { Id = 3, Name = "Tablet", Price = 1200 }
        };

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(Products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = Products.Find(p => p.Id == id);
            if (product == null) return NotFound();
            return Ok(product);
        }
    }
}
