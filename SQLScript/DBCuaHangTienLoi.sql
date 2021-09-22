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
	sChucVu nvarchar(50),
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
  sDonViTinh varchar(7),
  dNgaySX date,
  dHanSD date
)
alter table tblSanPham
alter column  sDonViTinh nvarchar(10)
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
  fTongTien float
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
  fTongTien float
)

-- CREATE TABLE CHI TIẾT HÓA ĐƠN NHẬP HÀNG
/*Chi tiết hóa đơn Nhập : mã hd, mã sp, số lượng nhập*/
create table tblChiTietHDN(
	iMaHDN int,
	iMaSP int primary key (iMaHDN,iMaSP),
	iSoLuongNhap int
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

 -- thêm tài khoản
 insert into tblTaiKhoan values('phong','123','1','1');
 -- thêm nhân viên
 update tblNhanVien
	set dNgaySinh ='2000-06-26', dNgayVaoLam = '2020-10-19', sSDT ='0352337342'

 update tblNhanVien 
 set sChucVu = (select sTenLoaiTK from tblLoaiTaiKhoan,tblTaiKhoan where tblNhanVien.iMaNV = tblTaiKhoan.iMaNV and tblTaiKhoan.iMaLoaiTK = tblLoaiTaiKhoan.iMaLoaiTK)
 go


-- procedure kiểm tra tài khoản bằng tendangnhap và matkhau trả về 1 tài khoản duy nhất or null
create proc sp_checklogin @tendangnhap nvarchar(50),@matkhau nvarchar(50)
as
begin
	select * from tblTaiKhoan
	where STenDangNhap = @tendangnhap and sMatKhau = @matkhau
end
go
-- kiểm tra
exec sp_checklogin 'phong','123'

-- lấy tên nhân viên từ mã nhân viên
select sTenNV from tblNhanVien where iMaNV = 1

-- thêm nhân viên quản lý
insert into tblNhanVien values(N'Nguyễn Đình Phong',1,N'Hà Nội','2000-10-22','2020-10-22','0201302402',null); go
 -- thêm tài khoản
 insert into tblTaiKhoan values('phong123','123',2,1002);
go
-- procedure thêm nhân viên ** chức vụ chỉ được cập nhật khi thêm tài khoản (dựa vào loại tài khoản để phân quyền)
create proc sp_ThemNhanVien_from_QuanLy @ten nvarchar(100),@gioitinh int,@quequan nvarchar(100),@ngaysinh date,@ngayvaolam date,@sdt varchar(20)
as 
begin 
	insert into
end
go

-- thêm NCC 
insert into tblNhaCC values (N'VinMart',N'20 Lý Thường Kiệt, Hoàn Kiếm, Hà Nội','04.3934 7628')
insert into tblNhaCC values (N'KFC',N'Số 1, Lô 13B, KĐT Mới Trung Yên,  Quận Cầu Giấy, Hà Nội','04.3935 6578')
insert into tblNhaCC values (N'Vifoodshop',N'164 Vương Thừa Vũ, Thanh Xuân, Hà Nội','0342.387.630')

insert into tblNhaCC values (N'Công ty cổ phần Bia - Rượu - Nước giải khát Hà Nội',N'83 Hoàng Hoa Thám, Ba Đình, Hà Nội.','0243 845 843')
-- thêm Loai SanPham
insert into tblLoaiSanPham values(N'Rau-Củ-Qủa') -- VinMart /1 
insert into tblLoaiSanPham values(N'Bánh Mì')    -- VinMart /2
insert into tblLoaiSanPham values(N'Sữa')		 -- VinMart /3
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
insert into tblSanPham values(N'Rau Cải Ngồng',1,1,10000,50,'VND','2020-05-23','2021-05-23')
insert into tblSanPham values(N'Táo',1,1,20000,50,'KG','2020-05-23','2021-05-23')
-- Bánh Mì
insert into tblSanPham values(N'Bánh Mì Cháy',2,1,20000,50,'Cái','2020-05-23','2021-05-23')
insert into tblSanPham values(N'Bánh Mì Ruốc',2,1,20000,50,'Cái','2020-05-23','2021-05-23')
insert into tblSanPham values(N'Bánh Mì Bơ',2,1,20000,50,'Cái','2020-05-23','2021-05-23')
-- Sữa
insert into tblSanPham values(N'Sữa Bò',3,1,30000,50,'Hộp','2020-05-23','2021-05-23')
insert into tblSanPham values(N'Sữa Ông Thọ',3,1,30000,50,'Hộp','2020-05-23','2021-05-23')
insert into tblSanPham values(N'Sữa MiLo',3,1,20000,50,'Hộp','2020-05-23','2021-05-23')
-- Bim Bim
insert into tblSanPham values(N'Bim Bim khoai Tây',4,2,10000,50,'Gói','2020-05-23','2021-05-23')
insert into tblSanPham values(N'Bim Bim Chuối',4,2,10000,50,'Gói','2020-05-23','2021-05-23')
insert into tblSanPham values(N'Bim Bim Cà Chua',4,2,10000,50,'Gói','2020-05-23','2021-05-23')
-- mÌ tÔM
insert into tblSanPham values(N'Mì Tôm',5,2,5000,50,'Gói','2020-05-23','2021-05-23')
insert into tblSanPham values(N'Bim Bim Cà Chua',5,2,5000,50,'Gói','2020-05-23','2021-05-23')
-- Nước Ngọt
insert into tblSanPham values(N'CoCa',6,4,10000,50,'Chai','2020-05-23','2021-05-23')
insert into tblSanPham values(N'FanTa',6,4,10000,50,'Chai','2020-05-23','2021-05-23')
insert into tblSanPham values(N'Sprite',6,4,10000,50,'Chai','2020-05-23','2021-05-23')
-- -- Rượu
insert into tblSanPham values(N'Vodka 500ml',7,4,80000,50,'Chai','2020-05-23','2021-05-23')
insert into tblSanPham values(N'Men 500ml',7,4,80000,50,'Chai','2020-05-23','2021-05-23')
insert into tblSanPham values(N'SoJu 100 ml',7,4,50000,50,'Chai','2020-05-23','2021-05-23')
-- Bia 
insert into tblSanPham values(N'Bia Hà Nội',8,4,20000,50,'Chai','2020-05-23','2021-05-23')
insert into tblSanPham values(N'Bia Sài Gòn',8,4,20000,50,'Chai','2020-05-23','2021-05-23')
insert into tblSanPham values(N'Bia Haniken',8,4,20000,50,'Chai','2020-05-23','2021-05-23')
-- Chocolate
insert into tblSanPham values(N'KitKat',9,3,10000,50,'Thanh','2020-05-23','2021-05-23')
insert into tblSanPham values(N'MentyKit',9,3,50000,50,'Hộp','2020-05-23','2021-05-23')
-- Xà Phong
insert into tblSanPham values(N'O Mô',10,3,20000,50,'Gói','2020-05-23','2021-05-23')
insert into tblSanPham values(N'ABa',10,3,50000,50,'Gói','2020-05-23','2021-05-23')


select *from tblSanPham
update  tblSanPham
set sDonViTinh= N'Hộp'
where sDonViTinh = 'Hop'
go
-- proc xem nhân viên theo chức vụ
drop proc sp_showNV_by_Chucvu
go
create proc sp_showNV_by_Chucvu @matk int
as
begin 
 declare @maloaitk varchar(10);
	set @maloaitk =( select a.iMaLoaiTK from tblLoaiTaiKhoan a,tblTaiKhoan b  where a.iMaLoaiTK=b.iMaLoaiTK and b.iMaTK=@matk);
	if @maloaitk=1
		select a.iMaNV as N'Mã NV',a.sTenNV as N'Họ Tên',
		case (a.iGioiTinh )
			when 1 then N'Nam'
			when 0 then N'Nữ'
		end as N'Giới Tính',
		a.sQueQuan as N'Quê Quán', a.dNgaySinh as N'Ngày Sinh',a.dNgayVaoLam as N'Ngày vào làm',
		 a.sSDT as N'Số ĐT',a.sChucVu as N'Chức Vụ'
		 from tblNhanVien a;
		--print'chuSoHuu';
	else if @maloaitk=2
		select a.iMaNV as N'Mã NV',a.sTenNV as N'Họ Tên',
		case (a.iGioiTinh )
			when 1 then N'Nam'
			when 0 then N'Nữ'
		end as N'Giới Tính',
		a.sQueQuan as N'Quê Quán', a.dNgaySinh as N'Ngày Sinh',a.dNgayVaoLam as N'Ngày vào làm',
		 a.sSDT as N'Số ĐT',a.sChucVu as N'Chức Vụ'
		from tblNhanVien a where sChucVu !='chusohuu';
		--print'quanly';
		else 
		select a.iMaNV as N'Mã NV',a.sTenNV as N'Họ Tên',
		case (a.iGioiTinh )
			when 1 then N'Nam'
			when 0 then N'Nữ'
		end as N'Giới Tính',
		a.sQueQuan as N'Quê Quán', a.dNgaySinh as N'Ngày Sinh',a.dNgayVaoLam as N'Ngày vào làm',
		 a.sSDT as N'Số ĐT',a.sChucVu as N'Chức Vụ'
		from tblNhanVien a where sChucVu !='chusohuu' and sChucVu!='squanly';
		--print'nhanvien';
end

 --select a.iMaLoaiTK from tblLoaiTaiKhoan a,tblTaiKhoan b  where a.iMaLoaiTK=b.iMaLoaiTK and b.iMaTK=1
exec sp_showNV_by_Chucvu 2

-- lấy ra mã nv lớn nhất để tạo mã mới khi thêm
select MAX(iMaNV) from tblNhanVien
-- lấy ra danh sách chức vụ theo mã tài khoản
--select * from tblLoaiTaiKhoan a, tblTaiKhoan b where a.iMaLoaiTK =b.iMaLoaiTK
drop proc sp_getComboBox_ChucVu_Nv
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

exec  sp_getComboBox_ChucVu_Nv 2
go
-- tạo proc thêm nhân viên từ 1 đối tượng nhân viên
drop proc sp_addNhanVien
create proc sp_addNhanVien @ten nvarchar(100),@gioitinh int,@diachi nvarchar(100),@ngaysinh date,@ngaylam date,@sdt varchar(20),@chucvu nvarchar(50)
as 
begin 
	insert into tblNhanVien values(@ten,@gioitinh,@diachi,@ngaysinh,@ngaylam,@sdt,@chucvu,null)
end
go
-- tạo proc sửa nhân viên điều kiện theo mã nhân viên
create proc sp_updateNhanVien @manv int, @ten nvarchar(100),@gioitinh int,@diachi nvarchar(100),@ngaysinh date,@ngaylam date,@sdt varchar(20),@chucvu nvarchar(50)
as 
begin 
	update tblNhanVien
	set sTenNV = @ten,iGioiTinh=@gioitinh,sQueQuan=@diachi,dNgaySinh=@ngaysinh,dNgayVaoLam=@ngaylam,sSDT=@sdt,sChucVu=@chucvu
	where iMaNV=@manv
end
go
-- tạo proc xóa nhân viên theo mã nhân viên
create proc sp_deleteNhanVien @manv int
as 
begin 
	delete 
	from tblNhanVien
	where iMaNV= @manv
end
go
-- tạo proc search nhân viên theo từ khóa tìm ở mã hoặc tên hoặc địa chỉ
drop proc sp_Search_by_Chucvu
go
create proc sp_Search_by_Chucvu @matk int, @key nvarchar(50)
as 
begin 
declare @maloaitk varchar(10);
	set @maloaitk =( select a.iMaLoaiTK from tblLoaiTaiKhoan a,tblTaiKhoan b  where a.iMaLoaiTK=b.iMaLoaiTK and b.iMaTK=@matk);
	if @maloaitk=1
		select a.iMaNV as N'Mã NV',a.sTenNV as N'Họ Tên',
		case (a.iGioiTinh )
			when 1 then N'Nam'
			when 0 then N'Nữ'
		end as N'Giới Tính',
		a.sQueQuan as N'Quê Quán', a.dNgaySinh as N'Ngày Sinh',a.dNgayVaoLam as N'Ngày vào làm',
		 a.sSDT as N'Số ĐT',a.sChucVu as N'Chức Vụ'
		 from tblNhanVien a
		 where iMaNV like '%'+@key+'%' or sTenNV like '%'+@key+'%' or sQueQuan like '%'+@key+'%'
		--print'chuSoHuu';
	else if @maloaitk=2
		select a.iMaNV as N'Mã NV',a.sTenNV as N'Họ Tên',
		case (a.iGioiTinh )
			when 1 then N'Nam'
			when 0 then N'Nữ'
		end as N'Giới Tính',
		a.sQueQuan as N'Quê Quán', a.dNgaySinh as N'Ngày Sinh',a.dNgayVaoLam as N'Ngày vào làm',
		 a.sSDT as N'Số ĐT',a.sChucVu as N'Chức Vụ'
		from tblNhanVien a where sChucVu !='chusohuu' and (iMaNV like '%'+@key+'%' or sTenNV like '%'+@key+'%' or sQueQuan like '%'+@key+'%');
		--print'quanly';
		else 
		select a.iMaNV as N'Mã NV',a.sTenNV as N'Họ Tên',
		case (a.iGioiTinh )
			when 1 then N'Nam'
			when 0 then N'Nữ'
		end as N'Giới Tính',
		a.sQueQuan as N'Quê Quán', a.dNgaySinh as N'Ngày Sinh',a.dNgayVaoLam as N'Ngày vào làm',
		 a.sSDT as N'Số ĐT',a.sChucVu as N'Chức Vụ'
		from tblNhanVien a where sChucVu !='chusohuu' and sChucVu!='squanly'  and (iMaNV like '%'+@key+'%' or sTenNV like '%'+@key+'%' or sQueQuan like '%'+@key+'%');
end
go
exec sp_Search_by_Chucvu 2,N'm'
-- xem tài khoản và thông thông tin tài khoản cùng nhân viên
select a.iMaNV as N'Mã NV',a.sTenNV N'Tên NV',b.iMaTK as N'Mã TK',b.STenDangNhap as N'Tên Đăng Nhập',b.sMatKhau as 'Mật Khẩu'
 from tblNhanVien a, tblTaiKhoan b,tblLoaiTaiKhoan c
where a.iMaNV = b.iMaNV and b.iMaLoaiTK = c.iMaLoaiTK
-- thêm cột trạng thái cho bảng nhân viên 1- đã có tài khoản - 0 chưa có tài khoản
 alter table tblNhanVien
 add trangthai int
 select * from tblNhanVien
 update tblNhanVien
	set trangthai = 1
	where exists (select* from tblTaiKhoan where tblNhanVien.iMaNV=tblTaiKhoan.iMaNV)
go

-- tạo proc hiện thị danh sách nhân viên và trạng thái tài khoản
drop proc sp_show_NhanVien_trangthai
go
create proc sp_show_NhanVien_trangthai @matk int
as
begin
	declare @maloaitk varchar(10);
	set @maloaitk = (select a.iMaLoaiTK from tblTaiKhoan a where a.iMaTK = @matk);
	if @maloaitk =1
		  select a.iMaNV as N'Mã NV',a.sTenNV N'Tên NV',a.sChucVu as N'Chức Vụ',a.trangthai as N'Trạng Thái'
		  from tblNhanVien a
	else if @maloaitk = 2
		  select a.iMaNV as N'Mã NV',a.sTenNV N'Tên NV',a.sChucVu as N'Chức Vụ',a.trangthai as N'Trạng Thái'
		  from tblNhanVien a
		  where (a.sChucVu !=N'chusohuu' and a.sChucVu!=N'quanly') or a.sChucVu is null
		 -- group by a.iMaNV,a.sTenNV,a.sChucVu,a.trangthai
end
go
--- tạo proc xem tài khoản từ mã nhân viên
create proc sp_show_acc_by_manv @manv int
as 
begin
	select a.iMaNV,a.iMaTK,a.STenDangNhap,a.sMatKhau,a.iMaLoaiTK 
	from tblTaiKhoan a
	where a.iMaNV = @manv
end
go
exec sp_show_acc_by_manv 2
-- xem tài khoản lớn nhất để lấy mã tk tiếp theo
select max(a.iMaTK) from tblTaiKhoan a
-- xem chức vụ từ mã nhân viên
select a.sChucVu from tblNhanVien a where a.iMaNV = 2
go
-- tạo proc thêm tài khoản từ 1 đối tượng tài khoản và thay đổi trạng thái ở bảng nhân viên
create proc sp_add_Account_and_changeStatus @tendangnhap nvarchar(50),@matkhau nvarchar(50),@maloaitk int,@manv int
as
 begin
	insert into tblTaiKhoan values(@tendangnhap,@matkhau,@maloaitk,@manv);
	update tblNhanVien 
	set trangthai=1
	where iMaNV=@manv
 end
 
 exec sp_add_Account_and_changeStatus 'vanlong','123',4,2004
 go
 -- tạo proc xóa tài khoản từ mã tài khoản và thay đổi trang thái ở bảng nhân viên
 drop proc sp_delete_Account_and_changeStatus
 go
 create proc sp_delete_Account_and_changeStatus @matk int,@manv int
as
 begin
	delete 
	from tblTaiKhoan
	where iMaTK =@matk
	update tblNhanVien 
	set trangthai=0
	where iMaNV=@manv
 end
 exec sp_delete_Account_and_changeStatus 1005,2004
 -- tạo proc update tài khoản từ mã tài khoản 
 go
  create proc sp_update_Account @matk int,@tendangnhap varchar(50),@matkhau varchar(50)
as
 begin

	update tblTaiKhoan 
	set STenDangNhap=@tendangnhap,sMatKhau =@matkhau
	where iMaTK = @matk
 end
 -- thêm cột hình ảnh vào tblsanpham
 alter table tblSanPham
 add HinhAnh nvarchar(50)
 go
 -- tạo proc xem sản phẩm
 create proc sp_show_SP 
 as begin 
 select a.iMaSP as N'Mã SP', a.sTenSP as N'Tên SP',a.iMaLoaiSP as N'Mã Loai',a.iMaNCC as 'Mã NCC',
 a.fGia as N'Gía',a.iSoLuong as N'Số Lượng',a.sDonViTinh as N'ĐVT',a.dNgaySX as N'Ngày SX',a.dHanSD as N'Hạn SD',a.HinhAnh as N'Hình Ảnh'
 from tblSanPham a
 end

-- xem loại sản phẩm
select * from tblLoaiSanPham
-- tạo proc sửa sản phẩm
go
drop proc sp_update_SanPham
go
create proc sp_update_SanPham @masp int,@tensp nvarchar(100),@maloai int,@mancc int,@gia float,@soluong int,@dvt nvarchar(10),
@nsx datetime,@hsd datetime,@hinhanh nvarchar(100)
as 
	begin
		update tblSanPham
		set sTenSP = @tensp,iMaLoaiSP=@maloai,iMaNCC =@mancc,fGia=@gia,iSoLuong=@soluong,sDonViTinh=@dvt,dNgaySX=@nsx,dHanSD=@hsd,HinhAnh=@hinhanh
		where iMaSP = @masp
	end
	go
-- tạo proc xóa sản phẩm sản phẩm
create proc sp_delete_SanPham @masp int
as 
	begin
		delete tblSanPham
		where iMaSP = @masp
	end
go
-- thêm cột giá nhập vào bảng chi tiết nhập hàng, thêm cột trạng thái vào HoaDonNhap
alter table tblChiTietHDN
add fGiaNhap float
alter table tblHoaDonNhap
add iTrangThai int
go
-- tạo proc xem danh sách hóa đơn
drop proc sp_show_HD
go
create proc sp_show_HD
as begin
	select a.iMaHDN as N'Mã HĐ', a.iMaNV as N'Mã NV', a.dNgayLap N'Ngày Lập',a.fTongTien as N'Tổng Tiền',
	case (a.iTrangThai)
	when 0 then N'Chưa Thanh Toán'
	when 1 then N'Đã Thanh Toán'
	end as N'Trạng Thái' 
	from tblHoaDonNhap a
	end
-- xem danh sách nhân viên kho
select a.iMaNV,a.sTenNV from tblNhanVien  a where sChucVu=N'nhanvienkho'
-- get max mã hóa đơn nhập
select max(iMaHDN) from tblHoaDonNhap
SELECT IDENT_CURRENT('tblHoaDonNhap') + 1
-- proc thêm hóa đơn nhập
create proc sp_add_HDN @mahd int,@manv int,@ngaynhap datetime,@tongtien float,@trangthai int
as
begin
	insert into tblHoaDonNhap values(@manv,@ngaynhap,@tongtien,@trangthai);
end
-- lấy chi tiết hóa đơn theo mã hóa đơn
select a.iMaHDN as N'Mã HĐ',a.iMaSP as N'Mã SP', a.fGiaNhap as N'Gía Nhập', a.iSoLuongNhap as N'Số Lượng Nhâp'
from tblChiTietHDN a
where a.iMaHDN = 1
-- tao proc sửa hóa đơn nhập
create proc sp_update_HDN @mahd int,@manv int,@ngaynhap datetime,@tongtien float,@trangthai int
as
begin
	update tblHoaDonNhap 
	set iMaNV = @manv , dNgayLap = @ngaynhap,fTongTien = @tongtien , iTrangThai = @trangthai
	where iMaHDN = @mahd
end
-- xem chi tiết hóa đơn  nhập theo mã hd
select * from tblChiTietHDN 
-- xóa hóa đơn ko có chi tiết hóa đơn
create proc sp_delete_HDN_1 @mahd int
as
	begin
	delete tblHoaDonNhap
	where iMaHDN =@mahd
	end
	go
-- xóa hóa đơn có chi tiết hóa đơn
create proc sp_delete_HDN_2 @mahd int
as
	begin
	delete tblChiTietHDN
	where iMaHDN = @mahd
	delete tblHoaDonNhap
	where iMaHDN =@mahd
	end
-- get mã loại tk from mã tk
select a.iMaLoaiTK from tblTaiKhoan a where a.iMaTK =1002
-- thanh toán hóa đơn
go
create proc sp_thanhtoan_HD @mahd int
as
begin 
update tblHoaDonNhap
set iTrangThai =1
where iMaHDN = @mahd
end
select distinct(sDonViTinh) from tblSanPham
go
drop trigger add_spCTHDN_TongTienHDN go
create trigger add_spCTHDN_TongTienHDN on tblChiTietHDN after insert
as 
begin
	update tblHoaDonNhap 
	set fTongTien = fTongTien + (select SUM(iSoLuongNhap * fGiaNhap) from inserted where inserted.iMaHDN = a.iMaHDN)
end
insert into tblChiTietHDN values(1,2,50,20000)
insert into tblChiTietHDN values(1,3,20,20000)
insert into tblChiTietHDN values(1,5,10,20000)
insert into tblChiTietHDN values(1,6,10,20000)
insert into tblChiTietHDN values(1,7,10,25000)
insert into tblChiTietHDN values(1,8,10,15000)
insert into tblChiTietHDN values(1,9,10,8000)
-- hoas ddonw 5
insert into tblChiTietHDN values(5,2,50,20000)
insert into tblChiTietHDN values(5,3,20,20000)
insert into tblChiTietHDN values(5,5,10,20000)
-- hoa don 6
insert into tblChiTietHDN values(6,9,10,8000)
insert into tblChiTietHDN values(6,2,50,20000)
insert into tblChiTietHDN values(6,8,10,15000)
-- hoa don 7
-- hoa don 8

 update tblHoaDonNhap 
set fTongTien = 
(select SUM(iSoLuongNhap * fGiaNhap) from tblChiTietHDN a where a.iMaHDN = tblHoaDonNhap.iMaHDN)

select SUM(iSoLuongNhap * fGiaNhap) from tblChiTietHDN where iMaHDN=1