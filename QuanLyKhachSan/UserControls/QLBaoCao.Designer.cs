namespace QuanLyKhachSan.UserControls
{
    partial class QLBaoCao
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
            this.GbxHD = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNgayTra = new System.Windows.Forms.TextBox();
            this.txtNgayNhan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GbxHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(577, 546);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GbxHD
            // 
            this.GbxHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.GbxHD.Controls.Add(this.button1);
            this.GbxHD.Controls.Add(this.txtNgayTra);
            this.GbxHD.Controls.Add(this.txtNgayNhan);
            this.GbxHD.Controls.Add(this.label8);
            this.GbxHD.Controls.Add(this.label3);
            this.GbxHD.Controls.Add(this.txtMaHD);
            this.GbxHD.Controls.Add(this.label6);
            this.GbxHD.Controls.Add(this.txtPhong);
            this.GbxHD.Controls.Add(this.label5);
            this.GbxHD.Controls.Add(this.txtKH);
            this.GbxHD.Controls.Add(this.label2);
            this.GbxHD.Controls.Add(this.txtHD);
            this.GbxHD.Controls.Add(this.label1);
            this.GbxHD.Location = new System.Drawing.Point(586, 3);
            this.GbxHD.Name = "GbxHD";
            this.GbxHD.Size = new System.Drawing.Size(427, 546);
            this.GbxHD.TabIndex = 1;
            this.GbxHD.TabStop = false;
            this.GbxHD.Text = "Thông tin hóa đơn";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 74);
            this.button1.TabIndex = 17;
            this.button1.Text = "Xuất file exel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtNgayTra
            // 
            this.txtNgayTra.Location = new System.Drawing.Point(150, 357);
            this.txtNgayTra.Name = "txtNgayTra";
            this.txtNgayTra.Size = new System.Drawing.Size(127, 22);
            this.txtNgayTra.TabIndex = 16;
            // 
            // txtNgayNhan
            // 
            this.txtNgayNhan.Location = new System.Drawing.Point(150, 313);
            this.txtNgayNhan.Name = "txtNgayNhan";
            this.txtNgayNhan.Size = new System.Drawing.Size(127, 22);
            this.txtNgayNhan.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ngày trả phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ngày nhận phòng";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(150, 220);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(127, 22);
            this.txtMaHD.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mã hóa đơn";
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(150, 175);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(127, 22);
            this.txtPhong.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phòng";
            // 
            // txtKH
            // 
            this.txtKH.Location = new System.Drawing.Point(150, 85);
            this.txtKH.Name = "txtKH";
            this.txtKH.Size = new System.Drawing.Size(127, 22);
            this.txtKH.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Khách hàng";
            // 
            // txtHD
            // 
            this.txtHD.Enabled = false;
            this.txtHD.Location = new System.Drawing.Point(150, 40);
            this.txtHD.Name = "txtHD";
            this.txtHD.Size = new System.Drawing.Size(127, 22);
            this.txtHD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng hóa đơn";
            // 
            // QLBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GbxHD);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QLBaoCao";
            this.Size = new System.Drawing.Size(1013, 549);
            this.Load += new System.EventHandler(this.UserControl5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GbxHD.ResumeLayout(false);
            this.GbxHD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox GbxHD;
        private System.Windows.Forms.TextBox txtHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNgayTra;
        private System.Windows.Forms.TextBox txtNgayNhan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}
