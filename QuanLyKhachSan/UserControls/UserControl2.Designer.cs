namespace QuanLyKhachSan.UserControls
{
    partial class UserControl2
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKhoitao2 = new System.Windows.Forms.Button();
            this.txt9 = new System.Windows.Forms.TextBox();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.lbDiachiNV = new System.Windows.Forms.Label();
            this.lbSDTNV = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 73);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(933, 306);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(795, 16);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 33);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(628, 16);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 33);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(463, 16);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 33);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(293, 17);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 32);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch2
            // 
            this.txtSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch2.Location = new System.Drawing.Point(36, 17);
            this.txtSearch2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch2.Name = "txtSearch2";
            this.txtSearch2.Size = new System.Drawing.Size(216, 30);
            this.txtSearch2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKhoitao2);
            this.groupBox1.Controls.Add(this.txt9);
            this.groupBox1.Controls.Add(this.txt8);
            this.groupBox1.Controls.Add(this.txt7);
            this.groupBox1.Controls.Add(this.txt6);
            this.groupBox1.Controls.Add(this.lbDiachiNV);
            this.groupBox1.Controls.Add(this.lbSDTNV);
            this.groupBox1.Controls.Add(this.lbTenNV);
            this.groupBox1.Controls.Add(this.lbMaNV);
            this.groupBox1.Location = new System.Drawing.Point(0, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 106);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // btnKhoitao2
            // 
            this.btnKhoitao2.Location = new System.Drawing.Point(784, 42);
            this.btnKhoitao2.Name = "btnKhoitao2";
            this.btnKhoitao2.Size = new System.Drawing.Size(75, 23);
            this.btnKhoitao2.TabIndex = 8;
            this.btnKhoitao2.Text = "Khởi tạo";
            this.btnKhoitao2.UseVisualStyleBackColor = true;
            this.btnKhoitao2.Click += new System.EventHandler(this.btnKhoitao2_Click);
            // 
            // txt9
            // 
            this.txt9.Location = new System.Drawing.Point(533, 65);
            this.txt9.Name = "txt9";
            this.txt9.Size = new System.Drawing.Size(192, 22);
            this.txt9.TabIndex = 7;
            // 
            // txt8
            // 
            this.txt8.Location = new System.Drawing.Point(533, 28);
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(192, 22);
            this.txt8.TabIndex = 6;
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(167, 65);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(120, 22);
            this.txt7.TabIndex = 5;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(167, 24);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(120, 22);
            this.txt6.TabIndex = 4;
            // 
            // lbDiachiNV
            // 
            this.lbDiachiNV.AutoSize = true;
            this.lbDiachiNV.Location = new System.Drawing.Point(439, 68);
            this.lbDiachiNV.Name = "lbDiachiNV";
            this.lbDiachiNV.Size = new System.Drawing.Size(47, 16);
            this.lbDiachiNV.TabIndex = 3;
            this.lbDiachiNV.Text = "Địa chỉ";
            // 
            // lbSDTNV
            // 
            this.lbSDTNV.AutoSize = true;
            this.lbSDTNV.Location = new System.Drawing.Point(439, 31);
            this.lbSDTNV.Name = "lbSDTNV";
            this.lbSDTNV.Size = new System.Drawing.Size(85, 16);
            this.lbSDTNV.TabIndex = 2;
            this.lbSDTNV.Text = "Số điện thoại";
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Location = new System.Drawing.Point(43, 68);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(91, 16);
            this.lbTenNV.TabIndex = 1;
            this.lbTenNV.Text = "Tên nhân viên";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(43, 31);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(86, 16);
            this.lbMaNV.TabIndex = 0;
            this.lbMaNV.Text = "Mã nhân viên";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch2);
            this.Controls.Add(this.dataGridView2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(933, 492);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt9;
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.Label lbDiachiNV;
        private System.Windows.Forms.Label lbSDTNV;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Button btnKhoitao2;
    }
}
