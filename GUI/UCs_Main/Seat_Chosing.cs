using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Nhom20_BTL.GUI
{
    public partial class Seat_Chosing: UserControl
    {
        private SellForm sellForm;
        private string filmName;

        public Seat_Chosing(SellForm sellForm, string filmName)
        {
            InitializeComponent();
            this.sellForm = sellForm;
            this.filmName = filmName;
            Film_nameLabel.Text = filmName;
        }


    }
}
