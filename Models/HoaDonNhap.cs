using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBanHang.Models
{
    class HoaDonNhap
    {
        int mahd;
        int manv;
        DateTime ngaylap;
        float tongtien;
        int trangthai;

        public int Mahd { get => mahd; set => mahd = value; }
        public int Manv { get => manv; set => manv = value; }
        public DateTime Ngaylap { get => ngaylap; set => ngaylap = value; }
        public float Tongtien { get => tongtien; set => tongtien = value; }
        public int Trangthai { get => trangthai; set => trangthai = value; }

        public HoaDonNhap(int mahd, int manv, DateTime ngaylap, float tongtien, int trangthai)
        {
            this.Mahd = mahd;
            this.Manv = manv;
            this.Ngaylap = ngaylap;
            this.Tongtien = tongtien;
            this.Trangthai = trangthai;
        }

        public HoaDonNhap()
        {
        }
    }
}
