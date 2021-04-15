using Frontend.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Frontend.Services
{
    public class HistoryService
    {
        private readonly IMongoCollection<History> _historys;

        public HistoryService()
        {
            var client = new MongoClient("mongodb+srv://nattapong:Power1stun@cluster0.ephtu.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            var database = client.GetDatabase("SoftwareStudio");

            _historys = database.GetCollection<History>("Historys");
        }

        public List<History> Get() =>
            _historys.Find(history => true).ToList();

        public History Get(string id) =>
            _historys.Find<History>(history => history.Id == id).FirstOrDefault();
            
        public List<History> GetById(string id) =>
            _historys.Find(history => history.rental == id).ToList();

        public History Create(History history)
        {
            _historys.InsertOne(history);
            return history;
        }

        public void Update(string id, History historyIn) =>
            _historys.ReplaceOne(history => history.Id == id, historyIn);

        public void Remove(History historyIn) =>
            _historys.DeleteOne(history => history.Id == historyIn.Id);

        public void Remove(string id) =>
            _historys.DeleteOne(history => history.Id == id);
    }
}