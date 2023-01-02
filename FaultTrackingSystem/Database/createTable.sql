CREATE DATABASE FaultTrackingAutomation

USE FaultTrackingAutomation

-- Il tablosu
CREATE TABLE City
(
Id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(128) NOT NULL,
Code INT NOT NULL
)

-- Ilce tablosu
CREATE TABLE District
(
Id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(128) NOT NULL,
CityId INT NOT NULL

CONSTRAINT FK_CityId_District FOREIGN KEY (CityId) REFERENCES City(Id) ON UPDATE CASCADE ON DELETE CASCADE
)

-- Musteri tablosu
CREATE TABLE Customer
(
Id INT PRIMARY KEY IDENTITY(1,1),
FirstName VARCHAR(128) NULL,
LastName VARCHAR(128) NULL,
Gender CHAR(1) NULL,
UserName VARCHAR(128) NOT NULL,
EmailAddress VARCHAR(128) NOT NULL,
PasswordHash VARCHAR(128) NOT NULL

CONSTRAINT UQ_UserName_Customer UNIQUE(UserName),
CONSTRAINT UQ_EmailAddress_Customer UNIQUE(EmailAddress)
)

-- Cihaz tablosu
CREATE TABLE Device
(
Id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(128) NOT NULL
)

-- Cihaz turu tablosu
CREATE TABLE DeviceType
(
Id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(128) NOT NULL,
DeviceId INT NOT NULL

CONSTRAINT FK_DeviceId_DeviceType FOREIGN KEY (DeviceId) REFERENCES Device(Id) ON UPDATE CASCADE ON DELETE CASCADE
)

-- Marka tablosu
CREATE TABLE Brand
(
Id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(128) NOT NULL,
DeviceTypeId INT NOT NULL

CONSTRAINT FK_DeviceTypeId_Brand FOREIGN KEY (DeviceTypeId) REFERENCES DeviceType(Id) ON UPDATE CASCADE ON DELETE CASCADE
)

CREATE TABLE SparePart
(
Id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(128) NOT NULL,
Amount INT NOT NULL,
PurchaseDate DATE NOT NULL,
Price FLOAT(2) NOT NULL,
DeviceTypeId INT NULL

CONSTRAINT FK_DeviceTypeId_SparePart FOREIGN KEY (DeviceTypeId) REFERENCES DeviceType(Id) ON UPDATE CASCADE ON DELETE SET NULL
)

-- Arizali cihazlarin tutuldugu tablo
CREATE TABLE Fault
(
Id INT PRIMARY KEY IDENTITY(1,1),
SerialNumber CHAR(13) NOT NULL,
CustomerId INT NOT NULL,
BrandId INT NULL,
Title VARCHAR(128) NOT NULL,
Description VARCHAR(MAX) NOT NULL,
ReportedAt DATETIME NOT NULL,
DeviceImage IMAGE  NULL,
DistrictId INT NULL,
OpenAddress VARCHAR(MAX) NOT NULL,
IsPay CHAR(1) NOT NULL,
IsGrouped CHAR(1) NOT NULL

CONSTRAINT UQ_SerialNumber_Fault UNIQUE(SerialNumber),
CONSTRAINT FK_CustomerId_Fault FOREIGN KEY (CustomerId) REFERENCES Customer(Id),
CONSTRAINT FK_BrandId_Fault FOREIGN KEY (BrandId) REFERENCES Brand(Id) ON DELETE SET NULL,
CONSTRAINT FK_DistrictId_Fault FOREIGN KEY (DistrictId) REFERENCES District(Id) ON DELETE SET NULL
)

-- Yonetici tablosu
CREATE TABLE Manager
(
Id INT PRIMARY KEY IDENTITY(1,1),
Code CHAR(20) NOT NULL,
EmailAddress VARCHAR(128) NOT NULL,
PasswordHash VARCHAR(128) NOT NULL,
NationalNumber CHAR(11) NOT NULL,
FirstName VARCHAR(128) NOT NULL,
LastName VARCHAR(128) NOT NULL,
Gender CHAR(1) NOT NULL,
UserType CHAR(1) NOT NULL

CONSTRAINT UQ_Code_Manager UNIQUE(Code),
CONSTRAINT UQ_Email_Manager UNIQUE(EmailAddress),
CONSTRAINT UQ_NationalNumber_Manager UNIQUE(NationalNumber)
)

