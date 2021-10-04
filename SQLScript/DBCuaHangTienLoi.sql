create database QuanLyCHTienLoi
use QuanLyCHTienLoi

/*CREATE TABLE NHANVIEN*/
/*Nhân viên : mã nv, tên nv, giới tính, quê quán, ngày sinh, ngày vào làm,sdt chức vụ*/
create table tblNhanVien(
	iMaNV int identity(1,1) primary key(iMaNV),
	sTenNV nvarchar(70),
	iGioiTinh int,
	sQueQuan nvarchar(255),
	dNgaySinh date,
	dNgayVaoLam date,
	sSDT varchar(15),
	trangthai bit null
);

--drop table tblNhanVien
-- CREATE TABLE CATEGORY ACCOUNT
/*+ Loại tài khoản: mã loại tk, tên loạitk.*/
create table tblLoaiTaiKhoan(
	iMaLoaiTK int identity(1,1) primary key (iMaLoaiTK),
	sTenLoaiTK nvarchar(100)
) 

-- CREATE TABLE ACCOUNT
/* Tài khoản:mã tk, tên đăng nhập, mật khẩu, mã loại tk, mã nv.*/
create table tblTaiKhoan(
	iMaTK int identity(1,1) primary key (iMaTK),
	STenDangNhap nvarchar(50),
	sMatKhau varchar(50),
	iMaLoaiTK int,
	iMaNV int
)
-- khóa ngoại cho bảng tài khoản
alter table tblTaiKhoan 
 add constraint fk_TK_tblLoaiTK foreign key (iMaLoaiTK) references tblLoaiTaiKhoan(iMaLoaiTK)
 alter table tblTaiKhoan 
 add constraint fk_TK_tblNhanVien foreign key (iMaNV) references tblNhanVien(iMaNV)

 -- CREATE TABLE NHACUNGCAP
 /*Nhà cung cấp: mã ncc, tên ncc, địa chỉ, sdt*/
 create table tblNhaCC(
	iMaNCC int identity(1,1) primary key (iMaNCC),
	sTenNCC nvarchar(255),
	sDiaChi nvarchar(255),
	sSdt varchar(20)
 )
-- CREATE TABLE LOAISANPHAM
/*loại sản phẩm : mã loại sp, tên loại sản phẩm.*/
create table tblLoaiSanPham(
   iMaLoaiSP int identity(1,1) primary key(iMaLoaiSP),
   sTenLoaiSP nvarchar(100)
)
--CREATE TABLE SANPHAM
/*sản phẩm: mã sp,tên sp,mã loại sp,mã ncc, giá, số lượng, đơn vị tính, ngày sản xuất, hạn sử dụng.*/
create table tblSanPham (
  iMaSP int identity(1,1) primary key(iMaSP),
  sTenSP nvarchar(100),
  iMaLoaiSP int,
  iMaNCC int,
  fGia float,
  iSoLuong int,
  sDonViTinh nvarchar(10),
  dNgaySX date,
  dHanSD date,
  sHinhAnh nvarchar(50) null
)  
/* tạo khóa ngoại bảng sản phẩm */
alter table tblSanPham
add constraint fk_SP_LoaiSP foreign key(iMaLoaiSP) references tblLoaiSanPham(iMaLoaiSP)
alter table tblSanPham
add constraint fk_SP_NCC foreign key(iMaNCC) references tblNhaCC(iMaNCC)

-- CREATE TABLE HÓA ĐƠN BÁN HÀNG
/*Hóa đơn bán hàng: mã hd,mã nv bán, ngày lập, tổng tiền*/
create table tblHoaDonBan(
  iMaHDB int identity(1,1) primary key(iMaHDB),
  iMaNV  int,
  dNgayLap date,
  fTongTien float,
  iTrangThai int
)

