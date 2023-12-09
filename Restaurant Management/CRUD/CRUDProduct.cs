using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Libmongocrypt;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.CRUD
{
    public class Product
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public int categoryId { get; set; }
        public string categoryName { get; set; }

        public int productPrice { get; set; }
        public Binary productImage { get; set; }

        // Các thuộc tính khác nếu cần
    }

    internal class CRUDProduct
    {
       

        public static void Create(Product product, string collectionName)
        {

            Connect.InitializeCollection(collectionName);

             product = new()
            {
                productId = product.productId,
                 productName = product.productName,
   
                 productPrice = product.productPrice,
                 categoryId = product.categoryId,
                 categoryName = product.categoryName,
             };
            var sort = Builders<BsonDocument>.Sort.Descending("productId");
            var findResult = Connect.collection.Find(_ => true).Sort(sort).Limit(1).ToList();


            foreach (var bsonDocument in findResult)
            {
                product.productId = bsonDocument.GetElement("productId").Value.AsInt32 + 1;

            }
            var result = product.ToBsonDocument();
            result.Remove("_t");
            Connect.collection.InsertOne(result);
        }

        public static List<BsonDocument> Read(string collectionName, string FieldName, string qry)
        {
            // Lấy collection từ cơ sở dữ liệu
            Connect.InitializeCollection(collectionName);

            // Thực hiện truy vấn MongoDB sử dụng biểu thức chính quy
            var filter = Builders<BsonDocument>.Filter.Regex(FieldName, new BsonRegularExpression(qry, "i"));
            var documents = Connect.collection.Find(filter).ToList();

            return documents;
        }
        public static void loadItemsToDataGridView(string collectionName, string FieldName, string qry, DataGridView dataGridView, ListBox listBox)
        {
            try
            {
                var documents = Read(collectionName, FieldName, qry);


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
        public static bool Update(Product product, string collectionName)
        {
            try
            {

                Connect.InitializeCollection(collectionName);

                var filter = Builders<BsonDocument>.Filter.Eq("productId", product.productId);
                var set = Builders<BsonDocument>.Update.Set("productName", product.productName).Set("productPrice", product.productPrice)
                    .Set("categoryName", product.categoryName).Set("categoryId", product.categoryId);

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


        public static bool Delete(int productId, string collectionName)
        {
            try
            {
                Connect.InitializeCollection(collectionName);
                var filter = Builders<BsonDocument>.Filter.Eq("productId", productId);
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
