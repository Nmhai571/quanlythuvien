create database CUAHANGSACH
use CUAHANGSACH


create table SACH
(
	Id int identity(1,1),
	TenSach nvarchar(30),
	TacGia nvarchar(30),
	Gia int,
	NamXuatBan datetime,
	AnhSach image,
	SoLuong int,
	IdTheLoaiSach int,
	IdNhaXuatBan int,
	primary key (Id)
)

create table NHAXUATBAN 
(
    Id int identity(1,1),
    TenNXB nvarchar(30),
	primary key (Id)
)



create table THELOAISACH
(
	Id int identity(1,1),
	TenTheLoai nvarchar(30)
	primary key (Id)

)

create table NHANVIEN
(
	Id int identity(1,1),
	HoTen nvarchar(30) not null,
	Luong int,
	SoDienThoai char(10),
	DiaChi nvarchar(50),
	IdRole int,
	primary key (Id)

)

create table Roles
(
	Id int identity(1,1),
	TenRole nvarchar(30),
	primary key (Id)
)
create table HOADONBANHANG
(
	Id int identity(1,1),
	NgayXuat datetime,
	IdNhanVien int,
	primary key (Id)
)



create table CHITIETHOADON
(
	Id int identity(1,1),
	IdSach int,
	IdHoaDon int,
	SoLuong int,
	TongHoaDon float,
	primary key (Id)
)



create table HOADONNNHAPHANG
(
	Id int identity(1,1),
	NgayXuat datetime,
	IdNhanVien int,
	IdNXB int,
	primary key (Id)
)


create table CHITIETHOADONNHAPHANG
(
	Id int identity(1,1),
	IdHoaDonNhapHang int,
	IdSach int,
	TongHoaDon float,
	SoLuong int,
	primary key (Id)
)

create table GIOHANG
(
	Id int identity(1,1),
	IdSach int,
	SoLuong int,
	primary key(Id)
)


--create foreign key
ALTER TABLE GIOHANG
ADD CONSTRAINT FK_GIOHANG_SACH FOREIGN KEY (IdSach) REFERENCES SACH(id)

ALTER TABLE NHANVIEN
ADD CONSTRAINT FK_NV_ROLE FOREIGN KEY (IdRole) REFERENCES Roles(id)

ALTER TABLE SACH
ADD CONSTRAINT FK_SACH_THELOAI FOREIGN KEY (IdTheLoaiSach) REFERENCES THELOAISACH(Id)

ALTER TABLE SACH
ADD CONSTRAINT FK_SACH_NHAXUATBAN FOREIGN KEY (IdNhaXuatBan) REFERENCES NHAXUATBAN(Id)

ALTER TABLE HOADONBANHANG
ADD CONSTRAINT FK_HOADON_NHANVIEN FOREIGN KEY (IdNhanVien) REFERENCES NHANVIEN(Id)

ALTER TABLE HOADONNNHAPHANG
ADD CONSTRAINT FK_HOADON_NHAPHANG FOREIGN KEY (IdNhanVien) REFERENCES NHANVIEN(Id)

ALTER TABLE HOADONNNHAPHANG
ADD CONSTRAINT FK_HOADON_NHAPHANG_NXB FOREIGN KEY (IdNXB) REFERENCES NHAXUATBAN(Id)

ALTER TABLE CHITIETHOADONNHAPHANG
ADD CONSTRAINT FK_CHITIETNHAPHANG_HOADON FOREIGN KEY (IdHoaDonNhapHang) REFERENCES HOADONNNHAPHANG(Id)

ALTER TABLE CHITIETHOADONNHAPHANG
ADD CONSTRAINT FK_CHITIETNHAPHANG_SACH FOREIGN KEY (IdSach) REFERENCES SACH(Id)

ALTER TABLE CHITIETHOADON
ADD CONSTRAINT FK_CHITIET_SACH FOREIGN KEY (IdSach) REFERENCES SACH(Id)

ALTER TABLE CHITIETHOADON
ADD CONSTRAINT FK_CHITIET_HOADON FOREIGN KEY (IdHoaDon) REFERENCES HOADONBANHANG(Id)

