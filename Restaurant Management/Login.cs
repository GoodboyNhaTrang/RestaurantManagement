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
using Restaurant_Management.CRUD;

namespace Restaurant_Management
{

   

   





    public class Login
{
    public static bool IsValidUser(string userName, string userPassword)
    {
      
        string collectionName = "User";

        Connect.InitializeCollection( collectionName);
        return Connect.IsValidUser(userName, userPassword);
    }
}

}
