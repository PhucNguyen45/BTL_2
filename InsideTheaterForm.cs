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
    public partial class InsideTheaterForm: Form
    {
        private SellForm sellForm;
        public InsideTheaterForm(SellForm sellForm)
        {
            InitializeComponent();
            this.sellForm = sellForm;
            InitializeButton();
        }

        private void InitializeButton()
        {
            for (int i = 2; i <= 40; i++)
            {
                Button button = this.Controls.Find("button" + i, true).FirstOrDefault() as Button;

                if (button != null)
                {
                    button.Click += new EventHandler(button_Click);
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor == Color.White)
            {
                button.BackColor = Color.Yellow;
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn muốn bỏ chọn ghế này ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    button.BackColor = Color.White;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xác nhận đặt vé thành công");
            // đoạn này để lưu dữ liệu vào SQL Server Database
            this.Close();
            sellForm.Close();
        }

    }
}
