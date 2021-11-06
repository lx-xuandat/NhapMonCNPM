using PMQLBanHang.BUS;
using PMQLBanHang.DTO;
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
        int matkSelected;
        public int Message
        {
            get { return matk; }
            set { matk = value; }
        }
        QuanLyBUS quanLyBUS = new QuanLyBUS();
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        public FrmTaiKhoan()
        {
            InitializeComponent();
        }

        private void FrmTaiKhoan_Load(object sender, EventArgs e)
        {
            LabelUser.Text = quanLyBUS.getUserName(matk);
            showNhanVien_TrangThai(matk);
            initComponents();
        }

        private void initComponents()
        {
            matkSelected = -1;
            txtTaiKhoan.Text ="";
            txtMatKhau.Text = "";
            cbNhanVien.Text = "";
            cbChucVu.DataSource = taiKhoanBUS.getAllChucVu();
            cbChucVu.DisplayMember = "sTenLoaiTK";
            cbChucVu.ValueMember = "iMaLoaiTK";
            cbNhanVien.DataSource = nhanVienBUS.getAllNhanVienNotTaiKhoan();
            cbNhanVien.DisplayMember = "sTenNV";
            cbNhanVien.ValueMember = "iMaNV";
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = false;
            btn_update.Enabled = false;
            cbNhanVien.Enabled = true;
        }


        private void showNhanVien_TrangThai(int matk)
        {
            dgr_nhanvien_trangthai.DataSource = taiKhoanBUS.showNhanVien_TrangThai(matk);
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
                matkSelected = Convert.ToInt32(dgr_nhanvien_trangthai.Rows[index].Cells[0].Value); ;
                int manv = Convert.ToInt32(dgr_nhanvien_trangthai.Rows[index].Cells[3].Value);
                label10.Text = manv.ToString();
                txtTaiKhoan.Text = dgr_nhanvien_trangthai.Rows[index].Cells[1].Value + "";
                txtMatKhau.Text = dgr_nhanvien_trangthai.Rows[index].Cells[2].Value + "";
                string trangthai = dgr_nhanvien_trangthai.Rows[index].Cells[3].Value+"";
                cbNhanVien.Text = dgr_nhanvien_trangthai.Rows[index].Cells[4].Value + "";
                cbChucVu.Text = dgr_nhanvien_trangthai.Rows[index].Cells[5].Value + "";
                btn_Them.Enabled = false;
                btn_Xoa.Enabled = true;
                btn_update.Enabled = true;
                cbNhanVien.Enabled = false;
            }
            else
            {
                label10.Text = "Mã NV"; 
                initComponents();
            }
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
            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan = getTaiKhoanFromInfo();
            if (checkInfo(taiKhoan))
            {
                if (!validateTaiKhoan(taiKhoan)) return;
                if (taiKhoanBUS.addAccount(taiKhoan) == 2)// thêm tài khoản nhớ thay đổi cả trạng thái ở bảng nhân viên
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

        private bool validateTaiKhoan(TaiKhoan taikhoan)
        {
            bool taikhoanhople = (taikhoan.Tendangnhap.All(char.IsLetterOrDigit) && taikhoan.Tendangnhap.Length>=4);
            if (!taikhoanhople)
            {
                MessageBox.Show("Tài khoản chứa ít nhất 4 kí tự là chữ hoặc số!", "Thông Báo !");
                return false;
            };
            if (taikhoan.Matkhau.Length<6)
            {
                MessageBox.Show("Mật khẩu tối thiểu 6 kí tự!", "Thông Báo !");
                return false;
            };
            return true;
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
                MessageBox.Show("Mật khẩu không được để trống !", "Thông Báo !");
                isPattern = false;
            }
            else if (ckbAnHien.Checked != true)
            {
                if (txtXacNhan.Text.Length == 0)
                {
                    isPattern = false;
                    MessageBox.Show("Mật khẩu xác nhận không được bỏ trống!", "Thông Báo !");
                    return false;
                }
                if (!taikhoan.Matkhau.Equals(txtXacNhan.Text))
                {
                    isPattern = false;
                    MessageBox.Show("Nhập lại mật khẩu không đúng!", "Thông Báo !");
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
                if (taiKhoanBUS.deleteAccount(taikhoan) ==2)
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
            string avc = cbNhanVien.SelectedValue+"";
            x.Manv = Convert.ToInt32(cbNhanVien.SelectedValue);
            x.Matk =  matkSelected;
            x.Tendangnhap = txtTaiKhoan.Text;
            x.Matkhau = txtMatKhau.Text;
            x.Maloaitk = Convert.ToInt32(cbChucVu.SelectedValue);
            return x;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            TaiKhoan taikhoan = new TaiKhoan();
            taikhoan = getTaiKhoanFromInfo();
            if (checkInfo(taikhoan))
            {
                if (!validateTaiKhoan(taikhoan)) return;
                if (MessageBox.Show("Bạn có thật sự muốn thay đổi không!", "Thông Báo!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    if (taiKhoanBUS.updateAccount(taikhoan) == 1)
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cbNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
