﻿CREATE DATABASE QLRP
GO

USE QLRP
GO

--drop database QLRP


CREATE TABLE NhanVien
(
	id VARCHAR(50) PRIMARY KEY,
	HoTen NVARCHAR(100) NOT NULL,
	NgaySinh DATE NOT NULL,
	DiaChi NVARCHAR(100),
	SDT VARCHAR(100),
	CMND INT NOT NULL Unique
)
GO

CREATE TABLE TaiKhoan
(
	UserName NVARCHAR(100) NOT NULL,
	Pass NVARCHAR(1000) NOT NULL,
	LoaiTK INT NOT NULL DEFAULT 2, -- 1:admin || 2:staff
	idNV VARCHAR(50) NOT NULL,

	FOREIGN KEY (idNV) REFERENCES dbo.NhanVien(ID)
)
GO

CREATE TABLE LoaiManHinh
(
	id VARCHAR(50) PRIMARY KEY,
	TenMH NVARCHAR(100) --2D || 3D || IMax
)
GO

CREATE TABLE PhongChieu
(
	id VARCHAR(50) PRIMARY KEY,
	TenPhong NVARCHAR(100) NOT NULL,
	idManHinh VARCHAR(50),
	SoChoNgoi INT NOT NULL,
	TinhTrang INT NOT NULL DEFAULT 1, -- 0:không hoạt động || 1:đang hoạt động
	SoHangGhe int not null,
	SoGheMotHang int not null,

	FOREIGN KEY (idManHinh) REFERENCES dbo.LoaiManHinh(id)
)
GO

CREATE TABLE Phim
(
	id varchar(50) PRIMARY KEY,
	TenPhim nvarchar(100) NOT NULL,
	MoTa nvarchar(1000) NULL,
	ThoiLuong float NOT NULL,
	NgayKhoiChieu date NOT NULL,
	NgayKetThuc date NOT NULL,
	SanXuat nvarchar(50) NOT NULL,
	DaoDien nvarchar(100) NULL,
	NamSX int NOT NULL,
)
GO

CREATE TABLE DinhDangPhim --Phim có hỗ trợ màn hình 3D hay IMax không?
(
	id varchar(50) NOT NULL primary key,
	idPhim VARCHAR(50) NOT NULL,
	idLoaiManHinh VARCHAR(50) NOT NULL,

	FOREIGN KEY (idPhim) REFERENCES dbo.Phim(id),
	FOREIGN KEY (idLoaiManHinh) REFERENCES dbo.LoaiManHinh,
)
GO

CREATE TABLE TheLoai
(
	id VARCHAR(50) PRIMARY KEY,
	TenTheLoai NVARCHAR(100) NOT NULL,
	MoTa NVARCHAR(100)
)
GO

CREATE TABLE PhanLoaiPhim --Quan hệ giữa Phim và LoaiPhim là quan hệ n-n
(
	idPhim VARCHAR(50) NOT NULL,
	idTheLoai VARCHAR(50) NOT NULL,

	FOREIGN KEY (idPhim) REFERENCES dbo.Phim(id),
	FOREIGN KEY (idTheLoai) REFERENCES dbo.TheLoai(id),

	CONSTRAINT PK_PhanLoaiPhim PRIMARY KEY(idPhim,idTheLoai)
)
GO

CREATE TABLE LichChieu
(
	id VARCHAR(50) PRIMARY KEY,
	ThoiGianChieu DATETIME NOT NULL,
	idPhong VARCHAR(50) NOT NULL,
	idDinhDang VARCHAR(50) NOT NULL,
	GiaVe Money NOT NULL

	FOREIGN KEY (idPhong) REFERENCES dbo.PhongChieu(id),
	FOREIGN KEY (idDinhDang) REFERENCES dbo.DinhDangPhim(id),

	--CONSTRAINT PK_LichChieu PRIMARY KEY(ngayChieu,gioChieu,idPhong) --Vì cùng 1 thời điểm có thể có nhiều phòng cùng hoạt động nên khóa chính phải là cả 3 cái
)
GO

