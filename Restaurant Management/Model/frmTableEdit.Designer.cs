namespace Restaurant_Management.Model
{
    partial class frmTableEdit
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label2 = new Label();
            TableId = new Label();
            txtTableName = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Size = new Size(93, 25);
            label1.Text = "Table Edit";
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.None;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnSave.Click += btnSave_Click_1;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Location = new Point(0, 250);
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new Size(275, 59);
            // 
            // guna2Panel2
            // 
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2Panel2.Size = new Size(275, 91);
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.None;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnClose.Click += btnClose_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 123);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Table Name";
            // 
            // TableId
            // 
            TableId.AutoSize = true;
            TableId.Location = new Point(154, 123);
            TableId.Name = "TableId";
            TableId.Size = new Size(44, 15);
            TableId.TabIndex = 2;
            TableId.Text = "TableId";
            TableId.Visible = false;
            // 
            // txtTableName
            // 
            txtTableName.CustomizableEdges = customizableEdges11;
            txtTableName.DefaultText = "";
            txtTableName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTableName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTableName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTableName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTableName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTableName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTableName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTableName.Location = new Point(36, 157);
            txtTableName.Name = "txtTableName";
            txtTableName.PasswordChar = '\0';
            txtTableName.PlaceholderText = "";
            txtTableName.SelectedText = "";
            txtTableName.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtTableName.Size = new Size(200, 36);
            txtTableName.TabIndex = 3;
            // 
            // frmTableEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 309);
            Controls.Add(txtTableName);
            Controls.Add(TableId);
            Controls.Add(label2);
            Name = "frmTableEdit";
            Text = "frmTableEdit";
            Controls.SetChildIndex(guna2Panel1, 0);
            Controls.SetChildIndex(guna2Panel2, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(TableId, 0);
            Controls.SetChildIndex(txtTableName, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label TableId;
        private Guna.UI2.WinForms.Guna2TextBox txtTableName;
    }
}