﻿namespace Restaurant_Management.Model
{
    partial class frmCategoryAdd
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
            txtCategoryName = new Guna.UI2.WinForms.Guna2TextBox();
            text = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.options;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // label1
            // 
            label1.Location = new Point(105, 39);
            label1.Size = new Size(127, 25);
            label1.Text = "Add Category";
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.None;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.Location = new Point(56, 12);
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnSave.Click += btnSave_Click_1;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Location = new Point(0, 222);
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(309, 59);
            // 
            // guna2Panel2
            // 
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2Panel2.Size = new Size(309, 91);
            guna2Panel2.Paint += guna2Panel2_Paint;
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.None;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.Location = new Point(167, 12);
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnClose.Click += btnClose_Click_1;
            // 
            // txtCategoryName
            // 
            txtCategoryName.CustomizableEdges = customizableEdges5;
            txtCategoryName.DefaultText = "";
            txtCategoryName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCategoryName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCategoryName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCategoryName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCategoryName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCategoryName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoryName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCategoryName.Location = new Point(56, 143);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.PasswordChar = '\0';
            txtCategoryName.PlaceholderText = "";
            txtCategoryName.SelectedText = "";
            txtCategoryName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtCategoryName.Size = new Size(200, 36);
            txtCategoryName.TabIndex = 10;
            // 
            // text
            // 
            text.AutoSize = true;
            text.Location = new Point(56, 125);
            text.Name = "text";
            text.Size = new Size(39, 15);
            text.TabIndex = 8;
            text.Text = "Name";
            // 
            // frmCategoryAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 281);
            Controls.Add(txtCategoryName);
            Controls.Add(text);
            Name = "frmCategoryAdd";
            Text = "frmCategoryAdd";
            Load += frmCategoryAdd_Load;
            Controls.SetChildIndex(text, 0);
            Controls.SetChildIndex(guna2Panel1, 0);
            Controls.SetChildIndex(txtCategoryName, 0);
            Controls.SetChildIndex(guna2Panel2, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Guna.UI2.WinForms.Guna2TextBox txtCategoryName;
        private Label text;
    }
}