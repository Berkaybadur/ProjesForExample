Create Database CRMDB
Go
Use CRMDB
Go 
Create Table Products
(
	Id Int Identity Primary Key,
	Name Varchar(50),
	Price Money
)
Go
Create Proc SP_Insert
	@Name  Varchar(50),
	@Price Money
As
	Insert Into Products Values(@Name,@Price)
Go
Create Proc SP_Update
	@Id Int,
	@Name  Varchar(50),
	@Price Money
As
	Update Products Set Name=@Name, Price=@Price
	Where Id=@Id
Go
Create Proc SP_Delete
	@Id Int
As
	Delete From Products Where Id = @Id
Go
Create Proc SP_Select
As
	Select * From Products
Go
Exec SP_Insert 'Muz ',25
Go
Exec SP_Insert 'Domates',10
Go
Exec SP_Insert 'Patates',32
Go
Create Proc SP_GetProductById
	@Id Int
As
	Select * From Products Where Id=@Id