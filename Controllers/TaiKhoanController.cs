using PMQLBanHang.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMQLBanHang.Controllers
{
    class TaiKhoanController
    {
        ConnectDB connectDB = new ConnectDB();
        internal object showNhanVien_TrangThai(int matk)
        {
            string[] nameParams = new string[] { "@matk" };
            Object[] valueParams = new Object[] { matk };
            DataTable data = connectDB.ExecuteProc("sp_show_NhanVien_trangthai", nameParams, valueParams);
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

        internal int getMaxMaTK()
        {
            string query = "select max(a.iMaTK) from tblTaiKhoan a";
            return Convert.ToInt32(connectDB.ExecuteScalar(query));
        }

        internal string getChucVuFromMaNV(int manv)
        {
            string result = "";
            string query = "select a.sChucVu from tblNhanVien a where a.iMaNV ="+manv;
            switch (connectDB.ExecuteScalar(query).ToString())
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
            //create proc sp_add_Account_and_changeStatus @tendangnhap nvarchar(50),@matkhau nvarchar(50),@maloaitk int, @manv int
            //as
            // begin

            //    insert into tblTaiKhoan values(@tendangnhap, @matkhau, @maloaitk, @manv);
            //            update tblNhanVien

            //    set trangthai = 1

            //    where iMaNV = @manv
            // end
            #endregion
            string nameProc = "sp_add_Account_and_changeStatus";// ko dùng mã nv vì tự tăng
            string[] nameParams = new string[] { "@tendangnhap", "@matkhau", "@maloaitk","@manv" };
            Object[] valueParams = new Object[] { x.Tendangnhap,x.Matkhau,x.Maloaitk,x.Manv };
            //MessageBox.Show(x.Tendangnhap+ x.Matkhau+ x.Maloaitk+ x.Manv);
            return connectDB.ExecuteNonProc(nameProc, nameParams, valueParams); 
        }

        internal int deleteAccount(TaiKhoan taikhoan)
        {
            #region    //create proc sp_delete_Account_and_changeStatus @matk int, @manv int
            //    as
            //     begin

            //        delete
            //        from tblTaiKhoan
            //        where iMaTK = @matk

            //        update tblNhanVien

            //        set trangthai = 0

            //        where iMaNV = @manv
            //     end
            #endregion
            string nameProc = "sp_delete_Account_and_changeStatus";
            string[] nameParams = new string[] { "@matk", "@manv" };
            Object[] valueParams = new Object[] { taikhoan.Matk, taikhoan.Manv};
            return connectDB.ExecuteNonProc(nameProc, nameParams, valueParams);
        }

        internal int updateAccount(TaiKhoan taikhoan)
        {
            #region  //create proc sp_update_Account @matk int, @tendangnhap varchar(50),@matkhau varchar(50)
            //as
            // begin


            //    update tblTaiKhoan

            //    set STenDangNhap = @tendangnhap, sMatKhau = @matkhau

            //    where iMaTK = @matk
            // end
            #endregion
            string nameProc = "sp_update_Account";
            string[] nameParams = new string[] { "@matk", "@tendangnhap", "@matkhau" };
            Object[] valueParams = new Object[] { taikhoan.Matk, taikhoan.Tendangnhap,taikhoan.Matkhau };
            return connectDB.ExecuteNonProc(nameProc, nameParams, valueParams);
        }
    }
}
