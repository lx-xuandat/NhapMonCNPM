using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBanHang.DTO
{
    class NhanVien
    {
		//		create table tblNhanVien(
		//iMaNV int identity(1,1) primary key(iMaNV),
		//	sTenNV nvarchar(70),
		//	iGioiTinh int,
		//	sQueQuan nvarchar(255),
		//	dNgaySinh date,
		//	dNgayVaoLam date,
		//	sSDT varchar(15),
		//	sChucVu nvarchar(50),
		//);
		int iMaNV;
		string sTenNV;
		int iGioiTinh;
		string sQueQuan;
		DateTime dNgaySinh;
		DateTime dNgayVaoLam;
		string sSoDienThoai;
		string sTrangThai;

		public int IMaNV { get => iMaNV; set => iMaNV = value; }
		public string STenNV { get => sTenNV; set => sTenNV = value; }
		public int IGioiTinh { get => iGioiTinh; set => iGioiTinh = value; }
		public string SQueQuan { get => sQueQuan; set => sQueQuan = value; }
		public DateTime DNgaySinh { get => dNgaySinh; set => dNgaySinh = value; }
		public DateTime DNgayVaoLam { get => dNgayVaoLam; set => dNgayVaoLam = value; }
		public string SSoDienThoai { get => sSoDienThoai; set => sSoDienThoai = value; }
		public string STrangThai{ get => sTrangThai; set => sTrangThai = value; }
	}
}
