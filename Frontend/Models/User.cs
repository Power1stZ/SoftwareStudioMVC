using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Frontend.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("studentNumber")]
        public string studentNumber { get; set; }

        [BsonElement("firstName")]
        public string firstName { get; set; }

        [BsonElement("lastName")]
        public string lastName { get; set; }

        [BsonElement("email")]
        public string email { get; set; }

        [BsonElement("password")]
        public string password { get; set; }

        [BsonElement("isBan")]
        public bool isBan { get; set; }

        [BsonElement("role")]
        public int role { get; set; }

        [BsonElement("exceedCount")]
        public int exceedCount { get; set; }

    }
}