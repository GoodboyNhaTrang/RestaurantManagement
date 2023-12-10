using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MongoDB.Driver.WriteConcern;

namespace Restaurant_Management.View
{
    public partial class frmKitchenView : Form
    {
        private string billNameCollection = "Bill";
        private string billDetailsNameCollection = "Bill_Details";
        private string productNameCollection = "p";
        public frmKitchenView()
        {
            InitializeComponent();
        }

        private void frmKitchenView_Load(object sender, EventArgs e)
        {
            GetOrders();
        }

        private void GetOrders()
        {

            Connect.InitializeCollection(billNameCollection);
            flowLayoutPanel1.Controls.Clear();
            var filter = Builders<BsonDocument>.Filter.Eq("status", "Pending");
            var documents = Connect.collection.Find(filter).ToList();
            // Create a DataTable to store the data
            DataTable dataTable1 = new DataTable();

            // Add columns to the DataTable based on the fields in the MongoDB documents
            foreach (var element in documents.First().Elements)
            {
                if (element.Name != "_id") // Exclude the "_id" field if present
                {
                    dataTable1.Columns.Add(new DataColumn(element.Name, typeof(string)));
                }
            }

            // Add rows to the DataTable with data from the MongoDB documents
            foreach (var document in documents)
            {
                DataRow row = dataTable1.NewRow();
                foreach (var element in document.Elements)
                {
                    if (element.Name != "_id") // Exclude the "_id" field if present
                    {
                        row[element.Name] = element.Value.ToString();
                    }
                }
                dataTable1.Rows.Add(row);
            }



            FlowLayoutPanel p1;
            for (int i = 0; i < dataTable1.Rows.Count; i++)
            {
                p1 = new FlowLayoutPanel();
                p1.AutoSize = true;
                p1.Width = 230;
                p1.Height = 350;
                p1.FlowDirection = FlowDirection.TopDown;
                p1.BorderStyle = BorderStyle.FixedSingle;
                p1.Margin = new Padding(10, 10, 10, 10);

                FlowLayoutPanel p2 = new FlowLayoutPanel();
                p2.BackColor = Color.FromArgb(50, 55, 89);
                p2.AutoSize = true;
                p2.Width = 230;
                p2.Width = 125;
                p2.FlowDirection = FlowDirection.TopDown;
                p2.Margin = new Padding(0, 0, 0, 0);

                Label lb1 = new Label();
                lb1.AutoSize = true;
                lb1.ForeColor = Color.White;
                lb1.Margin = new Padding(10, 10, 3, 0);

                Label lb2 = new Label();
                lb2.AutoSize = true;
                lb2.ForeColor = Color.White;
                lb2.Margin = new Padding(10, 5, 3, 0);

                Label lb3 = new Label();
                lb3.AutoSize = true;
                lb3.ForeColor = Color.White;
                lb3.Margin = new Padding(10, 5, 3, 0);

                Label lb4 = new Label();
                lb4.AutoSize = true;
                lb4.ForeColor = Color.White;
                lb4.Margin = new Padding(10, 5, 3, 10);

                lb1.Text = "Table: " + dataTable1.Rows[i]["TableName"].ToString();
                lb2.Text = "Waiter Name : " + dataTable1.Rows[i]["WaiterName"].ToString();
                lb3.Text = "Order Time : " + dataTable1.Rows[i]["aTime"].ToString();
                lb4.Text = "Order Type: " + dataTable1.Rows[i]["orderType"].ToString();

                p2.Controls.Add(lb1);
                p2.Controls.Add(lb2);
                p2.Controls.Add(lb3);
                p2.Controls.Add(lb4);


                p1.Controls.Add(p2);


                //Add product
                int mid = 0;
                mid = Convert.ToInt32(dataTable1.Rows[i]["billId"].ToString());

                Connect.InitializeCollection(billDetailsNameCollection);

                var filter2 = Builders<BsonDocument>.Filter.Eq("billId", mid);
                var documents2 = Connect.collection.Find(filter2).ToList();

                // Create a DataTable to store the data
                DataTable dataTable2 = new DataTable();

                dataTable2.Columns.Add("billDetailId");
                dataTable2.Columns.Add("productId");
                dataTable2.Columns.Add("productName");
                dataTable2.Columns.Add("quantity");
                Connect.InitializeCollection(productNameCollection);
                foreach (var document in documents2)
                {
                    DataRow row = dataTable2.NewRow();
                    row["billDetailId"] = document["billDetailId"].AsInt32;
                    row["productId"] = document["productId"].AsInt32;


                    row["quantity"] = document["quantity"].AsInt32;


                    var filter3 = Builders<BsonDocument>.Filter.Empty;
                    var documents3 = Connect.collection.Find(filter3).ToList();
                    foreach (var item in documents3)
                    {
                        if (item["productId"].AsInt32 == document["productId"].AsInt32)
                        {
                            row["productName"] = item["productName"].AsString;

                        }
                    }
                    dataTable2.Rows.Add(row);
                }
                //Console.WriteLine("Số dòng trong DataTable: " + dataTable2.Rows.Count);


                for (int j = 0; j < dataTable2.Rows.Count; j++)
                {
                    Label lb5 = new Label();
                    lb5.ForeColor = Color.Black;
                    lb5.Margin = new Padding(10, 5, 3, 0);
                    lb5.AutoSize = true;

                    int no = j + 1;

                    lb5.Text = "" + no + " " + dataTable2.Rows[j]["productName"].ToString() + " " + dataTable2.Rows[j]["quantity"].ToString();


                    p1.Controls.Add(lb5);
                }

                Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                b.Text = "Complete";
                b.AutoRoundedCorners = true;
                b.Size = new Size(100, 35);
                b.FillColor = Color.FromArgb(241, 85, 126);
                b.Margin = new Padding(30, 5, 3, 10);
                b.Tag = dataTable1.Rows[i]["billId"];

                b.Click += new EventHandler(b_click);
                p1.Controls.Add(b);

                flowLayoutPanel1.Controls.Add(p1);

            }
        }

        private void b_click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Guna.UI2.WinForms.Guna2Button).Tag.ToString());

            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            if(guna2MessageDialog1.Show("Are you sure ?") == DialogResult.Yes)
            {
                Connect.InitializeCollection(billNameCollection);
                var filter = Builders<BsonDocument>.Filter.Eq("billId", id);

                // Xây dựng các thay đổi cần áp dụng
                var update = Builders<BsonDocument>.Update.Set("status", "Complete");
                Connect.collection.UpdateOne(filter, update);
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Show("Saved Successfully!");

                GetOrders();
            }
        }
    }
}
