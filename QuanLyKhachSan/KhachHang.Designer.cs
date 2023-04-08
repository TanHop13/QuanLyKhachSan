namespace QuanLyKhachSan
{
    partial class KhachHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.btnGiaoDich = new System.Windows.Forms.Button();
            this.btndatPhong = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin chào";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnThongTin
            // 
            this.btnThongTin.Location = new System.Drawing.Point(68, 123);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(75, 23);
            this.btnThongTin.TabIndex = 2;
            this.btnThongTin.Text = "Thong tin";
            this.btnThongTin.UseVisualStyleBackColor = true;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // btnGiaoDich
            // 
            this.btnGiaoDich.Location = new System.Drawing.Point(68, 171);
            this.btnGiaoDich.Name = "btnGiaoDich";
            this.btnGiaoDich.Size = new System.Drawing.Size(75, 23);
            this.btnGiaoDich.TabIndex = 3;
            this.btnGiaoDich.Text = "Lịch sử giao dịch";
            this.btnGiaoDich.UseVisualStyleBackColor = true;
            this.btnGiaoDich.Click += new System.EventHandler(this.btnGiaoDich_Click);
            // 
            // btndatPhong
            // 
            this.btndatPhong.Location = new System.Drawing.Point(68, 225);
            this.btndatPhong.Name = "btndatPhong";
            this.btndatPhong.Size = new System.Drawing.Size(75, 23);
            this.btndatPhong.TabIndex = 4;
            this.btndatPhong.Text = "Đặt phòng";
            this.btndatPhong.UseVisualStyleBackColor = true;
            this.btndatPhong.Click += new System.EventHandler(this.btndatPhong_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(68, 282);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(209, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 439);
            this.panel1.TabIndex = 7;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btndatPhong);
            this.Controls.Add(this.btnGiaoDich);
            this.Controls.Add(this.btnThongTin);
            this.Controls.Add(this.groupBox1);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.Button btnGiaoDich;
        private System.Windows.Forms.Button btndatPhong;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
    }
}