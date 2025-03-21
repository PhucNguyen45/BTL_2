using static Guna.UI2.WinForms.Suite.Descriptions;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Winform_Nhom20_BTL
{
    partial class FrmTrangchinh
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelmenu = new System.Windows.Forms.Panel();
            this.buttontaikhoan = new System.Windows.Forms.Button();
            this.buttonkhachhang = new System.Windows.Forms.Button();
            this.buttonnhanvien = new System.Windows.Forms.Button();
            this.buttondulieu = new System.Windows.Forms.Button();
            this.buttondoanhthu = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.paneltitlebar = new System.Windows.Forms.Panel();
            this.labeltitle = new System.Windows.Forms.Label();
            this.paneldesktop = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelmenu.SuspendLayout();
            this.panellogo.SuspendLayout();
            this.paneltitlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelmenu.Controls.Add(this.button1);
            this.panelmenu.Controls.Add(this.buttontaikhoan);
            this.panelmenu.Controls.Add(this.buttonkhachhang);
            this.panelmenu.Controls.Add(this.buttonnhanvien);
            this.panelmenu.Controls.Add(this.buttondulieu);
            this.panelmenu.Controls.Add(this.buttondoanhthu);
            this.panelmenu.Controls.Add(this.panellogo);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(165, 518);
            this.panelmenu.TabIndex = 0;
            // 
            // buttontaikhoan
            // 
            this.buttontaikhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttontaikhoan.FlatAppearance.BorderSize = 0;
            this.buttontaikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttontaikhoan.ForeColor = System.Drawing.Color.White;
            this.buttontaikhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttontaikhoan.Location = new System.Drawing.Point(0, 208);
            this.buttontaikhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttontaikhoan.Name = "buttontaikhoan";
            this.buttontaikhoan.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttontaikhoan.Size = new System.Drawing.Size(165, 39);
            this.buttontaikhoan.TabIndex = 5;
            this.buttontaikhoan.Text = "Tài Khoản";
            this.buttontaikhoan.UseVisualStyleBackColor = true;
            this.buttontaikhoan.Click += new System.EventHandler(this.buttontaikhoan_Click_1);
            // 
            // buttonkhachhang
            // 
            this.buttonkhachhang.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonkhachhang.FlatAppearance.BorderSize = 0;
            this.buttonkhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonkhachhang.ForeColor = System.Drawing.Color.White;
            this.buttonkhachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonkhachhang.Location = new System.Drawing.Point(0, 169);
            this.buttonkhachhang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonkhachhang.Name = "buttonkhachhang";
            this.buttonkhachhang.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonkhachhang.Size = new System.Drawing.Size(165, 39);
            this.buttonkhachhang.TabIndex = 4;
            this.buttonkhachhang.Text = "Khách Hàng";
            this.buttonkhachhang.UseVisualStyleBackColor = true;
            this.buttonkhachhang.Click += new System.EventHandler(this.buttonkhachhang_Click_1);
            // 
            // buttonnhanvien
            // 
            this.buttonnhanvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonnhanvien.FlatAppearance.BorderSize = 0;
            this.buttonnhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonnhanvien.ForeColor = System.Drawing.Color.White;
            this.buttonnhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonnhanvien.Location = new System.Drawing.Point(0, 130);
            this.buttonnhanvien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonnhanvien.Name = "buttonnhanvien";
            this.buttonnhanvien.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonnhanvien.Size = new System.Drawing.Size(165, 39);
            this.buttonnhanvien.TabIndex = 3;
            this.buttonnhanvien.Text = "Nhân Viên";
            this.buttonnhanvien.UseVisualStyleBackColor = true;
            this.buttonnhanvien.Click += new System.EventHandler(this.buttonnhanvien_Click_1);
            // 
            // buttondulieu
            // 
            this.buttondulieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttondulieu.FlatAppearance.BorderSize = 0;
            this.buttondulieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondulieu.ForeColor = System.Drawing.Color.White;
            this.buttondulieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttondulieu.Location = new System.Drawing.Point(0, 91);
            this.buttondulieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttondulieu.Name = "buttondulieu";
            this.buttondulieu.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttondulieu.Size = new System.Drawing.Size(165, 39);
            this.buttondulieu.TabIndex = 2;
            this.buttondulieu.Text = "Dữ Liệu";
            this.buttondulieu.UseVisualStyleBackColor = true;
            this.buttondulieu.Click += new System.EventHandler(this.buttondulieu_Click_1);
            // 
            // buttondoanhthu
            // 
            this.buttondoanhthu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttondoanhthu.FlatAppearance.BorderSize = 0;
            this.buttondoanhthu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondoanhthu.ForeColor = System.Drawing.Color.White;
            this.buttondoanhthu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttondoanhthu.Location = new System.Drawing.Point(0, 52);
            this.buttondoanhthu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttondoanhthu.Name = "buttondoanhthu";
            this.buttondoanhthu.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttondoanhthu.Size = new System.Drawing.Size(165, 39);
            this.buttondoanhthu.TabIndex = 1;
            this.buttondoanhthu.Text = "Doanh Thu";
            this.buttondoanhthu.UseVisualStyleBackColor = true;
            this.buttondoanhthu.Click += new System.EventHandler(this.buttondoanhthu_Click_1);
            // 
            // panellogo
            // 
            this.panellogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panellogo.Controls.Add(this.label1);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(165, 52);
            this.panellogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(59, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CINER";
            // 
            // paneltitlebar
            // 
            this.paneltitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.paneltitlebar.Controls.Add(this.labeltitle);
            this.paneltitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitlebar.Location = new System.Drawing.Point(165, 0);
            this.paneltitlebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paneltitlebar.Name = "paneltitlebar";
            this.paneltitlebar.Size = new System.Drawing.Size(615, 52);
            this.paneltitlebar.TabIndex = 1;
            this.paneltitlebar.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltitlebar_Paint);
            // 
            // labeltitle
            // 
            this.labeltitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.ForeColor = System.Drawing.Color.White;
            this.labeltitle.Location = new System.Drawing.Point(265, 13);
            this.labeltitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(78, 26);
            this.labeltitle.TabIndex = 0;
            this.labeltitle.Text = "HOME";
            // 
            // paneldesktop
            // 
            this.paneldesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldesktop.Location = new System.Drawing.Point(165, 52);
            this.paneldesktop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paneldesktop.Name = "paneldesktop";
            this.paneldesktop.Size = new System.Drawing.Size(615, 466);
            this.paneldesktop.TabIndex = 2;
            this.paneldesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.paneldesktop_Paint);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "ĐĂNG XUẤT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmTrangchinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 518);
            this.Controls.Add(this.paneldesktop);
            this.Controls.Add(this.paneltitlebar);
            this.Controls.Add(this.panelmenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmTrangchinh";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelmenu.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            this.paneltitlebar.ResumeLayout(false);
            this.paneltitlebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelmenu;
        private Button buttondoanhthu;
        private Panel panellogo;
        private Button buttontaikhoan;
        private Button buttonkhachhang;
        private Button buttonnhanvien;
        private Button buttondulieu;
        private Panel paneltitlebar;
        private Label labeltitle;
        private Label label1;
        private Panel paneldesktop;
        private Button button1;
    }
}