-- CREATE TABLE CHI TIẾT HÓA ĐƠN BÁN HÀNG
/*Chi tiết hóa đơn bán : mã hd, mã sp, số lượng bán*/
create table tblChiTietHDB(
	iMaHDB int,
	iMaSP int primary key (iMaHDB,iMaSP),
	iSoLuongBan int
)
/*tạo liên kết khóa ngoại cho tbl chi tiết đơn mua hàng*/
 alter table tblChiTietHDB
 add constraint fk_CTHDB_HDB foreign key(iMaHDB) references tblHoaDonBan(iMaHDB)
 alter table tblChiTietHDB
 add constraint fk_CTHDB_SP foreign key(iMaSP) references tblSanPham(iMaSP)
 /*tạo liên kết khóa ngoại cho tbl Hóa Đơn Bán*/
 alter table tblHoaDonBan
 add constraint fk_HDB_NV foreign key(iMaNV) references tblNhanVien(iMaNV)

 -- CREATE TABLE HÓA ĐƠN NHẬP HÀNG
/*Hóa đơn bán hàng: mã hd,mã nv nhập, ngày lập,tổng tiền nhập*/
create table tblHoaDonNhap(
  iMaHDN int identity(1,1) primary key(iMaHDN),
  iMaNV  int,
  dNgayLap date,
  fTongTien float,
  iTrangThai bit null
)

-- CREATE TABLE CHI TIẾT HÓA ĐƠN NHẬP HÀNG
/*Chi tiết hóa đơn Nhập : mã hd, mã sp, số lượng nhập*/
create table tblChiTietHDN(
	iMaHDN int,
	iMaSP int primary key (iMaHDN,iMaSP),
	iSoLuongNhap int,
	fGiaNhap float null
)
/*tạo liên kết khóa ngoại cho tbl chi tiết đơn nhập hàng*/
 alter table tblChiTietHDN
 add constraint fk_CTHDN_HDN foreign key(iMaHDN) references tblHoaDonNhap(iMaHDN)
 alter table tblChiTietHDN
 add constraint fk_CTHDN_SP foreign key(iMaSP) references tblSanPham(iMaSP)
 /*tạo liên kết khóa ngoại cho tbl Hóa Đơn Nhập*/
 alter table tblHoaDonNhap
 add constraint fk_HDN_NV foreign key(iMaNV) references tblNhanVien(iMaNV)
 -- thêm thông tin
 insert into tblLoaiTaiKhoan
 values('chusohuu');
  insert into tblLoaiTaiKhoan
 values('quanly');
  insert into tblLoaiTaiKhoan
 values('nhanvienbanhang');
   insert into tblLoaiTaiKhoan
 values('nhanvienkho');


  -- thêm nhân viên
 insert into tblNhanVien values(N'Nguyễn Đình Phong',1,N'Hà Nội','2000-06-26','2020-10-19','0352337342',0);
 -- thêm tài khoản
 insert into tblTaiKhoan values('dinhphong','123',2,1);



-- thêm NCC 
insert into tblNhaCC values (N'VinCommerce',N'20 Lý Thường Kiệt, Hoàn Kiếm, Hà Nội','04.3934 7628')
insert into tblNhaCC values (N'KFC',N'Số 1, Lô 13B, KĐT Mới Trung Yên,  Quận Cầu Giấy, Hà Nội','04.3935 6578')
insert into tblNhaCC values (N'Vifoodshop',N'164 Vương Thừa Vũ, Thanh Xuân, Hà Nội','0342.387.630')