-- insert data
insert into NHAXUATBAN(TenNXB) values(N'Nhà Xuất Bản Kim Đồng');
insert into NHAXUATBAN(TenNXB) values(N'Nhà Xuất Bản Lao Động');
insert into NHAXUATBAN(TenNXB) values(N'Nhà Xuất Bản Đinh Tị Books');
insert into NHAXUATBAN(TenNXB) values(N'Nhà Xuất Bản Trẻ');
insert into NHAXUATBAN(TenNXB) values(N'Nhà Xuất Bản Đông A');

insert into THELOAISACH(TenTheLoai) values (N'Truyện Tranh');
insert into THELOAISACH(TenTheLoai) values (N'Tâm Lý');
insert into THELOAISACH(TenTheLoai) values (N'Tiểu Thuyết');
insert into THELOAISACH(TenTheLoai) values (N'Phát Triển Bản Thân');


insert into SACH(TenSach, TacGia, Gia, NamXuatBan, SoLuong, IdTheLoaiSach, IdNhaXuatBan, AnhSach) 
values (N'Đại Quản Gia Là Ma Hoàng', N'Đang Cập Nhật', 100000, '12/06/2002',10, 1, 1, (select * from openrowset(Bulk 'D:\DatabaseManagementSystem\Đồ án cuối kì\Ảnh\daiquangialamahoang.png', SINGLE_BLOB)as AnhSach));

insert into SACH(TenSach, TacGia, Gia, NamXuatBan, SoLuong, IdTheLoaiSach, IdNhaXuatBan, AnhSach) 
values (N'One Punch Man', N'ONE - Murata Yuusuke', 90000, '02/01/1998',12, 1, 1, (select * from openrowset(Bulk 'D:\DatabaseManagementSystem\Đồ án cuối kì\Ảnh\one-punch-man.png', SINGLE_BLOB)as AnhSach));

insert into SACH(TenSach, TacGia, Gia, NamXuatBan, SoLuong, IdTheLoaiSach, IdNhaXuatBan, AnhSach) 
values (N'Võ Luyện Đỉnh Phong', N'Đang Cập Nhật', 90000, '12/01/1998',12, 1, 2, (select * from openrowset(Bulk 'D:\DatabaseManagementSystem\Đồ án cuối kì\Ảnh\vo-luyen-dinh-phong.png', SINGLE_BLOB)as AnhSach));


insert into SACH(TenSach, TacGia, Gia, NamXuatBan, SoLuong, IdTheLoaiSach, IdNhaXuatBan, AnhSach) 
values (N'Tư Duy Mở', N'Nguyễn Anh Dũng', 100000, '11/26/2023',12, 2, 3, (select * from openrowset(Bulk 'D:\DatabaseManagementSystem\Đồ án cuối kì\Ảnh\tuduymo.png', SINGLE_BLOB)as AnhSach));

insert into SACH(TenSach, TacGia, Gia, NamXuatBan, SoLuong, IdTheLoaiSach, IdNhaXuatBan, AnhSach) 
values (N'Muôn Kiếp Nhân Sinh', N'Đang Cập Nhật', 120000, '12/12/1995',12, 3, 4, (select * from openrowset(Bulk 'D:\DatabaseManagementSystem\Đồ án cuối kì\Ảnh\muonkiepnhansinh.png', SINGLE_BLOB)as AnhSach));

insert into SACH(TenSach, TacGia, Gia, NamXuatBan, SoLuong, IdTheLoaiSach, IdNhaXuatBan, AnhSach) 
values (N'Kì Án Săn Ma', N'Gerald Brittle', 150000, '02/02/2013',12, 4, 5, (select * from openrowset(Bulk 'D:\DatabaseManagementSystem\Đồ án cuối kì\Ảnh\kyansanma.png', SINGLE_BLOB)as AnhSach));

