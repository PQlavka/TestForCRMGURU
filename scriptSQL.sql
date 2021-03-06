USE [master]
GO
/****** Object:  Database [localcsharp]    Script Date: 22.08.2020 20:59:13 ******/
CREATE DATABASE [localcsharp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'localcsharp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\localcsharp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'localcsharp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\localcsharp_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [localcsharp] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [localcsharp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [localcsharp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [localcsharp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [localcsharp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [localcsharp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [localcsharp] SET ARITHABORT OFF 
GO
ALTER DATABASE [localcsharp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [localcsharp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [localcsharp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [localcsharp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [localcsharp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [localcsharp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [localcsharp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [localcsharp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [localcsharp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [localcsharp] SET  DISABLE_BROKER 
GO
ALTER DATABASE [localcsharp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [localcsharp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [localcsharp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [localcsharp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [localcsharp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [localcsharp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [localcsharp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [localcsharp] SET RECOVERY FULL 
GO
ALTER DATABASE [localcsharp] SET  MULTI_USER 
GO
ALTER DATABASE [localcsharp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [localcsharp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [localcsharp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [localcsharp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [localcsharp] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'localcsharp', N'ON'
GO
ALTER DATABASE [localcsharp] SET QUERY_STORE = OFF
GO
USE [localcsharp]
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 22.08.2020 20:59:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 22.08.2020 20:59:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Code] [varchar](50) NULL,
	[Capital] [int] NOT NULL,
	[Space_m2] [real] NULL,
	[Population] [bigint] NULL,
	[Region] [int] NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Regions]    Script Date: 22.08.2020 20:59:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Regions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Regions] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cities] ON 

INSERT [dbo].[Cities] ([id], [Name]) VALUES (1, N'Kiev')
INSERT [dbo].[Cities] ([id], [Name]) VALUES (2, N'Moscow')
INSERT [dbo].[Cities] ([id], [Name]) VALUES (3, N'Minsk')
SET IDENTITY_INSERT [dbo].[Cities] OFF
GO
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([id], [Name], [Code], [Capital], [Space_m2], [Population], [Region]) VALUES (1, N'Ukraine', N'UA', 1, 603700, 42692393, 1)
INSERT [dbo].[Countries] ([id], [Name], [Code], [Capital], [Space_m2], [Population], [Region]) VALUES (4, N'Russian Federation', N'RU', 2, 17124442, 146599183, 1)
INSERT [dbo].[Countries] ([id], [Name], [Code], [Capital], [Space_m2], [Population], [Region]) VALUES (5, N'Belarus', N'BY', 3, 207600, 9498700, 1)
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
SET IDENTITY_INSERT [dbo].[Regions] ON 

INSERT [dbo].[Regions] ([id], [Name]) VALUES (1, N'Europe')
SET IDENTITY_INSERT [dbo].[Regions] OFF
GO
ALTER TABLE [dbo].[Countries]  WITH CHECK ADD  CONSTRAINT [FK_Countries_Cities] FOREIGN KEY([Capital])
REFERENCES [dbo].[Cities] ([id])
GO
ALTER TABLE [dbo].[Countries] CHECK CONSTRAINT [FK_Countries_Cities]
GO
ALTER TABLE [dbo].[Countries]  WITH CHECK ADD  CONSTRAINT [FK_Countries_Regions] FOREIGN KEY([Region])
REFERENCES [dbo].[Regions] ([id])
GO
ALTER TABLE [dbo].[Countries] CHECK CONSTRAINT [FK_Countries_Regions]
GO
/****** Object:  StoredProcedure [dbo].[AddCountry]    Script Date: 22.08.2020 20:59:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddCountry] 
	@name VARCHAR(50), @capital VARCHAR(50), @region VARCHAR(50), @code VARCHAR(50), @area REAL, @pop BIGINT
AS
BEGIN
	DECLARE @cap INT
	SET @cap = NULL
	SELECT TOP 1 @cap = id FROM Cities WHERE Name = @capital
	IF @cap IS NULL 
	BEGIN
		INSERT INTO Cities(Name) VALUES (@capital)
		SELECT TOP 1 @cap = id FROM Cities WHERE Name = @capital
	END

	DECLARE @reg INT
	SET @reg = NULL
	SELECT TOP 1 @reg = id FROM Regions WHERE Name = @region
	IF @reg IS NULL 
	BEGIN
		INSERT INTO Regions(Name) VALUES (@region)
		SELECT TOP 1 @reg = id FROM Regions WHERE Name = @region
	END
	
	DECLARE @countr INT
	SET @countr = NULL
	SELECT TOP 1 @countr = id FROM Countries WHERE Name = @name
	IF @countr IS NULL INSERT INTO Countries(Name, Capital, Region, Space_m2, Population, Code) VALUES (@name, @cap, @reg, @area, @pop, @code)
	ELSE UPDATE Countries SET Code = @code, Space_m2 = @area, Population = @pop, Capital = @cap, Region = @reg WHERE id = @countr
END
GO
USE [master]
GO
ALTER DATABASE [localcsharp] SET  READ_WRITE 
GO
