USE [master]
GO
/****** Object:  Database [QuanLyKhachSan]    Script Date: 21/03/2023 1:59:59 CH ******/
CREATE DATABASE [QuanLyKhachSan]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyKhachSan', FILENAME = N'D:\Database\QuanLyKhachSan.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyKhachSan_log', FILENAME = N'D:\Database\QuanLyKhachSan_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QuanLyKhachSan] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyKhachSan].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyKhachSan] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyKhachSan] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyKhachSan] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyKhachSan] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyKhachSan] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyKhachSan] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyKhachSan] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyKhachSan] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyKhachSan] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyKhachSan] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyKhachSan] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyKhachSan] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyKhachSan', N'ON'
GO
ALTER DATABASE [QuanLyKhachSan] SET QUERY_STORE = ON
GO
ALTER DATABASE [QuanLyKhachSan] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QuanLyKhachSan]
GO
/****** Object:  User [sa1]    Script Date: 21/03/2023 2:00:00 CH ******/
CREATE USER [sa1] FOR LOGIN [sa1] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 21/03/2023 2:00:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[NgayNhanPhong] [datetime] NOT NULL,
	[NgayTraPhong] [datetime] NOT NULL,
	[Total] [money] NOT NULL,
	[Phong] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[NgayNhanPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 21/03/2023 2:00:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDV] [int] NOT NULL,
	[TenDV] [nvarchar](50) NOT NULL,
	[GiaDV] [money] NOT NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 21/03/2023 2:00:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] NOT NULL,
	[Total] [money] NOT NULL,
	[KH] [int] NOT NULL,
	[NV] [int] NOT NULL,
	[Phong] [int] NOT NULL,
	[DichVu] [int] NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 21/03/2023 2:00:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[SDT] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 21/03/2023 2:00:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[SDT] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 21/03/2023 2:00:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaP] [int] NOT NULL,
	[TenP] [nvarchar](50) NULL,
	[LoaiP] [int] NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[MaP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type]    Script Date: 21/03/2023 2:00:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type](
	[IDLP] [int] NOT NULL,
	[TenLP] [nvarchar](50) NULL,
	[GiaP] [money] NULL,
 CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED 
(
	[IDLP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHoaDon] ([NgayNhanPhong], [NgayTraPhong], [Total], [Phong]) VALUES (CAST(N'2023-03-08T12:30:00.000' AS DateTime), CAST(N'2023-03-09T12:00:00.000' AS DateTime), 2000000.0000, 101)
GO
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV]) VALUES (1, N'Mát-xa', 150000.0000)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV]) VALUES (2, N'Bữa sáng ', 75000.0000)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV]) VALUES (3, N'Bữa trưa', 100000.0000)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV]) VALUES (4, N'Bữa tối', 125000.0000)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV]) VALUES (5, N'Dọn phòng', 30000.0000)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV]) VALUES (6, N'Đồ ăn vặt', 50000.0000)
GO
INSERT [dbo].[HoaDon] ([MaHD], [Total], [KH], [NV], [Phong], [DichVu]) VALUES (1, 100.0000, 1, 1, 101, 1)
INSERT [dbo].[HoaDon] ([MaHD], [Total], [KH], [NV], [Phong], [DichVu]) VALUES (2, 200.0000, 2, 2, 201, 2)
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (1, N'Lê Tâm Hòa', N'0123412312', N'Dong Nai')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (2, N'Nguyễn Tấn Hợp', N'0975757994', N'477/40 Nguyễn Văn Công')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (3, N'Nguy?n Qu?c Tu?n Tú', N'01231231231', N'Hoc Mon')
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [DiaChi]) VALUES (1, N'Vũ Hoàng Phan', N'0908091530', N'Sai Gon')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [DiaChi]) VALUES (2, N'Lê Bằng', N'0123145211', N'Binh Thuan')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [DiaChi]) VALUES (3, N'Nguy?n Hoàng Gia Phú', N'038981237192', N'Hoc Mon')
GO
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [TinhTrang]) VALUES (101, N'Phòng 1 Tầng 1', 1, 1)
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [TinhTrang]) VALUES (102, N'Phòng 2 Tầng 1', 1, 0)
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [TinhTrang]) VALUES (103, N'Phòng 3 T?ng 1', 2, 1)
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [TinhTrang]) VALUES (201, N'Phòng 1 Tầng 2', 1, 1)
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [TinhTrang]) VALUES (202, N'Phòng 2 Tầng 2', 1, 0)
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [TinhTrang]) VALUES (203, N'Phòng 3 Tầng 2', 2, 0)
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [TinhTrang]) VALUES (301, N'Phòng 1 Tầng 3', 1, 0)
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [TinhTrang]) VALUES (302, N'Phòng 2 T?ng 3', 1, 0)
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [TinhTrang]) VALUES (303, N'Phòng 3 T?ng 3', 2, 1)
GO
INSERT [dbo].[Type] ([IDLP], [TenLP], [GiaP]) VALUES (1, N'Giường Đơn', 1000000.0000)
INSERT [dbo].[Type] ([IDLP], [TenLP], [GiaP]) VALUES (2, N'Giường Đôi', 1000000.0000)
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_Phong] FOREIGN KEY([Phong])
REFERENCES [dbo].[Phong] ([MaP])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_Phong]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_DichVu] FOREIGN KEY([DichVu])
REFERENCES [dbo].[DichVu] ([MaDV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_DichVu]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([KH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([NV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_Phong] FOREIGN KEY([Phong])
REFERENCES [dbo].[Phong] ([MaP])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_Phong]
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK_Phong_Type1] FOREIGN KEY([LoaiP])
REFERENCES [dbo].[Type] ([IDLP])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK_Phong_Type1]
GO
USE [master]
GO
ALTER DATABASE [QuanLyKhachSan] SET  READ_WRITE 
GO
