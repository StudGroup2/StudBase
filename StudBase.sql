USE [master]
GO

/****** Object:  Database [StudBase]    Script Date: 14.06.2017 19:04:46 ******/
CREATE DATABASE [StudBase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StudBase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\StudBase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StudBase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\StudBase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [StudBase] SET COMPATIBILITY_LEVEL = 130
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudBase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [StudBase] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [StudBase] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [StudBase] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [StudBase] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [StudBase] SET ARITHABORT OFF 
GO

ALTER DATABASE [StudBase] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [StudBase] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [StudBase] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [StudBase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [StudBase] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [StudBase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [StudBase] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [StudBase] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [StudBase] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [StudBase] SET  DISABLE_BROKER 
GO

ALTER DATABASE [StudBase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [StudBase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [StudBase] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [StudBase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [StudBase] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [StudBase] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [StudBase] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [StudBase] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [StudBase] SET  MULTI_USER 
GO

ALTER DATABASE [StudBase] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [StudBase] SET DB_CHAINING OFF 
GO

ALTER DATABASE [StudBase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [StudBase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [StudBase] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [StudBase] SET QUERY_STORE = OFF
GO

USE [StudBase]
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO

ALTER DATABASE [StudBase] SET  READ_WRITE 
GO
