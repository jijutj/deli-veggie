using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            IEnumerable<Product> products = productService.GetProducts();;

            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProductDetails(string Id)
        {
            if(string.IsNullOrEmpty(Id)){
                return BadRequest("Invalid input");
            }
            
            Product product = productService.GetProduct(Id);;

            if(product == null){
                return NotFound("Product not found");
            }

            return Ok(product);
        }
    }
}