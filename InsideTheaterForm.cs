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


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xác nhận đặt vé thành công");
            // đoạn này để lưu dữ liệu vào SQL Server Database
            this.Close();
            sellForm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.Yellow)
            {
                button2.BackColor = Color.White;
            }
            else
                this.button2.BackColor = Color.Yellow;
        }
    }
}
