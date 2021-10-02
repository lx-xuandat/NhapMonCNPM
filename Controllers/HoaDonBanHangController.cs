using PMQLBanHang.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBanHang.Controllers
{
    class HoaDonBanHangController
    {
        ConnectDB connectDB = new ConnectDB();
        internal object getListHD()
        {
            DataTable data = connectDB.ExecuteProc("sp_ds_HoaDonBan");
            //return changeGender(data);
            return data;
        }

        internal List<NhanVien> getListNhanVienBanHang()
        {
            DataTable data = connectDB.ExecuteProc("sp_ds_NhanVienBanHang");
            List<NhanVien> list = new List<NhanVien>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                NhanVien nhanvien = new NhanVien();
                nhanvien.IMaNV = Convert.ToInt32(data.Rows[i]["iMaNV"]);
                nhanvien.STenNV = data.Rows[i]["sTenNV"].ToString();
                list.Add(nhanvien);
            }
            return list;
        }

        internal bool addHoaDonBan(HoaDonBan x)
        {
            //create proc sp_them_HoaDonBan @mahd int, @manv int, @ngaylap datetime
            //    as
            //    begin
            //    insert into tblHoaDonBan values(@manv, @ngaylap,0,0);
            //end
            string nameProc = "sp_them_HoaDonBan";
            string[] nameParams = new string[] { "@mahd", "@manv", "@ngaylap" };
            Object[] valuePrams = new Object[] { x.Mahd, x.Manv, x.Ngaylap };
            if (connectDB.ExecuteNonProc(nameProc, nameParams, valuePrams) != 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        internal DataTable showChiTietHD(int mahd)
        {
            string query = "select a.iMaHDB as N'Mã HĐ',a.iMaSP as N'Mã SP', b.fGia as N'Giá Bán', a.iSoLuongBan as N'Số Lượng Bán', (a.iSoLuongBan*b.fGia) as N'Thành Tiền'"
            + "from tblChiTietHDB a, tblSanPham b where  a.iMaSP = b.iMaSP and a.iMaHDB = "+ mahd;
            return connectDB.ExecuteQuery(query);
        }

        internal bool updateHoaDonBan(HoaDonBan x)
        {
            //create proc sp_capnhat_HoaDonBan @mahd int, @manv int, @ngaylap datetime,@tongtien float, @trangthai int
            //as
            //begin
            //    update tblHoaDonBan
            //    set iMaNV = @manv, dNgayLap = @ngaylap, fTongTien = @tongtien, iTrangThai = @trangthai
            //    where iMaHDB = @mahd
            //end
            string nameProc = "sp_capnhat_HoaDonBan";
            string[] nameParams = new string[] { "@mahd", "@manv", "@ngaylap", "@tongtien", "@trangthai" };
            Object[] valuePrams = new Object[] { x.Mahd, x.Manv, x.Ngaylap, x.Tongtien, x.Trangthai };
            if (connectDB.ExecuteNonProc(nameProc, nameParams, valuePrams) != 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

     
        internal bool deleteHoaDonBanHang(string mahd)
        {
            //create proc sp_xoa_HoaDonBan_va_ChiTietHDB @mahd int
            //    begin
            //        declare @count int
            //        set @count = (select count(iMaHDB) from tblChiTietHDB where iMaHDB = @mahd)
		          //  --không có chi tiết hóa đơn
            //        if @count = 0
            //            delete tblHoaDonBan
            //            where iMaHDB = @mahd
            //        -- có chi tiết háo đơn
            //        else
            //                delete tblHoaDonBan
            //            where iMaHDB = @mahd
            //            delete tblHoaDonBan
            //            where iMaHDB = @mahd
            //    end
            //go
            string nameProc = "sp_xoa_HoaDonBan_va_ChiTietHDB";
            string[] nameParams = new string[] { "@mahd" };
            Object[] valuePrams = new Object[] { Convert.ToInt32(mahd) };
            if (connectDB.ExecuteNonProc(nameProc, nameParams, valuePrams) <1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        internal int getMaloaiFromMaTK(int matk)
        {
            string query = "select a.iMaLoaiTK from tblTaiKhoan a where a.iMaTK=" + matk + "";
            Object result = connectDB.ExecuteScalar(query);
            return Convert.ToInt32(result);
        }

        internal bool ThanhToan(string text)
        {
            //create proc sp_thanhtoan_HoaDonBan @mahd int
            //as
            //begin
            //update tblHoaDonBan
            //set iTrangThai = 1
            //where iMaHDB = @mahd
            //end
            string nameProc = "sp_thanhtoan_HoaDonBan";
            string[] nameParams = new string[] { "@mahd" };
            Object[] valuePrams = new Object[] { Convert.ToInt32(text) };
            if (connectDB.ExecuteNonProc(nameProc, nameParams, valuePrams) != 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
