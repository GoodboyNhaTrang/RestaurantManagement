using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;

namespace Restaurant_Management
{

    public class CRUDOperations
    {
        private static IMongoCollection<BsonDocument> collection;

        public static void InitializeCollection( string collectionName)
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

        public static void AddNewCategory(string ID, string categoryName)
        {
            string collectionName = "Category";

            CRUDOperations.InitializeCollection(collectionName);

            if (!string.IsNullOrEmpty(ID) && !string.IsNullOrEmpty(categoryName))
            {
                
                var document = new BsonDocument
            {
                {"ID", ID },
                { "Name", categoryName }
            };

                collection.InsertOne(document);
            }
        }

        public static List<Category> GetAllCategories()
        {
            // Lấy tất cả Category từ collection và trả về danh sách
            // Ví dụ:
            string collectionName = "Category";
            CRUDOperations.InitializeCollection(collectionName);

            var categories = collection.Find(new BsonDocument()).ToList();

            var categoryList = new List<Category>();
            foreach (var bsonDocument in categories)
            {
                var category = new Category
                {
                    Id = bsonDocument["ID"].AsString,
                    Name = bsonDocument["Name"].AsString
                    // Các thuộc tính khác nếu có
                };
                categoryList.Add(category);
            }

            return categoryList;
        }



        public class Category
        {

            public string Id { get; set; }
            public string Name { get; set; }
        }

        public static bool UpdateCategory(string id, string newName)
        {
            try
            {
                string collectionName = "Category";
                CRUDOperations.InitializeCollection(collectionName);

                var filter = Builders<BsonDocument>.Filter.Eq("ID", id);
                var update = Builders<BsonDocument>.Update.Set("Name", newName);

                var updateResult = collection.UpdateOne(filter, update);

            
                if (updateResult.ModifiedCount > 0)
                {
                    return true; // Cập nhật thành công
                }
                else
                {
                    return false; // Không tìm thấy hoặc không cần cập nhật
                }
            }
            
            catch (Exception ex)
            {
                Console.WriteLine("Error updating category: " + ex.Message);
                return false;
            }
        }

    }
}
