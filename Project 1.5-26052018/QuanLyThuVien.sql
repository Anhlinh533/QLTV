﻿USE MASTER
CREATE DATABASE QuanLyThuVien
USE QuanLyThuVien

SET DATEFORMAT dmy

--*********************************************************** (TABLE) **************************************************************--
--*********************************************************** (TABLE) **************************************************************--
--*********************************************************** (TABLE) **************************************************************--
--*********************************************************** (TABLE) **************************************************************--
--*********************************************************** (TABLE) **************************************************************--
															 ---****---


--___________________________________________________________ THEDOCGIA ____________________________________________________________--

DROP TABLE LOAIDOCGIA
CREATE TABLE LOAIDOCGIA
(
	IDLoaiDG varchar(6) PRIMARY KEY NOT NULL,
	TenLoaiDG nvarchar(50) NOT NULL
)

INSERT INTO LOAIDOCGIA VALUES ('LDG001', N'Thường')
INSERT INTO LOAIDOCGIA VALUES ('LDG002', 'VIP')

DROP TABLE THEDOCGIA
CREATE TABLE THEDOCGIA
(
	IDDocGia varchar(6) PRIMARY KEY NOT NULL,
	HoTenDG nvarchar(50) NOT NULL,
	NgaySinhDG date NOT NULL,
	DiaChiDG nvarchar(50) NOT NULL,
	EmailDG varchar(30) NOT NULL,
	IDLoaiDG varchar(6) FOREIGN KEY REFERENCES LOAIDOCGIA(IDLoaiDG),
	NgayLapThe date NOT NULL,
	NgayHetHan date, --o
	TongNo money DEFAULT(0) --o
)

INSERT INTO THEDOCGIA(IDDocGIa, HoTenDG, NgaySinhDG, DiaChiDG, EmailDG, IDLoaiDG, NgayLapThe) VALUES ('IDG001', N'Nguyễn Văn A', '1/1/1990', N'á', 'a@yahoo.com', 'LDG001', '9/10/2017')
INSERT INTO THEDOCGIA(IDDocGIa, HoTenDG, NgaySinhDG, DiaChiDG, EmailDG, IDLoaiDG, NgayLapThe) VALUES ('IDG002', N'Nguyễn Văn B', '1/1/1997', N'ố', 'b@yahoo.com', 'LDG002', '6/9/2017')
INSERT INTO THEDOCGIA(IDDocGIa, HoTenDG, NgaySinhDG, DiaChiDG, EmailDG, IDLoaiDG, NgayLapThe) VALUES ('IDG003', N'Lê Thị Chung', '2/2/2000', N'é', 'c@yahoo.com', 'LDG001', '2/5/2018')
INSERT INTO THEDOCGIA(IDDocGIa, HoTenDG, NgaySinhDG, DiaChiDG, EmailDG, IDLoaiDG, NgayLapThe) VALUES ('IDG004', N'Lê Thị Trung', '4/4/1998', N'ế', 'd@yahoo.com', 'LDG002', '3/4/2017')
--------------------------------------------------------------------------------------------------------------------------------------

--___________________________________________________________ SACH _________________________________________________________________--
--DROP TABLE LOAISACH
CREATE TABLE LOAISACH
(
	IDLoaiSach varchar(6) PRIMARY KEY NOT NULL,
	TenLoaiSach nvarchar(50) NOT NULL
)

INSERT INTO LOAISACH VALUES ('LSA001', 'A')
INSERT INTO LOAISACH VALUES ('LSA002', 'B')
INSERT INTO LOAISACH VALUES ('LSA003', 'C')


--DROP TABLE DAUSACH
CREATE TABLE DAUSACH
(
	IDDauSach varchar(6) PRIMARY KEY NOT NULL,
	TenDauSach nvarchar(200) NOT NULL,
	IDLoaiSach varchar(6) FOREIGN KEY REFERENCES LOAISACH(IDLoaiSach)
)

INSERT INTO DAUSACH VALUES ('DSA001', 'Doraemon', 'LSA001')
INSERT INTO DAUSACH VALUES ('DSA002', N'Ngữ Văn', 'LSA002')
INSERT INTO DAUSACH VALUES ('DSA003', N'Vẽ Hình', 'LSA003')


--DROP TABLE SACH
CREATE TABLE SACH
(
	IDSach varchar(6) PRIMARY KEY NOT NULL,
	IDDauSach varchar(6) FOREIGN KEY REFERENCES DAUSACH(IDDauSach),
	IDCTTacGia varchar(6) FOREIGN KEY REFERENCES CT_TACGIA(IDCTTacGia), --bổ sung
	NhaXB nvarchar(20) NOT NULL,
	NamXB int NOT NULL,
	SoLuongTon int DEFAULT(0),
	GiaTien money DEFAULT(0) NOT NULL
)

INSERT INTO SACH (IDSach, IDDauSach, IDCTTacGia, NhaXB, NamXB, GiaTien) VALUES ('ISA001', 'DSA001', 'CTG001', N'Kim Đồng', 2002, 3000)
INSERT INTO SACH (IDSach, IDDauSach, IDCTTacGia, NhaXB, NamXB, GiaTien) VALUES ('ISA002', 'DSA002', 'CTG002', N'Kim Đồng', 2010, 7000)
INSERT INTO SACH (IDSach, IDDauSach, IDCTTacGia, NhaXB, NamXB, GiaTien) VALUES ('ISA003', 'DSA002', 'CTG003', N'Kông Đìm', 2012, 2000)
INSERT INTO SACH (IDSach, IDDauSach, IDCTTacGia, NhaXB, NamXB, GiaTien) VALUES ('ISA004', 'DSA003', 'CTG004', N'Kìm Đông', 2018, 4000)
INSERT INTO SACH (IDSach, IDDauSach, IDCTTacGia, NhaXB, NamXB, GiaTien) VALUES ('ISA005', 'DSA001', 'CTG001', N'Trẻ', 2017, 2750)
INSERT INTO SACH (IDSach, IDDauSach, IDCTTacGia, NhaXB, NamXB, GiaTien) VALUES ('ISA006', 'DSA001', 'CTG001', N'Trẻ', 2018, 2500)

--DROP TABLE CUONSACH
CREATE TABLE CUONSACH
(
	IDCuonSach varchar(6) PRIMARY KEY NOT NULL,
	IDSach varchar(6) FOREIGN KEY REFERENCES SACH(IDSach),
	TinhTrang nvarchar(20) DEFAULT(N'Chưa cho mượn') --o
)

INSERT INTO CUONSACH (IDCuonSach, IDSach) VALUES ('CSA001', 'ISA001')
INSERT INTO CUONSACH (IDCuonSach, IDSach) VALUES ('CSA002', 'ISA002')
INSERT INTO CUONSACH (IDCuonSach, IDSach) VALUES ('CSA003', 'ISA003')
INSERT INTO CUONSACH (IDCuonSach, IDSach) VALUES ('CSA004', 'ISA004')
INSERT INTO CUONSACH (IDCuonSach, IDSach) VALUES ('CSA005', 'ISA004')
INSERT INTO CUONSACH (IDCuonSach, IDSach) VALUES ('CSA006', 'ISA004')
INSERT INTO CUONSACH (IDCuonSach, IDSach) VALUES ('CSA007', 'ISA006')

--DROP TABLE TACGIA
CREATE TABLE TACGIA
(
	IDTacGia varchar(6) PRIMARY KEY NOT NULL,
	TenTacGia nvarchar(50) NOT NULL,
	NgaySinh date NOT NULL
)

INSERT INTO TACGIA VALUES ('ITG001', 'Anh', '1/1/1997')
INSERT INTO TACGIA VALUES ('ITG002', 'Banh', '1/1/2000')
INSERT INTO TACGIA VALUES ('ITG003', 'Canh', '5/1/2000')


