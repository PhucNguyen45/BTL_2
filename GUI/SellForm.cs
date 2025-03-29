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

namespace Winform_Nhom20_BTL.GUI
{
    public partial class SellForm: Form
    {
        public SellForm()
        {
            InitializeComponent();
        }

        private void CloseSellFom_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
