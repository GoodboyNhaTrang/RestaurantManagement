using Microsoft.VisualBasic.ApplicationServices;
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

namespace Restaurant_Management.View
{
    public partial class frmTableView : SimpleView
    {
        private static string collectionName = "Tables";

        public frmTableView()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            try
            {
                string fieldName = "TableName";
                string qry = $"{txtSearch.Text}"; // Sử dụng chuỗi truy vấn cho biểu thức chính quy
                ListBox lb = new ListBox();
                lb.Items.Clear();
                lb.Items.Add(TableId);
                lb.Items.Add(TableName);
                lb.Items.Add(TableStatus);
                CRUDTable.LoadDataFromMongoDB(collectionName, fieldName, qry, frmTablesView_listTable, lb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmTableView_Load(object sender, EventArgs e)
        {
         
            GetData();
        }

        private void frmTableView_ClientSizeChanged(object sender, EventArgs e)
        {
            frmTablesView_listTable.Width = ClientSize.Width - ClientSize.Width * 5 / 100;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            frmTableAdd frmTableAdd = new frmTableAdd();
            frmTableAdd.ShowDialog();
            GetData();
        }

        private void frmTableView_listTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && frmTablesView_listTable.Columns[e.ColumnIndex].Name == "dgvedit")
            {
                DataGridViewRow selectedRow = frmTablesView_listTable.Rows[e.RowIndex];
                Table editTable = new Table()
                {
                    TableId = Convert.ToInt32(selectedRow.Cells["TableId"].Value.ToString()),
                    TableName = selectedRow.Cells["TableName"].Value.ToString(),
                    TableStatus = selectedRow.Cells["TableStatus"].Value.ToString(),
                };
                frmTableEdit editForm = new frmTableEdit(editTable);
                editForm.ShowDialog();

                // Sau khi chỉnh sửa, cập nhật lại dữ liệu trong DataGridView nếu cần

                GetData();
            }
            else if (e.RowIndex >= 0 && frmTablesView_listTable.Columns[e.ColumnIndex].Name == "dgvDel")
            {
                DialogResult dialogResult = MessageBox.Show("Sure?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = frmTablesView_listTable.Rows[e.RowIndex];
                    CRUDTable.DeleteTable(Convert.ToInt32(selectedRow.Cells["TableId"].Value.ToString()), collectionName);
                }

                GetData();
            }
        }
    }
}