insert into tblNhaCC values (N'Công ty cổ phần Bia - Rượu - Nước giải khát Hà Nội',N'83 Hoàng Hoa Thám, Ba Đình, Hà Nội.','0243 845 843')
-- thêm Loai SanPham
insert into tblLoaiSanPham values(N'Rau-Củ-Qủa') -- VinCommerce /1 
insert into tblLoaiSanPham values(N'Bánh Mì')    -- VinCommerce /2
insert into tblLoaiSanPham values(N'Sữa')		 -- VinCommerce /3
insert into tblLoaiSanPham values(N'Bim Bim')    -- KFC /4
insert into tblLoaiSanPham values(N'Mì Tôm')     -- KFC /5
insert into tblLoaiSanPham values(N'Nước Ngọt')  --  Nước giải khát Hà Nội /6
insert into tblLoaiSanPham values(N'Rượu')       --  Nước giải khát Hà Nội /7
insert into tblLoaiSanPham values(N'Bia')        --  Nước giải khát Hà Nội /8
insert into tblLoaiSanPham values(N'Chocolate')  -- Vifoodshop /9
insert into tblLoaiSanPham values(N'Xà Phòng')   -- -- Vifoodshop /10
go
-- thêm SanPham
-- Rau củ quả
insert into tblSanPham values(N'Rau Cải Ngồng',1,1,10000,50,'VND','2021-09-23','2021-10-23',null)
insert into tblSanPham values(N'Táo',1,1,20000,50,'KG','2021-09-23','2021-10-23',null)
-- Bánh Mì
insert into tblSanPham values(N'Bánh Mì Cháy',2,1,20000,50,'Cái','2021-09-23','2021-10-23',null)
insert into tblSanPham values(N'Bánh Mì Ruốc',2,1,20000,50,'Cái','2021-09-23','2021-10-23',null)
insert into tblSanPham values(N'Bánh Mì Bơ',2,1,20000,50,'Cái','2021-09-23','2021-10-23',null)
-- Sữa
insert into tblSanPham values(N'Sữa Bò',3,1,30000,50,N'Hộp','2021-09-23','2021-10-23',null)
insert into tblSanPham values(N'Sữa Ông Thọ',3,1,30000,50,N'Hộp','2021-09-23','2021-10-23',null)
insert into tblSanPham values(N'Sữa MiLo',3,1,20000,50,N'Hộp','2021-09-23','2021-10-23',null)
-- Bim Bim
insert into tblSanPham values(N'Bim Bim khoai Tây',4,2,10000,50,'Gói','2021-09-23','2021-10-23',null)
insert into tblSanPham values(N'Bim Bim Chuối',4,2,10000,50,'Gói','2021-09-23','2021-10-23',null)
insert into tblSanPham values(N'Bim Bim Cà Chua',4,2,10000,50,'Gói','2021-09-23','2021-10-23',null)
-- mÌ tÔM
insert into tblSanPham values(N'Mì Tôm',5,2,5000,50,'Gói','2021-09-23','2021-10-23',null)
insert into tblSanPham values(N'Bim Bim Cà Chua',5,2,5000,50,'Gói','2021-09-23','2021-10-23',null)
-- Nước Ngọt
insert into tblSanPham values(N'CoCa',6,4,10000,50,'Chai','2021-09-23','2021-10-23',null)
insert into tblSanPham values(N'FanTa',6,4,10000,50,'Chai','2021-09-23','2021-10-23',null)
insert into tblSanPham values(N'Sprite',6,4,10000,50,'Chai','2021-09-23','2021-10-23',null)
-- -- Rượu
insert into tblSanPham values(N'Vodka 500ml',7,4,80000,50,'Chai','2021-09-23','2021-10-23',null)
insert into tblSanPham values(N'Men 500ml',7,4,80000,50,'Chai','2021-09-23','2021-10-23',null)
insert into tblSanPham values(N'SoJu 100 ml',7,4,50000,50,'Chai','2021-09-23','2021-10-23',null)
-- Bia 
insert into tblSanPham values(N'Bia Hà Nội',8,4,20000,50,'Chai','2021-09-23','2021-10-23',null)
insert into tblSanPham values(N'Bia Sài Gòn',8,4,20000,50,'Chai','2021-09-23','2021-10-23',null)
insert into tblSanPham values(N'Bia Haniken',8,4,20000,50,'Chai','2021-09-23','2021-10-23',null)
-- Chocolate
insert into tblSanPham values(N'KitKat',9,3,10000,50,'Thanh','2021-09-23','2021-10-23',null)
insert into tblSanPham values(N'MentyKit',9,3,50000,50,'Hộp','2021-09-23','2021-10-23',null)
-- Xà Phong
insert into tblSanPham values(N'O Mô',10,3,20000,50,'Gói','2021-09-23','2021-10-23',null)
insert into tblSanPham values(N'ABa',10,3,50000,50,'Gói','2021-09-23','2021-10-23',null)