--DROP TABLE CT_TACGIA
CREATE TABLE CT_TACGIA
(
	IDCTTacGia varchar(6) PRIMARY KEY NOT NULL,
	IDDauSach varchar(6) FOREIGN KEY REFERENCES DAUSACH(IDDauSach),
	IDTacGia varchar(6) FOREIGN KEY REFERENCES TACGIA(IDTacGia)
	--CONSTRAINT PK_CTG PRIMARY KEY (IDDauSach, IDTacGia)
)

INSERT INTO CT_TACGIA VALUES ('CTG001', 'DSA001', 'ITG001')
INSERT INTO CT_TACGIA VALUES ('CTG002', 'DSA002', 'ITG002')
INSERT INTO CT_TACGIA VALUES ('CTG003', 'DSA002', 'ITG003')
INSERT INTO CT_TACGIA VALUES ('CTG004', 'DSA003', 'ITG002')
--------------------------------------------------------------------------------------------------------------------------------------

--___________________________________________________________ PHIEUNHAPSACH ________________________________________________________--
--DROP TABLE PHIEUNHAPSACH
CREATE TABLE PHIEUNHAPSACH
(
	IDPhieuNhap varchar(6) PRIMARY KEY NOT NULL,
	NgayNhap date NOT NULL,
	TongTien money DEFAULT(0) --o
)

INSERT INTO PHIEUNHAPSACH (IDPhieuNhap, NgayNhap) VALUES ('INS001', '1/1/2008')
INSERT INTO PHIEUNHAPSACH (IDPhieuNhap, NgayNhap) VALUES ('INS002', '6/9/2010')


--DROP TABLE CT_PHIEUNHAPSACH
CREATE TABLE CT_PHIEUNHAPSACH
(
	IDCTPhieuNhap varchar(6) PRIMARY KEY NOT NULL,
	IDPhieuNhap varchar(6) FOREIGN KEY REFERENCES PHIEUNHAPSACH(IDPhieuNhap),
	IDSach varchar(6) FOREIGN KEY REFERENCES SACH(IDSach),
	SoLuong int DEFAULT(0) NOT NULL,
	DonGia money DEFAULT(0) NOT NULL,
	ThanhTien money DEFAULT(0) --o
)

INSERT INTO CT_PHIEUNHAPSACH (IDCTPhieuNhap, IDPhieuNhap, IDSach, SoLuong, DonGia) VALUES ('CNS001', 'INS001', 'ISA001', 100, 2000)
INSERT INTO CT_PHIEUNHAPSACH (IDCTPhieuNhap, IDPhieuNhap, IDSach, SoLuong, DonGia) VALUES ('CNS002', 'INS001', 'ISA002', 50, 6000)
INSERT INTO CT_PHIEUNHAPSACH (IDCTPhieuNhap, IDPhieuNhap, IDSach, SoLuong, DonGia) VALUES ('CNS003', 'INS002', 'ISA001', 60, 1900)
INSERT INTO CT_PHIEUNHAPSACH (IDCTPhieuNhap, IDPhieuNhap, IDSach, SoLuong, DonGia) VALUES ('CNS004', 'INS002', 'ISA003', 90, 1500)
INSERT INTO CT_PHIEUNHAPSACH (IDCTPhieuNhap, IDPhieuNhap, IDSach, SoLuong, DonGia) VALUES ('CNS005', 'INS002', 'ISA004', 150, 2800)
INSERT INTO CT_PHIEUNHAPSACH (IDCTPhieuNhap, IDPhieuNhap, IDSach, SoLuong, DonGia) VALUES ('CNS006', 'INS002', 'ISA005', 200, 2500)
--INSERT INTO CT_PHIEUNHAPSACH (IDCTPhieuNhap, IDPhieuNhap, IDSach, SoLuong, DonGia) VALUES ('CNS007', 'INS002', 'ISA006', 50, 2300)
--------------------------------------------------------------------------------------------------------------------------------------

--___________________________________________________________ PHIEUMUON ____________________________________________________________--
--DROP TABLE PHIEUMUON
CREATE TABLE PHIEUMUON
(
	IDPhieuMuon varchar(6) PRIMARY KEY NOT NULL,	
	IDDocGia varchar(6) FOREIGN KEY REFERENCES THEDOCGIA(IDDocGia),
	NgayMuon date NOT NULL,
	HanTra date --o
)

INSERT INTO PHIEUMUON (IDPhieuMuon, IDDocGia, NgayMuon) VALUES ('IPM001', 'IDG001', '1/1/2018')
INSERT INTO PHIEUMUON (IDPhieuMuon, IDDocGia, NgayMuon) VALUES ('IPM002', 'IDG001', '3/1/2018')
INSERT INTO PHIEUMUON (IDPhieuMuon, IDDocGia, NgayMuon) VALUES ('IPM003', 'IDG002', '1/3/2018')
INSERT INTO PHIEUMUON (IDPhieuMuon, IDDocGia, NgayMuon) VALUES ('IPM004', 'IDG001', '12/3/2018')


--DROP TABLE CT_PHIEUMUON
CREATE TABLE CT_PHIEUMUON
(
	IDCTPhieuMuon varchar(6) NOT NULL,
	IDPhieuMuon varchar(6) FOREIGN KEY REFERENCES PHIEUMUON(IDPhieuMuon),
	IDCuonSach varchar(6) FOREIGN KEY REFERENCES CUONSACH(IDCuonSach)
	CONSTRAINT PK_CPM PRIMARY KEY (IDCTPhieuMuon, IDCuonSach) --- 26/5
)

INSERT INTO CT_PHIEUMUON VALUES ('CPM001', 'IPM001', 'CSA001')
INSERT INTO CT_PHIEUMUON VALUES ('CPM002', 'IPM001', 'CSA003')
INSERT INTO CT_PHIEUMUON VALUES ('CPM003', 'IPM002', 'CSA002')
INSERT INTO CT_PHIEUMUON VALUES ('CPM004', 'IPM002', 'CSA004')
INSERT INTO CT_PHIEUMUON VALUES ('CPM005', 'IPM003', 'CSA005')
INSERT INTO CT_PHIEUMUON VALUES ('CPM006', 'IPM004', 'CSA006') /*phải trả pm1, pm2 trước*/
INSERT INTO CT_PHIEUMUON VALUES ('CPM007', 'IPM004', 'CSA005') /*lỗi vì còn sách quá hạn chưa trả*/
INSERT INTO CT_PHIEUMUON VALUES ('CPM008', 'IPM004', 'CSA007') /*lỗi vì số lượng tồn = 0*/
--------------------------------------------------------------------------------------------------------------------------------------

--___________________________________________________________ PHIEUTRA _____________________________________________________________--
--DROP TABLE PHIEUTRA
CREATE TABLE PHIEUTRA
(
	IDPhieuTra varchar(6) PRIMARY KEY NOT NULL,
	IDDocGia varchar(6) FOREIGN KEY REFERENCES THEDOCGIA(IDDocGia), --IDSach điền vào CT_PHIEUTRA
	NgayTra date NOT NULL,
	TienPhatKyNay money DEFAULT(0), --o default
	SoTienTra money DEFAULT(0),
	TienNoKyNay money DEFAULT(0) --o default
)

INSERT INTO PHIEUTRA (IDPhieuTra, IDDocGia, NgayTra, SoTienTra) VALUES ('IPT001', 'IDG001', '7/1/2018', 1000)
INSERT INTO PHIEUTRA (IDPhieuTra, IDDocGia, NgayTra, SoTienTra) VALUES ('IPT002', 'IDG001', '10/1/2018', 5000)


