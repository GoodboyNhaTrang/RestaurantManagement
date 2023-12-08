namespace Restaurant_Management.Model
{
    partial class frmProductAdd
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label3 = new Label();
            txtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            label5 = new Label();
            cbProduct = new Guna.UI2.WinForms.Guna2ComboBox();
            label6 = new Label();
            txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            txtImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            btnBrowser = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtImage).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.box;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // label1
            // 
            label1.Size = new Size(117, 25);
            label1.Text = "Add Product";
            label1.Click += label1_Click;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.None;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.Location = new Point(87, 12);
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnSave.Click += btnSave_Click_1;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Location = new Point(0, 327);
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(367, 59);
            guna2Panel1.Paint += guna2Panel1_Paint;
            // 
            // guna2Panel2
            // 
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2Panel2.Size = new Size(367, 91);
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.None;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.Location = new Point(207, 12);
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnClose.Click += btnClose_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(48, 110);
            label3.Name = "label3";
            label3.Size = new Size(45, 19);
            label3.TabIndex = 1;
            label3.Text = "Name";
            label3.Click += label3_Click;
            // 
            // txtProductName
            // 
            txtProductName.CustomizableEdges = customizableEdges5;
            txtProductName.DefaultText = "";
            txtProductName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtProductName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtProductName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtProductName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtProductName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtProductName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtProductName.Location = new Point(47, 132);
            txtProductName.Name = "txtProductName";
            txtProductName.PasswordChar = '\0';
            txtProductName.PlaceholderText = "";
            txtProductName.SelectedText = "";
            txtProductName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtProductName.Size = new Size(141, 24);
            txtProductName.TabIndex = 2;
            txtProductName.TextChanged += txtProductName_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(47, 229);
            label5.Name = "label5";
            label5.Size = new Size(72, 19);
            label5.TabIndex = 1;
            label5.Text = "Categeory";
            label5.Click += label5_Click;
            // 
            // cbProduct
            // 
            cbProduct.BackColor = Color.Transparent;
            cbProduct.CustomizableEdges = customizableEdges7;
            cbProduct.DrawMode = DrawMode.OwnerDrawFixed;
            cbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProduct.FocusedColor = Color.FromArgb(94, 148, 255);
            cbProduct.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbProduct.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbProduct.ForeColor = Color.FromArgb(68, 88, 112);
            cbProduct.ItemHeight = 30;
            cbProduct.Location = new Point(47, 251);
            cbProduct.Name = "cbProduct";
            cbProduct.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cbProduct.Size = new Size(140, 36);
            cbProduct.TabIndex = 3;
            cbProduct.SelectedIndexChanged += guna2ComboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(47, 170);
            label6.Name = "label6";
            label6.Size = new Size(38, 19);
            label6.TabIndex = 1;
            label6.Text = "Price";
            label6.Click += label6_Click;
            // 
            // txtPrice
            // 
            txtPrice.CustomizableEdges = customizableEdges9;
            txtPrice.DefaultText = "";
            txtPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Location = new Point(47, 192);
            txtPrice.Name = "txtPrice";
            txtPrice.PasswordChar = '\0';
            txtPrice.PlaceholderText = "";
            txtPrice.SelectedText = "";
            txtPrice.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtPrice.Size = new Size(138, 24);
            txtPrice.TabIndex = 2;
            txtPrice.TextChanged += guna2TextBox4_TextChanged;
            // 
            // txtImage
            // 
            txtImage.Image = Properties.Resources.pizza;
            txtImage.ImageRotate = 0F;
            txtImage.Location = new Point(246, 120);
            txtImage.Name = "txtImage";
            txtImage.ShadowDecoration.CustomizableEdges = customizableEdges11;
            txtImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            txtImage.Size = new Size(91, 103);
            txtImage.SizeMode = PictureBoxSizeMode.Zoom;
            txtImage.TabIndex = 6;
            txtImage.TabStop = false;
            txtImage.Click += guna2CirclePictureBox1_Click;
            // 
            // btnBrowser
            // 
            btnBrowser.AutoRoundedCorners = true;
            btnBrowser.BorderRadius = 13;
            btnBrowser.CustomizableEdges = customizableEdges12;
            btnBrowser.DisabledState.BorderColor = Color.DarkGray;
            btnBrowser.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBrowser.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBrowser.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBrowser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBrowser.ForeColor = Color.White;
            btnBrowser.Location = new Point(252, 229);
            btnBrowser.Name = "btnBrowser";
            btnBrowser.ShadowDecoration.CustomizableEdges = customizableEdges13;
            btnBrowser.Size = new Size(85, 29);
            btnBrowser.TabIndex = 7;
            btnBrowser.Text = "Browser";
            btnBrowser.Click += btnBrowser_Click;
            // 
            // frmProductAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 386);
            Controls.Add(btnBrowser);
            Controls.Add(txtImage);
            Controls.Add(cbProduct);
            Controls.Add(txtPrice);
            Controls.Add(label5);
            Controls.Add(txtProductName);
            Controls.Add(label6);
            Controls.Add(label3);
            Name = "frmProductAdd";
            Text = "frmProductAdd";
            Load += frmProductAdd_Load;
            Controls.SetChildIndex(guna2Panel1, 0);
            Controls.SetChildIndex(guna2Panel2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(txtProductName, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(txtPrice, 0);
            Controls.SetChildIndex(cbProduct, 0);
            Controls.SetChildIndex(txtImage, 0);
            Controls.SetChildIndex(btnBrowser, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtProductName;
        private Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbProduct;
        private Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2CirclePictureBox txtImage;
        private Guna.UI2.WinForms.Guna2Button btnBrowser;
    }
}