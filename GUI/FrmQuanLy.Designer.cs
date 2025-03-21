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
            this.panelmenu.SuspendLayout();
            this.panellogo.SuspendLayout();
            this.paneltitlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelmenu.Controls.Add(this.buttontaikhoan);
            this.panelmenu.Controls.Add(this.buttonkhachhang);
            this.panelmenu.Controls.Add(this.buttonnhanvien);
            this.panelmenu.Controls.Add(this.buttondulieu);
            this.panelmenu.Controls.Add(this.buttondoanhthu);
            this.panelmenu.Controls.Add(this.panellogo);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(220, 349);
            this.panelmenu.TabIndex = 0;
            // 
            // buttontaikhoan
            // 
            this.buttontaikhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttontaikhoan.FlatAppearance.BorderSize = 0;
            this.buttontaikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttontaikhoan.ForeColor = System.Drawing.Color.White;
            this.buttontaikhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttontaikhoan.Location = new System.Drawing.Point(0, 256);
            this.buttontaikhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttontaikhoan.Name = "buttontaikhoan";
            this.buttontaikhoan.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttontaikhoan.Size = new System.Drawing.Size(220, 48);
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
            this.buttonkhachhang.Location = new System.Drawing.Point(0, 208);
            this.buttonkhachhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonkhachhang.Name = "buttonkhachhang";
            this.buttonkhachhang.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonkhachhang.Size = new System.Drawing.Size(220, 48);
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
            this.buttonnhanvien.Location = new System.Drawing.Point(0, 160);
            this.buttonnhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonnhanvien.Name = "buttonnhanvien";
            this.buttonnhanvien.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonnhanvien.Size = new System.Drawing.Size(220, 48);
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
            this.buttondulieu.Location = new System.Drawing.Point(0, 112);
            this.buttondulieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttondulieu.Name = "buttondulieu";
            this.buttondulieu.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttondulieu.Size = new System.Drawing.Size(220, 48);
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
            this.buttondoanhthu.Location = new System.Drawing.Point(0, 64);
            this.buttondoanhthu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttondoanhthu.Name = "buttondoanhthu";
            this.buttondoanhthu.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttondoanhthu.Size = new System.Drawing.Size(220, 48);
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
            this.panellogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(220, 64);
            this.panellogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(79, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CINER";
            // 
            // paneltitlebar
            // 
            this.paneltitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.paneltitlebar.Controls.Add(this.labeltitle);
            this.paneltitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitlebar.Location = new System.Drawing.Point(220, 0);
            this.paneltitlebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paneltitlebar.Name = "paneltitlebar";
            this.paneltitlebar.Size = new System.Drawing.Size(527, 64);
            this.paneltitlebar.TabIndex = 1;
            this.paneltitlebar.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltitlebar_Paint);
            // 
            // labeltitle
            // 
            this.labeltitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.ForeColor = System.Drawing.Color.White;
            this.labeltitle.Location = new System.Drawing.Point(207, 16);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(95, 31);
            this.labeltitle.TabIndex = 0;
            this.labeltitle.Text = "HOME";
            // 
            // paneldesktop
            // 
            this.paneldesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldesktop.Location = new System.Drawing.Point(220, 64);
            this.paneldesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paneldesktop.Name = "paneldesktop";
            this.paneldesktop.Size = new System.Drawing.Size(527, 285);
            this.paneldesktop.TabIndex = 2;
            this.paneldesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.paneldesktop_Paint);
            // 
            // FrmTrangchinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 349);
            this.Controls.Add(this.paneldesktop);
            this.Controls.Add(this.paneltitlebar);
            this.Controls.Add(this.panelmenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTrangchinh";
            this.Text = "Form1";
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
    }
}
