using System;
using System.Collections.Generic;
using System.Linq;
using DeliVeggie.Common.Models;
using DeliVeggie.Common.Models.Messages;
using DeliVeggie.Gateway.Models;
using EasyNetQ;
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
            using (var bus = RabbitHutch.CreateBus(this.GetConnectionString()))
            {
                var request = new ProductsRequest();
                var response = bus.Rpc.Request<ProductsRequest, ProductsResponse>(request);
                products = response.Products.Select(x => MapProductResponseToModel(x)).ToList();
            }
            return products;
        }

        public ProductModel GetProduct(string ProductId)
        {
            ProductModel product = new ProductModel();
            using (var bus = RabbitHutch.CreateBus(this.GetConnectionString()))
            {
                var request = new ProductRequest(){ProductId = ProductId};
                var response = bus.Rpc.Request<ProductRequest, ProductResponse>(request);
                product = MapProductResponseToModel(response.Product);
            }
            return product;
        }

        private ProductModel MapProductResponseToModel(ProductDto productDto){
            return new ProductModel{Id = productDto.Id, Name = productDto.Name, EntryDate = productDto.EntryDate, Price = productDto.Price};
        }

        private string GetConnectionString(){
            return Configuration["RabbitMq:Host"];
        }
    }
}
