using System;

namespace DeliVeggie.Gateway.Models
{
    public class ProductModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime EntryDate{get;set; }
        public Double Price { get; set; }
    }
}