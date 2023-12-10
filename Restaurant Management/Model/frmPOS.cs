using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Libmongocrypt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Restaurant_Management.Model
{
    public partial class frmPOS : Form
    {
        private string categoryNameCollection = "Category";
        private string productNameCollection = "p";
        private string billNameCollection = "Bill";
        private string billDetailNameCollection = "Bill_Details";
        public int MainID = 0;
        public string OrderType;



        public frmPOS()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            frmPOS_listTable.BorderStyle = BorderStyle.FixedSingle;
            AddCategory();
            ProductPanel.Controls.Clear();
            LoadProduct();
        }

        private void frmStaffView_listTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void AddCategory()
        {
            Connect.InitializeCollection(categoryNameCollection);
            var filter = Builders<BsonDocument>.Filter.Empty;
            var documents = Connect.collection.Find(filter).ToList();


            // Tạo DataTable với các cột phù hợp
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("categoryName"); // Thêm cột CategoryName hoặc thêm các cột khác nếu cần
            foreach (var document in documents)
            {
                DataRow row = dataTable.NewRow();
                row["categoryName"] = document["categoryName"].AsString;
                dataTable.Rows.Add(row);
            }

            CategoryPanel.Controls.Clear();
            Guna.UI2.WinForms.Guna2Button b2 = new Guna.UI2.WinForms.Guna2Button();
            b2.FillColor = Color.FromArgb(50, 55, 89);
            b2.Size = new Size(134, 45);
            b2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            b2.Text = "All Categories";
            b2.CheckedState.FillColor = Color.FromArgb(241, 85, 126);
            b2.Click += new EventHandler(b_Click);

            CategoryPanel.Controls.Add(b2);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                    b.FillColor = Color.FromArgb(50, 55, 89);
                    b.Size = new Size(134, 45);
                    b.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    b.Text = row["categoryName"].ToString();


                    //event 
                    b.Click += new EventHandler(b_Click);

                    CategoryPanel.Controls.Add(b);
                }
            }

        }

        private void b_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;
            if (b.Text == "All Categories")
            {
                txtSearch.Text = "1";
                txtSearch.Text = "";
                return;
            }

            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PCategory.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }

        private void AddItems(string id, string proID, string name, string cat, string price, Image pimage)
        {
            //Tạo UserControl và Thiết Lập Thuộc Tính:
            var ucproduct = new ucProduct()
            {
                PName = name,
                PPrice = price,
                PCategory = cat,
                PImage = pimage,
                id = Convert.ToInt32(proID)
            };
            //Thêm UserControl vào Panel:
            ProductPanel.Controls.Add(ucproduct);

            //Xử lý Sự Kiện onSelect của UserControl:
            //ss: Đại diện cho đối tượng gửi sự kiện 
            ucproduct.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;

                bool itemExists = false;


                foreach (DataGridViewRow item in frmPOS_listTable.Rows)
                {
                    if (Convert.ToInt32(item.Cells["dgvproID"].Value) == wdg.id)
                    {
                        int currentQty;
                        if (item.Cells["dgvQty"].Value != null && int.TryParse(item.Cells["dgvQty"].Value.ToString(), out currentQty))
                        {
                            // Tăng giá trị Quantity và cập nhật Amount
                            currentQty += 1;
                            item.Cells["dgvQty"].Value = currentQty;

                            double price;
                            if (item.Cells["dgvPrice"].Value != null && double.TryParse(item.Cells["dgvPrice"].Value.ToString(), out price))
                            {
                                item.Cells["dgvAmount"].Value = currentQty * price;
                            }


                            itemExists = true;
                            break;
                        }
                    }
                }
                // Nếu hàng chưa tồn tại, thêm hàng mới
                if (!itemExists)
                {
                    frmPOS_listTable.Rows.Add(new object[] { 0, 0, wdg.id, wdg.PName, 1, wdg.PPrice, wdg.PPrice });
                }
                GetTotal();
            };
        }

        private void LoadProduct()
        {
            //Khởi tạo Kết nối và Lọc:
            Connect.InitializeCollection(productNameCollection);
            // Tạo một bộ lọc để tìm kiếm categoryId
            var filter = Builders<BsonDocument>.Filter.Empty;
            var documents = Connect.collection.Find(filter).ToList();

            //Khởi tạo DataTable:
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("productId", typeof(int));
            dataTable.Columns.Add("productName", typeof(string));
            dataTable.Columns.Add("productPrice", typeof(int));
            dataTable.Columns.Add("categoryId", typeof(int));
            dataTable.Columns.Add("categoryName", typeof(string));
            dataTable.Columns.Add("productImage", typeof(byte[])); // Sửa thành kiểu dữ liệu byte[]

            //Đổ dữ liệu vào DataTable:
            foreach (var document in documents)
            {
                // Chuyển đổi BsonBinaryData thành mảng byte[]
                byte[] imageBytes = document["productImage"].AsBsonBinaryData.Bytes;

                dataTable.Rows.Add(
                    document["productId"].AsInt32,
                    document["productName"].AsString,
                    document["productPrice"].AsInt32,
                    document["categoryId"].AsInt32,
                    document["categoryName"].AsString,
                    imageBytes
                );
            }
            //Hiển thị dữ liệu và hình ảnh:
            foreach (DataRow item in dataTable.Rows)
            {
                AddItems("0", item["productId"].ToString(), item["productName"].ToString(), item["categoryName"].ToString(),
                    item["productPrice"].ToString(), Image.FromStream(new MemoryStream((byte[])item["productImage"])));
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PName.ToLower().Contains(txtSearch.Text.Trim().ToLower());
            }
        }

        private void frmPOS_listTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in frmPOS_listTable.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void GetTotal()
        {
            double total = 0;
            lblTotal.Text = "";
            foreach (DataGridViewRow item in frmPOS_listTable.Rows)
            {
                total += double.Parse(item.Cells["dgvAmount"].Value.ToString());
            }

            lblTotal.Text = total.ToString("N2");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            frmPOS_listTable.Rows.Clear();
            MainID = 0;
            lblTotal.Text = "00";
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            OrderType = "Delivery";
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            OrderType = "Take Away";
        }

        private void btnDin_Click(object sender, EventArgs e)
        {
            OrderType = "Din in";
            frmWaiterSelect frm2 = new frmWaiterSelect();
            frm2.FormClosed += Frm2_FormClosed; // Thêm sự kiện FormClosed
            frm2.Show();

            frmTableSelect frm = new frmTableSelect();
            frm.FormClosed += Frm_FormClosed; // Thêm sự kiện FormClosed
            frm.Show();
        }

        private void Frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmWaiterSelect frm2 = (frmWaiterSelect)sender;
            if (frm2.waiterName != "")
            {
                lblWaiter.Text = frm2.waiterName;
                lblWaiter.Visible = true;
            }
            else
            {
                lblWaiter.Text = "";
                lblWaiter.Visible = false;
            }
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmTableSelect frm2 = (frmTableSelect)sender;
            if (frm2.TableName != "")
            {
                lblTable.Text = frm2.TableName;
                lblTable.Visible = true;
            }
            else
            {
                lblTable.Text = "";
                lblTable.Visible = false;
            }
        }

        private void btnKot_Click(object sender, EventArgs e)
        {
            int detailID = 0;
            Connect.InitializeCollection(billNameCollection);

            if (MainID == 0)
            {
                var filter = Builders<BsonDocument>.Filter.Empty; // Lọc tất cả các tài liệu
                MainID = Convert.ToInt32(Connect.collection.CountDocuments(filter)) + 1;


                var document = new BsonDocument
                {
                    { "billId", MainID},
                    { "aDate", Convert.ToDateTime(DateTime.Now.Date )},
                    { "aTime", DateTime.Now.ToLongTimeString() },
                    { "TableName", lblTable.Text},
                    { "WaiterName", lblWaiter.Text },
                    { "status", "Pending" },
                    { "orderType", OrderType},
                    { "total", Convert.ToDouble(lblTotal.Text)},
                    { "received", Convert.ToDouble(0) },
                    { "change",Convert.ToDouble(0) }
                };

                Connect.collection.InsertOne(document);
            }
            else
            {
                var filter = Builders<BsonDocument>.Filter.Eq("billId", MainID);
                var update = Builders<BsonDocument>.Update.Set("status", "Pending").Set("total", Convert.ToDouble(lblTotal.Text)).Set("received", Convert.ToDouble(0)).Set("change", Convert.ToDouble(0));
                Connect.collection.UpdateOne(filter, update);
            }


            foreach (DataGridViewRow row in frmPOS_listTable.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);
                Connect.InitializeCollection(billDetailNameCollection);
                if (detailID == 0)
                {
                    var sort = Builders<BsonDocument>.Sort.Descending("billDetailId");
                    var findResult = Connect.collection.Find(_ => true).Sort(sort).Limit(1).ToList();

                    foreach (var bsonDocument in findResult)
                    {
                        detailID = bsonDocument.GetElement("billDetailId").Value.AsInt32 + 1;
                    }

                    // Gán giá trị mới cho cột "dgvid" trong DataGridView
                    row.Cells["dgvid"].Value = detailID;

                    var document = new BsonDocument
                    {
                        { "billDetailId", detailID},
                        { "billId", MainID},
                        { "productId", Convert.ToInt32(row.Cells["dgvproID"].Value) },
                        { "quantity", Convert.ToInt32(row.Cells["dgvQty"].Value) },
                        { "price", Convert.ToDouble(row.Cells["dgvPrice"].Value) },
                        { "amount", Convert.ToDouble(row.Cells["dgvAmount"].Value)}
                    };
                    Connect.collection.InsertOne(document);
                }
                else
                {
                    var filter = Builders<BsonDocument>.Filter.Eq("billDetailId", detailID);
                    var update = Builders<BsonDocument>.Update.Set("productId", Convert.ToInt32(row.Cells["dgvproID"].Value))
                        .Set("quantity", Convert.ToInt32(row.Cells["dgvQty"].Value))
                        .Set("price", Convert.ToDouble(row.Cells["dgvPrice"].Value))
                        .Set("amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));
                    Connect.collection.UpdateOne(filter, update);
                }

            }


            frmPOS_listTable.Rows.Clear();
            guna2MessageDialog1.Show("Saved Successfully!");
            MainID = 0;
            detailID = 0;
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            lblTotal.Text = "00";

        }

        private void btnBill_Click(object sender, EventArgs e)
        {

        }
    }
}
