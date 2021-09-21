using PMQLBanHang.Controllers;
using PMQLBanHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMQLBanHang.Views
{
    public partial class FrmSanPham : Form
    {
        string filePath="";
        int matk;
        public int Message
        {
            get { return matk; }
            set { matk = value; }
        }
        QuanLyController quanLyController = new QuanLyController();
        SanPhamController sanPhamController = new SanPhamController();
        public FrmSanPham()
        {
            InitializeComponent();
        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            lbUser.Text = quanLyController.getUserName(matk);
            //avatar.Image = Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\ProImages\"+"1.jpg");
            //MessageBox.Show(Path.GetDirectoryName(Application.ExecutablePath) + @"\ProImages\");
            showSP();
            initComponents();
        }

        private void showSP()
        {
            dgr_sanpham.DataSource = sanPhamController.getListSP();
        }

        private void initComponents()
        {
            cbLoaiSP.DataSource = getListLoaiSP();
            cbLoaiSP.DisplayMember = "tenloaisp";
            cbLoaiSP.ValueMember = "maloaisp";
            cbLoaiSP.SelectedIndex = 1;
            CbTenNcc.DataSource = getListNCC();
            CbTenNcc.DisplayMember = "tenncc";
            CbTenNcc.ValueMember = "mancc";
            CbTenNcc.SelectedIndex = 1;
            txt_tensp.Text = "";
            txtGia.Text = "";
            txtSoluong.Text = "";
            dtpNSX.Value =DateTime.Today;
            dtpHSD.Value = DateTime.Today;
            avatar.Image = Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\ProImages\" + "9400570_orig.png");
            btn_Save.Enabled = true;
            fileName1.Text = "fileName";
            btn_sua.Enabled = false;
            btn_Xoa.Enabled = false;
            lbMaSp.Text = "Mã sp";
        }

        private List<NCC> getListNCC()
        {
            List<NCC> ncc = sanPhamController.getListNCC();
            return ncc;
        }

        private void avatar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog  ofd = new OpenFileDialog() { Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filePath = ofd.FileName;
                    fileName1.Text = ofd.SafeFileName;
                    avatar.Image = Image.FromFile(filePath);
                }
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            saveImage();
        }

        private bool saveImage()
        {
            bool isSuccess = false;
            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\ProImages\"; // <---
            if (Directory.Exists(appPath) == false)                                              // <---
            {                                                                                    // <---
                Directory.CreateDirectory(appPath);                                              // <---
            }                                                                                    // <---         
            try
            {
                if (!fileName1.Text.Equals("fileName"))
                {
                    string iName = fileName1.Text;
                    if (System.IO.File.Exists(appPath + iName))
                    {
                        // MessageBox.Show("Tồn tại ảnh"+ appPath + iName);
                        return true;
                    }
                    else
                    {
                        File.Copy(filePath, appPath + iName); // copy ảnh từ filePath tới apppath với tên iname
                        MessageBox.Show("Thêm thành công " + iName + "vào" + appPath);
                        Console.WriteLine(iName);
                        isSuccess = true;
                    }
                }
            }
            catch (Exception exp)
            {
                isSuccess = false;
                MessageBox.Show("Unable to open file " + exp.Message);
            }
            return isSuccess;
        }

        private void dgr_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int soluongrow = dgr_sanpham.RowCount;
            int index = dgr_sanpham.CurrentRow.Index;
            if (index < soluongrow - 1) // nếu nhấn vào hàng không có giá trị
            {
                btn_Save.Enabled = false;
                btn_sua.Enabled = true;
                btn_Xoa.Enabled = true;
                lbMaSp.Text = dgr_sanpham.Rows[index].Cells[0].Value + "";
                txt_tensp.Text = dgr_sanpham.Rows[index].Cells[1].Value + "";
                int Maloaisp = Convert.ToInt32(dgr_sanpham.Rows[index].Cells[2].Value + "");
                cbLoaiSP.SelectedValue = Maloaisp;
                int MaNCC = Convert.ToInt32(dgr_sanpham.Rows[index].Cells[3].Value + "");
                CbTenNcc.SelectedValue = MaNCC;
                txtGia.Text = dgr_sanpham.Rows[index].Cells[4].Value + "";
                txtSoluong.Text = dgr_sanpham.Rows[index].Cells[5].Value + "";
                cbDonviTinh.Text = dgr_sanpham.Rows[index].Cells[6].Value + "";
                dtpNSX.Text = dgr_sanpham.Rows[index].Cells[7].Value + "";
                dtpHSD.Text = dgr_sanpham.Rows[index].Cells[8].Value + "";
                string hinhanh = dgr_sanpham.Rows[index].Cells[9].Value + "";
                if (hinhanh.Length==0)
                {
                    fileName1.Text = "fileName";
                    avatar.Image = Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\ProImages\" + "9400570_orig.png");
                } else
                {
                    fileName1.Text = hinhanh;
                    saveImage();
                    avatar.Image = Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\ProImages\" + hinhanh);

                }
            }
            else
            {
                initComponents();
            }
        }
        private List<LoaiSanPham> getListLoaiSP()
        {
            List<LoaiSanPham> loaiSanPhams =  sanPhamController.getListLoaiSP();
            return loaiSanPhams;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (isFullInfo())
            {
                if (MessageBox.Show("Bạn có thật sự muốn sửa không!", "Thông Báo!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    SanPham sanPham = new SanPham();
                    sanPham = getSanPhamFromFrm();
                    if (sanPhamController.updateSanPham(sanPham) && saveImage())
                    {
                        refreshFrm();
                        MessageBox.Show("Cập Nhật Thành Công !", "Thông Báo !");
                    }
                }
            }
        }

        private bool isFullInfo()
        {
            if (txt_tensp.Text.Length ==0)
            {
                MessageBox.Show("Tên Sản Phẩm Không được để trống!", "Thông Báo !"); return false;
            } else if (txtSoluong.Text.Length == 0)
            {
                MessageBox.Show("Hãy Nhập số lượng !", "Thông Báo !"); return false;
            }  else
            {
                return true;
            }
        }

        private void refreshFrm()
        {
            showSP();
            initComponents();
        }

        private SanPham getSanPhamFromFrm()
        {
            SanPham san = new SanPham();
            san.Masp = Convert.ToInt32(lbMaSp.Text);
            san.Tensp = txt_tensp.Text;
            san.Maloaisp = Convert.ToInt32(cbLoaiSP.SelectedValue);
            // MessageBox.Show(cbLoaiSP.SelectedValue + "");
            san.Mancc = Convert.ToInt32(CbTenNcc.SelectedValue);
            san.Gia = float.Parse(txtGia.Text);
            san.Soluong = Convert.ToInt32(txtSoluong.Text);
            san.Donvitinh = cbDonviTinh.Text;
            san.Nsx = dtpNSX.Value;
            san.Hsd = dtpHSD.Value;
            if (fileName1.Text.Equals("fileName"))
            {
                san.Hinhanh = "";
            }
            else
            {
                san.Hinhanh = fileName1.Text;
            }
            
            return san;
        }

        private void btn_chonanh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filePath = ofd.FileName;
                    fileName1.Text = ofd.SafeFileName;
                    avatar.Image = Image.FromFile(filePath);
                }
            }
        }
    }
}
