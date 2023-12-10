create database QLDoAn
go
use QLDoAn
go
create table KhachSan
(
	MaKS varchar(10) primary key,
	TenKS nvarchar(50) not null,
	DiaChi nvarchar(50),
	MaLoaiKS varchar(10)
)
create table LoaiKS
(
	MaLoaiKS varchar(10) primary key,
	TenLoaiKS nvarchar(50)
)
alter table KhachSan add constraint fk_MaLoaiKS foreign key (MaLoaiKS) references LoaiKS(MaLoaiKS)
create table PhuongTien
(
	MaPT varchar(10) primary key,
	TenPT nvarchar(50) not null
)
create table DiemBD
(
	MaDiemBD varchar(10) primary key,
	TenDiemBD nvarchar(50) not null
)
create table ChucVu
(	
	MaCV varchar(10) primary key,
	TenCV nvarchar(50),
)
create table DiemKT
(
	MaDiemKT varchar(10) primary key,
	TenDiemKT nvarchar(50) not null
)
create table NhanVien
(
	MaNV varchar(10) primary key,
	TenNV nvarchar(50) not null,
	NgaySinh date,	MaCV varchar(10),
	constraint fk_MaCV_CV foreign key (MaCV) references ChucVu(MaCV),
	SDT varchar(10)
)

create table TaiKhoan
(
	MaTK varchar(10) primary key,
	TenTK varchar(20),
	MatKhau varchar(20),
	MaNV varchar(10),
	constraint fk_MaNV_TK foreign key (MaNV) references NhanVien(MaNV)
)
create table Tours
(
	MaTour varchar(10) primary key,
	TenTour nvarchar(50) not null,
	NgayDi date,
	NgayVe date,
	GiaTour int,
	MaDiemBD varchar(10),
	MaDiemKT varchar(10),
	MaPT varchar(10),
	MaKS varchar(10),
	constraint fk_MaDiemBD foreign key (MaDiemBD) references DiemBD(MaDiemBD),
	constraint fk_MaDiemKT foreign key (MaDiemKT) references DiemKT(MaDiemKT),
	constraint fk_MaPT foreign key (MaPT) references PhuongTien(MaPT),
	constraint fk_MaKS foreign key (MaKS) references KhachSan(MaKS)
)
create table KhachHang
(
	MaKH varchar(10) primary key,
	TenKH nvarchar(50) not null,
	SDT varchar(10),
	GioiTinh nvarchar(5),
	SoVe int,
)
create table HoaDon
(
	MaHD varchar(10) primary key,
	MaTour varchar(10),
	MaNV varchar(10),
	MaKH varchar(10),
	NgayLap date,
	ThanhTien int,
	constraint fk_MaTour foreign key(MaTour) references Tours(MaTour),
	constraint fk_MaNV foreign key(MaNV) references NhanVien(MaNV),
	constraint fk_MaKH foreign key(MaKH) references KhachHang(MaKH)
)


set dateformat dmy

INSERT INTO LoaiKS (MaLoaiKS, TenLoaiKS)
VALUES ('L1', N'Khách sạn'),
       ('L2', N'Nhà nghỉ'),
       ('L3', N'HomeStay'),
	   ('L4', N'Villa');
INSERT INTO KhachSan 
VALUES ('KS001', N'Khách sạn Hoa Hồng', N'123 Trần Hưng Đạo, Thành phố Đà Nẵng', 'L4'),
       ('KS002', N'Khách sạn Vườn Mây', N'456 Láng Hạ, Thủ đô Hà Nội', 'L1');

INSERT INTO PhuongTien (MaPT, TenPT)
VALUES ('PT001', N'Ô tô'),
       ('PT002', N'Máy bay');

INSERT INTO DiemBD (MaDiemBD, TenDiemBD)
VALUES ('DB001', N'Sân bay quốc tế Tân Sơn Nhất'),
       ('DB002', N'Sân bay quốc tế Nội Bài');

INSERT INTO DiemKT (MaDiemKT, TenDiemKT)
VALUES ('KT001', N'Sân Bay Đà Nẵng'),
       ('KT002', N'Sân Bay Quy Nhơn');

INSERT INTO ChucVu(MaCV, TenCV)
VALUES ('CV001', N'Nhân viên văn phòng'),
		('CV002', N'Hướng dẫn viên')

INSERT INTO NhanVien (MaNV, TenNV, NgaySinh, SDT, MaCV)
VALUES ('NV001', N'Nguyễn Văn Anh', '15/01/1990', '0901234567', 'CV001'),
       ('NV002', N'Trần Thị Bình', '20/05/1992', '0912345678', 'CV002');

INSERT INTO TaiKhoan (MaTK, TenTK, MatKhau, MaNV)
VALUES ('TK001', 'user1', 'user1', 'NV001'),
       ('TK002', 'admin1', 'admin1', 'NV002');

INSERT INTO KhachHang (MaKH, TenKH, SDT, GioiTinh, SoVe)
VALUES ('KH001', N'Nguyễn Thị Chinh', '0987654321', N'Nữ', 2),
       ('KH002', N'Lê Văn Dũng', '0123456789', N'Nam', 1);

INSERT INTO Tours (MaTour, TenTour, NgayDi, NgayVe, GiaTour, MaDiemBD, MaDiemKT, MaPT, MaKS)
VALUES ('T001', N'Tour Đà Nẵng', '01/11/2023', '10/11/2023', 1500000, 'DB001', 'KT001', 'PT001', 'KS001'),
       ('T002', N'Tour Hà Nội', '05/12/2023', '15/12/2023', 3600000, 'DB002', 'KT002', 'PT002', 'KS002');

INSERT INTO HoaDon (MaHD, MaTour, MaNV, MaKH, NgayLap)
VALUES ('HD001', 'T001', 'NV001', 'KH001', '05/11/2023'),
       ('HD002', 'T002', 'NV002', 'KH002', '10/12/2023')
go

CREATE TRIGGER updHoaDon
ON HoaDon
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE HoaDon
    SET ThanhTien = Tours.GiaTour * KhachHang.SoVe
    FROM HoaDon
    JOIN inserted ON HoaDon.MaHD = inserted.MaHD
	JOIN Tours ON inserted.MaTour = Tours.MaTour
    JOIN KhachHang ON inserted.MaKH = KhachHang.MaKH;
END
go