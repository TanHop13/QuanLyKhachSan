
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