insert into SACH(TenSach, TacGia, Gia, NamXuatBan, SoLuong, IdTheLoaiSach, IdNhaXuatBan, AnhSach) 
values (N'Điềm Tĩnh Và Nóng Giận', N'Tạ Quốc Kế', 80000, '12/04/2022',12, 4, 5, (select * from openrowset(Bulk 'D:\DatabaseManagementSystem\Đồ án cuối kì\Ảnh\diemtinhnonggian.png', SINGLE_BLOB)as AnhSach));

insert into Roles(TenRole) values ('ADMIN');
insert into Roles(TenRole) values ('NHANVIEN');

insert into NHANVIEN(HoTen, Luong, SoDienThoai, DiaChi, IdRole) values (N'Nguyễn Minh Hải', 1000000, 0938718496, N'Nha Trang', 1);
insert into NHANVIEN(HoTen, Luong, SoDienThoai, DiaChi, IdRole) values (N'Việt Thành', 900000, 0938715246, N'Quận 1', 2);
insert into NHANVIEN(HoTen, Luong, SoDienThoai, DiaChi, IdRole) values (N'Văn Trung', 90000000, 0938562482, N'Gò Vấp', 2);
insert into NHANVIEN(HoTen, Luong, SoDienThoai, DiaChi, IdRole) values (N'Luân Trường', 900000, 0938412634, N'Quận 10', 2);

insert into HOADONBANHANG (NgayXuat, IdNhanVien) values ('07/31/2023', 2);
insert into HOADONBANHANG (NgayXuat, IdNhanVien) values ('04/25/2023', 2);
insert into HOADONBANHANG (NgayXuat, IdNhanVien) values ('12/02/2023', 3);
insert into HOADONBANHANG (NgayXuat, IdNhanVien) values ('10/14/2023', 4);
insert into HOADONBANHANG (NgayXuat, IdNhanVien) values ('05/16/2023', 2);

insert into CHITIETHOADON(IdSach, IdHoaDon, SoLuong, TongHoaDon) values (2, 1, 1, 90000);
insert into CHITIETHOADON(IdSach, IdHoaDon, SoLuong, TongHoaDon) values (3, 2, 2, 100000);
insert into CHITIETHOADON(IdSach, IdHoaDon, SoLuong, TongHoaDon) values (4, 3, 1, 90000);
insert into CHITIETHOADON(IdSach, IdHoaDon, SoLuong, TongHoaDon) values (5, 4, 1, 90000);
insert into CHITIETHOADON(IdSach, IdHoaDon, SoLuong, TongHoaDon) values (6, 5, 1, 90000);

insert into HOADONNNHAPHANG(IdNXB, NgayXuat, IdNhanVien) values (1, '08/01/2023', 1);
insert into HOADONNNHAPHANG(IdNXB, NgayXuat, IdNhanVien) values (3, '08/01/2023', 2);

insert into CHITIETHOADONNHAPHANG(IdHoaDonNhapHang, IdSach, TongHoaDon, SoLuong) values (1, 2, 1100000, 15);
insert into CHITIETHOADONNHAPHANG(IdHoaDonNhapHang, IdSach, TongHoaDon, SoLuong) values (2, 3, 2000000, 20);



-- create proc getAllCategories
create procedure GetAllBookCategories
as
begin
	select TL.TenTheLoai from THELOAISACH  TL
end

-- call getAllCategory
EXEC GetAllBookCategories;

-- create proc getallNhaXuatBan
create procedure GetAllNhaXuatBan
as
begin
	select NXB.TenNXB from NHAXUATBAN NXB
end

-- call GetAllNhaXuatBan
EXEC GetAllNhaXuatBan;

-- create proc GetIdByNameCategory
create procedure GetIdByNameCategory
	@TenTheLoai nvarchar(30)
as
begin
	select TL.Id from THELOAISACH TL Where Tl.TenTheLoai = @TenTheLoai
end
--test proc GetIdByNameCategory
EXEC GetIdByNameCategory N'Truyện Tranh'

-- create proc GetIdByNamePublisher
create procedure GetIdByNamePublisher
	@TenNXB nvarchar(30)
