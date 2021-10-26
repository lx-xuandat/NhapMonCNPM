using PMQLBanHang.BUS;
using PMQLBanHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMQLBanHang.Views
{
    public partial class FrmNhanVien : Form
    {
        int matk;
        public int Message
        {
            get { return matk; }
            set { matk = value; }
        }
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        QuanLyBUS quanLyBUS = new QuanLyBUS();
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
           
            LabelUser.Text = quanLyBUS.getUserName(matk);
            showNV(matk);
            initComponents();
        }

        private void initComponents()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            rdFemale.Checked = true;
            txtAddress.Text = "";
            txtPhone.Text = "";
            //List<string> arrChucVu = nhanVienBUS.getListChucVu_by_MaTK(matk);
            //cbChucVu.DataSource=arrChucVu;
            txtTrangThai.Text = "";
            dtpBirthday.Value = DateTime.Today;
            dtpStartdate.Value = DateTime.Today;
            btn_ThemNV.Enabled = true;
            btn_SuaNV.Enabled = false;
            btn_XoaNV.Enabled = false;
            txt_Serach.Text = "Nhập Mã NV Hoặc Tên Nhân Viên...";
            txt_Serach.ForeColor = System.Drawing.Color.BlueViolet;
            
        }

        private void placeholder()
        {
        }
        private int getMaxMaNV()
        {
           
            return nhanVienBUS.getMaxMaNV()+1;
        }

        private void showNV(int matk)
        {
            dgr_NhanVien.DataSource =  nhanVienBUS.getListNV();
        }

        private void dgr_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int soluongrow = dgr_NhanVien.RowCount;
            int index = dgr_NhanVien.CurrentRow.Index;
            if (index < soluongrow-1) // nếu nhấn vào hàng không có giá trị
            {
                btn_ThemNV.Enabled = false;
                btn_SuaNV.Enabled = true;
                btn_XoaNV.Enabled = true;
                txtMaNV.Text     = dgr_NhanVien.Rows[index].Cells[0].Value + "";
                txtTenNV.Text    = dgr_NhanVien.Rows[index].Cells[1].Value + "";
                string gioitinh  = dgr_NhanVien.Rows[index].Cells[2].Value + "";
                txtAddress.Text  = dgr_NhanVien.Rows[index].Cells[3].Value + "";
                dtpBirthday.Text = dgr_NhanVien.Rows[index].Cells[4].Value + "";
                dtpStartdate.Text= dgr_NhanVien.Rows[index].Cells[5].Value + "";
                txtPhone.Text    = dgr_NhanVien.Rows[index].Cells[6].Value + "";
                txtTrangThai.Text   = dgr_NhanVien.Rows[index].Cells[7].Value + "";
                
                if (gioitinh.Equals("Nam"))
                {
                    rdMale.Checked = true;
                    rdFemale.Checked = false;
                }
                else
                {
                    rdMale.Checked = false;
                    rdFemale.Checked = true;
                }
               
                #region
                //string ngaysinh = (Convert.ToDateTime(dgr_NhanVien.Rows[index].Cells[3].Value, new CultureInfo("vi-VN")).ToString());
                //if (ngaysinh.Length == 21) // ngay sinh 26/6/2000 thì length =21 ngay sinh 26/12/2000 = 22
                //{
                //    string ngay = ngaysinh.Substring(0, 2);
                //    if (ngay.Contains("/")) // 3/12/2000 thiếu số ở ngày
                //    {
                //        dtpBirthday.Text = "0" + ngaysinh.Substring(0, 1) + ngaysinh.Substring(2, 17);
                //    }
                //    else // thiếu số ở tháng 12/3/2000
                //    {
                //        dtpBirthday.Text = ngaysinh.Substring(0, 2) + "0" + ngaysinh.Substring(2, 18);
                //    }
                //}
                //else
                //{
                //    if (ngaysinh.Length == 22) // 12/12/2000 đủ số
                //    {
                //        mskNgaysinh.Text = ngaysinh;
                //    }
                //    if (ngaysinh.Length == 20) // 6/6/2000 thiếu 2 số
                //    {
                //        mskNgaysinh.Text = "0" + ngaysinh.Substring(0, 2) + "0" + ngaysinh.Substring(2, 16);
                //    }
                //}
                #endregion
            }
            else
            {
                initComponents();
            }

        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            nhanvien = getNhanVienFromInfo();
            if (isFullInfo(nhanvien))
            {
                // thêm nhân viên
                if (nhanVienBUS.addNhanVien(nhanvien))
                {
                    RefreshFrm();
                    MessageBox.Show("Thêm Thành Công!","Thông Báo !");
                }
            }
            else
            {
                MessageBox.Show("Thông Tin Vừa Nhập Không Hợp Lệ !" +
                    "Vui Lòng Xem Lại","Thông Báo");
            }
        }

        private NhanVien getNhanVienFromInfo()
        {
            NhanVien nhanvien = new NhanVien();
            nhanvien.IMaNV = Convert.ToInt32(txtMaNV.Text==""? "0" : txtMaNV.Text);
            nhanvien.STenNV = txtTenNV.Text;
            nhanvien.IGioiTinh = getGenderFromRadio();
            nhanvien.SQueQuan = txtAddress.Text;
            nhanvien.DNgaySinh = dtpBirthday.Value;
            nhanvien.DNgayVaoLam = dtpStartdate.Value;
            nhanvien.SSoDienThoai = txtPhone.Text;
            nhanvien.STrangThai = txtTrangThai.Text;
            return nhanvien;
        }

        private void RefreshFrm()
        {
            LabelUser.Text = quanLyBUS.getUserName(matk);
            showNV(matk);
            initComponents();
        }

        private int getGenderFromRadio()
        {
            if (rdMale.Checked==true)
            {
                return 1;
            } else
            {
                return 0;
            }
        }

        private bool isFullInfo(NhanVien nhanvien)
        {
            TimeSpan span = nhanvien.DNgayVaoLam - nhanvien.DNgaySinh;
            var x = nhanvien.STenNV.Trim().Length == 0 || nhanvien.SQueQuan.Trim().Length == 0
                || Convert.ToDecimal(span.Days / 365) < 18 || nhanvien.DNgayVaoLam > DateTime.Today
                || nhanvien.SSoDienThoai.Trim().Length == 0;
            if (x == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            RefreshFrm();
        }

        private void btn_SuaNV_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            nhanvien = getNhanVienFromInfo();
            if (isFullInfo(nhanvien))
            {
                if (MessageBox.Show("Bạn có thật sự muốn sửa không!", "Thông Báo!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    if (nhanVienBUS.updateNhanVien(nhanvien))
                    {
                        RefreshFrm();
                        MessageBox.Show("Sửa Thành Công!", "Thông Báo !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Thông Tin Vừa Nhập Không Hợp Lệ !" +
                   "Vui Lòng Xem Lại", "Thông Báo");
            }
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            nhanvien = getNhanVienFromInfo();
                if (MessageBox.Show("Bạn có thật sự muốn xóa không!", "Thông Báo!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    if (nhanVienBUS.deleteNhanVien(nhanvien))
                    {
                        RefreshFrm();
                        MessageBox.Show("Xóa Thành Công!", "Thông Báo !");
                    }
                }
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_Serach_TextChanged(object sender, EventArgs e)
        {
            //string t = txt_Serach.Text;
            //if (t.Trim().Length ==0)
            //{
            //    showNV(matk);
            //} else
            //{
            //    showNhanVienSearch(t,matk);
            //}
        }

        private void showNhanVienSearch(string t, int matk)
        {
            dgr_NhanVien.DataSource = nhanVienBUS.getListNVSearch(t, matk);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string t = txt_Serach.Text;
            if (t.Trim().Length == 0)
            {
                showNV(matk);
            }
            else
            {
                showNhanVienSearch(t, matk);
            }
        }

        private void txt_Serach_Enter(object sender, EventArgs e)
        {
            if (txt_Serach.Text== "Nhập Mã NV Hoặc Tên Nhân Viên...")
            {
                txt_Serach.Text = "";
                txt_Serach.ForeColor = System.Drawing.Color.DarkCyan;

            }
        }

        private void txt_Serach_Leave(object sender, EventArgs e)
        {
            if (txt_Serach.Text=="")
            {
                txt_Serach.Text = "Nhập Mã NV Hoặc Tên Nhân Viên...";
                txt_Serach.ForeColor = System.Drawing.Color.BlueViolet;
            }
        }
    }
}
