using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using Amazon.SecurityToken.Model;

namespace Radium_Launcher_For_Windows.Server.Database
{
    public class Connect
    {
        private readonly string credential = Environment.GetEnvironmentVariable("DB_CONNECTION", EnvironmentVariableTarget.User) ?? "";
        public Connect() {

            var settings = MongoClientSettings.FromConnectionString(credential);
            // Set the ServerApi field of the settings object to set the version of the Stable API on the client
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            // Create a new client and connect to the server
            var client = new MongoClient(settings);
            // Send a ping to confirm a successful connection
            try
            {
                var result = client.GetDatabase("users").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
                Console.WriteLine(result.ToString());
                Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