as
begin
	select NXB.Id from NHAXUATBAN NXB Where NXB.TenNXB = @TenNXB
end
--test proc GetIdByNamePublisher
EXEC GetIdByNamePublisher N'Nhà Xuất Bản Lao Động'



 
--create proc getallbook
CREATE PROCEDURE GetAllBooksAndCategories
AS
BEGIN
    SELECT 
        S.Id AS IdSach,
        S.TenSach AS TenSach,
        S.TacGia AS TacGia,
        S.Gia AS Gia,
		S.AnhSach as AnhSach,
        S.NamXuatBan AS NamXuatBan,
        TL.TenTheLoai AS TenTheLoai,
		S.SoLuong AS SoLuong
    FROM
        SACH AS S
    INNER JOIN
        THELOAISACH AS TL ON S.IdTheLoaiSach = TL.Id;
END
-- call getallbook
EXEC GetAllBooksAndCategories;

-- procedure add book
CREATE PROCEDURE AddBook
    @TenSach NVARCHAR(30),
    @TacGia NVARCHAR(30),
    @Gia INT,
    @NamXuatBan DATETIME,
    @SoLuong INT,
    @IdTheLoaiSach INT,
    @IdNhaXuatBan INT,
    @AnhSach IMAGE
AS
BEGIN
	IF EXISTS (SELECT 1 FROM SACH WHERE TenSach = @TenSach)
    BEGIN
        UPDATE SACH
        SET SoLuong = SoLuong + @SoLuong
        WHERE TenSach = @TenSach
    END
    ELSE
    BEGIN
        INSERT INTO SACH (TenSach, TacGia, Gia, NamXuatBan, SoLuong, IdTheLoaiSach, IdNhaXuatBan, AnhSach)
        VALUES (@TenSach, @TacGia, @Gia, @NamXuatBan, @SoLuong, @IdTheLoaiSach, @IdNhaXuatBan, @AnhSach)
    END
END
-- call proc addbook
DECLARE @ImageData VARBINARY(MAX);
SELECT @ImageData = (SELECT * FROM OPENROWSET(BULK 'D:\DatabaseManagementSystem\Đồ án cuối kì\Ảnh\onepiece.png', SINGLE_BLOB) AS AnhSach);
EXEC AddBook
    @TenSach = N'Đại Quản Gia Là Ma Hoàng',
    @TacGia = N'Eiichiro Oda',
    @Gia = 150000,
    @NamXuatBan = '2002-07-01',
    @SoLuong = 20,
    @IdTheLoaiSach = 1, 
    @IdNhaXuatBan = 2, 
    @AnhSach = @ImageData

-- create proc edit book
CREATE PROCEDURE UpdateBook
    @Id INT,
    @TenSach NVARCHAR(30),
    @TacGia NVARCHAR(30),
    @Gia INT,
    @NamXuatBan DATETIME,
    @SoLuong INT,
    @IdTheLoaiSach INT,
    @IdNhaXuatBan INT,
    @AnhSach IMAGE
AS
BEGIN
    UPDATE SACH
    SET
        TenSach = @TenSach,
        TacGia = @TacGia,
        Gia = @Gia,
        NamXuatBan = @NamXuatBan,
        SoLuong = @SoLuong,
        IdTheLoaiSach = @IdTheLoaiSach,
        IdNhaXuatBan = @IdNhaXuatBan,
        AnhSach = @AnhSach
    WHERE
        Id = @Id;
END

-- create proc delete book
CREATE PROCEDURE DeleteBook
    @BookId INT
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM CHITIETHOADON WHERE IdSach = @BookId)
    BEGIN
        DELETE FROM CHITIETHOADON WHERE IdSach = @BookId;
    END
	IF EXISTS (SELECT 1 FROM CHITIETHOADONNHAPHANG WHERE IdSach = @BookId)
    BEGIN
		DELETE FROM CHITIETHOADONNHAPHANG WHERE IdSach = @BookId;
    END

    DELETE FROM SACH WHERE Id = @BookId;
