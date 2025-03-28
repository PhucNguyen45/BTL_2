﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Nhom20_BTL.GUI;

namespace Winform_Nhom20_BTL.UserControls
{
    public partial class Customer_Info: UserControl
    {
        private SellForm sellForm;

        public Customer_Info(SellForm sellForm)
        {
            InitializeComponent();

            this.sellForm = sellForm;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string cccd = textBox2.Text;            
            string phone = textBox3.Text;
            string date = dateTimePicker1.Value.ToString("dd/MM/yyyy");

            if (name == "" || cccd == "" || phone == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng");
                return;
            }
            else if (cccd.Length != 12)
            {
                MessageBox.Show("Số CCCD không hợp lệ");
                return;
            }
            else if (phone.Length > 11)
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }

            sellForm.UpdateReceipt_Info(name, cccd, phone, date);

            sellForm.Customer_Save_Click(sender, e);
        }
    }
}