CREATE TABLE KhachHang
(
	id VARCHAR(50) PRIMARY KEY,
	HoTen NVARCHAR(100) NOT NULL,
	NgaySinh DATE NOT NULL,
	DiaChi NVARCHAR(100),
	SDT VARCHAR(100),
	CMND INT NOT NULL Unique,
	DiemTichLuy int
)
GO

CREATE TABLE CheDoKM
(
	id VARCHAR(50) PRIMARY KEY,
	TenKM NVARCHAR NOT NULL,
	MoTa NVARCHAR,
	NgayBatDau DATE NOT NULL DEFAULT GETDATE(),
	NgayKetThuc DATE NOT NULL,
	DiemTichLuy int,
	TiSuatKM FLOAT NOT NULL
)
GO

CREATE TABLE Ve
(
	id int identity(1,1) PRIMARY KEY,
	LoaiVe INT  DEFAULT '0', --0: Vé người lớn || 1: Vé học sinh - sinh viên || 2: vé trẻ em
	idLichChieu VARCHAR(50),
	MaGheNgoi VARCHAR(50),
	LoaiGheNgoi INT NOT NULL,--0: Ghế Thường || 1: Ghế Vip
	idKhachHang VARCHAR(50),
	idCheDoKM VARCHAR(50),
	TrangThai INT NOT NULL DEFAULT '0', --0: 'Chưa Bán' || 1: 'Đã Bán'
	TienBanVe MONEY DEFAULT '0'

	FOREIGN KEY (idLichChieu) REFERENCES dbo.LichChieu(id),
	--FOREIGN KEY (idCheDoKM) REFERENCES dbo.CheDoKM(id),
	FOREIGN KEY (idKhachHang) REFERENCES dbo.KhachHang(id)
)
GO

<<<<<<< HEAD
update ve set GiaVe = 100000 where LoaiGheNgoi = 1

INSERT INTO dbo.NhanVien
( id, hoTen, ngaySinh, diaChi, CMND )
VALUES  
( 
	'NV00', -- id - int
	N'admin', -- hoTen - nvarchar(100)
	GETDATE(), -- ngaySinh - date
	N'admin', -- diaChi - nvarchar(100)
	123456789  -- soCMND - int
)
GO

SELECT * FROM dbo.NhanVien
GO

INSERT INTO dbo.TaiKhoan
( UserName, Pass, LoaiTK, idNV )
VALUES
(
	'admin',
	N'admin',
	'1',
	'NV00'
)
GO

SELECT * FROM dbo.TaiKhoan
GO
=======
>>>>>>> feature/doublefeel

CREATE PROC USP_Login
@userName nvarchar(1000), @pass nvarchar(1000)
AS
BEGIN
	SELECT * FROM dbo.TaiKhoan WHERE UserName = @userName AND Pass = @pass
END
GO


<<<<<<< HEAD
DECLARE @i INT = 1
=======
SET IDENTITY_INSERT Ve OFF
GO

>>>>>>> feature/doublefeel

INSERT [dbo].[TheLoai] ([id], [TenTheLoai], [MoTa]) VALUES (N'TL01', N'Hành Động', NULL)
INSERT [dbo].[TheLoai] ([id], [TenTheLoai], [MoTa]) VALUES (N'TL02', N'Hoạt Hình', NULL)
INSERT [dbo].[TheLoai] ([id], [TenTheLoai], [MoTa]) VALUES (N'TL03', N'Hài', NULL)
INSERT [dbo].[TheLoai] ([id], [TenTheLoai], [MoTa]) VALUES (N'TL04', N'Viễn Tưởng', NULL)
INSERT [dbo].[TheLoai] ([id], [TenTheLoai], [MoTa]) VALUES (N'TL05', N'Phiêu lưu', NULL)
INSERT [dbo].[TheLoai] ([id], [TenTheLoai], [MoTa]) VALUES (N'TL06', N'Gia đình', NULL)
INSERT [dbo].[TheLoai] ([id], [TenTheLoai], [MoTa]) VALUES (N'TL07', N'Tình Cảm', NULL)
INSERT [dbo].[TheLoai] ([id], [TenTheLoai], [MoTa]) VALUES (N'TL08', N'Tâm Lý', NULL)

