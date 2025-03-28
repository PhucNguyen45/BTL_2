using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Nhom20_BTL.GUI.UCs_Main;

namespace Winform_Nhom20_BTL.GUI
{
    public partial class Film_Chosing: UserControl
    {
        private SellForm sellForm;
        private Panel Sub_panel;

        public Film_Chosing(SellForm sellForm)
        {
            InitializeComponent();
            this.sellForm = sellForm;
            this.Sub_panel = new Panel();
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

        private void FilmData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string selectedFilm = FilmData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

            this.BackColor = Color.FromArgb(100, Color.Black);

            DateTime_Chosing uc = new DateTime_Chosing();
            uc.Dock = DockStyle.Fill;
            Sub_panel.Controls.Clear();
            Sub_panel.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}
