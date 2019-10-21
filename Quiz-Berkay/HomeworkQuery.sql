Create Database BankaDb
Go
Use BankaDb
Go
Create Table Customers
(
	CustomerId int identity Primary Key,
	FirstName varchar(50),
	LastName varchar(50),
	Email varchar(100) Unique,
	IdentityNumber char(11) Unique,
	PhoneNumber char(11) Unique
)