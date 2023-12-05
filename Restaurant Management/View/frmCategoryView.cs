using Restaurant_Management.CRUD;
using Restaurant_Management.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Restaurant_Management.CRUD.CRUDCategory;

namespace Restaurant_Management.View
{
    public partial class frmCategoryView : SimpleView
    {
        public frmCategoryView()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {

        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && guna2DataGridView1.Columns[e.ColumnIndex].Name == "dgvedit")
            {
                DataGridViewRow selectedRow = guna2DataGridView1.Rows[e.RowIndex];
                string editID = selectedRow.Cells["dgvid"].Value.ToString();
                string editName = selectedRow.Cells["dgvName"].Value.ToString();

                frmCategoryEdit editForm = new frmCategoryEdit(editID, editName);
                editForm.ShowDialog();

                // Sau khi chỉnh sửa, cập nhật lại dữ liệu trong DataGridView nếu cần
          
                UpdateGridViewData();
            }

            if (e.RowIndex >= 0 && guna2DataGridView1.Columns[e.ColumnIndex].Name == "dgvDel")
            {
                DataGridViewRow selectedRow = guna2DataGridView1.Rows[e.RowIndex];
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    string productIdToDelete = selectedRow.Cells["dgvid"].Value.ToString(); // Lấy ID của sản phẩm cần xóa từ cột "dgvid"
                    bool isDeleted = CRUDCategory.DeleteCategory(productIdToDelete,"Category");

                    if (isDeleted)
                    {
                        MessageBox.Show("Xóa sản phẩm thành công.");
                        // Sau khi xóa, cập nhật lại DataGridView hoặc load lại dữ liệu
                        UpdateGridViewData(); // Gọi hàm để tải lại dữ liệu vào DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Xóa sản phẩm thất bại.");
                    }
                }

            }


        }
        public void UpdateGridViewData()
        {
            guna2DataGridView1.Rows.Clear();

            List<Category> categories = GetAllCategories("Category");

            foreach (Category category in categories)
            {
                int rowIndex = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[rowIndex].Cells["dgvid"].Value = category.Id;
                guna2DataGridView1.Rows[rowIndex].Cells["dgvName"].Value = category.CategoryName;
            }
        }


        public void frmCategoryView_Load(object sender, EventArgs e)
        {


            // Xác định cột cho DataGridView (nếu chưa được xác định)


            // Gọi hàm GetAllCategories để lấy danh sách các Category từ cơ sở dữ liệu
            UpdateGridViewData();

             

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            this.Hide();
           frmCategoryAdd frm = new frmCategoryAdd();
            frm.Show();

        }






    }
}