-- procedure kiểm tra tài khoản bằng tendangnhap và matkhau trả về 1 tài khoản duy nhất or null
go
create proc sp_checklogin @tendangnhap nvarchar(50),@matkhau nvarchar(50)
as
begin
	select * from tblTaiKhoan
	where STenDangNhap = @tendangnhap and sMatKhau = @matkhau
end
go

-- lấy tên nhân viên từ mã nhân viên
select sTenNV from tblNhanVien where iMaNV = 1

go
-- procedure thêm nhân viên 

create proc sp_them_NhanVien @ten nvarchar(100),@gioitinh int,@quequan nvarchar(100),@ngaysinh date,@ngayvaolam date,@sdt varchar(20)
as 
begin 
	insert into tblNhanVien values(@ten,@gioitinh,@quequan,@ngaysinh,@ngayvaolam,@sdt,null)
end
go
-- proc xem nhân viên
go
create proc sp_ds_NhanVien
as
begin 
	select a.iMaNV as N'Mã NV',a.sTenNV as N'Họ Tên',
		case (a.iGioiTinh )
			when 1 then N'Nam'
			when 0 then N'Nữ'
		end as N'Giới Tính',
		a.sQueQuan as N'Quê Quán', a.dNgaySinh as N'Ngày Sinh',a.dNgayVaoLam as N'Ngày vào làm',
		 a.sSDT as N'Số ĐT',trangthai as N'Trạng Thái'
		 from tblNhanVien a;
end
exec sp_ds_NhanVien
-- lấy ra danh sách chức vụ theo mã tài khoản
go
create proc sp_getComboBox_ChucVu_Nv @matk int
as
begin
	declare @maloaitk varchar(10);
	set @maloaitk = (select a.iMaLoaiTK from tblTaiKhoan a where a.iMaTK = @matk);
	if @maloaitk =1
		select a.sTenLoaiTK from tblLoaiTaiKhoan a 
	else if @maloaitk = 2
		select a.sTenLoaiTK from tblLoaiTaiKhoan a where a.iMaLoaiTK !=1 and a.iMaLoaiTK !=2
end

exec  sp_getComboBox_ChucVu_Nv 1
go
-- tạo proc sửa nhân viên 
create proc sp_capnhat_NhanVien @manv int, @ten nvarchar(100),@gioitinh int,@diachi nvarchar(100),@ngaysinh date,@ngaylam date,@sdt varchar(20)
as 
begin 
	update tblNhanVien
	set sTenNV = @ten,iGioiTinh=@gioitinh,sQueQuan=@diachi,dNgaySinh=@ngaysinh,dNgayVaoLam=@ngaylam,sSDT=@sdt
	where iMaNV=@manv
end
go
-- tạo proc xóa nhân viên theo mã nhân viên
create proc sp_xoa_NhanVien @manv int
as 
begin 
	delete 
	from tblNhanVien
	where iMaNV= @manv
end
go
-- tạo proc search nhân viên theo từ khóa tìm ở mã hoặc tên hoặc địa chỉ
create proc sp_timkiem_NhanVien @matk int, @key nvarchar(50)
as 
begin 
	select a.iMaNV as N'Mã NV',a.sTenNV as N'Họ Tên',
		case (a.iGioiTinh )
			when 1 then N'Nam'
			when 0 then N'Nữ'
		end as N'Giới Tính',
		a.sQueQuan as N'Quê Quán', a.dNgaySinh as N'Ngày Sinh',a.dNgayVaoLam as N'Ngày vào làm',
		 a.sSDT as N'Số ĐT',a.trangthai as N'Trạng Thái'
		 from tblNhanVien a
		 where iMaNV like '%'+@key+'%' or sTenNV like '%'+@key+'%' or sQueQuan like '%'+@key+'%'