--DROP TABLE CT_PHIEUTRA
CREATE TABLE CT_PHIEUTRA
(
	IDCTPhieuTra varchar(6) NOT NULL,
	IDPhieuTra varchar(6) FOREIGN KEY REFERENCES PHIEUTRA(IDPhieuTra),
	IDCuonSach varchar(6) FOREIGN KEY REFERENCES CUONSACH(IDCuonSach),
	IDPhieuMuon varchar(6) FOREIGN KEY REFERENCES PHIEUMUON(IDPhieuMuon), --o
	SoNgayMuon int, --o
	TienPhat money DEFAULT(0) --o
	CONSTRAINT PK_CPT PRIMARY KEY (IDCTPhieuTra, IDPhieuTra, IDCuonSach) --- 26/5
)

INSERT INTO CT_PHIEUTRA (IDCTPhieuTra, IDPhieuTra, IDCuonSach) VALUES ('CPT001', 'IPT001', 'CSA001')
INSERT INTO CT_PHIEUTRA (IDCTPhieuTra, IDPhieuTra, IDCuonSach) VALUES ('CPT002', 'IPT001', 'CSA002')
INSERT INTO CT_PHIEUTRA (IDCTPhieuTra, IDPhieuTra, IDCuonSach) VALUES ('CPT003', 'IPT002', 'CSA003')
INSERT INTO CT_PHIEUTRA (IDCTPhieuTra, IDPhieuTra, IDCuonSach) VALUES ('CPT004', 'IPT002', 'CSA004')
--------------------------------------------------------------------------------------------------------------------------------------

--___________________________________________________________ PHIEUTHUTIENPHAT _____________________________________________________--
--DROP TABLE PHIEUTHUTIENPHAT
CREATE TABLE PHIEUTHUTIENPHAT
(
	IDPhieuThu varchar(6) PRIMARY KEY NOT NULL,
	IDDocGia varchar(6) FOREIGN KEY REFERENCES THEDOCGIA(IDDocGia),
	NgayLap date NOT NULL,
	SoTienThu money DEFAULT(0),
	ConLai money DEFAULT(0) --O
)
--------------------------------------------------------------------------------------------------------------------------------------

--___________________________________________________________ BCTINHHINHMUONSACH ___________________________________________________--
--DROP TABLE BCTINHHINHMUONSACH
CREATE TABLE BCTINHHINHMUONSACH
(
	IDBCMuonSach varchar(6) PRIMARY KEY NOT NULL,
	NgayLap date, --- 28/5
	Thang int NOT NULL,
	Nam int NOT NULL,	
	TongSoLuotMuon int DEFAULT(0) --o
)


--DROP TABLE CT_BCTINHHINHMUONSACH
CREATE TABLE CT_BCTINHHINHMUONSACH
(
	IDCTBCMuonSach varchar(6) PRIMARY KEY NOT NULL,
	IDBCMuonSach varchar(6) FOREIGN KEY REFERENCES BCTINHHINHMUONSACH(IDBCMuonSach),
	IDLoaiSach varchar(6) FOREIGN KEY REFERENCES LOAISACH(IDLoaiSach),
	SoLuotMuon int DEFAULT(0), --o
	TiLe float DEFAULT(0) --o
)
--------------------------------------------------------------------------------------------------------------------------------------

--___________________________________________________________ BCSACHTRATRE _________________________________________________________--
--DROP TABLE BCSACHTRATRE
CREATE TABLE BCSACHTRATRE
(
	IDBCSachTre varchar(6) PRIMARY KEY NOT NULL,
	NgayThangNam date NOT NULL,
	IDCuonSach varchar(6) FOREIGN KEY REFERENCES CUONSACH(IDCuonSach),
	IDPhieuMuon varchar(6) FOREIGN KEY REFERENCES PHIEUMUON(IDPhieuMuon),
	SoNgayTraTre int --
)
--------------------------------------------------------------------------------------------------------------------------------------

--___________________________________________________________ USERS ________________________________________________________________--
DROP TABLE USERS
CREATE TABLE USERS
(
	UserName varchar(50) PRIMARY KEY NOT NULL,	
	Pwd varchar(50) NOT NULL,
	IDDocGia varchar(6) FOREIGN KEY REFERENCES THEDOCGIA(IDDocGia)
)

DROP TABLE USERADMIN
CREATE TABLE USERADMIN
(	
	UserNameAdmin varchar(50) PRIMARY KEY NOT NULL,
	PasswordAdmin varchar(50) NOT NULL,
	IDAdmin varchar(6) FOREIGN KEY REFERENCES CT_USERADMIN(IDAdmin) --- 21/5
)

INSERT INTO USERADMIN VALUES ('HunterTeam', '05123', 'IAD001')
INSERT INTO USERADMIN VALUES ('baoduy', '1', 'IAD002')
INSERT INTO USERADMIN VALUES ('a', '1', 'IAD003')

DROP TABLE CT_USERADMIN --- 21/5
CREATE TABLE CT_USERADMIN
(	
	IDAdmin varchar(6) PRIMARY KEY NOT NULL,
	HoTenAdmin nvarchar(50) NOT NULL,
	NgaySinhAdmin date NOT NULL,
	DiaChiAdmin nvarchar(50) NOT NULL,
	EmailAdmin varchar(30) NOT NULL
)

INSERT INTO CT_USERADMIN VALUES ('IAD001', N'Văn A', '5/5/2015', N'Nhà', 'vana@yahoo.com')
INSERT INTO CT_USERADMIN VALUES ('IAD002', N'Văn Ắ', '4/4/2016', N'Trường', 'vanaw@gmail.com')
INSERT INTO CT_USERADMIN VALUES ('IAD003', N'a', '6/6/2010', N'a', 'a@gmail.com')
--------------------------------------------------------------------------------------------------------------------------------------

--___________________________________________________________ THAMSO _______________________________________________________________--
--DROP TABLE THAMSO
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

INSERT INTO THAMSO VALUES (18, 55, 6, 8, 5, 4, 1000, 1)
--INSERT INTO THAMSO (TuoiMin, TuoiMax)  VALUES (18, 55)
--------------------------------------------------------------------------------------------------------------------------------------



--*********************************************************** (TRIGGER) ************************************************************--
--*********************************************************** (TRIGGER) ************************************************************--
--*********************************************************** (TRIGGER) ************************************************************--
--*********************************************************** (TRIGGER) ************************************************************--
--*********************************************************** (TRIGGER) ************************************************************--
															  ---****---


--___________________________________________________________ THEDOCGIA ____________________________________________________________--
--DROP TRIGGER TRG_IU_IDG
CREATE TRIGGER TRG_IU_IDG ON THEDOCGIA
FOR INSERT, UPDATE
AS
BEGIN

/*Tuổi độc giả*/
	DECLARE @NGAYSINHDG date, @NGAYLAPTHE date, @TUOIMIN int, @TUOIMAX int
	
	SELECT @NGAYSINHDG = NgaySinhDG, @NGAYLAPTHE = NgayLapThe
	FROM INSERTED
	SELECT @TUOIMIN = TuoiMin, @TUOIMAX = TuoiMax
	FROM THAMSO

	IF (DATEDIFF(year, @NGAYSINHDG, @NGAYLAPTHE) < @TUOIMIN OR DATEDIFF(year, @NGAYSINHDG,  @NGAYLAPTHE) > @TUOIMAX)
	BEGIN
		PRINT N'Lỗi: Tuổi của độc giả phải từ ' + CAST(@TUOIMIN AS varchar) + N' đến ' + CAST(@TUOIMAX AS varchar)
		ROLLBACK TRANSACTION
	END	

