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
    public partial class Film_Chosing: UserControl
    {
        private SellForm sellForm;

        public Film_Chosing(SellForm sellForm)
        {
            InitializeComponent();
            this.sellForm = sellForm;
        }

        private void SuggestionBox_Click(object sender, EventArgs e)
        {
            if (SuggestionBox.SelectedItem != null)
            {
                SearchBox.Text = SuggestionBox.SelectedItem.ToString();
                SuggestionBox.Visible = false;
            }
        }

        List<string> items = new List<string> { "Apple", "Banana", "Cherry", "Grape", "Mango", "Orange", "Pineapple" }; // Ví dụ danh sách các item

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string keyword = SearchBox.Text.ToLower();
            var suggestions = items.Where(i => i.ToLower().StartsWith(keyword)).ToList();

            if (string.IsNullOrEmpty(keyword))
            {
                SuggestionBox.Visible = false;
                return;
            }

            if (suggestions.Count > 0)
            {
                SuggestionBox.Visible = true;
                SuggestionBox.DataSource = suggestions;
            }
            else
            {
                SuggestionBox.Visible = false;
            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // phải có database phim thì mới add tên phim được
            string film_name = "Tangled";
            sellForm.UpdateReceipt_Film(film_name);
            MessageBox.Show("Đã thêm phim");
            sellForm.Film_Save_Click(sender, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã thêm phim");
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã thêm phim");
            
        }
    }
}