end
go
exec sp_timkiem_NhanVien 2,N'p'
-- xem tài khoản và thông thông tin tài khoản cùng nhân viên
select a.iMaNV as N'Mã NV',a.sTenNV N'Tên NV',b.iMaTK as N'Mã TK',b.STenDangNhap as N'Tên Đăng Nhập',b.sMatKhau as 'Mật Khẩu'
 from tblNhanVien a, tblTaiKhoan b,tblLoaiTaiKhoan c
where a.iMaNV = b.iMaNV and b.iMaLoaiTK = c.iMaLoaiTK
-- thêm cột trạng thái cho bảng nhân viên 1- đã có tài khoản - 0 chưa có tài khoản
 select * from tblNhanVien
 update tblNhanVien
	set trangthai = 1
where exists (select* from tblTaiKhoan where tblNhanVien.iMaNV=tblTaiKhoan.iMaNV)

--- tạo proc xem tài khoản từ mã nhân viên
go
create proc sp_xem_NhanVien_by_manv @manv int
as 
begin
	select a.iMaNV,a.iMaTK,a.STenDangNhap,a.sMatKhau,a.iMaLoaiTK 
	from tblTaiKhoan a
	where a.iMaNV = @manv
end
go
exec sp_xem_NhanVien_by_manv 1
go
-- tạo proc thêm tài khoản từ 1 đối tượng tài khoản và thay đổi trạng thái ở bảng nhân viên
create proc sp_them_TaiKhoan @tendangnhap nvarchar(50),@matkhau nvarchar(50),@maloaitk int,@manv int
as
 begin
	insert into tblTaiKhoan values(@tendangnhap,@matkhau,@maloaitk,@manv);
	update tblNhanVien 
	set trangthai=1
	where iMaNV=@manv
 end
 go
 -- tạo proc xóa tài khoản từ mã tài khoản và thay đổi trang thái ở bảng nhân viên
 go
 create proc sp_xoa_TaiKhoan @matk int
as
 begin
	declare @manv int 
	set @manv = (select iMaNV from tblTaiKhoan where iMaTK =@matk)
	delete 
	from tblTaiKhoan
	where iMaTK =@matk
	update tblNhanVien 
	set trangthai=0
	where iMaNV=@manv
 end
 -- tạo proc update tài khoản từ mã tài khoản 
 go
create proc sp_capnhat_TaiKhoan @matk int,@tendangnhap varchar(50),@matkhau varchar(50),@maloaitk int
as
 begin

	update tblTaiKhoan 
	set STenDangNhap=@tendangnhap,sMatKhau =@matkhau,iMaLoaiTK=@maloaitk
	where iMaTK = @matk
 end
 -- tạo proc xem sản phẩm
 go
 create proc sp_ds_SanPham
 as begin 
 select a.iMaSP as N'Mã SP', a.sTenSP as N'Tên SP',a.iMaLoaiSP as N'Mã Loai',a.iMaNCC as 'Mã NCC',
 a.fGia as N'Gía',a.iSoLuong as N'Số Lượng',a.sDonViTinh as N'ĐVT',a.dNgaySX as N'Ngày SX',a.dHanSD as N'Hạn SD',a.sHinhAnh as N'Hình Ảnh'
 from tblSanPham a
 end
 exec sp_ds_SanPham
 -- tạo proc sửa sản phẩm
go
create proc sp_them_SanPham @masp int,@tensp nvarchar(100),@maloai int,@mancc int,@gia float,@soluong int,@dvt nvarchar(10),
@nsx datetime,@hsd datetime,@hinhanh nvarchar(100)
as 
	begin
			insert into tblSanPham values(@tensp,@maloai,@mancc,@gia,@soluong,@dvt,@nsx,@hsd,@hinhanh)
	end
	go
-- tạo proc sửa sản phẩm
go
create proc sp_capnhat_SanPham @masp int,@tensp nvarchar(100),@maloai int,@mancc int,@gia float,@soluong int,@dvt nvarchar(10),
@nsx datetime,@hsd datetime,@hinhanh nvarchar(100)
as 
	begin
		update tblSanPham
		set sTenSP = @tensp,iMaLoaiSP=@maloai,iMaNCC =@mancc,fGia=@gia,iSoLuong=@soluong,sDonViTinh=@dvt,dNgaySX=@nsx,dHanSD=@hsd,sHinhAnh=@hinhanh
		where iMaSP = @masp
	end
	go
