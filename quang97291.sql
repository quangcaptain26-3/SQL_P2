create database PMQ97291
use PMQ97291

create table PhongBan_2(
	MaPhongBan nvarchar(3) primary key,
	TenPhongBan nvarchar(30) not null unique,
	NgayThanhLap FLOAT NOT NULL CHECK (NgayThanhLap >= 0),
	PhuCap float not null check(PhuCap >= 0)
);
go
create table NhanVien_9(
	MaNhanVien nvarchar(5) primary key,
	HoTen nvarchar(30) not null,
	MaPhongBan nvarchar(3) not null references PhongBan_2(MaPhongBan),
	NgayVaoLam date not null,
	MucLuong float not null check(MucLuong >= 0)
);
go
create table DuAn_1(
	MaDuAn nvarchar(3) primary key,
	TenDuAn nvarchar(30) not null unique,
	TongKinhPhi float not null check(TongKinhPhi >= 0),
	MaNhanVienPhuTrach nvarchar(5) not null references NhanVien_9(MaNhanVien)
);

INSERT INTO PhongBan_2 (MaPhongBan, TenPhongBan, NgayThanhLap, PhuCap)
VALUES 
('HR1', 'Human Resources', 2015.3, 2000),
('FIN', 'Finance Department', 2018.5, 3000),
('ITD', 'IT Department', 2020.8, 4000),
('MK1', 'Marketing', 2019.1, 2500),
('SA1', 'Sales Department', 2021.7, 3500);

INSERT INTO NhanVien_9 (MaNhanVien, HoTen, MaPhongBan, NgayVaoLam, MucLuong)
VALUES 
('NV001', 'John Doe', 'HR1', '2020-01-15', 5000),
('NV002', 'Jane Smith', 'FIN', '2019-05-20', 7000),
('NV003', 'Mark Johnson', 'ITD', '2021-03-10', 8000),
('NV004', 'Emily Davis', 'MK1', '2022-07-25', 5500),
('NV005', 'Chris Brown', 'SA1', '2021-11-11', 6000);

INSERT INTO DuAn_1 (MaDuAn, TenDuAn, TongKinhPhi, MaNhanVienPhuTrach)
VALUES 
('DA1', 'Project Alpha', 50000, 'NV001'),
('DA2', 'Project Beta', 75000, 'NV002'),
('DA3', 'Project Gamma', 60000, 'NV003'),
('DA4', 'Project Delta', 85000, 'NV004'),
('DA5', 'Project Epsilon', 90000, 'NV005');

create procedure ThemNhanVien
	@MaNhanVien nvarchar(5), @HoTen nvarchar(30), @MaPhongBan nvarchar(3), @NgayVaoLam date, @MucLuong float
as begin
	declare @Dem int
	declare @Loi nvarchar(300)
	set @Loi = ' '

	set @Dem = (SELECT COUNT(*) FROM NhanVien_9 WHERE MaNhanVien = @MaNhanVien);
	if @Dem > 0
		set @Loi = N'Ma nhan vien da ton tai'

	set @Dem = (SELECT COUNT(*) FROM NhanVien_9 WHERE MaPhongBan = @MaPhongBan);
	if @Dem = 0
		set @Loi = N'Ma phong ban khong ton tai'

	if @NgayVaoLam > GETDATE()
		set @Loi = N'Ngay vao lam khong hop le'

	if @MucLuong <= 0
		set @Loi = N'Luong khong duoc phep be hon bang 0'

	if @Loi = ' '
		insert into NhanVien_9 (MaNhanVien, HoTen, MaPhongBan, NgayVaoLam, MucLuong)
		values (@MaNhanVien, @HoTen, @MaPhongBan, @NgayVaoLam, @MucLuong)
	else
		raiserror(@Loi, 16, 1)
end

drop procedure ThemNhanVien



EXEC ThemNhanVien 
    @MaNhanVien = 'NV006', 
    @HoTen = 'Alice Green', 
    @MaPhongBan = 'ITD', 
    @NgayVaoLam = '2023-12-01', 
    @MucLuong = 7000;

create function TimKiemDuAn
	(@KeyWord nvarchar(40))
