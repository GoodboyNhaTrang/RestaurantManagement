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
            frmStaffView_listTable.Width = ClientSize.Width - ClientSize.Width * 5 / 100;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            frmStaffAdd frmStaffAdd = new frmStaffAdd();
            frmStaffAdd.ShowDialog();
            GetData();
        }
    }
}
