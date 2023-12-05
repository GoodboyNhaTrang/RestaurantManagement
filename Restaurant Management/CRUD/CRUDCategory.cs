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

namespace Restaurant_Management.CRUD
{

    public class CRUDCategory
    {
      


        public static void AddNewCategory(string ID, string categoryName, string collectionName)
        {

            Connect.InitializeCollection(collectionName);

            if (!string.IsNullOrEmpty(ID) && !string.IsNullOrEmpty(categoryName))
            {

                var document = new BsonDocument
            {
                {"ID", ID },
                { "CategoryName", categoryName }
            };

                Connect.collection.InsertOne(document);
            }
        }
        public static bool DeleteCategory(string ID, string collectionName)
        {
            Connect.InitializeCollection(collectionName);
            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("ID", ID);
                var deleteResult = Connect.collection.DeleteOne(filter);

                if (deleteResult.DeletedCount > 0)
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
                Console.WriteLine("Error deleting product: " + ex.Message);
                return false;
            }
        }

        public static List<Category> GetAllCategories(string collectionName)
        {
            // Lấy tất cả Category từ collection và trả về danh sách

            Connect.InitializeCollection(collectionName);

            var categories = Connect.collection.Find(new BsonDocument()).ToList();

            var categoryList = new List<Category>();
            foreach (var bsonDocument in categories)
            {
                var category = new Category
                {
                    Id = bsonDocument["ID"].AsString,
                    CategoryName = bsonDocument["CategoryName"].AsString
                    // Các thuộc tính khác nếu có
                };
                categoryList.Add(category);
            }

            return categoryList;
        }



        public class Category
        {

            public string Id { get; set; }
            public string CategoryName { get; set; }
        }

        public static bool UpdateCategory(string id, string newName, string collectionName)
        {
            try
            {

                Connect.InitializeCollection(collectionName);

                var filter = Builders<BsonDocument>.Filter.Eq("ID", id);
                var update = Builders<BsonDocument>.Update.Set("CategoryName", newName);

                var updateResult = Connect.collection.UpdateOne(filter, update);


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
