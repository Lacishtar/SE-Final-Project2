create database SFMProject

drop table products
drop table order_product
drop table order_detail
drop table import_detail
drop table import
drop table agent
drop table sold


create table products(
	id int primary key identity,
	name varchar(250) not null,
	price float,
	quantity int
)

create table import(
	id int primary key identity,
	created_date date
)

create table import_detail(
	idImportDetail int primary key identity,
	idImport int,
	idProduct int,
	quantity int,
	foreign key(idImport) references import(id),
	foreign key(idProduct) references products(id)
)



create table agent(
	id int primary key identity,
	agent_name varchar(250) not null,
	phone varchar(11),
	address varchar(250)
)

create table order_product(
	id int primary key identity,
	agentId int not null,
	orderDate date not null,
	statusOrder bit not null, --1 la dang chuyen, 0 la dang xu li
	statusPay bit not null, --1 la thanh toan roi, 0 la chua thanh toan,
	methodPay varchar(50),
	foreign key(agentId) references agent(id)
)

create table order_detail(
	id int primary key identity,
	orderId int not null,
	productId int not null,
	quantity int not null,
	foreign key(orderId) references order_product(id),
	foreign key(productId) references products(id)
)

create table sold(
	id int primary key identity,
	productId int not null,
	quantity int not null,
	foreign key(productId) references products(id)
)

 
insert into products(name,quantity,price) values('Xiaomi Mi 11',30,6800000),
							('Samsung S21+',30,9999000),
							('Iphone 13',30,13000000),
							('Google Pixel 7',30,12000000),
							('Iphone 14',30,16300000),
							('Samsung J7',30,700000),
							('Vivo V25',30,9490000),
							('Xiaomi 12T',30,11490000),
							('Oppo Find X5 Pro',30,19990000),
							('Xiaomi Redmi Note 12',30,7190000) 

insert into import(created_date) values('2022-12-12'),('2022-11-21'),('2022-01-12'),('2022-02-12')
										,('2022-03-12'),('2022-04-12'),('2022-05-12'),('2022-07-12')
										,('2022-08-12'),('2022-10-12'),('2022-12-02')

insert into import_detail(idImport,idProduct,quantity) values(1,2,9),(2,1,10),(3,4,5),(4,5,20),(5,6,17),
																(6,3,12),(7,8,21),(8,7,13),(9,10,24),(10,9,14),
																(11,1,14)

insert into agent(agent_name, phone,address ) values('FPT','113', 'SG'),
													('TGDD','115', 'SG'),
													('CellPhoneS','114','HN'),
													('Mobile City','116','SG')



insert into order_product(agentId,orderDate,statusOrder,statusPay,methodPay) 
	values(1,'2021-05-3',0,1,'Momo'),(1,'2021-06-3',0,1,'Zalo Pay'),(1,'2021-07-4',1,0,'Cash'),(2,'2021-08-3',0,0,'Zalo Pay'),
			(2,'2021-11-3',1,1,'Cash'),(3,'2022-02-3',1,0,'Zalo Pay'),
			(3,'2022-04-3',0,0,'Momo'),(3,'2022-10-3',1,1,'Zalo Pay'),(3,'2022-12-13',0,1,'Cash')

insert into order_detail(orderId ,productId,quantity)
	values (1,2,2),(1,1,4),(1,4,5),(1,5,7),(1,7,3),
			(2,1,5),(2,3,2),(2,5,1),(2,7,3),(2,9,7),
			(3,5,3),(3,2,1),(3,3,5),(3,7,7),(3,7,4),(3,9,2),
			(4,1,8),(4,3,7),(4,5,6),(4,7,3),(4,9,2),
			(5,9,3),(2,1,7),(2,5,8),(2,7,9),(2,10,8),
			(6,4,3),(6,1,7),(6,2,8),(6,8,9),(6,9,10),
			(7,1,5),(7,4,3),(7,6,1),(7,3,3),(7,9,7),
			(8,1,2),(8,3,1),(8,5,7),(8,7,4),(8,9,8),
			(9,8,4),(9,3,2),(9,1,3),(9,10,4),(9,4,3)							

insert into sold(productId,quantity) values(9,3),(1,7),(5,8),(7,9),(10,8),
												(1,2),(3,1),(5,7),(7,4),(9,8)	





select * from products
select * from import
select * from import_detail
select * from agent
select * from order_product
select * from order_detail
select * from sold






	



