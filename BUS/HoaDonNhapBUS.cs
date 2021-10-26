using PMQLBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBanHang.BUS
{
    
    class HoaDonNhapBUS
    {
        ConnectDB connectDB = new ConnectDB();
        internal object getListHD()
        {
            DataTable data = connectDB.ExecuteProc("sp_ds_HoaDonNhap");
            //return changeGender(data);
            return data;
        }

        internal List<NhanVien> getListNhanVienKho()
        {
            DataTable data = connectDB.ExecuteProc("sp_ds_NhanVienKho");
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

        internal int getMaxMHDN()
        {
            int result=-1;
            string query = "SELECT IDENT_CURRENT('tblHoaDonNhap')";
            Object data = connectDB.ExecuteScalar(query);
            if (!data.ToString().Equals(""))
            {
                result = Convert.ToInt32(data);
               // Console.WriteLine("Data :"+data); 
            }
            return result;
        }

        internal bool addHoaDonNhap(HoaDonNhap x)
        {
            //create proc sp_them_HoaDonNhap @mahd int, @manv int, @ngaynhap datetime,@tongtien float, @trangthai int
            //as
            //begin
            //    insert into tblHoaDonNhap values(@manv, @ngaynhap, @tongtien, @trangthai);
            //end
            string nameProc = "sp_them_HoaDonNhap";
            string[] nameParams = new string[] { "@mahd", "@manv", "@ngaynhap", "@tongtien", "@trangthai" };
            Object[] valuePrams = new Object[] { x.Mahd, x.Manv,x.Ngaylap,x.Tongtien,x.Trangthai};
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
            string query = "select a.iMaHDN as N'Mã HĐ',a.iMaSP as N'Mã SP', a.fGiaNhap as N'Gía Nhập',"
                + " a.iSoLuongNhap as N'Số Lượng Nhâp' from tblChiTietHDN a where a.iMaHDN ="+mahd;
            return connectDB.ExecuteQuery(query);
        }

        internal bool updateHoaDonNhap(HoaDonNhap x)
        {
            //create proc sp_capnhat_HoaDonNhap @mahd int, @manv int, @ngaynhap datetime,@tongtien float, @trangthai int
            //as
            //begin
            //    update tblHoaDonNhap
            //    set iMaNV = @manv, dNgayLap = @ngaynhap, fTongTien = @tongtien, iTrangThai = @trangthai
            //    where iMaHDN = @mahd
            //end
            string nameProc = "sp_capnhat_HoaDonNhap";
            string[] nameParams = new string[] { "@mahd", "@manv", "@ngaynhap", "@tongtien", "@trangthai" };
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

        internal bool checkExistsCTHD(string mahd)
        {
            string query = "select * from tblChiTietHDN where iMaHDN=" + mahd;
            Object data = connectDB.ExecuteScalar(query);
            if (data == null)
            {
                return false;
            } else
            {
                return true;
            }
        }

        internal bool deleteTwoTable(string mahd)
        {
            //create proc sp_delete_HDN_1 @mahd int
            //as
            //    begin

            //    delete tblHoaDonNhap

            //    where iMaHDN = @mahd

            //    end
            string nameProc = "sp_delete_HDN_1";
            string[] nameParams = new string[] { "@mahd" };
            Object[] valuePrams = new Object[] { Convert.ToInt32(mahd) };
            if (connectDB.ExecuteNonProc(nameProc, nameParams, valuePrams) != 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        internal bool deleteOneTable(string mahd)
        {
            //create proc sp_delete_HDN_2 @mahd int
            //as
            //    begin
            //    delete tblChiTietHDN
            //    where iMaHDN = @mahd
            //    delete tblHoaDonNhap
            //    where iMaHDN = @mahd
            //    end
            string nameProc = "sp_delete_HDN_2";
            string[] nameParams = new string[] { "@mahd" };
            Object[] valuePrams = new Object[] { Convert.ToInt32(mahd) };
            if (connectDB.ExecuteNonProc(nameProc, nameParams, valuePrams) !=1)
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
            string query = "select a.iMaLoaiTK from tblTaiKhoan a where a.iMaTK="+matk+"";
            Object result = connectDB.ExecuteScalar(query);
            return Convert.ToInt32(result);
        }

        internal bool ThanhToan(string text)
        {
            //create proc sp_thanhtoan_HD @mahd int
            //as
            //begin
            //update tblHoaDonNhap
            //set iTrangThai = 1
            //where iMaHDN = @mahd
            //end
            string nameProc = "sp_thanhtoan_HD";
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
