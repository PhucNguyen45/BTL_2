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
    public partial class Room_Chosing: UserControl
    {
        private string filmName;
        private SellForm sellForm;
        public Room_Chosing(string filmName, SellForm sellForm)
        {
            InitializeComponent();
            this.filmName = filmName;
            label2.Text = "Phim đang xem: " + filmName;
            this.sellForm = sellForm;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("You clicked on a room");
            sellForm.Room_Save_Click(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) {
                // Show only available rooms
            }
            else
            {
                // Show all rooms
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                // Sort by name
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                // Sort by ascending order
            }
            else
            {
                // Sort by descending order
            }
        }
    }
}
