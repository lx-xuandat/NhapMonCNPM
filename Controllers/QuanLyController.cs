using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBanHang.Controllers
{
    class QuanLyController
    {
        public string getUserName(int matk)
        {
            ConnectDB connectDB = new ConnectDB();
            string query = "select sTenNV from tblNhanVien a, tblTaiKhoan b where a.iMaNV = b.iMaNV and b.iMaTK = "+matk+"";
            return connectDB.ExecuteScalar(query).ToString();
        }
    }
}
