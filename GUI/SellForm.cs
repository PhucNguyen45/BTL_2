using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
//using Winform_Nhom20_BTL.UserControls;

namespace Winform_Nhom20_BTL.GUI
{
    public partial class SellForm : Form
    {
        private int bordersize = 2;
        private Button btncancel;
        private Form actievform;
        public SellForm()
        {
            InitializeComponent();
            collapmenu();
            this.Padding = new Padding(bordersize);
            this.BackColor = Color.FromArgb(98, 102, 244);
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int xmsg, int wparam, int iparam);

        private void iconButton6_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void paneltitelbar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        private void SellForm_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != bordersize)
                        this.Padding = new Padding(bordersize);
                    break;
            }
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton6_Click_1(object sender, EventArgs e)
        {
            collapmenu();
        }

        private void collapmenu()
        {
            if (this.panelmenu.Width > 200)
            {
                panelmenu.Width = 100;
                pictureBox1.Visible = false;
                btnmenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelmenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                panelmenu.Width = 230;
                pictureBox1.Visible = true;
                btnmenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelmenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(5, 0, 0, 0);
                }

            }
        }
        private void activebutton(object sender)
        {
            if (sender != null)
            {
                if (btncancel != (Button)sender)
                {
                    disablebutton();
                    btncancel = (Button)sender;
                    btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void disablebutton()
        {
            foreach (Control privousBtn in panelmenu.Controls)
            {
                privousBtn.BackColor = Color.FromArgb(98, 102, 244);
                privousBtn.ForeColor = Color.Gainsboro;
                privousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void openchilform(Form chilform, object btnsender)
        {
            if (actievform != null) { actievform.Close(); }
            activebutton(btnsender);
            actievform = chilform;
            chilform.TopLevel = false;
            chilform.FormBorderStyle = FormBorderStyle.None;
            chilform.Dock = DockStyle.Fill;
            this.paneldeskop.Controls.Add(chilform);
            this.paneldeskop.Tag = chilform;
            chilform.BringToFront();
            chilform.Show();
            label1.Text = chilform.Text;
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            openchilform(new GUI.Forms_ban_ve.khachhang(), sender);
        }
    }
}

