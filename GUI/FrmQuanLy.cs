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
    public partial class FrmTrangchinh : Form
    {
        private Button btnCancel;
        private Random random;
        private int tempinedx;
        private Form activeform;
        public FrmTrangchinh()
        {
            InitializeComponent();
            random = new Random();
        }
        private Color SelectThemecolor()
        {
            int index = random.Next(Themecolor.colors.Count);
            while (tempinedx == index)
            {
                index = random.Next(Themecolor.colors.Count);
            }
            tempinedx = index;
            string color = Themecolor.colors[index];
            return ColorTranslator.FromHtml(color);
        }

        private void activatebutton(object btnsender)
        {
            if (btnsender != null)
            {
                if (btnCancel != (Button)btnsender)
                {
                    disablebutton();
                    Color color = SelectThemecolor();
                    btnCancel = (Button)btnsender;
                    btnCancel.BackColor = color;
                    btnCancel.ForeColor = Color.White;
                    btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    paneltitlebar.BackColor = color;
                    panellogo.BackColor = Themecolor.ChangeColorBrightness(color, -0.3);
                    Themecolor.primarycolors = color;
                    Themecolor.secondarycolors = Themecolor.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void disablebutton()
        {
            foreach (Control previousBtn in panelmenu.Controls)
            {
                previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                previousBtn.ForeColor = Color.Gainsboro;
                previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

        private void openchildform(Form childform, object btnsender)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activatebutton(btnsender);
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.paneldesktop.Controls.Add(childform);
            this.paneldesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
            labeltitle.Text = childform.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void paneldesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paneltitlebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttondoanhthu_Click_1(object sender, EventArgs e)
        {
            openchildform(new GUI.form.Frmdoanhthu(), sender);
        }

        private void buttondulieu_Click_1(object sender, EventArgs e)
        {
            openchildform(new GUI.form.Frmdulieu(), sender);
        }

        private void buttonnhanvien_Click_1(object sender, EventArgs e)
        {
            openchildform(new GUI.form.Frmnhanvien(), sender);
        }

        private void buttonkhachhang_Click_1(object sender, EventArgs e)
        {
            openchildform(new GUI.form.Frmkhachhang(), sender);
        }

        private void buttontaikhoan_Click_1(object sender, EventArgs e)
        {
            openchildform(new GUI.form.Frmtaikhoan(), sender);
        }

        private void buttonphim_Click(object sender, EventArgs e)
        {
            openchildform(new GUI.Forms.Frmphim(), sender);
        }
    }
}
