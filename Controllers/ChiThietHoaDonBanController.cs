using PMQLBanHang.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBanHang.Controllers
{
    class ChiThietHoaDonBanController
    {
        ConnectDB connectDB = new ConnectDB();
        internal DataTable getListSPNhapInCTHD(int mahd)
        {
            //create proc sp_ds_SanPham_CTHDBanHang @mahd int
            //as
            //    begin
            //        select b.iMaSP as N'Mã Sản Phẩm', b.sTenSP as N'Tên Sản Phẩm', a.iSoLuongBan as N'Số Lượng Bán', B.fGia as N'Giá Nhập', (b.fGia * a.iSoLuongBan) as N'Thành Tiền'
            //        from tblChiTietHDB a, tblSanPham b
            //        where iMaHDB = @mahd and a.iMaSP = b.iMaSP
            //    end
            string[] nameParams = new string[] { "@mahd" };
            object[] values = new object[] { mahd };
            return connectDB.ExecuteProc("sp_ds_SanPham_CTHDBanHang", nameParams, values);
        }
        internal int addSanPhamOrUpdateQuality(ChiTietHoaDonBan x)
        {
            //create proc sp_them_SanPham_CTHDBan @mahd int, @masp int, @soluongban int
            //as
            //begin
            // declare @tontai int
            // set @tontai = (select count(iMaHDB) from tblChiTietHDB where iMaHDB = @mahd and iMaSP = @masp)
            // if @tontai = 0
            //    begin
            //        update tblChiTietHDB
            //        set iSoLuongBan = iSoLuongBan + @soluongban
            //        where iMaHDB = @mahd and iMaSP = @masp
            //    end
            //    else
            //                begin
            //                    insert into tblChiTietHDB values(@mahd, @masp, @soluongban);
            //            end
            //        update tblSanPham
            //        set iSoLuong = iSoLuong - @soluongban
            //    where iMaSP = @masp
            //end
            string[] nameParams = new string[] { "@mahd", "@masp", "@soluongban" }; 
            object[] values = new object[] { x.Mahd, x.Masp, x.Soluongmua };
            return connectDB.ExecuteNonProc("sp_them_SanPham_CTHDBan", nameParams, values);
        }
        internal int updateSanPhamInChiTietHoaDon(ChiTietHoaDonBan x)
        {
            //create proc sp_capnhat_SanPham_CTHDBan @mahd int, @masp int, @soluongban int
            //as
            //begin
            //    declare @soluongbandau int
            //    set @soluongbandau = (select iSoLuongBan from tblChiTietHDB where iMaHDB = @mahd and iMaSP = @masp)
	           // update tblChiTietHDB
            //    set iSoLuongBan = @soluongban
            //    where iMaHDB = @mahd and iMaSP = @masp
            //    update tblSanPham
            //    set iSoLuong = iSoLuong + @soluongbandau - @soluongban
            //    where iMaSP = @masp
            //end
            //go
            string[] nameParams = new string[] { "@mahd", "@masp", "@soluongban" };
            object[] values = new object[] { x.Mahd, x.Masp, x.Soluongmua };
            return connectDB.ExecuteNonProc("sp_capnhat_SanPham_CTHDBan", nameParams, values);
        }
        internal int deleteSanPhamInChiTietHoaDon(ChiTietHoaDonBan x)
        {
            //create proc sp_xoa_SanPham_CTHDBan @mahd int, @masp int
            //as
            //begin
            //    declare @soluongxoa int
            //    set @soluongxoa = (select iSoLuongBan from tblChiTietHDB where iMaHDB = @mahd and iMaSP = @masp)
	           // delete tblChiTietHDB
            //    where iMaHDB = @mahd and iMaSP = @masp
            //    update tblSanPham
            //    set iSoLuong = iSoLuong + @soluongxoa
            //    where iMaSP = @masp
            //end
            string[] nameParams = new string[] { "@mahd", "@masp" };
            object[] values = new object[] { x.Mahd, x.Masp };
            return connectDB.ExecuteNonProc("sp_xoa_SanPham_CTHDBan", nameParams, values);
        }
    }
}
