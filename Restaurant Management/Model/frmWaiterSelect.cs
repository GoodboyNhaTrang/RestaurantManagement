﻿using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management.Model
{
    public partial class frmWaiterSelect : Form
    {

        private string staffNameCollection = "Staff";
        public string waiterName;
        public frmWaiterSelect()
        {
            InitializeComponent();
        }

        private void frmWaiterSelect_Load(object sender, EventArgs e)
        {
            Connect.InitializeCollection(staffNameCollection);
            // Tạo một filter
            var filter = Builders<BsonDocument>.Filter.Eq("Role", "Waiter");
            var documents = Connect.collection.Find(filter).ToList();

            // Tạo DataTable với các cột phù hợp
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("StaffId", typeof(int));
            dataTable.Columns.Add("StaffName", typeof(string));
            foreach (var document in documents)
            {
                DataRow row = dataTable.NewRow();
                row["StaffId"] = document["StaffId"].AsInt32;
                row["StaffName"] = document["StaffName"].AsString;
                dataTable.Rows.Add(row);
            }

            foreach (DataRow row in dataTable.Rows)
            {
                Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                b.Text = row["StaffName"].ToString();
                b.Width = 150;
                b.Height = 50;
                b.FillColor = Color.FromArgb(241, 85, 126);
                b.HoverState.FillColor = Color.FromArgb(50, 55, 89);

                //event 
                b.Click += new EventHandler(b_Click);
                flowLayoutPanel1.Controls.Add(b);
            }
        }
    
        private void b_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button Clicked!");
            waiterName = (sender as Guna.UI2.WinForms.Guna2Button).Text.ToString();
            this.Close();
        }
    }
}
