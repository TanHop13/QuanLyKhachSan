namespace QuanLyKhachSan.UserControls
{
    partial class UserControl6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbDatPhong = new System.Windows.Forms.Label();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.DVG1 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtLoai = new System.Windows.Forms.TextBox();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.txtMaP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.DVG1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(757, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbDatPhong
            // 
            this.lbDatPhong.AutoSize = true;
            this.lbDatPhong.Location = new System.Drawing.Point(300, 34);
            this.lbDatPhong.Name = "lbDatPhong";
            this.lbDatPhong.Size = new System.Drawing.Size(68, 16);
            this.lbDatPhong.TabIndex = 1;
            this.lbDatPhong.Text = "Đặt phòng";
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Location = new System.Drawing.Point(552, 30);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(75, 23);
            this.btnDatPhong.TabIndex = 2;
            this.btnDatPhong.Text = "Xác nhận đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // DVG1
            // 
            this.DVG1.Controls.Add(this.txtId);
            this.DVG1.Controls.Add(this.lb);
            this.DVG1.Controls.Add(this.dateTimePicker2);
            this.DVG1.Controls.Add(this.label5);
            this.DVG1.Controls.Add(this.label4);
            this.DVG1.Controls.Add(this.dateTimePicker1);
            this.DVG1.Controls.Add(this.txtLoai);
            this.DVG1.Controls.Add(this.txtPhong);
            this.DVG1.Controls.Add(this.txtMaP);
            this.DVG1.Controls.Add(this.label3);
            this.DVG1.Controls.Add(this.label2);
            this.DVG1.Controls.Add(this.label1);
            this.DVG1.Controls.Add(this.btnDatPhong);
            this.DVG1.Location = new System.Drawing.Point(17, 289);
            this.DVG1.Name = "DVG1";
            this.DVG1.Size = new System.Drawing.Size(737, 151);
            this.DVG1.TabIndex = 3;
            this.DVG1.TabStop = false;
            this.DVG1.Text = "Thông tin phòng";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(166, 114);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 14;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(57, 120);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(26, 16);
            this.lb.TabIndex = 13;
            this.lb.Text = "Mã";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(417, 114);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(130, 22);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày trả phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày đặt phòng";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(417, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // txtLoai
            // 
            this.txtLoai.Location = new System.Drawing.Point(407, 31);
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Size = new System.Drawing.Size(100, 22);
            this.txtLoai.TabIndex = 8;
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(166, 73);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(100, 22);
            this.txtPhong.TabIndex = 7;
            // 
            // txtMaP
            // 
            this.txtMaP.Location = new System.Drawing.Point(166, 31);
            this.txtMaP.Name = "txtMaP";
            this.txtMaP.Size = new System.Drawing.Size(100, 22);
            this.txtMaP.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Phòng";
            // 
            // UserControl6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DVG1);
            this.Controls.Add(this.lbDatPhong);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl6";
            this.Size = new System.Drawing.Size(757, 443);
            this.Load += new System.EventHandler(this.UserControl6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.DVG1.ResumeLayout(false);
            this.DVG1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbDatPhong;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.GroupBox DVG1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtLoai;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.TextBox txtMaP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lb;
    }
}
