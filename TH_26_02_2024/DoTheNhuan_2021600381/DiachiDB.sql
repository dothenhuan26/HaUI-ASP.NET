 
Create database DiachiDB
go
use DiachiDB
go
create table Tinh(
TinhID int primary key identity,
TenTinh nvarchar(30)
)

create table Huyen(
HuyenID int primary key identity,
TenHuyen nvarchar(30),
TinhID int foreign key references Tinh(TinhID)
)

create table Xa(
XaID int primary key identity,
TenXa nvarchar(30),
HuyenID int foreign key references Huyen(HuyenID)
)
go
insert into Tinh values(N'Hà Nội')
insert into Tinh values(N'Hải Phòng')
insert into Tinh values(N'Thái Bình')
insert into Tinh values(N'Lạng Sơn')
insert into Tinh values(N'Quảng Ninh')
go
insert into Huyen values(N'Thanh Xuân',1)
insert into Huyen values(N'Hoàn Kiếm',1)
insert into Huyen values(N'Đống Đa',1)
insert into Huyen values(N'Thanh Trì',1)
insert into Huyen values(N'Phúc Thọ',1)

go
-- cac xa, phuong thuoc Thanh Xuan --
insert into Xa values(N'Thanh xuân Bắc',1)
insert into Xa values(N'Thanh xuân Trung',1)
insert into Xa values(N'Thanh xuân Nam',1)
insert into Xa values(N'Thượng Đình',1)
insert into Xa values(N'Khương Mai',1)
insert into Xa values(N'Khương Trung',1)
insert into Xa values(N'Nhân Chính',1)
insert into Xa values(N'Phương Liệt',1)
insert into Xa values(N'Kim Giang',1)

go
-- cac xa, phuong thuoc Hoan Kiem --
insert into Xa values(N'Hàng Bạc',2)
insert into Xa values(N'Hàng Bài',2)
insert into Xa values(N'Hàng Bồ',2)
insert into Xa values(N'Hàng Bông',2)
insert into Xa values(N'Hàng Đào',2)
insert into Xa values(N'Hàng Gai',2)
insert into Xa values(N'Hàng Mã',2)
insert into Xa values(N'Hàng Trống',2)
insert into Xa values(N'Đồng Xuân',2)
insert into Xa values(N'Chương Dương',2)
insert into Xa values(N'Cửa Đông',2)
insert into Xa values(N'Cửa Nam',2)
insert into Xa values(N'Lý Thái Tổ',2)
insert into Xa values(N'Phan Chu Trinh',2)
insert into Xa values(N'Phúc Tân',2)
insert into Xa values(N'Tràng Tiền',2)
insert into Xa values(N'Trần Hưng Đạo',2)
go
-- cac quan, huyen cua Hai phong --
insert into Huyen values(N'Ngô Quyền',2)
insert into Huyen values(N'Đồ Sơn',2)
insert into Huyen values(N'Dương Kinh',2)
insert into Huyen values(N'Hải An',2)
insert into Huyen values(N'Hồng Bàng',2)
insert into Huyen values(N'Kiến An',2)
insert into Huyen values(N'Lê Chân',2)
insert into Huyen values(N'Bạch Long Vĩ',2)
insert into Huyen values(N'Thủy Nguyên',2)
go
-- cac xa, phuong thuoc Ngo Quyen --
insert into Xa values(N'Máy Chai',6)
insert into Xa values(N'Máy Tơ',6)
insert into Xa values(N'Vạn Mỹ',6)
insert into Xa values(N'Cầu Tre',6)
insert into Xa values(N'Lạc Viên',6)
insert into Xa values(N'Gia Viên',6)
insert into Xa values(N'Đông Khê',6)
insert into Xa values(N'Cầu Đất',6)
insert into Xa values(N'Lê Lợi',6)
insert into Xa values(N'Đằng Giang',6)
insert into Xa values(N'Lạch Tray',6)
insert into Xa values(N'Đồng Quốc Bình',6)

go 
select p.TinhID, TenTinh, d.HuyenID, TenHuyen, c.XaID, TenXa
from Tinh P, Huyen d, Xa c
where p.TinhID=d.TinhID and d.HuyenID=c.HuyenID
go

--select * from Tinh
--select * from Huyen
--select * from Xa
 
