USE [master]
GO
/****** Object:  Database [StockManagementDB]    Script Date: 8/7/2018 3:48:53 PM ******/
CREATE DATABASE [StockManagementDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StockManagementDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\StockManagementDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'StockManagementDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\StockManagementDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [StockManagementDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StockManagementDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StockManagementDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StockManagementDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StockManagementDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StockManagementDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StockManagementDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [StockManagementDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StockManagementDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [StockManagementDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StockManagementDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StockManagementDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StockManagementDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StockManagementDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StockManagementDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StockManagementDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StockManagementDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StockManagementDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StockManagementDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StockManagementDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StockManagementDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StockManagementDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StockManagementDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StockManagementDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StockManagementDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StockManagementDB] SET RECOVERY FULL 
GO
ALTER DATABASE [StockManagementDB] SET  MULTI_USER 
GO
ALTER DATABASE [StockManagementDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StockManagementDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StockManagementDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StockManagementDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'StockManagementDB', N'ON'
GO
USE [StockManagementDB]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 8/7/2018 3:48:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Company]    Script Date: 8/7/2018 3:48:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Company](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Item]    Script Date: 8/7/2018 3:48:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Item](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](250) NOT NULL,
	[RecorderLevel] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[CompanyId] [int] NOT NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockIn]    Script Date: 8/7/2018 3:48:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockIn](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyId] [int] NOT NULL,
	[ItemId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_StockIn] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name]) VALUES (1, N'Electronics')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (11, N'Food and Bevarage')
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Company] ON 

INSERT [dbo].[Company] ([Id], [Name]) VALUES (3, N'LG')
INSERT [dbo].[Company] ([Id], [Name]) VALUES (4, N'Pran')
INSERT [dbo].[Company] ([Id], [Name]) VALUES (2, N'Singer')
INSERT [dbo].[Company] ([Id], [Name]) VALUES (1, N'Walton')
SET IDENTITY_INSERT [dbo].[Company] OFF
SET IDENTITY_INSERT [dbo].[Item] ON 

INSERT [dbo].[Item] ([Id], [Name], [RecorderLevel], [CategoryId], [CompanyId]) VALUES (2, N'TV', 250, 1, 1)
INSERT [dbo].[Item] ([Id], [Name], [RecorderLevel], [CategoryId], [CompanyId]) VALUES (3, N'Refrigerator', 200, 1, 2)
INSERT [dbo].[Item] ([Id], [Name], [RecorderLevel], [CategoryId], [CompanyId]) VALUES (4, N'Chips', 100, 11, 4)
SET IDENTITY_INSERT [dbo].[Item] OFF
SET IDENTITY_INSERT [dbo].[StockIn] ON 

INSERT [dbo].[StockIn] ([Id], [CompanyId], [ItemId], [Quantity]) VALUES (2, 1, 2, 50)
INSERT [dbo].[StockIn] ([Id], [CompanyId], [ItemId], [Quantity]) VALUES (4, 3, 4, 50)
INSERT [dbo].[StockIn] ([Id], [CompanyId], [ItemId], [Quantity]) VALUES (5, 3, 3, 200)
INSERT [dbo].[StockIn] ([Id], [CompanyId], [ItemId], [Quantity]) VALUES (6, 4, 4, 200)
INSERT [dbo].[StockIn] ([Id], [CompanyId], [ItemId], [Quantity]) VALUES (7, 1, 2, 100)
INSERT [dbo].[StockIn] ([Id], [CompanyId], [ItemId], [Quantity]) VALUES (8, 1, 2, 50)
INSERT [dbo].[StockIn] ([Id], [CompanyId], [ItemId], [Quantity]) VALUES (9, 1, 2, 150)
INSERT [dbo].[StockIn] ([Id], [CompanyId], [ItemId], [Quantity]) VALUES (10, 1, 2, 250)
SET IDENTITY_INSERT [dbo].[StockIn] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Category]    Script Date: 8/7/2018 3:48:54 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Category] ON [dbo].[Category]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Company]    Script Date: 8/7/2018 3:48:54 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Company] ON [dbo].[Company]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Item]    Script Date: 8/7/2018 3:48:54 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Item] ON [dbo].[Item]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Item_Category]
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([Id])
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Item_Company]
GO
ALTER TABLE [dbo].[StockIn]  WITH CHECK ADD  CONSTRAINT [FK_StockIn_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([Id])
GO
ALTER TABLE [dbo].[StockIn] CHECK CONSTRAINT [FK_StockIn_Company]
GO
ALTER TABLE [dbo].[StockIn]  WITH CHECK ADD  CONSTRAINT [FK_StockIn_Item] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Item] ([Id])
GO
ALTER TABLE [dbo].[StockIn] CHECK CONSTRAINT [FK_StockIn_Item]
GO
USE [master]
GO
ALTER DATABASE [StockManagementDB] SET  READ_WRITE 
GO
