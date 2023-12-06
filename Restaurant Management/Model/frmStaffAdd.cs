using MongoDB.Bson;
using Restaurant_Management.CRUD;
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
    public partial class frmStaffAdd : SimpleAdd
    {
        private static string collectionName = "Staff";
        public frmStaffAdd()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (frmStaffAdd_txtName.Text == "" || frmStaffAdd_txtRole.Text == "" || frmStaffAdd_txtSalary.Text == "")
            {
                frmStaffAdd_messageDialog.Show("Điền đủ thông tin giùm");
            }
            else
            {
                CRUDStaff.AddNewStaff(frmStaffAdd_txtName.Text, frmStaffAdd_txtRole.Text, frmStaffAdd_txtSalary.Text, collectionName);
                MessageBox.Show("created successf");
            }
        }

        private void frmStaffAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
