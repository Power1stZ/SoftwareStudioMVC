using Frontend.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Frontend.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _users;

        public UserService()
        {
            var client = new MongoClient("mongodb+srv://nattapong:Power1stun@cluster0.ephtu.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            var database = client.GetDatabase("SoftwareStudio");
            _users = database.GetCollection<User>("Users");
        }

        public List<User> Get() =>
            _users.Find(user => true).ToList();

        public User Get(string id) =>
            _users.Find<User>(user => user.id == id).FirstOrDefault();

        public User GetById(string studentNumber) =>
            _users.Find<User>(user => user.studentNumber == studentNumber).FirstOrDefault();

        public User Login(string email, string password) =>
            _users.Find<User>(user => (user.email == email && user.password == password)).FirstOrDefault();
        public User Create(User user)
        {
            _users.InsertOne(user);
            return user;
        }

        public void Update(string id, User userIn) =>
            _users.ReplaceOne(user => user.id == id, userIn);

        public void Remove(User userIn) =>
            _users.DeleteOne(user => user.id == userIn.id);

        public void Remove(string id) =>
            _users.DeleteOne(user => user.id == id);
    }
}