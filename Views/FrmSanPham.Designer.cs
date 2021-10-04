namespace PMQLBanHang.Views
{
    partial class FrmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSanPham));
            this.btn_chonanh = new System.Windows.Forms.Button();
            this.cbDonviTinh = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CbTenNcc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbMaSp = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fileName1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dtpHSD = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dtpNSX = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.dgr_sanpham = new System.Windows.Forms.DataGridView();
            this.lbnguoidung = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_sanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_chonanh
            // 
            this.btn_chonanh.Location = new System.Drawing.Point(34, 196);
            this.btn_chonanh.Name = "btn_chonanh";
            this.btn_chonanh.Size = new System.Drawing.Size(75, 32);
            this.btn_chonanh.TabIndex = 6;
            this.btn_chonanh.Text = "Chọn Ảnh";
            this.btn_chonanh.UseVisualStyleBackColor = true;
            this.btn_chonanh.Click += new System.EventHandler(this.btn_chonanh_Click);
            // 
            // cbDonviTinh
            // 
            this.cbDonviTinh.FormattingEnabled = true;
            this.cbDonviTinh.Location = new System.Drawing.Point(71, 3);
            this.cbDonviTinh.Name = "cbDonviTinh";
            this.cbDonviTinh.Size = new System.Drawing.Size(115, 21);
            this.cbDonviTinh.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Đơn Tính:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtGia);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(274, 65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(225, 31);
            this.panel5.TabIndex = 2;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(65, 5);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(146, 20);
            this.txtGia.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gía:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbLoaiSP);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(274, 23);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(225, 31);
            this.panel6.TabIndex = 2;
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.FormattingEnabled = true;
            this.cbLoaiSP.Location = new System.Drawing.Point(64, 4);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(147, 21);
            this.cbLoaiSP.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Loại SP:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.CbTenNcc);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(3, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(253, 31);
            this.panel4.TabIndex = 1;
            // 
            // CbTenNcc
            // 
            this.CbTenNcc.FormattingEnabled = true;
            this.CbTenNcc.Location = new System.Drawing.Point(65, 2);
            this.CbTenNcc.Name = "CbTenNcc";
            this.CbTenNcc.Size = new System.Drawing.Size(159, 21);
            this.CbTenNcc.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên NCC:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_tensp);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(3, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 31);
            this.panel3.TabIndex = 0;
            // 
            // txt_tensp
            // 
            this.txt_tensp.Location = new System.Drawing.Point(65, 5);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(159, 20);
            this.txt_tensp.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thông Tin Sản Phẩm";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbDonviTinh);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(505, 23);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(199, 31);
            this.panel7.TabIndex = 3;
            // 
            // lbMaSp
            // 
            this.lbMaSp.AutoSize = true;
            this.lbMaSp.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSp.Location = new System.Drawing.Point(82, 26);
            this.lbMaSp.Name = "lbMaSp";
            this.lbMaSp.Size = new System.Drawing.Size(46, 18);
            this.lbMaSp.TabIndex = 5;
            this.lbMaSp.Text = "Mã SP";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(74, 5);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(112, 20);
            this.txtSoluong.TabIndex = 1;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(721, -28);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(86, 13);
            this.lbUser.TabIndex = 8;
            this.lbUser.Text = "Tên Người Dùng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, -28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Người sử dụng:";
            // 
            // fileName1
            // 
            this.fileName1.AutoSize = true;
            this.fileName1.Location = new System.Drawing.Point(51, 162);
            this.fileName1.Name = "fileName1";
            this.fileName1.Size = new System.Drawing.Size(48, 13);
            this.fileName1.TabIndex = 3;
            this.fileName1.Text = "fileName";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fileName1);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_sua);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_chonanh);
            this.panel1.Controls.Add(this.lbMaSp);
            this.panel1.Controls.Add(this.avatar);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 253);
            this.panel1.TabIndex = 10;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(701, 196);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(79, 45);
            this.btn_Xoa.TabIndex = 11;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(526, 196);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(79, 45);
            this.btn_sua.TabIndex = 10;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã SP :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(148, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 161);
            this.panel2.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dtpHSD);
            this.panel10.Controls.Add(this.label11);
            this.panel10.Location = new System.Drawing.Point(489, 115);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(215, 31);
            this.panel10.TabIndex = 3;
            // 
            // dtpHSD
            // 
            this.dtpHSD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHSD.Location = new System.Drawing.Point(64, 5);
            this.dtpHSD.Name = "dtpHSD";
            this.dtpHSD.Size = new System.Drawing.Size(139, 20);
            this.dtpHSD.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "HSD:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dtpNSX);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Location = new System.Drawing.Point(264, 115);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(206, 31);
            this.panel9.TabIndex = 5;
            // 
            // dtpNSX
            // 
            this.dtpNSX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNSX.Location = new System.Drawing.Point(54, 6);
            this.dtpNSX.Name = "dtpNSX";
            this.dtpNSX.Size = new System.Drawing.Size(139, 20);
            this.dtpNSX.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "NSX:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtSoluong);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Location = new System.Drawing.Point(505, 65);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(199, 31);
            this.panel8.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số Lượng:";
            // 
            // avatar
            // 
            this.avatar.Image = ((System.Drawing.Image)(resources.GetObject("avatar.Image")));
            this.avatar.Location = new System.Drawing.Point(23, 48);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(105, 102);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 2;
            this.avatar.TabStop = false;
            this.avatar.Click += new System.EventHandler(this.avatar_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(167, 196);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(79, 45);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // dgr_sanpham
            // 
            this.dgr_sanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgr_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_sanpham.Location = new System.Drawing.Point(12, 327);
            this.dgr_sanpham.Name = "dgr_sanpham";
            this.dgr_sanpham.Size = new System.Drawing.Size(863, 245);
            this.dgr_sanpham.TabIndex = 9;
            this.dgr_sanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_sanpham_CellClick);
            // 
            // lbnguoidung
            // 
            this.lbnguoidung.AutoSize = true;
            this.lbnguoidung.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnguoidung.Location = new System.Drawing.Point(697, 19);
            this.lbnguoidung.Name = "lbnguoidung";
            this.lbnguoidung.Size = new System.Drawing.Size(105, 18);
            this.lbnguoidung.TabIndex = 12;
            this.lbnguoidung.Text = "Tên Người Dùng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(599, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 18);
            this.label13.TabIndex = 11;
            this.label13.Text = "Người sử dụng:";
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 584);
            this.Controls.Add(this.lbnguoidung);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgr_sanpham);
            this.Name = "FrmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.FrmSanPham_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_sanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_chonanh;
        private System.Windows.Forms.ComboBox cbDonviTinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox CbTenNcc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbMaSp;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fileName1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DateTimePicker dtpHSD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DateTimePicker dtpNSX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridView dgr_sanpham;
        private System.Windows.Forms.Label lbnguoidung;
        private System.Windows.Forms.Label label13;
    }
}