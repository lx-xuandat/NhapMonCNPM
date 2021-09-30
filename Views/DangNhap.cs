
using PMQLBanHang.Controllers;
using PMQLBanHang.Models;
using PMQLBanHang.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace PMQLBanHang
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dangnhap(object sender, EventArgs e)
        {
            #region
            if (txtTenDangNhap.Text.Length != 0 && txtMatKhau.Text.Length != 0)
            {
                if (kiemtra())
                {
                    string tendangnhap = txtTenDangNhap.Text;
                    string matkhau = txtMatKhau.Text;
                    LoginController checklogin = new LoginController();
                    DataTable data = checklogin.checklogin(tendangnhap, matkhau);
                    if (data.Rows.Count > 0)
                    {
                        DataRow row = data.Rows[0];
                        switch (kiemTraChucVu(row))  // 1 là chusohuu / 2 là quanly /3 nhanvienbanhang /4 là nhanvienkho
                        {
                            case 1: MessageBox.Show("Bạn Đăng Nhập Quyền CHủ Sở Huữ", "Thông Báo!"); break;
                            case 2:
                                this.Hide();
                                FrmQuanLy frmQuanLy = new FrmQuanLy();
                                frmQuanLy.Message = getMaTK(row);
                                frmQuanLy.ShowDialog();
                                this.Show();
                                break;
                            case 3: MessageBox.Show("Bạn Đăng Nhập Quyền Bán Hàng", "Thông Báo!"); break;
                            case 4:
                                MessageBox.Show("Bạn Đăng Nhập Quyền Kho", "Thông Báo!");
                                this.Hide();
                                FrmHoaDonNhap frmHoaDonNhap = new FrmHoaDonNhap();
                                frmHoaDonNhap.Message = getMaTK(row);
                                frmHoaDonNhap.ShowDialog();
                                break;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Sai quy tắc đặt tên!", "thông báo!");
                }
            }
            else
            {
                MessageBox.Show("Thông tin không được để trống!", "thông báo!");
            }
            #endregion
            // MessageBox.Show("Không Tìm Thấy Nhân Viên!", "thông báo!");

        }

        private int getMaTK(DataRow row)
        {
            int myData = (int)row["iMaTK"];
            return myData;
        }

        private int kiemTraChucVu(DataRow row)
        {
            int myData =  (int)row["iMaLoaiTK"];
            return myData;
        }

        private bool kiemtra()
        {

            if (Regex.IsMatch(txtTenDangNhap.Text, "[a-zA-Z0-9_]"))
            {
                return true;
            }
            else return false;
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("bạn có thực sự muốn thoát !", "Thông báo!", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void keyOn()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                toolStripStatusLabel1.Text = "Caplock is ON";
                toolStripStatusLabel1.Visible = true;
            }
            else
            {
                toolStripStatusLabel1.Text = "Caplock is OFF";
                toolStripStatusLabel1.Visible = false;
            }
        }


        private void txtTenDangNhap_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            keyOn();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //   Application.Exit();
            MessageBox.Show("Nhân viên này đã có tài khoản!", "thông báo!");
        }
    }
}
