using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Nhom20_BTL
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            Username_txt.KeyDown += Username_KeyDown;
            Password_txt.KeyDown += Password_KeyDown;

            this.FormClosing += new FormClosingEventHandler(LoginForm_FormClosing);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Password_txt.Focus();
                Password_txt.SelectAll();
            }
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LoginButton_Click(sender, e);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string user = Username_txt.Text.Trim();
            string pass = Password_txt.Text.Trim();
            if (user == string.Empty) 
            { 
                MessageBox.Show("Chưa nhập user name !");
                Username_txt.Focus();
                return;
            }
            if (pass == string.Empty)
            {
                MessageBox.Show("Chưa nhập pass !");
                Password_txt.Focus();
                return;
            }
            if (user == "admin" && pass == "admin")
            {
                DashBoardForm f2 = new DashBoardForm(user);
                f2.Show();
                this.Hide();
                f2.FormClosed += (s, args) => this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                Username_txt.Clear();
                Password_txt.Clear();
                Username_txt.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát", "Xác nhận", MessageBoxButtons.OKCancel ,MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) 
            {
                Password_txt.UseSystemPasswordChar = false;
            }
            else
            {
                Password_txt.UseSystemPasswordChar = true;
            }
        }
    }
}