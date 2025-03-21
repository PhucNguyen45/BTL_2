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
        public Film_Chosing()
        {
            InitializeComponent();
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
    }
}
