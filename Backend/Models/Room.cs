using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Backend.Models
{
    public class Room
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("roomNumber")]
        public string roomNumber { get; set; }

        [BsonElement("roomName")]
        public string roomName { get; set; }


        [BsonElement("maxCount")]
        public int maxCount { get; set; }

        [BsonElement("currentRent")]
        public int currentRent { get; set; }
    }
}