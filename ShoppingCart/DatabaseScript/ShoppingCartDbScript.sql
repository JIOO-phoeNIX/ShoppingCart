﻿USE [master]
GO
/****** Object:  Database [ShoppingCart]    Script Date: 8/14/2020 6:34:49 AM ******/
CREATE DATABASE [ShoppingCart]
 
GO
ALTER DATABASE [ShoppingCart] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShoppingCart].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ShoppingCart] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [ShoppingCart] SET ANSI_NULLS ON 
GO
ALTER DATABASE [ShoppingCart] SET ANSI_PADDING ON 
GO
ALTER DATABASE [ShoppingCart] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [ShoppingCart] SET ARITHABORT ON 
GO
ALTER DATABASE [ShoppingCart] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ShoppingCart] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ShoppingCart] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ShoppingCart] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ShoppingCart] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ShoppingCart] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [ShoppingCart] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [ShoppingCart] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ShoppingCart] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [ShoppingCart] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ShoppingCart] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ShoppingCart] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ShoppingCart] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ShoppingCart] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ShoppingCart] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ShoppingCart] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ShoppingCart] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ShoppingCart] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ShoppingCart] SET RECOVERY FULL 
GO
ALTER DATABASE [ShoppingCart] SET  MULTI_USER 
GO
ALTER DATABASE [ShoppingCart] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ShoppingCart] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ShoppingCart] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ShoppingCart] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [ShoppingCart]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 8/14/2020 6:34:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 8/14/2020 6:34:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](500) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Price] [decimal](16, 2) NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [Name], [Description]) VALUES (1, N'Electronics', N'Home appliances')
INSERT [dbo].[Categories] ([CategoryID], [Name], [Description]) VALUES (3, N'Mobile Phone', N'Smart devices')
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [Name], [Description], [CategoryId], [Price]) VALUES (1, N'Home Theater', N'Take your home theater system to another level ', 1, CAST(300.00 AS Decimal(16, 2)))
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [CategoryId], [Price]) VALUES (2, N'Air Conditioner', N'Best Air Conditioner you can get', 1, CAST(250.00 AS Decimal(16, 2)))
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [CategoryId], [Price]) VALUES (3, N'Refrigerator', N'Make all your food and drinks stay fresh', 1, CAST(450.00 AS Decimal(16, 2)))
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [CategoryId], [Price]) VALUES (4, N'Standing Fan', N'Make your home hear free', 1, CAST(200.00 AS Decimal(16, 2)))
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [CategoryId], [Price]) VALUES (5, N'iPhone X', N'Neatly used iPhone  X', 3, CAST(600.00 AS Decimal(16, 2)))
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [CategoryId], [Price]) VALUES (6, N'Sony Xperia', N'New from the store', 3, CAST(500.00 AS Decimal(16, 2)))
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [CategoryId], [Price]) VALUES (7, N'Samsung Galaxy', N'Very neat', 3, CAST(550.00 AS Decimal(16, 2)))
SET IDENTITY_INSERT [dbo].[Products] OFF
USE [master]
GO
ALTER DATABASE [ShoppingCart] SET  READ_WRITE 
GO
