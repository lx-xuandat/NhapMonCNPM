using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBanHang.BUS
{
    class QuanLyBUS
    {
        ConnectDB connectDB = new ConnectDB();
        public string getUserName(int matk)
        {
            string query = "select sTenNV from tblNhanVien a, tblTaiKhoan b where a.iMaNV = b.iMaNV and b.iMaTK = "+matk+"";
            return connectDB.ExecuteScalar(query).ToString();
        }
       
    }
}
