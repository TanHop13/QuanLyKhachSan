
namespace QuanLyKhachSan
{
    partial class LeTan
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.btnDoiPhong = new System.Windows.Forms.Button();
            this.btnNhanP = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.cbDichVu = new System.Windows.Forms.ComboBox();
            this.btnAddDV = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ttMenuTTKH = new System.Windows.Forms.ToolStripMenuItem();
            this.ttMenuHD = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(507, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 359);
            this.panel2.TabIndex = 1;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(4, 3);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(401, 353);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbPhong);
            this.panel3.Controls.Add(this.btnDoiPhong);
            this.panel3.Controls.Add(this.btnNhanP);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Location = new System.Drawing.Point(507, 463);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(408, 84);
            this.panel3.TabIndex = 2;
            // 
            // cbPhong
            // 
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(4, 50);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(107, 24);
            this.cbPhong.TabIndex = 5;
            // 
            // btnDoiPhong
            // 
            this.btnDoiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiPhong.Location = new System.Drawing.Point(4, 5);
            this.btnDoiPhong.Name = "btnDoiPhong";
            this.btnDoiPhong.Size = new System.Drawing.Size(107, 41);
            this.btnDoiPhong.TabIndex = 4;
            this.btnDoiPhong.Text = "ĐỔI PHÒNG";
            this.btnDoiPhong.UseVisualStyleBackColor = true;
            // 
            // btnNhanP
            // 
            this.btnNhanP.Location = new System.Drawing.Point(159, 5);
            this.btnNhanP.Name = "btnNhanP";
            this.btnNhanP.Size = new System.Drawing.Size(94, 69);
            this.btnNhanP.TabIndex = 4;
            this.btnNhanP.Text = "NHẬN PHÒNG";
            this.btnNhanP.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(311, 5);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(94, 69);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "THANH TOÁN";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // cbDichVu
            // 
            this.cbDichVu.FormattingEnabled = true;
            this.cbDichVu.Location = new System.Drawing.Point(507, 57);
            this.cbDichVu.Name = "cbDichVu";
            this.cbDichVu.Size = new System.Drawing.Size(253, 24);
            this.cbDichVu.TabIndex = 3;
            // 
            // btnAddDV
            // 
            this.btnAddDV.Location = new System.Drawing.Point(766, 43);
            this.btnAddDV.Name = "btnAddDV";
            this.btnAddDV.Size = new System.Drawing.Size(94, 52);
            this.btnAddDV.TabIndex = 4;
            this.btnAddDV.Text = "THÊM";
            this.btnAddDV.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(866, 58);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 22);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // flpRoom
            // 
            this.flpRoom.AutoScroll = true;
            this.flpRoom.Location = new System.Drawing.Point(13, 45);
            this.flpRoom.Name = "flpRoom";
            this.flpRoom.Size = new System.Drawing.Size(476, 502);
            this.flpRoom.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttMenuTTKH,
            this.ttMenuHD,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ttMenuTTKH
            // 
            this.ttMenuTTKH.Name = "ttMenuTTKH";
            this.ttMenuTTKH.Size = new System.Drawing.Size(165, 24);
            this.ttMenuTTKH.Text = "Thông tin khách hàng";
            // 
            // ttMenuHD
            // 
            this.ttMenuHD.Name = "ttMenuHD";
            this.ttMenuHD.Size = new System.Drawing.Size(81, 24);
            this.ttMenuHD.Text = "Hóa đơn";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Dịch Vụ";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Dịch Vụ";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            // 
            // LeTan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 576);
            this.Controls.Add(this.flpRoom);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnAddDV);
            this.Controls.Add(this.cbDichVu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LeTan";
            this.Text = " ";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbDichVu;
        private System.Windows.Forms.Button btnAddDV;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.FlowLayoutPanel flpRoom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ttMenuTTKH;
        private System.Windows.Forms.ToolStripMenuItem ttMenuHD;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.Button btnDoiPhong;
        private System.Windows.Forms.Button btnNhanP;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}