create table LoaiPhong(
	MaLoai varchar(5) primary key,
	TenLoai varchar(50) not null,
	GhiChu varchar(1000)
);
create table Phong(
	MaPhong varchar(5) primary key,
	TenPhong varchar(50) not null,
	MaLoai varchar(5) not null,
	GiaThue int not null,
	TrangThai varchar(50) not null,
	foreign key (MaLoai) references LoaiPhong(MaLoai)
);

create table NhanVien(
	MaNhanVien varchar(10) primary key,
	MatKhau varchar(20) not null,
	HoTen varchar(50) not null,
	NgaySinh date,
	SoDienThoai varchar(10) not null
);
create table KhachHang(
	MaKhachHang int identity(1,1) primary key,
	TenKhachHang varchar(50) not null,
	DiaChi varchar(100),
	SoDienThoai varchar(10) not null
);
create table DichVu(
	MaDichVu varchar(5) primary key,
	TenDichVu varchar(50) not null,
	GiaTien int not null
);
create table ThuePhong(
	MaThue int identity(1,1) primary key,
	MaKhachHang int not null,
	MaPhong varchar(5) not null,
	NgayVao varchar(10) not null,
	SoNgayO int not null,
	DatCoc int,
	foreign key (MaKhachHang) references KhachHang(MaKhachHang),
	foreign key (MaPhong) references Phong(MaPhong)
);
create table ThanhToan(
	MaThanhToan int identity(1,1)  primary key,
	MaThue int not null,
	ThanhTien int not null,
	GhiChu varchar(1000),
	NgayThanhToan varchar(10) not null,
	foreign key (MaThue) references ThuePhong(MaThue)
);
create table SuDungDichVu(
	MaSuDung int identity(1,1) primary key,
	MaThue int not null,
	MaDichVu varchar(5) not null,
	NgaySuDung varchar(10) not null,
	DonGia int not null,
	foreign key (MaThue) references ThuePhong(MaThue),
	foreign key (MaDichVu) references DichVu(MaDichVu)
);

insert into LoaiPhong values ('H1','Hang 1','Phong hang 1')
insert into LoaiPhong values ('H2','Hang 2','Phong hang 2')
insert into LoaiPhong values ('H3','Hang 3','Phong hang 3')

insert into Phong values ('001','001','H1','100000','Trong')
insert into Phong values ('002','002','H1','100000','Trong')
insert into Phong values ('003','003','H1','100000','Trong')
insert into Phong values ('004','004','H2','200000','Trong')
insert into Phong values ('005','005','H2','200000','Trong')
insert into Phong values ('006','006','H2','200000','Trong')
insert into Phong values ('007','007','H3','300000','Trong')
insert into Phong values ('008','008','H3','300000','Trong')
insert into Phong values ('009','009','H3','300000','Trong')

insert into NhanVien values ('001','001','Nguyen Van Thang','01/01/1999','0123456789')
insert into NhanVien values ('002','002','Nguyen Vinh Hien','03/03/1999','0123456788')
insert into NhanVien values ('003','003','Nguyen Thanh Son','03/03/1999','0123456787')

insert into DichVu values ('001','An sang','30000')
insert into DichVu values ('002','An trua','40000')
insert into DichVu values ('003','An chieu','40000')
insert into DichVu values ('004','An toi','40000')