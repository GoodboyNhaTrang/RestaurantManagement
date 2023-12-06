using Guna.UI2.WinForms;
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

namespace Restaurant_Management.View
{
    public partial class frmStaffView : SimpleView
    {
        private static string collectionName = "Staff";
        public frmStaffView()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            try
            {
                string fieldName = "StaffName";
                string qry = $"{txtSearch.Text}"; // Sử dụng chuỗi truy vấn cho biểu thức chính quy
                ListBox lb = new ListBox();
                lb.Items.Clear();
                lb.Items.Add(StaffId);
                lb.Items.Add(UserId);
                lb.Items.Add(StaffName);
                lb.Items.Add(Role);
                lb.Items.Add(Salary);
                CRUDStaff.LoadDataFromMongoDB(collectionName, fieldName, qry, frmStaffView_listTable, lb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmStaffView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void frmStaffView_ClientSizeChanged(object sender, EventArgs e)
        {
            frmStaffView_listTable.Width = ClientSize.Width - ClientSize.Width * 5 / 100; ;
            frmStaffView_listTable.Height = ClientSize.Height - frmStaffView_listTable.Location.Y;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            frmStaffAdd frmStaffAdd = new frmStaffAdd();
            frmStaffAdd.ShowDialog();
            GetData();
        }

        private void frmStaffView_listTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && frmStaffView_listTable.Columns[e.ColumnIndex].Name == "dgvedit")
            {
                DataGridViewRow selectedRow = frmStaffView_listTable.Rows[e.RowIndex];
                Staff editStaff = new Staff()
                {
                    StaffId = Convert.ToInt32(selectedRow.Cells["StaffId"].Value.ToString()),
                    StaffName = selectedRow.Cells["StaffName"].Value.ToString(),
                    Role = selectedRow.Cells["Role"].Value.ToString(),
                    Salary = Convert.ToInt32(selectedRow.Cells["Salary"].Value.ToString()),
                };
                frmStaffEdit editForm = new frmStaffEdit(editStaff);
                editForm.ShowDialog();

                // Sau khi chỉnh sửa, cập nhật lại dữ liệu trong DataGridView nếu cần

                GetData();
            }
            else if (e.RowIndex >= 0 && frmStaffView_listTable.Columns[e.ColumnIndex].Name == "dgvDel")
            {
                DialogResult dialogResult = MessageBox.Show("Sure?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = frmStaffView_listTable.Rows[e.RowIndex];
                    CRUDStaff.DeleteStaff(Convert.ToInt32(selectedRow.Cells["StaffId"].Value.ToString()), collectionName);
                }

                GetData();
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
