using Restaurant_Management.CRUD;
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

namespace Restaurant_Management.Model
{
    public partial class frmTableAdd : SimpleAdd
    {
        private static string collectionName = "Tables";
        public frmTableAdd()
        {
            InitializeComponent();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (frmTableAdd_txtName.Text == "")
            {
                frmTableAdd_messageDialog.Show("Điền đủ thông tin giùm");
            }
            else
            {
                MessageBox.Show("Add thành công!");
                CRUDTable.AddNewTable(frmTableAdd_txtName.Text, collectionName);
            }
        }
    }
}
