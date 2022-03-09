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

        public IEnumerable<ProductModel> GetProducts()
        {
            List<ProductModel> products = new List<ProductModel>();
            // todo
            products.Add(new ProductModel{
                EntryDate = DateTime.Now,
                Id="1",
                Name="product1",
                Price= 100
            });
            return products;
        }

        public ProductModel GetProduct(string ProductId)
        {
            // todo.
            ProductModel product = new ProductModel{
                EntryDate = DateTime.Now,
                Id="1",
                Name="product1",
                Price= 100
            };
            return product;
        }
    }
}
