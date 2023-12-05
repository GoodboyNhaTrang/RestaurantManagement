namespace Restaurant_Management.View
{
    partial class frmTableView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableView));
            frmTablesView_listTable = new Guna.UI2.WinForms.Guna2DataGridView();
            Stt = new DataGridViewTextBoxColumn();
            TableId = new DataGridViewTextBoxColumn();
            TableName = new DataGridViewTextBoxColumn();
            TableStatus = new DataGridViewTextBoxColumn();
            dgvedit = new DataGridViewImageColumn();
            dgvDel = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)frmTablesView_listTable).BeginInit();
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
            // frmTablesView_listTable
            // 
            frmTablesView_listTable.AllowUserToAddRows = false;
            frmTablesView_listTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            frmTablesView_listTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(232, 234, 237);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            frmTablesView_listTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            frmTablesView_listTable.ColumnHeadersHeight = 40;
            frmTablesView_listTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            frmTablesView_listTable.Columns.AddRange(new DataGridViewColumn[] { Stt, TableId, TableName, TableStatus, dgvedit, dgvDel });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(239, 241, 243);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            frmTablesView_listTable.DefaultCellStyle = dataGridViewCellStyle3;
            frmTablesView_listTable.GridColor = Color.FromArgb(231, 229, 255);
            frmTablesView_listTable.Location = new Point(12, 100);
            frmTablesView_listTable.Name = "frmTablesView_listTable";
            frmTablesView_listTable.ReadOnly = true;
            frmTablesView_listTable.RowHeadersVisible = false;
            frmTablesView_listTable.RowTemplate.Height = 25;
            frmTablesView_listTable.Size = new Size(765, 276);
            frmTablesView_listTable.TabIndex = 4;
            frmTablesView_listTable.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            frmTablesView_listTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            frmTablesView_listTable.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            frmTablesView_listTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            frmTablesView_listTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            frmTablesView_listTable.ThemeStyle.BackColor = Color.White;
            frmTablesView_listTable.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            frmTablesView_listTable.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(232, 234, 237);
            frmTablesView_listTable.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            frmTablesView_listTable.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            frmTablesView_listTable.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            frmTablesView_listTable.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            frmTablesView_listTable.ThemeStyle.HeaderStyle.Height = 40;
            frmTablesView_listTable.ThemeStyle.ReadOnly = true;
            frmTablesView_listTable.ThemeStyle.RowsStyle.BackColor = Color.White;
            frmTablesView_listTable.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            frmTablesView_listTable.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            frmTablesView_listTable.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            frmTablesView_listTable.ThemeStyle.RowsStyle.Height = 25;
            frmTablesView_listTable.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            frmTablesView_listTable.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            frmTablesView_listTable.CellContentClick += frmTableView_listTable_CellContentClick;
            // 
            // Stt
            // 
            Stt.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Stt.FillWeight = 70F;
            Stt.HeaderText = "Stt";
            Stt.MinimumWidth = 70;
            Stt.Name = "Stt";
            Stt.ReadOnly = true;
            Stt.Width = 70;
            // 
            // TableId
            // 
            TableId.HeaderText = "TableId";
            TableId.Name = "TableId";
            TableId.ReadOnly = true;
            TableId.Visible = false;
            // 
            // TableName
            // 
            TableName.FillWeight = 49.4894943F;
            TableName.HeaderText = "Name";
            TableName.Name = "TableName";
            TableName.ReadOnly = true;
            // 
            // TableStatus
            // 
            TableStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TableStatus.HeaderText = "Status";
            TableStatus.Name = "TableStatus";
            TableStatus.ReadOnly = true;
            // 
            // dgvedit
            // 
            dgvedit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvedit.FillWeight = 50F;
            dgvedit.HeaderText = "";
            dgvedit.Image = Properties.Resources.pen2;
            dgvedit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvedit.MinimumWidth = 50;
            dgvedit.Name = "dgvedit";
            dgvedit.ReadOnly = true;
            dgvedit.SortMode = DataGridViewColumnSortMode.Automatic;
            dgvedit.Width = 50;
            // 
            // dgvDel
            // 
            dgvDel.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvDel.FillWeight = 50F;
            dgvDel.HeaderText = "";
            dgvDel.Image = (Image)resources.GetObject("dgvDel.Image");
            dgvDel.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvDel.MinimumWidth = 50;
            dgvDel.Name = "dgvDel";
            dgvDel.ReadOnly = true;
            dgvDel.SortMode = DataGridViewColumnSortMode.Automatic;
            dgvDel.Width = 50;
            // 
            // frmTableView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(frmTablesView_listTable);
            Name = "frmTableView";
            Text = "frmTableView";
            Load += frmTableView_Load;
            ClientSizeChanged += frmTableView_ClientSizeChanged;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtSearch, 0);
            Controls.SetChildIndex(btnAdd, 0);
            Controls.SetChildIndex(frmTablesView_listTable, 0);
            ((System.ComponentModel.ISupportInitialize)frmTablesView_listTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView frmTablesView_listTable;
        private DataGridViewTextBoxColumn Stt;
        private DataGridViewTextBoxColumn TableId;
        private DataGridViewTextBoxColumn TableName;
        private DataGridViewTextBoxColumn TableStatus;
        private DataGridViewImageColumn dgvedit;
        private DataGridViewImageColumn dgvDel;
    }
}