-- tạo proc xóa sản phẩm
create proc sp_xoa_SanPham @masp int
as 
	begin
		delete tblSanPham
		where iMaSP = @masp
	end
go

-- tạo proc xem danh sách hóa đơn nhập
go
create proc sp_ds_HoaDonNhap
as begin
	select a.iMaHDN as N'Mã HĐ', a.iMaNV as N'Mã NV',b.sTenNV as N'Tên Nhân Viên', a.dNgayLap N'Ngày Lập',a.fTongTien as N'Tổng Tiền',
	case (a.iTrangThai)
	when 0 then N'Chưa Thanh Toán'
	when 1 then N'Đã Thanh Toán'
	end as N'Trạng Thái' 
	from tblHoaDonNhap a,tblNhanVien b
	where a.iMaNV = b.iMaNV
	end
exec sp_ds_HoaDonNhap
-- proc thêm hóa đơn nhập
go
create proc sp_them_HoaDonNhap @mahd int,@manv int,@ngaynhap datetime,@tongtien float,@trangthai int
as
begin
	insert into tblHoaDonNhap values(@manv,@ngaynhap,@tongtien,@trangthai);
end
-- lấy chi tiết hóa đơn nhập theo mã hóa đơn
select a.iMaHDN as N'Mã HĐ',a.iMaSP as N'Mã SP', a.fGiaNhap as N'Gía Nhập', a.iSoLuongNhap as N'Số Lượng Nhâp'
from tblChiTietHDN a
where a.iMaHDN = 1
-- tao proc sửa hóa đơn nhập
go
create proc sp_capnhat_HoaDonNhap @mahd int,@manv int,@ngaynhap datetime,@tongtien float,@trangthai int
as
begin
	update tblHoaDonNhap 
	set iMaNV = @manv , dNgayLap = @ngaynhap,fTongTien = @tongtien , iTrangThai = @trangthai
	where iMaHDN = @mahd
end 
-- xóa hóa đơn nhập ko có chi tiết hóa đơn
go
create proc sp_xoa_HoaDonNhap_khongco_ChiTietHDN @mahd int
as
	begin
	delete tblHoaDonNhap
	where iMaHDN =@mahd
	end
	go
-- xóa hóa đơn nhập có chi tiết hóa đơn
create proc sp_xoa_HoaDonNhap_co_ChiTietHDN @mahd int
as
	begin
	delete tblChiTietHDN
	where iMaHDN = @mahd
	delete tblHoaDonNhap
	where iMaHDN =@mahd
	end
-- thanh toán hóa đơn
go
create proc sp_thanhtoan_HoaDonNhap @mahd int
as
begin 
update tblHoaDonNhap
set iTrangThai =1
where iMaHDN = @mahd
end

go
create trigger tr_them_SanPhamChiTietHDN_TongTienHDN on tblChiTietHDN after insert,update
as 
begin
	update tblHoaDonNhap 
	set fTongTien = fTongTien + (select SUM(iSoLuongNhap * fGiaNhap) from inserted where inserted.iMaHDN = iMaHDN)
end

