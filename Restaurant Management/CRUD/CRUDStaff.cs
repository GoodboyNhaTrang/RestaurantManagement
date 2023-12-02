using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.CRUD
{
    public class Staff
    {
        public ObjectId Id { get; set; }
        public string StaffId { get; set; }
        public string StaffName { get; set; }
        public string Role { get; set; }
        public int Salary { get; set; }
    }

    internal class CRUDStaff
    {
        public static void AddNewStaff(string StaffName, string Role, string Salary, string collectionName)
        {

            Connect.InitializeCollection(collectionName);

            Staff staff = new()
            {
                StaffName = StaffName,
                Role = Role,
                Salary = Convert.ToInt32(Salary),
            };
            var sort = Builders<BsonDocument>.Sort.Descending("StaffId");
            var id = Connect.collection.Find(_ => true).Sort(sort).Limit(1).ToList();

            foreach (var item in id)
            {
                staff.StaffId = item.GetElement("StaffId").ToString() + 1;
            }
            var result = staff.ToBsonDocument();
            result.Remove("_t");
            Connect.collection.InsertOne(result);
        }
        public static void LoadDataFromMongoDB(string collectionName, string FieldName, string qry, DataGridView dataGridView, ListBox listBox)
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
                    row[0] = i;
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
    }
}
