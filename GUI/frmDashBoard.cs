﻿using GUI.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDashBoard : Form
    {
		public frmDashBoard(Account acc)
		{
			InitializeComponent();

			this.LoginAccount = acc;
		}

		private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        void ChangeAccount(int type)
        {
            if (loginAccount.Type == 2) btnAdmin.Enabled = false;
            lblAccountInfo.Text += LoginAccount.UserName;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnSeller_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSeller frm = new frmSeller();
			frm.ShowDialog();
            this.Show();
        }

		private void btnAccountSettings_Click(object sender, EventArgs e)
		{
			frmAccountSettings frm = new frmAccountSettings(loginAccount);
			frm.ShowDialog();
			this.Show();
		}
	}
}