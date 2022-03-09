using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using DeliVeggie.Gateway.Models;
using DeliVeggie.Gateway.Services;

namespace DeliVeggie.Gateway.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> logger;
        private readonly ProductService productService;
        private readonly IConfiguration Configuration;

        public ProductController(ILogger<ProductController> logger, ProductService productService)
        {
            this.logger = logger;
            this.productService = productService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductModel>> GetProducts()
        {
            IEnumerable<ProductModel> products = productService.GetProducts();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<ProductModel> GetProductDetails(string Id)
        {
            if (string.IsNullOrEmpty(Id))
            {
                return BadRequest("Invalid input");
            }

            ProductModel product = productService.GetProduct(Id); ;

            if (product == null)
            {
                return NotFound("Product not found");
            }

            return Ok(product);
        }
    }
}