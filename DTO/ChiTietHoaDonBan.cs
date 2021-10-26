using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBanHang.DTO
{
    class ChiTietHoaDonBan
    {
        int mahd;
        int masp;
        int soluongmua;

        public ChiTietHoaDonBan()
        {
        }

        public ChiTietHoaDonBan(int mahd, int masp, int soluongmua)
        {
            this.Mahd = mahd;
            this.Masp = masp;
            this.Soluongmua = soluongmua;
        }

        public int Mahd { get => mahd; set => mahd = value; }
        public int Masp { get => masp; set => masp = value; }
        public int Soluongmua { get => soluongmua; set => soluongmua = value; }
    }
}
