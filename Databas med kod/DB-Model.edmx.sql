
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/25/2023 08:32:37
-- Generated from EDMX file: C:\Programmering 2\C#\Databas med kod\DB-Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Test];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Table]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Table];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Table'
CREATE TABLE [dbo].[Table] (
    [PersonNr] nchar(10)  NOT NULL,
    [Förnamn] nvarchar(50)  NOT NULL,
    [Efternamn] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'BokSet'
CREATE TABLE [dbo].[BokSet] (
    [BokNr] int IDENTITY(1,1) NOT NULL,
    [Titel] nvarchar(max)  NOT NULL,
    [Ämne] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [PersonNr] in table 'Table'
ALTER TABLE [dbo].[Table]
ADD CONSTRAINT [PK_Table]
    PRIMARY KEY CLUSTERED ([PersonNr] ASC);
GO

-- Creating primary key on [BokNr] in table 'BokSet'
ALTER TABLE [dbo].[BokSet]
ADD CONSTRAINT [PK_BokSet]
    PRIMARY KEY CLUSTERED ([BokNr] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------