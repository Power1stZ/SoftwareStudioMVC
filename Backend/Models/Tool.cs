using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Backend.Models
{
    public class Tool
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("toolName")]
        public string toolName { get; set; }

        [BsonElement("isRent")]
        public bool isRent { get; set; }

        [BsonElement("rentTime")]
        [BsonDateTimeOptions]
        public DateTime rentTime { get; set; }

        [BsonElement("room")]
        public string room { get; set; }

        [BsonElement("description")]
        public string description { get; set; }

        [BsonElement("rental")]
        public string rental { get; set; }
    }
}