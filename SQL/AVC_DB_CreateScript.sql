USE [master]
GO
/****** Object:  Database [AVC_DB]    Script Date: 10/03/2022 06:13:35 p. m. ******/
CREATE DATABASE [AVC_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AVC_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AVC_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AVC_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AVC_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [AVC_DB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AVC_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AVC_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AVC_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AVC_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AVC_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AVC_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [AVC_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AVC_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AVC_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AVC_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AVC_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AVC_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AVC_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AVC_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AVC_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AVC_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AVC_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AVC_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AVC_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AVC_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AVC_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AVC_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AVC_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AVC_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [AVC_DB] SET  MULTI_USER 
GO
ALTER DATABASE [AVC_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AVC_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AVC_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AVC_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AVC_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AVC_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'AVC_DB', N'ON'
GO
ALTER DATABASE [AVC_DB] SET QUERY_STORE = OFF
GO
USE [AVC_DB]
GO
/****** Object:  Table [dbo].[Order_Products]    Script Date: 10/03/2022 06:13:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_Products](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Product] [nvarchar](50) NOT NULL,
	[ID_Order] [nvarchar](50) NOT NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_Order_Products] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 10/03/2022 06:13:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[ID] [nvarchar](50) NOT NULL,
	[ID_Seller] [nvarchar](50) NOT NULL,
	[ID_Client] [nvarchar](50) NOT NULL,
	[ID_Deliverer] [nvarchar](50) NOT NULL,
	[Total_Items] [int] NULL,
	[Total_Price] [decimal](5, 2) NULL,
	[Delivery_Instructions] [nvarchar](100) NULL,
	[Date_Ordered] [datetime] NULL,
	[Date_Delivered] [datetime] NULL,
	[Status_Delivery] [bit] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 10/03/2022 06:13:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Producer] [nvarchar](50) NOT NULL,
	[Price] [decimal](5, 2) NULL,
	[Stock] [int] NULL,
	[Available] [bit] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/03/2022 06:13:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Phone] [bigint] NOT NULL,
	[Profile] [int] NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Order_Products] ADD  CONSTRAINT [DF_Order_Products_Quantity]  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF_Orders_Total_Items]  DEFAULT ((0)) FOR [Total_Items]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF_Orders_Total_Price]  DEFAULT ((0)) FOR [Total_Price]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF_Orders_Status_Delivery]  DEFAULT ((0)) FOR [Status_Delivery]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_Price]  DEFAULT ((0)) FOR [Price]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_Stock]  DEFAULT ((0)) FOR [Stock]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_Available]  DEFAULT ((0)) FOR [Available]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_Profile]  DEFAULT ((5)) FOR [Profile]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Order_Products]  WITH CHECK ADD FOREIGN KEY([ID_Order])
REFERENCES [dbo].[Products] ([ID])
GO
ALTER TABLE [dbo].[Order_Products]  WITH CHECK ADD FOREIGN KEY([ID_Product])
REFERENCES [dbo].[Products] ([ID])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([ID_Client])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([ID_Deliverer])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([ID_Seller])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([ID_Seller])
REFERENCES [dbo].[Users] ([ID])
GO
USE [master]
GO
ALTER DATABASE [AVC_DB] SET  READ_WRITE 
GO
