using PMQLBanHang.Controllers;
using PMQLBanHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMQLBanHang.Views
{
    public partial class FrmTaiKhoan : Form
    {
        int matk;
        public int Message
        {
            get { return matk; }
            set { matk = value; }
        }
        QuanLyController quanLyController = new QuanLyController();
        TaiKhoanController taiKhoanController = new TaiKhoanController();
        public FrmTaiKhoan()
        {
            InitializeComponent();
        }

        private void FrmTaiKhoan_Load(object sender, EventArgs e)
        {
            LabelUser.Text = quanLyController.getUserName(matk);
            showNhanVien_TrangThai(matk);
            initComponents();
        }

        private void initComponents()
        {
            txtMatk.Text = getMaxMaTk().ToString();
            txtTaiKhoan.Text ="";
            txtMatKhau.Text = "";
            txtChucVu.Text = "";
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = false;
            btn_update.Enabled = false;
        }

        private int getMaxMaTk()
        {
            int nextMaTK = taiKhoanController.getMaxMaTK()+1;
            return nextMaTK;
        }

        private void showNhanVien_TrangThai(int matk)
        {
            dgr_nhanvien_trangthai.DataSource = taiKhoanController.showNhanVien_TrangThai(matk);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgr_nhanvien_trangthai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int soluongrow = dgr_nhanvien_trangthai.RowCount;
            int index = dgr_nhanvien_trangthai.CurrentRow.Index;
            if (index < soluongrow - 1) // nếu nhấn vào hàng không có giá trị
            {
                int manv      = Convert.ToInt32(dgr_nhanvien_trangthai.Rows[index].Cells[0].Value);
                label10.Text = manv.ToString();
                string trangthai = dgr_nhanvien_trangthai.Rows[index].Cells[3].Value+"";
                if (trangthai.Trim().Length != 0)
                {
                    btn_Them.Enabled = false;
                    btn_Xoa.Enabled = true;
                    btn_update.Enabled = true;
                    if (trangthai.Equals("0"))
                    {
                        initComponents();
                        getChucVuFromMaNV(manv);
                    } else
                    {
                        getTaiKhoanByManv(manv);
                    }
                }
                else
                {
                    initComponents();
                    getChucVuFromMaNV(manv);
                }

            }
            else
            {
                label10.Text = "Mã NV"; 
                initComponents();
            }
        }

        private void getChucVuFromMaNV(int manv) // cho nhân viên chưa mã loại tk
        {
            txtChucVu.Text = taiKhoanController.getChucVuFromMaNV(manv);
        }

        private void getTaiKhoanByManv(int manv)// cho nhân viên đã có mã loại tk 
        {
            TaiKhoan taiKhoan = taiKhoanController.getAccountByMaNV(manv);
            txtMatk.Text = taiKhoan.Matk.ToString();
            txtTaiKhoan.Text = taiKhoan.Tendangnhap;
            txtMatKhau.Text = taiKhoan.Matkhau;
            txtChucVu.Text = getChucVuFromMaLoaiTK(taiKhoan.Maloaitk);
        }

        private string getChucVuFromMaLoaiTK(int maloaitk)
        {
            string chucvu="";
            switch (maloaitk)
            {
                case 1: chucvu = "chủ sở hữu"; break;
                case 2: chucvu = "quản lý"; break;
                case 3: chucvu = "nhân viên bán hàng"; break;
                case 4: chucvu = "nhân viên kho"; break;
                default: chucvu = "không có chức vụ"; break;
            }
            return chucvu;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (dgr_nhanvien_trangthai.CurrentRow.Selected == true)
            {
                if (txtChucVu.Text.Equals("chưa có chức vụ"))
                {
                    MessageBox.Show("Nhân viên này chưa có chức vụ, hãy thêm chức vụ trước!", "Thông Báo !");
                }
                else
                {
                    TaiKhoan taiKhoan = new TaiKhoan();         
                    taiKhoan = getTaiKhoanFromInfo();
                    if (checkInfo(taiKhoan))
                    {
                        if (taiKhoanController.addAccount(taiKhoan) == 2)// thêm tài khoản nhớ thay đổi cả trạng thái ở bảng nhân viên
                        {// bằng 2 vì 2 dòng bị ảnh hưởng
                            MessageBox.Show("Thêm Thành Công!", "Thông Báo !");
                            RefreshFrm();
                        }
                        else
                        {
                            MessageBox.Show("Thêm Không Thành Công!", "Thông Báo !");
                        }

                    }
                }
            } else
            {
                MessageBox.Show("Hãy Chọn Nhân Viên Chưa Có Tài Khoản !","Thông Báo !");
            }
        }

        private int getMaLoaiTKFromCV(object value)
        {
            int result=0;
            string tenChucvu = value.ToString();
            switch (tenChucvu)
            {
                case "chusohuu": result = 1; break;
                case "quanly": result = 2; break;
                case "nhanvienbanhang": result = 3; break;
                case "nhanvienkho": result = 4; break;
            }
            return result;
        }

        private bool checkInfo(TaiKhoan taikhoan)
        {
            bool isPattern = true;
            if (taikhoan.Tendangnhap.Trim().Length ==0)
            {
                MessageBox.Show("Tên đăng nhập không được để trống !","Thông Báo !");
                isPattern = false;
               
            }
            else if (taikhoan.Matkhau.Trim().Length ==0)
            {
                MessageBox.Show("Mật khẩu không được để tróng !", "Thông Báo !");
                isPattern = false;
            }
            else if (ckbAnHien.Checked != true)
            {
                if (!taikhoan.Matkhau.Equals(txtXacNhan.Text))
                {
                    isPattern = false;
                    MessageBox.Show(" mật khẩu xác nhận không giống nhau!", "Thông Báo !");
                }
            }
            return isPattern;
        }

        private void ckbAnHien_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAnHien.Checked == true)
            {
                txtMatKhau.PasswordChar=Convert.ToChar('\0');
                ckbAnHien.Text = "Ẩn";
                txtXacNhan.Enabled = false;
            }
            else if(ckbAnHien.Checked == false)
            {
                txtMatKhau.PasswordChar = '*';
                ckbAnHien.Text = "Hiện";
                txtXacNhan.Enabled = true;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            TaiKhoan taikhoan = new TaiKhoan();
            taikhoan = getTaiKhoanFromInfo();
            if (MessageBox.Show("Bạn có thật sự muốn xóa không!", "Thông Báo!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (taiKhoanController.deleteAccount(taikhoan) ==2)
                {
                    RefreshFrm();
                    MessageBox.Show("Xóa Thành Công!", "Thông Báo !");
                }
                else
                {
                    MessageBox.Show("Xóa Không Thành Công!", "Thông Báo !");
                }
            }
        }

        private void RefreshFrm()
        {
            showNhanVien_TrangThai(matk);
            initComponents();
        }

        private TaiKhoan getTaiKhoanFromInfo()
        {
            TaiKhoan x = new TaiKhoan();
            x.Manv = Convert.ToInt32(dgr_nhanvien_trangthai.CurrentRow.Cells[0].Value);
            x.Matk = Convert.ToInt32(txtMatk.Text);
            x.Tendangnhap = txtTaiKhoan.Text;
            x.Matkhau = txtMatKhau.Text;
            x.Maloaitk = getMaLoaiTKFromCV(dgr_nhanvien_trangthai.CurrentRow.Cells[2].Value);
            return x;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            TaiKhoan taikhoan = new TaiKhoan();
            taikhoan = getTaiKhoanFromInfo();
            if (checkInfo(taikhoan))
            {
                if (MessageBox.Show("Bạn có thật sự muốn thay đổi không!", "Thông Báo!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    if (taiKhoanController.updateAccount(taikhoan) == 1)
                    {
                        RefreshFrm();
                        MessageBox.Show("Cập Nhật Thành Công!", "Thông Báo !");
                    }
                    else
                    {
                        MessageBox.Show("Cập Nhật Thành Công!", "Thông Báo !");
                    }
                }
            }
            
        }
    }
}
