using PMQLBanHang.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBanHang.Controllers
{
    class ChiTietHoaDonNhapController
    {
        ConnectDB connectDB = new ConnectDB();
        internal DataTable getListSPNhapInCTHD(int mahd)
        {
            //create proc sp_ds_SanPham_CTHDNhap @mahd int
            //as
            //    begin
            //        select b.iMaSP as N'Mã Sản Phẩm', b.sTenSP as N'Tên Sản Phẩm', a.iSoLuongNhap as N'Số Lượng Nhập', a.fGiaNhap as N'Giá Nhập', (a.fGiaNhap * a.iSoLuongNhap) as N'Thành Tiền'
            //        from tblChiTietHDN a, tblSanPham b
            //        where iMaHDN = @mahd and a.iMaSP = b.iMaSP
            //    end
            string[] nameParams = new string[] { "@mahd" };
            object[] values = new object[] { mahd};
            return connectDB.ExecuteProc("sp_ds_SanPham_CTHDNhap",nameParams, values);
        }
        internal int addSanPhamOrUpdateQuality(ChiTietHoaDonNhap x)
        {
            //create proc sp_them_SanPham_CTHDNhap @mahd int, @masp int, @soluongnhap int, @gianhap float
            //as
            //    begin
            //        declare @tontai int
            //        set @tontai = (select count(iMaHDN) from tblChiTietHDN where iMaHDN = @mahd and iMaSP = @masp)
            //  if @tontai = 0
            //            begin
            //                update tblChiTietHDN
            //                set iSoLuongNhap = iSoLuongNhap + @soluongnhap,fGiaNhap = @gianhap
            //                where iMaHDN = @mahd and iMaSP = @masp
            //            end
            //        else
            //                begin
            //                    insert into tblChiTietHDN values(@mahd, @masp, @soluongnhap, @gianhap);
            //            end
            //    end   //    end
            string[] nameParams = new string[] { "@mahd","@masp","@soluongnhap","@gianhap" };
            object[] values = new object[] { x.Mahd,x.Masp,x.Soluongnhap,x.Gianhap };
            return connectDB.ExecuteNonProc("sp_them_SanPham_CTHDNhap", nameParams, values);
        }
    }
}