/*Ngày hết hạn thẻ*/
	UPDATE THEDOCGIA 
	SET NgayHetHan = DATEADD(month, O.HanThe, I.NgayLapThe)
	FROM INSERTED I, THAMSO O, THEDOCGIA A
	WHERE A.IDDocGia = I.IDDocGia

END
--------------------------------------------------------------------------------------------------------------------------------------

--___________________________________________________________ SACH _____________________________________________________________--
--DROP TRIGGER TRG_ISA
CREATE TRIGGER TRG_ISA ON SACH
FOR INSERT, UPDATE
AS
BEGIN

/*NamXB > NgaySinh*/
	DECLARE @NAMXB int, @NAMSINH int

	SELECT @NAMXB = NamXB
	FROM INSERTED
	SELECT @NAMSINH = year(A.NgaySinh)
	FROM INSERTED I, TACGIA A, CT_TACGIA B
	WHERE B.IDCTTacGia = I.IDCTTacGia AND A.IDTacGia = B.IDTacGia

	IF (@NAMXB <= @NAMSINH)
	BEGIN
		PRINT N'Năm xuất bản phải lớn hơn ngày sinh của tác giả'
		ROLLBACK TRANSACTION
	END

/*Sách xuất bản 8 năm*/
	DECLARE @NGAYNHAP date, @KHOANGCACHXB int

	SELECT @NGAYNHAP = A.NgayNhap 
	FROM INSERTED I, PHIEUNHAPSACH A, CT_PHIEUNHAPSACH B
	WHERE A.IDPhieuNhap = B.IDPhieuNhap AND B.IDSach = I.IDSach	
	SELECT @KHOANGCACHXB = KhoangCachXB
	FROM THAMSO

	IF((year(@NGAYNHAP) - @NAMXB) > @KHOANGCACHXB)
	BEGIN
		PRINT N'Lỗi: Chỉ nhận các sách xuất bản trong vòng ' + CAST(@KHOANGCACHXB AS varchar) + N' năm'
		ROLLBACK TRANSACTION
	END

END

--_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _

--DROP TRIGGER TRG_ITG
CREATE TRIGGER TRG_ITG ON TACGIA
FOR INSERT
AS
BEGIN

/*Max 100 tác giả*/
	IF((SELECT COUNT(DISTINCT IDTacGia) FROM TACGIA) > 100)
	BEGIN
		PRINT N'Lỗi: Vượt quá 100 tác giả'
		ROLLBACK TRANSACTION
	END

END
--------------------------------------------------------------------------------------------------------------------------------------

--___________________________________________________________ PHIEUNHAPSACH ________________________________________________________--
--DROP TRIGGER TRG_U_IPN
CREATE TRIGGER TRG_U_IPN ON PHIEUNHAPSACH
FOR UPDATE
AS
BEGIN

	DECLARE @NGAYNHAPI date, @NGAYNHAPD date, @KHOANGCACHXB int
	SELECT @NGAYNHAPI = I.NgayNhap, @NGAYNHAPD = D.NgayNhap
	FROM INSERTED I, DELETED D
	SELECT @KHOANGCACHXB = KhoangCachXB
	FROM THAMSO

	IF(@NGAYNHAPI <> @NGAYNHAPD)
	BEGIN
		DECLARE @ROWNUM int, @ROW int = 0
		SELECT @ROWNUM = (SELECT COUNT(*) FROM INSERTED I, CT_PHIEUNHAPSACH A
						  WHERE A.IDPhieuNhap = I.IDPhieuNhap)

		SELECT IDENTITY(int, 1, 1) AS Num, IDCTPhieuNhap, A.IDPhieuNhap, IDSach, SoLuong, DonGia, ThanhTien INTO #INSERTED FROM INSERTED I, CT_PHIEUNHAPSACH A
																																  WHERE A.IDPhieuNhap = I.IDPhieuNhap
		
		WHILE (@ROW < @ROWNUM)
		BEGIN
			SET @ROW += 1

			DECLARE @NAMXB int

			SELECT @NAMXB = NamXB 
			FROM #INSERTED I, SACH A
			WHERE A.IDSach = I.IDSach AND I.Num = @ROW

			IF((year(@NGAYNHAPI) - @NAMXB) > @KHOANGCACHXB)
			BEGIN
				PRINT N'Lỗi: Chỉ nhận các sách xuất bản trong vòng ' + CAST(@KHOANGCACHXB AS varchar) + N' năm'
				ROLLBACK TRANSACTION
			END
		END
	END

END

--_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _

--DROP TRIGGER TRG_IU_CPN
CREATE TRIGGER TRG_IU_CPN ON CT_PHIEUNHAPSACH
FOR INSERT, UPDATE
AS
BEGIN

/*SoLuong <= SoLuongTon, DonGia < GiaTien*/
	DECLARE @DONGIA money, @GIATIEN money

	SELECT @DONGIA = DonGia, @GIATIEN = GiaTien
	FROM INSERTED I, SACH A
	WHERE A.IDSach = I.IDSach	

	IF (@DONGIA >= @GIATIEN)
	BEGIN
		PRINT N'Đơn giá sách khi nhập phải bé hơn giá tiền của sách'
		ROLLBACK TRANSACTION
	END

/*Sách xuất bản 8 năm*/
	DECLARE @NGAYNHAP date, @NAMXB int, @KHOANGCACHXB int

	SELECT @NGAYNHAP = NgayNhap 
	FROM INSERTED I, PHIEUNHAPSACH A
	WHERE I.IDPhieuNhap = A.IDPhieuNhap
	SELECT @NAMXB = NamXB
	FROM INSERTED I, SACH A
	WHERE I.IDSach = A.IDSach
	SELECT @KHOANGCACHXB = KhoangCachXB
	FROM THAMSO

	IF((year(@NGAYNHAP) - @NAMXB) > @KHOANGCACHXB)
	BEGIN
		PRINT N'Lỗi: Chỉ nhận các sách xuất bản trong vòng ' + CAST(@KHOANGCACHXB AS varchar) + N' năm'
		ROLLBACK TRANSACTION
	END

/*UPDATE SoLuongTon*/
	IF (NOT EXISTS (SELECT * FROM DELETED))
	BEGIN
		UPDATE SACH
		SET SoLuongTon = A.SoLuongTon + I.SoLuong
		FROM INSERTED I, SACH A
		WHERE A.IDSach = I.IDSach
	END
	ELSE
	BEGIN
		UPDATE SACH
		SET SoLuongTon = A.SoLuongTon + I.SoLuong
		FROM INSERTED I, SACH A
		WHERE A.IDSach = I.IDSach

		UPDATE SACH
		SET SoLuongTon = A.SoLuongTon - L.SoLuong
		FROM DELETED L, SACH A
		WHERE A.IDSach = L.IDSach
	END

/*ThanhTien*/	
	UPDATE CT_PHIEUNHAPSACH
	SET ThanhTien = I.SoLuong * I.DonGia
	FROM INSERTED I, CT_PHIEUNHAPSACH A
	WHERE A.IDCTPhieuNhap = I.IDCTPhieuNhap

/*TongTien*/	
	UPDATE PHIEUNHAPSACH
	SET TongTien = (SELECT SUM(A.ThanhTien)
					FROM INSERTED I, CT_PHIEUNHAPSACH A
					WHERE A.IDPhieuNhap = I.IDPhieuNhap)
	FROM INSERTED I, PHIEUNHAPSACH A
	WHERE A.IDPhieuNhap = I.IDPhieuNhap

END

--_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _

