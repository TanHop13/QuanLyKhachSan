
use QuanLyKhachSan
go

begin
	update HoaDon
	set Total = CASE 
		when MaHD = 1 then (select SUM(b.ChiPhi) + ( abs(( DAY(NgayTraPhong) - DAY(NgayNhanPhong)) * 24 ) 
											+ abs(( DATEPART(hour, NgayTraPhong) - DATEPART(hour, NgayNhanPhong) ))) * d.GiaP
								from HoaDon a, ChiTietHoaDon b, Phong c, Type d
								where a.MaHD = 1 and a.MaHD = b.IDHoaDon and a.Phong = c.MaP and c.LoaiP = d.ID
								group by NgayTraPhong, NgayNhanPhong, GiaP)

		when MaHD = 2 then (select SUM(b.ChiPhi) + ( abs(( DAY(NgayTraPhong) - DAY(NgayNhanPhong)) * 24 ) 
											+ abs(( DATEPART(hour, NgayTraPhong) - DATEPART(hour, NgayNhanPhong) ))) * d.GiaP
								from HoaDon a, ChiTietHoaDon b, Phong c, Type d
								where a.MaHD = 2 and a.MaHD = b.IDHoaDon and a.Phong = c.MaP and c.LoaiP = d.ID
								group by NgayTraPhong, NgayNhanPhong, GiaP)

		when MaHD = 3 then (select SUM(b.ChiPhi) + ( abs(( DAY(NgayTraPhong) - DAY(NgayNhanPhong)) * 24 ) 
											+ abs(( DATEPART(hour, NgayTraPhong) - DATEPART(hour, NgayNhanPhong) ))) * d.GiaP
								from HoaDon a, ChiTietHoaDon b, Phong c, Type d
								where a.MaHD = 3 and a.MaHD = b.IDHoaDon and a.Phong = c.MaP and c.LoaiP = d.ID
								group by NgayTraPhong, NgayNhanPhong, GiaP)

		when MaHD = 4 then (select SUM(b.ChiPhi) + ( abs(( DAY(NgayTraPhong) - DAY(NgayNhanPhong)) * 24 ) 
											+ abs(( DATEPART(hour, NgayTraPhong) - DATEPART(hour, NgayNhanPhong) ))) * d.GiaP
								from HoaDon a, ChiTietHoaDon b, Phong c, Type d
								where a.MaHD = 4 and a.MaHD = b.IDHoaDon and a.Phong = c.MaP and c.LoaiP = d.ID
								group by NgayTraPhong, NgayNhanPhong, GiaP)

		when MaHD = 5 then (select SUM(b.ChiPhi) + ( abs(( DAY(NgayTraPhong) - DAY(NgayNhanPhong)) * 24 ) 
											+ abs(( DATEPART(hour, NgayTraPhong) - DATEPART(hour, NgayNhanPhong) ))) * d.GiaP
								from HoaDon a, ChiTietHoaDon b, Phong c, Type d
								where a.MaHD = 5 and a.MaHD = b.IDHoaDon and a.Phong = c.MaP and c.LoaiP = d.ID
								group by NgayTraPhong, NgayNhanPhong, GiaP)

		when MaHD = 6 then (select SUM(b.ChiPhi) + ( abs(( DAY(NgayTraPhong) - DAY(NgayNhanPhong)) * 24 ) 
											+ abs(( DATEPART(hour, NgayTraPhong) - DATEPART(hour, NgayNhanPhong) ))) * d.GiaP
								from HoaDon a, ChiTietHoaDon b, Phong c, Type d
								where a.MaHD = 6 and a.MaHD = b.IDHoaDon and a.Phong = c.MaP and c.LoaiP = d.ID
								group by NgayTraPhong, NgayNhanPhong, GiaP)

		when MaHD = 7 then (select SUM(b.ChiPhi) + ( abs(( DAY(NgayTraPhong) - DAY(NgayNhanPhong)) * 24 ) 
											+ abs(( DATEPART(hour, NgayTraPhong) - DATEPART(hour, NgayNhanPhong) ))) * d.GiaP
								from HoaDon a, ChiTietHoaDon b, Phong c, Type d
								where a.MaHD = 7 and a.MaHD = b.IDHoaDon and a.Phong = c.MaP and c.LoaiP = d.ID
								group by NgayTraPhong, NgayNhanPhong, GiaP)

		when MaHD = 8 then (select SUM(b.ChiPhi) + ( abs(( DAY(NgayTraPhong) - DAY(NgayNhanPhong)) * 24 ) 
											+ abs(( DATEPART(hour, NgayTraPhong) - DATEPART(hour, NgayNhanPhong) ))) * d.GiaP
								from HoaDon a, ChiTietHoaDon b, Phong c, Type d
								where a.MaHD = 8 and a.MaHD = b.IDHoaDon and a.Phong = c.MaP and c.LoaiP = d.ID
								group by NgayTraPhong, NgayNhanPhong, GiaP)
	
		when MaHD = 9 then (select SUM(b.ChiPhi) + ( abs(( DAY(NgayTraPhong) - DAY(NgayNhanPhong)) * 24 ) 
											+ abs(( DATEPART(hour, NgayTraPhong) - DATEPART(hour, NgayNhanPhong) ))) * d.GiaP
								from HoaDon a, ChiTietHoaDon b, Phong c, Type d
								where a.MaHD = 9 and a.MaHD = b.IDHoaDon and a.Phong = c.MaP and c.LoaiP = d.ID
								group by NgayTraPhong, NgayNhanPhong, GiaP)

		when MaHD = 10 then (select SUM(b.ChiPhi) + ( abs(( DAY(NgayTraPhong) - DAY(NgayNhanPhong)) * 24 ) 
											+ abs(( DATEPART(hour, NgayTraPhong) - DATEPART(hour, NgayNhanPhong) ))) * d.GiaP
								from HoaDon a, ChiTietHoaDon b, Phong c, Type d
								where a.MaHD = 10 and a.MaHD = b.IDHoaDon and a.Phong = c.MaP and c.LoaiP = d.ID
								group by NgayTraPhong, NgayNhanPhong, GiaP)
	else ''
	end
