using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBanHang.DTO
{
    class ChiTietHoaDonNhap
    {
        int mahd;
        int masp;
        int soluongnhap;
        float gianhap;

        public ChiTietHoaDonNhap()
        {
        }

        public ChiTietHoaDonNhap(int mahd, int masp, int soluongnhap, float gianhap)
        {
            this.Mahd = mahd;
            this.Masp = masp;
            this.Soluongnhap = soluongnhap;
            this.Gianhap = gianhap;
        }

        public int Mahd { get => mahd; set => mahd = value; }
        public int Masp { get => masp; set => masp = value; }
        public int Soluongnhap { get => soluongnhap; set => soluongnhap = value; }
        public float Gianhap { get => gianhap; set => gianhap = value; }
    }
}
