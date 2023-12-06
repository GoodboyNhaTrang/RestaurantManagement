namespace Restaurant_Management.View
{
    partial class frmCategoryView
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
            frmCategoryView_listTable = new Guna.UI2.WinForms.Guna2DataGridView();
            STT = new DataGridViewTextBoxColumn();
            categoryId = new DataGridViewTextBoxColumn();
            categoryName = new DataGridViewTextBoxColumn();
            _id = new DataGridViewTextBoxColumn();
            dgvedit = new DataGridViewImageColumn();
            dgvDel = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)frmCategoryView_listTable).BeginInit();
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
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 2);
            label2.Size = new Size(121, 25);
            label2.Text = "Category List";
            label2.Click += label2_Click;
            // 
            // frmCategoryView_listTable
            // 
            frmCategoryView_listTable.AllowUserToAddRows = false;
            frmCategoryView_listTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            frmCategoryView_listTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(232, 234, 237);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            frmCategoryView_listTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            frmCategoryView_listTable.ColumnHeadersHeight = 40;
            frmCategoryView_listTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            frmCategoryView_listTable.Columns.AddRange(new DataGridViewColumn[] { STT, categoryId, categoryName, _id, dgvedit, dgvDel });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            frmCategoryView_listTable.DefaultCellStyle = dataGridViewCellStyle3;
            frmCategoryView_listTable.GridColor = Color.FromArgb(231, 229, 255);
            frmCategoryView_listTable.Location = new Point(12, 100);
            frmCategoryView_listTable.Name = "frmCategoryView_listTable";
            frmCategoryView_listTable.ReadOnly = true;
            frmCategoryView_listTable.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(239, 241, 243);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(71, 69, 94);
            frmCategoryView_listTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            frmCategoryView_listTable.RowTemplate.Height = 25;
            frmCategoryView_listTable.Size = new Size(776, 250);
            frmCategoryView_listTable.TabIndex = 4;
            frmCategoryView_listTable.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            frmCategoryView_listTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            frmCategoryView_listTable.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            frmCategoryView_listTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            frmCategoryView_listTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            frmCategoryView_listTable.ThemeStyle.BackColor = Color.White;
            frmCategoryView_listTable.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            frmCategoryView_listTable.ThemeStyle.HeaderStyle.BackColor = Color.White;
            frmCategoryView_listTable.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            frmCategoryView_listTable.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            frmCategoryView_listTable.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            frmCategoryView_listTable.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            frmCategoryView_listTable.ThemeStyle.HeaderStyle.Height = 40;
            frmCategoryView_listTable.ThemeStyle.ReadOnly = true;
            frmCategoryView_listTable.ThemeStyle.RowsStyle.BackColor = Color.White;
            frmCategoryView_listTable.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            frmCategoryView_listTable.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            frmCategoryView_listTable.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            frmCategoryView_listTable.ThemeStyle.RowsStyle.Height = 25;
            frmCategoryView_listTable.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            frmCategoryView_listTable.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            frmCategoryView_listTable.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.Name = "STT";
            STT.ReadOnly = true;
            // 
            // categoryId
            // 
            categoryId.HeaderText = "id";
            categoryId.Name = "categoryId";
            categoryId.ReadOnly = true;
            categoryId.Visible = false;
            // 
            // categoryName
            // 
            categoryName.HeaderText = "Name";
            categoryName.Name = "categoryName";
            categoryName.ReadOnly = true;
            // 
            // _id
            // 
            _id.HeaderText = "_id";
            _id.Name = "_id";
            _id.ReadOnly = true;
            _id.Visible = false;
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
            // frmCategoryView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(frmCategoryView_listTable);
            Name = "frmCategoryView";
            Text = "frmCategoryView";
            Load += frmCategoryView_Load;
            ClientSizeChanged += frmCategoryView_ClientSizeChanged;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtSearch, 0);
            Controls.SetChildIndex(btnAdd, 0);
            Controls.SetChildIndex(frmCategoryView_listTable, 0);
            ((System.ComponentModel.ISupportInitialize)frmCategoryView_listTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Guna.UI2.WinForms.Guna2DataGridView frmCategoryView_listTable;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn categoryId;
        private DataGridViewTextBoxColumn categoryName;
        private DataGridViewTextBoxColumn _id;
        private DataGridViewImageColumn dgvedit;
        private DataGridViewImageColumn dgvDel;
    }
}