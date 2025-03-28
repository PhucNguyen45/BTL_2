namespace Winform_Nhom20_BTL.GUI
{
    partial class Room_Chosing
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Film_Playing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seat_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seat_Per_Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(29, 112);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 21);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Còn trống";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "DANH SÁCH CÁC PHÒNG CHIẾU CÒN TRỐNG";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Room,
            this.Room_Number,
            this.Film_Playing,
            this.Seat_Count,
            this.Seat_Per_Room});
            this.dataGridView1.Location = new System.Drawing.Point(29, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(993, 437);
            this.dataGridView1.TabIndex = 7;
            // 
            // ID_Room
            // 
            this.ID_Room.HeaderText = "ID";
            this.ID_Room.Name = "ID_Room";
            this.ID_Room.Width = 43;
            // 
            // Room_Number
            // 
            this.Room_Number.HeaderText = "Phòng Chiếu";
            this.Room_Number.Name = "Room_Number";
            this.Room_Number.Width = 93;
            // 
            // Film_Playing
            // 
            this.Film_Playing.HeaderText = "Phim";
            this.Film_Playing.Name = "Film_Playing";
            this.Film_Playing.Width = 55;
            // 
            // Seat_Count
            // 
            this.Seat_Count.HeaderText = "Số Ghế Trống";
            this.Seat_Count.Name = "Seat_Count";
            this.Seat_Count.Width = 99;
            // 
            // Seat_Per_Room
            // 
            this.Seat_Per_Room.HeaderText = "Số Ghế";
            this.Seat_Per_Room.Name = "Seat_Per_Room";
            this.Seat_Per_Room.Width = 68;
            // 
            // Room_Chosing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Room_Chosing";
            this.Size = new System.Drawing.Size(1055, 598);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Film_Playing;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seat_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seat_Per_Room;
    }
}
