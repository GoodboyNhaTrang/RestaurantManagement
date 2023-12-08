using Restaurant_Management.CRUD;
using Restaurant_Management.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Restaurant_Management.View
{
    public partial class frmProductView : SimpleView
    {
        private static string collectionName = "Product";
        public frmProductView()
        {
            InitializeComponent();
        }


        public void GetData()
        {
            try
            {
                string fieldName = "productName";
                string qry = $"{txtSearch.Text}"; // Sử dụng chuỗi truy vấn cho biểu thức chính quy
                ListBox lb = new ListBox();
                lb.Items.Clear();
                lb.Items.Add(_id);
                lb.Items.Add(productId);

                lb.Items.Add(productName);
                lb.Items.Add(categoryName);
                lb.Items.Add(productPrice);

                CRUDProduct.Read(collectionName, fieldName, qry, frmProductView_listTable, lb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void frmProductView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            frmProductAdd frm = new frmProductAdd();
            frm.Show();
        }

        private void frmProductView_listTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && frmProductView_listTable.Columns[e.ColumnIndex].Name == "dgvedit")
            {
                DataGridViewRow selectedRow = frmProductView_listTable.Rows[e.RowIndex];
                Product editProduct = new Product()
                {
                    productId = Convert.ToInt32(selectedRow.Cells["productId"].Value.ToString()),
                    categoryId = Convert.ToInt32(selectedRow.Cells["categoryId"].Value.ToString()),

                    productPrice = Convert.ToInt32(selectedRow.Cells["productPrice"].Value.ToString()),
                    productName = selectedRow.Cells["productName"].Value.ToString(),
                    categoryName = selectedRow.Cells["categoryName"].Value.ToString(),


                };
                frmProductEdit editForm = new frmProductEdit(editProduct);
                editForm.ShowDialog();

                // Sau khi chỉnh sửa, cập nhật lại dữ liệu trong DataGridView nếu cần

                GetData();
            }

            else if (e.RowIndex >= 0 && frmProductView_listTable.Columns[e.ColumnIndex].Name == "dgvDel")
            {
                DialogResult dialogResult = MessageBox.Show("Sure?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = frmProductView_listTable.Rows[e.RowIndex];
                    CRUDProduct.Delete(Convert.ToInt32(selectedRow.Cells["productId"].Value.ToString()), collectionName);
                }

                GetData();
            }

        }

        

        private void frmProductView_listTable_ClientSizeChanged(object sender, EventArgs e)
        {
            frmProductView_listTable.Width = ClientSize.Width - ClientSize.Width * 5 / 100; ;
            frmProductView_listTable.Height = ClientSize.Height - frmProductView_listTable.Location.Y;
        }
    }
}
