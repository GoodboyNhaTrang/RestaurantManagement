using MongoDB.Bson;
using Restaurant_Management.CRUD;
using Restaurant_Management.Model;
using Restaurant_Management.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Restaurant_Management.CRUD.CRUDProduct;



namespace Restaurant_Management.Model
{
    public partial class frmProductEdit : SimpleAdd
    {
        private int productID;
        private string catName;
        public frmProductEdit()
        {
            InitializeComponent();
        }
        string collectionName = "Product";

        public frmProductEdit(Product product)
        {
            InitializeComponent();
            productID = product.productId;
            txtProductName.Text = product.productName.ToString();
            txtPrice.Text = product.productPrice.ToString();
            catName = product.categoryName.ToString();
            Debug.WriteLine(product.productImage);
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
            cbProduct.SelectedIndex = cbProduct.FindStringExact(catName);
        }

        private void frmProductEdit_Load(object sender, EventArgs e)
        {

            LoadCategoriesToComboBox();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }

        private void txtImage_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbEditProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEditProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_2(object sender, EventArgs e)
        {
            List<BsonDocument> docs = CRUDCategory.Read("categoryName", cbProduct.Text);

            int catId = 0;
            catId = docs[0].GetElement("categoryId").Value.ToInt32();

            byte[] imageData = ImageToByteArray(txtImage.Image);
            BsonBinaryData bsonImageData = new BsonBinaryData(imageData);
            Product product = new()
            {
                productId = productID,
                productName = txtProductName.Text,
                productPrice = Convert.ToInt32(txtPrice.Text),
                categoryName = cbProduct.Text,
                categoryId = catId,
                productImage = bsonImageData,
            };

            CRUDProduct.Update(product, collectionName);
            MessageBox.Show("Edited successfully");
        }

        private void btnClose_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProduct.Text = cbProduct.SelectedIndex.ToString();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

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
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
