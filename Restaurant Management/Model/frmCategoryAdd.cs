using Restaurant_Management.CRUD;
using Restaurant_Management.View;
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
    public partial class frmCategoryAdd : SimpleAdd
    {
        public frmCategoryAdd()
        {
            InitializeComponent();
        }
        public frmCategoryAdd(string id, string name)
        {
            InitializeComponent();



            // Hiển thị dữ liệu của sản phẩm được chọn trong các control trên form
            txtID.Text = id;
            txtCategoryName.Text = name;
        }



        private void frmCategoryAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string categoryName = txtCategoryName.Text;

            // Gọi hàm để lưu Category mới vào cơ sở dữ liệu
            CRUDCategory.AddNewCategory(ID, categoryName,"Category");

            MessageBox.Show("Created Successfully");

            this.Close();

            frmCategoryView categoryView = new frmCategoryView();
            categoryView.UpdateGridViewData();
     

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
