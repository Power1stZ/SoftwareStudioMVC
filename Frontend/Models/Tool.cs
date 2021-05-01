using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Frontend.Models
{
    public class Tool
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("toolName")]
        public string toolName { get; set; }

        [BsonElement("room")]
        public string room { get; set; }

        [BsonElement("description")]
        public string description { get; set; }

        [BsonElement("maxCount")]
        public string maxCount { get; set; }
    }
}