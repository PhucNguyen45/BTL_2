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
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();

            //panel2.AutoScroll = true;
            timer1 = new Timer();
            timer1.Interval = 1000; // Set the interval to 1 second (1000 milliseconds)
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label4.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chắc chắn muốn thoát");
            Form2 f2 = new Form2("defaultUserName");
            f2.Show();
            this.Close();
        }

        
    }
}
