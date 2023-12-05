namespace Restaurant_Management.Model
{
    partial class frmStaffEdit
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtStaffName = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            txtStaffRole = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            txtStaffSalary = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            StaffId = new Label();
            StaffEditConfirm = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Size = new Size(86, 25);
            label1.Text = "Staff Edit";
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.None;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnSave.Click += btnSave_Click_1;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Location = new Point(0, 344);
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(272, 59);
            // 
            // guna2Panel2
            // 
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2Panel2.Size = new Size(272, 91);
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.None;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnClose.Click += btnClose_Click_1;
            // 
            // txtStaffName
            // 
            txtStaffName.CustomizableEdges = customizableEdges5;
            txtStaffName.DefaultText = "";
            txtStaffName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtStaffName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtStaffName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtStaffName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtStaffName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtStaffName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtStaffName.Location = new Point(32, 118);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.PasswordChar = '\0';
            txtStaffName.PlaceholderText = "";
            txtStaffName.SelectedText = "";
            txtStaffName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtStaffName.Size = new Size(200, 36);
            txtStaffName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 100);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Name";
            // 
            // txtStaffRole
            // 
            txtStaffRole.CustomizableEdges = customizableEdges7;
            txtStaffRole.DefaultText = "";
            txtStaffRole.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtStaffRole.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtStaffRole.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtStaffRole.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtStaffRole.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtStaffRole.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffRole.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtStaffRole.Location = new Point(32, 189);
            txtStaffRole.Name = "txtStaffRole";
            txtStaffRole.PasswordChar = '\0';
            txtStaffRole.PlaceholderText = "";
            txtStaffRole.SelectedText = "";
            txtStaffRole.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtStaffRole.Size = new Size(200, 36);
            txtStaffRole.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 171);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 8;
            label3.Text = "Role";
            // 
            // txtStaffSalary
            // 
            txtStaffSalary.CustomizableEdges = customizableEdges9;
            txtStaffSalary.DefaultText = "";
            txtStaffSalary.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtStaffSalary.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtStaffSalary.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtStaffSalary.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtStaffSalary.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtStaffSalary.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffSalary.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtStaffSalary.Location = new Point(32, 256);
            txtStaffSalary.Name = "txtStaffSalary";
            txtStaffSalary.PasswordChar = '\0';
            txtStaffSalary.PlaceholderText = "";
            txtStaffSalary.SelectedText = "";
            txtStaffSalary.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtStaffSalary.Size = new Size(200, 36);
            txtStaffSalary.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 238);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 10;
            label4.Text = "Salary";
            // 
            // StaffId
            // 
            StaffId.AutoSize = true;
            StaffId.Location = new Point(91, 100);
            StaffId.Name = "StaffId";
            StaffId.Size = new Size(17, 15);
            StaffId.TabIndex = 1;
            StaffId.Text = "Id";
            StaffId.Visible = false;
            // 
            // StaffEditConfirm
            // 
            StaffEditConfirm.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            StaffEditConfirm.Caption = "Confirm";
            StaffEditConfirm.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            StaffEditConfirm.Parent = null;
            StaffEditConfirm.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            StaffEditConfirm.Text = null;
            // 
            // frmStaffEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 403);
            Controls.Add(StaffId);
            Controls.Add(txtStaffSalary);
            Controls.Add(label4);
            Controls.Add(txtStaffRole);
            Controls.Add(label3);
            Controls.Add(txtStaffName);
            Controls.Add(label2);
            Name = "frmStaffEdit";
            Text = "frmStaffEdit";
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtStaffName, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtStaffRole, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(txtStaffSalary, 0);
            Controls.SetChildIndex(guna2Panel1, 0);
            Controls.SetChildIndex(guna2Panel2, 0);
            Controls.SetChildIndex(StaffId, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Guna.UI2.WinForms.Guna2TextBox txtStaffName;
        private Label label2;
        public Guna.UI2.WinForms.Guna2TextBox txtStaffRole;
        private Label label3;
        public Guna.UI2.WinForms.Guna2TextBox txtStaffSalary;
        private Label label4;
        private Label StaffId;
        private Guna.UI2.WinForms.Guna2MessageDialog StaffEditConfirm;
    }
}