END
-- call delete book
EXEC DeleteBook @BookId = 8; 

--create proc GetBookById
Create procedure GetBookById
	@Id int
AS
BEGIN
	SELECT * FROM SACH WHERE Id = @Id
END
EXEC GetBookById @Id = 1; 


--create proc GetCategoryById
Create procedure GetCategoryById
	@Id int
AS
BEGIN
	SELECT * FROM THELOAISACH WHERE Id = @Id
END
EXEC GetCategoryById @Id = 1; 

--create proc GetPublisherById
Create procedure GetPublisherById
	@Id int
AS
BEGIN
	SELECT * FROM NHAXUATBAN WHERE Id = @Id
END
EXEC GetPublisherById @Id = 5; 

-- create proc LoginEmployeeByPhone
create procedure  LoginEmployeeByPhone
	@Phone  char(10)
as
begin
	SET NOCOUNT ON;
    SELECT nv.Id, nv.HoTen, r.TenRole FROM NHANVIEN nv 
	JOIN Roles r on r.Id = nv.IdRole
	WHERE nv.SoDienThoai = @Phone;
end
EXEC LoginEmployeeByPhone @Phone = '938718496'; 

-- create proc GetEmployeeByName
create procedure GetEmployeeByName
	@Name  nvarchar(30)
as
begin
	SET NOCOUNT ON;
    SELECT nv.Id, nv.HoTen, r.TenRole FROM NHANVIEN nv
	JOIN Roles r on r.Id = nv.IdRole
	WHERE nv.HoTen = @Name
	
end
EXEC GetEmployeeByName @Name = N'Nguyễn Minh Hải'; 



--create proc GetChiTietHoaDonNhapHang
CREATE PROCEDURE GetChiTietHoaDonNhaphang
AS
BEGIN
    SELECT 
        CTNH.IdHoaDonNhapHang AS MaHoaDon,
        (Select TenSach from SACH S where CTNH.IdSach = S.Id) AS TenSach,
		CTNH.SoLuong,
		CTNH.TongHoaDon,
		(Select nv.HoTen from NHANVIEN nv where nv.Id = NH.IdNhanVien) AS NhanVien,
		(Select nxb.TenNXB from NHAXUATBAN nxb where nxb.Id = NH.IdNXB) AS NhaXuatBan,
		NH.NgayXuat

    FROM
        CHITIETHOADONNHAPHANG AS CTNH
    INNER JOIN
        HOADONNNHAPHANG AS NH ON NH.Id = CTNH.IdHoaDonNhapHang;
END
exec GetChiTietHoaDonNhaphang

CREATE PROCEDURE AddToCart
    @SachId INT
AS
BEGIN
    INSERT INTO GIOHANG (IdSach, SoLuong)
    VALUES (@SachId, 1);
END;
--create proc EditCart
CREATE PROCEDURE EditCart
    @IdSach int,
	@SoLuong int
AS
BEGIN
    UPDATE GIOHANG
    SET
        SoLuong = @SoLuong
    WHERE
        IdSach = @IdSach
END

-- create proc GetBooksInCart
CREATE PROCEDURE GetBooksInCart
AS
BEGIN
    SELECT GH.IdSach, S.TenSach, S.Gia, SUM(GH.SoLuong) AS SoLuong
    FROM GIOHANG GH
    JOIN SACH S ON GH.IdSach = S.Id
    GROUP BY GH.IdSach, S.TenSach, S.Gia;
END;
exec GetBooksInCart;

--create proce DeleteBookInCart
CREATE PROCEDURE DeleteBookInCart
    @BookId INT
AS
BEGIN
    DELETE FROM GIOHANG WHERE GIOHANG.IdSach = @BookId;
END

-- create proc thanhtoan
CREATE PROCEDURE ThanhToan
    @NhanVienId INT
