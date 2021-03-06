USE [master]
GO
/****** Object:  Database [advance]    Script Date: 4/4/2021 10:03:24 PM ******/
CREATE DATABASE [advance]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'advance', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\advance.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'advance_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\advance_log.ldf' , SIZE = 20416KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [advance] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [advance].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [advance] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [advance] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [advance] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [advance] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [advance] SET ARITHABORT OFF 
GO
ALTER DATABASE [advance] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [advance] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [advance] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [advance] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [advance] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [advance] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [advance] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [advance] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [advance] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [advance] SET  DISABLE_BROKER 
GO
ALTER DATABASE [advance] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [advance] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [advance] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [advance] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [advance] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [advance] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [advance] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [advance] SET RECOVERY FULL 
GO
ALTER DATABASE [advance] SET  MULTI_USER 
GO
ALTER DATABASE [advance] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [advance] SET DB_CHAINING OFF 
GO
ALTER DATABASE [advance] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [advance] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [advance] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'advance', N'ON'
GO
ALTER DATABASE [advance] SET QUERY_STORE = OFF
GO
USE [advance]
GO
/****** Object:  User [tester]    Script Date: 4/4/2021 10:03:24 PM ******/
CREATE USER [tester] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 4/4/2021 10:03:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[custom_id] [int] IDENTITY(1,1) NOT NULL,
	[custom_name] [nvarchar](50) NOT NULL,
	[custom_phone] [nvarchar](15) NULL,
	[gender] [char](1) NOT NULL,
	[status] [nvarchar](10) NULL,
	[end_total] [decimal](18, 0) NULL,
	[credit] [decimal](18, 0) NULL,
	[credit1]  AS ([credit]-[end_total]),
	[start_date] [datetime] NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[custom_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_customer]    Script Date: 4/4/2021 10:03:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_customer]
