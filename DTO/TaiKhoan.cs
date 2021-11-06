using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBanHang.DTO
{
    class TaiKhoan
    {
        int matk;
        string tendangnhap;
        string matkhau;
        int maloaitk;
        int manv;

        public int Matk { get => matk; set => matk = value; }
        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public int Maloaitk { get => maloaitk; set => maloaitk = value; }
        public int Manv { get => manv; set => manv = value; }

        public TaiKhoan(int matk, string tendangnhap, string matkhau, int maloaitk, int manv)
        {
            this.matk = matk;
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.maloaitk = maloaitk;
            this.manv = manv;
        }

        public TaiKhoan()
        {
        }
    }
}
