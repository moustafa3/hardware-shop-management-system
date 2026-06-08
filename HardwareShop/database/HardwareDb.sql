CREATE DATABASE HardwareDb;
GO

USE HardwareDb;
GO

CREATE TABLE CategoryTbl
(
    CatCode INT IDENTITY(1,1) PRIMARY KEY,
    CatName NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE CustomerTbl
(
    CustCode INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Gender NVARCHAR(20) NOT NULL,
    Phone NVARCHAR(30) NOT NULL
);
GO

CREATE TABLE ItemTbl
(
    ItCode INT IDENTITY(1,1) PRIMARY KEY,
    ItName NVARCHAR(100) NOT NULL,
    ItCategory INT NOT NULL,
    ItPrice DECIMAL(18,2) NOT NULL,
    ItStock INT NOT NULL,
    Manufacturer NVARCHAR(100) NOT NULL,

    CONSTRAINT FK_Item_Category
        FOREIGN KEY (ItCategory)
        REFERENCES CategoryTbl(CatCode)
);
GO

CREATE TABLE BillingTbl
(
    BCode INT IDENTITY(1,1) PRIMARY KEY,
    BDate DATE NOT NULL,
    Customer INT NOT NULL,
    Amount DECIMAL(18,2) NOT NULL,
    PaymentMode NVARCHAR(30) NOT NULL,

    CONSTRAINT FK_Billing_Customer
        FOREIGN KEY (Customer)
        REFERENCES CustomerTbl(CustCode)
);
GO

INSERT INTO CategoryTbl (CatName)
VALUES
('Tools'),
('Electrical'),
('Plumbing'),
('Paint'),
('Safety');
GO

INSERT INTO CustomerTbl (Name, Gender, Phone)
VALUES
('Unknown', 'N/A', 'N/A'),
('John Doe', 'Male', '0600000000'),
('Sara Smith', 'Female', '0611111111');
GO

INSERT INTO ItemTbl (ItName, ItCategory, ItPrice, ItStock, Manufacturer)
VALUES
('Hammer', 1, 15.00, 50, 'Generic'),
('Screwdriver', 1, 8.00, 100, 'Generic'),
('Electric Cable', 2, 25.00, 40, 'CableCo'),
('Water Pipe', 3, 12.00, 60, 'PipeCo'),
('Paint Bucket', 4, 35.00, 20, 'PaintCo'),
('Safety Gloves', 5, 5.00, 200, 'SafeCo');
GO

INSERT INTO BillingTbl (BDate, Customer, Amount, PaymentMode)
VALUES
(CAST(GETDATE() AS DATE), 1, 15.00, 'Cash'),
(CAST(GETDATE() AS DATE), 2, 25.00, 'Mobile'),
(CAST(GETDATE() AS DATE), 3, 35.00, 'Card');
GO