namespace Restaurant_Management.Model
{
    partial class frmCategoryEdit
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
            txtEditName = new Guna.UI2.WinForms.Guna2TextBox();
            text = new Label();
            catId = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Size = new Size(125, 25);
            label1.Text = "Edit Category";
            label1.Click += label1_Click;
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
            guna2Panel1.Location = new Point(0, 234);
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(303, 59);
            // 
            // guna2Panel2
            // 
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2Panel2.Size = new Size(303, 91);
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
            // txtEditName
            // 
            txtEditName.CustomizableEdges = customizableEdges5;
            txtEditName.DefaultText = "";
            txtEditName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEditName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEditName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEditName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEditName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEditName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEditName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEditName.Location = new Point(44, 142);
            txtEditName.Name = "txtEditName";
            txtEditName.PasswordChar = '\0';
            txtEditName.PlaceholderText = "";
            txtEditName.SelectedText = "";
            txtEditName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtEditName.Size = new Size(200, 36);
            txtEditName.TabIndex = 6;
            // 
            // text
            // 
            text.AutoSize = true;
            text.Location = new Point(44, 124);
            text.Name = "text";
            text.Size = new Size(39, 15);
            text.TabIndex = 4;
            text.Text = "Name";
            // 
            // catId
            // 
            catId.AutoSize = true;
            catId.Location = new Point(45, 94);
            catId.Name = "catId";
            catId.Size = new Size(0, 15);
            catId.TabIndex = 7;
            catId.Visible = false;
            // 
            // frmCategoryEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 293);
            Controls.Add(catId);
            Controls.Add(txtEditName);
            Controls.Add(text);
            Name = "frmCategoryEdit";
            Text = "frmCategoryEdit";
            Load += frmCategoryEdit_Load;
            Controls.SetChildIndex(guna2Panel1, 0);
            Controls.SetChildIndex(guna2Panel2, 0);
            Controls.SetChildIndex(text, 0);
            Controls.SetChildIndex(txtEditName, 0);
            Controls.SetChildIndex(catId, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Guna.UI2.WinForms.Guna2TextBox txtEditName;
        private Label text;
        private Label catId;
    }
}