USE MASTER
CREATE DATABASE QuanLyThuVien
USE QuanLyThuVien

SET DATEFORMAT dmy

--*********************************************************** (TABLE) **************************************************************--

--___________________________________________________________ THEDOCGIA ____________________________________________________________--
--1
CREATE TABLE LOAIDOCGIA
(
	IDLoaiDG varchar(6) PRIMARY KEY NOT NULL,
	TenLoaiDG nvarchar(50) NOT NULL
)
--DROP TABLE LOAIDOCGIA
INSERT INTO LOAIDOCGIA VALUES ('LDG001', N'Thường')
INSERT INTO LOAIDOCGIA VALUES ('LDG002', 'VIP')

--1.1
CREATE TABLE THEDOCGIA
(
	IDDocGia varchar(6) PRIMARY KEY NOT NULL,
	HoTenDG nvarchar(50) NOT NULL,
	NgaySinhDG datetime NOT NULL,
	DiaChiDG nvarchar(50) NOT NULL,
	EmailDG varchar(30) NOT NULL,
	IDLoaiDG varchar(6) FOREIGN KEY REFERENCES LOAIDOCGIA(IDLoaiDG),
	NgayLapThe datetime NOT NULL,
	NgayHetHan datetime,
	TongNo money DEFAULT(0)
)
--DROP TABLE THEDOCGIA

INSERT INTO THEDOCGIA(IDDocGIa, HoTenDG, NgaySinhDG, DiaChiDG, EmailDG, IDLoaiDG, NgayLapThe) VALUES ('IDG001', N'Nguyễn Văn A', '1/1/1990', N'bá', 'b@yahoo.com', 'LDG002', '1/1/2018')
INSERT INTO THEDOCGIA(IDDocGIa, HoTenDG, NgaySinhDG, DiaChiDG, EmailDG, IDLoaiDG, NgayLapThe) VALUES ('IDG002', N'Nguyễn Văn B', '1/1/1990', N'bá', 'b@yahoo.com', 'LDG002', '1/1/2018')
--------------------------------------------------------------------------------------------------------------------------------------

--___________________________________________________________ SACH _________________________________________________________________--
--2
CREATE TABLE LOAISACH
(
	IDLoaiSach varchar(6) PRIMARY KEY NOT NULL,
	TenLoaiSach nvarchar(50) NOT NULL
)
--DROP TABLE LOAISACH

--2.1
CREATE TABLE DAUSACH
(
	IDDauSach varchar(6) PRIMARY KEY NOT NULL,
	TenDauSach nvarchar(200) NOT NULL,
	IDLoaiSach varchar(6) FOREIGN KEY REFERENCES LOAISACH(IDLoaiSach)
)
--DROP TABLE DAUSACH

--2.2
CREATE TABLE SACH
(
	IDSach varchar(6) PRIMARY KEY NOT NULL,
	IDDauSach varchar(6) FOREIGN KEY REFERENCES DAUSACH(IDDauSach),		
	NhaXB nvarchar(20) NOT NULL,
	NamXB int NOT NULL,	
	SoLuongTon int NOT NULL,
	GiaTien money NOT NULL
)
--DROP TABLE SACH

--2.3
CREATE TABLE CUONSACH
(
	IDCuonSach varchar(6) PRIMARY KEY NOT NULL,
	IDSach varchar(6) FOREIGN KEY REFERENCES SACH(IDSach),
	TinhTrang nvarchar(20) NOT NULL
)
--DROP TABLE CUONSACH

--2.4
CREATE TABLE TACGIA
(
	IDTacGia varchar(6) PRIMARY KEY NOT NULL,
	TenTacGia nvarchar(50) NOT NULL,
	NgaySinh datetime
)
--DROP TABLE TACGIA

--2.5
CREATE TABLE CT_TACGIA
(
	IDCTTacGia varchar(6) PRIMARY KEY NOT NULL,
	IDDauSach varchar(6) FOREIGN KEY REFERENCES DAUSACH(IDDauSach),
	IDTacGia varchar(6) FOREIGN KEY REFERENCES TACGIA(IDTacGia)
)
--DROP TABLE CT_TACGIA
--------------------------------------------------------------------------------------------------------------------------------------

