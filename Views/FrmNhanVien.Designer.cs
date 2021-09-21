namespace PMQLBanHang.Views
{
    partial class FrmNhanVien
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
            this.dgr_NhanVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dtpStartdate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_XoaNV = new System.Windows.Forms.Button();
            this.btn_SuaNV = new System.Windows.Forms.Button();
            this.btn_ThemNV = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txt_Serach = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.LabelUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_NhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgr_NhanVien
            // 
            this.dgr_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_NhanVien.Location = new System.Drawing.Point(12, 89);
            this.dgr_NhanVien.Name = "dgr_NhanVien";
            this.dgr_NhanVien.ReadOnly = true;
            this.dgr_NhanVien.Size = new System.Drawing.Size(507, 398);
            this.dgr_NhanVien.TabIndex = 0;
            this.dgr_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_NhanVien_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chức Năng Quản Lý Nhân Viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(554, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 347);
            this.panel1.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbChucVu);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Location = new System.Drawing.Point(3, 311);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(278, 31);
            this.panel9.TabIndex = 8;
            // 
            // cbChucVu
            // 
            this.cbChucVu.Location = new System.Drawing.Point(68, 3);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(192, 21);
            this.cbChucVu.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Chức Vụ:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtPhone);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Location = new System.Drawing.Point(3, 274);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(278, 31);
            this.panel8.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(68, 6);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(192, 20);
            this.txtPhone.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số ĐT:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dtpStartdate);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(3, 237);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(278, 31);
            this.panel7.TabIndex = 6;
            // 
            // dtpStartdate
            // 
            this.dtpStartdate.CustomFormat = "dd/MM/yyyy";
            this.dtpStartdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartdate.Location = new System.Drawing.Point(68, 5);
            this.dtpStartdate.Name = "dtpStartdate";
            this.dtpStartdate.Size = new System.Drawing.Size(192, 20);
            this.dtpStartdate.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày Vào:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dtpBirthday);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(3, 200);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(278, 31);
            this.panel6.TabIndex = 5;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CustomFormat = "dd/MM/yyyy";
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(68, 5);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(192, 20);
            this.dtpBirthday.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày Sinh:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtAddress);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(3, 163);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(278, 31);
            this.panel5.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(68, 6);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(192, 20);
            this.txtAddress.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Địa Chỉ:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdFemale);
            this.panel4.Controls.Add(this.rdMale);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(3, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(278, 31);
            this.panel4.TabIndex = 3;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(161, 9);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(60, 17);
            this.rdFemale.TabIndex = 2;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "FeMale";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(68, 9);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(48, 17);
            this.rdMale.TabIndex = 1;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới Tính:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTenNV);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(3, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 31);
            this.panel3.TabIndex = 2;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(68, 6);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(192, 20);
            this.txtTenNV.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên NV:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMaNV);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 31);
            this.panel2.TabIndex = 1;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(68, 6);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(192, 20);
            this.txtMaNV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã NV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông Tin Nhân Viên";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btn_Report);
            this.panel10.Controls.Add(this.btn_LamMoi);
            this.panel10.Controls.Add(this.btn_XoaNV);
            this.panel10.Controls.Add(this.btn_SuaNV);
            this.panel10.Controls.Add(this.btn_ThemNV);
            this.panel10.Location = new System.Drawing.Point(525, 407);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(329, 84);
            this.panel10.TabIndex = 3;
            // 
            // btn_Report
            // 
            this.btn_Report.Location = new System.Drawing.Point(193, 42);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(117, 39);
            this.btn_Report.TabIndex = 3;
            this.btn_Report.Text = "In Danh Sách";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Location = new System.Drawing.Point(52, 42);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(105, 38);
            this.btn_LamMoi.TabIndex = 5;
            this.btn_LamMoi.Text = "Làm Mới";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_XoaNV
            // 
            this.btn_XoaNV.Location = new System.Drawing.Point(254, 0);
            this.btn_XoaNV.Name = "btn_XoaNV";
            this.btn_XoaNV.Size = new System.Drawing.Size(75, 36);
            this.btn_XoaNV.TabIndex = 2;
            this.btn_XoaNV.Text = "Xóa";
            this.btn_XoaNV.UseVisualStyleBackColor = true;
            this.btn_XoaNV.Click += new System.EventHandler(this.btn_XoaNV_Click);
            // 
            // btn_SuaNV
            // 
            this.btn_SuaNV.Enabled = false;
            this.btn_SuaNV.Location = new System.Drawing.Point(135, 0);
            this.btn_SuaNV.Name = "btn_SuaNV";
            this.btn_SuaNV.Size = new System.Drawing.Size(75, 36);
            this.btn_SuaNV.TabIndex = 1;
            this.btn_SuaNV.Text = "Sửa";
            this.btn_SuaNV.UseVisualStyleBackColor = true;
            this.btn_SuaNV.Click += new System.EventHandler(this.btn_SuaNV_Click);
            // 
            // btn_ThemNV
            // 
            this.btn_ThemNV.Location = new System.Drawing.Point(12, 0);
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new System.Drawing.Size(75, 36);
            this.btn_ThemNV.TabIndex = 0;
            this.btn_ThemNV.Text = "Thêm";
            this.btn_ThemNV.UseVisualStyleBackColor = true;
            this.btn_ThemNV.Click += new System.EventHandler(this.btn_ThemNV_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(876, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txt_Serach
            // 
            this.txt_Serach.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Serach.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_Serach.Location = new System.Drawing.Point(54, 43);
            this.txt_Serach.Name = "txt_Serach";
            this.txt_Serach.Size = new System.Drawing.Size(331, 25);
            this.txt_Serach.TabIndex = 6;
            this.txt_Serach.TextChanged += new System.EventHandler(this.txt_Serach_TextChanged);
            this.txt_Serach.Enter += new System.EventHandler(this.txt_Serach_Enter);
            this.txt_Serach.Leave += new System.EventHandler(this.txt_Serach_Leave);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(407, 41);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(83, 26);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "Tìm Kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(565, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Người Dùng:";
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.Location = new System.Drawing.Point(638, 9);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(86, 13);
            this.LabelUser.TabIndex = 9;
            this.LabelUser.Text = "Tên Người Dùng";
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 532);
            this.Controls.Add(this.LabelUser);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Serach);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgr_NhanVien);
            this.Name = "FrmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_NhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgr_NhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DateTimePicker dtpStartdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_XoaNV;
        private System.Windows.Forms.Button btn_SuaNV;
        private System.Windows.Forms.Button btn_ThemNV;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.TextBox txt_Serach;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.ComboBox cbChucVu;
    }
}