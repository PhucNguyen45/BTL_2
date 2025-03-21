using System;
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
        public Customer_Info()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string cccd = textBox2.Text;            
            string phone = textBox3.Text;


        }
    }
}
