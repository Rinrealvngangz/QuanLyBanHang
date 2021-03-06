USE [master]
GO
/****** Object:  Database [QLBH]    Script Date: 9/7/2020 8:55:12 PM ******/
CREATE DATABASE [QLBH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLBH', FILENAME = N'D:\DATA\QLBH.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLBH_log', FILENAME = N'D:\DATA\QLBH_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLBH] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLBH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLBH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLBH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLBH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLBH] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLBH] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLBH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLBH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLBH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLBH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLBH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLBH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLBH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLBH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLBH] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLBH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLBH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLBH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLBH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLBH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLBH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLBH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLBH] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLBH] SET  MULTI_USER 
GO
ALTER DATABASE [QLBH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLBH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLBH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLBH] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLBH] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLBH] SET QUERY_STORE = OFF
GO
USE [QLBH]
GO
/****** Object:  User [test]    Script Date: 9/7/2020 8:55:12 PM ******/
CREATE USER [test] FOR LOGIN [test] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [test]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [test]
GO
/****** Object:  Table [dbo].[AccountUser]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountUser](
	[UserName] [nchar](100) NULL,
	[PassWord] [nchar](100) NULL,
	[role] [nchar](50) NULL,
	[MaUser] [nchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHD] [nchar](10) NULL,
	[MaSP] [nchar](10) NULL,
	[TenSP] [nvarchar](50) NULL,
	[Size] [nchar](10) NULL,
	[Color] [nchar](10) NULL,
	[SoLuong] [nchar](10) NULL,
	[Gia] [int] NULL,
	[TenNV] [nvarchar](200) NULL,
	[TenKH] [nvarchar](200) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GioHang]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GioHang](
	[MaSP] [nchar](10) NULL,
	[TenSP] [nvarchar](50) NULL,
	[Size] [nchar](10) NULL,
	[Color] [nchar](10) NULL,
	[SoLuong] [nchar](10) NULL,
	[Gia] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hang]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hang](
	[MaHang] [nchar](10) NULL,
	[TenHang] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] NULL,
	[TenKH] [nvarchar](50) NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[NgayBan] [datetime] NULL,
	[TongGia] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [int] NULL,
	[NgayMua] [datetime] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](10) NULL,
	[TenNV] [nvarchar](200) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[NgaySinh] [date] NULL,
	[HinhAnh] [nvarchar](200) NULL,
	[Sdt] [nchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhapKho]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhapKho](
	[MaSP] [nchar](10) NULL,
	[TenSP] [nvarchar](50) NULL,
	[NgayNhap] [datetime] NULL,
	[Soluong] [int] NULL,
	[MaNCC] [nchar](10) NULL,
	[DonGia] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nchar](10) NULL,
	[TenSP] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[Soluong] [int] NULL,
	[MaHang] [nchar](10) NULL,
	[Image] [char](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[HinhAnh] [nvarchar](200) NULL,
	[MaNCC] [nchar](10) NULL,
	[TenNCC] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[SDT] [nchar](50) NULL,
	[Hang] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongKe]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongKe](
	[Date] [datetime] NULL,
	[Price] [int] NULL,
	[TenSP] [nvarchar](50) NULL,
	[ValMonth] [int] NULL,
	[ValYear] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongTinSP]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinSP](
	[MaSP] [nchar](10) NULL,
	[Size] [nchar](10) NULL,
	[Color] [nchar](10) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[AccountUser] ([UserName], [PassWord], [role], [MaUser]) VALUES (N'Ha                                                                                                  ', N'123                                                                                                 ', N'User                                              ', N'NV1                                               ')
INSERT [dbo].[AccountUser] ([UserName], [PassWord], [role], [MaUser]) VALUES (N'Admin                                                                                               ', N'admin123                                                                                            ', N'Admin                                             ', N'AD                                                ')
GO
INSERT [dbo].[Hang] ([MaHang], [TenHang]) VALUES (N'NK        ', N'Nike      ')
INSERT [dbo].[Hang] ([MaHang], [TenHang]) VALUES (N'AD        ', N'Adidas    ')
INSERT [dbo].[Hang] ([MaHang], [TenHang]) VALUES (N'CV        ', N'Converse  ')
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [DiaChi], [NgaySinh], [HinhAnh], [Sdt]) VALUES (N'NV1       ', N'Nguyen', N'Nữ', N'23 btx', CAST(N'2000-02-04' AS Date), N'unnamed.jpg', N'0949238337                                                                                                                                                                                              ')
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [Soluong], [MaHang], [Image]) VALUES (N'NK1       ', N'Nike SB', 5000000, 1, N'NK        ', NULL)
GO
INSERT [dbo].[ThongTinSP] ([MaSP], [Size], [Color]) VALUES (N'NK1       ', N'6         ', N'red       ')
GO
/****** Object:  StoredProcedure [dbo].[checkAccount]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[checkAccount]
@user nchar(50) , @pass nchar(50)
as
	 select * from AccountUser Where UserName =@user and PassWord = @pass
GO
/****** Object:  StoredProcedure [dbo].[checkThongKe]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[checkThongKe]
   @thang int , @nam int
   as
      if exists(select * from ThongKe where  MONTH(Date) =@thang and YEAR(Date) = @nam )
	  begin
	
	    print N'Có thông tin'
		
	  end
	  else
	  print N'Không có Thông tin'
GO
/****** Object:  StoredProcedure [dbo].[CountHD]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[CountHD]
 as
 begin
   Select count(*)
   from HoaDon
 end
GO
/****** Object:  StoredProcedure [dbo].[DeleteKhachHang]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[DeleteKhachHang]
 @maKH nchar(50)
as
begin
 delete 
 from KhachHang
 where MaKH=@maKH
 end
  
GO
/****** Object:  StoredProcedure [dbo].[DeleteNCC]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[DeleteNCC]
@maNCC nvarchar(10)
as
begin
   delete
   from Supplier
   where MaNCC=@maNCC
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteNhanVien]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[DeleteNhanVien]
  @maNV nchar(10)

  as
   begin
     delete
	 from NhanVien
	 where MaNV=@maNV
   end
GO
/****** Object:  StoredProcedure [dbo].[DeleteSPKho]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteSPKho]
@masp nvarchar(10)
as
begin
    Delete
	from NhapKho
	where MaSP=@masp
end
GO
/****** Object:  StoredProcedure [dbo].[DelUser]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DelUser]
@MaNV nchar(50)
as
 begin
   delete
   from AccountUser
   Where MaUser =@MaNV
 end
GO
/****** Object:  StoredProcedure [dbo].[DemHoaDon]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DemHoaDon]

 as
 begin 
 select  max(MaHD)
 from HoaDon
 end
GO
/****** Object:  StoredProcedure [dbo].[DemKhachHang_Ma]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DemKhachHang_Ma]
as
begin
  select count(*)
  from KhachHang
end
GO
/****** Object:  StoredProcedure [dbo].[DemSoLuongSpInThongTinSp]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DemSoLuongSpInThongTinSp]
@masp nvarchar(10)
as
select  count (A.MaSP) as soluong
from ThongTinSP A
where A.MaSP=@masp
GO
/****** Object:  StoredProcedure [dbo].[DemSoLuongTTSP]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   create proc [dbo].[DemSoLuongTTSP]
@masp nvarchar(10)
as
select  count (A.MaSP) as soluong
from ThongTinSP A
where A.MaSP=@masp
GO
/****** Object:  StoredProcedure [dbo].[FillGioiNhanVien]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[FillGioiNhanVien]
 @giotinh nvarchar(20)
 as
  begin
    select * from NhanVien Where GioiTinh =@giotinh
  end
GO
/****** Object:  StoredProcedure [dbo].[fillImgNameNV]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[fillImgNameNV]
@user nchar(50) 
as
   if exists (select * from AccountUser Where UserName =@user)
     begin
	   select B.MaNV ,B.TenNV ,B.GioiTinh, B.DiaChi ,B.NgaySinh ,B.HinhAnh ,B.Sdt
	   from AccountUser A, NhanVien B
	   where A.MaUser =B.MaNV and A.UserName =@user
	 end
	 else
	 print N'Khong co nhan vien trong danh sach'
GO
/****** Object:  StoredProcedure [dbo].[FillPassNv]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[FillPassNv]
 @maNv nchar(50)
 as
 begin
 select B.UserName , B.PassWord ,B.role,B.MaUser
 from NhanVien A , AccountUser B
 where  A.MaNV =B.MaUser and A.MaNV =@maNv
 end
GO
/****** Object:  StoredProcedure [dbo].[FillTenKH]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[FillTenKH]

 as
  begin
    select * from KhachHang order by TenKH
  end
GO
/****** Object:  StoredProcedure [dbo].[FillTenNhanVien]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[FillTenNhanVien]

 as
  begin
    select * from NhanVien order by TenNV , NgaySinh ASC
  end
GO
/****** Object:  StoredProcedure [dbo].[FillTheoHang]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[FillTheoHang]
  @Hang nchar(50)
  as
  begin
      select * from Supplier Where Hang =@Hang
  end
GO
/****** Object:  StoredProcedure [dbo].[hienThiNhapKho]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[hienThiNhapKho]
as
select * from NhapKho
GO
/****** Object:  StoredProcedure [dbo].[InsertKhachHang]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertKhachHang]
@maKH nchar(10) , @tenKH nvarchar(200) ,@diaChi nvarchar(50) , @sdt int , @ngaymua nchar (50)

as
  if exists(select * from KhachHang Where MaKH =@maKH)
    print N'Đã Có Mã KH trong Danh sách'
	else
	  begin
	    insert into KhachHang values(@maKH,@tenKH,@diaChi,@sdt,@ngaymua)
		print N'Thêm Thành Công'
	  end
GO
/****** Object:  StoredProcedure [dbo].[LoadingNCCTheoMa]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LoadingNCCTheoMa]
@maNCC nchar(10)
as
 begin
   select * from Supplier where MaNCC =@maNCC
 end
	
GO
/****** Object:  StoredProcedure [dbo].[LoadingThongKe]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create proc [dbo].[LoadingThongKe]
  @date nchar(50)
  as
  begin
   select *
   from ThongKe
   where Date =@date
	end
GO
/****** Object:  StoredProcedure [dbo].[ThemAdmin]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[ThemAdmin]
  @maNV nchar(10) ,@user nchar(50) ,@pass nchar(200) ,@role nchar(10)
  as
    if exists (select * from AccountUser Where MaUser =@maNV) or  exists (select * from AccountUser Where UserName =@user) 
	  print N'đã có mã trùng hoặc đã có tên user trùng'
	  else
	    begin
	 
	     insert into AccountUser values(@user,@pass,@role,@maNV)
		 print N'Thêm Success'
	  end
		 
GO
/****** Object:  StoredProcedure [dbo].[themSPtuKho]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themSPtuKho]
@maSp  nchar(10) , @tensp nvarchar(50) ,@dongia int ,@soluong int, @mahang nchar(10)
as
if exists (select * from SanPham Where MaSP=@maSp)
  print N'Đã có sản phẩm mã trùng'
  else
  begin
    insert into SanPham values (@maSp,@tensp,@dongia,@soluong,@mahang,null)
  end
GO
/****** Object:  StoredProcedure [dbo].[themThongKe]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[themThongKe]
 @date nchar(50) , @price int ,@tensp nvarchar(50) , @valMonth int ,@valYear int
 as
  begin
     insert into ThongKe values(@date,@price,@tensp,@valMonth,@valYear)
  end

GO
/****** Object:  StoredProcedure [dbo].[ThemUser]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemUser]
  @maNV nchar(10) ,@user nchar(50) ,@pass nchar(200) ,@role nchar(10)
  as
    if exists (select * from AccountUser Where MaUser =@maNV) or  exists (select * from AccountUser Where UserName =@user) 
	  print N'đã có mã trùng hoặc đã có tên user trùng'
	  else
	    begin
	  if exists (select * from NhanVien Where MaNV =@maNV)
	  begin
	     insert into AccountUser values(@user,@pass,@role,@maNV)
		 print N'Thêm Success'
	  end
	  else
	       print N'Không có mã Nhân viên'
		   end
GO
/****** Object:  StoredProcedure [dbo].[TimKiemKH]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[TimKiemKH]

@tenKH nvarchar(200)

as

begin
  select * from KhachHang where TenKH like @tenKH+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[TimKiemNCC]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   create proc [dbo].[TimKiemNCC]
  @tenNCC nvarchar(200)
  as
  begin
    select * from Supplier
	where TenNCC  like @tenNCC+'%'
  end
GO
/****** Object:  StoredProcedure [dbo].[TimKiemNhanVien]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TimKiemNhanVien]

@tenNV nvarchar(200)

as
 begin
    select * from NhanVien Where TenNV  like @tenNV+'%'
 end
GO
/****** Object:  StoredProcedure [dbo].[TimKiemSanPham]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TimKiemSanPham]
@Tensp nvarchar (50)

as
   select * from SanPham Where TenSP like @Tensp+'%'  
GO
/****** Object:  StoredProcedure [dbo].[TimKiemSpTheoMS]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TimKiemSpTheoMS]
@masp nvarchar(10)
as
select *
from SanPham 
where SanPham.MaSP = @masp
GO
/****** Object:  StoredProcedure [dbo].[TimKiemSpTheoTen]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TimKiemSpTheoTen]
@ten nvarchar(50)
as
select *
from SanPham 
where SanPham.TenSP = @ten
GO
/****** Object:  StoredProcedure [dbo].[TimMaxKhachHang_Ma]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TimMaxKhachHang_Ma]
as
begin
  select Max(MaKH)
  from KhachHang
end
GO
/****** Object:  StoredProcedure [dbo].[TimMaxSPShell]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[TimMaxSPShell]
as
 begin
 select  TenSP,count(*)
 from GioHang
 group by  TenSP
 having count(*) >= All(
   select count(*)
   from GioHang
   group by TenSP)
     
  end
GO
/****** Object:  StoredProcedure [dbo].[TimSp_Size_Hang]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TimSp_Size_Hang]
@maHang  nvarchar(10), @size int

as
select A.MaSP,A.TenSP,A.DonGia,A.Soluong
from SanPham A ,Hang B ,ThongTinSP C
where A.MaHang=B.MaHang and A.MaSP=C.MaSP and B.MaHang=@maHang and C.Size=@size
GO
/****** Object:  StoredProcedure [dbo].[TimSp_Size_Hang_MaSP]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TimSp_Size_Hang_MaSP]
@maHang  nvarchar(10),@maSP nvarchar(10) , @size nvarchar(10)
 
as
select A.MaSP,A.TenSP,A.DonGia,A.Soluong
from SanPham A ,Hang B ,ThongTinSP C
where A.MaHang=B.MaHang and A.MaSP=C.MaSP and B.MaHang=@maHang and C.Size=@size and A.MaSP=@maSP
GO
/****** Object:  StoredProcedure [dbo].[TimSpKhoTheoNTN]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TimSpKhoTheoNTN]
@ngay int , @thang int,@nam int
as
 select * 
 from NhapKho 
 where DAY(NgayNhap)=@ngay and MONTH(NgayNhap)=@thang and YEAR(NgayNhap) =@nam 
GO
/****** Object:  StoredProcedure [dbo].[TimTenHang]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TimTenHang]
@maHang nvarchar(10)
as
select A.MaSP,A.TenSP,A.DonGia,A.Soluong
from SanPham A ,Hang B 
where A.MaHang=B.MaHang and B.MaHang=@maHang
GO
/****** Object:  StoredProcedure [dbo].[updateHinhAnh]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[updateHinhAnh]
@img char(200) , @masp nvarchar(50)
as
update SanPham
set Image =@img
where MaSP=@masp
GO
/****** Object:  StoredProcedure [dbo].[UpdateKhachHang]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateKhachHang]
@maKH nchar(10) , @tenKH nvarchar(200) ,@diaChi nvarchar(50) , @sdt int
as 
   if exists(select * from KhachHang Where MaKH=@maKH)
     begin
	   update KhachHang
	   set TenKH=@tenKH , DiaChi =@diaChi , SDT=@sdt
	   where MaKH =@maKH
	   print N'Update Success'
	 end
	 else
	  print N'Update Fail'
GO
/****** Object:  StoredProcedure [dbo].[UpdateLogo]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[UpdateLogo]
@anh nvarchar(200),@maNCC nchar(10)
as
   begin
       update Supplier
	   set HinhAnh=@anh
	   where MaNCC =@maNCC
   end
GO
/****** Object:  StoredProcedure [dbo].[UpdateNCC]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[UpdateNCC]
@maNCC nchar(10) , @tenNCC nvarchar(100) , @diaChi nvarchar(100), @sdt nchar(50) ,@hang nchar(10)
as
if exists(select * from Supplier where MaNCC = @maNCC)
  begin
       update Supplier
	   set TenNCC=@tenNCC , DiaChi =@diaChi , SDT=@sdt ,Hang =@hang
	   Where MaNCC =@maNCC
	      print N'Update Success'
  end
  else
    print N'Update Fail'
GO
/****** Object:  StoredProcedure [dbo].[updateSanPham]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateSanPham]
@masp nvarchar(10),@tensp nvarchar(50),@dongia int,@soluong int
as
update SanPham
set TenSP=@tensp ,DonGia=@dongia,Soluong=@soluong
where MaSP=@masp
GO
/****** Object:  StoredProcedure [dbo].[UpdateSoLuongKho]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[UpdateSoLuongKho]
  @soluong int , @masp nchar(10)
  as
    begin
	  update NhapKho
	  set Soluong =@soluong
	  where MaSP =@masp
	end
GO
/****** Object:  StoredProcedure [dbo].[UpdateSPKho]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateSPKho]
@masp nvarchar(10),@tensp nvarchar(50) , @soluong int, @dongia int , @maNCC nvarchar(10)

as
begin
  update NhapKho
  set TenSP =@tensp , Soluong =@soluong , DonGia =@dongia , MaNCC =@maNCC
  where MaSP=@masp
end
GO
/****** Object:  StoredProcedure [dbo].[updateThongKe]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[updateThongKe]
 @date nchar(50) , @value int , @soluong int ,@price int ,@valMonth int
  as
  begin
    update ThongKe
	set  Value =@value , SoLuong=@soluong , Price =@price ,ValueMonth =@valMonth
	where Date =@date
	end
GO
/****** Object:  StoredProcedure [dbo].[UpdateUser]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateUser]
@MaNV nchar(50) , @user nchar(50) , @pass nchar(200)
as
   begin
   update AccountUser
   set PassWord=@pass ,UserName =@user
   where MaUser =@MaNV
   end
GO
/****** Object:  StoredProcedure [dbo].[usp_AccountUser]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_AccountUser]
 @username nvarchar(100) , @password nvarchar(100)
as
begin
     select * from AccountUser Where UserName=@username and PassWord =@password
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Del_ChitietHoaDon]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Del_ChitietHoaDon]
@maHD int
as
begin
  delete
  from ChiTietHoaDon
  where MaHD = @maHD
end
GO
/****** Object:  StoredProcedure [dbo].[usp_deleteAllGioHang]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_deleteAllGioHang]
as
begin
  Delete
  from GioHang
end
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteAllHoaDon]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_DeleteAllHoaDon]

as
begin
  delete
  from HoaDon 
  
end
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteGioHang]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_DeleteGioHang]
@masp nchar(10) ,@size nchar(10) ,@color nchar(10) , @soluong nchar(10)
as
  begin
    delete
	from GioHang
	Where MaSP =@masp and Size =@size and Color =@color and SoLuong =@soluong
  end
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteHoaDon]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_DeleteHoaDon]
@maHD int
as
begin
  delete
  from HoaDon
  where MaHD =@maHD
end
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteSanPham]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_DeleteSanPham]
@masp nvarchar(10)
as
 if exists(select * from SanPham Where MaSP =@masp)
	begin
   delete 
   from  SanPham 
   where MaSP =@masp
     delete 
   from  ThongTinSP 
   where MaSP =@masp
    print N'Delete sản phẩm Thành công'
end
else
     print N'Delete sản phẩm Thất bại'
GO
/****** Object:  StoredProcedure [dbo].[usp_fillDate]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_fillDate]
@ngay int , @thang int , @nam int
as
begin
       
    select * 
	from NhapKho
	where DAY(NgayNhap) = @ngay or MONTH(NgayNhap) =@thang and YEAR(NgayNhap) = @nam
end
GO
/****** Object:  StoredProcedure [dbo].[usp_fillDateHoaDon]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_fillDateHoaDon]
@ngay int , @thang int , @nam int
as
begin
       
    select * 
	from HoaDon
	where DAY(NgayBan) = @ngay or MONTH(NgayBan) =@thang and YEAR(NgayBan) = @nam
	
end
GO
/****** Object:  StoredProcedure [dbo].[usp_fillDateKhachHang]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_fillDateKhachHang]
@ngay int , @thang int , @nam int
as
begin
       
    select * 
	from KhachHang
	where DAY(NgayMua) = @ngay or MONTH(NgayMua) =@thang and YEAR(NgayMua) = @nam
end
GO
/****** Object:  StoredProcedure [dbo].[usp_fillDateThongke]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_fillDateThongke]
@ngay int , @thang int , @nam int
as
begin
       
    select * 
	from ThongKe
	where DAY(Date) = @ngay or MONTH(Date) =@thang and YEAR(Date) = @nam
	
end
GO
/****** Object:  StoredProcedure [dbo].[usp_fillMaHang]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_fillMaHang]

@tenHang nchar(10)

as
begin
      select A.MaSP , A.TenSP, A.DonGia,A.Soluong,A.MaHang,A.Image
	  from SanPham A , Hang B 
	  Where A.MaHang =B.MaHang and B.TenHang =@tenHang
end
GO
/****** Object:  StoredProcedure [dbo].[usp_fillNamThongke]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_fillNamThongke]
 @nam int
as
begin
       
    select * 
	from ThongKe
	where   YEAR(Date) = @nam
	
end
GO
/****** Object:  StoredProcedure [dbo].[usp_FillSP]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_FillSP]
as
begin

select *
from NhapKho
order by MaSP ASC ,DonGia ASC
end
GO
/****** Object:  StoredProcedure [dbo].[usp_fillThangThongke]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_fillThangThongke]
@thang int , @nam int
as
begin
       
    select * 
	from ThongKe
	where  MONTH(Date) =@thang and YEAR(Date) = @nam
	
end
GO
/****** Object:  StoredProcedure [dbo].[usp_insert_GioHang]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_insert_GioHang]
@masp nchar(10) , @tensp nvarchar(50) , @size nchar(10) , @color nchar(10) , @soluong nchar(10) , @gia int

as
   begin
      insert into GioHang values(@masp,@tensp,@size,@color,@soluong,@gia)
   end
GO
/****** Object:  StoredProcedure [dbo].[usp_insertNhanVien]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_insertNhanVien]

  @maNV nchar(10) , @tenNV nvarchar(50) , @gioiTinh nvarchar(10) , @diaChi nvarchar(50) , @ntn nchar(50) , @hinhAnh nvarchar(200) ,@sdt nchar(200)

  as
    if exists(select * from NhanVien Where MaNV =@maNV) or exists (select * from NhanVien where HinhAnh =@hinhanh)
	   print N'Đã có Mã NV trong DS hoặc ten image trùng' 
	else
	   begin
	      insert into NhanVien values(@maNV,@tenNV,@gioiTinh,@diaChi,@ntn,@hinhAnh,@sdt)
		   print N'Thêm Nhân Viên Thành Công'
	   end
GO
/****** Object:  StoredProcedure [dbo].[usp_insertNVFrom_SignUp]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_insertNVFrom_SignUp]

  @maNV nchar(10) , @tenNV nvarchar(50) , @gioiTinh nvarchar(10) , @diaChi nvarchar(50) , @ntn nchar(50) ,@sdt nchar(200)

  as
    if exists(select * from NhanVien Where MaNV =@maNV)
	   print N'Đã có Mã NV trong DS ' 
	else
	   begin
	      insert into NhanVien values(@maNV,@tenNV,@gioiTinh,@diaChi,@ntn,null,@sdt)
		   print N'Thêm Nhân Viên Thành Công'
	   end
GO
/****** Object:  StoredProcedure [dbo].[usp_KQPriceYear]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	   create proc [dbo].[usp_KQPriceYear]
  @nam int
  as
      if exists (select * from ThongKe where YEAR(Date) =@nam )
	  begin
     select sum(Price)
	 from ThongKe
	 where  YEAR(Date) =@nam 	
	 end
	 else
	   print N'Không có Thắng cần tìm'
GO
/****** Object:  StoredProcedure [dbo].[usp_LayThongTinSPTheoMa]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_LayThongTinSPTheoMa]
 @masp nvarchar(10) ,  @size nvarchar(10)
as
begin
    select  Color
	from ThongTinSP 
	where MaSP=@masp and  Size =@size;
end
GO
/****** Object:  StoredProcedure [dbo].[usp_loadindSize]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_loadindSize]
@masp nvarchar(10)

as
begin
select distinct  Size
from ThongTinSP
Where MaSP =@masp
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Loading_Sp_Theo_MS]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Loading_Sp_Theo_MS]
@masp nvarchar(50)
as
begin
select *
from ThongTinSP
where MaSP = @masp
end
GO
/****** Object:  StoredProcedure [dbo].[usp_LoadingChiTietHoaDon_Ma]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_LoadingChiTietHoaDon_Ma]
@maHD int
as
begin
select B.MaSP ,B.TenSP ,B.Size,B.Color,B.SoLuong,B.Gia ,B.TenNV,B.TenKH
from HoaDon A ,ChiTietHoaDon B
where A.MaHD =B.MaHD and A.MaHD=@maHD;
end
GO
/****** Object:  StoredProcedure [dbo].[usp_loadingMaHang]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_loadingMaHang]

as

begin
   select * from Hang
end
GO
/****** Object:  StoredProcedure [dbo].[usp_LoadingSP]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_LoadingSP]

as
 begin
 select * from SanPham
 end
GO
/****** Object:  StoredProcedure [dbo].[usp_Them_HoaDon]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Them_HoaDon]
@maHD int , @tenKH nvarchar (50) ,@tenNV nvarchar(50) , @ntn nchar (20) ,@tongGia int

as
if exists(select * from HoaDon Where MaHD =@maHD)
 print N'Đã có Mã trùng'
 else
 begin
   insert into HoaDon values(@maHD,@tenKH,@tenNV,@ntn,@tongGia)
    print N'Thêm Hóa Đơn Thành công'
 end
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemChiTiet_HoaDon]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[usp_ThemChiTiet_HoaDon]
 @maHd nchar(10) ,@masp nchar(10) ,@tensp nvarchar(50) , @size nchar(10) ,@color nchar(10) ,@soluong nchar(10) , @gia int , @tenNV nvarchar(200) , @tenKH nvarchar(200)
 as
   if exists ( select * from HoaDon where MaHD =@maHd)
     
	 begin
	 insert into ChiTietHoaDon values (@maHd,@masp,@tensp,@size,@color,@soluong,@gia,@tenNV,@tenKH)
	    print N'Thêm Chi Tiết Hóa đơn Success'
		end
	else
		 print N'Thêm Fail'
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemKho]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_ThemKho]
 
 @masp nvarchar(10) , @tensp nvarchar(50) ,@ntn Datetime , @soluong int, @maNCC nvarchar(10),@gia int

 as

  if exists(select * from NhapKho where MaSP = @masp)
      print N'Đã có sản phẩm có mã số ' +@masp+ N' trong CSDL! or mã nhà cung cấp trong CSDL!'
	  else
	  begin
	    if exists(select * from Supplier where MaNCC = @maNCC)
	     begin
		    	insert into NhapKho values (@masp,@tensp,@ntn,@soluong,@maNCC,@gia)  
				 print N'Thêm sản phẩm vào kho Thành công'
		 end
		 else
			 print N'Thêm sản phẩm Thất Bại'
       end
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemKhoHang]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_ThemKhoHang]
 
 @masp nvarchar(10) , @tensp nvarchar(50) ,@ntn Datetime , @soluong int, @maNCC nvarchar(10),@gia int

 as

  if exists(select * from NhapKho where MaSP = @masp)
      print N'Đã có sản phẩm có mã số ' +@masp+ N' trong CSDL! or mã nhà cung cấp trong CSDL!'
	  else
	     begin
		    	insert into NhapKho values (@masp,@tensp,@ntn,@soluong,@maNCC,@gia)  
				 print N'Thêm sản phẩm vào kho Thành công'
		 end
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemNCC]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_ThemNCC]

@maNCC nchar(10) , @tenNCC nvarchar(100) , @diaChi nvarchar(100), @sdt nchar(50) ,@hang nchar(10) ,@hinhAnh nvarchar(200)
as
	if exists(select * from Supplier where MaNCC = @maNCC)
	  print N'Đã Có Mã Nhà Cung cấp'
	  else
	  begin
          insert into Supplier values (@hinhAnh,@maNCC,@tenNCC,@diaChi,@sdt,@hang)
		  	  print N'Thêm Thành công!'
		end
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemSize_Color]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_ThemSize_Color]

@masp nvarchar(10) , @size nvarchar(10), @color nvarchar(10)
as
begin
update ThongTinSP
set  Size =@size , Color = @color
where MaSP=@masp
end
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemSize_Color_SanPham]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_ThemSize_Color_SanPham]
 
 @masp nchar(10) , @color nchar(10) ,@Size nchar(10)

 as

  if exists(select * from SanPham where MaSP = @masp)
	     begin
		    	insert into ThongTinSP values (@masp,@Size,@color)  
				 print N'Thêm Size Color sản phẩm Thành công'
		 end
		 else
		 print N'Thêm Size Color sản phẩm Fail'
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemSize_ColorVaoKho]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[usp_ThemSize_ColorVaoKho]
 @masp nvarchar(10) ,@size nvarchar(10),@color nvarchar(10)
 as
 begin
     insert into ThongTinSP values(@masp,@size,@color)
	  print N'Thêm size,color sản phẩm vào kho Thành công'
 end
   
GO
/****** Object:  StoredProcedure [dbo].[usp_ThongKePrice]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[usp_ThongKePrice]
  @thang int , @nam int

  as
      if exists (select * from ThongKe where Month(Date) =@thang and YEAR(Date) =@nam )
	  begin
     select sum(Price)
	 from ThongKe
	 where Month(Date) =@thang and YEAR(Date) =@nam 	
	 end
	 else
	   print N'Không có Thắng cần tìm'
GO
/****** Object:  StoredProcedure [dbo].[usp_ThongKePriceYear]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[usp_ThongKePriceYear]
  @nam int
  as
      if exists (select * from ThongKe where YEAR(Date) =@nam )
	  begin
     select sum(Price)
	 from ThongKe
	 where  YEAR(Date) =@nam 	
	 end
	 else
	   print N'Không có Thắng cần tìm'
GO
/****** Object:  StoredProcedure [dbo].[usp_timKiemAcc]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[usp_timKiemAcc]
	   @user nvarchar(200)
	   as
	 
	     select * 
		 from AccountUser
		 Where UserName like @user+'%'
GO
/****** Object:  StoredProcedure [dbo].[usp_TimKiemHD_ten]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_TimKiemHD_ten]
@tenKH nvarchar(200)
as
begin
    select * from HoaDon Where TenKH like @tenKH+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[usp_TimKiemSanPhamKho]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_TimKiemSanPhamKho]
@Tensp nvarchar (50)

as
   select * from NhapKho Where TenSP like @Tensp+'%'   
GO
/****** Object:  StoredProcedure [dbo].[usp_TinhTongGia_Giohang]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_TinhTongGia_Giohang]
as
  begin
   select sum(Gia)
   from GioHang
  end
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateAvartar_NV]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[usp_UpdateAvartar_NV]
@hinhanh nvarchar(200),@maNV nchar(10)
as
if exists (select * from NhanVien where HinhAnh =@hinhanh)
     print N'đã có tên Trùng'
	 else
   begin
       update NhanVien
	   set HinhAnh =@hinhanh
	   where MaNV =@maNV
	   print N'Update Success'
   end
GO
/****** Object:  StoredProcedure [dbo].[usp_updateNhanVien]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create proc [dbo].[usp_updateNhanVien]

 @maNV nchar(10) , @tenNV nvarchar(50) , @gioiTinh nvarchar(10) , @diaChi nvarchar(50) , @ntn nchar(50) ,@sdt nchar(200)

 as
   if exists(select * from NhanVien Where MaNV =@maNV)
	   begin
	       update NhanVien 
		   set TenNV=@tenNV , GioiTinh =@gioiTinh ,DiaChi=@diaChi,NgaySinh =@ntn ,Sdt =@sdt
		    
		   where MaNV=@maNV
		   print N'Update Thành Công'
	   end
	   else
	        print N'Update Fail!'
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateSanPham]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_UpdateSanPham]
@masp nchar(10) , @tensp nchar(50),@soluong int,@dongia int 
as
 if exists(select * from SanPham Where MaSP =@masp)
	begin  
     update SanPham
	 set  TenSP= @tensp , Soluong =@soluong , DonGia =@dongia
	 where MaSP =@masp
	 			 print N'Update sản phẩm Thành công'
		 end
		 else
		 print N'Update sản phẩm Thất bại'

GO
/****** Object:  StoredProcedure [dbo].[usp_updateThongKe]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_updateThongKe]
 @value int , @soluong int , @price int , @date nchar(50)
 as
   begin
     update ThongKe
	 set Value =@value , SoLuong =@soluong , Price =@price
	 where Date =@date

   end
GO
/****** Object:  StoredProcedure [dbo].[usp_valueThang]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_valueThang]
  @thang int , @nam int
as
 if exists(select * from ThongKe where  MONTH(Date) =@thang and YEAR(Date) = @nam )
begin
       
    select sum(ValMonth)
	from ThongKe
	where  MONTH(Date) =@thang and YEAR(Date) = @nam	
end
else
   print N'Không có Thông tin Tháng ,năm cần tìm'
GO
/****** Object:  StoredProcedure [dbo].[usp_valueYear]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[usp_valueYear]
  @nam int
as
begin
       
    select sum(ValYear)
	from ThongKe
	where  YEAR(Date) = @nam
	
end
GO
/****** Object:  StoredProcedure [dbo].[XoaSpTheoMa]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaSpTheoMa]
@masp nvarchar(10)
as
delete  
from SanPham 
where SanPham.MaSP = @masp
GO
/****** Object:  StoredProcedure [dbo].[XoaTTSPTheoMa]    Script Date: 9/7/2020 8:55:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaTTSPTheoMa]
@masp nvarchar(10)
as
delete  
from ThongTinSP 
where ThongTinSP.MaSP =@masp
GO
USE [master]
GO
ALTER DATABASE [QLBH] SET  READ_WRITE 
GO
