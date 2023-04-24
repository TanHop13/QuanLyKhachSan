use QuanLyKhachSan
go

begin
	update ChiTietHoaDon
	set ChiPhi = CASE
				when IdDichVu = 1 then (select GiaDV
										from DichVu 
										where MaDV = 1)
				when IdDichVu = 2 then (select GiaDV
										from DichVu 
										where MaDV = 2)
				when IdDichVu = 3 then (select GiaDV
										from DichVu 
										where MaDV = 3)
				when IdDichVu = 4 then (select GiaDV
										from DichVu 
										where MaDV = 4)
				when IdDichVu = 5 then (select GiaDV
										from DichVu 
										where MaDV = 5)
				when IdDichVu = 6 then (select GiaDV
										from DichVu 
										where MaDV = 6)
				when IdDichVu = 7 then (select GiaDV
										from DichVu 
										where MaDV = 7)
				when IdDichVu = 8 then (select GiaDV
										from DichVu 
										where MaDV = 8)
				when IdDichVu = 9 then (select GiaDV
										from DichVu 
										where MaDV = 9)
				when IdDichVu = 10 then (select GiaDV
										from DichVu 
										where MaDV = 10)
				when IdDichVu = 11 then (select GiaDV
										from DichVu 
										where MaDV = 11)
				when IdDichVu = 12 then (select GiaDV
										from DichVu 
										where MaDV = 12)
				when IdDichVu = 13 then (select GiaDV
										from DichVu 
										where MaDV = 13)
				when IdDichVu = 14 then (select GiaDV
										from DichVu 
										where MaDV = 14)
				when IdDichVu = 15 then (select GiaDV
										from DichVu 
										where MaDV = 15)
	else ''
	end

end
go