--___________________________________________________________ PHIEUNHAPSACH ________________________________________________________--
--3
CREATE TABLE PHIEUNHAPSACH
(
	IDPhieuNhap varchar(6) PRIMARY KEY NOT NULL,
	NgayNhap datetime NOT NULL,
	TongTien money NOT NULL
)
--DROP TABLE PHIEUNHAPSACH

--3.1
CREATE TABLE CT_PHIEUNHAPSACH
(
	IDCTPhieuNhap varchar(6) PRIMARY KEY NOT NULL,
	IDPhieuNhap varchar(6) FOREIGN KEY REFERENCES PHIEUNHAPSACH(IDPhieuNhap),
	IDSach varchar(6) FOREIGN KEY REFERENCES SACH(IDSach),
	SoLuong int NOT NULL,
	DonGia money NOT NULL,
	ThanhTien money NOT NULL
)
--DROP TABLE CT_PHIEUNHAPSACH
--------------------------------------------------------------------------------------------------------------------------------------

--___________________________________________________________ PHIEUMUON ____________________________________________________________--
--4
CREATE TABLE PHIEUMUON
(
	IDPhieuMuon varchar(6) PRIMARY KEY NOT NULL,	
	IDDocGia varchar(6) FOREIGN KEY REFERENCES THEDOCGIA(IDDocGia),
	NgayMuon datetime NOT NULL,
	HanTra datetime NOT NULL
)
--DROP TABLE PHIEUMUON

--4.1
CREATE TABLE CT_PHIEUMUON
(
	IDCTPhieuMuon varchar(6) PRIMARY KEY NOT NULL,
	IDPhieuMuon varchar(6) FOREIGN KEY REFERENCES PHIEUMUON(IDPhieuMuon),
	IDCuonSach varchar(6) FOREIGN KEY REFERENCES CUONSACH(IDCuonSach)	
)
--DROP TABLE CT_PHIEUMUON
--------------------------------------------------------------------------------------------------------------------------------------

--___________________________________________________________ PHIEUTRA _____________________________________________________________--
--5
CREATE TABLE PHIEUTRA
(
	IDPhieuTra varchar(6) PRIMARY KEY NOT NULL,
	IDDocGia varchar(6) FOREIGN KEY REFERENCES THEDOCGIA(IDDocGia),
	NgayTra datetime NOT NULL,
	TienPhatKyNay money NOT NULL,
	SoTienTra money NOT NULL,
	TienNoKyNay money NOT NULL
)
--DROP TABLE PHIEUTRA

--5.1
CREATE TABLE CT_PHIEUTRA
(
	IDCTPhieuTra varchar(6) PRIMARY KEY NOT NULL,
	IDPhieuTra varchar(6) FOREIGN KEY REFERENCES PHIEUTRA(IDPhieuTra),
	IDCuonSach varchar(6) FOREIGN KEY REFERENCES CUONSACH(IDCuonSach),
	IDCTPhieuMuon varchar(6) FOREIGN KEY REFERENCES CT_PHIEUMUON(IDCTPhieuMuon),
	SoNgayMuon int NOT NULL,
	TienPhat money DEFAULT(0)
)
--DROP TABLE CT_PHIEUTRA
--------------------------------------------------------------------------------------------------------------------------------------

--___________________________________________________________ PHIEUTHUTIENPHAT _____________________________________________________--
--6
CREATE TABLE PHIEUTHUTIENPHAT
(
	IDPhieuThu varchar(6) PRIMARY KEY NOT NULL,	
	IDDocGia varchar(6) FOREIGN KEY REFERENCES THEDOCGIA(IDDocGia),
	NgayLap datetime NOT NULL,
	SoTienThu money NOT NULL,
	ConLai money NOT NULL
)
--DROP TABLE PHIEUTHUTIENPHAT
--------------------------------------------------------------------------------------------------------------------------------------

