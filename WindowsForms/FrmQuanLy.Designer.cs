namespace PMQLBanHang.Views
{
    partial class FrmQuanLy
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
            this.btn_QLNhanVien = new System.Windows.Forms.Button();
            this.btn_QLSanPham = new System.Windows.Forms.Button();
            this.btn_QLHoaDonBan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_QlyTaiKhoan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_QLNhanVien
            // 
            this.btn_QLNhanVien.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLNhanVien.Location = new System.Drawing.Point(34, 143);
            this.btn_QLNhanVien.Name = "btn_QLNhanVien";
            this.btn_QLNhanVien.Size = new System.Drawing.Size(133, 76);
            this.btn_QLNhanVien.TabIndex = 0;
            this.btn_QLNhanVien.Text = "Quản Lý Nhân Viên";
            this.btn_QLNhanVien.UseVisualStyleBackColor = true;
            this.btn_QLNhanVien.Click += new System.EventHandler(this.btn_QLNhanVien_Click);
            // 
            // btn_QLSanPham
            // 
            this.btn_QLSanPham.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLSanPham.Location = new System.Drawing.Point(576, 142);
            this.btn_QLSanPham.Name = "btn_QLSanPham";
            this.btn_QLSanPham.Size = new System.Drawing.Size(148, 77);
            this.btn_QLSanPham.TabIndex = 1;
            this.btn_QLSanPham.Text = "Quản Lý Sản Phẩm";
            this.btn_QLSanPham.UseVisualStyleBackColor = true;
            this.btn_QLSanPham.Click += new System.EventHandler(this.btn_QLSanPham_Click);
            // 
            // btn_QLHoaDonBan
            // 
            this.btn_QLHoaDonBan.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLHoaDonBan.Location = new System.Drawing.Point(213, 143);
            this.btn_QLHoaDonBan.Name = "btn_QLHoaDonBan";
            this.btn_QLHoaDonBan.Size = new System.Drawing.Size(142, 74);
            this.btn_QLHoaDonBan.TabIndex = 2;
            this.btn_QLHoaDonBan.Text = "Quản Lý Hóa Đơn Bán Hàng";
            this.btn_QLHoaDonBan.UseVisualStyleBackColor = true;
            this.btn_QLHoaDonBan.Click += new System.EventHandler(this.btn_QLHoaDonNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans SemiBold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(253, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chức Năng Của Phần Mềm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Người dùng :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(111, 19);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(86, 16);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Tên Của Bạn";
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.Location = new System.Drawing.Point(646, 19);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(78, 31);
            this.btn_Logout.TabIndex = 7;
            this.btn_Logout.Text = "Đăng Xuất";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_QlyTaiKhoan
            // 
            this.btn_QlyTaiKhoan.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QlyTaiKhoan.Location = new System.Drawing.Point(402, 142);
            this.btn_QlyTaiKhoan.Name = "btn_QlyTaiKhoan";
            this.btn_QlyTaiKhoan.Size = new System.Drawing.Size(129, 77);
            this.btn_QlyTaiKhoan.TabIndex = 8;
            this.btn_QlyTaiKhoan.Text = "Quản Lý Tài Khoản";
            this.btn_QlyTaiKhoan.UseVisualStyleBackColor = true;
            this.btn_QlyTaiKhoan.Click += new System.EventHandler(this.btn_QlyTaiKhoan_Click);
            // 
            // FrmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PMQLBanHang.Properties.Resources.background_grafana;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(763, 396);
            this.Controls.Add(this.btn_QlyTaiKhoan);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_QLHoaDonBan);
            this.Controls.Add(this.btn_QLSanPham);
            this.Controls.Add(this.btn_QLNhanVien);
            this.Name = "FrmQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Quản Lý Cửa Hàng";
            this.Load += new System.EventHandler(this.FrmQuanLy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_QLNhanVien;
        private System.Windows.Forms.Button btn_QLSanPham;
        private System.Windows.Forms.Button btn_QLHoaDonBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_QlyTaiKhoan;
    }
}