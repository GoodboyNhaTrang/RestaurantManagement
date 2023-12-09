using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management
{
    public class Connect
    {
        public static IMongoCollection<BsonDocument> collection;
        public static void InitializeCollection(string collectionName)
        {
            string connectionString = "mongodb+srv://abc123:trungngu123@cluster0.urlminh.mongodb.net/";
            string dbName = "RM";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(dbName);
            collection = database.GetCollection<BsonDocument>(collectionName);
        }

        public static bool IsValidUser(string userName, string userPassword)
        {
            bool isValid = false;

            var filter = Builders<BsonDocument>.Filter.Eq("userName", userName) & Builders<BsonDocument>.Filter.Eq("userPassword", userPassword);
            var result = collection.Find(filter).FirstOrDefault();

            if (result != null)
            {
                isValid = true;
                Name = result["Name"].AsString;
            }

            return isValid;
        }

        public static string _name;
        public static string Name
        {
            get { return _name; }
            private set { _name = value; }

        }

        public static void BlurBackground()
        {

        }


    }
}
