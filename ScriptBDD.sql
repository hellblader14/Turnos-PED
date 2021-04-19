USE [master]
GO

/****** Object:  Database [Gestor_Turnos]    Script Date: 4/17/2021 5:11:25 PM ******/
CREATE DATABASE [Gestor_Turnos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Gestor_Turnos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Gestor_Turnos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Gestor_Turnos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Gestor_Turnos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Gestor_Turnos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Gestor_Turnos] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Gestor_Turnos] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Gestor_Turnos] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Gestor_Turnos] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Gestor_Turnos] SET ARITHABORT OFF 
GO

ALTER DATABASE [Gestor_Turnos] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Gestor_Turnos] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Gestor_Turnos] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Gestor_Turnos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Gestor_Turnos] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Gestor_Turnos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Gestor_Turnos] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Gestor_Turnos] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Gestor_Turnos] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Gestor_Turnos] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Gestor_Turnos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Gestor_Turnos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Gestor_Turnos] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Gestor_Turnos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Gestor_Turnos] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Gestor_Turnos] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Gestor_Turnos] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Gestor_Turnos] SET RECOVERY FULL 
GO

ALTER DATABASE [Gestor_Turnos] SET  MULTI_USER 
GO

ALTER DATABASE [Gestor_Turnos] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Gestor_Turnos] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Gestor_Turnos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Gestor_Turnos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Gestor_Turnos] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Gestor_Turnos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [Gestor_Turnos] SET QUERY_STORE = OFF
GO

ALTER DATABASE [Gestor_Turnos] SET  READ_WRITE 
GO

USE [Gestor_Turnos]
GO

/****** Object:  Table [dbo].[transacciones]    Script Date: 4/17/2021 5:13:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[transacciones](
	[id] [nchar](10) NOT NULL,
	[transaccion] [varchar](50) NULL,
	[prioridad] [int] NULL,
	[fecha] [datetime] NULL,
	[idcliente] [nchar](10) NULL,
	[tipo_cliente] [varchar](15) NULL,
	[estado] [bit] NULL,
	[userid] [nchar](15) NULL,
 CONSTRAINT [PK_transacciones] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[transacciones]  WITH CHECK ADD  CONSTRAINT [FK_transacciones_clientes] FOREIGN KEY([idcliente])
REFERENCES [dbo].[clientes] ([idcliente])
GO

ALTER TABLE [dbo].[transacciones] CHECK CONSTRAINT [FK_transacciones_clientes]
GO

ALTER TABLE [dbo].[transacciones]  WITH CHECK ADD  CONSTRAINT [FK_transacciones_usuarios] FOREIGN KEY([userid])
REFERENCES [dbo].[usuarios] ([userid])
GO

ALTER TABLE [dbo].[transacciones] CHECK CONSTRAINT [FK_transacciones_usuarios]
GO

USE [Gestor_Turnos]
GO

/****** Object:  Table [dbo].[usuarios]    Script Date: 4/17/2021 5:13:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[usuarios](
	[userid] [nchar](15) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[tipo_usuario] [nchar](10) NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [Gestor_Turnos]
GO

/****** Object:  Table [dbo].[clientes]    Script Date: 4/17/2021 5:12:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[clientes](
	[idcliente] [nchar](10) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[tipo_cliente] [varchar](15) NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[idcliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

