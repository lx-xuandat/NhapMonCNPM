
namespace PMQLBanHang.Views
{
    partial class FrmChiTietHoaDonBan
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
            this.btnXoaSanPham = new System.Windows.Forms.Button();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.txtSoluongmua = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.txtMahang = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSohd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgrChiTietHang = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgrMatHang = new System.Windows.Forms.DataGridView();
            this.lbUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrChiTietHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoaSanPham
            // 
            this.btnXoaSanPham.Location = new System.Drawing.Point(520, 327);
            this.btnXoaSanPham.Name = "btnXoaSanPham";
            this.btnXoaSanPham.Size = new System.Drawing.Size(110, 55);
            this.btnXoaSanPham.TabIndex = 82;
            this.btnXoaSanPham.Text = "Bỏ Sản Phẩm";
            this.btnXoaSanPham.UseVisualStyleBackColor = true;
            this.btnXoaSanPham.Click += new System.EventHandler(this.btnXoaSanPham_Click);
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(837, 472);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(154, 20);
            this.txtTongtien.TabIndex = 81;
            // 
            // txtSoluongmua
            // 
            this.txtSoluongmua.Location = new System.Drawing.Point(395, 439);
            this.txtSoluongmua.Name = "txtSoluongmua";
            this.txtSoluongmua.Size = new System.Drawing.Size(105, 20);
            this.txtSoluongmua.TabIndex = 76;
            this.txtSoluongmua.Text = "1";
            this.txtSoluongmua.TextChanged += new System.EventHandler(this.txtSoluongmua_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(291, 441);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 15);
            this.label13.TabIndex = 79;
            this.label13.Text = "Số lượng mua:";
            // 
            // txtgia
            // 
            this.txtgia.Enabled = false;
            this.txtgia.Location = new System.Drawing.Point(348, 402);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(152, 20);
            this.txtgia.TabIndex = 77;
            // 
            // txtTenhang
            // 
            this.txtTenhang.Enabled = false;
            this.txtTenhang.Location = new System.Drawing.Point(107, 438);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(167, 20);
            this.txtTenhang.TabIndex = 75;
            // 
            // txtMahang
            // 
            this.txtMahang.Enabled = false;
            this.txtMahang.Location = new System.Drawing.Point(80, 402);
            this.txtMahang.Name = "txtMahang";
            this.txtMahang.Size = new System.Drawing.Size(157, 20);
            this.txtMahang.TabIndex = 74;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(258, 407);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 15);
            this.label11.TabIndex = 73;
            this.label11.Text = "Đơn giá /1:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 439);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 15);
            this.label10.TabIndex = 72;
            this.label10.Text = "Tên sản phẩm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 71;
            this.label5.Text = "Mã hàng: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 70;
            // 
            // txtSohd
            // 
            this.txtSohd.Enabled = false;
            this.txtSohd.Location = new System.Drawing.Point(837, 422);
            this.txtSohd.Name = "txtSohd";
            this.txtSohd.Size = new System.Drawing.Size(154, 20);
            this.txtSohd.TabIndex = 69;
            this.txtSohd.Text = "Số Hóa Đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(817, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(702, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 67;
            this.label2.Text = "Danh Sách Hàng Được Mua";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 16);
            this.label7.TabIndex = 66;
            this.label7.Text = "Danh Sách Hàng Bán";
            // 
            // dgrChiTietHang
            // 
            this.dgrChiTietHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgrChiTietHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrChiTietHang.Location = new System.Drawing.Point(649, 75);
            this.dgrChiTietHang.Name = "dgrChiTietHang";
            this.dgrChiTietHang.Size = new System.Drawing.Size(457, 307);
            this.dgrChiTietHang.TabIndex = 65;
            this.dgrChiTietHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrChiTietHang_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(744, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 64;
            this.label9.Text = "Số Hóa Đơn: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(740, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 63;
            this.label8.Text = "Tổng Tiền : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 20);
            this.label14.TabIndex = 62;
            this.label14.Text = "Quản lý hàng bán";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1007, 407);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 85);
            this.btnBack.TabIndex = 84;
            this.btnBack.Text = "Quay Lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(520, 197);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 58);
            this.btnRefresh.TabIndex = 80;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(520, 75);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 59);
            this.btnThem.TabIndex = 78;
            this.btnThem.Text = "Thêm Vào Giỏ Hàng";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgrMatHang
            // 
            this.dgrMatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgrMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrMatHang.Location = new System.Drawing.Point(15, 75);
            this.dgrMatHang.Name = "dgrMatHang";
            this.dgrMatHang.Size = new System.Drawing.Size(485, 307);
            this.dgrMatHang.TabIndex = 61;
            this.dgrMatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrMatHang_CellClick);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(928, 18);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(106, 16);
            this.lbUser.TabIndex = 60;
            this.lbUser.Text = "Tên Người Dùng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(824, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 59;
            this.label1.Text = "Người Dùng :";
            // 
            // FrmChiTietHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 509);
            this.Controls.Add(this.btnXoaSanPham);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.txtSoluongmua);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txtTenhang);
            this.Controls.Add(this.txtMahang);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSohd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgrChiTietHang);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgrMatHang);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.label1);
            this.Name = "FrmChiTietHoaDonBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Hóa Đơn Bán Hàng";
            this.Load += new System.EventHandler(this.FrmChiTietHoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrChiTietHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrMatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnXoaSanPham;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.TextBox txtSoluongmua;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.TextBox txtMahang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSohd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgrChiTietHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgrMatHang;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label label1;
    }
}