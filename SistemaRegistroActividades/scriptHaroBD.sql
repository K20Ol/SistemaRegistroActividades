USE [master]
GO
/****** Object:  Database [BDActividadesCulturales]    Script Date: 10/01/2025 12:15:25 ******/
CREATE DATABASE [BDActividadesCulturales]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDActividadesCulturales', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\BDActividadesCulturales.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BDActividadesCulturales_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\BDActividadesCulturales_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [BDActividadesCulturales] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDActividadesCulturales].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDActividadesCulturales] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDActividadesCulturales] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDActividadesCulturales] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDActividadesCulturales] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDActividadesCulturales] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDActividadesCulturales] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BDActividadesCulturales] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDActividadesCulturales] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDActividadesCulturales] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDActividadesCulturales] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDActividadesCulturales] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDActividadesCulturales] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDActividadesCulturales] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDActividadesCulturales] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDActividadesCulturales] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BDActividadesCulturales] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDActividadesCulturales] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDActividadesCulturales] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDActividadesCulturales] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDActividadesCulturales] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDActividadesCulturales] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDActividadesCulturales] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDActividadesCulturales] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BDActividadesCulturales] SET  MULTI_USER 
GO
ALTER DATABASE [BDActividadesCulturales] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDActividadesCulturales] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDActividadesCulturales] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDActividadesCulturales] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BDActividadesCulturales] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BDActividadesCulturales] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BDActividadesCulturales] SET QUERY_STORE = ON
GO
ALTER DATABASE [BDActividadesCulturales] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [BDActividadesCulturales]
GO
/****** Object:  Table [dbo].[Actividades]    Script Date: 10/01/2025 12:15:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actividades](
	[ID_Actividad] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Lugar] [nvarchar](200) NULL,
	[Descripcion] [nvarchar](max) NULL,
	[ID_Organizador] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Actividad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Organizadores]    Script Date: 10/01/2025 12:15:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Organizadores](
	[ID_Organizador] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Institucion] [nvarchar](100) NULL,
	[Correo] [nvarchar](100) NULL,
	[Telefono] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Organizador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Participantes]    Script Date: 10/01/2025 12:15:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Participantes](
	[ID_Participante] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Correo] [nvarchar](100) NULL,
	[Telefono] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Participante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Participantes_Actividades]    Script Date: 10/01/2025 12:15:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Participantes_Actividades](
	[ID_Actividad] [int] NOT NULL,
	[ID_Participante] [int] NOT NULL,
	[Fecha_Inscripcion] [date] NOT NULL,
	[Rol] [nvarchar](50) NOT NULL,
	[Asistencia] [bit] NULL,
	[Observaciones] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Actividad] ASC,
	[ID_Participante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Participantes_Actividades] ADD  DEFAULT ((0)) FOR [Asistencia]
GO
ALTER TABLE [dbo].[Actividades]  WITH CHECK ADD FOREIGN KEY([ID_Organizador])
REFERENCES [dbo].[Organizadores] ([ID_Organizador])
GO
ALTER TABLE [dbo].[Participantes_Actividades]  WITH CHECK ADD FOREIGN KEY([ID_Actividad])
REFERENCES [dbo].[Actividades] ([ID_Actividad])
GO
ALTER TABLE [dbo].[Participantes_Actividades]  WITH CHECK ADD FOREIGN KEY([ID_Participante])
REFERENCES [dbo].[Participantes] ([ID_Participante])
GO
USE [master]
GO
ALTER DATABASE [BDActividadesCulturales] SET  READ_WRITE 
GO
