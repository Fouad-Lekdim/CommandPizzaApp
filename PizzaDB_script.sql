-- ============================================================
--  CommandPizzaApp - Database Setup Script
--  Run this script in SSMS to create and seed the database.
--  Safe to re-run: uses IF NOT EXISTS guards throughout.
-- ============================================================


-- ------------------------------------------------------------
-- 1. Create the database if it doesn't exist
-- ------------------------------------------------------------
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'PizzaDB')
BEGIN
    CREATE DATABASE PizzaDB;
    PRINT 'Database PizzaDB created.';
END
ELSE
    PRINT 'Database PizzaDB already exists, skipping creation.';
GO

USE PizzaDB;
GO


-- ------------------------------------------------------------
-- 2. Table: PizzaSizes
-- ------------------------------------------------------------
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'PizzaSizes')
BEGIN
    CREATE TABLE [dbo].[PizzaSizes] (
        [PizzaSizeId] INT          NOT NULL,
        [Size]        NCHAR(10)    NOT NULL,
        [Price]       FLOAT        NOT NULL,
        CONSTRAINT [PK_PizzaSizes] PRIMARY KEY CLUSTERED ([PizzaSizeId] ASC)
    );
    PRINT 'Table PizzaSizes created.';
END
ELSE
    PRINT 'Table PizzaSizes already exists, skipping creation.';
GO


-- ------------------------------------------------------------
-- 3. Table: CrustTypes
-- ------------------------------------------------------------
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'CrustTypes')
BEGIN
    CREATE TABLE [dbo].[CrustTypes] (
        [CrustId]    INT           IDENTITY(1,1) NOT NULL,
        [CrustType]  NVARCHAR(10)  NOT NULL,
        [CrustPrice] FLOAT         NOT NULL,
        PRIMARY KEY CLUSTERED ([CrustId] ASC)
    );
    PRINT 'Table CrustTypes created.';
END
ELSE
    PRINT 'Table CrustTypes already exists, skipping creation.';
GO


-- ------------------------------------------------------------
-- 4. Table: Orders  (starts empty — populated via the app)
-- ------------------------------------------------------------
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Orders')
BEGIN
    CREATE TABLE [dbo].[Orders] (
        [OrderNumber]  INT           IDENTITY(1,1) NOT NULL,
        [PizzaSizeId]  INT           NOT NULL,
        [CrustTypeId]  INT           NOT NULL,
        [Toppings]     NVARCHAR(500) NULL,
        [WhereToEat]   NVARCHAR(50)  NOT NULL,
        [TotalPrice]   FLOAT         NOT NULL,
        CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([OrderNumber] ASC),
        CONSTRAINT [FK_Orders_PizzaSizes] FOREIGN KEY ([PizzaSizeId])
            REFERENCES [dbo].[PizzaSizes] ([PizzaSizeId])
    );
    PRINT 'Table Orders created.';
END
ELSE
    PRINT 'Table Orders already exists, skipping creation.';
GO


-- ------------------------------------------------------------
-- 5. Seed data: PizzaSizes
--    Only inserts if the table is empty.
-- ------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM PizzaSizes)
BEGIN
    INSERT [dbo].[PizzaSizes] ([PizzaSizeId], [Size], [Price]) VALUES (1, N'Small',  3)
    INSERT [dbo].[PizzaSizes] ([PizzaSizeId], [Size], [Price]) VALUES (2, N'Medium', 6)
    INSERT [dbo].[PizzaSizes] ([PizzaSizeId], [Size], [Price]) VALUES (3, N'Large',  10)
    PRINT 'PizzaSizes seeded.';
END
ELSE
    PRINT 'PizzaSizes already has data, skipping seed.';
GO


-- ------------------------------------------------------------
-- 6. Seed data: CrustTypes
--    Only inserts if the table is empty.
-- ------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM CrustTypes)
BEGIN
    SET IDENTITY_INSERT [dbo].[CrustTypes] ON
    INSERT [dbo].[CrustTypes] ([CrustId], [CrustType], [CrustPrice]) VALUES (1, N'Thin',  5)
    INSERT [dbo].[CrustTypes] ([CrustId], [CrustType], [CrustPrice]) VALUES (2, N'Thick', 8)
    SET IDENTITY_INSERT [dbo].[CrustTypes] OFF
    PRINT 'CrustTypes seeded.';
END
ELSE
    PRINT 'CrustTypes already has data, skipping seed.';
GO


-- ------------------------------------------------------------
-- Done!
-- ------------------------------------------------------------
PRINT '--------------------------------------------';
PRINT 'PizzaDB is ready. You can now run the app.';
PRINT '--------------------------------------------';
GO
