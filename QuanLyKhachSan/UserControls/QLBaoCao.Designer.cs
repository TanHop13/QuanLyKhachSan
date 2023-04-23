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
            this.txtNhanvien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDV = new System.Windows.Forms.TextBox();
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
            this.GbxHD.Controls.Add(this.txtNhanvien);
            this.GbxHD.Controls.Add(this.label7);
            this.GbxHD.Controls.Add(this.txtMaHD);
            this.GbxHD.Controls.Add(this.label6);
            this.GbxHD.Controls.Add(this.txtPhong);
            this.GbxHD.Controls.Add(this.label5);
            this.GbxHD.Controls.Add(this.label4);
            this.GbxHD.Controls.Add(this.txtDV);
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
            // txtNhanvien
            // 
            this.txtNhanvien.Location = new System.Drawing.Point(150, 265);
            this.txtNhanvien.Name = "txtNhanvien";
            this.txtNhanvien.Size = new System.Drawing.Size(127, 22);
            this.txtNhanvien.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nhân viên";
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
            this.label6.Size = new System.Drawing.Size(83, 17);
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
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dịch vụ";
            // 
            // txtDV
            // 
            this.txtDV.Location = new System.Drawing.Point(150, 130);
            this.txtDV.Name = "txtDV";
            this.txtDV.Size = new System.Drawing.Size(127, 22);
            this.txtDV.TabIndex = 5;
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
            this.label2.Size = new System.Drawing.Size(84, 17);
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
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng hóa đơn";
            // 
            // UserControl5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GbxHD);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl5";
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
        private System.Windows.Forms.TextBox txtDV;
        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNhanvien;
        private System.Windows.Forms.Label label7;
    }
}