--___________________________________________________________ BCTINHHINHMUONSACH ___________________________________________________--
--7
CREATE TABLE BCTINHHINHMUONSACH
(
	IDBCMuonSach varchar(6) PRIMARY KEY NOT NULL,
	ThangNam int NOT NULL,
	TongSoLuotMuon int NOT NULL
)
--DROP TABLE BCTINHHINHMUONSACH

--7.1
CREATE TABLE CT_BCTINHHINHMUONSACH
(
	IDCTBCMuonSach varchar(6) PRIMARY KEY NOT NULL,
	IDBCMuonSach varchar(6) FOREIGN KEY REFERENCES BCTINHHINHMUONSACH(IDBCMuonSach),
	IDLoaiSach varchar(6) FOREIGN KEY REFERENCES LOAISACH(IDLoaiSach),
	SoLuotMuon int NOT NULL,
	TiLe float NOT NULL
)
--DROP TABLE CT_BCTINHHINHMUONSACH
--------------------------------------------------------------------------------------------------------------------------------------

--___________________________________________________________ BCSACHTRATRE _________________________________________________________--
--8
CREATE TABLE BCSACHTRATRE
(
	IDBCSachTre varchar(6) PRIMARY KEY NOT NULL,
	NgayThangNam datetime NOT NULL,
	IDCuonSach  varchar(6) FOREIGN KEY REFERENCES CUONSACH(IDCuonSach),
	IDPhieuMuon varchar(6) FOREIGN KEY REFERENCES PHIEUMUON(IDPhieuMuon),
	SoNgayTraTre int NOT NULL
)
--DROP TABLE BCSACHTRATRE
--------------------------------------------------------------------------------------------------------------------------------------

--___________________________________________________________ USERS ________________________________________________________________--
--9
CREATE TABLE USERS
(
	UserName varchar(50) NOT NULL,
	IDDocGia varchar(6) FOREIGN KEY REFERENCES THEDOCGIA(IDDocGia),
	Pwd varchar(50) NOT NULL
)
--DROP TABLE USERS
--------------------------------------------------------------------------------------------------------------------------------------

--___________________________________________________________ THAMSO _______________________________________________________________--
--10
CREATE TABLE THAMSO
(
	TuoiMin int DEFAULT(18),
	TuoiMax int DEFAULT(55),
	HanThe int DEFAULT(6),
	KhoangCachXB int DEFAULT(8),
	SoSachMuonMax int DEFAULT(5),
	SoNgayMuonMax int DEFAULT(4),
	TienPhatMoiNgay money DEFAULT(1000),
	ApDungQDSoTienThu int DEFAULT(1)
)
--DROP TABLE THAMSO

INSERT INTO THAMSO VALUES (18, 55, 6, 8, 5, 4, 1000, 1)
INSERT INTO THAMSO (TuoiMin, TuoiMax)  VALUES (18, 55)
--------------------------------------------------------------------------------------------------------------------------------------



--*********************************************************** (TRIGGER) ************************************************************--

--__________________________________________________________ Tuổi độc giả
CREATE TRIGGER TRG_T ON THEDOCGIA
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @NGAYSINHDG datetime, @NGAYLAPTHE datetime, @TUOIMIN int, @TUOIMAX int
	
	SELECT @NGAYSINHDG = NgaySinhDG, @NGAYLAPTHE = NgayLapThe
	FROM INSERTED
	SELECT @TUOIMIN = TuoiMin, @TUOIMAX = TuoiMax
	FROM THAMSO

	IF (DATEDIFF(year, @NGAYSINHDG, @NGAYLAPTHE) < @TUOIMIN OR DATEDIFF(year, @NGAYSINHDG,  @NGAYLAPTHE) > @TUOIMAX)
	BEGIN
		PRINT N'Lỗi: Tuổi của độc giả phải từ 18 đến 55'
		ROLLBACK TRANSACTION
	END	
