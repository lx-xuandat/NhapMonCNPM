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
    public partial class FrmChiTietHoaDonBan : Form
    {
        int matk;
        int maHD;
        int maspSelected;
        int tongtien;
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
        ChiTietHoaDonBanBUS ChiTietHoaDonBanBUS = new ChiTietHoaDonBanBUS();
        public FrmChiTietHoaDonBan()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void RefreshFrm()
        {
            initComponents();
        }
        private void FrmChiTietHoaDonBan_Load(object sender, EventArgs e)
        {
            lbUser.Text = quanLyBUS .getUserName(matk);
            initComponents();
        }

        private void initComponents()
        {
            tongtien = -1;
            maspSelected =-1;
            txtSohd.Text = maHD + "";
            dgrMatHang.DataSource = ChiTietHoaDonBanBUS .getListSPBan(maHD);
            dgrChiTietHang.DataSource = ChiTietHoaDonBanBUS .getListSPBanInCTHD(maHD);
            txtgia.Enabled = false;
            txtMahang.Enabled = false;
            txtTenhang.Enabled = false;
            btnThem.Enabled = false;
            txtTongtien.Text = ChiTietHoaDonBanBUS .getTongTienHD(maHD)+"";
            btnXoaSanPham.Enabled = false;
            
        }

        private void dgrMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int soluongrow = dgrMatHang.RowCount;
            int index = dgrMatHang.CurrentRow.Index;
            if (index < soluongrow - 1) // nếu nhấn vào hàng không có giá trị
            {
                btnXoaSanPham.Enabled = false;
                btnThem.Enabled = true;
                txtMahang.Text = dgrMatHang.Rows[index].Cells[0].Value + "";
                txtTenhang.Text = dgrMatHang.Rows[index].Cells[1].Value + "";
                txtgia.Text = dgrMatHang.Rows[index].Cells[1].Value + "";
                txtSoluongmua.Text = "1";
            }
            else
            {
                initComponents();
            }
        }

        private void txtSoluongmua_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgrMatHang.CurrentRow.Selected == true)
            {
                ChiTietHoaDonBan x =  getChiTietHoaDonBanFromForm();
                if (ChiTietHoaDonBanBUS.addSanPhamOrUpdateQuality(x)>0)
                {
                    MessageBox.Show("Thêm thành công!", "Thông Báo!");
                    RefreshFrm();
                }
            }
            else
            {
                MessageBox.Show("Hãy Chọn Hóa Đơn Thanh Toán !", "Thông Báo!");
            }
        }

        private ChiTietHoaDonBan getChiTietHoaDonBanFromForm()
        {
            ChiTietHoaDonBan x = new ChiTietHoaDonBan();
            x.Mahd = maHD;
            x.Masp = Convert.ToInt32(txtMahang.Text);
            x.Soluongmua = Convert.ToInt32(txtSoluongmua.Text);
            return x;
        }

        private void dgrChiTietHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoaSanPham.Enabled = true;
            int soluongrow = dgrChiTietHang.RowCount;
            int index = dgrChiTietHang.CurrentRow.Index;
            if (index < soluongrow - 1) // nếu nhấn vào hàng không có giá trị
            {
                maspSelected = Convert.ToInt32(dgrChiTietHang.Rows[index].Cells[0].Value);
                tongtien = Convert.ToInt32(dgrChiTietHang.Rows[index].Cells[4].Value+"");
            }
            else
            {
                initComponents();
            }
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            if (dgrChiTietHang.CurrentRow.Selected == true && maspSelected!=-1)
            {
                
                if (ChiTietHoaDonBanBUS .deleteSanPhamInChiTietHoaDon(maHD,maspSelected,tongtien) > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông Báo!");
                    RefreshFrm();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn sản phẩm trong hóa đơn !", "Thông Báo!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshFrm();
        }
    }
}
