using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Radium_Launcher_For_Windows.Server.Database.Enum;

namespace Radium_Launcher_For_Windows.Server.Database
{
    public class Users
    {
        private ObjectId _id { get; }
        private string user { get; set; }
        private string passwordSHA1 { get; set; }
        private AccountType accountType { get; set; }

        private MongoClient client;


        public Users(MongoClient client) { this.client = client; }
        public Users(ObjectId id, string user, string passwordSHA1, AccountType accountType, MongoClient client)
        {
            this._id = id;
            this.user = user;
            this.passwordSHA1 = passwordSHA1;
            this.accountType = accountType;

            this.client = client;
        }

        public BsonDocument FindDocument()
        {
            var collection = this.client.GetDatabase("sample_mflix").GetCollection<BsonDocument>("movies");
            var filter = Builders<BsonDocument>.Filter.Eq("title", "Back to the Future");
            var document = collection.Find(filter).First();
            return document;
        }

        public Object GenerateDocument()
        {
            throw new NotImplementedException();
        }

        public void InsertAll()
        {
            throw new NotImplementedException();
        }
    }
}
