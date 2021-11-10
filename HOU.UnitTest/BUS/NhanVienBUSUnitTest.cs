using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMQLBanHang.BUS;
using PMQLBanHang.DTO;
using System;

namespace HOU.UnitTest.BUS
{
    [TestClass]
    public class NhanVienBUSUnitTest
    {
        protected NhanVien nhanvien = new NhanVien();
        protected NhanVienBUS bus  = new NhanVienBUS();

        [TestMethod]
        public void addNhanVien()
        {
            nhanvien.DNgaySinh = new DateTime(1999,2,20);
            nhanvien.DNgayVaoLam = new DateTime(1999, 2, 20);
            nhanvien.IGioiTinh = 1;
            nhanvien.SQueQuan = "Ha Noi";
            nhanvien.SSoDienThoai = "0987654321";
            nhanvien.STenNV = "Xuan Dat";
            nhanvien.STrangThai = "1";

            var result = bus.addNhanVien(nhanvien);

            Assert.IsNotNull(result);
            Assert.IsTrue(result);
        }
    }
}
