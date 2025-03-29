using System.Drawing;

namespace Winform_Nhom20_BTL.GUI
{
    partial class SellForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellForm));
            this.Receipt_pnl = new System.Windows.Forms.Panel();
            this.label_Seat = new System.Windows.Forms.Label();
            this.label_Room = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.label_Film = new System.Windows.Forms.Label();
            this.label_Birthdate = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_CCCD = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CustomerInfo_tab = new System.Windows.Forms.TabPage();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.Confirm_btn = new System.Windows.Forms.Button();
            this.Birthdate_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Address_txtbox = new System.Windows.Forms.TextBox();
            this.CCCD_txtbox = new System.Windows.Forms.TextBox();
            this.Phone_txtbox = new System.Windows.Forms.TextBox();
            this.Name_txtbox = new System.Windows.Forms.TextBox();
            this.FilmChoosing_tab = new System.Windows.Forms.TabPage();
            this.Room_tab = new System.Windows.Forms.TabPage();
            this.Seat_tab = new System.Windows.Forms.TabPage();
            this.CloseSellFom_btn = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Receipt_pnl.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.CustomerInfo_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseSellFom_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // Receipt_pnl
            // 
            this.Receipt_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Receipt_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Receipt_pnl.Controls.Add(this.label_Seat);
            this.Receipt_pnl.Controls.Add(this.label_Room);
            this.Receipt_pnl.Controls.Add(this.label_Time);
            this.Receipt_pnl.Controls.Add(this.label_Film);
            this.Receipt_pnl.Controls.Add(this.label_Birthdate);
            this.Receipt_pnl.Controls.Add(this.label_Address);
            this.Receipt_pnl.Controls.Add(this.label_CCCD);
            this.Receipt_pnl.Controls.Add(this.label_Phone);
            this.Receipt_pnl.Controls.Add(this.label_Name);
            this.Receipt_pnl.Controls.Add(this.label6);
            this.Receipt_pnl.Location = new System.Drawing.Point(801, 64);
            this.Receipt_pnl.Name = "Receipt_pnl";
            this.Receipt_pnl.Size = new System.Drawing.Size(336, 578);
            this.Receipt_pnl.TabIndex = 1;
            // 
            // label_Seat
            // 
            this.label_Seat.AutoSize = true;
            this.label_Seat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Seat.Location = new System.Drawing.Point(3, 443);
            this.label_Seat.Name = "label_Seat";
            this.label_Seat.Size = new System.Drawing.Size(76, 21);
            this.label_Seat.TabIndex = 9;
            this.label_Seat.Text = "Số Ghế: ";
            // 
            // label_Room
            // 
            this.label_Room.AutoSize = true;
            this.label_Room.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Room.Location = new System.Drawing.Point(3, 393);
            this.label_Room.Name = "label_Room";
            this.label_Room.Size = new System.Drawing.Size(115, 21);
            this.label_Room.TabIndex = 8;
            this.label_Room.Text = "Phòng Chiếu: ";
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Time.Location = new System.Drawing.Point(3, 344);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(100, 21);
            this.label_Time.TabIndex = 7;
            this.label_Time.Text = "Suất Chiếu: ";
            // 
            // label_Film
            // 
            this.label_Film.AutoSize = true;
            this.label_Film.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Film.Location = new System.Drawing.Point(3, 295);
            this.label_Film.Name = "label_Film";
            this.label_Film.Size = new System.Drawing.Size(52, 21);
            this.label_Film.TabIndex = 6;
            this.label_Film.Text = "Phim:";
            // 
            // label_Birthdate
            // 
            this.label_Birthdate.AutoSize = true;
            this.label_Birthdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Birthdate.Location = new System.Drawing.Point(3, 249);
            this.label_Birthdate.Name = "label_Birthdate";
            this.label_Birthdate.Size = new System.Drawing.Size(96, 21);
            this.label_Birthdate.TabIndex = 5;
            this.label_Birthdate.Text = "Ngày Sinh: ";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Address.Location = new System.Drawing.Point(3, 205);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(78, 21);
            this.label_Address.TabIndex = 4;
            this.label_Address.Text = "Địa Chỉ: ";
            // 
            // label_CCCD
            // 
            this.label_CCCD.AutoSize = true;
            this.label_CCCD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CCCD.Location = new System.Drawing.Point(3, 159);
            this.label_CCCD.Name = "label_CCCD";
            this.label_CCCD.Size = new System.Drawing.Size(71, 21);
            this.label_CCCD.TabIndex = 3;
            this.label_CCCD.Text = "CCCD: ";
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Phone.Location = new System.Drawing.Point(3, 113);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(128, 21);
            this.label_Phone.TabIndex = 2;
            this.label_Phone.Text = "Số Điện Thoại: ";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(3, 68);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(145, 21);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Tên Khách Hàng: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(110, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hóa Đơn";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.CustomerInfo_tab);
            this.tabControl1.Controls.Add(this.FilmChoosing_tab);
            this.tabControl1.Controls.Add(this.Room_tab);
            this.tabControl1.Controls.Add(this.Seat_tab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(783, 690);
            this.tabControl1.TabIndex = 0;
            // 
            // CustomerInfo_tab
            // 
            this.CustomerInfo_tab.BackColor = System.Drawing.Color.LightSlateGray;
            this.CustomerInfo_tab.Controls.Add(this.label7);
            this.CustomerInfo_tab.Controls.Add(this.Logout_btn);
            this.CustomerInfo_tab.Controls.Add(this.Confirm_btn);
            this.CustomerInfo_tab.Controls.Add(this.Birthdate_txtbox);
            this.CustomerInfo_tab.Controls.Add(this.label5);
            this.CustomerInfo_tab.Controls.Add(this.label4);
            this.CustomerInfo_tab.Controls.Add(this.label3);
            this.CustomerInfo_tab.Controls.Add(this.label2);
            this.CustomerInfo_tab.Controls.Add(this.label1);
            this.CustomerInfo_tab.Controls.Add(this.Address_txtbox);
            this.CustomerInfo_tab.Controls.Add(this.CCCD_txtbox);
            this.CustomerInfo_tab.Controls.Add(this.Phone_txtbox);
            this.CustomerInfo_tab.Controls.Add(this.Name_txtbox);
            this.CustomerInfo_tab.Location = new System.Drawing.Point(4, 22);
            this.CustomerInfo_tab.Name = "CustomerInfo_tab";
            this.CustomerInfo_tab.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerInfo_tab.Size = new System.Drawing.Size(775, 664);
            this.CustomerInfo_tab.TabIndex = 1;
            this.CustomerInfo_tab.Text = "Thông Tin Khách Hàng";
            // 
            // Logout_btn
            // 
            this.Logout_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Logout_btn.Location = new System.Drawing.Point(3, 628);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(94, 33);
            this.Logout_btn.TabIndex = 13;
            this.Logout_btn.Text = "Log Out";
            this.Logout_btn.UseVisualStyleBackColor = true;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Confirm_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_btn.Location = new System.Drawing.Point(294, 407);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(141, 46);
            this.Confirm_btn.TabIndex = 12;
            this.Confirm_btn.Text = "XÁC NHẬN";
            this.Confirm_btn.UseVisualStyleBackColor = true;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // Birthdate_txtbox
            // 
            this.Birthdate_txtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Birthdate_txtbox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthdate_txtbox.Location = new System.Drawing.Point(277, 316);
            this.Birthdate_txtbox.Name = "Birthdate_txtbox";
            this.Birthdate_txtbox.Size = new System.Drawing.Size(300, 35);
            this.Birthdate_txtbox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số CCCD";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số Điện Thoại";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Họ Và Tên Khách";
            // 
            // Address_txtbox
            // 
            this.Address_txtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Address_txtbox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_txtbox.Location = new System.Drawing.Point(277, 272);
            this.Address_txtbox.Name = "Address_txtbox";
            this.Address_txtbox.Size = new System.Drawing.Size(300, 35);
            this.Address_txtbox.TabIndex = 3;
            // 
            // CCCD_txtbox
            // 
            this.CCCD_txtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCCD_txtbox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCCD_txtbox.Location = new System.Drawing.Point(277, 226);
            this.CCCD_txtbox.Name = "CCCD_txtbox";
            this.CCCD_txtbox.Size = new System.Drawing.Size(300, 35);
            this.CCCD_txtbox.TabIndex = 2;
            // 
            // Phone_txtbox
            // 
            this.Phone_txtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Phone_txtbox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_txtbox.Location = new System.Drawing.Point(277, 180);
            this.Phone_txtbox.Name = "Phone_txtbox";
            this.Phone_txtbox.Size = new System.Drawing.Size(300, 35);
            this.Phone_txtbox.TabIndex = 1;
            // 
            // Name_txtbox
            // 
            this.Name_txtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Name_txtbox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_txtbox.Location = new System.Drawing.Point(277, 132);
            this.Name_txtbox.Name = "Name_txtbox";
            this.Name_txtbox.Size = new System.Drawing.Size(300, 35);
            this.Name_txtbox.TabIndex = 0;
            // 
            // FilmChoosing_tab
            // 
            this.FilmChoosing_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FilmChoosing_tab.Location = new System.Drawing.Point(4, 22);
            this.FilmChoosing_tab.Name = "FilmChoosing_tab";
            this.FilmChoosing_tab.Padding = new System.Windows.Forms.Padding(3);
            this.FilmChoosing_tab.Size = new System.Drawing.Size(775, 664);
            this.FilmChoosing_tab.TabIndex = 0;
            this.FilmChoosing_tab.Text = "Chọn Phim";
            // 
            // Room_tab
            // 
            this.Room_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Room_tab.Location = new System.Drawing.Point(4, 22);
            this.Room_tab.Name = "Room_tab";
            this.Room_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Room_tab.Size = new System.Drawing.Size(775, 664);
            this.Room_tab.TabIndex = 2;
            this.Room_tab.Text = "Chọn Phòng Chiếu";
            // 
            // Seat_tab
            // 
            this.Seat_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Seat_tab.Location = new System.Drawing.Point(4, 22);
            this.Seat_tab.Name = "Seat_tab";
            this.Seat_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Seat_tab.Size = new System.Drawing.Size(775, 664);
            this.Seat_tab.TabIndex = 3;
            this.Seat_tab.Text = "Chọn Ghế";
            // 
            // CloseSellFom_btn
            // 
            this.CloseSellFom_btn.Image = ((System.Drawing.Image)(resources.GetObject("CloseSellFom_btn.Image")));
            this.CloseSellFom_btn.Location = new System.Drawing.Point(1098, 0);
            this.CloseSellFom_btn.Name = "CloseSellFom_btn";
            this.CloseSellFom_btn.Size = new System.Drawing.Size(27, 24);
            this.CloseSellFom_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseSellFom_btn.TabIndex = 2;
            this.CloseSellFom_btn.TabStop = false;
            this.CloseSellFom_btn.Click += new System.EventHandler(this.CloseSellFom_btn_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Cornsilk;
            this.label7.Location = new System.Drawing.Point(162, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(425, 42);
            this.label7.TabIndex = 14;
            this.label7.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1149, 714);
            this.Controls.Add(this.CloseSellFom_btn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Receipt_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellForm";
            this.Text = "Cineer Vietnam Corp.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Receipt_pnl.ResumeLayout(false);
            this.Receipt_pnl.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.CustomerInfo_tab.ResumeLayout(false);
            this.CustomerInfo_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseSellFom_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Receipt_pnl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CustomerInfo_tab;
        private System.Windows.Forms.TabPage FilmChoosing_tab;
        private System.Windows.Forms.TextBox Phone_txtbox;
        private System.Windows.Forms.TextBox Name_txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Address_txtbox;
        private System.Windows.Forms.TextBox CCCD_txtbox;
        private System.Windows.Forms.Button Confirm_btn;
        private System.Windows.Forms.TextBox Birthdate_txtbox;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox CloseSellFom_btn;
        private System.Windows.Forms.Label label_Birthdate;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_CCCD;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Room;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label_Film;
        private System.Windows.Forms.Label label_Seat;
        private System.Windows.Forms.TabPage Room_tab;
        private System.Windows.Forms.TabPage Seat_tab;
        private System.Windows.Forms.Label label7;
    }
}