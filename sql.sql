USE [QLTV]
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ThongTinSach'

GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ThongTinSach'

GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ctpm'

GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ctpm'

GO
ALTER TABLE [dbo].[SinhVien] DROP CONSTRAINT [FK_SinhVien_Nganh]
GO
ALTER TABLE [dbo].[Sach] DROP CONSTRAINT [FK_Sach_TheLoai]
GO
ALTER TABLE [dbo].[Sach] DROP CONSTRAINT [FK_Sach_NhaXuatBan]
GO
ALTER TABLE [dbo].[PhieuMuon] DROP CONSTRAINT [FK_PhieuMuon_NhanVien]
GO
ALTER TABLE [dbo].[PhieuMuon] DROP CONSTRAINT [FK_PhieuMuon_HoiVien]
GO
ALTER TABLE [dbo].[Nganh] DROP CONSTRAINT [FK_Nganh_Khoa]
GO
ALTER TABLE [dbo].[HoiVien] DROP CONSTRAINT [FK_HoiVien_SinhVien]
GO
ALTER TABLE [dbo].[HoiVien] DROP CONSTRAINT [FK_HoiVien_LoaiHoiVien]
GO
ALTER TABLE [dbo].[ChiTietTacGia] DROP CONSTRAINT [FK_ChiTietTacGia_TacGia]
GO
ALTER TABLE [dbo].[ChiTietTacGia] DROP CONSTRAINT [FK_ChiTietTacGia_Sach]
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon] DROP CONSTRAINT [FK_ChiTietPhieuMuon_Sach]
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon] DROP CONSTRAINT [FK_ChiTietPhieuMuon_PhieuMuon]
GO
/****** Object:  View [dbo].[ThongTinSach]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
DROP VIEW [dbo].[ThongTinSach]
GO
/****** Object:  View [dbo].[main]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
DROP VIEW [dbo].[main]
GO
/****** Object:  View [dbo].[docgia]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
DROP VIEW [dbo].[docgia]
GO
/****** Object:  View [dbo].[ctpm]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
DROP VIEW [dbo].[ctpm]
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
DROP TABLE [dbo].[TheLoai]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
DROP TABLE [dbo].[TaiKhoan]
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
DROP TABLE [dbo].[TacGia]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
DROP TABLE [dbo].[SinhVien]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
DROP TABLE [dbo].[Sach]
GO
/****** Object:  Table [dbo].[RangBuoc]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
DROP TABLE [dbo].[RangBuoc]
GO
/****** Object:  Table [dbo].[PhieuMuon]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
DROP TABLE [dbo].[PhieuMuon]
GO
/****** Object:  Table [dbo].[NhaXuatBan]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
DROP TABLE [dbo].[NhaXuatBan]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
DROP TABLE [dbo].[NhanVien]
GO
/****** Object:  Table [dbo].[Nganh]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
DROP TABLE [dbo].[Nganh]
GO
/****** Object:  Table [dbo].[LoaiHoiVien]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
DROP TABLE [dbo].[LoaiHoiVien]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
DROP TABLE [dbo].[Khoa]
GO
/****** Object:  Table [dbo].[HoiVien]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
DROP TABLE [dbo].[HoiVien]
GO
/****** Object:  Table [dbo].[ChiTietTacGia]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
DROP TABLE [dbo].[ChiTietTacGia]
GO
/****** Object:  Table [dbo].[ChiTietPhieuMuon]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
DROP TABLE [dbo].[ChiTietPhieuMuon]
GO
USE [master]
GO
/****** Object:  Database [QLTV]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
DROP DATABASE [QLTV]
GO
/****** Object:  Database [QLTV]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
CREATE DATABASE [QLTV]
 GO
ALTER DATABASE [QLTV] SET COMPATIBILITY_LEVEL = 12/12/20180
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLTV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLTV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLTV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLTV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLTV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLTV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLTV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLTV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLTV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLTV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLTV] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLTV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLTV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLTV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLTV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLTV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLTV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLTV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLTV] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLTV] SET  MULTI_USER 
GO
ALTER DATABASE [QLTV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLTV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLTV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLTV] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLTV] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLTV]
GO
/****** Object:  Table [dbo].[ChiTietPhieuMuon]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuMuon](
	[MaCTPM] [nchar](10) NOT NULL,
	[MaS] [nchar](10) NULL,
	[MaPM] [nchar](10) NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_ChiTietPhieuMuon] PRIMARY KEY CLUSTERED 
(
	[MaCTPM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietTacGia]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietTacGia](
	[MaCTTG] [nchar](10) NOT NULL,
	[MaS] [nchar](10) NULL,
	[MaTG] [nchar](10) NULL,
	[Sluong] [int] NULL,
 CONSTRAINT [PK_ChiTietTacGia] PRIMARY KEY CLUSTERED 
(
	[MaCTTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoiVien]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoiVien](
	[MaHV] [nchar](10) NOT NULL,
	[MaSV] [nchar](10) NULL,
	[MaLoaiHV] [nchar](10) NULL,
	[NgayLapThe] [date] NULL,
	[TenHoiVien] [nvarchar](50) NULL,
	[SDT] [nchar](11) NULL,
	[DiaChi] [nvarchar](150) NULL,
	[Email] [nchar](100) NULL,
	[NgaySinh] [date] NULL,
	[CMND] [nchar](11) NULL,
	[GioiTinh] [bit] NULL,
 CONSTRAINT [PK_HoiViwn] PRIMARY KEY CLUSTERED 
(
	[MaHV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [nchar](10) NOT NULL,
	[TenKhoa] [nvarchar](50) NULL,
 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiHoiVien]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHoiVien](
	[MaLoaiHV] [nchar](10) NOT NULL,
	[TenLoaiHV] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiHoiVien] PRIMARY KEY CLUSTERED 
(
	[MaLoaiHV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nganh]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nganh](
	[MaNganh] [nchar](10) NOT NULL,
	[TenNganh] [nvarchar](50) NULL,
	[MaKhoa] [nchar](10) NULL,
 CONSTRAINT [PK_Nganh] PRIMARY KEY CLUSTERED 
(
	[MaNganh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNv] [nchar](10) NOT NULL,
	[TenNv] [nvarchar](100) NULL,
	[CMND] [nchar](11) NULL,
	[SDT] [nchar](11) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[GioiTinh] [bit] NULL,
	[NgaySinh] [date] NULL,
	[NgayVaoLam] [date] NULL,
	[Email] [nchar](100) NULL,
	[userid] [int] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaXuatBan]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaXuatBan](
	[MaNXB] [nchar](10) NOT NULL,
	[TenNXB] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhaXuatBan] PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuMuon]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuMuon](
	[MaPM] [nchar](10) NOT NULL,
	[MaHV] [nchar](10) NULL,
	[ThoiGianMuon] [date] NULL,
	[HanTraSach] [date] NULL,
	[Manv] [nchar](10) NULL,
 CONSTRAINT [PK_PhieuMuon] PRIMARY KEY CLUSTERED 
(
	[MaPM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RangBuoc]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RangBuoc](
	[marb] [nchar](10) NULL,
	[Tenrb] [nvarchar](100) NULL,
	[GiaTri] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sach]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaS] [nchar](10) NOT NULL,
	[TenSach] [nvarchar](50) NULL,
	[MaNXB] [nchar](10) NULL,
	[MaTG] [nchar](10) NULL,
	[MaTl] [nchar](10) NULL,
	[NamXuatBan] [int] NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[MaS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSv] [nchar](10) NOT NULL,
	[TenSv] [nvarchar](50) NULL,
	[MaNganh] [nchar](10) NULL,
	[NamHoc] [nchar](10) NULL,
	[SDT] [nchar](11) NULL,
	[DiaChi] [nvarchar](150) NULL,
	[Email] [nchar](100) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[MaTG] [nchar](10) NOT NULL,
	[TenTg] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK__TacGia__2725005481398ABA] PRIMARY KEY CLUSTERED 
(
	[MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[userid] [int] NOT NULL,
	[pass] [nchar](50) NULL,
	[role] [bit] NULL,
	[tentk] [nchar](50) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[MaTL] [nchar](10) NOT NULL,
	[TenTL] [nvarchar](50) NULL,
 CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED 
(
	[MaTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[ctpm]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ctpm]
AS
SELECT pm.MaPM, ctpm.MaCTPM, hv.TenHoiVien, pm.Manv, s.TenSach, s.TinhTrang, pm.ThoiGianMuon, pm.HanTraSach, hv.MaHV
FROM   dbo.PhieuMuon AS pm INNER JOIN
             dbo.ChiTietPhieuMuon AS ctpm ON pm.MaPM = ctpm.MaPM INNER JOIN
             dbo.Sach AS s ON s.MaS = ctpm.MaS INNER JOIN
             dbo.HoiVien AS hv ON hv.MaHV = pm.MaHV

GO
/****** Object:  View [dbo].[docgia]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[docgia] AS
SELECT hv.MaHV,hv.TenHoiVien,hv.gioitinh ,hv.DiaChi, hv.MaSV, hv.NgayLapThe,hv.NgaySinh, hv.SDT, hv.Email, lhv.TenLoaiHV, hv.CMND
FROM HoiVien hv INNER JOIN LoaiHoiVien lhv ON hv.MaLoaiHV = lhv.MaLoaiHV
GO
/****** Object:  View [dbo].[main]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[main] AS
SELECT  pm.MaPM,pm.ThoiGianMuon, hv.TenHoiVien, pm.Manv, s.TenSach, pm.HanTraSach, hv.MaHV
FROM PhieuMuon pm INNER JOIN ChiTietPhieuMuon ctpm ON pm.MaPM = ctpm.MaPM inner join Sach s on s.MaS = ctpm.MaS inner join HoiVien hv on hv.MaHV = pm.MaHV 

GO
/****** Object:  View [dbo].[ThongTinSach]    Script Date: 12/12/2018/12/12/2018/2018 10:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ThongTinSach]
AS
SELECT s.MaS, s.TenSach, s.NamXuatBan, nxb.TenNXB, tl.TenTL, tg.TenTg, s.TinhTrang
FROM   dbo.Sach AS s INNER JOIN
             dbo.NhaXuatBan AS nxb ON s.MaNXB = nxb.MaNXB INNER JOIN
             dbo.TheLoai AS tl ON s.MaTl = tl.MaTL INNER JOIN
             dbo.TacGia AS tg ON s.MaTG = tg.MaTG

GO
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaS], [MaPM], [TinhTrang]) VALUES (N'CTPM10    ', N'S1        ', N'PM7       ', 0)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaS], [MaPM], [TinhTrang]) VALUES (N'CTPM11    ', N'S1        ', N'PM7       ', 1)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaS], [MaPM], [TinhTrang]) VALUES (N'CTPM12/12/2018    ', N'S2        ', N'PM8       ', 1)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaS], [MaPM], [TinhTrang]) VALUES (N'CTPM13    ', N'S2        ', N'PM8       ', 0)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaS], [MaPM], [TinhTrang]) VALUES (N'CTPM14    ', N'S4        ', N'PM14      ', 0)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaS], [MaPM], [TinhTrang]) VALUES (N'CTPM15    ', N'S5        ', N'PM15      ', 0)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaS], [MaPM], [TinhTrang]) VALUES (N'CTPM16    ', N'S6        ', N'PM16      ', 1)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaS], [MaPM], [TinhTrang]) VALUES (N'CTPM17    ', N'S6        ', N'PM19      ', 1)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaS], [MaPM], [TinhTrang]) VALUES (N'CTPM18    ', N'S2        ', N'PM19      ', 1)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaS], [MaPM], [TinhTrang]) VALUES (N'CTPM19    ', N'S20       ', N'PM20      ', 0)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaS], [MaPM], [TinhTrang]) VALUES (N'CTPM2     ', N'S1        ', N'PM2       ', 0)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaS], [MaPM], [TinhTrang]) VALUES (N'CTPM20    ', N'S15       ', N'PM21      ', 0)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaS], [MaPM], [TinhTrang]) VALUES (N'CTPM21    ', N'S21       ', N'PM21      ', 0)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaS], [MaPM], [TinhTrang]) VALUES (N'CTPM22    ', N'S12/12/2018       ', N'PM22      ', 0)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaS], [MaPM], [TinhTrang]) VALUES (N'CTPM23    ', N'S2        ', N'PM23      ', 1)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaS], [MaPM], [TinhTrang]) VALUES (N'CTPM24    ', N'S10       ', N'PM23      ', NULL)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaS], [MaPM], [TinhTrang]) VALUES (N'CTPM25    ', N'S19       ', N'PM23      ', NULL)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaS], [MaPM], [TinhTrang]) VALUES (N'CTPM3     ', N'S2        ', N'PM3       ', 0)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaS], [MaPM], [TinhTrang]) VALUES (N'CTPM4     ', N'S4        ', N'PM1       ', 0)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaS], [MaPM], [TinhTrang]) VALUES (N'CTPM6     ', N'S4        ', N'PM5       ', 0)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaS], [MaPM], [TinhTrang]) VALUES (N'CTPM7     ', N'S1        ', N'PM6       ', 0)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaS], [MaPM], [TinhTrang]) VALUES (N'CTPM8     ', N'S1        ', N'PM6       ', 0)
INSERT [dbo].[HoiVien] ([MaHV], [MaSV], [MaLoaiHV], [NgayLapThe], [TenHoiVien], [SDT], [DiaChi], [Email], [NgaySinh], [CMND], [GioiTinh]) VALUES (N'DG1       ', N'15520441', N'LHV1      ', CAST(N'2018-11-22' AS Date), N'Lý Thiên Long', N'01664083308', N'Tân sơn', N'Nguyenhoangvu1176@gmail.com                                                                         ', NULL, N'1          ', 1)
INSERT [dbo].[HoiVien] ([MaHV], [MaSV], [MaLoaiHV], [NgayLapThe], [TenHoiVien], [SDT], [DiaChi], [Email], [NgaySinh], [CMND], [GioiTinh]) VALUES (N'DG10      ', N'15520441', N'LHV1      ', CAST(N'2018-12-20' AS Date), N'Phạm Văn Ngọc', N'12/12/20183        ', N'12/12/20183', N'12/12/20183                                                                                                 ', CAST(N'2009-11-18' AS Date), N'12/12/20183        ', 0)
INSERT [dbo].[HoiVien] ([MaHV], [MaSV], [MaLoaiHV], [NgayLapThe], [TenHoiVien], [SDT], [DiaChi], [Email], [NgaySinh], [CMND], [GioiTinh]) VALUES (N'DG11      ', N'15110112/12/20182 ', N'LHV1      ', CAST(N'2018-12-20' AS Date), N'Nguyễn Đình Long', N'12/12/20183        ', N'abc', N'abc                                                                                                 ', CAST(N'2009-11-18' AS Date), N'12/12/20183        ', 0)
INSERT [dbo].[HoiVien] ([MaHV], [MaSV], [MaLoaiHV], [NgayLapThe], [TenHoiVien], [SDT], [DiaChi], [Email], [NgaySinh], [CMND], [GioiTinh]) VALUES (N'DG2       ', N'151101097 ', N'LHV1      ', CAST(N'2018-12-19' AS Date), N'Võ Minh Quân', N'12/12/20183        ', N'abc', N'xyz                                                                                                 ', CAST(N'2009-11-18' AS Date), N'1          ', 1)
INSERT [dbo].[HoiVien] ([MaHV], [MaSV], [MaLoaiHV], [NgayLapThe], [TenHoiVien], [SDT], [DiaChi], [Email], [NgaySinh], [CMND], [GioiTinh]) VALUES (N'DG3       ', N'151101086 ', N'LHV2      ', CAST(N'2018-11-22' AS Date), N'Ngô Hồng Phúc', N'024520183', N'a', N'a                                                                                                   ', NULL, N'1          ', 0)
INSERT [dbo].[HoiVien] ([MaHV], [MaSV], [MaLoaiHV], [NgayLapThe], [TenHoiVien], [SDT], [DiaChi], [Email], [NgaySinh], [CMND], [GioiTinh]) VALUES (N'DG4       ', N'151101086 ', N'LHV2      ', CAST(N'2013-11-03' AS Date), N'Thái Nguyễn Duy Phương', N'024520183      ', N'a', N'a                                                                                                   ', NULL, N'1          ', NULL)
INSERT [dbo].[HoiVien] ([MaHV], [MaSV], [MaLoaiHV], [NgayLapThe], [TenHoiVien], [SDT], [DiaChi], [Email], [NgaySinh], [CMND], [GioiTinh]) VALUES (N'DG5       ', N'151101111 ', N'LHV1      ', CAST(N'2018-12-01' AS Date), N'Nguyễn Thị Trang', N'543        ', N'a', N'a                                                                                                   ', NULL, N'1          ', NULL)
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'KH&KTTT', N'Khoa học và kỹ thuật thông tin')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'NNA', N'Ngôn ngữ anh')
INSERT [dbo].[LoaiHoiVien] ([MaLoaiHV], [TenLoaiHV]) VALUES (N'LHV1', N'Vãng lai')
INSERT [dbo].[LoaiHoiVien] ([MaLoaiHV], [TenLoaiHV]) VALUES (N'LHV2', N'Khách quen')
INSERT [dbo].[Nganh] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'CNTT', N'Công nghệ thông tin', N'KH&KTTT')
INSERT [dbo].[Nganh] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'PM', N'Phần mềm', N'CNTT      ')
INSERT [dbo].[Nganh] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'SP', N'Sư phạm', N'NNA       ')
INSERT [dbo].[NhanVien] ([MaNv], [TenNv], [CMND], [SDT], [DiaChi], [GioiTinh], [NgaySinh], [NgayVaoLam], [Email], [userid]) VALUES (N'NV1       ', N'Lý Thiên Long', N'241611111  ', N'01664083308', N'tân sơn', 1, NULL, NULL, N'a                                                                                                   ', 1)
INSERT [dbo].[NhanVien] ([MaNv], [TenNv], [CMND], [SDT], [DiaChi], [GioiTinh], [NgaySinh], [NgayVaoLam], [Email], [userid]) VALUES (N'NV10      ', N'12/12/201832', N'241611111        ', N'12/12/20183        ', N'12/12/20183', 0, CAST(N'1999-11-11' AS Date), CAST(N'2018-12-20' AS Date), N'53                                                                                                 ', NULL)
INSERT [dbo].[NhanVien] ([MaNv], [TenNv], [CMND], [SDT], [DiaChi], [GioiTinh], [NgaySinh], [NgayVaoLam], [Email], [userid]) VALUES (N'NV11      ', N'abc', N'132        ', N'241611111        ', N'ád', 0, CAST(N'1995-11-01' AS Date), CAST(N'2017-11-30' AS Date), N'ád                                                                                                  ', NULL)
INSERT [dbo].[NhanVien] ([MaNv], [TenNv], [CMND], [SDT], [DiaChi], [GioiTinh], [NgaySinh], [NgayVaoLam], [Email], [userid]) VALUES (N'NV11      ', N'Nguyễn Đình Long', N'132        ', N'241611111        ', N'ád', 0, CAST(N'1995-11-01' AS Date), CAST(N'2017-11-30' AS Date), N'ád                                                                                                  ', 3)
INSERT [dbo].[NhanVien] ([MaNv], [TenNv], [CMND], [SDT], [DiaChi], [GioiTinh], [NgaySinh], [NgayVaoLam], [Email], [userid]) VALUES (N'NV3       ', N'Võ Thiên Sơn', N'241611111  ', N'09875412/12/2018371', N'333, Thạch lam, Tân phú', 0, CAST(N'1995-11-01' AS Date), CAST(N'2018-12-20' AS Date), N'a a                                                                                                 ', null)
INSERT [dbo].[NhanVien] ([MaNv], [TenNv], [CMND], [SDT], [DiaChi], [GioiTinh], [NgaySinh], [NgayVaoLam], [Email], [userid]) VALUES (N'NV4       ', N'Nguyễn Hoàng vũ', N'331829888  ', N'0901453675 ', N'19', 0, CAST(N'1995-11-01' AS Date), CAST(N'2018-12-20' AS Date), N'abc@gmail,com                                                                                       ', NULL)
INSERT [dbo].[NhanVien] ([MaNv], [TenNv], [CMND], [SDT], [DiaChi], [GioiTinh], [NgaySinh], [NgayVaoLam], [Email], [userid]) VALUES (N'NV5       ', N'abc', N'241611111      ', N'0901453675     ', N'ádasd', 0, CAST(N'1995-11-01' AS Date), CAST(N'2018-12-13' AS Date), N'a                                                                                                   ', NULL)
INSERT [dbo].[NhanVien] ([MaNv], [TenNv], [CMND], [SDT], [DiaChi], [GioiTinh], [NgaySinh], [NgayVaoLam], [Email], [userid]) VALUES (N'NV6       ', N'Nguyễn Hoàng Vũ', N'241611111  ', N'01664083308', N'tân sơn', 0, CAST(N'1995-11-01' AS Date), CAST(N'2018-12-20' AS Date), N'a                                                                                                   ', NULL)
INSERT [dbo].[NhanVien] ([MaNv], [TenNv], [CMND], [SDT], [DiaChi], [GioiTinh], [NgaySinh], [NgayVaoLam], [Email], [userid]) VALUES (N'NV7       ', N'tui', N'12/12/20183        ', N'12/12/20183        ', N'12/12/20183', 0, CAST(N'1995-11-01' AS Date), CAST(N'2018-12-20' AS Date), N'12/12/20183                                                                                                 ', NULL)
INSERT [dbo].[NhanVien] ([MaNv], [TenNv], [CMND], [SDT], [DiaChi], [GioiTinh], [NgaySinh], [NgayVaoLam], [Email], [userid]) VALUES (N'NV8       ', N'tui', N'12/12/20183        ', N'12/12/20183        ', N'tui', 0, CAST(N'1995-11-01' AS Date), CAST(N'2018-12-20' AS Date), N'tui                                                                                                 ', NULL)
INSERT [dbo].[NhanVien] ([MaNv], [TenNv], [CMND], [SDT], [DiaChi], [GioiTinh], [NgaySinh], [NgayVaoLam], [Email], [userid]) VALUES (N'NV9       ', N'Nguyễn Thị Thúy Loan', N'331564786  ', N'1          ', N'A', 0, CAST(N'1999-11-11' AS Date), CAST(N'2018-12-20' AS Date), N'sbc                                                                                                 ', NULL)
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB]) VALUES (N'NXB       ', N'bc')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB]) VALUES (N'NXB1      ', N'Kim đồng')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB]) VALUES (N'NXB10     ', N'Âm nhạc')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB]) VALUES (N'NXB11     ', N'No')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB]) VALUES (N'NXB06    ', N'abc')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB]) VALUES (N'NXB13     ', N'áda')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB]) VALUES (N'NXB15     ', N'bc')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB]) VALUES (N'NXB16     ', N'adasd')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB]) VALUES (N'NXB17     ', N'1312/12/20183')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB]) VALUES (N'NXB18     ', N'')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB]) VALUES (N'NXB19     ', N'')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB]) VALUES (N'NXB2      ', N'Văn học')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB]) VALUES (N'NXB3      ', N'Thanh niên')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB]) VALUES (N'NXB4      ', N'Phụ nữ')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB]) VALUES (N'NXB5      ', N'Lao động')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB]) VALUES (N'NXB6      ', N'Tri thức')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB]) VALUES (N'NXB7      ', N'Sân khấu')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB]) VALUES (N'NXB8      ', N'Nghệ thuật')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB]) VALUES (N'NXB9      ', N'Văn học')
INSERT [dbo].[PhieuMuon] ([MaPM], [MaHV], [ThoiGianMuon], [HanTraSach], [Manv]) VALUES (N'PM1       ', N'DG1       ', CAST(N'2018-12-12' AS Date), CAST(N'2018-12-24' AS Date), N'NV1       ')
INSERT [dbo].[PhieuMuon] ([MaPM], [MaHV], [ThoiGianMuon], [HanTraSach], [Manv]) VALUES (N'PM14      ', N'DG4       ', CAST(N'2018-12-19' AS Date), CAST(N'2018-12-24' AS Date), N'NV4       ')
INSERT [dbo].[PhieuMuon] ([MaPM], [MaHV], [ThoiGianMuon], [HanTraSach], [Manv]) VALUES (N'PM15      ', N'DG5       ', CAST(N'2018-12-19' AS Date), CAST(N'2018-12-24' AS Date), N'NV4       ')
INSERT [dbo].[PhieuMuon] ([MaPM], [MaHV], [ThoiGianMuon], [HanTraSach], [Manv]) VALUES (N'PM16      ', N'DG1       ', CAST(N'2018-12-19' AS Date), CAST(N'2018-12-24' AS Date), N'NV4       ')
INSERT [dbo].[PhieuMuon] ([MaPM], [MaHV], [ThoiGianMuon], [HanTraSach], [Manv]) VALUES (N'PM17      ', N'DG1       ', CAST(N'2018-12-19' AS Date), CAST(N'2018-12-24' AS Date), N'NV4       ')
INSERT [dbo].[PhieuMuon] ([MaPM], [MaHV], [ThoiGianMuon], [HanTraSach], [Manv]) VALUES (N'PM18      ', N'DG3       ', CAST(N'2018-12-20' AS Date), CAST(N'2018-12-25' AS Date), N'NV1       ')
INSERT [dbo].[PhieuMuon] ([MaPM], [MaHV], [ThoiGianMuon], [HanTraSach], [Manv]) VALUES (N'PM19      ', N'DG5       ', CAST(N'2018-12-20' AS Date), CAST(N'2018-12-25' AS Date), N'NV1       ')
INSERT [dbo].[PhieuMuon] ([MaPM], [MaHV], [ThoiGianMuon], [HanTraSach], [Manv]) VALUES (N'PM2       ', N'DG1       ', CAST(N'2018-12-18' AS Date), CAST(N'2018-12-18' AS Date), N'NV1       ')
INSERT [dbo].[PhieuMuon] ([MaPM], [MaHV], [ThoiGianMuon], [HanTraSach], [Manv]) VALUES (N'PM20      ', N'DG7       ', CAST(N'2018-12-20' AS Date), CAST(N'2018-12-25' AS Date), N'NV1       ')
INSERT [dbo].[PhieuMuon] ([MaPM], [MaHV], [ThoiGianMuon], [HanTraSach], [Manv]) VALUES (N'PM21      ', N'DG9       ', CAST(N'2018-12-20' AS Date), CAST(N'2018-12-25' AS Date), N'NV1       ')
INSERT [dbo].[PhieuMuon] ([MaPM], [MaHV], [ThoiGianMuon], [HanTraSach], [Manv]) VALUES (N'PM22      ', N'DG3       ', CAST(N'2018-12-20' AS Date), CAST(N'2018-12-25' AS Date), N'NV1       ')
INSERT [dbo].[PhieuMuon] ([MaPM], [MaHV], [ThoiGianMuon], [HanTraSach], [Manv]) VALUES (N'PM23      ', N'DG4       ', CAST(N'2018-12-20' AS Date), CAST(N'2018-12-25' AS Date), N'NV1       ')
INSERT [dbo].[PhieuMuon] ([MaPM], [MaHV], [ThoiGianMuon], [HanTraSach], [Manv]) VALUES (N'PM3       ', N'DG2       ', CAST(N'2018-12-18' AS Date), CAST(N'2018-12-18' AS Date), N'NV1       ')
INSERT [dbo].[PhieuMuon] ([MaPM], [MaHV], [ThoiGianMuon], [HanTraSach], [Manv]) VALUES (N'PM4       ', N'DG3       ', CAST(N'2018-12-18' AS Date), CAST(N'2018-12-18' AS Date), N'NV1       ')
INSERT [dbo].[PhieuMuon] ([MaPM], [MaHV], [ThoiGianMuon], [HanTraSach], [Manv]) VALUES (N'PM5       ', N'DG3       ', CAST(N'2018-12-18' AS Date), CAST(N'2018-12-18' AS Date), N'NV1       ')
INSERT [dbo].[PhieuMuon] ([MaPM], [MaHV], [ThoiGianMuon], [HanTraSach], [Manv]) VALUES (N'PM6       ', N'DG1       ', CAST(N'2018-12-18' AS Date), CAST(N'2018-12-18' AS Date), N'NV1       ')
INSERT [dbo].[PhieuMuon] ([MaPM], [MaHV], [ThoiGianMuon], [HanTraSach], [Manv]) VALUES (N'PM7       ', N'DG1       ', CAST(N'2018-12-19' AS Date), CAST(N'2018-12-19' AS Date), N'NV4       ')
INSERT [dbo].[PhieuMuon] ([MaPM], [MaHV], [ThoiGianMuon], [HanTraSach], [Manv]) VALUES (N'PM8       ', N'DG4       ', CAST(N'2018-12-19' AS Date), CAST(N'2018-12-24' AS Date), N'NV4       ')
INSERT [dbo].[RangBuoc] ([marb], [Tenrb], [GiaTri]) VALUES (N'RB1       ', N'số ngày tối đa được mượn sách', 5)
INSERT [dbo].[RangBuoc] ([marb], [Tenrb], [GiaTri]) VALUES (N'RB2       ', N'Số sách tối đa được mượn trong 1 ngày', 3)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S1        ', N'Đấu phá thương khung', N'NXB1      ', N'TG1       ', N'TL1       ', 2010, 1)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S10       ', N'Bách Hợp', N'NXB10     ', N'TG4       ', N'TL1       ', 2014, 0)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S11       ', N'Yêu em từ cái nhìn đầu tiên', N'NXB3      ', N'TG8       ', N'TL1       ', 2018, 1)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S12/12/2018       ', N'Ddu du ddu du', N'NXB5      ', N'TG2       ', N'TL3       ', 2018, 0)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S13       ', N'Tình yêu học', N'NXB4      ', N'TG3       ', N'TL8       ', 2018, 1)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S14       ', N'Chiến nào ma kia', N'NXB3      ', N'TG1       ', N'Tl2       ', 2018, 1)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S15       ', N'Cửu âm chân', N'NXB3      ', N'TG2       ', N'TL3       ', 2018, 0)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S16       ', N'Cửu dương thần công', N'NXB2      ', N'TG4       ', N'TL3       ', 2018, 1)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S17       ', N'Thần điêu hiệp lữ', N'NXB6      ', N'TG4       ', N'TL3       ', 1978, 1)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S18       ', N'Bánh trôi nước', N'NXB6      ', N'TG7       ', N'TL4       ', 2018, 1)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S19       ', N'Luât an ninh mạng', N'NXB6      ', N'TG8       ', N'TL9       ', 2011, 0)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S2        ', N'Thủy hử', N'NXB2      ', N'TG2       ', N'TL2       ', 2018, 1)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S20       ', N'Dế mèn phiêu lưu ký', N'NXB4      ', N'TG2       ', N'TL7       ', 2018, 0)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S21       ', N'Ỷ thiên đồ long ký', N'NXB6      ', N'TG2       ', N'TL3       ', 2018, 0)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S22       ', N'Tiếu ngạo giang hồ', N'NXB9      ', N'TG2       ', N'TL3       ', 2014, 1)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S23       ', N'Tuyết sơn phi hồ', N'NXB4      ', N'TG2       ', N'TL3       ', 2016, 1)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S24       ', N'Thiên long bát bộ', N'NXB4      ', N'TG2       ', N'TL1       ', 2018, 1)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S25       ', N'Truyện kiều', N'NXB5      ', N'TG4       ', N'TL1       ', 2018, 1)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S26       ', N'Tây Du Kí', N'NXB3      ', N'TG2       ', N'TL1       ', 2012/12/2018, 1)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S27       ', N'Hồng bàng', N'NXB3      ', N'TG4       ', N'TL1       ', 2018, 1)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S3        ', N'Họa bì', N'NXB2      ', N'TG3       ', N'TL1       ', 2013, 1)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S4        ', N'Tam quốc diễn nghĩa', N'NXB3      ', N'TG3       ', N'TL1       ', 2018, 0)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S5        ', N'Hồng lâu mộng', N'NXB1      ', N'TG3       ', N'TL1       ', 2018, 0)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S6        ', N'Đắc Nhân Tâm', N'NXB3      ', N'TG4       ', N'TL1       ', 2018, 1)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S7        ', N'Dế mèn phiêu lưu kí', N'NXB3      ', N'TG2       ', N'TL1       ', 2017, 1)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S8        ', N'Doreamon', N'NXB3      ', N'TG4       ', N'TL2       ', 2015, 1)
INSERT [dbo].[Sach] ([MaS], [TenSach], [MaNXB], [MaTG], [MaTl], [NamXuatBan], [TinhTrang]) VALUES (N'S9        ', N'Yêu em không anh', N'NXB2      ', N'TG9       ', N'TL9       ', 2018, 1)
INSERT [dbo].[SinhVien] ([MaSv], [TenSv], [MaNganh], [NamHoc], [SDT], [DiaChi], [Email]) VALUES (N'15520440 ', N'Lý Thiên Long', N'CNTT', N'2018      ', N'0987654321 ', N'Quận 4', N'15520440@gm.uit.edu.vn                                                                         ')
INSERT [dbo].[SinhVien] ([MaSv], [TenSv], [MaNganh], [NamHoc], [SDT], [DiaChi], [Email]) VALUES (N'15520434 ', N'Nguyễn Văn Ngọc', N'PM', N'2018      ', N'0987654321 ', N'Quận 4', N'15520434@gm.uit.edu.vn                                                                         ')
INSERT [dbo].[SinhVien] ([MaSv], [TenSv], [MaNganh], [NamHoc], [SDT], [DiaChi], [Email]) VALUES (N'15520497 ', N'Võ Minh Quân', N'PM', N'2018      ', N'0987654321 ', N'Quận 4', N'15520497@gm.uit.edu.vn                                                                         ')
INSERT [dbo].[SinhVien] ([MaSv], [TenSv], [MaNganh], [NamHoc], [SDT], [DiaChi], [Email]) VALUES (N'15520432 ', N'Ngô Hồng Phúc', N'PM', N'2018      ', N'0987654321 ', N'Quận 4', N'15520432@gm.uit.edu.vn                                                                         ')
INSERT [dbo].[SinhVien] ([MaSv], [TenSv], [MaNganh], [NamHoc], [SDT], [DiaChi], [Email]) VALUES (N'15520785 ', N'Nguyễn Hoàng Vũ', N'PM', N'2018      ', N'0987654321 ', N'Quận 4', N'15520785@gm.uit.edu.vn                                                                         ')
INSERT [dbo].[SinhVien] ([MaSv], [TenSv], [MaNganh], [NamHoc], [SDT], [DiaChi], [Email]) VALUES (N'15520134 ', N'Thái Nguyễn Duy Phương', N'PM', N'2018      ', N'0987654321 ', N'Quận 4', N'15520134@gm.uit.edu.vn                                                                         ')
INSERT [dbo].[SinhVien] ([MaSv], [TenSv], [MaNganh], [NamHoc], [SDT], [DiaChi], [Email]) VALUES (N'15520441 ', N'Nguyễn Đình Long', NULL,  N'2018' , NULL, NULL, NULL)
INSERT [dbo].[SinhVien] ([MaSv], [TenSv], [MaNganh], [NamHoc], [SDT], [DiaChi], [Email]) VALUES (N'15520698 ', N'Nguyễn Thị Trang', NULL, N'2018', NULL, NULL, NULL)

INSERT [dbo].[TacGia] ([MaTG], [TenTg]) VALUES (N'TG1       ', N'Nguyễn Quang Hải')
INSERT [dbo].[TacGia] ([MaTG], [TenTg]) VALUES (N'TG10      ', N'Tăng Nhật Tuệ')
INSERT [dbo].[TacGia] ([MaTG], [TenTg]) VALUES (N'TG11      ', N'Võ Khánh Vũ')
INSERT [dbo].[TacGia] ([MaTG], [TenTg]) VALUES (N'TG2       ', N'Võ Thiên Sơn')
INSERT [dbo].[TacGia] ([MaTG], [TenTg]) VALUES (N'TG3       ', N'Nguyễn Khánh Hoàng')
INSERT [dbo].[TacGia] ([MaTG], [TenTg]) VALUES (N'TG4       ', N'Tăng Ngọc Tuyền')
INSERT [dbo].[TacGia] ([MaTG], [TenTg]) VALUES (N'TG5       ', N'khánh sơn')
INSERT [dbo].[TacGia] ([MaTG], [TenTg]) VALUES (N'TG6       ', N'Nguyễn Văn Tạ')
INSERT [dbo].[TacGia] ([MaTG], [TenTg]) VALUES (N'TG7       ', N'Nguyễn Khánh Ngọc')
INSERT [dbo].[TacGia] ([MaTG], [TenTg]) VALUES (N'TG8       ', N'Trần Kim Anh')
INSERT [dbo].[TacGia] ([MaTG], [TenTg]) VALUES (N'TG9       ', N'Nguyễn Thị Thúy Loan')
INSERT [dbo].[TaiKhoan] ([userid], [pass], [role], [tentk]) VALUES (1, N'admin                                             ', 1, N'admin                                             ')
INSERT [dbo].[TaiKhoan] ([userid], [pass], [role], [tentk]) VALUES (2, N'thlong                                             ', 0, N'thlong                                               ')
INSERT [dbo].[TaiKhoan] ([userid], [pass], [role], [tentk]) VALUES (3, N'dlong                                               ', 0, N'dlong                                               ')

INSERT [dbo].[TheLoai] ([MaTL], [TenTL]) VALUES (N'TL1       ', N'Tiểu thuyết')
INSERT [dbo].[TheLoai] ([MaTL], [TenTL]) VALUES (N'TL10      ', N'Lịch sử')
INSERT [dbo].[TheLoai] ([MaTL], [TenTL]) VALUES (N'Tl2       ', N'Ngôn tình')
INSERT [dbo].[TheLoai] ([MaTL], [TenTL]) VALUES (N'TL3       ', N'Kiếm hiệp')
INSERT [dbo].[TheLoai] ([MaTL], [TenTL]) VALUES (N'TL4       ', N'Văn học')
INSERT [dbo].[TheLoai] ([MaTL], [TenTL]) VALUES (N'TL5       ', N'Toán học')
INSERT [dbo].[TheLoai] ([MaTL], [TenTL]) VALUES (N'TL6       ', N'Giải trí')
INSERT [dbo].[TheLoai] ([MaTL], [TenTL]) VALUES (N'TL7       ', N'Phiêu lưu')
INSERT [dbo].[TheLoai] ([MaTL], [TenTL]) VALUES (N'TL8       ', N'Nghiên cứu khoa học')
INSERT [dbo].[TheLoai] ([MaTL], [TenTL]) VALUES (N'TL9       ', N'Pháp luật')
ALTER TABLE [dbo].[ChiTietPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuMuon_PhieuMuon] FOREIGN KEY([MaPM])
REFERENCES [dbo].[PhieuMuon] ([MaPM])
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon] CHECK CONSTRAINT [FK_ChiTietPhieuMuon_PhieuMuon]
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuMuon_Sach] FOREIGN KEY([MaS])
REFERENCES [dbo].[Sach] ([MaS])
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon] CHECK CONSTRAINT [FK_ChiTietPhieuMuon_Sach]
GO
ALTER TABLE [dbo].[ChiTietTacGia]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietTacGia_Sach] FOREIGN KEY([MaS])
REFERENCES [dbo].[Sach] ([MaS])
GO
ALTER TABLE [dbo].[ChiTietTacGia] CHECK CONSTRAINT [FK_ChiTietTacGia_Sach]
GO
ALTER TABLE [dbo].[ChiTietTacGia]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietTacGia_TacGia] FOREIGN KEY([MaTG])
REFERENCES [dbo].[TacGia] ([MaTG])
GO
ALTER TABLE [dbo].[ChiTietTacGia] CHECK CONSTRAINT [FK_ChiTietTacGia_TacGia]
GO
ALTER TABLE [dbo].[HoiVien]  WITH CHECK ADD  CONSTRAINT [FK_HoiVien_LoaiHoiVien] FOREIGN KEY([MaLoaiHV])
REFERENCES [dbo].[LoaiHoiVien] ([MaLoaiHV])
GO
ALTER TABLE [dbo].[HoiVien] CHECK CONSTRAINT [FK_HoiVien_LoaiHoiVien]
GO
ALTER TABLE [dbo].[HoiVien]  WITH CHECK ADD  CONSTRAINT [FK_HoiVien_SinhVien] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSv])
GO
ALTER TABLE [dbo].[HoiVien] CHECK CONSTRAINT [FK_HoiVien_SinhVien]
GO
ALTER TABLE [dbo].[Nganh]  WITH CHECK ADD  CONSTRAINT [FK_Nganh_Khoa] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[Nganh] CHECK CONSTRAINT [FK_Nganh_Khoa]
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_HoiVien] FOREIGN KEY([MaHV])
REFERENCES [dbo].[HoiVien] ([MaHV])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PhieuMuon_HoiVien]
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_NhanVien] FOREIGN KEY([Manv])
REFERENCES [dbo].[NhanVien] ([MaNv])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PhieuMuon_NhanVien]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_NhaXuatBan] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NhaXuatBan] ([MaNXB])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_NhaXuatBan]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_TheLoai] FOREIGN KEY([MaTl])
REFERENCES [dbo].[TheLoai] ([MaTL])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_TheLoai]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Nganh] FOREIGN KEY([MaNganh])
REFERENCES [dbo].[Nganh] ([MaNganh])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Nganh]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[37] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12/12/2018
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "pm"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 212
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ctpm"
            Begin Extent = 
               Top = 207
               Left = 57
               Bottom = 404
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "s"
            Begin Extent = 
               Top = 405
               Left = 57
               Bottom = 602
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "hv"
            Begin Extent = 
               Top = 603
               Left = 57
               Bottom = 800
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ctpm'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ctpm'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[27] 2[14] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12/12/2018
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "s"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 212
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "nxb"
            Begin Extent = 
               Top = 207
               Left = 57
               Bottom = 350
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tl"
            Begin Extent = 
               Top = 351
               Left = 57
               Bottom = 494
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tg"
            Begin Extent = 
               Top = 495
               Left = 57
               Bottom = 638
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ThongTinSach'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ThongTinSach'
GO
USE [master]
GO
ALTER DATABASE [QLTV] SET  READ_WRITE 
GO
