
using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DeliVeggie.Services.Product.Entities
{
    public class ProductMdo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime EntryDate { get; set; }
        public Double Price { get; set; }
    }
}