END
			
--DROP TRIGGER TRG_T								 
--------------------------------------------------------------------------------------------------------------------------------------

--__________________________________________________________ Ngày hết hạn thẻ
CREATE TRIGGER TRG_NHH ON THEDOCGIA
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @NGAYLAPTHE datetime, @HANTHE int
	
	SELECT @NGAYLAPTHE = NgayLapThe
	FROM INSERTED
	SELECT @HANTHE = HanThe
	FROM THAMSO
	
	UPDATE THEDOCGIA 
	SET NgayHetHan = DATEADD(month, @HANTHE, @NGAYLAPTHE)
END

--DROP TRIGGER TRG_NHH	
--------------------------------------------------------------------------------------------------------------------------------------

--__________________________________________________________ Max 100 tác giả
CREATE TRIGGER TRG_TG ON TACGIA
FOR INSERT
AS
BEGIN
	IF((SELECT COUNT(DISTINCT IDTacGia) FROM TACGIA) > 100)
	BEGIN
		PRINT N'Lỗi: Vượt quá 100 tác giả'
		ROLLBACK TRANSACTION
	END
END

--DROP TRIGGER TRG_TG
--------------------------------------------------------------------------------------------------------------------------------------

--__________________________________________________________ Sách xuất bản 8 năm
CREATE TRIGGER TRG_XB ON CT_PHIEUNHAPSACH
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @NGAYNHAP datetime, @NAMXB int, @KHOANGCACHXB int

	SELECT @NGAYNHAP = NgayNhap 
	FROM INSERTED I, PHIEUNHAPSACH P
	WHERE I.IDPhieuNhap = P.IDPhieuNhap
	SELECT @NAMXB = NamXB
	FROM INSERTED I, SACH S
	WHERE I.IDSach = S.IDSach
	SELECT @KHOANGCACHXB = KhoangCachXB
	FROM THAMSO

	IF(DATEDIFF(year, @NAMXB, @NGAYNHAP) > @KHOANGCACHXB)
	BEGIN
		PRINT N'Lỗi: Chỉ nhận các sách xuất bản trong vòng 8 năm'
		ROLLBACK TRANSACTION
	END	
END

--DROP TRIGGER TRG_XB
--------------------------------------------------------------------------------------------------------------------------------------

--__________________________________________________________ Quy định cho mượn sách
CREATE TRIGGER TRG_MS ON CT_PHIEUMUON
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @NGAYHETHAN datetime, @IDCUONSACH varchar(6), @IDDOCGIA varchar(6), @NGAYMUON datetime, @TINHTRANG nvarchar(20), @NGHETHAN datetime
		
	SELECT @IDCUONSACH = IDCuonSach, @IDDOCGIA = IDDocGia, @NGAYMUON = NgayMuon
	FROM INSERTED I, PHIEUMUON P
	WHERE I.IDPhieuMuon = P.IDPhieuMuon
	SELECT @NGAYHETHAN = NgayHetHan
	FROM THEDOCGIA
	WHERE @IDDOCGIA = IDDocGia
	SELECT @TINHTRANG = TinhTrang
	FROM CUONSACH
	WHERE @IDCUONSACH = IDCuonSach	

	IF((@NGAYHETHAN <= @NGAYMUON) OR (@TINHTRANG = N'Cho mượn') OR EXISTS (SELECT * FROM PHIEUMUON A, CT_PHIEUMUON B
																		   WHERE A.IDPhieuMuon = B.IDPhieuMuon AND A.HanTra < @NGAYMUON
																		   AND NOT EXISTS(SELECT * FROM PHIEUTRA C, CT_PHIEUTRA D WHERE C.IDPhieuTra = D.IDCTPhieuTra AND D.IDCTPhieuMuon = B.IDCTPhieuMuon)))
	BEGIN
		PRINT N'Lỗi: Chỉ cho mượn với thẻ còn hạn, không có sách mượn quá hạn, và sách không có người đang mượn'
		ROLLBACK TRANSACTION
	END	
