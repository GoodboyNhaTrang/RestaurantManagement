namespace Restaurant_Management
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            btnExit = new Guna.UI2.WinForms.Guna2Button();
            guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(pictureBox1);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.FillColor = Color.FromArgb(50, 55, 89);
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(243, 170);
            guna2Panel1.TabIndex = 4;
            guna2Panel1.Paint += guna2Panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.login1;
            pictureBox1.Location = new Point(73, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 144);
            label3.Name = "label3";
            label3.Size = new Size(161, 15);
            label3.TabIndex = 0;
            label3.Text = "Please enter user information";
            label3.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 195);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // txtUser
            // 
            txtUser.CustomizableEdges = customizableEdges3;
            txtUser.DefaultText = "";
            txtUser.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUser.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUser.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUser.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUser.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUser.Location = new Point(12, 213);
            txtUser.Name = "txtUser";
            txtUser.PasswordChar = '\0';
            txtUser.PlaceholderText = "";
            txtUser.SelectedText = "";
            txtUser.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtUser.Size = new Size(200, 24);
            txtUser.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 240);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // txtPass
            // 
            txtPass.CustomizableEdges = customizableEdges5;
            txtPass.DefaultText = "";
            txtPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPass.Location = new Point(12, 258);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '\0';
            txtPass.PlaceholderText = "";
            txtPass.SelectedText = "";
            txtPass.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPass.Size = new Size(200, 27);
            txtPass.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.AutoRoundedCorners = true;
            btnLogin.BorderRadius = 21;
            btnLogin.CustomizableEdges = customizableEdges7;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.FromArgb(241, 85, 126);
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(12, 291);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnLogin.Size = new Size(98, 45);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.AutoRoundedCorners = true;
            btnExit.BorderRadius = 21;
            btnExit.CustomizableEdges = customizableEdges9;
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.FillColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(114, 290);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnExit.Size = new Size(98, 45);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.Click += btnExit_Click;
            // 
            // guna2MessageDialog1
            // 
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            guna2MessageDialog1.Caption = "RMS";
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            guna2MessageDialog1.Parent = this;
            guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            guna2MessageDialog1.Text = null;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 367);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(label2);
            Controls.Add(txtUser);
            Controls.Add(label1);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "44";
            Load += frmLogin_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Label label3;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
    }
}