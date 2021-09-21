using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBanHang.Models
{
    class SanPham
    {
        int masp;
        string tensp;
        int maloaisp;
        int mancc;
        float gia;
        int soluong;
        string donvitinh;
        DateTime nsx;
        DateTime hsd;
        string hinhanh;

        public int Masp { get => masp; set => masp = value; }
        public string Tensp { get => tensp; set => tensp = value; }
        public int Maloaisp { get => maloaisp; set => maloaisp = value; }
        public int Mancc { get => mancc; set => mancc = value; }
        public float Gia { get => gia; set => gia = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string Donvitinh { get => donvitinh; set => donvitinh = value; }
        public DateTime Nsx { get => nsx; set => nsx = value; }
        public DateTime Hsd { get => hsd; set => hsd = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }

        public SanPham(int masp, string tensp, int maloaisp, int mancc, float gia, int soluong, string donvitinh, DateTime nsx, DateTime hsd, string hinhanh)
        {
            this.masp = masp;
            this.tensp = tensp;
            this.maloaisp = maloaisp;
            this.mancc = mancc;
            this.gia = gia;
            this.soluong = soluong;
            this.donvitinh = donvitinh;
            this.nsx = nsx;
            this.hsd = hsd;
            this.hinhanh = hinhanh;
        }

        public SanPham()
        {
        }
    }
}







