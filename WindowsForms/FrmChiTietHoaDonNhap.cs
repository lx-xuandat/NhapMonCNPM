using PMQLBanHang.BUS;
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
    public partial class FrmChiTietHoaDonBanHang : Form
    {
        int matk;
        int maHD;
        public int Message
        {
            get { return matk; }
            set { matk = value; }
        }
        public int NumberHD
        {
            get { return maHD; }
            set { maHD = value; }
        }
        QuanLyBUS quanLyBUS = new QuanLyBUS();
        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        ChiTietHoaDonBanBUS ChiTietHoaDonNhapBUS = new ChiTietHoaDonBanBUS();
        public FrmChiTietHoaDonBanHang()
        {
            InitializeComponent();
        }

        private void FrmChiTietHoaDonNhap_Load(object sender, EventArgs e)
        {
            lbUser.Text = quanLyBUS.getUserName(matk);
           
            initComponents();
        }
        private void initComponents()
        {
            txtSohd.Text = maHD + "";
            dgrMatHang.DataSource = sanPhamBUS.getListSP();
            dgrChiTietHang.DataSource = ChiTietHoaDonNhapBUS.getListSPBanInCTHD(maHD);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void dgrMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int soluongrow = dgrMatHang.RowCount;
            int index = dgrMatHang.CurrentRow.Index;
            if (index < soluongrow - 1) // nếu nhấn vào hàng không có giá trị
            {
                btnCapnhatsoluong.Enabled = false;
                btnXoaSanPham.Enabled = false;
                btnThem.Enabled = true;
                txtMahang.Text = dgrMatHang.Rows[index].Cells[0].Value + "";
                txtTenhang.Text = dgrMatHang.Rows[index].Cells[2].Value+"";
                int manv = Convert.ToInt32(dgrMatHang.Rows[index].Cells[1].Value + "");
                //cbNhanVien.Text = dgr_hoadonnhap.Rows[index].Cells[2].Value + "";
                //dtpNhap.Value = Convert.ToDateTime(dgr_hoadonnhap.Rows[index].Cells[3].Value);
                //txtTongtien.Text = dgr_hoadonnhap.Rows[index].Cells[4].Value + "";
                //txtTrangthai.Text = dgr_hoadonnhap.Rows[index].Cells[5].Value + "";
                //showChiTietHoaDonByMaHD(maHDSelected);
                //if (kiemtraTrangThai(txtTrangthai.Text) == 1)// 1 là đã thanh toán 0 là chưa thanh toán
                //{
                //    btn_thanhtoan.Enabled = false;
                //}
                //else
                //{
                //    btn_thanhtoan.Enabled = true;
                //}
            }
            else
            {
                initComponents();
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
