using Microsoft.VisualBasic.ApplicationServices;
using MongoDB.Driver;
using Restaurant_Management.CRUD;
using Restaurant_Management.Model;
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
using static Restaurant_Management.CRUD.CRUDCategory;

namespace Restaurant_Management.View
{
    public partial class frmCategoryView : SimpleView
    {

        private static string collectionName = "Category";
        public frmCategoryView()
        {
            InitializeComponent();
        }


        public void GetData()
        {
            try
            {
                string fieldName = "categoryName";
                string qry = $"{txtSearch.Text}"; // Sử dụng chuỗi truy vấn cho biểu thức chính quy
                ListBox lb = new ListBox();
                lb.Items.Clear();
                lb.Items.Add(_id);
                lb.Items.Add(categoryId);

                lb.Items.Add(categoryName);

                loadItemToDataGridView(fieldName, qry, frmCategoryView_listTable, lb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
            if (e.RowIndex >= 0 && frmCategoryView_listTable.Columns[e.ColumnIndex].Name == "dgvedit")
            {
                DataGridViewRow selectedRow = frmCategoryView_listTable.Rows[e.RowIndex];
                Category editCategory = new Category()
                {
                    categoryId = Convert.ToInt32(selectedRow.Cells["categoryId"].Value.ToString()),
                    categoryName = selectedRow.Cells["categoryName"].Value.ToString(),

                };
                frmCategoryEdit editForm = new frmCategoryEdit(editCategory);
                editForm.ShowDialog();

                // Sau khi chỉnh sửa, cập nhật lại dữ liệu trong DataGridView nếu cần

                GetData();
            }

            else if (e.RowIndex >= 0 && frmCategoryView_listTable.Columns[e.ColumnIndex].Name == "dgvDel")
            {
                DialogResult dialogResult = MessageBox.Show("Sure?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = frmCategoryView_listTable.Rows[e.RowIndex];
                    CRUDCategory.Delete(Convert.ToInt32(selectedRow.Cells["categoryId"].Value.ToString()), collectionName);
                }

                GetData();
            }


        }



        public void frmCategoryView_Load(object sender, EventArgs e)
        {
            GetData();


        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

            frmCategoryAdd frm = new frmCategoryAdd();
            frm.Show();

        }

        private void frmCategoryView_ClientSizeChanged(object sender, EventArgs e)
        {

            frmCategoryView_listTable.Width = ClientSize.Width - ClientSize.Width * 5 / 100; ;
            frmCategoryView_listTable.Height = ClientSize.Height - frmCategoryView_listTable.Location.Y;


        }
    }
}
