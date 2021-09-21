using PMQLBanHang.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PMQLBanHang.Controllers
{
    class NhanVienController
    {
        ConnectDB connectDB = new ConnectDB();
        internal DataTable getListNV(int matk)
        {
            string[] nameParams = new string[] { "@matk" };
            Object[] valueParams = new Object[] { matk };
            DataTable data = connectDB.ExecuteProc("sp_showNV_by_Chucvu", nameParams, valueParams);
            //return changeGender(data);
            return data;
        }

        private DataTable changeGender(DataTable data)
        {
            for (int i=0;i<data.Rows.Count;i++)
            {
                DataRow row = data.Rows[i];
                if (row["Giới Tính"].ToString().Equals("1"))
                {
                    data.Rows[i]["Giới Tính"] = "Nam";
                }
                else
                {
                    data.Rows[i]["Giới Tính"] = "Nữ";
                }
            }
            return data;
        }

        internal int getMaxMaNV()
        {
            int result =-1;
            string query = "select MAX(iMaNV) from tblNhanVien";
            result = Convert.ToInt32(connectDB.ExecuteScalar(query)) ;
            return result;
        }

        internal List<string> getListChucVu_by_MaTK(int matk)
        {
            List<string> result = new List<string>();
            string[] nameParams = new string[] { "@matk" };
            Object[] valueParams = new Object[] { matk };
            DataTable data =connectDB.ExecuteProc("sp_getComboBox_ChucVu_Nv", nameParams, valueParams);
            foreach (DataRow row in data.Rows )
            {
                string s = row["sTenLoaiTK"].ToString();
                result.Add(s);
            }
            return result;
        }

        internal bool addNhanVien(NhanVien nhanvien)
        {
            //create proc sp_addNhanVien @ten nvarchar(100),@gioitinh int, @diachi nvarchar(100),@ngaysinh date, @ngaylam date,@sdt varchar(20),@chucvu nvarchar(50)
            //as
            //begin

            //    insert into tblNhanVien values(@ten, @gioitinh, @diachi, @ngaysinh, @ngaylam, @sdt, @chucvu)
            //end
            string nameProc = "sp_addNhanVien";
            string[] nameParams = new string[] {"@ten", "@gioitinh", "@diachi", "@ngaysinh", "@ngaylam", "@sdt", "@chucvu" };
            Object[] valuePrams = new Object[] { nhanvien.STenNV,nhanvien.IGioiTinh,nhanvien.SQueQuan,nhanvien.DNgaySinh,nhanvien.DNgayVaoLam,nhanvien.SSoDienThoai,nhanvien.SChucVu};
            if (connectDB.ExecuteNonProc(nameProc, nameParams, valuePrams) != 1)
            {
                return false;
            } else
            {
                return true;
            }
            
        }

        internal bool updateNhanVien(NhanVien nhanvien)
        {
            string nameProc = "sp_updateNhanVien";
            string[] nameParams = new string[] {"@manv", "@ten", "@gioitinh", "@diachi", "@ngaysinh", "@ngaylam", "@sdt", "@chucvu" };
            Object[] valuePrams = new Object[] { nhanvien.IMaNV,nhanvien.STenNV, nhanvien.IGioiTinh, nhanvien.SQueQuan, nhanvien.DNgaySinh, nhanvien.DNgayVaoLam, nhanvien.SSoDienThoai, nhanvien.SChucVu };
            if (connectDB.ExecuteNonProc(nameProc, nameParams, valuePrams) != 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        internal bool deleteNhanVien(NhanVien nhanvien)
        {
            string nameProc = "sp_deleteNhanVien";
            string[] nameParams = new string[] { "@manv" };
            Object[] valuePrams = new Object[] { nhanvien.IMaNV };
            if (connectDB.ExecuteNonProc(nameProc, nameParams, valuePrams) != 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        internal object getListNVSearch(string key, int matk)
        {
            string[] nameParams = new string[] { "@matk","@key" };
            Object[] valueParams = new Object[] { matk,key};
            DataTable data = connectDB.ExecuteProc("sp_Search_by_Chucvu", nameParams, valueParams);
            return data;
        }
    }
}
