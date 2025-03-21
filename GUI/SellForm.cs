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
            Customer_Info uc = new Customer_Info();
            addUserControl(uc);
        }


        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}