INSERT [dbo].[NhanVien] ([id], [HoTen], [NgaySinh], [DiaChi], [SDT], [CMND]) VALUES (N'NV00', N'admin', CAST(N'2018-04-22' AS Date), N'admin', NULL, 123456789)
INSERT [dbo].[NhanVien] ([id], [HoTen], [NgaySinh], [DiaChi], [SDT], [CMND]) VALUES (N'NV01', N'Bán Vé', CAST(N'2018-04-30' AS Date), NULL, NULL, 14725836)

INSERT [dbo].[TaiKhoan] ([UserName], [Pass], [LoaiTK], [idNV]) VALUES (N'admin', N'admin', 1, N'NV00')
INSERT [dbo].[TaiKhoan] ([UserName], [Pass], [LoaiTK], [idNV]) VALUES (N'NV01', N'1', 2, N'NV01')

INSERT [dbo].[KhachHang] ([id], [HoTen], [NgaySinh], [DiaChi], [SDT], [CMND], [DiemTichLuy]) VALUES (N'KH01', N'Nguyễn Văn A', CAST(N'1998-05-03' AS Date), N'Bla Bla', N'0123456789', 218161554, 0)
INSERT [dbo].[KhachHang] ([id], [HoTen], [NgaySinh], [DiaChi], [SDT], [CMND], [DiemTichLuy]) VALUES (N'KH02', N'Nguyễn Văn B', CAST(N'1998-05-03' AS Date), N'Bla Bla', N'0123456789', 218161564, 0)
INSERT [dbo].[KhachHang] ([id], [HoTen], [NgaySinh], [DiaChi], [SDT], [CMND], [DiemTichLuy]) VALUES (N'KH03', N'Nguyễn Văn B', CAST(N'1998-05-03' AS Date), N'Bla Bla', N'0123456789', 218161654, 0)

INSERT [dbo].[LoaiManHinh] ([id], [TenMH]) VALUES (N'MH01', N'2D')
INSERT [dbo].[LoaiManHinh] ([id], [TenMH]) VALUES (N'MH02', N'3D')
INSERT [dbo].[LoaiManHinh] ([id], [TenMH]) VALUES (N'MH03', N'IMAX')
INSERT [dbo].[LoaiManHinh] ([id], [TenMH]) VALUES (N'MH04', N'4D')

INSERT [dbo].[PhongChieu] ([id], [TenPhong], [idManHinh], [SoChoNgoi], [TinhTrang], [SoHangGhe], [SoGheMotHang]) VALUES (N'PC01', N'CINEMA 01', N'MH01', 140, 1, 10, 14)
INSERT [dbo].[PhongChieu] ([id], [TenPhong], [idManHinh], [SoChoNgoi], [TinhTrang], [SoHangGhe], [SoGheMotHang]) VALUES (N'PC02', N'CINEMA 02', N'MH02', 140, 1, 10, 14)
INSERT [dbo].[PhongChieu] ([id], [TenPhong], [idManHinh], [SoChoNgoi], [TinhTrang], [SoHangGhe], [SoGheMotHang]) VALUES (N'PC03', N'CINEMA 03', N'MH03', 140, 1, 10, 14)
INSERT [dbo].[PhongChieu] ([id], [TenPhong], [idManHinh], [SoChoNgoi], [TinhTrang], [SoHangGhe], [SoGheMotHang]) VALUES (N'PC04', N'CINEMA 04', N'MH04', 140, 1, 10, 14)

