using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.CRUD;
using static Restaurant_Management.CRUD.CRUDCategory;

namespace Restaurant_Management.Model
{
    public partial class frmCategoryEdit : SimpleAdd
    {
        private static string collectionName = "Category";
        public frmCategoryEdit()
        {
            InitializeComponent();
        }

        public frmCategoryEdit(Category category)
        {
            InitializeComponent();
            catId.Text = category.categoryId.ToString();
            txtEditName.Text = category.categoryName.ToString();
        }
        private void frmCategoryEdit_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Category editedCategory = new()
            {
                categoryId = Convert.ToInt32(catId.Text),
                categoryName = txtEditName.Text

            };
            CRUDCategory.Update(editedCategory, collectionName);
            MessageBox.Show("Edited successfully");

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