end
go

--CREATE PROCEDURE [dbo].[GetTotalByMaHD] @MaHD INT
--AS
--BEGIN
--DECLARE @TotalMoney DECIMAL(18,2)
--SELECT @TotalMoney = SUM(b.ChiPhi) + ( ABS(( DAY(NgayTraPhong) - DAY(NgayNhanPhong)) * 24 ) 
--										+ ABS(( DATEPART(hour, NgayTraPhong) - DATEPART(hour, NgayNhanPhong) ))) * d.GiaP
--							FROM HoaDon a, ChiTietHoaDon b, Phong c, Type d
--							WHERE a.MaHD = @MaHD AND a.MaHD = b.IDHoaDon AND a.Phong = c.MaP AND c.LoaiP = d.ID
--							GROUP BY NgayTraPhong, NgayNhanPhong, GiaP

--UPDATE HoaDon
--SET Total = @TotalMoney
--WHERE MaHD = @MaHD

--End

--exec dbo.GetTotalByMaHD @MaHD = 1

----StoreProc Them Hoa Don
--Create PROCEDURE LTP_InsertBill
--    @idTable INT
--AS
--BEGIN
--    DECLARE @NgayNhanPhong DATETIME, @NgayTraPhong DATETIME, @idKH INT;

--    SELECT @NgayNhanPhong = hdkh.NgayDatPhong, @NgayTraPhong = hdkh.NgayHetHan, @idKH = kh.MaKH
--    FROM HoaDonKhachHang hdkh
--    INNER JOIN KhachHang kh ON hdkh.TenKH = kh.username
--    INNER JOIN Phong p ON hdkh.MaP = p.MaP
--    WHERE p.MaP = @idTable;

--    INSERT INTO dbo.HoaDon (Total, KH, NV, Phong, NgayNhanPhong, NgayTraPhong)
--    VALUES (0, @idKH, 1, @idTable, @NgayNhanPhong, @NgayTraPhong);
--END
--GO

----StoreProc Them Chi Tiet Hoa Don
--Create PROCEDURE LTP_InsertBillInfo
--    @idRoom int, @idBill INT, @idDV int, @ChiPhi decimal
--AS
--BEGIN
--    DECLARE @NgayXuatHoaDon DATETIME;

--    SELECT @NgayXuatHoaDon = hdkh.NgayDatPhong
--    FROM HoaDonKhachHang hdkh
--    WHERE hdkh.MaP = @idRoom;

--    INSERT INTO dbo.ChiTietHoaDon(NgayXuatHoaDon, IDHoaDon, ChiPhi, IdDichVu)
--    VALUES (@NgayXuatHoaDon, @idBill, @ChiPhi, @idDV);
--END
--GO


--select hdkh.NgayDatPhong, hdkh.NgayHetHan, kh.MaKH
--from HoaDonKhachHang hdkh, KhachHang kh, Phong p
--where hdkh.TenKH = kh.username and hdkh.MaP = p.MaP and hdkh.MaP = 203


--select NgayHetHan
--from HoaDonKhachHang 
--where MaP = 203

--select max(MaHD) from dbo.HoaDon

--exec dbo.LTP_InsertBill @idTable = 203

--exec dbo.LTP_InsertBillInfo @idRoom = 203, @idBill = 3, @idDV = 3, @ChiPhi = 75000

update dbo.Phong set TinhTrang = 0 where MaP = 101
select *
from Phong

