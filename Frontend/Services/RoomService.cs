using Frontend.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Frontend.Services
{
    public class RoomService
    {
        private readonly IMongoCollection<Room> _rooms;

        public RoomService()
        {
            var client = new MongoClient("mongodb+srv://nattapong:Power1stun@cluster0.ephtu.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            var database = client.GetDatabase("SoftwareStudio");

            _rooms = database.GetCollection<Room>("Rooms");
        }

        public List<Room> Get() =>
            _rooms.Find(room => true).ToList();

        public Room Get(string id) =>
            _rooms.Find<Room>(room => room.id == id).FirstOrDefault();

        public Room Create(Room room)
        {
            _rooms.InsertOne(room);
            return room;
        }

        public void Update(string id, Room roomIn) =>
            _rooms.ReplaceOne(room => room.id == id, roomIn);

        public void Remove(Room roomIn) =>
            _rooms.DeleteOne(room => room.id == roomIn.id);

        public void Remove(string id) => 
            _rooms.DeleteOne(room => room.id == id);
    }
}