CREATE DATABASE BeautySalon2
 
GO

USE BeautySalon2
GO
 

-- Створення таблиці Users

CREATE SCHEMA UserManagement;

CREATE TABLE UserManagement.Users(
  Id int NOT NULL,
  UsersFirstName varchar(max) NULL,
  UsersLastName VARCHAR(50) NULL,
  UsersEmail VARCHAR(50) NULL,
   Passwordd varchar(50)  NULL,
PRIMARY KEY ( Id))

GO

-- таблиця комент
CREATE TABLE UserManagement.Сomments(
  Id int NOT NULL,
  UserID int NOT NULL,
  MastersID int NOT NULL,
  Rating decimal(5,1) NOT NULL,
  CreateTime  DATETIME NOT   NULL,
  Comments varchar(200),
PRIMARY KEY (Id ))
GO

--таблиця відповідь на комент
CREATE TABLE UserManagement.Reply(
  Id int NOT NULL,
  CommentId int,
  TextPeply varchar(200),
  DateTimeReply DATETIME NOT   NULL,
PRIMARY KEY (Id ))
GO


CREATE SCHEMA  ServicedManagement;
--таблиця послуги
CREATE TABLE ServicedManagement.Serviced(
    Id int NOT NULL,
    ServiceName varchar(50) NULL,
    DescriptionServices varchar(200) NULL,
    Price int  NULL,
PRIMARY KEY (Id) )

GO
--таблиця майстри
CREATE TABLE ServicedManagement.Masters(
  Id int NOT NULL,
  FirstName nchar(50)   NULL,
  LastName nchar(50)    NULL,
  MastersType  nchar(255)   NULL,
  ServiceID int  NULL,
  SalonID int  NULL,
PRIMARY KEY (Id))
GO
--таблиця міста
CREATE TABLE ServicedManagement.SalonCity(
  Id int NOT NULL,
  CitySalon nchar(255)   NULL,
PRIMARY KEY (Id))
GO


--таблиця продукти
CREATE TABLE ServicedManagement.Products (
    Id int ,
    ProductName varchar(50) NOT NULL,
    Description varchar(200),
    Price decimal(10,2) NOT NULL,
	PRIMARY KEY (Id ))
GO


CREATE SCHEMA OrdersManagement;
--таблиця замовлення послуги
CREATE TABLE OrdersManagement.Ordeers(
 Id int NOT NULL,
  UserID int  NOT  NULL,
  ServiceID int NOT   NULL,
  ProductID int NOT   NULL,
OrderDate  DATETIME NOT   NULL,
PRIMARY KEY (Id ))

GO
--таблиця замовлення продуктів
CREATE TABLE OrdersManagement.ProductOrders (
    Id int NOT  NULL,
	UserID int NOT  NULL,
    ProductID int NOT  NULL,
    Quantity int,
	PRIMARY KEY (Id ))
GO
CREATE TABLE UserManagement.СommentsProducts(
  Id int NOT NULL,
  UserID int NOT NULL,
  ProductID int NOT NULL,
  Rating decimal(5,1) NOT NULL,
  CreateTime  DATETIME NOT   NULL,
  Comments varchar(200),
PRIMARY KEY (Id ))
GO

--таблиця відповідь на комент
CREATE TABLE UserManagement.ReplyProducts(
  Id int NOT NULL,
  CommentProductId int,
  TextProductReply varchar(200),
  DateTimeProductReply DATETIME NOT   NULL,
PRIMARY KEY (Id ))
GO



--1
ALTER TABLE UserManagement. СommentsProducts
ADD FOREIGN KEY (UserID ) REFERENCES UserManagement.Users(Id  )

GO 


--1
ALTER TABLE UserManagement. СommentsProducts
ADD FOREIGN KEY (ProductID) REFERENCES ServicedManagement.Products (Id  )

GO 

--1
ALTER TABLE UserManagement. ReplyProducts
ADD FOREIGN KEY (CommentProductId) REFERENCES UserManagement. СommentsProducts (Id  )

GO 

--1
ALTER TABLE UserManagement.Сomments
ADD FOREIGN KEY (UserID ) REFERENCES UserManagement.Users(Id  )

GO 


--1
ALTER TABLE UserManagement.Сomments
ADD FOREIGN KEY (MastersID ) REFERENCES ServicedManagement.Masters(Id  )

GO 


--1
ALTER TABLE    OrdersManagement.ProductOrders
ADD FOREIGN KEY (Id  ) REFERENCES ServicedManagement.Products (Id   )

GO 
--1.2
ALTER TABLE ServicedManagement.Masters
ADD FOREIGN KEY (Id) REFERENCES ServicedManagement.SalonCity (Id )

GO 
--2

ALTER TABLe  ServicedManagement.Masters
ADD FOREIGN KEY (SalonID) REFERENCES ServicedManagement.Serviced (Id )

GO 

--4

ALTER TABLE OrdersManagement.Ordeers
ADD FOREIGN KEY (ServiceID) REFERENCES ServicedManagement.Serviced (Id )

GO 


--клієнт та його замовлення
ALTER TABLE    OrdersManagement.Ordeers
ADD FOREIGN KEY (UserID) REFERENCES UserManagement.Users (Id )

GO 

--клієнт та його замовлення продуктів
ALTER TABLE    OrdersManagement.ProductOrders
ADD FOREIGN KEY (UserID) REFERENCES UserManagement.Users (Id )

GO 

--клієнт та його замовлення
ALTER TABLE    UserManagement.Reply
ADD FOREIGN KEY (CommentId) REFERENCES UserManagement.Сomments (Id )

GO
