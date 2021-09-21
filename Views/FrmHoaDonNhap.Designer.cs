namespace PMQLBanHang.Views
{
    partial class FrmHoaDonNhap
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
            this.dgr_hoadonnhap = new System.Windows.Forms.DataGridView();
            this.dgr_chitiet_hdn = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Xóa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_ThemHD = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNhap = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbThanhToan = new System.Windows.Forms.ComboBox();
            this.btn_Detail = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_hoadonnhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_chitiet_hdn)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgr_hoadonnhap
            // 
            this.dgr_hoadonnhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgr_hoadonnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_hoadonnhap.Location = new System.Drawing.Point(12, 76);
            this.dgr_hoadonnhap.Name = "dgr_hoadonnhap";
            this.dgr_hoadonnhap.Size = new System.Drawing.Size(402, 242);
            this.dgr_hoadonnhap.TabIndex = 0;
            this.dgr_hoadonnhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_hoadonnhap_CellClick);
            // 
            // dgr_chitiet_hdn
            // 
            this.dgr_chitiet_hdn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgr_chitiet_hdn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_chitiet_hdn.Location = new System.Drawing.Point(457, 76);
            this.dgr_chitiet_hdn.Name = "dgr_chitiet_hdn";
            this.dgr_chitiet_hdn.Size = new System.Drawing.Size(412, 242);
            this.dgr_chitiet_hdn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(657, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Người Dùng :";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(748, 13);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(106, 16);
            this.lbUser.TabIndex = 3;
            this.lbUser.Text = "Tên Người Dùng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh Sách Hóa Đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(581, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chi Tiết Hóa Đơn";
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHD.Location = new System.Drawing.Point(748, 57);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(50, 16);
            this.lbMaHD.TabIndex = 6;
            this.lbMaHD.Text = "Mã HD";
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Location = new System.Drawing.Point(776, 402);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(93, 68);
            this.btn_thanhtoan.TabIndex = 7;
            this.btn_thanhtoan.Text = "Thanh Toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(627, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng Tiền :";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Enabled = false;
            this.txtTongtien.Location = new System.Drawing.Point(709, 352);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(160, 20);
            this.txtTongtien.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Xóa);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_ThemHD);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 152);
            this.panel1.TabIndex = 10;
            // 
            // btn_Xóa
            // 
            this.btn_Xóa.Location = new System.Drawing.Point(322, 111);
            this.btn_Xóa.Name = "btn_Xóa";
            this.btn_Xóa.Size = new System.Drawing.Size(80, 35);
            this.btn_Xóa.TabIndex = 8;
            this.btn_Xóa.Text = "Xóa";
            this.btn_Xóa.UseVisualStyleBackColor = true;
            this.btn_Xóa.Click += new System.EventHandler(this.btn_Xóa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(171, 111);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(80, 35);
            this.btn_Sua.TabIndex = 7;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_ThemHD
            // 
            this.btn_ThemHD.Location = new System.Drawing.Point(34, 111);
            this.btn_ThemHD.Name = "btn_ThemHD";
            this.btn_ThemHD.Size = new System.Drawing.Size(80, 35);
            this.btn_ThemHD.TabIndex = 6;
            this.btn_ThemHD.Text = "Thêm";
            this.btn_ThemHD.UseVisualStyleBackColor = true;
            this.btn_ThemHD.Click += new System.EventHandler(this.btn_ThemHD_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtTrangthai);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(239, 62);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(193, 27);
            this.panel5.TabIndex = 5;
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Enabled = false;
            this.txtTrangthai.Location = new System.Drawing.Point(83, 3);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(107, 20);
            this.txtTrangthai.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Trạng Thái :";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.dtpNhap);
            this.panel4.Location = new System.Drawing.Point(205, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 27);
            this.panel4.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày Nhập:";
            // 
            // dtpNhap
            // 
            this.dtpNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNhap.Location = new System.Drawing.Point(94, 3);
            this.dtpNhap.Name = "dtpNhap";
            this.dtpNhap.Size = new System.Drawing.Size(130, 20);
            this.dtpNhap.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbNhanVien);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(19, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 28);
            this.panel3.TabIndex = 2;
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(70, 2);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(141, 21);
            this.cbNhanVien.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nhân Viên :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMaHD);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(19, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 28);
            this.panel2.TabIndex = 1;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(69, 4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(101, 20);
            this.txtMaHD.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã HD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông Tin Hóa Đơn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(330, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(246, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Quản Lý Hóa Đơn Nhập Hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(545, 406);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Hình Thức :";
            // 
            // cbThanhToan
            // 
            this.cbThanhToan.FormattingEnabled = true;
            this.cbThanhToan.Location = new System.Drawing.Point(640, 401);
            this.cbThanhToan.Name = "cbThanhToan";
            this.cbThanhToan.Size = new System.Drawing.Size(121, 21);
            this.cbThanhToan.TabIndex = 13;
            // 
            // btn_Detail
            // 
            this.btn_Detail.Location = new System.Drawing.Point(486, 345);
            this.btn_Detail.Name = "btn_Detail";
            this.btn_Detail.Size = new System.Drawing.Size(114, 31);
            this.btn_Detail.TabIndex = 14;
            this.btn_Detail.Text = "Xem Chi Tiết";
            this.btn_Detail.UseVisualStyleBackColor = true;
            this.btn_Detail.Click += new System.EventHandler(this.btn_Detail_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Thống Kê Tiền Nhập";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Detail);
            this.Controls.Add(this.cbThanhToan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_thanhtoan);
            this.Controls.Add(this.lbMaHD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgr_chitiet_hdn);
            this.Controls.Add(this.dgr_hoadonnhap);
            this.Name = "FrmHoaDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Hóa Đơn Nhập Hàng";
            this.Load += new System.EventHandler(this.FrmHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_hoadonnhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_chitiet_hdn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgr_hoadonnhap;
        private System.Windows.Forms.DataGridView dgr_chitiet_hdn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNhap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.Button btn_ThemHD;
        private System.Windows.Forms.Button btn_Xóa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbThanhToan;
        private System.Windows.Forms.Button btn_Detail;
        private System.Windows.Forms.Button button1;
    }
}