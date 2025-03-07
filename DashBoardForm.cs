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
    public partial class DashBoardForm : Form
    {
        public DashBoardForm(string UserName)
        {
            InitializeComponent();
            label1.Text = "Xin chào, " + UserName;
            this.FormClosing += new FormClosingEventHandler(DashBoardForm_FormClosing);
        }

        private void DashBoardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm f1 = new LoginForm();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                LoginForm f1 = new LoginForm();
                f1.Show();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label2.Text = DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SellForm f3 = new SellForm();
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageForm f5 = new ManageForm();
            f5.ShowDialog();
        }
    }
}
