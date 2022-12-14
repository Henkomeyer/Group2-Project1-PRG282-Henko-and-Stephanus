USE [master]
GO
/****** Object:  Database [PRG_282_Project_Database]    Script Date: 2022/11/17 16:56:33 ******/
CREATE DATABASE [PRG_282_Project_Database]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PRG_281_Project_Database', FILENAME = N'D:\SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PRG_281_Project_Database.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PRG_281_Project_Database_log', FILENAME = N'D:\SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PRG_281_Project_Database_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PRG_282_Project_Database] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PRG_282_Project_Database].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PRG_282_Project_Database] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PRG_282_Project_Database] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PRG_282_Project_Database] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PRG_282_Project_Database] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PRG_282_Project_Database] SET ARITHABORT OFF 
GO
ALTER DATABASE [PRG_282_Project_Database] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PRG_282_Project_Database] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PRG_282_Project_Database] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PRG_282_Project_Database] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PRG_282_Project_Database] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PRG_282_Project_Database] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PRG_282_Project_Database] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PRG_282_Project_Database] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PRG_282_Project_Database] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PRG_282_Project_Database] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PRG_282_Project_Database] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PRG_282_Project_Database] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PRG_282_Project_Database] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PRG_282_Project_Database] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PRG_282_Project_Database] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PRG_282_Project_Database] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PRG_282_Project_Database] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PRG_282_Project_Database] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PRG_282_Project_Database] SET  MULTI_USER 
GO
ALTER DATABASE [PRG_282_Project_Database] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PRG_282_Project_Database] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PRG_282_Project_Database] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PRG_282_Project_Database] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PRG_282_Project_Database] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PRG_282_Project_Database] SET QUERY_STORE = OFF
GO
USE [PRG_282_Project_Database]
GO
/****** Object:  Table [dbo].[Module Info]    Script Date: 2022/11/17 16:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Module Info](
	[Module Code] [varchar](50) NULL,
	[Module Name] [varchar](50) NOT NULL,
	[Module Description] [varchar](50) NOT NULL,
	[Links to Resources] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student Info]    Script Date: 2022/11/17 16:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student Info](
	[Student Number] [int] NOT NULL,
	[Student Name and Surname] [varchar](50) NOT NULL,
	[Student Image] [image] NOT NULL,
	[DoB] [date] NOT NULL,
	[Gender] [tinyint] NOT NULL,
	[Phone] [int] NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[Module Codes] [varchar](5) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[spAddModules]    Script Date: 2022/11/17 16:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAddModules]
(
	@ModuleCode INT,
	@ModuleName varchar(50),
	@ModuleDesc varchar(100),
	@ModuleLinks varchar(100)
)
AS
BEGIN
	INSERT INTO [Module Info]
	VALUES (@ModuleCode, @ModuleName, @ModuleDesc, @ModuleLinks)
END;


GO
/****** Object:  StoredProcedure [dbo].[spAddStudent]    Script Date: 2022/11/17 16:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAddStudent]
(
	@StudentNumber INT,
	@StudentName varchar(100),
	@StudentImage IMAGE,
	@DoB DATE,
	@Gender varchar(5),
	@Phone INT,
	@Address varchar(50),
	@ModuleCodes varchar(50)
)
AS 
BEGIN
INSERT INTO [Student Info]
VALUES (@StudentNumber, @StudentName, @StudentImage, @DoB, @Gender, @Phone, @Address, @ModuleCodes)
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteModule]    Script Date: 2022/11/17 16:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDeleteModule]
(
	@ModuleCode INT
)
AS
BEGIN
DELETE FROM [Module Info]
WHERE [Module Code] = @ModuleCode

END;



GO
/****** Object:  StoredProcedure [dbo].[spDeleteStudent]    Script Date: 2022/11/17 16:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDeleteStudent]
(
	@StudentNumber INT
)
AS 
BEGIN
	DElETE FROM [Student Info]
	WHERE [Student Number]=@StudentNumber
END
GO
/****** Object:  StoredProcedure [dbo].[spGetModules]    Script Date: 2022/11/17 16:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetModules]
AS
SELECT * FROM [Module Info]
GO;
GO
/****** Object:  StoredProcedure [dbo].[spGetStudents]    Script Date: 2022/11/17 16:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetStudents]
AS
SELECT * FROM [Student Info]
GO;
GO
/****** Object:  StoredProcedure [dbo].[spSearchModule]    Script Date: 2022/11/17 16:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSearchModule]
(
	@ModuleCode INT
)
AS
BEGIN
SELECT * FROM [Module Info]
WHERE [Module Code] = @ModuleCode

END;



GO
/****** Object:  StoredProcedure [dbo].[spSearchStudent]    Script Date: 2022/11/17 16:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSearchStudent]
(
	@StudentNumber INT
)
AS 
BEGIN
	SELECT * FROM [Student Info]
	WHERE [Student Number]=@StudentNumber
END
GO
/****** Object:  StoredProcedure [dbo].[spUpdateModule]    Script Date: 2022/11/17 16:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateModule]
(
	@ModuleCode INT,
	@ModuleName varchar(50),
	@ModuleDesc varchar(100),
	@ModuleLinks varchar(100)
)
AS
BEGIN
	UPDATE [Module Info]
	SET [Module Code] = @ModuleCode, [Module Name] = @ModuleName, [Module Description] = @ModuleDesc, [Links to Resources] = @ModuleLinks
	WHERE [Module Code] = @ModuleCode
END;



GO
/****** Object:  StoredProcedure [dbo].[spUpdateStudent]    Script Date: 2022/11/17 16:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateStudent]
(
	@StudentNumber INT,
	@StudentName varchar(100),
	@StudentImage IMAGE,
	@DoB DATE,
	@Gender varchar(5),
	@Phone INT,
	@Address varchar(50),
	@ModuleCodes varchar(50)
)
AS 
BEGIN
UPDATE [Student Info]
SET [Student Number]=@StudentNumber, [Student Name and Surname]=@StudentName, [Student Image]=@StudentImage, DoB=@DoB, Gender=@Gender, Phone=@Phone,Address= @Address, [Module Codes]=@ModuleCodes
WHERE [Student Number]=@StudentNumber
END
GO
USE [master]
GO
ALTER DATABASE [PRG_282_Project_Database] SET  READ_WRITE 
GO
