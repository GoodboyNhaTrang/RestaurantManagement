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
    public partial class frmStaffEdit : SimpleAdd
    {
        public frmStaffEdit()
        {
            InitializeComponent();
        }
        string collectionName = "Staff";
        public frmStaffEdit(Staff staff)
        {
            InitializeComponent();
            StaffId.Text = staff.StaffId.ToString();
            txtStaffName.Text = staff.StaffName.ToString();
            txtStaffRole.Text = staff.Role.ToString();
            txtStaffSalary.Text = staff.Salary.ToString();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Staff editedStaff = new()
            {
                StaffId = Convert.ToInt32(StaffId.Text),
                StaffName = txtStaffName.Text,
                Role = txtStaffRole.Text,
                Salary = Convert.ToInt32(txtStaffSalary.Text)
            };
            CRUDStaff.UpdateStaff(editedStaff, collectionName);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStaffEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
