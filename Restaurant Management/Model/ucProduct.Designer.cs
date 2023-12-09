namespace Restaurant_Management.Model
{
    partial class ucProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            panel1 = new Panel();
            lblPName = new Label();
            txtImage = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2ShadowPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtImage).BeginInit();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(guna2Separator1);
            guna2ShadowPanel1.Controls.Add(panel1);
            guna2ShadowPanel1.Controls.Add(txtImage);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(3, 3);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(199, 187);
            guna2ShadowPanel1.TabIndex = 0;
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(0, 125);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(192, 10);
            guna2Separator1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblPName);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 138);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 49);
            panel1.TabIndex = 1;
            // 
            // lblPName
            // 
            lblPName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPName.Location = new Point(3, 0);
            lblPName.Name = "lblPName";
            lblPName.Size = new Size(193, 40);
            lblPName.TabIndex = 0;
            lblPName.Text = "Product Name";
            lblPName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtImage
            // 
            txtImage.CustomizableEdges = customizableEdges1;
            txtImage.Image = Properties.Resources.Pho;
            txtImage.ImageRotate = 0F;
            txtImage.Location = new Point(50, 26);
            txtImage.Name = "txtImage";
            txtImage.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtImage.Size = new Size(104, 82);
            txtImage.SizeMode = PictureBoxSizeMode.Zoom;
            txtImage.TabIndex = 0;
            txtImage.TabStop = false;
            txtImage.UseTransparentBackground = true;
            txtImage.Click += txtImage_Click;
            // 
            // ucProduct
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(guna2ShadowPanel1);
            Name = "ucProduct";
            Size = new Size(205, 193);
            guna2ShadowPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox txtImage;
        private Panel panel1;
        private Label lblPName;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
