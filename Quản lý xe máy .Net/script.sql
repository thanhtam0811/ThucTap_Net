USE [master]
GO
/****** Object:  Database [QuanLyXeMay]    Script Date: 5/28/2023 7:25:49 PM ******/
CREATE DATABASE [QuanLyXeMay]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyXeMay', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QuanLyXeMay.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyXeMay_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QuanLyXeMay_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyXeMay] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyXeMay].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyXeMay] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyXeMay] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyXeMay] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyXeMay] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyXeMay] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyXeMay] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyXeMay] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyXeMay] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyXeMay] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyXeMay] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyXeMay] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyXeMay] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyXeMay] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyXeMay] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyXeMay] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyXeMay] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyXeMay] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyXeMay] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyXeMay] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyXeMay] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyXeMay] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyXeMay] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyXeMay] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyXeMay] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyXeMay] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyXeMay] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyXeMay] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyXeMay] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyXeMay] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyXeMay] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyXeMay] SET QUERY_STORE = OFF
GO
USE [QuanLyXeMay]
GO
/****** Object:  Table [dbo].[login]    Script Date: 5/28/2023 7:25:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[taikhoan] [nvarchar](50) NOT NULL,
	[matkhau] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[quyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_loginn] PRIMARY KEY CLUSTERED 
(
	[taikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Qlhanghoa]    Script Date: 5/28/2023 7:25:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Qlhanghoa](
	[mahang] [varchar](50) NOT NULL,
	[tenhang] [nvarchar](50) NULL,
	[nhasanxuat] [nvarchar](50) NULL,
	[mota] [nvarchar](50) NULL,
	[soluong] [int] NULL,
	[giaban] [float] NULL,
	[donvitinh] [nchar](10) NULL,
	[baohanh] [nvarchar](50) NULL,
 CONSTRAINT [PK_Qlhanghoa] PRIMARY KEY CLUSTERED 
(
	[mahang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Qlluong]    Script Date: 5/28/2023 7:25:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Qlluong](
	[maluong] [varchar](50) NOT NULL,
	[manv] [varchar](50) NULL,
	[hesoluong] [float] NULL,
	[tienluong] [float] NULL,
 CONSTRAINT [PK_Qlluong] PRIMARY KEY CLUSTERED 
(
	[maluong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Qlnhacungcap]    Script Date: 5/28/2023 7:25:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Qlnhacungcap](
	[mancc] [varchar](50) NOT NULL,
	[tenncc] [nvarchar](50) NULL,
	[diachincc] [nvarchar](50) NULL,
	[sodienthoaincc] [char](10) NULL,
	[emailncc] [nvarchar](50) NULL,
 CONSTRAINT [PK_Qlnhacungcap] PRIMARY KEY CLUSTERED 
(
	[mancc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Qlnhanvien]    Script Date: 5/28/2023 7:25:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Qlnhanvien](
	[manv] [varchar](50) NOT NULL,
	[tennv] [nvarchar](50) NULL,
	[gioitinh] [nvarchar](50) NULL,
	[namsinh] [date] NULL,
	[diachi] [nvarchar](50) NULL,
	[sodienthoai] [char](10) NULL,
	[email] [nvarchar](50) NULL,
	[chucvu] [nvarchar](50) NULL,
	[luongcoban] [float] NULL,
 CONSTRAINT [PK_Qlnhanvien] PRIMARY KEY CLUSTERED 
(
	[manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Qlnhap]    Script Date: 5/28/2023 7:25:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Qlnhap](
	[manhap] [varchar](50) NOT NULL,
	[manv] [varchar](50) NULL,
	[mahang] [varchar](50) NULL,
	[mancc] [varchar](50) NULL,
	[ngaynhap] [date] NULL,
	[soluongnhap] [int] NULL,
	[gianhap] [float] NULL,
	[thue] [float] NULL,
	[thanhtien] [float] NULL,
 CONSTRAINT [PK_Qlnhap] PRIMARY KEY CLUSTERED 
(
	[manhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Qlxuat]    Script Date: 5/28/2023 7:25:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Qlxuat](
	[maxuat] [varchar](50) NOT NULL,
	[mahang] [varchar](50) NULL,
	[tennv] [nvarchar](50) NULL,
	[ngayxuat] [date] NULL,
	[tenkh] [nvarchar](50) NULL,
	[soluongxuat] [int] NULL,
	[giaxuat] [float] NULL,
	[thue] [float] NULL,
	[thanhtien] [float] NULL,
 CONSTRAINT [PK_xuat] PRIMARY KEY CLUSTERED 
(
	[maxuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[login] ([taikhoan], [matkhau], [email], [quyen]) VALUES (N'admin', N'admin1', N'admin@gmail.com', N'admin')
INSERT [dbo].[login] ([taikhoan], [matkhau], [email], [quyen]) VALUES (N'datnguyen', N'datnguyen', N'dat@gmail.com', N'nhanvien')
INSERT [dbo].[login] ([taikhoan], [matkhau], [email], [quyen]) VALUES (N'nhanvien', N'nhanven1', N'nvv@gmail.com', N'nhanvien')
INSERT [dbo].[login] ([taikhoan], [matkhau], [email], [quyen]) VALUES (N'nhanvien1', N'nhanvien1', N'nhanvien1@gmail.com', N'nhanvien')
GO
INSERT [dbo].[Qlhanghoa] ([mahang], [tenhang], [nhasanxuat], [mota], [soluong], [giaban], [donvitinh], [baohanh]) VALUES (N'MH1', N'honda', N'vanminh', N'xanh', 1300, 2000000, N'vnd       ', N'1nam')
INSERT [dbo].[Qlhanghoa] ([mahang], [tenhang], [nhasanxuat], [mota], [soluong], [giaban], [donvitinh], [baohanh]) VALUES (N'MH10', N'sym', N'vanminh', N'do', 980, 5000000, N'vnd       ', N'1nam')
INSERT [dbo].[Qlhanghoa] ([mahang], [tenhang], [nhasanxuat], [mota], [soluong], [giaban], [donvitinh], [baohanh]) VALUES (N'MH11', N'bmw', N'vanminh', N'do', 979, 4600000, N'vnd       ', N'1nam')
INSERT [dbo].[Qlhanghoa] ([mahang], [tenhang], [nhasanxuat], [mota], [soluong], [giaban], [donvitinh], [baohanh]) VALUES (N'MH12', N'yadea', N'vanminh', N'do', 978, 3600000, N'vnd       ', N'1nam')
INSERT [dbo].[Qlhanghoa] ([mahang], [tenhang], [nhasanxuat], [mota], [soluong], [giaban], [donvitinh], [baohanh]) VALUES (N'MH13', N'niu', N'vanminh', N'do', 977, 3700000, N'vnd       ', N'1nam')
INSERT [dbo].[Qlhanghoa] ([mahang], [tenhang], [nhasanxuat], [mota], [soluong], [giaban], [donvitinh], [baohanh]) VALUES (N'MH14', N'vinfast', N'vanminh', N'do', 976, 3800000, N'vnd       ', N'1nam')
INSERT [dbo].[Qlhanghoa] ([mahang], [tenhang], [nhasanxuat], [mota], [soluong], [giaban], [donvitinh], [baohanh]) VALUES (N'MH15', N'harley-davidson', N'vanminh', N'do', 990, 4100000, N'vnd       ', N'1nam')
INSERT [dbo].[Qlhanghoa] ([mahang], [tenhang], [nhasanxuat], [mota], [soluong], [giaban], [donvitinh], [baohanh]) VALUES (N'MH16', N'SH', N'vanminh', N'do', 990, 4200000, N'vnd       ', N'1nam')
INSERT [dbo].[Qlhanghoa] ([mahang], [tenhang], [nhasanxuat], [mota], [soluong], [giaban], [donvitinh], [baohanh]) VALUES (N'MH17', N'winner', N'vanminh', N'do', 988, 4300000, N'vnd       ', N'1nam')
INSERT [dbo].[Qlhanghoa] ([mahang], [tenhang], [nhasanxuat], [mota], [soluong], [giaban], [donvitinh], [baohanh]) VALUES (N'MH18', N'super cup', N'vanminh', N'do', 988, 4400000, N'vnd       ', N'1nam')
INSERT [dbo].[Qlhanghoa] ([mahang], [tenhang], [nhasanxuat], [mota], [soluong], [giaban], [donvitinh], [baohanh]) VALUES (N'MH19', N'air blade', N'vanminh', N'do', 988, 4800000, N'vnd       ', N'1nam')
INSERT [dbo].[Qlhanghoa] ([mahang], [tenhang], [nhasanxuat], [mota], [soluong], [giaban], [donvitinh], [baohanh]) VALUES (N'MH2', N'yamaha', N'vanminh', N'do', 900, 3000000, N'vnd       ', N'1nam')
INSERT [dbo].[Qlhanghoa] ([mahang], [tenhang], [nhasanxuat], [mota], [soluong], [giaban], [donvitinh], [baohanh]) VALUES (N'MH20', N'exciter', N'vanminh', N'do', 987, 5100000, N'vnd       ', N'1nam')
INSERT [dbo].[Qlhanghoa] ([mahang], [tenhang], [nhasanxuat], [mota], [soluong], [giaban], [donvitinh], [baohanh]) VALUES (N'MH3', N'dream', N'vanminh', N'do', 990, 2500000, N'vnd       ', N'1nam')
INSERT [dbo].[Qlhanghoa] ([mahang], [tenhang], [nhasanxuat], [mota], [soluong], [giaban], [donvitinh], [baohanh]) VALUES (N'MH4', N'vision', N'vanminh', N'xanh', 970, 4000000, N'vnd       ', N'1nam')
INSERT [dbo].[Qlhanghoa] ([mahang], [tenhang], [nhasanxuat], [mota], [soluong], [giaban], [donvitinh], [baohanh]) VALUES (N'MH5', N'suzuki', N'vanminh', N'xanh', 970, 4000000, N'vnd       ', N'1nam')
INSERT [dbo].[Qlhanghoa] ([mahang], [tenhang], [nhasanxuat], [mota], [soluong], [giaban], [donvitinh], [baohanh]) VALUES (N'MH6', N'benelli', N'vanminh', N'xanh', 950, 3500000, N'vnd       ', N'1nam')
INSERT [dbo].[Qlhanghoa] ([mahang], [tenhang], [nhasanxuat], [mota], [soluong], [giaban], [donvitinh], [baohanh]) VALUES (N'MH7', N'ducati', N'vanminh', N'do', 955, 5000000, N'vnd       ', N'1nam')
INSERT [dbo].[Qlhanghoa] ([mahang], [tenhang], [nhasanxuat], [mota], [soluong], [giaban], [donvitinh], [baohanh]) VALUES (N'MH8', N'kawasaki', N'vanminh', N'do', 988, 45000000, N'vnd       ', N'1nam')
INSERT [dbo].[Qlhanghoa] ([mahang], [tenhang], [nhasanxuat], [mota], [soluong], [giaban], [donvitinh], [baohanh]) VALUES (N'MH9', N'Triumph', N'vanminh', N'tim', 985, 3500000, N'vnd       ', N'1nam')
GO
INSERT [dbo].[Qlluong] ([maluong], [manv], [hesoluong], [tienluong]) VALUES (N'ML1', N'NV1', 1.7, 3400000)
INSERT [dbo].[Qlluong] ([maluong], [manv], [hesoluong], [tienluong]) VALUES (N'ML10', N'NV10', 1.9, 3800000)
INSERT [dbo].[Qlluong] ([maluong], [manv], [hesoluong], [tienluong]) VALUES (N'ML2', N'NV2', 1.7, 3400000)
INSERT [dbo].[Qlluong] ([maluong], [manv], [hesoluong], [tienluong]) VALUES (N'ML3', N'NV4', 1.7, 3400000)
INSERT [dbo].[Qlluong] ([maluong], [manv], [hesoluong], [tienluong]) VALUES (N'ML4', N'NV3', 1.7, 3400000)
INSERT [dbo].[Qlluong] ([maluong], [manv], [hesoluong], [tienluong]) VALUES (N'ML5', N'NV5', 1.7, 3400000)
INSERT [dbo].[Qlluong] ([maluong], [manv], [hesoluong], [tienluong]) VALUES (N'ML6', N'NV6', 1.7, 3400000)
INSERT [dbo].[Qlluong] ([maluong], [manv], [hesoluong], [tienluong]) VALUES (N'ML7', N'NV7', 1.9, 3800000)
INSERT [dbo].[Qlluong] ([maluong], [manv], [hesoluong], [tienluong]) VALUES (N'ML8', N'NV8', 1.9, 3800000)
INSERT [dbo].[Qlluong] ([maluong], [manv], [hesoluong], [tienluong]) VALUES (N'ML9', N'NV9', 1.9, 3800000)
GO
INSERT [dbo].[Qlnhacungcap] ([mancc], [tenncc], [diachincc], [sodienthoaincc], [emailncc]) VALUES (N'MN1', N'honda', N'hanoi', N'0987654321', N'hon@gmail.com')
INSERT [dbo].[Qlnhacungcap] ([mancc], [tenncc], [diachincc], [sodienthoaincc], [emailncc]) VALUES (N'MN10', N'nozza', N'hanoi', N'0984374594', N'noz@gmail.com')
INSERT [dbo].[Qlnhacungcap] ([mancc], [tenncc], [diachincc], [sodienthoaincc], [emailncc]) VALUES (N'MN11', N'nozza1', N'hanoi', N'0984374576', N'noz1@gmail.com')
INSERT [dbo].[Qlnhacungcap] ([mancc], [tenncc], [diachincc], [sodienthoaincc], [emailncc]) VALUES (N'MN12', N'nozza2', N'hanoi', N'0984374578', N'noz2@gmail.com')
INSERT [dbo].[Qlnhacungcap] ([mancc], [tenncc], [diachincc], [sodienthoaincc], [emailncc]) VALUES (N'MN13', N'nozza3', N'hanoi', N'098437432 ', N'noz3@gmail.com')
INSERT [dbo].[Qlnhacungcap] ([mancc], [tenncc], [diachincc], [sodienthoaincc], [emailncc]) VALUES (N'MN14', N'nozza4', N'hanoi', N'098437483 ', N'noz4@gmail.com')
INSERT [dbo].[Qlnhacungcap] ([mancc], [tenncc], [diachincc], [sodienthoaincc], [emailncc]) VALUES (N'MN15', N'nozza5', N'hanoi', N'098437489 ', N'noz5@gmail.com')
INSERT [dbo].[Qlnhacungcap] ([mancc], [tenncc], [diachincc], [sodienthoaincc], [emailncc]) VALUES (N'MN16', N'nozza6', N'hanoi', N'098437443 ', N'noz6@gmail.com')
INSERT [dbo].[Qlnhacungcap] ([mancc], [tenncc], [diachincc], [sodienthoaincc], [emailncc]) VALUES (N'MN17', N'jupiter', N'laocai', N'043859483 ', N'jup@gmail.com')
INSERT [dbo].[Qlnhacungcap] ([mancc], [tenncc], [diachincc], [sodienthoaincc], [emailncc]) VALUES (N'MN18', N'jupiter1', N'laocai', N'043859432 ', N'jup1@gmail.com')
INSERT [dbo].[Qlnhacungcap] ([mancc], [tenncc], [diachincc], [sodienthoaincc], [emailncc]) VALUES (N'MN19', N'jupiter2', N'laocai', N'043859434 ', N'jup2@gmail.com')
INSERT [dbo].[Qlnhacungcap] ([mancc], [tenncc], [diachincc], [sodienthoaincc], [emailncc]) VALUES (N'MN2', N'yamaha', N'hanoi', N'0987654322', N'yah@gmail.com')
INSERT [dbo].[Qlnhacungcap] ([mancc], [tenncc], [diachincc], [sodienthoaincc], [emailncc]) VALUES (N'MN20', N'jupiter3', N'laocai', N'043859412 ', N'jup4@gmail.com')
INSERT [dbo].[Qlnhacungcap] ([mancc], [tenncc], [diachincc], [sodienthoaincc], [emailncc]) VALUES (N'MN3', N'suzuki', N'hochiminh', N'0987654323', N'suz@gmail.com')
INSERT [dbo].[Qlnhacungcap] ([mancc], [tenncc], [diachincc], [sodienthoaincc], [emailncc]) VALUES (N'MN4', N'dream', N'hochiminh', N'0987654324', N'dea@gmail.com')
INSERT [dbo].[Qlnhacungcap] ([mancc], [tenncc], [diachincc], [sodienthoaincc], [emailncc]) VALUES (N'MN5', N'ducati', N'hochiminh', N'0987654325', N'duc@gmail.com')
INSERT [dbo].[Qlnhacungcap] ([mancc], [tenncc], [diachincc], [sodienthoaincc], [emailncc]) VALUES (N'MN6', N'vision', N'hanoi', N'0987654326', N'vis@gmail.com')
INSERT [dbo].[Qlnhacungcap] ([mancc], [tenncc], [diachincc], [sodienthoaincc], [emailncc]) VALUES (N'MN7', N'piaggio', N'hanoi', N'0987654327', N'pia@gmail.com')
INSERT [dbo].[Qlnhacungcap] ([mancc], [tenncc], [diachincc], [sodienthoaincc], [emailncc]) VALUES (N'MN8', N'SYM', N'hanoi', N'0987654328', N'sym@gmail.com')
INSERT [dbo].[Qlnhacungcap] ([mancc], [tenncc], [diachincc], [sodienthoaincc], [emailncc]) VALUES (N'MN9', N'kawasaki', N'hanoi', N'0973648363', N'kaw@gmail.com')
GO
INSERT [dbo].[Qlnhanvien] ([manv], [tennv], [gioitinh], [namsinh], [diachi], [sodienthoai], [email], [chucvu], [luongcoban]) VALUES (N'NV1', N'dat', N'nam', CAST(N'2022-10-28' AS Date), N'nghean', N'0384938733', N'dat@gmail.com', N'Marketing', 2000000)
INSERT [dbo].[Qlnhanvien] ([manv], [tennv], [gioitinh], [namsinh], [diachi], [sodienthoai], [email], [chucvu], [luongcoban]) VALUES (N'NV10', N'huy', N'nam', CAST(N'2022-11-01' AS Date), N'nghean', N'0847586434', N'huy@gmail.com', N'Bảo vệ', 2000000)
INSERT [dbo].[Qlnhanvien] ([manv], [tennv], [gioitinh], [namsinh], [diachi], [sodienthoai], [email], [chucvu], [luongcoban]) VALUES (N'NV11', N'nhat', N'nam', CAST(N'2022-11-02' AS Date), N'nghean', N'0649373837', N'nhat@gmail.com', N'Bảo vệ', 2000000)
INSERT [dbo].[Qlnhanvien] ([manv], [tennv], [gioitinh], [namsinh], [diachi], [sodienthoai], [email], [chucvu], [luongcoban]) VALUES (N'NV12', N'yen', N'nu', CAST(N'2022-11-03' AS Date), N'hanoi', N'0839478473', N'yen@gmail.com', N'Nhân viên', 2000000)
INSERT [dbo].[Qlnhanvien] ([manv], [tennv], [gioitinh], [namsinh], [diachi], [sodienthoai], [email], [chucvu], [luongcoban]) VALUES (N'NV13', N'tung', N'nam', CAST(N'2022-11-04' AS Date), N'nghean', N'0384983738', N'tung@gmail.com', N'Marketing', 2000000)
INSERT [dbo].[Qlnhanvien] ([manv], [tennv], [gioitinh], [namsinh], [diachi], [sodienthoai], [email], [chucvu], [luongcoban]) VALUES (N'NV14', N'hai', N'nam', CAST(N'2022-11-05' AS Date), N'nghean', N'0384384848', N'hai@gmail.com', N'Tạp vụ', 2000000)
INSERT [dbo].[Qlnhanvien] ([manv], [tennv], [gioitinh], [namsinh], [diachi], [sodienthoai], [email], [chucvu], [luongcoban]) VALUES (N'NV15', N'hung', N'nam', CAST(N'2022-06-01' AS Date), N'nghean', N'0384739847', N'hung@gmail.com', N'Marketing', 2000000)
INSERT [dbo].[Qlnhanvien] ([manv], [tennv], [gioitinh], [namsinh], [diachi], [sodienthoai], [email], [chucvu], [luongcoban]) VALUES (N'NV16', N'khai', N'nam', CAST(N'2022-06-02' AS Date), N'nghean', N'0384739834', N'khai@gmail.com', N'Nhân viên', 2000000)
INSERT [dbo].[Qlnhanvien] ([manv], [tennv], [gioitinh], [namsinh], [diachi], [sodienthoai], [email], [chucvu], [luongcoban]) VALUES (N'NV17', N'cuong', N'nam', CAST(N'2022-06-03' AS Date), N'nghean', N'0384739826', N'cuongi@gmail.com', N'Tạp vụ', 2000000)
INSERT [dbo].[Qlnhanvien] ([manv], [tennv], [gioitinh], [namsinh], [diachi], [sodienthoai], [email], [chucvu], [luongcoban]) VALUES (N'NV18', N'nguyenvanA', N'nam', CAST(N'2022-06-05' AS Date), N'nghean', N'098648364 ', N'aaa@gmail.com', N'Nhân viên', 3000000)
INSERT [dbo].[Qlnhanvien] ([manv], [tennv], [gioitinh], [namsinh], [diachi], [sodienthoai], [email], [chucvu], [luongcoban]) VALUES (N'NV2', N'hoang', N'nam', CAST(N'2022-10-27' AS Date), N'nghean', N'0384938734', N'hoang@gmail.com', N'Marketing', 2000000)
INSERT [dbo].[Qlnhanvien] ([manv], [tennv], [gioitinh], [namsinh], [diachi], [sodienthoai], [email], [chucvu], [luongcoban]) VALUES (N'NV3', N'chien', N'nam', CAST(N'2022-10-26' AS Date), N'hanoi', N'0384938735', N'chien@gmail.com', N'Bảo vệ', 2000000)
INSERT [dbo].[Qlnhanvien] ([manv], [tennv], [gioitinh], [namsinh], [diachi], [sodienthoai], [email], [chucvu], [luongcoban]) VALUES (N'NV4', N'sang', N'nam', CAST(N'2022-10-25' AS Date), N'hanoi', N'0384938736', N'sang@gmail.com', N'Tạp vụ', 2000000)
INSERT [dbo].[Qlnhanvien] ([manv], [tennv], [gioitinh], [namsinh], [diachi], [sodienthoai], [email], [chucvu], [luongcoban]) VALUES (N'NV5', N'huu', N'nam', CAST(N'2022-10-24' AS Date), N'nghean', N'0384938737', N'huu@gmail.com', N'Tạp vụ', 2000000)
INSERT [dbo].[Qlnhanvien] ([manv], [tennv], [gioitinh], [namsinh], [diachi], [sodienthoai], [email], [chucvu], [luongcoban]) VALUES (N'NV6', N'my', N'nu', CAST(N'2022-10-24' AS Date), N'nghean', N'0384938738', N'my1@gmail.com', N'Marketing', 2000000)
INSERT [dbo].[Qlnhanvien] ([manv], [tennv], [gioitinh], [namsinh], [diachi], [sodienthoai], [email], [chucvu], [luongcoban]) VALUES (N'NV7', N'trang', N'nu', CAST(N'2022-10-23' AS Date), N'nghean', N'0384938739', N'trang@gmail.com', N'Marketing', 2000000)
INSERT [dbo].[Qlnhanvien] ([manv], [tennv], [gioitinh], [namsinh], [diachi], [sodienthoai], [email], [chucvu], [luongcoban]) VALUES (N'NV8', N'chau', N'nam', CAST(N'2022-10-22' AS Date), N'nghean', N'0384938740', N'chau@gmail.com', N'Bảo vệ', 2000000)
INSERT [dbo].[Qlnhanvien] ([manv], [tennv], [gioitinh], [namsinh], [diachi], [sodienthoai], [email], [chucvu], [luongcoban]) VALUES (N'NV9', N'khanh', N'nam', CAST(N'2022-10-21' AS Date), N'nghean', N'0384938741', N'khanh@gmail.com', N'Nhân viên', 2000000)
GO
INSERT [dbo].[Qlnhap] ([manhap], [manv], [mahang], [mancc], [ngaynhap], [soluongnhap], [gianhap], [thue], [thanhtien]) VALUES (N'PN1', N'NV1', N'MH1', N'MN1', CAST(N'2022-11-08' AS Date), 1000, 2000000, 10, 2200000000)
INSERT [dbo].[Qlnhap] ([manhap], [manv], [mahang], [mancc], [ngaynhap], [soluongnhap], [gianhap], [thue], [thanhtien]) VALUES (N'PN10', N'NV1', N'MH10', N'MN10', CAST(N'2023-04-01' AS Date), 1000, 2000000, 10, 2200000000)
INSERT [dbo].[Qlnhap] ([manhap], [manv], [mahang], [mancc], [ngaynhap], [soluongnhap], [gianhap], [thue], [thanhtien]) VALUES (N'PN11', N'NV11', N'MH11', N'MN11', CAST(N'2023-01-03' AS Date), 1000, 1000000, 10, 1100000000)
INSERT [dbo].[Qlnhap] ([manhap], [manv], [mahang], [mancc], [ngaynhap], [soluongnhap], [gianhap], [thue], [thanhtien]) VALUES (N'PN12', N'NV12', N'MH12', N'MN12', CAST(N'2023-01-04' AS Date), 1000, 1000000, 10, 1100000000)
INSERT [dbo].[Qlnhap] ([manhap], [manv], [mahang], [mancc], [ngaynhap], [soluongnhap], [gianhap], [thue], [thanhtien]) VALUES (N'PN13', N'NV13', N'MH13', N'MN13', CAST(N'2023-01-05' AS Date), 1000, 1000000, 10, 1100000000)
INSERT [dbo].[Qlnhap] ([manhap], [manv], [mahang], [mancc], [ngaynhap], [soluongnhap], [gianhap], [thue], [thanhtien]) VALUES (N'PN14', N'NV14', N'MH14', N'MN14', CAST(N'2023-01-06' AS Date), 1000, 1000000, 10, 1100000000)
INSERT [dbo].[Qlnhap] ([manhap], [manv], [mahang], [mancc], [ngaynhap], [soluongnhap], [gianhap], [thue], [thanhtien]) VALUES (N'PN15', N'NV15', N'MH15', N'MN15', CAST(N'2023-01-07' AS Date), 1000, 1000000, 10, 1100000000)
INSERT [dbo].[Qlnhap] ([manhap], [manv], [mahang], [mancc], [ngaynhap], [soluongnhap], [gianhap], [thue], [thanhtien]) VALUES (N'PN16', N'NV16', N'MH16', N'MN16', CAST(N'2023-01-08' AS Date), 1000, 1000000, 10, 1100000000)
INSERT [dbo].[Qlnhap] ([manhap], [manv], [mahang], [mancc], [ngaynhap], [soluongnhap], [gianhap], [thue], [thanhtien]) VALUES (N'PN17', N'NV17', N'MH17', N'MN17', CAST(N'2023-01-09' AS Date), 1000, 1000000, 10, 1100000000)
INSERT [dbo].[Qlnhap] ([manhap], [manv], [mahang], [mancc], [ngaynhap], [soluongnhap], [gianhap], [thue], [thanhtien]) VALUES (N'PN2', N'NV2', N'MH2', N'MN2', CAST(N'2022-11-09' AS Date), 1000, 2000000, 10, 2200000000)
INSERT [dbo].[Qlnhap] ([manhap], [manv], [mahang], [mancc], [ngaynhap], [soluongnhap], [gianhap], [thue], [thanhtien]) VALUES (N'PN3', N'NV3', N'MH3', N'MN3', CAST(N'2022-11-10' AS Date), 1000, 2000000, 10, 2200000000)
INSERT [dbo].[Qlnhap] ([manhap], [manv], [mahang], [mancc], [ngaynhap], [soluongnhap], [gianhap], [thue], [thanhtien]) VALUES (N'PN4', N'NV4', N'MH4', N'MN4', CAST(N'2022-11-11' AS Date), 1000, 2000000, 10, 2200000000)
INSERT [dbo].[Qlnhap] ([manhap], [manv], [mahang], [mancc], [ngaynhap], [soluongnhap], [gianhap], [thue], [thanhtien]) VALUES (N'PN5', N'NV5', N'MH5', N'MN5', CAST(N'2022-11-12' AS Date), 1000, 2000000, 10, 2200000000)
INSERT [dbo].[Qlnhap] ([manhap], [manv], [mahang], [mancc], [ngaynhap], [soluongnhap], [gianhap], [thue], [thanhtien]) VALUES (N'PN6', N'NV6', N'MH6', N'MN6', CAST(N'2022-11-13' AS Date), 1000, 2000000, 10, 2200000000)
INSERT [dbo].[Qlnhap] ([manhap], [manv], [mahang], [mancc], [ngaynhap], [soluongnhap], [gianhap], [thue], [thanhtien]) VALUES (N'PN7', N'NV7', N'MH7', N'MN7', CAST(N'2022-11-14' AS Date), 1000, 2000000, 10, 2200000000)
INSERT [dbo].[Qlnhap] ([manhap], [manv], [mahang], [mancc], [ngaynhap], [soluongnhap], [gianhap], [thue], [thanhtien]) VALUES (N'PN8', N'NV8', N'MH8', N'MN8', CAST(N'2022-11-16' AS Date), 1000, 2000000, 10, 2200000000)
INSERT [dbo].[Qlnhap] ([manhap], [manv], [mahang], [mancc], [ngaynhap], [soluongnhap], [gianhap], [thue], [thanhtien]) VALUES (N'PN9', N'NV9', N'MH9', N'MN9', CAST(N'2022-11-16' AS Date), 1000, 2000000, 10, 2200000000)
GO
INSERT [dbo].[Qlxuat] ([maxuat], [mahang], [tennv], [ngayxuat], [tenkh], [soluongxuat], [giaxuat], [thue], [thanhtien]) VALUES (N'PX1', N'MH1', N'dat', CAST(N'2022-12-01' AS Date), N'khanh', 100, 2000000, 10, 220000000)
INSERT [dbo].[Qlxuat] ([maxuat], [mahang], [tennv], [ngayxuat], [tenkh], [soluongxuat], [giaxuat], [thue], [thanhtien]) VALUES (N'PX10', N'MH10', N'huy', CAST(N'2022-11-08' AS Date), N'ngoc', 20, 5000000, 10, 110000000)
INSERT [dbo].[Qlxuat] ([maxuat], [mahang], [tennv], [ngayxuat], [tenkh], [soluongxuat], [giaxuat], [thue], [thanhtien]) VALUES (N'PX11', N'MH11', N'nhat', CAST(N'2022-11-08' AS Date), N'yen', 21, 5000000, 10, 115500000)
INSERT [dbo].[Qlxuat] ([maxuat], [mahang], [tennv], [ngayxuat], [tenkh], [soluongxuat], [giaxuat], [thue], [thanhtien]) VALUES (N'PX12', N'MH12', N'yen', CAST(N'2022-11-09' AS Date), N'yen', 22, 5000000, 10, 121000000)
INSERT [dbo].[Qlxuat] ([maxuat], [mahang], [tennv], [ngayxuat], [tenkh], [soluongxuat], [giaxuat], [thue], [thanhtien]) VALUES (N'PX13', N'MH13', N'tung', CAST(N'2022-11-09' AS Date), N'hung', 23, 5000000, 10, 126500000)
INSERT [dbo].[Qlxuat] ([maxuat], [mahang], [tennv], [ngayxuat], [tenkh], [soluongxuat], [giaxuat], [thue], [thanhtien]) VALUES (N'PX14', N'MH14', N'hai', CAST(N'2022-11-09' AS Date), N'hung', 24, 5000000, 10, 132000000)
INSERT [dbo].[Qlxuat] ([maxuat], [mahang], [tennv], [ngayxuat], [tenkh], [soluongxuat], [giaxuat], [thue], [thanhtien]) VALUES (N'PX15', N'MH15', N'hung', CAST(N'2023-02-16' AS Date), N'hung', 10, 4100000, 10, 45100000)
INSERT [dbo].[Qlxuat] ([maxuat], [mahang], [tennv], [ngayxuat], [tenkh], [soluongxuat], [giaxuat], [thue], [thanhtien]) VALUES (N'PX16', N'MH16', N'khai', CAST(N'2023-02-16' AS Date), N'hung', 10, 4100000, 10, 45100000)
INSERT [dbo].[Qlxuat] ([maxuat], [mahang], [tennv], [ngayxuat], [tenkh], [soluongxuat], [giaxuat], [thue], [thanhtien]) VALUES (N'PX17', N'MH17', N'cuong', CAST(N'2022-11-08' AS Date), N'cuong', 12, 4300000, 10, 56760000)
INSERT [dbo].[Qlxuat] ([maxuat], [mahang], [tennv], [ngayxuat], [tenkh], [soluongxuat], [giaxuat], [thue], [thanhtien]) VALUES (N'PX18', N'MH18', N'ngocuong', CAST(N'2022-11-08' AS Date), N'ngocuong', 12, 4300000, 10, 56760000)
INSERT [dbo].[Qlxuat] ([maxuat], [mahang], [tennv], [ngayxuat], [tenkh], [soluongxuat], [giaxuat], [thue], [thanhtien]) VALUES (N'PX19', N'MH19', N'dinh', CAST(N'2022-11-17' AS Date), N'ngocuong', 12, 4300000, 10, 56760000)
INSERT [dbo].[Qlxuat] ([maxuat], [mahang], [tennv], [ngayxuat], [tenkh], [soluongxuat], [giaxuat], [thue], [thanhtien]) VALUES (N'PX2', N'MH2', N'hoang', CAST(N'2022-12-02' AS Date), N'chau', 100, 2000000, 10, 220000000)
INSERT [dbo].[Qlxuat] ([maxuat], [mahang], [tennv], [ngayxuat], [tenkh], [soluongxuat], [giaxuat], [thue], [thanhtien]) VALUES (N'PX20', N'MH20', N'hoang', CAST(N'2022-11-23' AS Date), N'ngocuong', 13, 4300000, 10, 61490000)
INSERT [dbo].[Qlxuat] ([maxuat], [mahang], [tennv], [ngayxuat], [tenkh], [soluongxuat], [giaxuat], [thue], [thanhtien]) VALUES (N'PX3', N'MH3', N'chien', CAST(N'2022-12-03' AS Date), N'Lananh', 10, 2000000, 10, 22000000)
INSERT [dbo].[Qlxuat] ([maxuat], [mahang], [tennv], [ngayxuat], [tenkh], [soluongxuat], [giaxuat], [thue], [thanhtien]) VALUES (N'PX4', N'MH4', N'sang', CAST(N'2022-12-04' AS Date), N'Sang', 30, 2000000, 10, 66000000)
INSERT [dbo].[Qlxuat] ([maxuat], [mahang], [tennv], [ngayxuat], [tenkh], [soluongxuat], [giaxuat], [thue], [thanhtien]) VALUES (N'PX5', N'MH5', N'huu', CAST(N'2022-12-05' AS Date), N'dat', 30, 2000000, 10, 66000000)
INSERT [dbo].[Qlxuat] ([maxuat], [mahang], [tennv], [ngayxuat], [tenkh], [soluongxuat], [giaxuat], [thue], [thanhtien]) VALUES (N'PX6', N'MH6', N'my', CAST(N'2022-12-05' AS Date), N'nhat', 50, 2000000, 10, 110000000)
INSERT [dbo].[Qlxuat] ([maxuat], [mahang], [tennv], [ngayxuat], [tenkh], [soluongxuat], [giaxuat], [thue], [thanhtien]) VALUES (N'PX7', N'MH7', N'trang', CAST(N'2022-12-06' AS Date), N'hiep', 45, 2000000, 10, 99000000)
INSERT [dbo].[Qlxuat] ([maxuat], [mahang], [tennv], [ngayxuat], [tenkh], [soluongxuat], [giaxuat], [thue], [thanhtien]) VALUES (N'PX8', N'MH8', N'chau', CAST(N'2022-12-07' AS Date), N'ngoc', 12, 2000000, 10, 26400000)
INSERT [dbo].[Qlxuat] ([maxuat], [mahang], [tennv], [ngayxuat], [tenkh], [soluongxuat], [giaxuat], [thue], [thanhtien]) VALUES (N'PX9', N'MH9', N'khanh', CAST(N'2022-12-08' AS Date), N'huy', 15, 2000000, 10, 33000000)
GO
ALTER TABLE [dbo].[Qlluong]  WITH CHECK ADD  CONSTRAINT [FK_Qlluong_Qlnhanvien] FOREIGN KEY([manv])
REFERENCES [dbo].[Qlnhanvien] ([manv])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Qlluong] CHECK CONSTRAINT [FK_Qlluong_Qlnhanvien]
GO
ALTER TABLE [dbo].[Qlnhap]  WITH CHECK ADD  CONSTRAINT [FK_Qlnhap_Qlhanghoa] FOREIGN KEY([mahang])
REFERENCES [dbo].[Qlhanghoa] ([mahang])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Qlnhap] CHECK CONSTRAINT [FK_Qlnhap_Qlhanghoa]
GO
ALTER TABLE [dbo].[Qlnhap]  WITH CHECK ADD  CONSTRAINT [FK_Qlnhap_Qlnhacungcap] FOREIGN KEY([mancc])
REFERENCES [dbo].[Qlnhacungcap] ([mancc])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Qlnhap] CHECK CONSTRAINT [FK_Qlnhap_Qlnhacungcap]
GO
ALTER TABLE [dbo].[Qlnhap]  WITH CHECK ADD  CONSTRAINT [FK_Qlnhap_Qlnhanvien] FOREIGN KEY([manv])
REFERENCES [dbo].[Qlnhanvien] ([manv])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Qlnhap] CHECK CONSTRAINT [FK_Qlnhap_Qlnhanvien]
GO
ALTER TABLE [dbo].[Qlxuat]  WITH CHECK ADD  CONSTRAINT [FK_Qlxuat_Qlhanghoa] FOREIGN KEY([mahang])
REFERENCES [dbo].[Qlhanghoa] ([mahang])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Qlxuat] CHECK CONSTRAINT [FK_Qlxuat_Qlhanghoa]
GO

/****** Object:  StoredProcedure [dbo].[them_hang]    Script Date: 5/28/2023 7:25:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[them_hang] (@maphieunhap varchar(50), @ngaynhap date, @tennv nvarchar(50), @tenncc nvarchar(50),@tenhang nvarchar(50), @soluongnhap int,@gianhap float,@thue float)
AS
BEGIN
	INSERT INTO Qlnhap
	VALUES (@maphieunhap, @ngaynhap, @tennv, @tenncc,@tenhang , @soluongnhap ,@gianhap ,@thue )
END
GO
/****** Object:  StoredProcedure [dbo].[themhang]    Script Date: 5/28/2023 7:25:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[themhang] (@maphieunhap varchar(20), @ngaynhap date, @tennv nvarchar(50), @tenncc nvarchar(50),@tenhang nvarchar(50), @soluongnhap int,@gianhap float,@thue float)
AS
BEGIN
	INSERT INTO Qlnhap
	VALUES (@maphieunhap, @ngaynhap, @tennv, @tenncc,@tenhang , @soluongnhap ,@gianhap ,@thue )
END
GO
USE [master]
GO
ALTER DATABASE [QuanLyXeMay] SET  READ_WRITE 
GO
