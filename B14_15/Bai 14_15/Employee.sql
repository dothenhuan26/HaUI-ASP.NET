use master
go
if DB_ID('Company') is not null
	drop database Company
go
create database Company
go
use Company
go
create table Department(
deptid int primary key identity,
deptname nvarchar(25)
)
insert into Department values('Hanh chinh')
insert into Department values('Ke toan')
insert into Department values('Tong hop')
go
create table Employee(
eid int primary key identity,
name nvarchar(30),
age int,
addr nvarchar(30),
salary int,
image nvarchar(50),
deptid int foreign key references Department(deptid))
go
insert into Employee values('Lan Anh',32,'Ha noi',3500,'a01.jpg',1)
insert into Employee values('Thi Huong',30,'Ha noi',5000,'a02.jpg',2)
insert into Employee values('Van Ha',30,'Hai phong',4000,'a03.jpg',1)
insert into Employee values('Hong Linh',35,'Thai binh',5500,'a04.jpg',3)
insert into Employee values('Van Hung',32,'Hai phong',5000,'a05.jpg',1)
insert into Employee values('Hai Yen',28,'Thai binh',3000,'a06.jpg',1)
insert into Employee values('My Ha',26,'Hai phong',3000,'a07.jpg',2)
insert into Employee values('Phuong Thuy',24,'Hai phong',2000,'a08.jpg',3)
insert into Employee values('Phi Hung',24,'Ha noi',2500,'a09.jpg',2)
insert into Employee values('Cong Tuan',40,'Thai binh',4500,'a10.jpg',2)
go
--drop table Employee
-- select * from Employee where addr='Hai phong' and salary>3000
select * from Employee  
-- 
go
create table Accout(
id int primary key identity,
username varchar(50) UNIQUE,
password nvarchar(100),
role tinyint)
go
insert into Accout values('admin','123',1)
insert into Accout values('1','1',2)
insert into Accout values('2','2',2)
GO

select * from Accout