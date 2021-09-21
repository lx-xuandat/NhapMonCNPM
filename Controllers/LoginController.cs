using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBanHang.Controllers
{
    class LoginController
    {
        public DataTable checklogin(string tendangnhap, string matkhau)
        {
            //create proc sp_checklogin @tendangnhap nvarchar(50),@matkhau nvarchar(50)
            //as
            //begin

            //    select* from tblTaiKhoan
            //   where STenDangNhap = @tendangnhap and sMatKhau = @matkhau
            //end
            //go
            string nameproc = "sp_checklogin";
            string[] paramName = new string[] { "@tendangnhap", "@matkhau" };
            Object[] paramValue =new Object[]{ tendangnhap, matkhau };
            ConnectDB connect = new ConnectDB();
            DataTable data =connect.ExecuteProc(nameproc,paramName,paramValue);
            return data;
        }
    }
}
