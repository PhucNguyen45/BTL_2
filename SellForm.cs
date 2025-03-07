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
    public partial class SellForm: Form
    {
        public SellForm()
        {
            InitializeComponent();

            //panel2.AutoScroll = true;
            timer1 = new Timer();
            timer1.Interval = 1000; // Set the interval to 1 second (1000 milliseconds)
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

            dateTimePicker1.ValueChanged += new EventHandler(dateTimePicker1_ValueChanged);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label4.Text = DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult DialogResult = MessageBox.Show("Xác nhận thông tin khách hàng", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            // đoạn này để lưu dữ liệu mật khẩu mới vào SQL Server Database
            if (DialogResult == DialogResult.Yes)
            {
                InsideTheaterForm insideTheaterForm = new InsideTheaterForm(this);
                insideTheaterForm.ShowDialog();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xác nhận hủy đơn vé");
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            int age = CalculateAge(selectedDate);
            if (age < 18)
            {
                MessageBox.Show("Không thể mua vé cho người dưới 18 tuổi");
                dateTimePicker1.Value = DateTime.Now;
            }
        }

        private int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}
