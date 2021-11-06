using PMQLBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMQLBanHang.BUS
{
    class TaiKhoanBUS
    {
        ConnectDB connectDB = new ConnectDB();
        internal object showNhanVien_TrangThai(int matk)
        {
            //string[] nameParams = new string[] { "@matk" };
            //Object[] valueParams = new Object[] { matk };
            DataTable data = connectDB.ExecuteProc("sp_ds_TaiKhoan");
            //return changeGender(data);
            return data;
        }

        internal TaiKhoan getAccountByMaNV(int manv)
        {
            string[] nameParams = new string[] { "@manv" };
            Object[] valueParams = new Object[] { manv };
            DataTable data = connectDB.ExecuteProc("sp_show_acc_by_manv", nameParams, valueParams);
            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan.Manv = Convert.ToInt32(data.Rows[0]["iMaNV"]);
            taiKhoan.Matk = Convert.ToInt32(data.Rows[0]["iMaTK"]);
            taiKhoan.Tendangnhap = data.Rows[0]["sTenDangNhap"]+"";
            taiKhoan.Matkhau = data.Rows[0]["sMatKhau"] + "";
            taiKhoan.Maloaitk = Convert.ToInt32(data.Rows[0]["iMaLoaiTK"]);
            return taiKhoan;
        }


        public DataTable getAllChucVu()
        {
            string query = "select * from tblLoaiTaiKhoan where iMaLoaiTK!=1";
            return connectDB.ExecuteQuery(query);
        }
        internal string getChucVuFromMaNV(int manv)
        {
            //create proc sp_xem_ChucVu_tu_MaNV @manv int
            //as begin
            //select a.sTenLoaiTK from tblLoaiTaiKhoan a, tblNhanVien b, tblTaiKhoan c
            //where b.iMaNV = c.iMaNV and c.iMaLoaiTK = a.iMaLoaiTK and b.iMaNV = @manv
            //end
            string result = "";
            string[] nameParams = new string[] { "@manv"};
            Object[] valueParams = new Object[] { manv };
            DataTable resultChucVu =  connectDB.ExecuteProc("sp_xem_ChucVu_tu_MaNV", nameParams, valueParams);
            switch (resultChucVu.Rows[0][0].ToString())
            {
                case "chusohuu": result = "Chủ Sở Hữu"; break;
                case "nhanvienkho": result = "Nhân Viên Kho"; break;
                case "nhanvienbanhang": result = "Nhân Viên Bán Hàng"; break;
                case "quanly": result = "Quản Lý"; break;
                default: result = "chưa có chức vụ"; break;
            }
            return result;
        }

        internal int addAccount(TaiKhoan x)
        {
            #region
            //create proc sp_them_TaiKhoan @tendangnhap nvarchar(50),@matkhau nvarchar(50),@maloaitk int, @manv int
            //as
            //    begin
            //    insert into tblTaiKhoan values(@tendangnhap, @matkhau, @maloaitk, @manv);
            //            update tblNhanVien
            //    set trangthai = 1
            //    where iMaNV = @manv
            //    end
            //    go
            #endregion
            string nameProc = "sp_them_TaiKhoan";// ko dùng mã nv vì tự tăng
            string[] nameParams = new string[] { "@tendangnhap", "@matkhau", "@maloaitk","@manv" };
            Object[] valueParams = new Object[] { x.Tendangnhap,x.Matkhau,x.Maloaitk,x.Manv };
            return connectDB.ExecuteNonProc(nameProc, nameParams, valueParams); 
        }

        internal int deleteAccount(TaiKhoan taikhoan)
        {
            #region   
            //create proc sp_xoa_TaiKhoan @matk int
            //as
            // begin
            //    declare @manv int
            //    set @manv = (select iMaNV from tblTaiKhoan where iMaTK = @matk)
	           // delete
            //    from tblTaiKhoan
            //    where iMaTK = @matk
            //    update tblNhanVien
            //    set trangthai = 0
            //    where iMaNV = @manv
            // end
            #endregion
            string nameProc = "sp_xoa_TaiKhoan";
            string[] nameParams = new string[] { "@matk"};
            Object[] valueParams = new Object[] { taikhoan.Matk};
            return connectDB.ExecuteNonProc(nameProc, nameParams, valueParams);
        }

        internal int updateAccount(TaiKhoan taikhoan)
        {
            #region  
            //create proc sp_capnhat_TaiKhoan @matk int, @tendangnhap varchar(50),@matkhau varchar(50), @maloaitk int
            //as
            // begin
            //    update tblTaiKhoan
            //    set STenDangNhap = @tendangnhap, sMatKhau = @matkhau, iMaloaiTk = @maloaitk
            //    where iMaTK = @matk
            // end
            #endregion
            string nameProc = "sp_capnhat_TaiKhoan";
            string[] nameParams = new string[] { "@matk", "@tendangnhap", "@matkhau", "@maloaitk" };
            Object[] valueParams = new Object[] { taikhoan.Matk, taikhoan.Tendangnhap,taikhoan.Matkhau,taikhoan.Maloaitk };
            return connectDB.ExecuteNonProc(nameProc, nameParams, valueParams);
        }
    }
}