END

--DROP TRIGGER TRG_MS
--------------------------------------------------------------------------------------------------------------------------------------

--__________________________________________________________ Mỗi độc giả Max mượn 5 cuốn
CREATE TRIGGER TRG_MM ON CT_PHIEUMUON
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @IDPHIEUMUON varchar(6), @IDDOCGIA varchar(6), @SOSACHMUONMAX int
		
	SELECT @IDPHIEUMUON = IDPhieuMuon
	FROM INSERTED
	SELECT @IDDOCGIA = IDDocGia
	FROM PHIEUMUON
	WHERE @IDPHIEUMUON = IDPhieuMuon	
	SELECT @SOSACHMUONMAX = SoSachMuonMax
	FROM THAMSO

	IF((SELECT COUNT(DISTINCT A.IDCuonSach) 
		FROM CT_PHIEUMUON A, PHIEUMUON B
		WHERE A.IDPhieuMuon = B.IDPhieuMuon AND B.IDDocGia = @IDDOCGIA
		AND NOT EXISTS (SELECT * FROM CT_PHIEUTRA C, PHIEUTRA D
						WHERE C.IDCuonSach = A.IDCuonSach AND C.IDPhieuTra = D.IDPhieuTra
						AND D.NgayTra < B.NgayMuon))) > @SOSACHMUONMAX		
	BEGIN
		PRINT N'Lỗi: Mỗi độc giả chỉ mượn tối đa 5 quyển sách'
		ROLLBACK TRANSACTION 
	END	
END

--DROP TRIGGER TRG_MM
--------------------------------------------------------------------------------------------------------------------------------------

--__________________________________________________________ Hạn trả 4 ngày
CREATE TRIGGER TRG_HT ON PHIEUMUON
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @NGAYMUON datetime, @SONGAYMUONMAX int
	
	SELECT @NGAYMUON = NgayMuon
	FROM INSERTED
	SELECT @SONGAYMUONMAX = SoNgayMuonMax
	FROM THAMSO
	
	UPDATE PHIEUMUON
	SET HanTra = DATEADD(day, @SONGAYMUONMAX, @NGAYMUON)
END

--DROP TRIGGER TRG_HT
--------------------------------------------------------------------------------------------------------------------------------------

--__________________________________________________________ Tiền phạt do trả trễ mỗi sách
CREATE TRIGGER TRG_TP ON CT_PHIEUTRA
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @SONGAYMUON int, @SONGAYMUONMAX int, @TIENPHATMOINGAY int
	
	SELECT @SONGAYMUON = SoNgayMuon
	FROM INSERTED
	SELECT @SONGAYMUONMAX = SoNgayMuonMax, @TIENPHATMOINGAY = TienPhatMoiNgay
	FROM THAMSO
	
	IF(@SONGAYMUON > 4)
	BEGIN
		UPDATE CT_PHIEUTRA
		SET TienPhat = (@SONGAYMUON - 4)*@TIENPHATMOINGAY
	END
END

--DROP TRIGGER TRG_TP
--------------------------------------------------------------------------------------------------------------------------------------

--__________________________________________________________ Áp dụng QĐ số tiền thu
CREATE TRIGGER TRG_QD ON PHIEUTHUTIENPHAT
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @SOTIENTHU money, @TONGNO money, @APDUNGQDSOTIENTHU int
	
	SELECT @SOTIENTHU = SoTienThu
	FROM INSERTED
	SELECT @TONGNO = TongNo
	FROM INSERTED I, THEDOCGIA T
	WHERE I.IDDocGia = T.IDDocGia
	SELECT @APDUNGQDSOTIENTHU = ApDungQDSoTienThu
	FROM THAMSO
	
	IF(@APDUNGQDSOTIENTHU = 1)
	BEGIN
		IF(@SOTIENTHU > @TONGNO)
		BEGIN
			PRINT N'Số tiền thu không được vượt quá số tiền độc giả đang nợ'
		END
	END
END

--DROP TRIGGER TRG_QD