using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Frontend.Models
{
    public class History
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("rental")]
        public string rental { get; set; }

        [BsonElement("toolName")]
        public string toolName { get; set; }

        [BsonElement("timeStart")]
        [BsonDateTimeOptions]
        public DateTime timeStart { get; set; }

        [BsonElement("timeExpire")]
        [BsonDateTimeOptions]
        public DateTime timeExpire { get; set; }

        [BsonElement("timeLend")]
        [BsonDateTimeOptions]
        public DateTime timeLend { get; set; }

        [BsonElement("isLend")]
        public bool isLend { get; set; }


    }
}