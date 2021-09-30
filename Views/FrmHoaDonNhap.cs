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
    public partial class FrmHoaDonNhap : Form
    {
        int matk;
        int maloaitk;
        int maHDSelected;
        public int Message
        {
            get { return matk; }
            set { matk = value; }
        }
        QuanLyController quanLyController = new QuanLyController();
        HoaDonNhapController nhapController = new HoaDonNhapController();
        public FrmHoaDonNhap()
        {
            InitializeComponent();
        }

        private void FrmHoaDonNhap_Load(object sender, EventArgs e)
        {
            lbUser.Text = quanLyController.getUserName(matk);
            maloaitk = nhapController.getMaloaiFromMaTK(matk);
            showDSHD();
            initComponents();

        }

        private void showDSHD()
        {
            dgr_hoadonnhap.DataSource = nhapController.getListHD();
        }

        private void dgr_hoadonnhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int soluongrow = dgr_hoadonnhap.RowCount;
            int index = dgr_hoadonnhap.CurrentRow.Index;
            if (index < soluongrow - 1) // nếu nhấn vào hàng không có giá trị
            {
                cbNhanVien.Enabled = false;
                btn_Sua.Enabled = true;
                btn_Xóa.Enabled = true;
                lbMaHD.Text  = dgr_hoadonnhap.Rows[index].Cells[0].Value + "";
                maHDSelected =  Convert.ToInt32(dgr_hoadonnhap.Rows[index].Cells[0].Value);
                int manv = Convert.ToInt32(dgr_hoadonnhap.Rows[index].Cells[1].Value + "");
                cbNhanVien.Text = dgr_hoadonnhap.Rows[index].Cells[2].Value + "";
                dtpNhap.Value = Convert.ToDateTime(dgr_hoadonnhap.Rows[index].Cells[3].Value);
                txtTongtien.Text  = dgr_hoadonnhap.Rows[index].Cells[4].Value + "";
                txtTrangthai.Text = dgr_hoadonnhap.Rows[index].Cells[5].Value + "";
                showChiTietHoaDonByMaHD(maHDSelected);
                if (kiemtraTrangThai(txtTrangthai.Text) ==1)// 1 là đã thanh toán 0 là chưa thanh toán
                {
                    btn_thanhtoan.Enabled = false;
                }
                else
                {
                    btn_thanhtoan.Enabled = true;
                }
            }
            else
            {
                initComponents();
            }
        }

        private int kiemtraTrangThai(string tt)
        {
            
            if (tt.Equals("") || tt.Equals("Chưa Thanh Toán") ||Convert.ToInt32(tt)==0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private void showChiTietHoaDonByMaHD(int mahd)
        {
            dgr_chitiet_hdn.DataSource = nhapController.showChiTietHD(mahd);
        }

        private void initComponents()
        {
            txtTrangthai.Text = "0";
            lbMaHD.Text = "Mã HD";
            maHDSelected = -1;
            cbNhanVien.Enabled = true;
            cbNhanVien.DataSource = nhapController.getListNhanVienKho();
            cbNhanVien.DisplayMember = "sTenNV";
            cbNhanVien.ValueMember = "iMaNV";
            cbNhanVien.Text = "";
            dtpNhap.Value = DateTime.Today;
            dgr_chitiet_hdn.DataSource=null;
            txtTongtien.Text = "";
            btn_thanhtoan.Enabled = true;
            btn_Sua.Enabled = false;
            btn_Xóa.Enabled = false;
            if (maloaitk==4)
            {
                //dgr_hoadonnhap.Row = true;
                btn_ThemHD.Enabled = false;
                btn_Sua.Enabled = false;
                btn_Xóa.Enabled = false;
                btn_thanhtoan.Enabled = false;
            }
        }

        private int getNextMaHD()
        {
            int result = nhapController.getMaxMHDN() + 1;
            return result;
        }

        private void btn_ThemHD_Click(object sender, EventArgs e)
        {
            if (isFullInfo())
            {
                if (MessageBox.Show("Bạn có thật sự muốn thêm không!", "Thông Báo!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    HoaDonNhap donNhap = new HoaDonNhap();
                    donNhap = getDonNhapFromForm();
                    if (nhapController.addHoaDonNhap(donNhap))
                    {
                        MessageBox.Show("Thêm Thành Công!", "Thông Baso1");
                        RefreshFrm();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Không Thành Công!", "Thông Baso1");
                    }
                }
            }
        }

        private void RefreshFrm()
        {
            showDSHD();
            initComponents();
        }

        private HoaDonNhap getDonNhapFromForm()
        {
            HoaDonNhap nhap = new HoaDonNhap();
            nhap.Mahd = maHDSelected;
            nhap.Manv = Convert.ToInt32(cbNhanVien.SelectedValue);
            nhap.Ngaylap = dtpNhap.Value;
            nhap.Tongtien = 0;
            //nhap.Trangthai = Convert.ToInt32(txtTrangthai.Text);
            return nhap;
        }

        private bool isFullInfo()
        {
            if (cbNhanVien.Text.Equals(""))
            {
                MessageBox.Show("Hãy Chọn Nhân Viên!","Thông Báo !");
                return false; 
            } else if (dtpNhap.Value > DateTime.Today)
            {
                MessageBox.Show("Ngày Nhập không chính xác!", "Thông Báo !");
                    return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgr_hoadonnhap.CurrentRow.Selected == true)
            {
                if (!txtTrangthai.Text.Equals("0"))
                {
                    MessageBox.Show("Không thể Sửa Hóa Đơn Đã Thanh Toán !", "Thông Báo !");
                }
                else
                {
                    if (MessageBox.Show("Bạn có thật sự muốn sửa không!", "Thông Báo!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        if (isFullInfo())
                        {
                            HoaDonNhap hoaDonNhap = new HoaDonNhap();
                            hoaDonNhap = getDonNhapFromForm();
                            if (nhapController.updateHoaDonNhap(hoaDonNhap))
                            {
                                RefreshFrm();
                                MessageBox.Show("Cập Nhật thành công!", "Thông Báo !");
                            }
                            else
                            {
                                MessageBox.Show("Cập Nhật Không thành công!", "Thông Báo !");
                            }
                        }
                    }
                }
            } else
            {
                MessageBox.Show("Hãy Chọn Hóa Đơn cần sửa!", "Thông Báo !");
            }
        }

        private void btn_Xóa_Click(object sender, EventArgs e)
        {
            if (dgr_hoadonnhap.CurrentRow.Selected == true)
            {
                if (!txtTrangthai.Text.Equals("0"))
                {
                    MessageBox.Show("Không thể xóa hóa đơn đã thanh toán!", "Thông Báo !");
                }
                else
                {
                    if (MessageBox.Show("Bạn có thật sự muốn xóa không!", "Thông Báo!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {

                        if (isContainChiTietHD(maHDSelected+""))
                        {
                            // xóa hóa đơn và chi tiết hóa đơn
                            if (nhapController.deleteTwoTable(maHDSelected + ""))
                            {
                                RefreshFrm();
                                MessageBox.Show("Xóa Thành Công!", "Thông Báo !");
                            }
                            else
                            {
                                MessageBox.Show("Xóa Không Thành Công!", "Thông Báo !");
                            }
                        }
                        else
                        {
                            // xóa hóa đơn
                            if (nhapController.deleteOneTable(maHDSelected + ""))
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
                }
             }
            else
            {
                MessageBox.Show("Hãy Chọn Hóa Đơn cần sửa!", "Thông Báo !");
            }
        }

        private bool isContainChiTietHD(string mahd)
        {
            return nhapController.checkExistsCTHD(mahd);
        }

        private void btn_Detail_Click(object sender, EventArgs e)
        {
            if (maHDSelected!=-1)
            {
                switch (maloaitk)
                {
                    case 2: // quản lý
                        MessageBox.Show("Tính năng này chỉ cho phép Nhân Viên Kho!", "Thông Báo!"); break;
                    case 4:
                        FrmChiTietHoaDonNhap frmChiTiet = new FrmChiTietHoaDonNhap();
                        frmChiTiet.Message = matk;
                        frmChiTiet.NumberHD = maHDSelected;
                        this.Hide();
                        frmChiTiet.ShowDialog();
                        this.Show(); break;
                }
            }
            else
            {
                MessageBox.Show("Chọn 1 hóa đơn!", "Thông Báo!");
            }
            

        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            if (dgr_hoadonnhap.CurrentRow.Selected == true)
            {
                if (MessageBox.Show("Xác Nhận Thanh Toán!", "Thông Báo!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    if (nhapController.ThanhToan(lbMaHD.Text)) {
                        MessageBox.Show("Thanh Toán Thành Công!", "Thông Báo!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy Chọn Hóa Đơn Thanh Toán !", "Thông Báo!");
            }
        }
    }
}
