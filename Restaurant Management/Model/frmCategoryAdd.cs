using Restaurant_Management.CRUD;
using Restaurant_Management.View;
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
    public partial class frmCategoryAdd : SimpleAdd
    {
        private static string collectionName = "Category";

        public frmCategoryAdd()
        {
            InitializeComponent();
        }




        private void frmCategoryAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            if (txtCategoryName.Text == "")
            {
                MessageBox.Show("Điền đủ thông tin giùm");
            }
            else
            {
                CRUDCategory.Create(txtCategoryName.Text, collectionName);
                MessageBox.Show("Create successfully");
              
            }







        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Hide();


        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
