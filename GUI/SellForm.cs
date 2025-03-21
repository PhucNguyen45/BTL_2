using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using Winform_Nhom20_BTL.UserControls;

namespace Winform_Nhom20_BTL.GUI
{
    public partial class SellForm: Form
    {
        public SellForm()
        {
            InitializeComponent();
            Customer_Info uc = new Customer_Info(this);
            addUserControl(uc);
        }

        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(uc);
            uc.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Customer_Info uc = new Customer_Info(this);
            addUserControl(uc);
        }

        public void TriggerGuna2Button5_Click(object sender, EventArgs e)
        {
            guna2Button5_Click(sender, e);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Film_Chosing uc = new Film_Chosing();
            addUserControl(uc);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Room_Chosing uc = new Room_Chosing();
            addUserControl(uc);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        public void UpdateReceipt_Info(string name, string cccd, string phone, string date)
        {
            label2.Text = "Khách hàng: " + name;
            label3.Text = "Số CCCD: " + cccd;
            label4.Text = "SĐT: " + phone;
            label5.Text = "Ngày, tháng, năm sinh: " + date;
        }
    }
}
