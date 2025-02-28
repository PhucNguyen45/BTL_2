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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text.Trim();
            string pass = textBox2.Text.Trim();

            if (user == "admin" && pass == "admin")
            {
                MessageBox.Show("Admin đăng nhập thành công");
                Form2 f2 = new Form2(user);
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chắc chắn muốn thoát");
            Application.Exit();
        }
    }
}