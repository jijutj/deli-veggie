using DeliVeggie.Services.Product.DAL;
using Microsoft.Extensions.Configuration;
using DeliVeggie.Common.Models;
using DeliVeggie.Common.Models.Messages;
using System.Collections.Generic;
using System.Linq;

namespace DeliVeggie.Services.Product.BL
{
    public class ProductLogic
    {
        private ProductRepository productRepository;

        public ProductLogic(IConfiguration Configuration, ProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IEnumerable<ProductDto> GetProducts()
        {
            var result = this.productRepository.GetProducts();
            return result.Select(x => new Common.Models.ProductDto { Id = x.Id, EntryDate = x.EntryDate, Name = x.Name, Price = x.Price });
        }

        public Common.Models.ProductDto GetProduct(string productId)
        {
            if(string.IsNullOrWhiteSpace(productId)){
                return null;
            }
            var result = this.productRepository.GetProduct(productId);
            return new Common.Models.ProductDto { Id = result.Id, EntryDate = result.EntryDate, Name = result.Name, Price = result.Price};
        }
    }

}