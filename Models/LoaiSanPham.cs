using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBanHang.Models
{
    class LoaiSanPham
    {
        int maloaisp;
        string tenloaisp;

        public int Maloaisp { get => maloaisp; set => maloaisp = value; }
        public string Tenloaisp { get => tenloaisp; set => tenloaisp = value; }

        public LoaiSanPham(int maloaisp, string tenloaisp)
        {
            this.maloaisp = maloaisp;
            this.tenloaisp = tenloaisp;
        }

        public LoaiSanPham()
        {
        }
    }
}
