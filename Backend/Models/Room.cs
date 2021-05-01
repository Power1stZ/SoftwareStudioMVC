using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Backend.Models
{
    public class Room
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("roomName")]
        public string roomName { get; set; }


        [BsonElement("description")]
        public string description { get; set; }
    }
}