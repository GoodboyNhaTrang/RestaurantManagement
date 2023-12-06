using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using MongoDB.Bson;
using MongoDB.Driver;


using MongoDB.Driver.Core.Configuration;

namespace Restaurant_Management.CRUD
{

    public class CRUDCategory
    {

        //    public class Category
        //    {
        //        public ObjectId Id { get; set; }
        //        public string CategoryName { get; set; }
        //    }


        //    public static void AddNewCategory(string categoryName, string collectionName)
        //    {

        //        Connect.InitializeCollection(collectionName);

        //        if (!string.IsNullOrEmpty(categoryName))
        //        {

        //            var document = new BsonDocument
        //        {

        //            { "CategoryName", categoryName }
        //        };

        //            Connect.collection.InsertOne(document);
        //        }
        //    }
        //    public static bool DeleteCategory(string ID, string collectionName)
        //    {
        //        Connect.InitializeCollection(collectionName);
        //        try
        //        {
        //            var filter = Builders<BsonDocument>.Filter.Eq("_id", ID);
        //            var deleteResult = Connect.collection.DeleteOne(filter);

        //            if (deleteResult.DeletedCount > 0)
        //            {
        //                return true; // Cập nhật thành công
        //            }
        //            else
        //            {
        //                return false; // Không tìm thấy hoặc không cần cập nhật
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Error deleting product: " + ex.Message);
        //            return false;
        //        }
        //    }

        //    //public static List<Category> GetAllCategories(string collectionName)
        //    //{
        //    //    // Lấy tất cả Category từ collection và trả về danh sách

        //    //    Connect.InitializeCollection(collectionName);

        //    //    var categories = Connect.collection.Find(new BsonDocument()).ToList();

        //    //    var categoryList = new List<Category>();
        //    //    foreach (var bsonDocument in categories)
        //    //    {
        //    //        var category = new Category
        //    //        {

        //    //            CategoryName = bsonDocument["CategoryName"].AsString
        //    //            // Các thuộc tính khác nếu có
        //    //        };
        //    //        categoryList.Add(category);
        //    //    }

        //    //    return categoryList;
        //    //}





        //    public static bool UpdateCategory(string id, string newName, string collectionName)
        //    {
        //        try
        //        {

        //            Connect.InitializeCollection(collectionName);

        //            var filter = Builders<BsonDocument>.Filter.Eq("ID", id);
        //            var update = Builders<BsonDocument>.Update.Set("CategoryName", newName);

        //            var updateResult = Connect.collection.UpdateOne(filter, update);


        //            if (updateResult.ModifiedCount > 0)
        //            {
        //                return true; // Cập nhật thành công
        //            }
        //            else
        //            {
        //                return false; // Không tìm thấy hoặc không cần cập nhật
        //            }
        //        }

        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Error updating category: " + ex.Message);
        //            return false;
        //        }
        //    }







        //public async Task Create(Category category)
        //{
           
        //    await Connect.collection.InsertOneAsync(category);
        //}

        //public async Task<Category> Read(string id)
        //{
        //    var results = await Connect.collection.FindAsync(x => x.categoryId == id);
        //    return await results.SingleAsync();
        //}

        //public async Task Update(Category category)
        //{
        //    await Connect.collection.FindOneAndReplaceAsync(x => x.categoryId == category.categoryId, category);
        //}

        //public async Task Delete(string id)
        //{
        //    await Connect.collection.DeleteOneAsync(x => x.Id == id);
        //}
        public class Category
        {
         
            public string categoryName { get; set; }
            public int categoryId { get; set; }
            // Các thuộc tính khác nếu cần
        }


        public static void Create(string categoryName ,string collectionName)
        {

            Connect.InitializeCollection(collectionName);

            Category category = new()
            {
                categoryName = categoryName
            };
            var sort = Builders<BsonDocument>.Sort.Descending("categoryId");
            var findResult = Connect.collection.Find(_ => true).Sort(sort).Limit(1).ToList();


            foreach (var bsonDocument in findResult)
            {
                category.categoryId = bsonDocument.GetElement("categoryId").Value.AsInt32 + 1;

            }
            var result = category.ToBsonDocument();
            result.Remove("_t");
            Connect.collection.InsertOne(result);
        }

        public static void Read(string collectionName, string FieldName, string qry, DataGridView dataGridView, ListBox listBox)
        {
            try
            {
                // Lấy collection từ cơ sở dữ liệu
                Connect.InitializeCollection(collectionName);

                // Thực hiện truy vấn MongoDB sử dụng biểu thức chính quy
                var filter = Builders<BsonDocument>.Filter.Regex(FieldName, new BsonRegularExpression(qry, "i"));
                var documents = Connect.collection.Find(filter).ToList();

                // Load dữ liệu vào DataGridView
                DataTable dataTable = new DataTable();

                for (int i = 0; i < dataGridView.ColumnCount; ++i)
                {
                    if (dataGridView.Columns[i] is not DataGridViewImageColumn)
                    {
                        dataTable.Columns.Add(new DataColumn(dataGridView.Columns[i].Name));
                        dataGridView.Columns[i].DataPropertyName = dataGridView.Columns[i].Name;
                    }
                }

                for (int i = 0; i < documents.Count; ++i)
                {
                    var row = dataTable.NewRow();
                    row[0] = i + 1;
                    foreach (var element in documents[i])
                    {
                        // Giả sử chỉ lấy giá trị của các phần tử BsonDocument để hiển thị trong DataGridView
                        if (element.Name != "_id")
                            row[element.Name] = element.Value;
                    }
                    dataTable.Rows.Add(row);
                }

                dataGridView.DataSource = dataTable;

                // Đổ dữ liệu vào ListBox
                listBox.Items.Clear();
                foreach (var document in documents)
                {
                    // Giả sử chỉ lấy giá trị của một trường cụ thể để hiển thị trong ListBox
                    string listItem = document.GetValue(FieldName).AsString;
                    listBox.Items.Add(listItem);
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                MessageBox.Show(ex.ToString());
            }
        }

        public static bool Update(Category category, string collectionName)
        {
            try
            {

                Connect.InitializeCollection(collectionName);

                var filter = Builders<BsonDocument>.Filter.Eq("categoryId", category.categoryId);
                var set = Builders<BsonDocument>.Update.Set("categoryName", category.categoryName);

                var updateResult = Connect.collection.UpdateOne(filter, set);

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
        
            public static bool Delete(int categoryId, string collectionName)
        {
            try
            {
                Connect.InitializeCollection(collectionName);
                var filter = Builders<BsonDocument>.Filter.Eq("categoryId", categoryId);
                var delResult = Connect.collection.DeleteOne(filter);

                if (delResult.DeletedCount > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error deleting product: " + e.Message);
                return false;
            }
        }

    }
}

