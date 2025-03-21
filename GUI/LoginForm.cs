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

            this.FormClosing += new FormClosingEventHandler(LoginForm_FormClosing);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textbox1.Text.Trim();
            string pass = textBox2.Text.Trim();
            if (user == string.Empty) 
            { 
                MessageBox.Show("Chưa nhập user name !");
                textbox1.Focus();
                return;
            }
            if (pass == string.Empty)
            {
                MessageBox.Show("Chưa nhập pass !");
                textBox2.Focus();
                return;
            }
            if (user == "admin" && pass == "admin")
            {
                DashBoardForm f2 = new DashBoardForm(user);
                //f2.FormClosed += (s, args) => this.Show();
                f2.Show();
                this.Hide();
                f2.FormClosed += (s, args) => this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                textbox1.Clear();
                textBox2.Clear();
                textbox1.Focus();
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
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}