INSERT [dbo].[Phim] ([id], [TenPhim], [MoTa], [ThoiLuong], [NgayKhoiChieu], [NgayKetThuc], [SanXuat], [DaoDien], [NamSX]) VALUES (N'P01', N'Avengers: Cuộc Chiến Vô Cực', N'Avengers: Infinity War', 150, CAST(N'2018-05-01' AS Date), CAST(N'2018-06-01' AS Date), N'Mỹ', N'Anthony Russo,  Joe Russo', 2018)
INSERT [dbo].[Phim] ([id], [TenPhim], [MoTa], [ThoiLuong], [NgayKhoiChieu], [NgayKetThuc], [SanXuat], [DaoDien], [NamSX]) VALUES (N'P02', N'Lật Mặt: 3 Chàng Khuyết', N'Lat Mat 3 Chang Khuyet', 100, CAST(N'2018-05-01' AS Date), CAST(N'2018-06-01' AS Date), N'Việt Nam', N'Lý Hải', 2018)
INSERT [dbo].[Phim] ([id], [TenPhim], [MoTa], [ThoiLuong], [NgayKhoiChieu], [NgayKetThuc], [SanXuat], [DaoDien], [NamSX]) VALUES (N'P03', N'100 Ngày Bên Em', NULL, 100, CAST(N'2018-05-01' AS Date), CAST(N'2018-06-01' AS Date), N'Việt Nam', N'Vũ Ngọc Phượng', 2018)
INSERT [dbo].[Phim] ([id], [TenPhim], [MoTa], [ThoiLuong], [NgayKhoiChieu], [NgayKetThuc], [SanXuat], [DaoDien], [NamSX]) VALUES (N'P04', N'Ngỗng Vịt Phiêu Lưu Ký', N'Duck Duck Goose', 91, CAST(N'2018-05-01' AS Date), CAST(N'2018-06-01' AS Date), N'Mỹ', N'Christopher Jenkins', 2018)

INSERT [dbo].[PhanLoaiPhim] ([idPhim], [idTheLoai]) VALUES (N'P01', N'TL01')
INSERT [dbo].[PhanLoaiPhim] ([idPhim], [idTheLoai]) VALUES (N'P01', N'TL04')
INSERT [dbo].[PhanLoaiPhim] ([idPhim], [idTheLoai]) VALUES (N'P01', N'TL05')
INSERT [dbo].[PhanLoaiPhim] ([idPhim], [idTheLoai]) VALUES (N'P02', N'TL01')
INSERT [dbo].[PhanLoaiPhim] ([idPhim], [idTheLoai]) VALUES (N'P02', N'TL07')
INSERT [dbo].[PhanLoaiPhim] ([idPhim], [idTheLoai]) VALUES (N'P02', N'TL08')
INSERT [dbo].[PhanLoaiPhim] ([idPhim], [idTheLoai]) VALUES (N'P03', N'TL03')
INSERT [dbo].[PhanLoaiPhim] ([idPhim], [idTheLoai]) VALUES (N'P03', N'TL07')
INSERT [dbo].[PhanLoaiPhim] ([idPhim], [idTheLoai]) VALUES (N'P03', N'TL08')
INSERT [dbo].[PhanLoaiPhim] ([idPhim], [idTheLoai]) VALUES (N'P04', N'TL02')
INSERT [dbo].[PhanLoaiPhim] ([idPhim], [idTheLoai]) VALUES (N'P04', N'TL03')
INSERT [dbo].[PhanLoaiPhim] ([idPhim], [idTheLoai]) VALUES (N'P04', N'TL05')

INSERT [dbo].[DinhDangPhim] ([id], [idPhim], [idLoaiManHinh]) VALUES (N'DD01', N'P01', N'MH01')
INSERT [dbo].[DinhDangPhim] ([id], [idPhim], [idLoaiManHinh]) VALUES (N'DD02', N'P01', N'MH03')
INSERT [dbo].[DinhDangPhim] ([id], [idPhim], [idLoaiManHinh]) VALUES (N'DD03', N'P02', N'MH01')
INSERT [dbo].[DinhDangPhim] ([id], [idPhim], [idLoaiManHinh]) VALUES (N'DD04', N'P03', N'MH02')