-- Personel tablosu
CREATE TABLE Staff
(
Id INT PRIMARY KEY IDENTITY(1,1),
Code CHAR(20) NOT NULL,
EmailAddress VARCHAR(128) NOT NULL,
PasswordHash VARCHAR(128) NOT NULL,
NationalNumber VARCHAR(128) NOT NULL,
FirstName VARCHAR(128) NOT NULL,
LastName VARCHAR(128) NOT NULL,
Gender CHAR(1) NOT NULL,
UserType CHAR(1) NOT NULL,
Salary FLOAT(2) NOT NULL

CONSTRAINT UQ_Code_Staff UNIQUE(Code),
CONSTRAINT UQ_Email_Staff UNIQUE(EmailAddress),
CONSTRAINT UQ_NationalNumber_Staff UNIQUE(NationalNumber)
)

-- Teknisyen tablosu
CREATE TABLE Technician
(
Id INT PRIMARY KEY IDENTITY(1,1),
Code CHAR(20) NOT NULL,
EmailAddress VARCHAR(128) NOT NULL,
PasswordHash VARCHAR(128) NOT NULL,
NationalNumber CHAR(11) NOT NULL,
FirstName VARCHAR(128) NOT NULL,
LastName VARCHAR(128) NOT NULL,
Gender CHAR(1) NOT NULL,
UserType CHAR(1) NOT NULL,
Salary FLOAT(2) NOT NULL,
DeviceId INT NULL

CONSTRAINT UQ_Code_Technician UNIQUE(Code),
CONSTRAINT UQ_Email_Technician UNIQUE(EmailAddress),
CONSTRAINT UQ_NationalNumber_Technician UNIQUE(NationalNumber),
CONSTRAINT FK_DeviceId_Technician FOREIGN KEY (DeviceId) REFERENCES Device(Id) ON DELETE SET NULL
)

-- Arizali cihazlara atanan teknisyenlerin tablosu
CREATE TABLE Assignment
(
Id INT PRIMARY KEY IDENTITY(1,1),
TechnicianId INT NOT NULL,
FaultId INT NOT NULL,
AssignedAt DATETIME NOT NULL

CONSTRAINT FK_Technician_Assignment FOREIGN KEY (TechnicianId) REFERENCES Technician(Id),
CONSTRAINT FK_FaultId_Assignment FOREIGN KEY (FaultId) REFERENCES Fault(Id)
)

--Arizali cihazlara hangi islemlerin yapildigini tutan tablo
CREATE TABLE Repair 
(
Id INT PRIMARY KEY IDENTITY(1,1),
FaultId INT NOT NULL,
AssignmentId INT NOT NULL,
RepairDate DATETIME NOT NULL,
Title VARCHAR(128) NOT NULL,
Description VARCHAR(MAX) NOT NULL,
DeviceStatus VARCHAR(128) NOT NULL,
TotalPrice FLOAT(2) DEFAULT(0)

CONSTRAINT FK_FaultId_Repair FOREIGN KEY (FaultId) REFERENCES Fault(Id),
CONSTRAINT FK_AssignmentId_Repair FOREIGN KEY (AssignmentId) REFERENCES Assignment(Id)
)

-- Arizali cihazlar icin faturalarin tutuldugu tablo
CREATE TABLE Invoice 
(
Id INT PRIMARY KEY IDENTITY(1,1),
CustomerId INT NOT NULL,
RepairId INT NOT NULL,
InvoiceDate DATETIME NOT NULL,
Paid FLOAT(2) NOT NULL

CONSTRAINT FK_CustomerId_Invoice FOREIGN KEY (CustomerId) REFERENCES Customer(Id),
CONSTRAINT FK_RepairId_Invoice FOREIGN KEY (RepairId) REFERENCES Repair(Id)
)

-- Kredi karti turu
CREATE TABLE CreditCardType
(
Id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(128) NOT NULL
)