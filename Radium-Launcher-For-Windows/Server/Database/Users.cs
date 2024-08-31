using MongoDB.Bson;
using MongoDB.Driver;
using Radium_Launcher_For_Windows.Server.Database.Enum;

namespace Radium_Launcher_For_Windows.Server.Database
{
    public class Users
    {
        private ObjectId Id;
        private string User;
        private string PasswordSHA1;
        private AccountType AccountType;

        private MongoClient Client;

        public Users(MongoClient client) { }
        public Users(ObjectId id, string user, string passwordSHA1, AccountType accountType, MongoClient client)
        {
            Id = id;
            User = user;
            PasswordSHA1 = passwordSHA1;
            AccountType = accountType;
            Client = client;
        }

        public BsonDocument FindDocument()
        {
            if (Client == null)
            {
                return null;
            }
            var collection = Client.GetDatabase("Radium_Launcher").GetCollection<BsonDocument>("Users");
            var filter = Builders<BsonDocument>.Filter.Eq("user", "DefaultAdmin");
            var document = collection.Find(filter).FirstOrDefault();
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
