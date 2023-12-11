using MongoDB.Bson;
using Restaurant_Management.CRUD;
using System;
using System.Collections;
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
    public partial class frmProductAdd : SimpleAdd
    {
        private static string collectionName = "Product";
        private static Image defaultImage;
        public frmProductAdd()
        {
            InitializeComponent();
            defaultImage = txtImage.Image;
        }

        private void frmProductAdd_Load(object sender, EventArgs e)
        {
            LoadCategoriesToComboBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void LoadCategoriesToComboBox()
        {
            // Gọi phương thức Read của CRUDCategory để lấy danh sách các category
            List<Category> categories = CRUDCategory.GetAllCategories("Category");

            // Xóa các mục hiện tại trong ComboBox
            cbProduct.Items.Clear();

            // Duyệt qua danh sách category và thêm từng category vào ComboBox
            foreach (var category in categories)
            {
                cbProduct.Items.Add(category.categoryName);
            }
        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProduct.Text = cbProduct.SelectedIndex.ToString();
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
        string filePath;
        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Chỉ cho phép người dùng chọn file hình ảnh
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp; *.jfif)|*.jpg; *.jpeg; *.png; *.gif; *.bmp; *.jfif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của file hình ảnh đã chọn
                string selectedImagePath = openFileDialog.FileName;

                // Hiển thị hình ảnh trong PictureBox
                txtImage.Image = new Bitmap(selectedImagePath);
            }
        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (txtImage.Image == (defaultImage))
                MessageBox.Show("Vui lòng chọn hình ảnh");
            else
            {
                List<BsonDocument> category = CRUDCategory.Read("categoryName", cbProduct.Text);

                Product product = new()
                {
                    //productId = Convert.ToInt32(txtProductId.Text),
                    productName = txtProductName.Text,
                    productPrice = Convert.ToInt32(txtPrice.Text),
                    categoryName = cbProduct.Text,
                    categoryId = category[0].GetElement("categoryId").Value.ToInt32() + 1,
            };

                CRUDProduct.Create(product, collectionName);
                MessageBox.Show("Create successfully");
            }

        }


        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
