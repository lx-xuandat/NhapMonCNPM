using PMQLBanHang.Controllers;
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
    public partial class FrmChiTietHoaDonNhap : Form
    {
        int matk;
        public int Message
        {
            get { return matk; }
            set { matk = value; }
        }
        QuanLyController quanLyController = new QuanLyController();
        public FrmChiTietHoaDonNhap()
        {
            InitializeComponent();
        }

        private void FrmChiTietHoaDonNhap_Load(object sender, EventArgs e)
        {
            lbUser.Text = quanLyController.getUserName(matk);
        }
    }
}