-- proc lấy chức vụ từ mã nhân viên
go
create proc sp_xem_ChucVu_tu_MaNV @manv int
as begin
select a.sTenLoaiTK from tblLoaiTaiKhoan a,tblNhanVien b, tblTaiKhoan c
where b.iMaNV=c.iMaNV and c.iMaLoaiTK = a.iMaLoaiTK and b.iMaNV = @manv
end 
-- proc lấy danh sách nhân viên kho
go
create proc sp_ds_NhanVienKho
as begin
select b.iMaNV,b.sTenNV from tblLoaiTaiKhoan a,tblNhanVien b, tblTaiKhoan c
where b.iMaNV=c.iMaNV and c.iMaLoaiTK = a.iMaLoaiTK and a.iMaLoaiTK=4
end 
-- proc xem danh sách tài khoản
go
create proc sp_ds_TaiKhoan
as 
	begin
		select a.iMaTK as N'Mã Tài Khoản',a.STenDangNhap as N'Tên Đăng Nhập',
		a.sMatKhau as N'Mật khẩu',c.iMaNV as N'Mã Nhân Viên',c.sTenNV as N'Tên Nhân Viên',b.sTenLoaiTK as N'Chức Vụ'
		from tblTaiKhoan a,tblLoaiTaiKhoan b,tblNhanVien c
		where a.iMaLoaiTK = b .iMaLoaiTK and a.iMaNV = c.iMaNV
	end
select * from tblLoaiTaiKhoan where iMaLoaiTK!=1
select * from tblNhanVien where trangthai=0 or trangthai is null

--HÓA ĐƠN BÁN HÀNG
go 
-- tạo proc xem danh sách hóa đơn bán
create proc sp_ds_HoaDonBan
as begin
	select a.iMaHDB as N'Mã HĐ', a.iMaNV as N'Mã NV',b.sTenNV as N'Tên Nhân Viên', a.dNgayLap N'Ngày Lập',a.fTongTien as N'Tổng Tiền',
	case (a.iTrangThai)
		when 0 then N'Chưa Thanh Toán'
		when 1 then N'Đã Thanh Toán'
	end as N'Trạng Thái' 
	from tblHoaDonBan a,tblNhanVien b
	where a.iMaNV = b.iMaNV
	end
exec sp_ds_HoaDonBan
go
-- proc thêm hóa đơn bán hàng
create proc sp_them_HoaDonBan @mahd int,@manv int,@ngaylap datetime
as
begin
	insert into tblHoaDonBan values(@manv,@ngaylap,0,0);
end
-- lấy chi tiết hóa đơn bán theo mã hóa đơn
select a.iMaHDB as N'Mã HĐ',a.iMaSP as N'Mã SP', b.fGia as N'Giá Bán', a.iSoLuongBan as N'Số Lượng Bán', (a.iSoLuongBan*b.fGia) as N'Thành Tiền'
from tblChiTietHDB a, tblSanPham b
where a.iMaHDB = 1 and a.iMaSP = b.iMaSP
go
-- tao proc sửa hóa đơn bán
create proc sp_capnhat_HoaDonBan @mahd int,@manv int,@ngaylap datetime,@tongtien float,@trangthai int
as
begin
	update tblHoaDonBan 
	set iMaNV = @manv , dNgayLap = @ngaylap,fTongTien = @tongtien , iTrangThai = @trangthai
	where iMaHDB = @mahd
end 
go
-- xóa hóa đơn bán hàng 
create proc sp_xoa_HoaDonBan_va_ChiTietHDB @mahd int
as
	begin
		declare @count int
		set @count = (select count(iMaHDB) from tblChiTietHDB where iMaHDB=@mahd)
		-- không có chi tiết hóa đơn
		if @count = 0
			delete tblHoaDonBan
			where iMaHDB =@mahd
		-- có chi tiết háo đơn
		else
			delete tblHoaDonBan
			where iMaHDB = @mahd
			delete tblHoaDonBan
			where iMaHDB =@mahd
	end
go
-- proc lấy danh sách nhân viên bán hàng
go
create proc sp_ds_NhanVienBanHang
as begin
select b.iMaNV,b.sTenNV from tblLoaiTaiKhoan a,tblNhanVien b, tblTaiKhoan c
where b.iMaNV=c.iMaNV and c.iMaLoaiTK = a.iMaLoaiTK and a.iMaLoaiTK=3
end 
-- thanh toán hóa đơn bán hàng
go
create proc sp_thanhtoan_HoaDonBan @mahd int
as
begin 
update tblHoaDonBan
set iTrangThai =1
where iMaHDB = @mahd
end