--DROP TRIGGER TRG_D_CPN
CREATE TRIGGER TRG_D_CPN ON CT_PHIEUNHAPSACH
FOR DELETE
AS
BEGIN

	UPDATE PHIEUNHAPSACH
	SET TongTien = (SELECT SUM(A.ThanhTien)
					FROM DELETED L, CT_PHIEUNHAPSACH A
					WHERE A.IDPhieuNhap = L.IDPhieuNhap)
	FROM DELETED L, PHIEUNHAPSACH A
	WHERE A.IDPhieuNhap = L.IDPhieuNhap

	UPDATE SACH
	SET SoLuongTon = A.SoLuongTon - L.SoLuong
	FROM DELETED L, SACH A
	WHERE A.IDSach = L.IDSach

END
--------------------------------------------------------------------------------------------------------------------------------------

--___________________________________________________________ PHIEUMUON _____________________________________________________________--
--DROP TRIGGER TRG_IU_IPM
CREATE TRIGGER TRG_IU_IPM ON PHIEUMUON
FOR INSERT, UPDATE
AS
BEGIN

/*NgayMuon > NgayLapThe*/
	DECLARE @NGAYMUON date, @NGAYLAPTHE date
	
	SELECT @NGAYMUON = NgayMuon, @NGAYLAPTHE = NgayLapThe
	FROM INSERTED I, THEDOCGIA A
	WHERE A.IDDocGia = I.IDDocGia

	IF (@NGAYMUON < @NGAYLAPTHE)
	BEGIN
		PRINT N'Ngày mượn sách phải lớn hơn hoặc bằng ngày lập thẻ độc giả'
		ROLLBACK TRANSACTION
	END

/*Hạn trả 4 ngày*/
	UPDATE PHIEUMUON
	SET HanTra = DATEADD(day, O.SoNgayMuonMax, I.NgayMuon)
	FROM INSERTED I, THAMSO O, PHIEUMUON A
	WHERE A.IDPhieuMuon = I.IDPhieuMuon

/*UPDATE SoNgayMuon(CT_PHIEUTRA) khi UPDATE NgayMuon*/
	DECLARE @NGAYMUONI date, @NGAYMUOND date
	SELECT @NGAYMUONI = I.NgayMuon, @NGAYMUOND = D.NgayMuon
	FROM INSERTED I, DELETED D

	IF(@NGAYMUONI <> @NGAYMUOND)
	BEGIN
		UPDATE CUONSACH
		SET TinhTrang = N'Đã cho mượn'
		FROM INSERTED I, CUONSACH A, CT_PHIEUMUON B
		WHERE B.IDPhieuMuon = I.IDPhieuMuon AND A.IDCuonSach = B.IDCuonSach

		UPDATE CT_PHIEUTRA
		SET	SoNgayMuon = DATEDIFF(day, I.NgayMuon, A.NgayTra)
		FROM INSERTED I, PHIEUTRA A, CT_PHIEUTRA B
		WHERE B.IDPhieuMuon = I.IDPhieuMuon
			  AND A.IDPhieuTra = B.IDPhieuTra
	END

END

--_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _

--DROP TRIGGER TRG_IU_CPM
CREATE TRIGGER TRG_IU_CPM ON CT_PHIEUMUON
FOR INSERT, UPDATE
AS
BEGIN

/*Kiểm tra sách còn số lượng tồn k*/
	DECLARE @SOLUONGTON int

	SELECT @SOLUONGTON = B.SoLuongTon
	FROM INSERTED I, CUONSACH A, SACH B
	WHERE A.IDCuonSach = I.IDCuonSach AND B.IDSach = A.IDSach

	IF (@SOLUONGTON = 0)
	BEGIN
		PRINT N'Số lượng sách đã hết'
		ROLLBACK TRANSACTION
	END
/*Quy định cho mượn sách.9*/
	DECLARE @NGAYHETHAN date, @IDCUONSACH varchar(6), @IDDOCGIA varchar(6), @NGAYMUON date, @TINHTRANG nvarchar(20)
		
	SELECT @IDCUONSACH = IDCuonSach, @IDDOCGIA = IDDocGia, @NGAYMUON = NgayMuon
	FROM INSERTED I, PHIEUMUON A
	WHERE I.IDPhieuMuon = A.IDPhieuMuon
	SELECT @NGAYHETHAN = NgayHetHan
	FROM THEDOCGIA
	WHERE IDDocGia = @IDDOCGIA
	SELECT @TINHTRANG = TinhTrang
	FROM CUONSACH
	WHERE IDCuonSach = @IDCUONSACH

	IF(@NGAYHETHAN <= @NGAYMUON) OR (@TINHTRANG = N'Đã cho mượn') OR EXISTS (SELECT * FROM PHIEUMUON A, CT_PHIEUMUON B, CUONSACH C
																		     WHERE A.IDPhieuMuon = B.IDPhieuMuon 
																			 AND A.IDDocGia = @IDDOCGIA AND A.HanTra < @NGAYMUON
																		     AND C.IDCuonSach = B.IDCuonSach AND C.TinhTrang = N'Đã cho mượn')
	BEGIN
		PRINT N'Lỗi: Chỉ cho mượn với thẻ còn hạn, không có sách mượn quá hạn, và sách không có người đang mượn'
		ROLLBACK TRANSACTION
	END
	ELSE
	BEGIN
		UPDATE CUONSACH
		SET TinhTrang = N'Đã cho mượn'
		WHERE IDCuonSach = @IDCUONSACH

		UPDATE SACH
		SET SoLuongTon -= 1
		FROM SACH A, CUONSACH B
		WHERE A.IDSach = B.IDSach AND B.IDCuonSach = @IDCUONSACH
	END

/*Mỗi độc giả Max mượn 5 cuốn*/
	DECLARE @SOSACHMUONMAX int	
	
	SELECT @SOSACHMUONMAX = SoSachMuonMax
	FROM THAMSO

	IF((SELECT COUNT(DISTINCT A.IDCuonSach) 
		FROM CT_PHIEUMUON A, PHIEUMUON B
		WHERE A.IDPhieuMuon = B.IDPhieuMuon AND B.IDDocGia = @IDDOCGIA
		AND NOT EXISTS (SELECT * FROM CT_PHIEUTRA C, PHIEUTRA D
						WHERE C.IDCuonSach = A.IDCuonSach AND C.IDPhieuTra = D.IDPhieuTra
						AND D.NgayTra < B.NgayMuon))) > @SOSACHMUONMAX		
	BEGIN
		PRINT N'Lỗi: Mỗi độc giả chỉ mượn tối đa ' + CAST(@SOSACHMUONMAX AS varchar) + N' quyển sách'
		ROLLBACK TRANSACTION 
	END	

END

--_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 

--DROP TRIGGER TRG_D_CPM
CREATE TRIGGER TRG_D_CPM ON CT_PHIEUMUON
FOR DELETE
AS
BEGIN	

	UPDATE CUONSACH
	SET TinhTrang = N'Chưa cho mượn'
	FROM DELETED L, CUONSACH A
	WHERE A.IDCuonSach = L.IDCuonSach

	UPDATE SACH --- 29/5
	SET SoLuongTon += 1
	FROM DELETED L, SACH A, CUONSACH B
	WHERE A.IDSach = B.IDSach AND B.IDCuonSach = L.IDCuonSach

END
--------------------------------------------------------------------------------------------------------------------------------------

--___________________________________________________________ PHIEUTRA _____________________________________________________________--
--DROP TRIGGER TRG_U_IPT
CREATE TRIGGER TRG_U_IPT ON PHIEUTRA
FOR UPDATE
AS
BEGIN

