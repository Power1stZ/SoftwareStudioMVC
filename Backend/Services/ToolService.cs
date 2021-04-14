using Backend.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Backend.Services
{
    public class ToolService
    {
        private readonly IMongoCollection<Tool> _tools;

        public ToolService()
        {
            var client = new MongoClient("mongodb+srv://nattapong:Power1stun@cluster0.ephtu.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            var database = client.GetDatabase("SoftwareStudio");

            _tools = database.GetCollection<Tool>("Tool");
        }

        public List<Tool> Get() =>
            _tools.Find(tool => true).ToList();

        public Tool Get(string id) =>
            _tools.Find<Tool>(tool => tool.Id == id).FirstOrDefault();

        public Tool Create(Tool tool)
        {
            _tools.InsertOne(tool);
            return tool;
        }
        public void Update(string id, Tool toolIn) =>
            _tools.ReplaceOne(tool => tool.Id == id, toolIn);

        public void Remove(Tool toolIn) =>
            _tools.DeleteOne(tool => tool.Id == toolIn.Id);

        public void Remove(string id) => 
            _tools.DeleteOne(tool => tool.Id == id);
    }
}