returns table
as return
	(select MaDuAn, TenDuAn, TongKinhPhi, MaNhanVienPhuTrach from DuAn_1
	inner join NhanVien_9 on DuAn_1.MaNhanVienPhuTrach = NhanVien_9.MaNhanVien
	where MaDuAn LIKE '%' + @KeyWord + '%'
	or TenDuAn LIKE '%' + @KeyWord + '%'
	or TongKinhPhi LIKE '%' + @KeyWord + '%'
	or MaNhanVienPhuTrach LIKE '%' + @KeyWord + '%'
	);

SELECT * 
FROM TimKiemDuAn('A');

create procedure ThemPhongBan
	@MaPhongBan nvarchar(3), @TenPhongBan nvarchar(30), @NgayThanhLap float, @PhuCap float
as begin
	declare @Dem int
	declare @Loi nvarchar(300)
	set @Loi = ' '

	set @Dem = (select count(*) from PhongBan_2 where MaPhongBan = @MaPhongBan)
	if @Dem > 0
		set @Loi = N'Ma phong ban da ton tai'

	set @Dem = (select count(*) from PhongBan_2 where TenPhongBan = @TenPhongBan)
	if @Dem > 0
		set @Loi = N'Ten phong ban da ton tai'

	if @NgayThanhLap <= 0
		set @Loi = N'Sua ngay ngay thanh lap di'

	if @PhuCap <= 0
		set @Loi = N'Phu cap phai lon hon'

	if @Loi = ' '
		insert into PhongBan_2(MaPhongBan, TenPhongBan, NgayThanhLap, PhuCap) 
		values (@MaPhongBan, @TenPhongBan, @NgayThanhLap, @PhuCap)
	else
		raiserror(@Loi, 16, 1)
end

EXEC ThemPhongBan 
    @MaPhongBan = 'HR2', 
    @TenPhongBan = 'Human Resources2', 
    @NgayThanhLap = 3650, 
    @PhuCap = 1000;
-- Kết quả mong đợi: Thêm thành công bản ghi vào bảng `PhongBan_2`

create procedure SuaPhongBan
	@MaPhongBan nvarchar(3), @TenPhongBan nvarchar(30), @NgayThanhLap float, @PhuCap float
as begin
	declare @Dem int
	declare @Loi nvarchar(300)
	set @Loi = ' '

	set @Dem = (select count(*) from PhongBan_2 where MaPhongBan = @MaPhongBan)
	if @Dem = 0
		set @Loi = N'Ma phong ban khong ton tai'

	set @Dem = (select count(*) from PhongBan_2 where TenPhongBan = @TenPhongBan AND MaPhongBan != @MaPhongBan)
	if @Dem > 0
		set @Loi = N'Ten phong ban da ton tai'

	if @NgayThanhLap <= 0
		set @Loi = N'Ngay thanh lap khong am'

	if @PhuCap <= 0
		set @Loi = N'Phu cap khong am'

	if @Loi = ' '
		update PhongBan_2
		set TenPhongBan = @TenPhongBan,
			NgayThanhLap = @NgayThanhLap,
			PhuCap = @PhuCap
		where MaPhongBan = @MaPhongBan
	else
		raiserror(@Loi, 16, 1)
end

create procedure XoaPhongBan
	@MaPhongBan nvarchar(3)
as begin 
	declare @Dem int
	declare @Loi nvarchar(300)
	set @Loi = ' '

	set @Dem = (select count(*) from PhongBan_2 where MaPhongBan = @MaPhongBan)
	if @Dem = 0
		set @Loi = N'Ma phong ban khong ton tai'
	
	set @Dem = (select count(*) from NhanVien_9 where MaPhongBan = @MaPhongBan)
	if @Dem > 0
		set @Loi = N'Khong the xoa do ton tai o NhanVien'

	if @Loi = ' ' 
		delete from PhongBan_2
		where MaPhongBan = @MaPhongBan
	else	
		raiserror(@Loi, 16, 1)
end

create function TimKiemPhongBan
(
		@MaPhongBan nvarchar(3), @TenPhongBan nvarchar(30), @NgayThanhLap float, @PhuCap float
)
returns table
as return
(
	select * from PhongBan_2
	where (@MaPhongBan is null or MaPhongBan = @MaPhongBan)
		and(@TenPhongBan is null or TenPhongBan LIKE '%' + @TenPhongBan + '%')
		and(@NgayThanhLap is null or NgayThanhLap = @NgayThanhLap)
		and(@PhuCap is null or PhuCap = @PhuCap)
)

select * from TimKiemPhongBan(NULL, 'IT', NULL, NULL)