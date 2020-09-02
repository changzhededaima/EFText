
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/14/2020 17:47:17
-- Generated from EDMX file: E:\项目解决方案\EFText\EFText\EFModel2.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EFStudet];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Techer'
CREATE TABLE [dbo].[Techer] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Class] nvarchar(20)  NOT NULL,
    [Name] nvarchar(20)  NOT NULL,
    [CreateTime] datetime  NOT NULL
);
GO

-- Creating table 'OrderInfo'
CREATE TABLE [dbo].[OrderInfo] (
    [Id] uniqueidentifier  NOT NULL,
    [OrderNum] nvarchar(50)  NOT NULL,
    [CreateTime] nvarchar(max)  NOT NULL,
    [TecherId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Techer'
ALTER TABLE [dbo].[Techer]
ADD CONSTRAINT [PK_Techer]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OrderInfo'
ALTER TABLE [dbo].[OrderInfo]
ADD CONSTRAINT [PK_OrderInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TecherId] in table 'OrderInfo'
ALTER TABLE [dbo].[OrderInfo]
ADD CONSTRAINT [FK_TecherOrderInfo]
    FOREIGN KEY ([TecherId])
    REFERENCES [dbo].[Techer]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TecherOrderInfo'
CREATE INDEX [IX_FK_TecherOrderInfo]
ON [dbo].[OrderInfo]
    ([TecherId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------