as
select custom_id,custom_name,end_total from customer
GO
/****** Object:  Table [dbo].[deliveries]    Script Date: 4/4/2021 10:03:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[deliveries](
	[delivery_id] [int] IDENTITY(1,1) NOT NULL,
	[custom_id] [int] NOT NULL,
	[last_account] [decimal](18, 0) NULL,
	[delivered_money] [decimal](18, 0) NULL,
	[after_delivering]  AS ([last_account]-[delivered_money]),
	[notices] [nvarchar](100) NULL,
	[emp_id] [int] NULL,
	[deliver_date] [datetime] NULL,
 CONSTRAINT [PK_deliveries] PRIMARY KEY CLUSTERED 
(
	[delivery_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 4/4/2021 10:03:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[emp_id] [int] IDENTITY(1,1) NOT NULL,
	[emp_name] [nvarchar](50) NOT NULL,
	[emp_password] [nvarchar](50) NULL,
	[emp_status] [nvarchar](15) NULL,
 CONSTRAINT [PK_employee] PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[invoice]    Script Date: 4/4/2021 10:03:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[invoice](
	[invoice_id] [int] IDENTITY(1,1) NOT NULL,
	[custom_id] [int] NOT NULL,
	[products_string] [nvarchar](250) NULL,
	[notices] [nvarchar](250) NULL,
	[emp_id] [int] NULL,
	[buy_date] [datetime] NULL,
	[price] [decimal](18, 0) NULL,
 CONSTRAINT [PK_invoice] PRIMARY KEY CLUSTERED 
(
	[invoice_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[invoice] SET (LOCK_ESCALATION = AUTO)
GO
/****** Object:  Table [dbo].[temptable]    Script Date: 4/4/2021 10:03:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[temptable](
	[invoice_id] [int] IDENTITY(1,1) NOT NULL,
	[custom_id] [int] NOT NULL,
	[products_string] [nvarchar](250) NULL,
	[notices] [nvarchar](250) NULL,
	[emp_id] [int] NULL,
	[buy_date] [datetime] NULL,
	[price] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[temptable1]    Script Date: 4/4/2021 10:03:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[temptable1](
	[delivery_id] [int] IDENTITY(1,1) NOT NULL,
	[custom_id] [int] NOT NULL,
	[last_account] [decimal](18, 0) NULL,
	[delivered_money] [decimal](18, 0) NULL,
	[after_delivering] [decimal](19, 0) NULL,
	[notices] [nvarchar](100) NULL,
	[emp_id] [int] NULL,
	[deliver_date] [datetime] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[customer] ON 

INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1, N'hossam', N'7777', N'm', N'1', CAST(1100 AS Decimal(18, 0)), CAST(20000 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.713' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (3, N'ahmed', NULL, N'm', N'1', CAST(0 AS Decimal(18, 0)), CAST(7200 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.713' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (4, N'hazim', NULL, N'm', N'1', CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.713' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1003, N'ali', NULL, N'm', N'1', CAST(0 AS Decimal(18, 0)), CAST(17000 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.717' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1004, N'fatma', NULL, N'f', N'1', CAST(0 AS Decimal(18, 0)), CAST(50300 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.717' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1005, N'حسام علي حسين اليعري', NULL, N'm', N'1', CAST(5000 AS Decimal(18, 0)), CAST(8900 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.717' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1009, N'صالح محمد', NULL, N'm', N'1', CAST(1200 AS Decimal(18, 0)), CAST(16320 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.720' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1011, N'علي علي اليعري', NULL, N'm', NULL, CAST(300 AS Decimal(18, 0)), NULL, CAST(N'2019-10-06T23:28:29.720' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1012, N'احمد علي احمد اليعري', NULL, N'm', NULL, CAST(28000 AS Decimal(18, 0)), NULL, CAST(N'2019-10-06T23:28:29.720' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1013, N'خالد محمد اليعري', N'772982855', N'm', NULL, CAST(0 AS Decimal(18, 0)), NULL, CAST(N'2019-10-06T23:28:29.720' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1014, N'ghshshgsh', N'f', N'm', NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.723' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1015, N'احمد احمد اليعري', N'7763737823', N'm', NULL, CAST(5000 AS Decimal(18, 0)), NULL, CAST(N'2019-10-06T23:28:29.723' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1016, N'محمد صالح احمد اليعري', N'377373883', N'm', N'1', CAST(0 AS Decimal(18, 0)), CAST(2200 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.723' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1017, N'smir', NULL, N'm', N'1', CAST(0 AS Decimal(18, 0)), CAST(500 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.727' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1018, N'يوسف', N'1', N'm', N'1', CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.727' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1019, N'سمير', NULL, N'm', N'', NULL, NULL, CAST(N'2019-10-06T23:28:29.727' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1020, N'aisha', N'7672838292', N'm', N'1', CAST(0 AS Decimal(18, 0)), CAST(800 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.727' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1021, N'ammar', NULL, N'm', N'1', CAST(0 AS Decimal(18, 0)), NULL, CAST(N'2019-10-06T23:28:29.727' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1022, N'ddd', NULL, N'm', NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.730' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1023, N'ssss', NULL, N'm', NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.730' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1024, N'gggg', NULL, N'f', NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.730' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1025, N'dddd', NULL, N'm', NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.730' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1026, N'ashraf', NULL, N'f', N'1', CAST(0 AS Decimal(18, 0)), CAST(200 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.730' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1027, N'ziad', NULL, N'f', N'0', CAST(2000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.730' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1028, N'www', NULL, N'f', N'0', CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.730' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1029, N'hhhh', NULL, N'f', N'0', CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.730' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1030, N'qqq', N'', N'f', N'0', CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.733' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1031, N'zzzzzz', NULL, N'f', N'0', CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.733' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1032, N'سميرة', NULL, N'j', N'1', CAST(0 AS Decimal(18, 0)), CAST(200 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.733' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1033, N'tmim', NULL, N'm', N'0', CAST(200 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.733' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1034, N'hhgzvaz', NULL, N'm', N'0', CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.733' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1035, N'hhh', NULL, N'f', NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.733' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1036, N'علي محمد صالح', NULL, N'm', N'0', CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.737' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (1037, N'ايوب حمادي', N'6373838823', N'm', N'1', CAST(6000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.737' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (2036, N'علي محمد احمد', NULL, N'm', N'0', CAST(3010 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.737' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (2037, N'خليل يحيى اليعري', N'7788889978', N'm', N'1', CAST(44500 AS Decimal(18, 0)), CAST(950 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.737' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (3037, N'hani', NULL, N'm', N'1', CAST(400 AS Decimal(18, 0)), CAST(4200 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.737' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (3038, N'ali ali', N'773990022', N'm', N'1', CAST(2300 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(N'2019-10-06T23:28:29.737' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (3039, N'صالح علي', NULL, N'm', NULL, CAST(5000 AS Decimal(18, 0)), CAST(4000 AS Decimal(18, 0)), CAST(N'2019-10-06T23:32:34.717' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (3040, N'nadder', NULL, N'm', NULL, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(N'2019-11-11T09:30:25.503' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (4040, N'عبد الرحمن احسن اليعري', N'736368738', N'm', N'0', CAST(3000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(N'2019-11-15T20:21:11.377' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (5040, N'عبد الله نصار', NULL, N'm', N'0', CAST(2000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(N'2019-12-04T10:34:30.440' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (5041, N'يعري اليعري', N'772988755', N'm', N'0', CAST(6000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(N'2021-03-21T21:53:05.223' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (5042, N'arafat', N'773208776', N'm', N'0', CAST(50000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(N'2021-03-29T01:37:01.397' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (5043, N'حميد اليعري', N'773777780', N'm', N'0', CAST(4000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(N'2021-04-04T18:59:24.090' AS DateTime))
INSERT [dbo].[customer] ([custom_id], [custom_name], [custom_phone], [gender], [status], [end_total], [credit], [start_date]) VALUES (5044, N'llllllllllllllll', N'76728286272', N'm', N'0', CAST(2000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(N'2021-04-04T21:56:15.463' AS DateTime))
SET IDENTITY_INSERT [dbo].[customer] OFF
SET IDENTITY_INSERT [dbo].[deliveries] ON 

INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (36, 1005, CAST(10000 AS Decimal(18, 0)), CAST(3000 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-07-26T03:42:51.463' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (37, 1005, CAST(5000 AS Decimal(18, 0)), CAST(2500 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-07-26T03:43:49.453' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (38, 1, CAST(21000 AS Decimal(18, 0)), CAST(20000 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-07-26T04:06:24.357' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (39, 1, CAST(66000 AS Decimal(18, 0)), CAST(1000 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-07-26T04:06:49.757' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (40, 1, CAST(8000 AS Decimal(18, 0)), CAST(8000 AS Decimal(18, 0)), N'6 عدلها الموظف رقم "Jul 26 2019 11:44AM" في  8000* الى15000* تم تعديل القيمة المسلمة من -- تم ادخاره', 6, CAST(N'2019-07-26T04:07:11.293' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (41, 1, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N' تم ادخارها لمالك الحساب  * ريال 5000* = تم تسدسد كامل هذا الحساب و الباقي له *', 6, CAST(N'2019-07-26T04:07:58.117' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (42, 1, CAST(7000 AS Decimal(18, 0)), CAST(7000 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-07-26T04:09:13.873' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (43, 1, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'6 عدلها الموظف رقم "Jul 26 2019 11:51AM" في  0* الى7000* تم تعديل القيمة المسلمة من --6 عدلها الموظف', 6, CAST(N'2019-07-26T11:39:00.043' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (44, 1005, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-07-26T11:53:22.203' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (45, 1004, CAST(-10000 AS Decimal(18, 0)), CAST(-10000 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-07-26T12:04:21.920' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (46, 1003, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-07-26T12:09:14.380' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (49, 1, CAST(1000 AS Decimal(18, 0)), CAST(1500 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-07-26T14:06:51.603' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (50, 1009, CAST(1000 AS Decimal(18, 0)), CAST(1000 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-07-26T14:09:59.167' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (51, 1009, CAST(15980 AS Decimal(18, 0)), CAST(14780 AS Decimal(18, 0)), N' ريال 1020 * ريال إجمالي الباقي المدخر للحساب=16320* = تم تسدسد كامل هذا الحساب و الباقي له * تم ادخ', 6, CAST(N'2019-07-26T14:17:38.157' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (52, 1, CAST(0 AS Decimal(18, 0)), CAST(2000 AS Decimal(18, 0)), N'sjjsdkdssjsjs', 6, CAST(N'2019-07-26T14:18:43.793' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (64, 1005, CAST(500 AS Decimal(18, 0)), CAST(300 AS Decimal(18, 0)), NULL, 0, CAST(N'2019-07-27T13:19:59.830' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (65, 1, CAST(6000 AS Decimal(18, 0)), CAST(7000 AS Decimal(18, 0)), N' تم ادخارها لمالك الحساب  * ريال 1000* = تم تسدسد كامل هذا الحساب و الباقي له *dbhdhdkdbhdhdk', 6, CAST(N'2019-07-27T13:30:42.060' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (66, 1, CAST(350 AS Decimal(18, 0)), CAST(400 AS Decimal(18, 0)), N' تم ادخارها لمالك الحساب  * ريال 50* = تم تسدسد كامل هذا الحساب و الباقي له * تم ادخارها لمالك الحسا', 6, CAST(N'2019-07-27T14:17:12.300' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (68, 1005, CAST(200 AS Decimal(18, 0)), CAST(100 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-07-27T14:27:37.873' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (69, 1005, CAST(0 AS Decimal(18, 0)), CAST(200 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-07-27T14:28:09.530' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (70, 1005, CAST(800 AS Decimal(18, 0)), CAST(900 AS Decimal(18, 0)), N' تم ادخارها لمالك الحساب  * ريال 100* = تم تسدسد كامل هذا الحساب و الباقي له * تم ادخارها لمالك الحس', 6, CAST(N'2019-07-27T14:29:42.063' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (72, 1005, CAST(4500 AS Decimal(18, 0)), CAST(4500 AS Decimal(18, 0)), N' ريال 500 * ريال إجمالي الباقي المدخر للحساب=8900* = تم تسدسد كامل هذا الحساب و الباقي له * تم ادخار', 4, CAST(N'2019-07-28T12:02:07.040' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (73, 3, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N' ريال 700 * ريال إجمالي الباقي المدخر للحساب=7000* = تم تسدسد كامل هذا الحساب و الباقي له * تم ادخار', 6, CAST(N'2019-07-29T01:36:09.720' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (74, 1013, NULL, CAST(0 AS Decimal(18, 0)), N' تم ادخارها لمالك الحساب  * ريال 2000* = تم تسدسد كامل هذا الحساب و الباقي له *', 6, CAST(N'2019-07-29T16:54:36.670' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (75, 1015, CAST(20000 AS Decimal(18, 0)), CAST(15000 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-07-29T20:56:20.607' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (76, 3, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N' تم ادخارها لمالك الحساب  * ريال 200* = تم تسدسد كامل هذا الحساب و الباقي له *', 6, CAST(N'2019-08-01T14:53:28.513' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (77, 1019, NULL, CAST(0 AS Decimal(18, 0)), N' تم ادخارها لمالك الحساب  * ريال 500* = تم تسدسد كامل هذا الحساب و الباقي له *', 6, CAST(N'2019-08-01T14:55:40.597' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (78, 1020, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N' تم ادخارها لمالك الحساب  * ريال 800* = تم تسدسد كامل هذا الحساب و الباقي له *', 6, CAST(N'2019-08-01T15:05:06.063' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (79, 1009, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N' تم ادخارها لمالك الحساب  * ريال 350* = تم تسدسد كامل هذا الحساب و الباقي له *', 6, CAST(N'2019-08-01T15:11:44.510' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (1081, 1015, CAST(5000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N' ريال 100 * ريال إجمالي الباقي المدخر للحساب=100* = تم تسدسد كامل هذا الحساب و الباقي له * تم ادخاره', 6, CAST(N'2019-08-04T01:22:25.953' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (1082, 1015, CAST(5000 AS Decimal(18, 0)), CAST(3000 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-08-04T18:45:54.817' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (1083, 1015, CAST(2000 AS Decimal(18, 0)), CAST(1000 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-08-04T19:28:11.077' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (1084, 2037, CAST(500 AS Decimal(18, 0)), CAST(400 AS Decimal(18, 0)), N'iohojjppjk', 0, CAST(N'2019-08-04T20:16:21.063' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (1085, 2037, CAST(2000 AS Decimal(18, 0)), CAST(1500 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-08-06T21:06:33.190' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (1086, 2037, CAST(100 AS Decimal(18, 0)), CAST(50 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-08-06T21:08:53.310' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (1087, 2037, CAST(50 AS Decimal(18, 0)), CAST(50 AS Decimal(18, 0)), N' تم ادخارها لمالك الحساب  * ريال 950* = تم تسدسد كامل هذا الحساب و الباقي له *', 6, CAST(N'2019-08-06T21:09:24.300' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2085, 2037, CAST(81310 AS Decimal(18, 0)), CAST(300 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-08-09T15:32:06.347' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2086, 1033, CAST(2000 AS Decimal(18, 0)), CAST(600 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-08-09T15:58:14.050' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2087, 1, CAST(3000 AS Decimal(18, 0)), CAST(500 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-08-09T16:07:29.213' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2088, 2037, CAST(81710 AS Decimal(18, 0)), CAST(400 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-08-09T16:08:34.863' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2089, 2037, CAST(81310 AS Decimal(18, 0)), CAST(300 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-08-09T16:09:00.350' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2090, 1026, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N' ريال 200 * ريال إجمالي الباقي المدخر للحساب=200* = تم تسدسد كامل هذا الحساب و الباقي له * تم ادخاره', 6, CAST(N'2019-08-09T16:09:28.773' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2091, 1032, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N' ريال 100 * ريال إجمالي الباقي المدخر للحساب=200* = تم تسدسد كامل هذا الحساب و الباقي له * تم ادخاره', 6, CAST(N'2019-08-09T16:10:26.400' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2092, 1033, CAST(1400 AS Decimal(18, 0)), CAST(1200 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-08-09T16:10:50.160' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2093, 1, CAST(2000 AS Decimal(18, 0)), CAST(300 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-08-09T16:11:11.713' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2094, 1, CAST(2700 AS Decimal(18, 0)), CAST(900 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-08-09T16:14:02.570' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2095, 2037, CAST(81010 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-08-09T16:15:52.280' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2096, 2037, CAST(81000 AS Decimal(18, 0)), CAST(1000 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-08-09T16:16:24.023' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2097, 2037, CAST(80000 AS Decimal(18, 0)), CAST(3000 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-08-09T16:17:06.407' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2098, 2037, CAST(77000 AS Decimal(18, 0)), CAST(2000 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-08-09T16:18:59.770' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2099, 2037, CAST(75000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-08-09T16:19:18.593' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2100, 1, CAST(2700 AS Decimal(18, 0)), CAST(200 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-08-09T16:19:37.700' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2101, 2037, CAST(70000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-08-09T16:22:46.677' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2102, 1016, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N' ريال 200 * ريال إجمالي الباقي المدخر للحساب=2200* = تم تسدسد كامل هذا الحساب و الباقي له * تم ادخار', 6, CAST(N'2019-08-09T16:23:48.367' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2103, 1037, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N' ريال 250000 * ريال إجمالي الباقي المدخر للحساب=252500* = تم تسدسد كامل هذا الحساب و الباقي له * تم ', 6, CAST(N'2019-08-27T16:54:27.773' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2104, 1037, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N' تم ادخارها لمالك الحساب  * ريال 2000* = تم تسدسد كامل هذا الحساب و الباقي له *', 6, CAST(N'2019-08-30T22:34:59.070' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2105, 1037, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N' تم ادخارها لمالك الحساب  * ريال 400* = تم تسدسد كامل هذا الحساب و الباقي له *', 0, CAST(N'2019-08-30T22:45:40.517' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2106, 2036, CAST(303000 AS Decimal(18, 0)), CAST(500 AS Decimal(18, 0)), NULL, 0, CAST(N'2019-08-30T22:49:41.153' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2107, 1037, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N' تم ادخارها لمالك الحساب  * ريال 6000* = تم تسدسد كامل هذا الحساب و الباقي له *', 0, CAST(N'2019-08-30T23:31:46.720' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2108, 1016, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N' ريال 2000 * ريال إجمالي الباقي المدخر للحساب=2000* = تم تسدسد كامل هذا الحساب و الباقي له * تم ادخا', 0, CAST(N'2019-08-30T23:50:57.417' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2109, 3037, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N' تم ادخارها لمالك الحساب  * ريال 3000* = تم تسدسد كامل هذا الحساب و الباقي له *', 6, CAST(N'2019-08-31T01:09:10.597' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2110, 1037, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N' تم ادخارها لمالك الحساب  * ريال 4900* = تم تسدسد كامل هذا الحساب و الباقي له *', 6, CAST(N'2019-08-31T01:09:55.717' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2111, 3037, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N' تم ادخارها لمالك الحساب  * ريال 500* = تم تسدسد كامل هذا الحساب و الباقي له *', 6, CAST(N'2019-08-31T01:10:19.987' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2112, 3037, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N' تم ادخارها لمالك الحساب  * ريال 400* = تم تسدسد كامل هذا الحساب و الباقي له *', 6, CAST(N'2019-08-31T01:16:47.987' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2113, 3037, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N' تم ادخارها لمالك الحساب  * ريال 300* = تم تسدسد كامل هذا الحساب و الباقي له *', 6, CAST(N'2019-08-31T01:17:50.530' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2114, 1016, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-08-31T01:36:21.200' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2115, 1011, CAST(1000 AS Decimal(18, 0)), CAST(700 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-08-31T02:19:51.573' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2116, 2037, CAST(60000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N' تم ادخارها لمالك الحساب  * ريال 800* = تم تسدسد كامل هذا الحساب و الباقي له *', 6, CAST(N'2019-08-31T12:34:34.473' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2117, 2036, CAST(10000 AS Decimal(18, 0)), CAST(6490 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-08-31T23:10:02.733' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2118, 2037, CAST(60000 AS Decimal(18, 0)), CAST(10000 AS Decimal(18, 0)), NULL, 0, CAST(N'2019-08-31T23:46:36.777' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2120, 2037, CAST(50000 AS Decimal(18, 0)), CAST(7000 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-09-01T00:02:58.817' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2121, 1, CAST(1700 AS Decimal(18, 0)), CAST(400 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-09-01T00:29:50.853' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2122, 1, CAST(1300 AS Decimal(18, 0)), CAST(200 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-09-01T00:30:46.400' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2123, 2036, CAST(3510 AS Decimal(18, 0)), CAST(500 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-09-01T00:42:20.463' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2124, 3039, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N' تم ادخارها لمالك الحساب  * ريال 4000* = تم تسدسد كامل هذا الحساب و الباقي له *', 6, CAST(N'2019-10-06T23:32:54.933' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2125, 1015, CAST(3000 AS Decimal(18, 0)), CAST(1000 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-11-15T20:12:39.093' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (2126, 4040, CAST(8000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-11-15T20:23:13.330' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (3125, 1021, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), NULL, 6, CAST(N'2019-12-04T10:35:04.263' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (3126, 1005, CAST(25000 AS Decimal(18, 0)), CAST(20000 AS Decimal(18, 0)), NULL, 6, CAST(N'2020-06-05T14:29:23.400' AS DateTime))
INSERT [dbo].[deliveries] ([delivery_id], [custom_id], [last_account], [delivered_money], [notices], [emp_id], [deliver_date]) VALUES (4126, 5043, CAST(9000 AS Decimal(18, 0)), CAST(5000 AS Decimal(18, 0)), NULL, 6, CAST(N'2021-04-04T19:00:50.710' AS DateTime))
SET IDENTITY_INSERT [dbo].[deliveries] OFF
SET IDENTITY_INSERT [dbo].[employee] ON 

INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_password], [emp_status]) VALUES (4, N'mohmed', N'1231', NULL)
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_password], [emp_status]) VALUES (5, N'حسام', N'1111', NULL)
INSERT [dbo].[employee] ([emp_id], [emp_name], [emp_password], [emp_status]) VALUES (6, N'ali', N'1111', NULL)
SET IDENTITY_INSERT [dbo].[employee] OFF
SET IDENTITY_INSERT [dbo].[invoice] ON 

INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (111, 1005, NULL, NULL, 6, CAST(N'2019-10-06T23:28:29.863' AS DateTime), CAST(10000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (112, 1, NULL, NULL, 6, CAST(N'2019-10-06T23:28:29.870' AS DateTime), CAST(100000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (113, 1, NULL, NULL, 6, CAST(N'2019-10-06T23:28:29.873' AS DateTime), CAST(15000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (114, 1003, NULL, NULL, 6, CAST(N'2019-10-06T23:28:29.873' AS DateTime), CAST(10000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (115, 1009, N'', NULL, 4, CAST(N'2019-10-06T23:28:29.873' AS DateTime), CAST(1400 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (116, 1009, NULL, NULL, 6, CAST(N'2019-10-06T23:28:29.877' AS DateTime), CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (117, 1009, NULL, NULL, 6, CAST(N'2019-10-06T23:28:29.877' AS DateTime), CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (118, 1011, NULL, NULL, 6, CAST(N'2019-10-06T23:28:29.877' AS DateTime), CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (119, 1012, NULL, NULL, 6, CAST(N'2019-10-06T23:28:29.877' AS DateTime), CAST(10000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (120, 1009, NULL, NULL, 6, CAST(N'2019-10-06T23:28:29.880' AS DateTime), CAST(10000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (121, 1009, NULL, NULL, 6, CAST(N'2019-10-06T23:28:29.880' AS DateTime), CAST(20000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (122, 1, N'gsgshhsg', NULL, 6, CAST(N'2019-10-06T23:28:29.880' AS DateTime), CAST(5000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (123, 1023, N'بيض+حليب', N'بيض+حليب', 6, CAST(N'2019-10-06T23:28:29.880' AS DateTime), CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (125, 1005, N'222ؤىىىىؤرىنؤ', NULL, 6, CAST(N'2019-10-06T23:28:29.883' AS DateTime), CAST(500 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (126, 1, N'shnknksnms', NULL, 4, CAST(N'2019-10-06T23:28:29.883' AS DateTime), CAST(350 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (127, 1005, N'للغعهالبففبغعاع', N'الللالفلعهخخخغفففغههخ', 4, CAST(N'2019-10-06T23:28:29.883' AS DateTime), CAST(4000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (128, 1015, N'ojohjoi', NULL, 6, CAST(N'2019-10-06T23:28:29.883' AS DateTime), CAST(2000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (1133, 2037, N'اكخاهكاختهخلع', NULL, 6, CAST(N'2019-10-06T23:28:29.883' AS DateTime), CAST(2000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2132, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.887' AS DateTime), CAST(400 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2133, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.887' AS DateTime), CAST(300 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2134, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.887' AS DateTime), CAST(4390 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2135, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.887' AS DateTime), CAST(3400 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2136, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.887' AS DateTime), CAST(388 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2137, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.890' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2138, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.890' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2139, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.890' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2140, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.890' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2141, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.890' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2142, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.890' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2143, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.890' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2144, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.890' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2145, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.890' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2146, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.890' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2147, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.893' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2148, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.893' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2149, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.893' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2150, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.893' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2151, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.893' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2152, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.893' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2153, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.897' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2154, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.897' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2155, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.897' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2156, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.900' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2157, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.900' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2158, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.900' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2159, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.900' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2160, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.903' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2161, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.903' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2162, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.903' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2163, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.903' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2164, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.903' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2165, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.903' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2166, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.907' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2167, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.907' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2168, 1, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.907' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2169, 1, N'bnninin', NULL, 6, CAST(N'2019-10-06T23:28:29.907' AS DateTime), CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2170, 1, N'ttttttttt', NULL, 6, CAST(N'2019-10-06T23:28:29.907' AS DateTime), CAST(2600 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2171, 2037, N'rrrrrrrrrrrr', NULL, NULL, CAST(N'2019-10-06T23:28:29.907' AS DateTime), CAST(4000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2172, 2037, N'300', NULL, 6, CAST(N'2019-10-06T23:28:29.910' AS DateTime), CAST(400 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2173, 2037, N'dddddddd', NULL, 6, CAST(N'2019-10-06T23:28:29.910' AS DateTime), CAST(4900 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2174, 2037, N'rrrrrrrrrrrrrrrrr', NULL, 6, CAST(N'2019-10-06T23:28:29.910' AS DateTime), CAST(30 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2176, 2037, N'hhhh', N'yhhjjj', 6, CAST(N'2019-10-06T23:28:29.910' AS DateTime), CAST(80 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2177, 2037, NULL, NULL, 6, CAST(N'2019-10-06T23:28:29.910' AS DateTime), CAST(5000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2178, 1037, NULL, NULL, 6, CAST(N'2019-10-06T23:28:29.910' AS DateTime), CAST(6000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2179, 2037, NULL, NULL, 6, CAST(N'2019-10-06T23:28:29.913' AS DateTime), CAST(20000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2180, 2037, NULL, NULL, 6, CAST(N'2019-10-06T23:28:29.913' AS DateTime), CAST(40000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2181, 2037, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.920' AS DateTime), CAST(700 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2182, 2037, NULL, NULL, NULL, CAST(N'2019-10-06T23:28:29.920' AS DateTime), NULL)
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2183, 2037, N'rrrrrrrrrrr', NULL, 6, CAST(N'2019-10-06T23:28:29.920' AS DateTime), CAST(500 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2184, 2036, NULL, NULL, 6, CAST(N'2019-10-06T23:28:29.923' AS DateTime), CAST(2000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2185, 2036, NULL, NULL, 6, CAST(N'2019-10-06T23:28:29.923' AS DateTime), CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2186, 2037, NULL, NULL, 6, CAST(N'2019-10-06T23:28:29.923' AS DateTime), CAST(200 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2187, 2037, NULL, NULL, 6, CAST(N'2019-10-06T23:28:29.923' AS DateTime), CAST(300 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2188, 3037, NULL, NULL, 6, CAST(N'2019-10-06T23:28:29.923' AS DateTime), CAST(400 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2189, 3038, NULL, NULL, 6, CAST(N'2019-10-06T23:28:29.923' AS DateTime), CAST(300 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2190, 2037, NULL, NULL, 6, CAST(N'2019-10-06T23:28:29.923' AS DateTime), CAST(490 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2191, 3039, N'يباعيين', NULL, 5, CAST(N'2019-10-06T23:36:17.623' AS DateTime), CAST(5000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2192, 1015, N'hfjkkgdugdui', N'djshkjfhh', 6, CAST(N'2019-11-15T20:14:50.540' AS DateTime), CAST(3000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (2193, 4040, NULL, NULL, 6, CAST(N'2019-11-15T20:21:39.780' AS DateTime), CAST(8000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (3192, 2037, NULL, NULL, 6, CAST(N'2020-06-03T14:58:01.550' AS DateTime), NULL)
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (3193, 2037, NULL, NULL, 6, CAST(N'2020-06-03T14:58:01.573' AS DateTime), CAST(1010 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (3194, 1005, NULL, NULL, 6, CAST(N'2020-06-05T14:27:48.830' AS DateTime), NULL)
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (3195, 1005, NULL, NULL, 6, CAST(N'2020-06-05T14:27:48.853' AS DateTime), CAST(10000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (3196, 1005, NULL, NULL, 6, CAST(N'2020-06-05T14:28:25.687' AS DateTime), NULL)
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (3197, 1005, NULL, NULL, 6, CAST(N'2020-06-05T14:28:25.690' AS DateTime), CAST(15000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (4194, 5041, N'نقداااا', N'لالالا', 6, CAST(N'2021-03-21T21:56:52.147' AS DateTime), CAST(6000 AS Decimal(18, 0)))
INSERT [dbo].[invoice] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (4195, 5043, N'اااااا', N'السلاسل', 6, CAST(N'2021-04-04T18:59:56.040' AS DateTime), CAST(4000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[invoice] OFF
SET IDENTITY_INSERT [dbo].[temptable] ON 

INSERT [dbo].[temptable] ([invoice_id], [custom_id], [products_string], [notices], [emp_id], [buy_date], [price]) VALUES (4195, 5043, N'اااااا', N'السلاسل', 6, CAST(N'2021-04-04T18:59:56.040' AS DateTime), CAST(4000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[temptable] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [u_cus]    Script Date: 4/4/2021 10:03:24 PM ******/
ALTER TABLE [dbo].[customer] ADD  CONSTRAINT [u_cus] UNIQUE NONCLUSTERED 
(
	[custom_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[customer] ADD  CONSTRAINT [endtotal_default]  DEFAULT ((0)) FOR [end_total]
GO
ALTER TABLE [dbo].[customer] ADD  CONSTRAINT [credit_default]  DEFAULT ((0)) FOR [credit]
GO
ALTER TABLE [dbo].[deliveries] ADD  CONSTRAINT [default_last_account]  DEFAULT ((0)) FOR [last_account]
GO
ALTER TABLE [dbo].[deliveries] ADD  DEFAULT ((0)) FOR [delivered_money]
GO
ALTER TABLE [dbo].[invoice] ADD  CONSTRAINT [def]  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[invoice]  WITH CHECK ADD  CONSTRAINT [FK_invo_emp] FOREIGN KEY([emp_id])
REFERENCES [dbo].[employee] ([emp_id])
GO
ALTER TABLE [dbo].[invoice] CHECK CONSTRAINT [FK_invo_emp]
GO
ALTER TABLE [dbo].[invoice]  WITH CHECK ADD  CONSTRAINT [FK_invoice_customer] FOREIGN KEY([custom_id])
REFERENCES [dbo].[customer] ([custom_id])
GO
ALTER TABLE [dbo].[invoice] CHECK CONSTRAINT [FK_invoice_customer]
GO
ALTER TABLE [dbo].[invoice]  WITH CHECK ADD  CONSTRAINT [FK_invoice_emp] FOREIGN KEY([emp_id])
REFERENCES [dbo].[employee] ([emp_id])
GO
ALTER TABLE [dbo].[invoice] CHECK CONSTRAINT [FK_invoice_emp]
GO
/****** Object:  StoredProcedure [dbo].[deliv_find_previd]    Script Date: 4/4/2021 10:03:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[deliv_find_previd] (@custom_id int,@top int=10,@part int=1,@count int output)
as
begin 
  declare @c int ,@prev_id int=0,@i int=1,@part1 int
  
		  if exists(select * from sys.tables where name='temptable1')
         drop table temptable1

 	   select  top ((@top*(@part-1))+1)  * into temptable1  from deliveries where custom_id=@custom_id order by delivery_id desc

	   if exists(select * from temptable1)
		 select @count=count(delivery_id) FROM temptable1 where custom_id=@custom_id

	 select @c=count(delivery_id) FROM deliveries where custom_id=@custom_id
	 if(@c%@top>0)
      set @part1=(@c/@top)+1
	else if(@c%@top=0)
	  set @part1=(@c/@top)
return @part1
end

GO
/****** Object:  StoredProcedure [dbo].[DeliveriesDeleteProcedur]    Script Date: 4/4/2021 10:03:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
    create proc [dbo].[DeliveriesDeleteProcedur](@delivery_id int)
  as 
  begin

  if exists(select delivery_id from deliveries where delivery_id=@delivery_id)
  begin
  delete from deliveries where delivery_id=@delivery_id

  return @delivery_id
  end
  else
  return 0
  end
GO
/****** Object:  StoredProcedure [dbo].[DeliveriesInsertProcedure]    Script Date: 4/4/2021 10:03:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DeliveriesInsertProcedure] @custom_name nvarchar(50),
@delivered_money decimal=0,@notices nvarchar(100)='',@emp_name nvarchar(50)=null
AS
	SET NOCOUNT ON;
		declare @custom_id int,@emp_id int=0,@end_total decimal=0,@credit decimal=0
	if(@emp_name is not null)
	begin
	select @emp_id=emp_id from employee where emp_name=@emp_name
	end

if(@custom_name is not null and @delivered_money>=0)
begin
	select @custom_id=custom_id,@end_total=end_total from customer where custom_name=@custom_name

	  if((@delivered_money <= @end_total))
	begin
		  insert into deliveries(custom_id,last_account,delivered_money,notices,emp_id,deliver_date)
		  	  values (@custom_id,@end_total,@delivered_money,@notices,@emp_id,getdate())

	   update customer set end_total=(@end_total-@delivered_money) where custom_id=@custom_id
	end

  else if((@delivered_money > @end_total))
	begin
		set @credit=(@delivered_money - @end_total)
		set @delivered_money=@end_total
		set @notices=' تم ادخارها لمالك الحساب '+' * ريال '+cast(@credit as nvarchar(50))+'* = تم تسدسد كامل هذا الحساب و الباقي له *'
	 
	  insert into deliveries(custom_id,last_account,delivered_money,notices,emp_id,deliver_date)
		  	  values (@custom_id,@end_total,@delivered_money,@notices,@emp_id,getdate())

		update customer set end_total=(@end_total-@delivered_money),status='1',credit=credit+@credit where custom_id=@custom_id
	end 
	 return 1
end
	else
	return 0

GO
/****** Object:  StoredProcedure [dbo].[DeliveriesSelectProcedure]    Script Date: 4/4/2021 10:03:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeliveriesSelectProcedure]
AS
	SET NOCOUNT ON;
SELECT        deliveries.delivery_id, customer.custom_name, 
 deliveries.last_account as'last_account',
 deliveries.delivered_money,deliveries.after_delivering, 
 deliveries.notices, deliveries.deliver_date, employee.emp_name
FROM            customer INNER JOIN
                         deliveries ON customer.custom_id = deliveries.custom_id left outer JOIN
                         employee ON deliveries.emp_id = employee.emp_id 
						 order by deliveries.delivery_id desc

GO
/****** Object:  StoredProcedure [dbo].[DeliveriesUpdateProcedure]    Script Date: 4/4/2021 10:03:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeliveriesUpdateProcedure] @delivery_id int,
 @custom_name nvarchar(50),@delivered_money decimal,@notices nvarchar(100)=''
AS
	SET NOCOUNT ON;
		declare @custom_id int,@emp_id int=0,@end_total decimal,@after_delivering decimal

if( @custom_name is not null and @delivered_money>=0)
	begin
	select @custom_id=custom_id,@end_total=end_total from customer where custom_name=@custom_name

	 update deliveries set custom_id=@custom_id,delivered_money=@delivered_money,notices=@notices
	 where delivery_id=@delivery_id


	 return 1
end
else
	return 0

GO
/****** Object:  StoredProcedure [dbo].[find_previd]    Script Date: 4/4/2021 10:03:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[find_previd] (@custom_id int,@top int=10,@part int=1,@count int output)
as
begin 
  declare @c int ,@prev_id int=0,@i int=1,@part1 int
  
		  if exists(select * from sys.tables where name='temptable')
         drop table temptable
 	   select  top ((@top*(@part-1))+1)  * into temptable from invoice where custom_id=@custom_id order by invoice_id desc

	   if exists(select * from temptable)
		 select @count=count(invoice_id) FROM temptable where custom_id=@custom_id

	 select @c=count(invoice_id) FROM invoice where custom_id=@custom_id
	 if(@c%@top>0)
      set @part1=(@c/@top)+1
	else if(@c%@top=0)
	  set @part1=(@c/@top)
return @part1
end
GO
/****** Object:  StoredProcedure [dbo].[IndivisualDeliver]    Script Date: 4/4/2021 10:03:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



 CREATE proc [dbo].[IndivisualDeliver](@custom_name nvarchar(50)=null,@top int=10,@part int=1)
  as 
    declare @custom_id int,@count int=0,@prev_id int=0,@i int=1,@c int,@part1 int

	if exists(select * from sys.tables where name='temptable1')
            drop table temptable1

 if(@custom_name is not null  and @part<>0)
  begin
     select @custom_id=custom_id  from customer where custom_name=@custom_name

	 	 EXEC	@part1 =deliv_find_previd @custom_id,@top,@part,@count = @count OUTPUT

    if(@part=1)
     select top 1 @prev_id=(delivery_id+1)  FROM deliveries where custom_id=@custom_id order by delivery_id desc

	else if(@part > 1  and @part<=@part1)
	 begin
	 	       while (@i <= @count) 
        begin 
          select top (1) @prev_id=(delivery_id+1)  FROM temptable1 where custom_id=@custom_id  order by delivery_id desc
		  delete from temptable1 where delivery_id=@prev_id-1
           set @i = (@i+1)
        end

	 end

SELECT  top (@top)   deliveries.delivery_id, customer.custom_name, 
 deliveries.last_account as'last_account',
 deliveries.delivered_money,deliveries.after_delivering, 
 deliveries.notices, deliveries.deliver_date, employee.emp_name
FROM            customer INNER JOIN
                         deliveries ON customer.custom_id = deliveries.custom_id left outer JOIN
                         employee ON deliveries.emp_id = employee.emp_id 
						 where customer.custom_name=@custom_name
						 and deliveries.delivery_id < @prev_id
						 order by deliveries.delivery_id desc
						 return 1
   end

GO
/****** Object:  StoredProcedure [dbo].[invo_indiv_select_top]    Script Date: 4/4/2021 10:03:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


 CREATE proc [dbo].[invo_indiv_select_top](@custom_name nvarchar(50)=null,@top int=10,@part int=1)
  as 
    declare @custom_id int,@count int=0,@prev_id int=0,@i int=1,@c int,@part1 int

	if exists(select * from sys.tables where name='temptable')
            drop table temptable

 if(@custom_name is not null  and @part<>0)
  begin
     select @custom_id=custom_id  from customer where custom_name=@custom_name

	 	 EXEC	@part1 =find_previd @custom_id,@top,@part,@count = @count OUTPUT

    if(@part=1)
     select top 1 @prev_id=(invoice_id+1)  FROM invoice where custom_id=@custom_id order by invoice_id desc

	else if(@part > 1  and @part<=@part1)
	 begin
	 	       while (@i <= @count) 
        begin 
          select top (1) @prev_id=(invoice_id+1)  FROM temptable where custom_id=@custom_id  order by invoice_id desc
		  delete from temptable where invoice_id=@prev_id-1
           set @i = (@i+1)
        end

	 end

    SELECT  top (@top) invoice.invoice_id, invoice.price, customer.custom_name, invoice.products_string, invoice.buy_date, invoice.notices, employee.emp_name
    FROM            customer INNER JOIN
                         invoice ON customer.custom_id = invoice.custom_id left outer JOIN
                         employee ON invoice.emp_id = employee.emp_id 
						 where  custom_name=@custom_name and
						 invoice.invoice_id < @prev_id
						 order by invoice.invoice_id desc
   end






GO
/****** Object:  StoredProcedure [dbo].[InvoIndivSelectProc]    Script Date: 4/4/2021 10:03:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[InvoIndivSelectProc](@custom_name nvarchar(50))
  as 
SELECT        invoice.invoice_id, invoice.price, customer.custom_name, invoice.products_string, invoice.buy_date, invoice.notices, employee.emp_name
FROM            customer INNER JOIN
                         invoice ON customer.custom_id = invoice.custom_id left outer JOIN
                         employee ON invoice.emp_id = employee.emp_id 
						 where custom_name=@custom_name order by invoice_id desc
GO
/****** Object:  StoredProcedure [dbo].[proc_delete_invoice]    Script Date: 4/4/2021 10:03:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
    create proc [dbo].[proc_delete_invoice](@invoice_id int)
  as 
  begin

  if exists(select invoice_id from invoice where invoice_id=@invoice_id)
  begin
  delete from invoice where invoice_id=@invoice_id

  return @invoice_id
  end
  else
  return 0
  end
GO
/****** Object:  StoredProcedure [dbo].[proc_insert_invoice]    Script Date: 4/4/2021 10:03:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------procedure buyinsert for insert invoice---------------------------------------------------------------------
/*------(اضافة فاتورة قرض بإسم العميل (وشرط ان لا يكون السعر قيمة سالبة ---------
 ----------الى جدول الفواتير واضافة السعر الى العميل الخاص بالقرض-----------------*/
 --بروسيجر الاضافة لايحتاج الى ترايقر ليحوسب الفاتورة المضافة اى حساب العمي بل يقم بذلك بنفسة
  CREATE procedure [dbo].[proc_insert_invoice](@custom_name nvarchar(50),@price decimal=0,
  @products_string nvarchar(250)=null,@notices nvarchar(250)=null,@emp_name nvarchar(50)=null)
  as 
  begin

  if exists(select custom_id from customer where custom_name=@custom_name) 
  begin
       declare @custom_id int,@emp_id int
  select @custom_id=custom_id from customer where custom_name=@custom_name

  if(@emp_name is not null)
   begin
   	 select @emp_id=emp_id from employee where emp_name=@emp_name
   end

	  insert into invoice(custom_id,products_string,price,notices,emp_id) 
	  values(@custom_id,@products_string,@price,@notices,@emp_id)
	  if @price>=0
	  begin
	  update customer set end_total=end_total+@price 
	  where custom_id=@custom_id
	  end
  return 1
  end
  else
  return 0
  end
GO
/****** Object:  StoredProcedure [dbo].[proc_select_invoice]    Script Date: 4/4/2021 10:03:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE proc [dbo].[proc_select_invoice]
  as 
SELECT        invoice.invoice_id, invoice.price, customer.custom_name, invoice.products_string, invoice.buy_date, invoice.notices, employee.emp_name
FROM            customer INNER JOIN
                         invoice ON customer.custom_id = invoice.custom_id left outer JOIN
                         employee ON invoice.emp_id = employee.emp_id 
						 where invoice.buy_date<=10
						 order by invoice_id desc

GO
/****** Object:  StoredProcedure [dbo].[proc_update_invoice]    Script Date: 4/4/2021 10:03:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE procedure [dbo].[proc_update_invoice](@invoice_id int,@custom_name nvarchar(50)=null,@price decimal=.0,
  @products_string nvarchar(250)=null,@notices nvarchar(250)=null,@emp_name nvarchar(50)=null)
  as 
  begin

  if exists(select invoice_id from invoice where invoice_id=@invoice_id)
  begin
    declare @custom_id int,@emp_id int=0,@end_total decimal

   if @emp_name is not null
   begin
   select @emp_id=emp_id from employee where emp_name=@emp_name
	  end

	 select @custom_id=custom_id,@end_total=end_total from customer where custom_name=@custom_name
 if @custom_id >0
   begin
   	  update invoice set custom_id=@custom_id,products_string=@products_string,price=@price,notices=@notices,emp_id=@emp_id
	  where invoice_id=@invoice_id
  return 1
   end
   else
  return 0
  end
  else
  return 0
  end
GO
/****** Object:  StoredProcedure [dbo].[restore_database]    Script Date: 4/4/2021 10:03:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


  CREATE procedure [dbo].[restore_database](@file_name nvarchar(250))
  as 
  begin
ALTER DATABASE [advance] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
BACKUP LOG [advance] TO  DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\Backup\advance_LogBackup_2021-04-04_21-49-27.bak' WITH NOFORMAT, NOINIT,  NAME = N'advance_LogBackup_2021-04-04_21-49-27', NOSKIP, NOREWIND, NOUNLOAD,  NORECOVERY ,  STATS = 5
RESTORE DATABASE [advance] FROM  DISK =@file_name WITH  FILE = 1,  NOUNLOAD,  STATS = 5
ALTER DATABASE [advance] SET MULTI_USER
  end
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'الإجمالي' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'customer', @level2type=N'COLUMN',@level2name=N'end_total'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'قاعدة بيانات فواتير اجلة(قرض/سلف) لمحلات الحسين التجارية' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'customer'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'المسلمات' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'deliveries'
GO
USE [master]
GO
ALTER DATABASE [advance] SET  READ_WRITE 
GO
