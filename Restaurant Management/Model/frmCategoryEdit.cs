using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Restaurant_Management.CRUDOperations;

namespace Restaurant_Management.Model
{
    public partial class frmCategoryEdit : SimpleAdd
    {
        public frmCategoryEdit()
        {
            InitializeComponent();
        }
        public frmCategoryEdit(string id, string name)
        {
            InitializeComponent();
            txtEditID.Text = id;
            txtEditName.Text = name;
        }

        private void frmCategoryEdit_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string editedID = txtEditID.Text; // Lấy ID từ TextBox txtID
            string editedName = txtEditName.Text; // Lấy Name từ TextBox txtCategoryName

            // Thực hiện logic cập nhật dữ liệu trong cơ sở dữ liệu MongoDB
            bool updateSuccess = CRUDOperations.UpdateCategory(editedID, editedName);

            if (updateSuccess)
            {
                // Cập nhật dữ liệu thành công, thông báo và cập nhật DataGridView
                MessageBox.Show("Category updated successfully!");


                this.Close(); // Đóng form sau khi cập nhật
            }
            else
            {
                MessageBox.Show("Failed to update category. Please try again!");
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
