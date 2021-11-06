using PMQLBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBanHang.BUS
{
    class SanPhamBUS
    {
        ConnectDB connectDB = new ConnectDB();

        internal object getListSP()
        {
            DataTable data = connectDB.ExecuteProc("sp_ds_SanPham");
            //return changeGender(data);
            return data;
        }

        internal List<LoaiSanPham> getListLoaiSP()
        {
            List<LoaiSanPham> List = new List<LoaiSanPham>();
            string query = "select * from tblLoaiSanPham";
            DataTable data = connectDB.ExecuteQuery(query);
            for (int i=0; i<data.Rows.Count ;i++)
            {
                LoaiSanPham loaiSanPham = new LoaiSanPham();
                loaiSanPham.Maloaisp = Convert.ToInt32(data.Rows[i]["iMaLoaiSP"]);
                loaiSanPham.Tenloaisp = data.Rows[i]["sTenLoaiSP"].ToString();
                List.Add(loaiSanPham);
                Console.WriteLine(loaiSanPham.Maloaisp + "");
            }
            return List; 
        }

        internal List<NCC> getListNCC()
        {
            List<NCC> List = new List<NCC>();
            string query = "select * from tblNhaCC";
            DataTable data = connectDB.ExecuteQuery(query);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                NCC nCC = new NCC();
                nCC.Mancc = Convert.ToInt32(data.Rows[i]["iMaNCC"]);
                nCC.Tenncc = data.Rows[i]["sTenNCC"].ToString();
                nCC.Diachi = data.Rows[i]["sDiaChi"].ToString();
                nCC.Sdt = data.Rows[i]["sSdt"].ToString();
                List.Add(nCC);
                
            }
            return List;
        }

        internal bool updateSanPham(SanPham s)
        {
            #region  
            //create proc sp_capnhat_SanPham @masp int, @tensp nvarchar(100),@maloai int, @mancc int, @gia float, @soluong int, @dvt nvarchar(10),
            //@nsx datetime, @hsd datetime,@hinhanh nvarchar(100)
            //as
            //    begin
            //        update tblSanPham
            //        set sTenSP = @tensp, iMaLoaiSP = @maloai, iMaNCC = @mancc, fGia = @gia, iSoLuong = @soluong, sDonViTinh = @dvt, dNgaySX = @nsx, dHanSD = @hsd, sHinhAnh = @hinhanh
            //        where iMaSP = @masp
            //    end
            //    go
            #endregion
            string nameProc = "sp_capnhat_SanPham";
            string[] nameParams = new string[] { "@masp", "@tensp", "@maloai", "@mancc", "@gia", "@soluong", "@dvt", "@nsx", "@hsd", "@hinhanh" };
            Object[] valuePrams = new Object[] { s.Masp,s.Tensp,s.Maloaisp,s.Mancc,s.Gia,s.Soluong,s.Donvitinh,s.Nsx,s.Hsd,s.Hinhanh };
            if (connectDB.ExecuteNonProc(nameProc, nameParams, valuePrams) != 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        internal bool addSanPham(SanPham s)
        {
            #region  
            //create proc sp_them_SanPham @masp int, @tensp nvarchar(100),@maloai int, @mancc int, @gia float, @soluong int, @dvt nvarchar(10),
            //@nsx datetime, @hsd datetime,@hinhanh nvarchar(100)
            //as
            //    begin
            //            insert into tblSanPham values(@tensp, @maloai, @mancc, @gia, @soluong, @dvt, @nsx, @hsd, @hinhanh)
            //    end
            //    go
            #endregion
            string nameProc = "sp_them_SanPham";
            string[] nameParams = new string[] { "@masp", "@tensp", "@maloai", "@mancc", "@gia", "@soluong", "@dvt", "@nsx", "@hsd", "@hinhanh" };
            Object[] valuePrams = new Object[] { s.Masp, s.Tensp, s.Maloaisp, s.Mancc, s.Gia, s.Soluong, s.Donvitinh, s.Nsx, s.Hsd, s.Hinhanh };
            if (connectDB.ExecuteNonProc(nameProc, nameParams, valuePrams) != 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        internal bool deleteSanPham(SanPham x)
        {
            //create proc sp_xoa_SanPham @masp int
            //as
            //    begin
            //        delete tblSanPham
            //        where iMaSP = @masp
            //    end
            //go
            string nameProc = "sp_xoa_SanPham";
            string[] nameParams = new string[] { "@masp"};
            Object[] valuePrams = new Object[] { x.Masp };
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
