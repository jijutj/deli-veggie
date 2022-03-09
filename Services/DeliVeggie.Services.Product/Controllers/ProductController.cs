using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DeliVeggie.Services.Product.Entities;
using DeliVeggie.Services.Product.BL;
using DeliVeggie.Common.Models;

namespace DeliVeggie.Services.Product.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly ProductLogic productLogic;

        public ProductController(ILogger<ProductController> logger, ProductLogic productLogic)
        {
            _logger = logger;
            this.productLogic = productLogic;
        }

        [HttpGet]
        public IEnumerable<ProductDto> Get()
        {
            return productLogic.GetProducts();
        }

        [HttpGet("{id}")]
        public ProductDto Get(string Id)
        {
            return productLogic.GetProduct(Id);
        }
    }
}