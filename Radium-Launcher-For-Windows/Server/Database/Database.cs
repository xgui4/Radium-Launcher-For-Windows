using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using Amazon.SecurityToken.Model;
using System.Windows;
using System.Linq.Expressions;
using System.Security.Policy;

namespace Radium_Launcher_For_Windows.Server.Database
{
    public class Database
    {
        private string connectionString = "";
        private string database = "Radium_Launcher";
        public Database() {
            SetConnectionString(); 
        }

        /// <summary>
        /// Se connecter à Mongo Atlas à l'aide de la clé de connexion
        /// </summary>
        /// <returns>Le Client de MongoDB</returns>
        public MongoClient ConnectToMongoDB()
        {
            MongoClient client = null;
            try
            {
                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new MongoClientException(
                        "Access Denied. Please verify that the connectionString is in the environment variable."
                    );
                }
                var credentials = MongoClientSettings.FromConnectionString(connectionString);
                credentials.ServerApi = new ServerApi(ServerApiVersion.V1);
                client = new MongoClient(credentials);
            }
            catch (MongoClientException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return client; 
        }

        public void TestConnection(MongoClient client)
        {
            client.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
            MessageBox.Show("Pinged your deployment. You successfully connected to MongoDB!");
        }

        private void SetConnectionString() 
        {
            this.connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION", EnvironmentVariableTarget.User) ?? "";
        }
    }
}