AS
BEGIN
    DECLARE @HoaDonId INT;

    INSERT INTO HOADONBANHANG (NgayXuat, IdNhanVien)
    VALUES (GETDATE(), @NhanVienId);

    SET @HoaDonId = SCOPE_IDENTITY(); 

    INSERT INTO CHITIETHOADON (IdSach, IdHoaDon, SoLuong, TongHoaDon)
    SELECT G.IdSach, @HoaDonId, SUM(G.SoLuong), SUM(G.SoLuong * S.Gia)
    FROM GIOHANG G
    JOIN SACH S ON G.IdSach = S.Id
    GROUP BY G.IdSach;

    DELETE FROM GIOHANG;
    SELECT @HoaDonId AS HoaDonId;
END;
exec ThanhToan @NhanVienId = 2


-- create GetChiTietHoaDon
CREATE PROCEDURE GetChiTietHoaDon
    
AS
BEGIN
    SELECT
        HDBH.Id as IDHoaDon,
        S.TenSach,
        CTH.SoLuong,
        S.Gia AS DonGia,
        CTH.TongHoaDon AS ThanhTien,
		HDBH.NgayXuat AS NGAYXUAT,
        SUM(CTH.TongHoaDon) OVER (PARTITION BY CTH.IdHoaDon) AS TongTienHoaDon,
		NV.HoTen AS NHANVIENXUAT
    FROM CHITIETHOADON CTH
	JOIN HOADONBANHANG HDBH ON HDBH.Id = CTH.IdHoaDon
    JOIN SACH S ON CTH.IdSach = S.Id
	JOIN NHANVIEN NV ON NV.Id = HDBH.IdNhanVien
END;
exec GetChiTietHoaDon  

--create proc SearchBooks
CREATE PROCEDURE SearchBooks
    @SearchTerm NVARCHAR(50)
AS
BEGIN
    SELECT
        S.Id AS IdSach,
        S.TenSach AS TenSach,
        S.TacGia AS TacGia,
        S.Gia AS Gia,
		S.AnhSach as AnhSach,
        S.NamXuatBan AS NamXuatBan,
        TL.TenTheLoai AS TenTheLoai,
		S.SoLuong AS SoLuong
    FROM SACH S
    JOIN THELOAISACH TL ON S.IdTheLoaiSach = TL.Id
    JOIN NHAXUATBAN NXB ON S.IdNhaXuatBan = NXB.Id
    WHERE S.TenSach LIKE '%' + @SearchTerm + '%' OR TL.TenTheLoai LIKE '%' + @SearchTerm + '%';
END;
exec SearchBooks @SearchTerm = N'đại'


CREATE FUNCTION TotalBill()
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @TotalAmount DECIMAL(18, 2);
    
    SELECT @TotalAmount = SUM(TongHoaDon)
    FROM CHITIETHOADON;
    
    RETURN ISNULL(@TotalAmount, 0);
END;
SELECT dbo.TotalBill()

-- tạo trigger check nếu số lượng = 0 thì không cho thêm giỏ hàng
CREATE TRIGGER PreventAddToCart
ON GIOHANG
FOR INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM INSERTED i
        JOIN SACH s ON i.IdSach = s.Id
        WHERE s.SoLuong = 0
    )
    BEGIN
        RAISERROR('Số lượng sách đã hết!', 16, 1);
        ROLLBACK TRANSACTION;
    END;
END;



-- tạo trigger không được mua nhiều hơn số sách trong kho
CREATE TRIGGER PreventOverPurchase
ON CHITIETHOADON
FOR INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM INSERTED i
        JOIN SACH s ON i.IdSach = s.Id
        WHERE i.SoLuong > s.SoLuong
    )
    BEGIN
        RAISERROR('Số lượng sách không đủ!', 16, 1);
        ROLLBACK TRANSACTION;
    END;
END;


-- tạo trigger tự động cập nhật số lượng sách sau khi đặt hàng
CREATE TRIGGER UpdateBookQuantityAfterPurchase
ON CHITIETHOADON
AFTER INSERT
AS
BEGIN
    UPDATE SACH
    SET SACH.SoLuong = SACH.SoLuong - INSERTED.SoLuong
    FROM INSERTED
    WHERE SACH.Id = INSERTED.IdSach;
END;

















