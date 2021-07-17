﻿using PTUDTM.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using BLL;

namespace PTUDTM
{

    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnLogin_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string token = Businesses.auth.Signin(username,password,true);
            MessageBox.Show(token);
            //Program.frmMain = new frmMain();
            //this.Hide();
            //Program.frmMain.Show();
        }

        private void pnLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