go
create trigger tr_them_SanPhamChiTietHDB_TongTienHDB on tblChiTietHDB after insert,update
as 
begin
	declare @mahdb int
	set @mahdb =  (select iMaHDB from inserted)
	update tblHoaDonBan
	set fTongTien = fTongTien + (select SUM(a.iSoLuongBan * b.fGia) from inserted a,tblSanPham b where a.iMaHDB = iMaHDB and a.iMaSP=b.iMaSP)
	where iMaHDB = @mahdb
end
go
-- ds sản phẩm bán để thêm vào giỏ
go
create proc sp_ds_SanPhamBan
 as begin 
 select a.iMaSP as N'Mã SP', a.sTenSP as N'Tên SP',a.fGia as N'Gía',a.iSoLuong as N'Số Lượng',a.dNgaySX as N'Ngày SX',a.dHanSD as N'Hạn SD'
 from tblSanPham a
 end
 exec sp_ds_SanPhamBan
--  ds sản phẩm chi tiết hóa đơn
go
create proc sp_ds_SanPham_CTHDBanHang @mahd int
as
    begin
        select b.iMaSP as N'Mã Sản Phẩm', b.sTenSP as N'Tên Sản Phẩm', a.iSoLuongBan as N'Số Lượng Bán', B.fGia as N'Giá Nhập', (b.fGia  * a.iSoLuongBan) as N'Thành Tiền'
        from tblChiTietHDB a, tblSanPham b
        where iMaHDB = @mahd and a.iMaSP = b.iMaSP
    end      
go 
exec sp_ds_SanPham_CTHDBanHang 1
-- thêm sản phẩm vào hóa đơn
create proc sp_them_SanPham_CTHDBan @mahd int, @masp int, @soluongban int
as
begin
 declare @tontai int
 set @tontai = (select count(iMaHDB) from tblChiTietHDB where iMaHDB = @mahd and iMaSP = @masp)
 print @tontai
 if @tontai != 0
    begin
		update tblChiTietHDB
		set iSoLuongBan = iSoLuongBan + @soluongban
		where iMaHDB = @mahd and iMaSP = @masp
	end
	else
		begin
			insert into tblChiTietHDB values(@mahd, @masp, @soluongban);
		end
	update tblSanPham
	set iSoLuong = iSoLuong - @soluongban
	where iMaSP = @masp
end   
go
exec sp_them_SanPham_CTHDBan 1,1,1
-- câp nhật sản phẩm vào hóa đơn
go
create proc sp_capnhat_SanPham_CTHDBan @mahd int, @masp int, @soluongban int
as
begin
	declare @soluongbandau int
	set @soluongbandau = (select iSoLuongBan from tblChiTietHDB where iMaHDB = @mahd and iMaSP = @masp)
	update tblChiTietHDB
	set iSoLuongBan =  @soluongban
	where iMaHDB = @mahd and iMaSP = @masp
	update tblSanPham
	set iSoLuong = iSoLuong + @soluongbandau - @soluongban
	where iMaSP = @masp
end  
go
-- xóa sản phẩm trong hóa đơn
create proc sp_xoa_SanPham_CTHDBan @mahd int, @masp int,@tongtien float
as
begin
	declare @soluongxoa int
	set @soluongxoa = (select iSoLuongBan from tblChiTietHDB where iMaHDB = @mahd and iMaSP = @masp)
	begin
		delete tblChiTietHDB
		where iMaHDB = @mahd and iMaSP = @masp
		update tblSanPham
		set iSoLuong = iSoLuong + @soluongxoa
		where iMaSP = @masp
		update tblHoaDonBan 
		set fTongTien = fTongTien - @tongtien
		where iMaHDB=@mahd
	end
end

exec sp_xoa_SanPham_CTHDBan 1,2
select fTongTien from tblHoaDonBan where iMaHDB = 2

select * from tblChiTietHDB a, tblHoaDonBan b where a.iMaHDB = b.iMaHDB
select b.fTongTien from tblChiTietHDB a, tblHoaDonBan b where a.iMaHDB = 1 and a.iMaHDB = b.iMaHDB and a.iMaSP =1
