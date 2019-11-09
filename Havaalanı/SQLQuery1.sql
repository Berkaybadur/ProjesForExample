Create database HavaalanıOtomasyon
Go


Create table District
(
DistrictId int identity primary key,
DistrictName Varchar(50),
)
Go

Create table Provinces
(
ProvincesId int identity primary key,
ProvincesName Varchar(50),
)
Go



Create table Country
(
CountryId int identity primary key,
CountryName Varchar(50),
ProvincesId int,
DistrictId int,
Constraint FK_Provinces_Provinces Foreign Key(ProvincesId) References Provinces(ProvincesId),
Constraint FK_District_District Foreign Key(DistrictId) References District(DistrictId)

)
Go

Create table Airport
(
AirportId int identity primary key,
AirportName Varchar(50),
CountryId int,
ProvincesId int,
DistrictId int,
Constraint FK_Province_Province Foreign Key(ProvincesId) References Provinces(ProvincesId),
Constraint FK_Dist_Dist Foreign Key(DistrictId) References District(DistrictId),
Constraint FK_Country_Country Foreign Key(CountryId) References Country(CountryId)

)
Go

Create table Airplane
(
AirplaneId int identity primary key,
AirplaneName Varchar(50),

)
Go





