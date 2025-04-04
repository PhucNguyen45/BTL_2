﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Nhom20_BTL.GUI;

namespace Winform_Nhom20_BTL
{
    public partial class DashBoardForm : Form
    {
        public DashBoardForm(string UserName)
        {
            InitializeComponent();
            label1.Text = "Xin chào, " + UserName;
            
        }

        private void Add_Order_Click(object sender, EventArgs e)
        {
            SellForm f3 = new SellForm();
            f3.Show();
            this.Hide();
            f3.FormClosed += (s, args) => this.Show();
        }

        private void Order_Managemt_Click(object sender, EventArgs e)
        {
            FrmTrangchinh frmQL = new FrmTrangchinh();
            frmQL.Show();
            this.Hide();
            frmQL.FormClosed += (s, args) => this.Show();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult results = MessageBox.Show("Bạn muốn thoát ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (results == DialogResult.OK)
            {
                this.Close();
            }
        }

        
    }
}
