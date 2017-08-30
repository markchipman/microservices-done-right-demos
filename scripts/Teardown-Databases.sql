USE [master]
GO

IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'1-Marketing')
DROP DATABASE [1-Marketing]
GO

IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'1-Sales')
DROP DATABASE [1-Sales]
GO

IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'1-Warehouse')
DROP DATABASE [1-Warehouse]
GO


IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'2-Marketing')
DROP DATABASE [2-Marketing]
GO

IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'2-Sales')
DROP DATABASE [2-Sales]
GO

IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'2-Warehouse')
DROP DATABASE [2-Warehouse]
GO