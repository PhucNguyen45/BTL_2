namespace Winform_Nhom20_BTL.GUI.UCs_Main
{
    partial class DateTime_Chosing
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
            this.Time_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Time_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Time_Panel
            // 
            this.Time_Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Time_Panel.AutoScroll = true;
            this.Time_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Time_Panel.BackColor = System.Drawing.Color.Moccasin;
            this.Time_Panel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.Time_Panel.Controls.Add(this.dataGridView1);
            this.Time_Panel.CustomBorderColor = System.Drawing.Color.Black;
            this.Time_Panel.CustomBorderThickness = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Time_Panel.Location = new System.Drawing.Point(-10, 183);
            this.Time_Panel.Name = "Time_Panel";
            this.Time_Panel.Size = new System.Drawing.Size(591, 444);
            this.Time_Panel.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(556, 411);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DateTime_Chosing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Time_Panel);
            this.Name = "DateTime_Chosing";
            this.Size = new System.Drawing.Size(581, 627);
            this.Time_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Time_Panel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
