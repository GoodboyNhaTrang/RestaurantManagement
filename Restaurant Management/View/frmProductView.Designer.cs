namespace Restaurant_Management.View
{
    partial class frmProductView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            frmProductView_listTable = new Guna.UI2.WinForms.Guna2DataGridView();
            STT = new DataGridViewTextBoxColumn();
            productId = new DataGridViewTextBoxColumn();
            productName = new DataGridViewTextBoxColumn();
            categoryId = new DataGridViewTextBoxColumn();
            categoryName = new DataGridViewTextBoxColumn();
            productPrice = new DataGridViewTextBoxColumn();
            _id = new DataGridViewTextBoxColumn();
            productImage = new DataGridViewTextBoxColumn();
            dgvedit = new DataGridViewImageColumn();
            dgvDel = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)frmProductView_listTable).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges1;
            // 
            // btnAdd
            // 
            btnAdd.CheckedState.ImageSize = new Size(64, 64);
            btnAdd.DialogResult = DialogResult.None;
            btnAdd.HoverState.ImageSize = new Size(64, 64);
            btnAdd.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            btnAdd.PressedState.ImageSize = new Size(64, 64);
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // frmProductView_listTable
            // 
            frmProductView_listTable.AllowUserToAddRows = false;
            frmProductView_listTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            frmProductView_listTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(232, 234, 237);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            frmProductView_listTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            frmProductView_listTable.ColumnHeadersHeight = 40;
            frmProductView_listTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            frmProductView_listTable.Columns.AddRange(new DataGridViewColumn[] { STT, productId, productName, categoryId, categoryName, productPrice, _id, productImage, dgvedit, dgvDel });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            frmProductView_listTable.DefaultCellStyle = dataGridViewCellStyle3;
            frmProductView_listTable.GridColor = Color.FromArgb(231, 229, 255);
            frmProductView_listTable.Location = new Point(12, 100);
            frmProductView_listTable.Name = "frmProductView_listTable";
            frmProductView_listTable.ReadOnly = true;
            frmProductView_listTable.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(239, 241, 243);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(71, 69, 94);
            frmProductView_listTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            frmProductView_listTable.RowTemplate.Height = 25;
            frmProductView_listTable.Size = new Size(776, 250);
            frmProductView_listTable.TabIndex = 5;
            frmProductView_listTable.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            frmProductView_listTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            frmProductView_listTable.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            frmProductView_listTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            frmProductView_listTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            frmProductView_listTable.ThemeStyle.BackColor = Color.White;
            frmProductView_listTable.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            frmProductView_listTable.ThemeStyle.HeaderStyle.BackColor = Color.White;
            frmProductView_listTable.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            frmProductView_listTable.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            frmProductView_listTable.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            frmProductView_listTable.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            frmProductView_listTable.ThemeStyle.HeaderStyle.Height = 40;
            frmProductView_listTable.ThemeStyle.ReadOnly = true;
            frmProductView_listTable.ThemeStyle.RowsStyle.BackColor = Color.White;
            frmProductView_listTable.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            frmProductView_listTable.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            frmProductView_listTable.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            frmProductView_listTable.ThemeStyle.RowsStyle.Height = 25;
            frmProductView_listTable.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            frmProductView_listTable.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            frmProductView_listTable.CellContentClick += frmProductView_listTable_CellContentClick;
 
            frmProductView_listTable.ClientSizeChanged += frmProductView_listTable_ClientSizeChanged;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.Name = "STT";
            STT.ReadOnly = true;
            // 
            // productId
            // 
            productId.HeaderText = "id";
            productId.Name = "productId";
            productId.ReadOnly = true;
            productId.Visible = false;
            // 
            // productName
            // 
            productName.HeaderText = "Name";
            productName.Name = "productName";
            productName.ReadOnly = true;
            // 
            // categoryId
            // 
            categoryId.HeaderText = "cateogoryId";
            categoryId.Name = "categoryId";
            categoryId.ReadOnly = true;
            categoryId.Visible = false;
            // 
            // categoryName
            // 
            categoryName.HeaderText = "Category";
            categoryName.Name = "categoryName";
            categoryName.ReadOnly = true;
            // 
            // productPrice
            // 
            productPrice.HeaderText = "Price";
            productPrice.Name = "productPrice";
            productPrice.ReadOnly = true;
            // 
            // _id
            // 
            _id.HeaderText = "_id";
            _id.Name = "_id";
            _id.ReadOnly = true;
            _id.Visible = false;
            // 
            // productImage
            // 
            productImage.HeaderText = "productImage";
            productImage.Name = "productImage";
            productImage.ReadOnly = true;
            productImage.Visible = false;
            // 
            // dgvedit
            // 
            dgvedit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvedit.FillWeight = 50F;
            dgvedit.HeaderText = "";
            dgvedit.Image = Properties.Resources.pen;
            dgvedit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvedit.MinimumWidth = 50;
            dgvedit.Name = "dgvedit";
            dgvedit.ReadOnly = true;
            dgvedit.Resizable = DataGridViewTriState.True;
            dgvedit.SortMode = DataGridViewColumnSortMode.Automatic;
            dgvedit.Width = 50;
            // 
            // dgvDel
            // 
            dgvDel.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvDel.FillWeight = 50F;
            dgvDel.HeaderText = "";
            dgvDel.Image = Properties.Resources.trash_bin;
            dgvDel.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvDel.MinimumWidth = 50;
            dgvDel.Name = "dgvDel";
            dgvDel.ReadOnly = true;
            dgvDel.Resizable = DataGridViewTriState.True;
            dgvDel.SortMode = DataGridViewColumnSortMode.Automatic;
            dgvDel.Width = 50;
            // 
            // frmProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(frmProductView_listTable);
            Name = "frmProductView";
            Text = "frmProductView";
            Load += frmProductView_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtSearch, 0);
            Controls.SetChildIndex(btnAdd, 0);
            Controls.SetChildIndex(frmProductView_listTable, 0);
            ((System.ComponentModel.ISupportInitialize)frmProductView_listTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Guna.UI2.WinForms.Guna2DataGridView frmProductView_listTable;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn productId;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn categoryId;
        private DataGridViewTextBoxColumn categoryName;
        private DataGridViewTextBoxColumn productPrice;
        private DataGridViewTextBoxColumn _id;
        private DataGridViewTextBoxColumn productImage;
        private DataGridViewImageColumn dgvedit;
        private DataGridViewImageColumn dgvDel;
    }
}