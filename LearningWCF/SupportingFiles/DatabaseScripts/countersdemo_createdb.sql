USE [master]
GO
/****** Object:  Database [CountersDemo]    Script Date: 01/28/2007 17:24:44 ******/
CREATE DATABASE [CountersDemo] ON  PRIMARY 
( NAME = N'CountersDemo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\CountersDemo.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CountersDemo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\CountersDemo_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
EXEC dbo.sp_dbcmptlevel @dbname=N'CountersDemo', @new_cmptlevel=90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CountersDemo].[dbo].[sp_fulltext_database] @action = 'disable'
end
GO
ALTER DATABASE [CountersDemo] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [CountersDemo] SET ANSI_NULLS OFF
GO
ALTER DATABASE [CountersDemo] SET ANSI_PADDING OFF
GO
ALTER DATABASE [CountersDemo] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [CountersDemo] SET ARITHABORT OFF
GO
ALTER DATABASE [CountersDemo] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [CountersDemo] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [CountersDemo] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [CountersDemo] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [CountersDemo] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [CountersDemo] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [CountersDemo] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [CountersDemo] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [CountersDemo] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [CountersDemo] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [CountersDemo] SET  ENABLE_BROKER
GO
ALTER DATABASE [CountersDemo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [CountersDemo] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [CountersDemo] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [CountersDemo] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [CountersDemo] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [CountersDemo] SET  READ_WRITE
GO
ALTER DATABASE [CountersDemo] SET RECOVERY FULL
GO
ALTER DATABASE [CountersDemo] SET  MULTI_USER
GO
ALTER DATABASE [CountersDemo] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [CountersDemo] SET DB_CHAINING OFF
GO
USE [CountersDemo]
GO
/****** Object:  Table [dbo].[Counters]    Script Date: 01/28/2007 17:24:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Counters](
	[id] [int] NOT NULL,
	[value] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[procCountersUpdate]    Script Date: 01/28/2007 17:24:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procCountersUpdate] 
	(@id 			[int],
	 @value	[int] )
AS UPDATE [dbo].[procCountersUpdate] 

SET  
	 [value] = @value
WHERE 
	( [id]	 = @id)

GO
/****** Object:  StoredProcedure [dbo].[procCountersSelect]    Script Date: 01/28/2007 17:24:44 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procCountersSelect]
AS SELECT * FROM [dbo].[Counters]
GO

INSERT INTO Counters (id, value) Values (1, 0)
INSERT INTO Counters (id, value) Values (2, 0)
