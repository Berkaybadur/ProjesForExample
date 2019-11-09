Create database Havaalanıs
Go
Use Havaalanıs
go
Create table Country
(
CountryId int identity primary key,
CountryName Varchar(50)
)
Go

Create table Provinces
(
ProvincesId int identity primary key,
ProvincesName Varchar(50),
Country_Id int,
Constraint FK_Country_Prov Foreign Key(Country_Id) References Country(CountryId)
)
Go

Create table District
(
DistrictId int identity primary key,
DistrictName Varchar(50),
Province_Id int,
Constraint FK_Prov_Dist Foreign Key(Province_Id) References Provinces(ProvincesId)
)
Go

Create table Airport
(
AirportId int identity primary key,
AirportName Varchar(50),
DistrictId int,
Constraint FK_Dist_Dist Foreign Key(DistrictId) References District(DistrictId)


)
Go

Create table Airplane
(
AirplaneId int identity primary key,
AirplaneName Varchar(50),
SeatingCapacity Varchar(50),
AirportId int,
Constraint FK_Airport_Airport Foreign Key(AirportId) References Airport(AirportId)

)
Go

Create Table Title
(
TitleId int identity Primary Key,
Title varchar(25)

)
Go


Create table Personel
(
PersonelId int identity primary key,
PersonelTc varchar(11) unique,
PersonelFirstName varchar(25),
PersonelLastName varchar(25),
PersonelPhoneNumber varchar(11),
PersonelAddress nvarchar(100),
District int,
AirplaneId int,
CONSTRAINT chk_PersonelPhoneNumber CHECK (PersonelPhoneNumber like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
TitleId int,
Foreign Key(AirplaneId) References Airplane(AirplaneId),
Foreign Key(TitleId) References Title(TitleId),
Foreign Key(District) References District(DistrictId)

)

Go

Create table Expedition
(
ExpeditionId int identity primary key,
DepartureLocation Varchar(50),
RotationLocation Varchar(50),
DepartureDatetime datetime,
RotationDatetime datetime,
District int,
Foreign key(District) References District(DistrictId),
AirplaneId int,
Foreign key(AirplaneId) References Airplane(AirplaneId)


)

Go

Create table Degree
(
DegreeId int identity primary key,
Name Varchar(50),
)
Go

Create table Customers
(
CustomerId int identity primary key,
CustomerTc varchar(11) unique,
CustomerName Varchar(50),
CustomerSurname Varchar(50),
CustomerMail Varchar(50),
CustomerPhone Varchar(11),
CustomerAdress Varchar(50),
UserName Varchar(50),
UserPassword Varchar(50),
DegreeId int,
DistrictId int,
 Foreign Key(DistrictId) References District(DistrictId),
  Foreign Key(DegreeId) References Degree(DegreeId),
  CONSTRAINT chk_CustomerPhone CHECK (CustomerPhone like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
)
Go




Create table Ticket
(
TicketId int identity primary key,
NumberOfSeats Varchar(5),
Price money,
ExpeditionId int,
CustomerId int,
AirplaneId int,
AirportId int,
DistrictId int,
Foreign Key(AirportId) References Airport(AirportId),
Foreign Key(AirplaneId) References Airplane(AirplaneId),
Foreign Key(CustomerId) References Customers(CustomerId),
Foreign Key(ExpeditionId) References Expedition(ExpeditionId),
 Foreign Key(DistrictId) References District(DistrictId)
)
Go
























