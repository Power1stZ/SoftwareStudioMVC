using Backend.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Backend.Services
{
    public class HistoryService
    {
        private readonly IMongoCollection<History> _historys;

        public HistoryService()
        {
            var client = new MongoClient("mongodb+srv://nattapong:Power1stun@cluster0.ephtu.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            var database = client.GetDatabase("SoftwareStudio");

            _historys = database.GetCollection<History>("History");
        }

        public List<History> Get() =>
            _historys.Find(history => true).ToList();

        public History Get(string id) =>
            _historys.Find<History>(history => history.Id == id).FirstOrDefault();

        public History Create(History history)
        {
            _historys.InsertOne(history);
            return history;
        }
    }
}