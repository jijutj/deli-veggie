using System;
using System.Collections.Generic;
using System.Linq;
using DeliVeggie.Gateway.Models;
using Microsoft.Extensions.Configuration;

namespace DeliVeggie.Gateway.Services
{
    public class ProductService
    {
        public IConfiguration Configuration;
        public ProductService(IConfiguration Configuration)
        {
            this.Configuration = Configuration;
        }

        public IEnumerable<Product> GetProducts()
        {
            List<Product> productModels = null;
            // todo

            return productModels;
        }

        public Product GetProduct(string ProductId)
        {
            Product productModels = null;
            // todo

            return productModels;
        }
    }
}
