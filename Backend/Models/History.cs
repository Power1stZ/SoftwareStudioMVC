using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Backend.Models
{
    public class History
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("studentNumber")]
        public string studentNumber { get; set; }

        [BsonElement("toolID")]
        public string toolsID { get; set; }

        [BsonElement("time")]
        [BsonDateTimeOptions]
        public DateTime time { get; set; }

        [BsonElement("isExceed")]
        public bool isExceed { get; set; }


    }
}