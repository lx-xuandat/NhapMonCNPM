namespace PMQLBanHang.Views
{
    partial class FrmTaiKhoan
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
            this.LabelUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgr_nhanvien_trangthai = new System.Windows.Forms.DataGridView();
            this.lbMaNV = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_BaoCao = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtXacNhan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ckbAnHien = new System.Windows.Forms.CheckBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_nhanvien_trangthai)).BeginInit();
            this.lbMaNV.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Người sử dụng:";
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUser.Location = new System.Drawing.Point(140, 9);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(94, 16);
            this.LabelUser.TabIndex = 1;
            this.LabelUser.Text = "Người sử dụng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh Sách Tài Khoản Nhân Viên\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgr_nhanvien_trangthai
            // 
            this.dgr_nhanvien_trangthai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgr_nhanvien_trangthai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_nhanvien_trangthai.Location = new System.Drawing.Point(21, 74);
            this.dgr_nhanvien_trangthai.Name = "dgr_nhanvien_trangthai";
            this.dgr_nhanvien_trangthai.Size = new System.Drawing.Size(496, 368);
            this.dgr_nhanvien_trangthai.TabIndex = 5;
            this.dgr_nhanvien_trangthai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_nhanvien_trangthai_CellClick);
            // 
            // lbMaNV
            // 
            this.lbMaNV.Controls.Add(this.panel7);
            this.lbMaNV.Controls.Add(this.panel6);
            this.lbMaNV.Controls.Add(this.panel5);
            this.lbMaNV.Controls.Add(this.panel4);
            this.lbMaNV.Controls.Add(this.panel3);
            this.lbMaNV.Controls.Add(this.panel2);
            this.lbMaNV.Location = new System.Drawing.Point(523, 80);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(336, 368);
            this.lbMaNV.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbChucVu);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(3, 88);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(293, 38);
            this.panel7.TabIndex = 6;
            // 
            // cbChucVu
            // 
            this.cbChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(93, 8);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(185, 24);
            this.cbChucVu.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Chức Vụ :";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_BaoCao);
            this.panel6.Controls.Add(this.btn_Xoa);
            this.panel6.Controls.Add(this.btn_update);
            this.panel6.Controls.Add(this.btn_Them);
            this.panel6.Location = new System.Drawing.Point(3, 239);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(293, 123);
            this.panel6.TabIndex = 5;
            // 
            // btn_BaoCao
            // 
            this.btn_BaoCao.Location = new System.Drawing.Point(186, 73);
            this.btn_BaoCao.Name = "btn_BaoCao";
            this.btn_BaoCao.Size = new System.Drawing.Size(88, 47);
            this.btn_BaoCao.TabIndex = 3;
            this.btn_BaoCao.Text = "Báo Cáo";
            this.btn_BaoCao.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(15, 73);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(93, 47);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(186, 15);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(92, 52);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Cập Nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(15, 15);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(93, 52);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Cấp Tài Khoản";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtXacNhan);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(3, 171);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(293, 62);
            this.panel5.TabIndex = 4;
            // 
            // txtXacNhan
            // 
            this.txtXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhan.Location = new System.Drawing.Point(89, 28);
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.PasswordChar = '*';
            this.txtXacNhan.Size = new System.Drawing.Size(185, 22);
            this.txtXacNhan.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nhập Lại Mật Khẩu:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ckbAnHien);
            this.panel4.Controls.Add(this.txtMatKhau);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(3, 127);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(326, 38);
            this.panel4.TabIndex = 3;
            // 
            // ckbAnHien
            // 
            this.ckbAnHien.AutoSize = true;
            this.ckbAnHien.Location = new System.Drawing.Point(275, 9);
            this.ckbAnHien.Name = "ckbAnHien";
            this.ckbAnHien.Size = new System.Drawing.Size(48, 17);
            this.ckbAnHien.TabIndex = 2;
            this.ckbAnHien.Text = "Hiện";
            this.ckbAnHien.UseVisualStyleBackColor = true;
            this.ckbAnHien.CheckedChanged += new System.EventHandler(this.ckbAnHien_CheckedChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(93, 6);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(176, 22);
            this.txtMatKhau.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mật Khẩu :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbNhanVien);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 38);
            this.panel3.TabIndex = 2;
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(93, 8);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(185, 24);
            this.cbNhanVien.TabIndex = 1;
            this.cbNhanVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNhanVien_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhân Viên:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTaiKhoan);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(3, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 38);
            this.panel2.TabIndex = 1;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(93, 6);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(185, 22);
            this.txtTaiKhoan.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tài Khoản :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(594, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thông Tin Tài Khoản";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(754, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Mã Nv:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(802, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Mã NV";
            // 
            // FrmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 460);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.dgr_nhanvien_trangthai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelUser);
            this.Controls.Add(this.label1);
            this.Name = "FrmTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Tài Khoản Nhân Viên";
            this.Load += new System.EventHandler(this.FrmTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_nhanvien_trangthai)).EndInit();
            this.lbMaNV.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgr_nhanvien_trangthai;
        private System.Windows.Forms.Panel lbMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_BaoCao;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtXacNhan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ckbAnHien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.Label label5;
    }
}