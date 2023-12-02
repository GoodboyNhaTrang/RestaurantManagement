namespace Restaurant_Management.View
{
    partial class frmStaffView
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
            frmStaffView_listTable = new Guna.UI2.WinForms.Guna2DataGridView();
            Stt = new DataGridViewTextBoxColumn();
            StaffId = new DataGridViewTextBoxColumn();
            UserId = new DataGridViewTextBoxColumn();
            StaffName = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            Salary = new DataGridViewTextBoxColumn();
            dgvedit = new DataGridViewImageColumn();
            dgvDel = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)frmStaffView_listTable).BeginInit();
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
            // frmStaffView_listTable
            // 
            frmStaffView_listTable.AllowUserToAddRows = false;
            frmStaffView_listTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            frmStaffView_listTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(232, 234, 237);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            frmStaffView_listTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            frmStaffView_listTable.ColumnHeadersHeight = 40;
            frmStaffView_listTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            frmStaffView_listTable.Columns.AddRange(new DataGridViewColumn[] { Stt, StaffId, UserId, StaffName, Role, Salary, dgvedit, dgvDel });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            frmStaffView_listTable.DefaultCellStyle = dataGridViewCellStyle3;
            frmStaffView_listTable.GridColor = Color.FromArgb(231, 229, 255);
            frmStaffView_listTable.Location = new Point(12, 100);
            frmStaffView_listTable.Name = "frmStaffView_listTable";
            frmStaffView_listTable.ReadOnly = true;
            frmStaffView_listTable.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(239, 241, 243);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(71, 69, 94);
            frmStaffView_listTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            frmStaffView_listTable.RowTemplate.Height = 25;
            frmStaffView_listTable.Size = new Size(776, 250);
            frmStaffView_listTable.TabIndex = 5;
            frmStaffView_listTable.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            frmStaffView_listTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            frmStaffView_listTable.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            frmStaffView_listTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            frmStaffView_listTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            frmStaffView_listTable.ThemeStyle.BackColor = Color.White;
            frmStaffView_listTable.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            frmStaffView_listTable.ThemeStyle.HeaderStyle.BackColor = Color.White;
            frmStaffView_listTable.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            frmStaffView_listTable.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            frmStaffView_listTable.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            frmStaffView_listTable.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            frmStaffView_listTable.ThemeStyle.HeaderStyle.Height = 40;
            frmStaffView_listTable.ThemeStyle.ReadOnly = true;
            frmStaffView_listTable.ThemeStyle.RowsStyle.BackColor = Color.White;
            frmStaffView_listTable.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            frmStaffView_listTable.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            frmStaffView_listTable.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            frmStaffView_listTable.ThemeStyle.RowsStyle.Height = 25;
            frmStaffView_listTable.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            frmStaffView_listTable.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
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
            // StaffId
            // 
            StaffId.HeaderText = "StaffId";
            StaffId.Name = "StaffId";
            StaffId.ReadOnly = true;
            StaffId.Visible = false;
            // 
            // UserId
            // 
            UserId.HeaderText = "UserId";
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
            UserId.Visible = false;
            // 
            // StaffName
            // 
            StaffName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StaffName.HeaderText = "Name";
            StaffName.Name = "StaffName";
            StaffName.ReadOnly = true;
            // 
            // Role
            // 
            Role.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Role.HeaderText = "Role";
            Role.Name = "Role";
            Role.ReadOnly = true;
            // 
            // Salary
            // 
            Salary.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Salary.HeaderText = "Salary";
            Salary.Name = "Salary";
            Salary.ReadOnly = true;
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
            // frmStaffView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(frmStaffView_listTable);
            Name = "frmStaffView";
            Text = "Form1";
            Load += frmStaffView_Load;
            ClientSizeChanged += frmStaffView_ClientSizeChanged;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtSearch, 0);
            Controls.SetChildIndex(btnAdd, 0);
            Controls.SetChildIndex(frmStaffView_listTable, 0);
            ((System.ComponentModel.ISupportInitialize)frmStaffView_listTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Guna.UI2.WinForms.Guna2DataGridView frmStaffView_dataGrid;
        private DataGridViewTextBoxColumn dgvStt;
        public Guna.UI2.WinForms.Guna2DataGridView frmStaffView_listTable;
        private DataGridViewTextBoxColumn Stt;
        private DataGridViewTextBoxColumn StaffName;
        private DataGridViewTextBoxColumn StaffSalary;
        private DataGridViewImageColumn dgvedit;
        private DataGridViewImageColumn dgvDel;
        private DataGridViewTextBoxColumn StaffRole;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewTextBoxColumn Salary;
        private DataGridViewTextBoxColumn StaffId;
        private DataGridViewTextBoxColumn UserId;
    }
}