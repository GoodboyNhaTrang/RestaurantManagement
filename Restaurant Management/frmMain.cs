﻿using Restaurant_Management.CRUD;
using Restaurant_Management.Model;
using Restaurant_Management.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Load += frmMain_Load;
        }

        public void addControls(Form f)
        {
            ControlsPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            ControlsPanel.Controls.Add(f);
            f.Show();

        }

        //public void addControls(frmMain mainForm, Form f)
        //{
        //    mainForm.ControlsPanel.Controls.Clear();
        //    f.Dock = DockStyle.Fill;
        //    f.TopLevel = false;
        //    mainForm.ControlsPanel.Controls.Add(f);
        //    f.Show();
        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = Connect.Name;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            addControls(new frmHome());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            addControls(new frmCategoryView());
        }

        private void ControlsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            addControls(new frmStaffView());
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            addControls(new frmTableView());
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            frmPOS frm = new frmPOS();
            frm.Show();
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            addControls(new frmKitchenView());
        }
    }
}
