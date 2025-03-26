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
using Winform_Nhom20_BTL.GUI.UCs_Main;
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

        public void Customer_Save_Click(object sender, EventArgs e)
        {
            guna2Button1.Checked = false;
            guna2Button5.Checked = true;
            Film_Chosing uc = new Film_Chosing(this);
            addUserControl(uc);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Film_Chosing uc = new Film_Chosing(this);
            addUserControl(uc);
        }

        public void Film_Save_Click(object sender, EventArgs e)
        {
            guna2Button5.Checked = false;
            guna2Button6.Checked = true;
            string filmName = label6.Text.Replace("Phim: ", "");
            Room_Chosing uc = new Room_Chosing(filmName, this);
            addUserControl(uc);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            string filmName = label6.Text.Replace("Phim: ", "");
            Room_Chosing uc = new Room_Chosing(filmName, this);
            addUserControl(uc);
        }

        public void Room_Save_Click(object sender, EventArgs e)
        {
            guna2Button6.Checked = false;
            guna2Button7.Checked = true;
            string filmName = label6.Text.Replace("Phim: ", "");
            Seat_Chosing uc = new Seat_Chosing(this, filmName);
            addUserControl(uc);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            string filmName = label6.Text.Replace("Phim: ", "");
            Seat_Chosing uc = new Seat_Chosing(this, filmName);
            addUserControl(uc);
        }

        public void Seat_Save_Click(object sender, EventArgs e)
        {
            guna2Button7.Checked = false;
            guna2Button2.Checked = true;
            Service uc = new Service(/*this*/);
            addUserControl(uc);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Service uc = new Service(/*this*/);
            addUserControl(uc);
        }

        public void UpdateReceipt_Info(string name, string cccd, string phone, string date)
        {
            label2.Text = "Khách hàng: " + name;
            label3.Text = "Số CCCD: " + cccd;
            label4.Text = "SĐT: " + phone;
            label5.Text = "Ngày, tháng, năm sinh: " + date;
        }

        public void UpdateReceipt_Film(string film)
        {
            label6.Text = "Phim: " + film;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult results = MessageBox.Show("Bạn muốn thoát ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (results == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReceiptPrinting receiptPrinting = new ReceiptPrinting();
            receiptPrinting.Show();
            this.Hide();
        }
    }
}
