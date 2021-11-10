using PMQLBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PMQLBanHang.BUS
{
    public class NhanVienBUS
    {
        ConnectDB connectDB = new ConnectDB();
        internal DataTable getListNV()
        {
            //string[] nameParams = new string[] { "@matk" };
            //Object[] valueParams = new Object[] { matk };
            DataTable data = connectDB.ExecuteProc("sp_ds_NhanVien");
            //return changeGender(data);
            return data;
        }
        internal DataTable getAllNhanVienNotTaiKhoan()
        {
            DataTable data = connectDB.ExecuteQuery("select * from tblNhanVien where trangthai=0 or trangthai is null");
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

        public bool addNhanVien(NhanVien nhanvien)
        {
            //create proc sp_them_NhanVien @ten nvarchar(100),@gioitinh int, @quequan nvarchar(100),@ngaysinh date, @ngayvaolam date,@sdt varchar(20)
            //as
            //begin
            //    insert into tblNhanVien values(@ten, @gioitinh, @quequan, @ngaysinh, @ngayvaolam, @sdt,null)
            //end
            //go
            string nameProc = "sp_them_NhanVien";
            string[] nameParams = new string[] {"@ten", "@gioitinh", "@quequan", "@ngaysinh", "@ngayvaolam", "@sdt" };
            Object[] valuePrams = new Object[] { nhanvien.STenNV,nhanvien.IGioiTinh,nhanvien.SQueQuan,nhanvien.DNgaySinh,nhanvien.DNgayVaoLam,nhanvien.SSoDienThoai};
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
            string nameProc = "sp_capnhat_NhanVien";
            string[] nameParams = new string[] {"@manv", "@ten", "@gioitinh", "@diachi", "@ngaysinh", "@ngaylam", "@sdt" };
            Object[] valuePrams = new Object[] { nhanvien.IMaNV,nhanvien.STenNV, nhanvien.IGioiTinh, nhanvien.SQueQuan, nhanvien.DNgaySinh, nhanvien.DNgayVaoLam, nhanvien.SSoDienThoai };
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
            string nameProc = "sp_xoa_NhanVien";
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
            DataTable data = connectDB.ExecuteProc("sp_timkiem_NhanVien", nameParams, valueParams);
            return data;
        }
    }
}