/*TienNoKyNay*/
	DECLARE @ROWNUM int, @ROW int = 0
	SELECT @ROWNUM = (SELECT COUNT(*) FROM INSERTED)

	SELECT IDENTITY(int, 1, 1) AS Num, IDPhieuTra, IDDocGia, NgayTra, TienPhatKyNay, SoTienTra, TienNoKyNay INTO #INSERTED FROM INSERTED
		
	WHILE (@ROW < @ROWNUM)
	BEGIN		
		SET @ROW += 1

		DECLARE @TIENPHATKYNAY money, @SOTIENTRA money

		SELECT @TIENPHATKYNAY = TienPhatKyNay, @SOTIENTRA = SoTienTra
		FROM #INSERTED I
		WHERE I.Num = @ROW

		IF (@SOTIENTRA > @TIENPHATKYNAY)
		BEGIN
			PRINT N'Số tiền trả(Phiếu trả) vượt quá tiền phạt kỳ này. Vui lòng nhập lại số tiền trả'

			UPDATE PHIEUTRA
			SET TienNoKyNay = 0
			FROM #INSERTED I, PHIEUTRA A
			WHERE A.IDPhieuTra = I.IDPhieuTra AND I.Num = @ROW
		END
		ELSE
		BEGIN
			UPDATE PHIEUTRA
			SET TienNoKyNay = A.TienPhatKyNay - A.SoTienTra
			FROM #INSERTED I, PHIEUTRA A
			WHERE A.IDPhieuTra = I.IDPhieuTra AND I.Num = @ROW
		END	
	END
	
/*TongNo*/
	UPDATE THEDOCGIA
	SET TongNo = (SELECT SUM(A.TienNoKyNay)
				  FROM INSERTED I, PHIEUTRA A
				  WHERE A.IDDocGia = I.IDDocGia)
	FROM INSERTED I, THEDOCGIA A
	WHERE A.IDDocGia = I.IDDocGia			  		

/*UPDATE SoNgayMuon(CT_PHIEUTRA) khi UPDATE NgayTra*/
	DECLARE @NGAYTRAI date, @NGAYTRAD date
	SELECT @NGAYTRAI = I.NgayTra, @NGAYTRAD = D.NgayTra
	FROM INSERTED I, DELETED D

	IF(@NGAYTRAI <> @NGAYTRAD)
	BEGIN
		UPDATE CUONSACH
		SET TinhTrang = N'Đã cho mượn'
		FROM INSERTED I, CUONSACH A, CT_PHIEUTRA B
		WHERE B.IDPhieuTra = I.IDPhieuTra AND A.IDCuonSach = B.IDCuonSach

		UPDATE CT_PHIEUTRA
		SET	SoNgayMuon = DATEDIFF(day, B.NgayMuon, I.NgayTra)
		FROM INSERTED I, CT_PHIEUTRA A, PHIEUMUON B
		WHERE A.IDPhieuTra = I.IDPhieuTra
			  AND B.IDPhieuMuon = A.IDPhieuMuon
	END

END
--_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 

--DROP TRIGGER TRG_IU_CPT
CREATE TRIGGER TRG_IU_CPT ON CT_PHIEUTRA
FOR INSERT, UPDATE
AS
BEGIN

/*Điều kiện*/
	DECLARE @TINHTRANG nvarchar(20), @SONGAYMUONMAX int, @TIENPHATMOINGAY int
	
	SELECT @TINHTRANG = TinhTrang
	FROM INSERTED I, CUONSACH A
	WHERE A.IDCuonSach = I.IDCuonSach
	SELECT @SONGAYMUONMAX = SoNgayMuonMax, @TIENPHATMOINGAY = TienPhatMoiNgay
	FROM THAMSO	

	IF (@TINHTRANG = N'Chưa cho mượn') --****
	BEGIN
		PRINT N'Sách chưa cho mượn'
		ROLLBACK TRANSACTION
	END	
	ELSE
	BEGIN

	/*IDPhieuMuon, SoNgayMuon*/
		UPDATE CT_PHIEUTRA
		SET IDPhieuMuon = C.IDPhieuMuon, SoNgayMuon = DATEDIFF(day, C.NgayMuon, A.NgayTra)
		FROM INSERTED I, PHIEUTRA A, CT_PHIEUTRA B, PHIEUMUON C, CT_PHIEUMUON D
		WHERE B.IDCTPhieuTra = I.IDCTPhieuTra
			  AND A.IDPhieuTra = B.IDPhieuTra AND C.IDPhieuMuon = D.IDPhieuMuon 
			  AND B.IDCuonSach = D.IDCuonSach AND NOT EXISTS (SELECT * FROM INSERTED I, PHIEUTRA A, CT_PHIEUTRA B, PHIEUMUON C, CT_PHIEUMUON D
															  WHERE A.IDPhieuTra = B.IDPhieuTra AND C.IDPhieuMuon = D.IDPhieuMuon
																	AND B.IDCuonSach = D.IDCuonSach AND B.IDCuonSach = I.IDCuonSach AND B.IDPhieuMuon = C.IDPhieuMuon)
																	
	/*NgayTra > NgayMuon*/
		DECLARE @ROWNUM1 int, @ROW1 int = 0
		SELECT @ROWNUM1 = (SELECT COUNT(*) FROM INSERTED)

		SELECT IDENTITY(int, 1, 1) AS Num1, IDCTPhieuTra, IDPhieuTra, IDCuonSach, IDPhieuMuon, SoNgayMuon, TienPhat INTO #INSERTED1 FROM INSERTED
		
		WHILE (@ROW1 < @ROWNUM1)
		BEGIN
			SET @ROW1 += 1
			
			DECLARE @SONGAYMUON int

			SELECT @SONGAYMUON = A.SoNgayMuon
			FROM #INSERTED1 I1, CT_PHIEUTRA A
			WHERE A.IDCTPhieuTra = I1.IDCTPhieuTra AND I1.Num1 = @ROW1

			IF (@SONGAYMUON < 0)
			BEGIN
				PRINT N'Ngày trả(phiếu trả) phải lớn hơn ngày mượn(phiếu mượn)'
				ROLLBACK TRANSACTION
			END	

			IF (@SONGAYMUON = 0)
			BEGIN
				UPDATE CT_PHIEUTRA
				SET SoNgayMuon = 1
				FROM #INSERTED1 I1, CT_PHIEUTRA A
				WHERE A.IDCTPhieuTra = I1.IDCTPhieuTra AND I1.Num1 = @ROW1		
			END

	/*TienPhat và Tự động thêm BCSACHTRATRE*/		
			DECLARE @NGAYTRA date, @IDCUONSACH varchar(6), @IDPHIEUMUON varchar(6)

			SELECT @NGAYTRA = NgayTra, @IDCUONSACH = I1.IDCuonSach, @IDPHIEUMUON = B.IDPhieuMuon --
			FROM #INSERTED1 I1, PHIEUTRA A, CT_PHIEUTRA B
			WHERE A.IDPhieuTra = I1.IDPhieuTra AND B.IDCTPhieuTra = I1.IDCTPhieuTra AND I1.Num1 = @ROW1

			IF (@SONGAYMUON > @SONGAYMUONMAX)
			BEGIN
				UPDATE CT_PHIEUTRA
				SET TienPhat = @TIENPHATMOINGAY * (A.SoNgayMuon - @SONGAYMUONMAX)
				FROM #INSERTED1 I1, CT_PHIEUTRA A
				WHERE A.IDCTPhieuTra = I1.IDCTPhieuTra AND I1.Num1 = @ROW1
		/*Tự động thêm BCSACHTRATRE*/ --- 23/5
				DECLARE @t int
				DECLARE @mt varchar(5) = 'IST00'				
				
				SET @t = (SELECT COUNT (IDBCSachTre) 
						  FROM BCSACHTRATRE)
				SET @t += 1
				IF (@t >= 10 AND @t < 100) 
				BEGIN
					SET @mt = 'IST0'
				END
				ELSE
				BEGIN
					IF (@t >= 100 AND @t < 1000) 
					BEGIN
						SET @mt = 'IST'
					END
				END				

				IF (EXISTS (SELECT * FROM #INSERTED1 I1, BCSACHTRATRE A 
									WHERE A.IDCuonSach = I1.IDCuonSach AND A.IDPhieuMuon = I1.IDPhieuMuon AND I1.Num1 = @ROW1))
				BEGIN
					UPDATE BCSACHTRATRE
					SET NgayThangNam = @NGAYTRA
					FROM #INSERTED1 I1, BCSACHTRATRE A
					WHERE A.IDCuonSach = I1.IDCuonSach AND A.IDPhieuMuon = I1.IDPhieuMuon AND I1.Num1 = @ROW1
				END
				ELSE
				BEGIN
					INSERT INTO BCSACHTRATRE (IDBCSachTre, NgayThangNam, IDCuonSach, IDPhieuMuon) VALUES (@mt + CAST(@t AS varchar), @NGAYTRA, @IDCUONSACH, @IDPHIEUMUON)
				END
			END
			ELSE
			BEGIN
				UPDATE CT_PHIEUTRA
				SET TienPhat = 0
				FROM #INSERTED1 I1, CT_PHIEUTRA A
				WHERE A.IDCTPhieuTra = I1.IDCTPhieuTra AND I1.Num1 = @ROW1	
		/*update BCSACHTRATRE khi k trả trễ*/ --- 23/5
				UPDATE BCSACHTRATRE 
				SET SoNgayTraTre = 0
				WHERE IDCuonSach = @IDCUONSACH AND IDPhieuMuon = @IDPHIEUMUON
			END
		END

	/*Sau khi trả thành công*/
		UPDATE CUONSACH
		SET TinhTrang = N'Chưa cho mượn'
		FROM INSERTED I, CUONSACH A
		WHERE A.IDCuonSach = I.IDCuonSach

	/*Thay đổi IDCuonSach cùng hàng*/
		DECLARE @IDCUONSACHI varchar(6), @IDCUONSACHD varchar(6)
		SELECT @IDCUONSACHI = I.IDCuonSach, @IDCUONSACHD = D.IDCuonSach
		FROM INSERTED I, DELETED D	
		
		IF (@IDCUONSACHI <> @IDCUONSACHD)
		BEGIN
			UPDATE CUONSACH
			SET TinhTrang = N'Đã cho mượn'
			FROM DELETED D, CUONSACH A
			WHERE A.IDCuonSach = D.IDCuonSach

			UPDATE CUONSACH
			SET TinhTrang = N'Chưa cho mượn'
			FROM INSERTED I, CUONSACH A
			WHERE A.IDCuonSach = I.IDCuonSach
		END									
		
	/*TienPhatKyNay*/
		DECLARE @ROWNUM2 int, @ROW2 int = 0
		SELECT @ROWNUM2 = (SELECT COUNT(*) FROM INSERTED)

		SELECT IDENTITY(int, 1, 1) AS Num2, IDCTPhieuTra, IDPhieuTra, IDCuonSach, IDPhieuMuon, SoNgayMuon, TienPhat INTO #INSERTED2 FROM INSERTED
		
		WHILE (@ROW2 < @ROWNUM2)
		BEGIN
			SET @ROW2 += 1

			UPDATE PHIEUTRA
			SET TienPhatKyNay = (SELECT SUM(A.TienPhat)
							     FROM #INSERTED2 I2, CT_PHIEUTRA A
							     WHERE A.IDPhieuTra = I2.IDPhieuTra AND I2.Num2 = @ROW2)
			FROM #INSERTED2 I2, PHIEUTRA A
			WHERE A.IDPhieuTra = I2.IDPhieuTra AND I2.Num2 = @ROW2
		END
		
	END