INSERT [dbo].[LichChieu] ([id], [ThoiGianChieu], [idPhong], [idDinhDang]) VALUES (N'LC01', CAST(N'2018-05-02T08:50:00.000' AS DateTime), N'PC01', N'DD01')
INSERT [dbo].[LichChieu] ([id], [ThoiGianChieu], [idPhong], [idDinhDang], [GiaVe]) VALUES (N'LC01', CAST(N'2018-05-02T08:50:00.000' AS DateTime), N'PC01', N'DD01', 85000.0000)
INSERT [dbo].[LichChieu] ([id], [ThoiGianChieu], [idPhong], [idDinhDang], [GiaVe]) VALUES (N'LC02', CAST(N'2018-05-02T08:05:00.000' AS DateTime), N'PC02', N'DD01', 85000.0000)
INSERT [dbo].[LichChieu] ([id], [ThoiGianChieu], [idPhong], [idDinhDang], [GiaVe]) VALUES (N'LC03', CAST(N'2018-05-02T08:10:00.000' AS DateTime), N'PC03', N'DD02', 85000.0000)
INSERT [dbo].[LichChieu] ([id], [ThoiGianChieu], [idPhong], [idDinhDang], [GiaVe]) VALUES (N'LC04', CAST(N'2018-05-02T09:20:00.000' AS DateTime), N'PC04', N'DD03', 85000.0000)
SET IDENTITY_INSERT [dbo].[Ve] ON 

INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (1, 0, N'LC01', N'A1', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (2, 0, N'LC01', N'A2', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (3, 0, N'LC01', N'A3', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (4, 0, N'LC01', N'A4', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (5, 0, N'LC01', N'A5', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (6, 0, N'LC01', N'A6', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (7, 0, N'LC01', N'A7', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (8, 0, N'LC01', N'A8', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (9, 0, N'LC01', N'A9', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (10, 0, N'LC01', N'A10', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (11, 0, N'LC01', N'A11', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (12, 0, N'LC01', N'A12', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (13, 0, N'LC01', N'A13', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (14, 0, N'LC01', N'A14', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (15, 0, N'LC01', N'B1', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (16, 0, N'LC01', N'B2', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (17, 0, N'LC01', N'B3', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (18, 0, N'LC01', N'B4', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (19, 0, N'LC01', N'B5', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (20, 0, N'LC01', N'B6', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (21, 0, N'LC01', N'B7', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (22, 0, N'LC01', N'B8', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (23, 0, N'LC01', N'B9', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (24, 0, N'LC01', N'B10', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (25, 0, N'LC01', N'B11', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (26, 0, N'LC01', N'B12', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (27, 0, N'LC01', N'B13', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (28, 0, N'LC01', N'B14', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (29, 0, N'LC01', N'C1', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (30, 0, N'LC01', N'C2', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (31, 0, N'LC01', N'C3', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (32, 0, N'LC01', N'C4', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (33, 0, N'LC01', N'C5', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (34, 0, N'LC01', N'C6', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (35, 0, N'LC01', N'C7', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (36, 0, N'LC01', N'C8', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (37, 0, N'LC01', N'C9', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (38, 0, N'LC01', N'C10', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (39, 0, N'LC01', N'C11', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (40, 0, N'LC01', N'C12', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (41, 0, N'LC01', N'C13', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (42, 0, N'LC01', N'C14', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (43, 0, N'LC01', N'D1', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (44, 0, N'LC01', N'D2', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (45, 0, N'LC01', N'D3', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (46, 0, N'LC01', N'D4', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (47, 0, N'LC01', N'D5', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (48, 0, N'LC01', N'D6', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (49, 0, N'LC01', N'D7', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (50, 0, N'LC01', N'D8', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (51, 0, N'LC01', N'D9', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (52, 0, N'LC01', N'D10', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (53, 0, N'LC01', N'D11', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (54, 0, N'LC01', N'D12', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (55, 0, N'LC01', N'D13', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (56, 0, N'LC01', N'D14', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (57, 0, N'LC01', N'E1', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (58, 0, N'LC01', N'E2', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (59, 0, N'LC01', N'E3', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (60, 0, N'LC01', N'E4', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (61, 0, N'LC01', N'E5', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (62, 0, N'LC01', N'E6', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (63, 0, N'LC01', N'E7', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (64, 0, N'LC01', N'E8', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (65, 0, N'LC01', N'E9', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (66, 0, N'LC01', N'E10', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (67, 0, N'LC01', N'E11', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (68, 0, N'LC01', N'E12', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (69, 0, N'LC01', N'E13', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (70, 0, N'LC01', N'E14', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (71, 0, N'LC01', N'F1', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (72, 0, N'LC01', N'F2', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (73, 0, N'LC01', N'F3', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (74, 0, N'LC01', N'F4', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (75, 0, N'LC01', N'F5', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (76, 0, N'LC01', N'F6', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (77, 0, N'LC01', N'F7', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (78, 0, N'LC01', N'F8', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (79, 0, N'LC01', N'F9', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (80, 0, N'LC01', N'F10', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (81, 0, N'LC01', N'F11', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (82, 0, N'LC01', N'F12', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (83, 0, N'LC01', N'F13', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (84, 0, N'LC01', N'F14', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (85, 0, N'LC01', N'G1', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (86, 0, N'LC01', N'G2', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (87, 0, N'LC01', N'G3', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (88, 0, N'LC01', N'G4', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (89, 0, N'LC01', N'G5', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (90, 0, N'LC01', N'G6', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (91, 0, N'LC01', N'G7', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (92, 0, N'LC01', N'G8', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (93, 0, N'LC01', N'G9', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (94, 0, N'LC01', N'G10', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (95, 0, N'LC01', N'G11', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (96, 0, N'LC01', N'G12', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (97, 0, N'LC01', N'G13', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (98, 0, N'LC01', N'G14', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (99, 0, N'LC01', N'J1', NULL, N'0', 1, 0.0000)
GO
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (100, 0, N'LC01', N'J2', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (101, 0, N'LC01', N'J3', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (102, 0, N'LC01', N'J4', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (103, 0, N'LC01', N'J5', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (104, 0, N'LC01', N'J6', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (105, 0, N'LC01', N'J7', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (106, 0, N'LC01', N'J8', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (107, 0, N'LC01', N'J9', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (108, 0, N'LC01', N'J10', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (109, 0, N'LC01', N'J11', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (110, 0, N'LC01', N'J12', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (111, 0, N'LC01', N'J13', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (112, 0, N'LC01', N'J14', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (113, 0, N'LC01', N'I1', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (114, 0, N'LC01', N'I2', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (115, 0, N'LC01', N'I3', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (116, 0, N'LC01', N'I4', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (117, 0, N'LC01', N'I5', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (118, 0, N'LC01', N'I6', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (119, 0, N'LC01', N'I7', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (120, 0, N'LC01', N'I8', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (121, 0, N'LC01', N'I9', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (122, 0, N'LC01', N'I10', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (123, 0, N'LC01', N'I11', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (124, 0, N'LC01', N'I12', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (125, 0, N'LC01', N'I13', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (126, 0, N'LC01', N'I14', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (127, 0, N'LC01', N'K1', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (128, 0, N'LC01', N'K2', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (129, 0, N'LC01', N'K3', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (130, 0, N'LC01', N'K4', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (131, 0, N'LC01', N'K5', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (132, 0, N'LC01', N'K6', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (133, 0, N'LC01', N'K7', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (134, 0, N'LC01', N'K8', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (135, 0, N'LC01', N'K9', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (136, 0, N'LC01', N'K10', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (137, 0, N'LC01', N'K11', NULL, N'0', 0, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (138, 0, N'LC01', N'K12', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (139, 0, N'LC01', N'K13', NULL, N'0', 1, 0.0000)
INSERT [dbo].[Ve] ([id], [LoaiVe], [idLichChieu], [MaGheNgoi], [idKhachHang], [idCheDoKM], [TrangThai], [TienBanVe]) VALUES (140, 0, N'LC01', N'K14', NULL, N'0', 1, 0.0000)
SET IDENTITY_INSERT [dbo].[Ve] OFF


<<<<<<< HEAD
select * from Phim where DAY(GETDATE()) <= DAY(NgayKetThuc) and MONTH(GETDATE()) <= MONTH(NgayKetThuc) and YEAR(GETDATE()) <= YEAR(NgayKetThuc)
select * from Phim where GETDATE() <= NgayKetThuc
=======
>>>>>>> feature/doublefeel
