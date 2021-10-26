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
    public partial class FrmHoaDonBan : Form
    {
        int matk;
        int maloaitk;
        int maHDSelected;
        public int Message
        {
            get { return matk; }
            set { matk = value; }
        }
        QuanLyBUS quanLyBUS = new QuanLyBUS();
        HoaDonBanHangBUS banHangBUS = new HoaDonBanHangBUS();
        public FrmHoaDonBan()
        {
            InitializeComponent();
        }
        private void FrmHoaDonBan_Load(object sender, EventArgs e)
        {
            lbUser.Text = quanLyBUS.getUserName(matk);
            maloaitk = banHangBUS.getMaloaiFromMaTK(matk);
            showDSHD();
            initComponents();
        }
        private void showDSHD()
        {
            dgr_hoadonban.DataSource = banHangBUS.getListHD();
        }
        private void initComponents()
        {
            txtTrangthai.Text = "0";
            lbMaHD.Text = "Mã HD";
            maHDSelected = -1;
            cbNhanVien.Enabled = true;
            cbNhanVien.DataSource = banHangBUS.getListNhanVienBanHang();
            cbNhanVien.DisplayMember = "sTenNV";
            cbNhanVien.ValueMember = "iMaNV";
            cbNhanVien.Text = "";
            dtpLap.Value = DateTime.Today;
            dgr_chitiet_hdb.DataSource = null;
            txtTongtien.Text = "";
            btn_thanhtoan.Enabled = true;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_ThemHD.Enabled = true;
            btn_Detail.Enabled = false;
            if (maloaitk == 4)
            {
                btn_ThemHD.Enabled = false;
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
                btn_thanhtoan.Enabled = false;
            }
        }
        private void RefreshFrm()
        {
            showDSHD();
            initComponents();
        }
        private HoaDonBan getDonBanFromForm()
        {
            HoaDonBan banhang = new HoaDonBan();
            banhang.Mahd = maHDSelected;
            banhang.Manv = Convert.ToInt32(cbNhanVien.SelectedValue);
            banhang.Ngaylap = dtpLap.Value;
            banhang.Tongtien = Convert.ToInt32(txtTongtien.Text);
            return banhang;
        }

        private bool isFullInfo()
        {
            if (cbNhanVien.Text.Equals(""))
            {
                MessageBox.Show("Hãy Chọn Nhân Viên!", "Thông Báo !");
                return false;
            }
            else if (dtpLap.Value > DateTime.Today)
            {
                MessageBox.Show("Ngày Lập không chính xác!", "Thông Báo !");
                return false;
            }
            else
            {
                return true;
            }
        }
       

        private void btn_ThemHD_Click(object sender, EventArgs e)
        {
            if (isFullInfo())
            {
                if (MessageBox.Show("Bạn có thật sự muốn thêm không!", "Thông Báo!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    HoaDonBan donBan = new HoaDonBan();
                    donBan = getDonBanFromForm();
                    if (banHangBUS.addHoaDonBan(donBan))
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
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgr_hoadonban.CurrentRow.Selected == true)
            {
                if (!txtTrangthai.Text.Equals("Chưa Thanh Toán"))
                {
                    MessageBox.Show("Không thể Sửa Hóa Đơn Đã Thanh Toán !", "Thông Báo !");
                }
                else
                {
                    if (MessageBox.Show("Bạn có thật sự muốn sửa không!", "Thông Báo!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        if (isFullInfo())
                        {
                            HoaDonBan hoaDon = new HoaDonBan();
                            hoaDon = getDonBanFromForm();
                            if (banHangBUS.updateHoaDonBan(hoaDon))
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
            }
            else
            {
                MessageBox.Show("Hãy Chọn Hóa Đơn cần sửa!", "Thông Báo !");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgr_hoadonban.CurrentRow.Selected == true)
            {
                if (!txtTrangthai.Text.Equals("Chưa Thanh Toán"))
                {
                    MessageBox.Show("Không thể xóa hóa đơn đã thanh toán!", "Thông Báo !");
                }
                else
                {
                    if (MessageBox.Show("Bạn có thật sự muốn xóa không!", "Thông Báo!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        // xóa hóa đơn và chi tiết hóa đơn
                        if (banHangBUS.deleteHoaDonBanHang(maHDSelected + ""))
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
        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            if (dgr_hoadonban.CurrentRow.Selected == true)
            {
                if (MessageBox.Show("Xác Nhận Thanh Toán!", "Thông Báo!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    if (banHangBUS.ThanhToan(lbMaHD.Text))
                    {
                        MessageBox.Show("Thanh Toán Thành Công!", "Thông Báo!");
                        RefreshFrm();
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy Chọn Hóa Đơn Thanh Toán !", "Thông Báo!");
            }
        }

        private void dgr_hoadonban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int soluongrow = dgr_hoadonban.RowCount;
            int index = dgr_hoadonban.CurrentRow.Index;
            if (index < soluongrow - 1) // nếu nhấn vào hàng không có giá trị
            {
                cbNhanVien.Enabled = false;
                btn_Sua.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_ThemHD.Enabled = false;
                lbMaHD.Text = dgr_hoadonban.Rows[index].Cells[0].Value + "";
                maHDSelected = Convert.ToInt32(dgr_hoadonban.Rows[index].Cells[0].Value);
                int manv = Convert.ToInt32(dgr_hoadonban.Rows[index].Cells[1].Value + "");
                cbNhanVien.Text = dgr_hoadonban.Rows[index].Cells[2].Value + "";
                dtpLap.Value = Convert.ToDateTime(dgr_hoadonban.Rows[index].Cells[3].Value);
                txtTongtien.Text = dgr_hoadonban.Rows[index].Cells[4].Value + "";
                txtTrangthai.Text = dgr_hoadonban.Rows[index].Cells[5].Value + "";
                showChiTietHoaDonByMaHD(maHDSelected);
                if (kiemtraTrangThai(txtTrangthai.Text) == 1)// 1 là đã thanh toán 0 là chưa thanh toán
                {
                    btn_thanhtoan.Enabled = false;
                    btn_Detail.Enabled = false;
                }
                else
                {
                    btn_thanhtoan.Enabled = true;
                    btn_Detail.Enabled = true;

                }
            }
            else
            {
                initComponents();
            }
        }

        private int kiemtraTrangThai(string text)
        {
            if (text.Equals("") || text.Equals("Chưa Thanh Toán"))
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private void showChiTietHoaDonByMaHD(int maHDSelected)
        {
            dgr_chitiet_hdb.DataSource = banHangBUS.showChiTietHD(maHDSelected);
        }

        private void btn_Detail_Click(object sender, EventArgs e)
        {
            if(!txtTrangthai.Text.Equals("Chưa Thanh Toán"))
            {
                MessageBox.Show("Hóa đơn này đã thanh toán!", "Thông Báo!");
            }
            else
            {
                if (maHDSelected != -1)
                {
                    switch (maloaitk)
                    {
                        case 2: // quản lý
                            MessageBox.Show("Tính năng này chỉ cho phép Nhân Viên Bán Hàng!", "Thông Báo!"); break;
                        case 3:
                            FrmChiTietHoaDonBan frmChiTiet = new FrmChiTietHoaDonBan();
                            frmChiTiet.Message = matk;
                            frmChiTiet.NumberHD = maHDSelected;
                            this.Hide();
                            frmChiTiet.ShowDialog();
                            RefreshFrm();
                            this.Show(); break;
                    }
                }
                else
                {
                    MessageBox.Show("Chọn 1 hóa đơn!", "Thông Báo!");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