END

--_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _

--DROP TRIGGER TRG_D_CPT
CREATE TRIGGER TRG_D_CPT ON CT_PHIEUTRA
FOR DELETE
AS
BEGIN

		UPDATE CUONSACH
		SET TinhTrang = N'Đã cho mượn'
		FROM DELETED L, CUONSACH A
		WHERE A.IDCuonSach = L.IDCuonSach
		
		UPDATE PHIEUTRA
		SET TienPhatKyNay = (SELECT SUM(A.TienPhat)
						     FROM DELETED L, CT_PHIEUTRA A
						     WHERE A.IDPhieuTra = L.IDPhieuTra)
		FROM DELETED L, PHIEUTRA A
		WHERE A.IDPhieuTra = L.IDPhieuTra
		
		UPDATE THEDOCGIA
		SET TongNo = (SELECT SUM(A.TienNoKyNay)
					  FROM DELETED L, PHIEUTRA A, THEDOCGIA B
					  WHERE A.IDPhieuTra = L.IDPhieuTra
							AND B.IDDocGia = A.IDDocGia)
		FROM DELETED L, PHIEUTRA A, THEDOCGIA B
		WHERE A.IDPhieuTra = L.IDPhieuTra
			  AND B.IDDocGia = A.IDDocGia

END
--------------------------------------------------------------------------------------------------------------------------------------

--___________________________________________________________ PHIEUTHUTIENPHAT _____________________________________________________________--
--DROP TRIGGER TRG_IU_ITP
CREATE TRIGGER TRG_IU_ITP ON PHIEUTHUTIENPHAT
FOR INSERT, UPDATE
AS
BEGIN

/*NgayLap >= min(NgayTra)*/
	DECLARE @NGAYLAP date, @NGAYTRA date

	SELECT @NGAYLAP = NgayLap
	FROM INSERTED
	SELECT @NGAYTRA = A.NgayTra
	FROM INSERTED I, PHIEUTRA A
	WHERE A.IDDocGia = I.IDDocGia AND NOT EXISTS (SELECT * FROM PHIEUTRA B
												  WHERE B.IDDocGia = A.IDDocGia AND B.NgayTra < A.NgayTra)

	IF (@NGAYLAP < @NGAYTRA)
	BEGIN
		PRINT N'Ngày lập phiếu thu tiền phạt phải lớn hơn hoặc bằng ngày trả sách đầu tiên của độc giả'
		ROLLBACK TRANSACTION
	END

/*Áp dụng QĐ số tiền thu*/
	DECLARE @SOTIENTHU money, @TONGNO money, @APDUNGQDSOTIENTHU int
	
	SELECT @SOTIENTHU = SoTienThu
	FROM INSERTED
	SELECT @TONGNO = TongNo
	FROM INSERTED I, THEDOCGIA A
	WHERE I.IDDocGia = A.IDDocGia
	SELECT @APDUNGQDSOTIENTHU = ApDungQDSoTienThu
	FROM THAMSO
	
	IF(@APDUNGQDSOTIENTHU = 1)
	BEGIN
		IF(@SOTIENTHU > @TONGNO)
		BEGIN
			PRINT N'Số tiền thu không được vượt quá số tiền độc giả đang nợ'
		END
	END

/*ConLai*/
	UPDATE PHIEUTHUTIENPHAT
	SET ConLai = B.TongNo + L.SoTienThu - I.SoTienThu
	FROM INSERTED I, DELETED L, PHIEUTHUTIENPHAT A, THEDOCGIA B
	WHERE A.IDPhieuThu = I.IDPhieuThu 
		  AND B.IDDocGia = I.IDDocGia

	UPDATE THEDOCGIA
	SET TongNo = I.ConLai
	FROM INSERTED I, THEDOCGIA A
	WHERE A.IDDocGia = I.IDDocGia

END

--_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _

--DROP TRIGGER TRG_D_ITP
CREATE TRIGGER TRG_D_ITP ON PHIEUTHUTIENPHAT
FOR DELETE
AS
BEGIN

	UPDATE THEDOCGIA
	SET TongNo = A.TongNo + L.SoTienThu
	FROM DELETED L, THEDOCGIA A
	WHERE A.IDDocGia = L.IDDocGia

