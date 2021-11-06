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
    public partial class FrmQuanLy : Form
    {
        int matk;
        public int Message
        {
            get { return matk; }
            set { matk = value; }
        }
        public FrmQuanLy()
        {
            InitializeComponent();
           
        }
        private void FrmQuanLy_Load(object sender, EventArgs e)
        {
            
            QuanLyBUS quanLyBUS = new QuanLyBUS();
            labelName.Text=quanLyBUS.getUserName(matk);
        }

        private void btn_QLNhanVien_Click(object sender, EventArgs e)
        {
            FrmNhanVien frmNhanVien = new FrmNhanVien();
            this.Hide();
            frmNhanVien.Message = matk;
            frmNhanVien.ShowDialog();
            this.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_QlyTaiKhoan_Click(object sender, EventArgs e)
        {
            FrmTaiKhoan frmtaikhoan = new FrmTaiKhoan();
            this.Hide();
            frmtaikhoan.Message = matk;
            frmtaikhoan.ShowDialog();
            this.Show();
        }

        private void btn_QLSanPham_Click(object sender, EventArgs e)
        {
            FrmSanPham frmSanPham = new FrmSanPham();
            this.Hide();
            frmSanPham.Message = matk;
            frmSanPham.ShowDialog();
            this.Show();
        }

        private void btn_QLHoaDonNhap_Click(object sender, EventArgs e)
        {
            //FrmHoaDonNhap frmHoaDonNhap = new FrmHoaDonNhap();
            //this.Hide();
            //frmHoaDonNhap.Message = matk;
            //frmHoaDonNhap.ShowDialog();
            //this.Show();
            FrmHoaDonBan frmHoaDonBan = new FrmHoaDonBan();
            this.Hide();
            frmHoaDonBan.Message = matk;
            frmHoaDonBan.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
