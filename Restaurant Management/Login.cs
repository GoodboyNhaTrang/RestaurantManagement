using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Restaurant_Management
{

    //public class ConnectDB
    //{
      
    //    public static bool isValidUser(string userName, string userPassword)
    //    {
    //        bool isValid = false;
    //        // Chuỗi kết nối MongoDB

    //        string connectionString = "mongodb+srv://abc123:trungngu123@cluster0.urlminh.mongodb.net/"; // Thay đổi thông tin kết nối tùy theo cấu hình MongoDB của bạn

    //        // Tạo MongoClient để kết nối tới MongoDB
    //        var client = new MongoClient(connectionString);

    //        // Chọn hoặc tạo một database trong MongoDB
    //        var database = client.GetDatabase("RM"); // Thay "mydatabase" bằng tên database bạn muốn sử dụng

    //        // Chọn hoặc tạo một collection trong database
    //        var collection = database.GetCollection<BsonDocument>("User"); // Thay "mycollection" bằng tên collection bạn muốn sử dụng



    //        var filter = Builders<BsonDocument>.Filter.Eq("userName", userName) & Builders<BsonDocument>.Filter.Eq("userPassword", userPassword);
        
    //        var result = collection.Find(filter).FirstOrDefault();
        
    //        if (result != null)
    //        {
    //            isValid = true;
    //           Name = result["Name"].AsString;
             


    //        }
    //        return isValid;

    //        // Tạo một document mới để thêm vào collection
    //        //var document = new BsonDocument
    //        //{
    //        //        { "userID", "1" },
    //        //        { "userName", "Trung" },
    //        //        { "userPassword", "admin" },
    //        //        {"Name", "Trung" },
    //        //        { "Phone", "123-456-7890" }
    //        //    // Thêm các trường và giá trị dữ liệu khác tùy ý
    //        //};

    //        //// Thêm document vào collection
    //        //collection.InsertOne(document);

    //        //Console.WriteLine("Document added to MongoDB.");



    //    }

    //    public static string _name;
    //    public static string Name
    //    {
    //        get { return _name; }  
    //       private set { _name = value; }
    //    }



    //}



    public class Login
{
    public static bool IsValidUser(string userName, string userPassword)
    {
      
        string collectionName = "User";

        CRUDOperations.InitializeCollection( collectionName);
        return CRUDOperations.IsValidUser(userName, userPassword);
    }
}

}