END
--------------------------------------------------------------------------------------------------------------------------------------

--___________________________________________________________ BCTINHHINHMUONSACH _____________________________________________________________--
--DROP TRIGGER TRG_IU_IMS
CREATE TRIGGER TRG_IU_IMS ON BCTINHHINHMUONSACH
FOR INSERT, UPDATE
AS
BEGIN

/*Thang, Nam >= NgayMuon*/
	DECLARE @THANG int, @NAM int, @NGAYMUON date

	SELECT @THANG = Thang, @NAM = Nam
	FROM INSERTED
	SELECT @NGAYMUON = A.NgayMuon
	FROM PHIEUMUON A
	WHERE NOT EXISTS (SELECT * FROM PHIEUMUON B
					  WHERE B.NgayMuon < A.NgayMuon)

	IF (@NAM < year(@NGAYMUON) OR (@NAM = year(@NGAYMUON) AND @THANG < month(@NGAYMUON)))
	BEGIN
		PRINT N'Tháng năm của "Báo cáo thống kê tình hình mượn sách theo thể loại" phải lớn hơn hoặc bằng ngày mượn sách đầu tiên'
		ROLLBACK TRANSACTION
	END

END

--_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _

--DROP TRIGGER TRG_I_IMS
CREATE TRIGGER TRG_I_IMS ON BCTINHHINHMUONSACH
FOR INSERT
AS
BEGIN

/*NgayLap*/
	UPDATE BCTINHHINHMUONSACH
	SET NgayLap = GETDATE()
	FROM INSERTED I, BCTINHHINHMUONSACH A
	WHERE A.IDBCMuonSach = I.IDBCMuonSach

/*Tự động thêm CT_BCTINHHINHMUONSACH*/ --- 22/5
	DECLARE @t int, @j int, @i int = 1
	DECLARE @mt varchar(5) = 'CMS00', @mj varchar(5) = 'LSA00'
	DECLARE @IDBCMUONSACH varchar(6)
	
	SET @t = (SELECT COUNT (IDCTBCMuonSach) 
			  FROM CT_BCTINHHINHMUONSACH)
	SET @j = (SELECT COUNT (IDLoaiSach)
			  FROM LOAISACH)
	SELECT @IDBCMUONSACH = IDBCMuonSach
	FROM INSERTED	
		
	WHILE (@i <= @j)
	BEGIN
		SET @t += 1
		IF (@t >= 10 AND @t < 100) 
		BEGIN
			SET @mt = 'CMS0'
		END
		ELSE
		BEGIN
			IF (@t >= 100 AND @t < 1000) 
			BEGIN
				SET @mt = 'CMS'
			END
		END

		IF (@i >= 10 AND @i < 100) 
		BEGIN
			SET @mj = 'LSA0'
		END
		ELSE 
		BEGIN
			IF (@i >= 100 AND @i < 1000) 
			BEGIN
				SET @mj = 'LSA'
			END
		END
		
		INSERT INTO CT_BCTINHHINHMUONSACH (IDCTBCMuonSach, IDBCMuonSach, IDLoaiSach) VALUES (@mt + CAST(@t AS varchar), @IDBCMUONSACH, @mj + CAST(@i AS varchar))		
		SET @i += 1
	END

END

--_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _

--DROP TRIGGER TRG_IU_CMS
CREATE TRIGGER TRG_IU_CMS ON CT_BCTINHHINHMUONSACH
FOR INSERT, UPDATE
AS
BEGIN

/*SoLuotMuon*/
	UPDATE CT_BCTINHHINHMUONSACH
	SET SoLuotMuon = (SELECT COUNT(*) FROM INSERTED I, BCTINHHINHMUONSACH A, PHIEUMUON B, CT_PHIEUMUON C , CUONSACH D, SACH E, DAUSACH F
					  WHERE A.IDBCMuonSach = I.IDBCMuonSach AND B.IDPhieuMuon = C.IDPhieuMuon					        
						    AND C.IDCuonSach = D.IDCuonSach AND D.IDSach = E.IDSach AND E.IDDauSach = F.IDDauSach
						    AND F.IDLoaiSach = I.IDLoaiSach AND month(B.NgayMuon) = A.Thang AND year(B.NgayMuon) = A.Nam)
	FROM INSERTED I, CT_BCTINHHINHMUONSACH A
	WHERE A.IDCTBCMuonSach = I.IDCTBCMuonSach

/*TongSoLuotMuon*/
	UPDATE BCTINHHINHMUONSACH
	SET TongSoLuotMuon = (SELECT SUM(B.SoLuotMuon)
						  FROM INSERTED I, BCTINHHINHMUONSACH A, CT_BCTINHHINHMUONSACH B
						  WHERE A.IDBCMuonSach = I.IDBCMuonSach AND B.IDBCMuonSach = A.IDBCMuonSach)								
	FROM INSERTED I, BCTINHHINHMUONSACH A
	WHERE A.IDBCMuonSach = I.IDBCMuonSach

/*TiLe*/
	DECLARE @TONGSOLUOTMUON int

	SELECT @TONGSOLUOTMUON = TongSoLuotMuon
	FROM INSERTED I, BCTINHHINHMUONSACH A
	WHERE A.IDBCMuonSach = I.IDBCMuonSach

	IF (@TONGSOLUOTMUON = 0)
	BEGIN
		UPDATE CT_BCTINHHINHMUONSACH
		SET TiLe = 0
		FROM INSERTED I, CT_BCTINHHINHMUONSACH A
		WHERE A.IDCTBCMuonSach = I.IDCTBCMuonSach
	END
	ELSE
	BEGIN
		UPDATE CT_BCTINHHINHMUONSACH
		SET TiLe = CAST (B.SoLuotMuon AS float) / CAST (A.TongSoLuotMuon AS float)
		FROM INSERTED I, BCTINHHINHMUONSACH A, CT_BCTINHHINHMUONSACH B
		WHERE A.IDBCMuonSach = I.IDBCMuonSach AND B.IDBCMuonSach = A.IDBCMuonSach
	END

END
--------------------------------------------------------------------------------------------------------------------------------------

--___________________________________________________________ BCSACHTRATRE _________________________________________________________--
--DROP TRIGGER TRG_IU_IST
CREATE TRIGGER TRG_IU_IST ON BCSACHTRATRE
FOR INSERT, UPDATE
AS
BEGIN

/*NgayThangNam >= min(NgayTra)*/
	DECLARE @NGAYTHANGNAM date, @NGAYTRA date

	SELECT @NGAYTHANGNAM = NgayThangNam
	FROM INSERTED
	SELECT @NGAYTRA = A.NgayTra
	FROM PHIEUTRA A
	WHERE NOT EXISTS (SELECT * FROM PHIEUTRA B
					  WHERE B.NgayTra < A.NgayTra)

	IF (@NGAYTHANGNAM < @NGAYTRA)
	BEGIN
		PRINT N'Ngày tháng năm của "Báo cáo thông kê sách trả trễ" phải lớn hơn hoặc bằng ngày trả sách đầu tiên'
		ROLLBACK TRANSACTION
	END

/*SoNgayTraTre*/
	DECLARE @SONGAYMUONMAX int

	SELECT @SONGAYMUONMAX = SoNgayMuonMax 
	FROM THAMSO

	UPDATE BCSACHTRATRE
	SET SoNgayTraTre = SoNgayMuon - @SONGAYMUONMAX
	FROM INSERTED I, BCSACHTRATRE A, CT_PHIEUTRA B
	WHERE A.IDBCSachTre = I.IDBCSachTre
		  AND A.IDCuonSach = B.IDCuonSach AND A.IDPhieuMuon = B.IDPhieuMuon

END
--------------------------------------------------------------------------------------------------------------------------------------