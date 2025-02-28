using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Nhom20_BTL
{
    public partial class Form2 : Form
    {
        public Form2(string UserName)
        {
            InitializeComponent();
            label1.Text = "Xin chào, " + UserName;
            label2.Text = "Người đăng nhập: " + UserName;

            this.FormClosing += new FormClosingEventHandler(Form2_FormClosing);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chắc chắn muốn thoát");
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label2.Text = DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
