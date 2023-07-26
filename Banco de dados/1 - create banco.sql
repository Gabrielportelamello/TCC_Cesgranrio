USE [master]
GO

/****** Object:  Database [tailandia]    Script Date: 25/07/2023 20:53:25 ******/
CREATE DATABASE [tailandia] 
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [tailandia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [tailandia] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [tailandia] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [tailandia] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [tailandia] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [tailandia] SET ARITHABORT OFF 
GO

ALTER DATABASE [tailandia] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [tailandia] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [tailandia] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [tailandia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [tailandia] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [tailandia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [tailandia] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [tailandia] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [tailandia] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [tailandia] SET  DISABLE_BROKER 
GO

ALTER DATABASE [tailandia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [tailandia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [tailandia] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [tailandia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [tailandia] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [tailandia] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [tailandia] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [tailandia] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [tailandia] SET  MULTI_USER 
GO

ALTER DATABASE [tailandia] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [tailandia] SET DB_CHAINING OFF 
GO

ALTER DATABASE [tailandia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [tailandia] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [tailandia] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [tailandia] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [tailandia] SET QUERY_STORE = OFF
GO

ALTER DATABASE [tailandia] SET  READ_WRITE 
GO

