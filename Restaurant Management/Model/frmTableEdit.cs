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
    public partial class frmTableEdit : SimpleAdd
    {
        public frmTableEdit()
        {
            InitializeComponent();
        }
        string collectionName = "Tables";
        public frmTableEdit(Table table)
        {
            InitializeComponent();
            TableId.Text = table.TableId.ToString();
            txtTableName.Text = table.TableName.ToString();
            
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Table editedTable = new()
            {
                TableId = Convert.ToInt32(TableId.Text),
                TableName = txtTableName.Text,
                TableStatus = "Available"
            };
            CRUDTable.UpdateTable(editedTable, collectionName);
            MessageBox.Show("Edit thành công!");
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
