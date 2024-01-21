create database Textile
USE Textile


----------------------------------------------------------------------------------------------------------------------------------------------------------

create table Client (SR#1 int,
					 C_id varchar(20) not null  primary key,	
					 C_name varchar (50) not null, 
					 C_company varchar (50),
					 C_contact varchar(20),
                     C_city varchar (50),
					 C_mail varchar (50))

 select * from Client

create procedure new_client
as 
begin
	
	select top 1 *from view_clients order by [Client ID] desc
	
end

exec new_client


create view view_clients
as
select C_id as [Client ID], C_name as [Client Name], C_company as Company,C_contact as Contact, 
		C_mail as Email,C_city as [Address] from Client 


create PROCEDURE Insertclient
@C_name VARCHAR(50),@C_company varchar(50),@C_contact varchar (20), @C_city varchar(100),@C_mail varchar(20) 
AS
BEGIN
	DECLARE @ClientId VARCHAR(25);
	DECLARE @PreFix VARCHAR(10) = 'C';
	DECLARE @Id INT;

	SELECT @Id = ISNULL(MAX(SR#1),0) + 1 FROM Client
	SELECT @ClientId = @PreFix + RIGHT('0' + CAST(@Id AS VARCHAR(7)), 7)
	
	INSERT INTO Client VALUES  (@id, @ClientId, @C_name, @C_company, @C_Contact, @C_city, @C_mail)
END

exec Insertclient 'yalmaz', 'IYI', '646166', 'lahore','yalo135@gmail.com';


select * from Client


----------------------------------------------------------------------------------------------------------------------------------------------------------

create table Orders  (SR#2 int,
					  O_id varchar(20) not null primary key, 
                      C_id varchar(20) not null foreign key references Client(C_id),
                      Order_date date,
				      Due_date date)


select * from view_order



create PROCEDURE Insertorder
@c_id varchar(20),@due_date date
AS
BEGIN
	DECLARE @OrderId VARCHAR(25);
	DECLARE @PreFix VARCHAR(10) = 'O';
	DECLARE @Id INT;
	DECLARE @Order_date date;

	SELECT @Id = ISNULL(MAX(SR#2),0) + 1 FROM Orders
	SELECT @OrderId = @PreFix + RIGHT('0' + CAST(@Id AS VARCHAR(7)), 7)
	Select @Order_date = cast(getdate()as date)

	INSERT INTO Orders VALUES  (@id, @OrderId, @c_id,@Order_date,@due_date )
END

exec Insertorder  'C02', '20210512' ;------------

select * from Orders


----------------------------------------------------------------------------------------------------------------------------------------------------------

create table Order_details (O_id varchar(20) not null foreign key references Orders(O_id) on delete cascade, 
                            F_id varchar(20) not null foreign key references Fabrics(F_id), 
                            Meters int, 
							Color varchar(20),
							Order_Price float)

alter table Order_details
add constraint PK_OD primary key(O_id,F_id)

delete from Orders where O_id = 'O06'

select *from Orders
create TRIGGER price_calculate
ON Order_details
AFTER INSERT AS 
BEGIN
	update Order_details 
	set Order_details.Order_Price = (
	select f.F_rate from Fabrics f 
	where f.F_id = Order_details.F_id) * Order_details.Meters
END



----------------------------------------------------------------------------------------------------------------------------------------------------------

create table Fabrics (SR#3 INT,
					  F_id varchar(20) not null primary key,
					  F_name varchar (50) not null, 
					  F_rate int not null,
					  F_type varchar (50))


create procedure new_fabric
as 
begin
	
	select top 1 *from view_fabric order by [Fabric ID] desc
	
end

new_fabric

create view view_fabric
as
select F_id as [Fabric ID],F_name as [Fabric Name], F_type as [Fabric Type], F_rate as [Fabric Rate] from Fabrics


create PROCEDURE Insertfabric
@F_name varchar(50), @F_rate int, @F_type varchar (50)
AS
BEGIN
	DECLARE @FabricId VARCHAR(25);
	DECLARE @PreFix VARCHAR(10) = 'F';
	DECLARE @Id INT;

	SELECT @Id = ISNULL(MAX(SR#3),0) + 1 FROM Fabrics
	SELECT @FabricId = @PreFix + RIGHT('0' + CAST(@Id AS VARCHAR(7)), 7)
	
	INSERT INTO Fabrics VALUES  (@id, @FabricId, @F_name, @F_rate,@F_type)
END

exec Insertfabric 'S02','54','Silk';

select * from fabrics


-------------------------------------------------------------------------------
----FABRIC HISTORY


create table Fabric_history (F_Id varchar(20) not null foreign key references Fabrics(F_Id),
							 F_rate int not null,
							 H_Date date 
							 constraint PK_HIS Primary key (F_id, H_date))


create TRIGGER update_rate
ON fabrics
AFTER UPDATE
AS 
BEGIN
    INSERT INTO Fabric_history( F_Id, F_rate, H_Date)
    SELECT i.F_Id,d.F_rate,cast ((GETDATE())as date)
    FROM inserted i
    LEFT JOIN deleted d
        ON i.F_Id = d.F_Id
    WHERE i.F_rate != ISNULL(d.F_rate, -1)
END;

select *from Fabric_history


create proc rate_date
@fid varchar(20), @cur_date date
as 
begin
	
	select * from Fabric_history f
	where	
		datepart(year,f.H_Date) = datepart(year, @cur_date)
	and
		datepart(month,f.H_Date) =datepart(MONTH, @cur_date)
	and f.F_Id= @fid
end

exec rateDisplay 'F02','20220101'

select *from Transactions


----------------------------------------------------------------------------------------------------------------------------------------------------------


create table Employees (SR#4 INT,
						E_id varchar(20) not null primary key, 
						E_name varchar (50), 
						E_CNIC varchar(20),
						E_contact varchar(20),
                        E_address varchar (100),
						DOJ date,
						Designation varchar (50),
						Salary float)


						
create procedure emp_designation
as 
begin
	select E_id from employees where designation = 'Salesman'
end




alter procedure new_employee
as 
begin
	
	select top 1 *from view_employee order by [Emp ID] desc
	
end

exec new_employee

create view view_employee
as 
select E_id as [Emp ID], E_name as [Emp Name], E_contact as [Contact], E_address as [Address],
		E_CNIC as CNIC,DOJ as [Joining Date], Designation, Salary from Employees


create PROCEDURE Insertemployee
@E_name VARCHAR(50),@E_CNIC varchar(20),@E_contact varchar(20), @E_address varchar(100),@E_designation varchar (50),@E_salary float
AS
BEGIN
	DECLARE @EmployeeId VARCHAR(25);
	DECLARE @PreFix VARCHAR(10) = 'E';
	DECLARE @Id INT;
	DECLARE @E_DOJ date;

	SELECT @Id = ISNULL(MAX(SR#4),0) + 1 FROM Employees
	SELECT @EmployeeId = @PreFix + RIGHT('0' + CAST(@Id AS VARCHAR(7)), 7)
	SELECT @E_DOJ = CAST(GETDATE()AS DATE);

	INSERT INTO employees VALUES  (@id, @EmployeeId, @E_name, @E_CNIC,@E_contact,@E_address,@E_DOJ,@E_designation,@E_salary)
END


exec Insertemployee  'yalmaz', '35202-19845-1', '19681','house #400D','Worker','78000.0';------------

select * from Employees	

----------------------------------------------------------------------------------------------------------------------------------------------------------

create table Transactions (SR#5 int,
					T_id varchar(20) not null primary key, 
                    C_id varchar(20) not null foreign key references Client(C_id),
                    O_id varchar(20) not null foreign key references Orders(O_id),
		   		    E_id varchar(20) not null foreign key references Employees(E_id),
				    Payment float,
				    Transaction_date date)



alter PROCEDURE Insertpayment
@C_Id varchar(20),@O_Id varchar(20), @E_Id varchar(20),@Payment float
AS
BEGIN
	DECLARE @TranId VARCHAR(25);
	DECLARE @PreFix VARCHAR(10) = 'T';
	DECLARE @Id INT;
	DECLARE @TRANSACTION_DATE DATE;

	SELECT @Id = ISNULL(MAX(SR#5),0) + 1 FROM transactions
	SELECT @TranId = @PreFix + RIGHT('0' + CAST(@Id AS VARCHAR(7)), 7)
	SELECT @TRANSACTION_DATE = CAST(GETDATE()AS DATE)

	INSERT INTO transactions VALUES  (@id, @TranId, @C_Id, @O_Id, @E_Id, @Payment,@TRANSACTION_DATE)
END

exec Insertpayment 'C01', 'O01', 'E01', '4000';------------


Select * from view_transaction
select * from transactions
---do it change

create procedure new_transaction
as 
begin
	
	select top 1 *from view_transaction order by [Trans ID] desc
	
end


----------------------------------------------------------------------------------------------------------------------------------------------------------

select * from Client
select * from Orders
select * from Order_details
select * from Fabrics
select * from Employees
select * from Transactions


------------------------------------------------------------------
--ORDER VIEW

create view view_order
as
select O.O_Id as [Order ID], O.C_Id as [Client ID], C.C_name as [Client Name], F.F_name as Fabric, D.Meters, D.Color,
D.Order_Price as [Order Price], O.Order_date as [Order Date], O.due_date as [Due Date] 
from orders O,Order_details D,Client C, Fabrics F
WHERE O.O_Id=D.O_Id and O.C_Id=C.C_Id and D.F_id = F.F_id

alter proc show_payment
@oid varchar(20)
as
begin
	select sum(Order_Price) from Order_details od inner join Transactions t on od.O_id = @oid
end

exec show_payment 'O01'

create TRIGGER price_calculate
ON Order_details
AFTER INSERT AS 
BEGIN
	update Order_details 
	set Order_details.Order_Price = (
	select f.F_rate from Fabrics f 
	where f.F_id = Order_details.F_id) * Order_details.Meters
END

select *from Order_details


select * from Orders
select * from Order_details
select * from view_order

---------------------------------------------------------
-------RATE VIEW

alter view view_rates
as
select fh.F_id as [Fabric ID], f.F_name as [Fabric], fh.F_rate as Rate, fh.H_Date as [Update Date] 
from Fabric_history fh
inner join Fabrics f
on fh.F_Id = f.F_id



---------------------------------------------------------
----TRANSACTION VIEW


create view view_transaction
as

select t.T_id as [Trans ID], c.C_name as [Client Name], t.O_id as [Order ID], o.Order_date as [Order Date], 
a.Meters, t.Payment, t.Transaction_date as [Payment Date], e.E_name as [Emp Name]
from Transactions t  
inner join Orders o
on t.O_id = o.O_id
inner join Order_details a
on t.O_id = a.O_id
left join Client c
on t.C_id = c.C_id
left join Employees e
on t.E_id = e.E_id  

select * from view_transaction



----------------------------------------MONTHLY REVENUE--------------------------------


alter function monthly_revenue(@cur_month int, @cur_year int)
returns int 
as 
begin
declare @rev int 

	set @rev = (select Sum(t.Payment) from Transactions t
	where	
		datepart(year,t.Transaction_date) = @cur_year
	and
		datepart(month,t.Transaction_date) = @cur_month)
	return @rev
end

select dbo.monthly_revenue(01,2022)

select * from transactions



-------------------------------------------------------------------------
----YEARLY REVENUE


create function yearly_revenue(@cur_year int)
returns int 
as 
begin
declare @rev int = 0

	set @rev = (select Sum(t.Payment) from Transactions t
	where	
		datepart(year,t.Transaction_date) = @cur_year)
	
	return @rev
end


select dbo.yearly_revenue(2020)


select O_id from Transactions

