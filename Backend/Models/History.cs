using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Backend.Models
{
    public class History
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("historyID")]
        public string historyID { get; set; }

        [BsonElement("studentNumber")]
        public string studentNumber { get; set; }

        [BsonElement("toolName")]
        public string toolName { get; set; }

        [BsonElement("rentTime")]
        [BsonDateTimeOptions]
        public DateTime rentTime { get; set; }

        [BsonElement("lendTime")]
        [BsonDateTimeOptions]
        public DateTime lendTime { get; set; }

        [BsonElement("createTime")]
        [BsonDateTimeOptions]
        public DateTime createTime { get; set; }
    }
}