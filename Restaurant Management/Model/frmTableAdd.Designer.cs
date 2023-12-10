namespace Restaurant_Management.Model
{
    partial class frmTableAdd
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            frmTableAdd_txtName = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            frmTableAdd_messageDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(137, 40);
            label1.Size = new Size(95, 25);
            label1.Text = "Table Add";
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.None;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges13;
            btnSave.Click += btnSave_Click_1;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Location = new Point(0, 276);
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2Panel1.Size = new Size(271, 59);
            // 
            // guna2Panel2
            // 
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges15;
            guna2Panel2.Size = new Size(271, 91);
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.None;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnClose.Click += btnClose_Click_1;
            // 
            // frmTableAdd_txtName
            // 
            frmTableAdd_txtName.CustomizableEdges = customizableEdges17;
            frmTableAdd_txtName.DefaultText = "";
            frmTableAdd_txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            frmTableAdd_txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            frmTableAdd_txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            frmTableAdd_txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            frmTableAdd_txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            frmTableAdd_txtName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            frmTableAdd_txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            frmTableAdd_txtName.Location = new Point(38, 178);
            frmTableAdd_txtName.Name = "frmTableAdd_txtName";
            frmTableAdd_txtName.PasswordChar = '\0';
            frmTableAdd_txtName.PlaceholderText = "";
            frmTableAdd_txtName.SelectedText = "";
            frmTableAdd_txtName.ShadowDecoration.CustomizableEdges = customizableEdges18;
            frmTableAdd_txtName.Size = new Size(200, 36);
            frmTableAdd_txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 145);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Table Name";
            // 
            // frmTableAdd_messageDialog
            // 
            frmTableAdd_messageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            frmTableAdd_messageDialog.Caption = null;
            frmTableAdd_messageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            frmTableAdd_messageDialog.Parent = null;
            frmTableAdd_messageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            frmTableAdd_messageDialog.Text = null;
            // 
            // frmTableAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 335);
            Controls.Add(label2);
            Controls.Add(frmTableAdd_txtName);
            Name = "frmTableAdd";
            Text = "frmTableAdd";
            Controls.SetChildIndex(guna2Panel1, 0);
            Controls.SetChildIndex(guna2Panel2, 0);
            Controls.SetChildIndex(frmTableAdd_txtName, 0);
            Controls.SetChildIndex(label2, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox frmTableAdd_txtName;
        private Label label2;
        private Guna.UI2.WinForms.Guna2MessageDialog frmTableAdd_messageDialog;
    }
}