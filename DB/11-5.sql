USE [master]
GO
/****** Object:  Database [Storehouse]    Script Date: 2018-11-05 23:19:02 ******/
CREATE DATABASE [Storehouse] ON  PRIMARY 
( NAME = N'Storehouse', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Storehouse.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Storehouse_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Storehouse_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Storehouse].[dbo].[sp_fulltext_database] @action = 'disable'
end
GO
ALTER DATABASE [Storehouse] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Storehouse] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Storehouse] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Storehouse] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Storehouse] SET ARITHABORT OFF 
GO
ALTER DATABASE [Storehouse] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Storehouse] SET AUTO_SHRINK ON 
GO
ALTER DATABASE [Storehouse] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Storehouse] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Storehouse] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Storehouse] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Storehouse] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Storehouse] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Storehouse] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Storehouse] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Storehouse] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Storehouse] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Storehouse] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Storehouse] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Storehouse] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Storehouse] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Storehouse] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Storehouse] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Storehouse] SET  MULTI_USER 
GO
ALTER DATABASE [Storehouse] SET PAGE_VERIFY TORN_PAGE_DETECTION  
GO
ALTER DATABASE [Storehouse] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Storehouse', N'ON'
GO
USE [Storehouse]
GO
/****** Object:  Table [dbo].[BasicData]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BasicData](
	[UnitID] [int] IDENTITY(1,1) NOT NULL,
	[UnitName] [nvarchar](50) NOT NULL,
	[flag] [int] NOT NULL,
 CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED 
(
	[UnitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[BillGuid] [nvarchar](50) NOT NULL,
	[BillAutoID] [nvarchar](50) NOT NULL,
	[BillDate] [datetime] NULL,
	[DepotGuid] [nvarchar](200) NOT NULL,
	[StorageTypeGuid] [nvarchar](200) NOT NULL,
	[SupplierGuid] [nvarchar](200) NOT NULL,
	[DeptGuid] [nvarchar](50) NOT NULL,
	[Bearing] [nvarchar](20) NOT NULL,
	[BillID] [nvarchar](50) NOT NULL,
	[BatchNo] [nvarchar](50) NOT NULL,
	[HandlePerson] [nvarchar](50) NOT NULL,
	[CreatePerson] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NULL,
	[CheckPerson] [nvarchar](50) NOT NULL,
	[CheckDate] [datetime] NULL,
	[Flag] [char](10) NOT NULL,
	[Remark] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BillGuid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillAutoID]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillAutoID](
	[id] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[BillAutoID] [int] NOT NULL,
	[Flag] [char](10) NOT NULL,
 CONSTRAINT [PK_BillAutoID] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillDetail]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetail](
	[BillDetailGuid] [nvarchar](50) NOT NULL,
	[BillGuid] [nvarchar](50) NOT NULL,
	[MaterialGuid] [nvarchar](50) NOT NULL,
	[MaterialId] [nvarchar](50) NOT NULL,
	[MaterialName] [nvarchar](200) NOT NULL,
	[BarNo] [nvarchar](50) NOT NULL,
	[Spec] [nvarchar](50) NOT NULL,
	[Unit] [nvarchar](50) NOT NULL,
	[Qty] [numeric](18, 2) NOT NULL,
	[Remark] [char](10) NOT NULL,
	[SortID] [int] IDENTITY(1,1) NOT NULL,
	[zj] [nvarchar](50) NULL,
	[gh] [nvarchar](50) NULL,
	[bz] [nvarchar](200) NULL,
	[qd] [nvarchar](50) NULL,
	[cd] [nvarchar](50) NULL,
	[jz] [nvarchar](50) NULL,
	[mz] [nvarchar](50) NULL,
	[scrq] [nvarchar](50) NULL,
	[Total] [decimal](18, 0) NULL,
 CONSTRAINT [PK_BillDetail] PRIMARY KEY CLUSTERED 
(
	[BillDetailGuid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CheckBill]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CheckBill](
	[CheckBillGuid] [nvarchar](50) NOT NULL,
	[BillDate] [datetime] NULL,
	[Depot] [nvarchar](50) NOT NULL,
	[HandlePerson] [nvarchar](50) NOT NULL,
	[BillID] [nvarchar](50) NOT NULL,
	[BillAutoID] [nvarchar](50) NOT NULL,
	[CreatePerson] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NULL,
	[CheckPerson] [nvarchar](50) NOT NULL,
	[CheckDate] [datetime] NULL,
	[Remark] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_CheckBill] PRIMARY KEY CLUSTERED 
(
	[CheckBillGuid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CheckBillDetail]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CheckBillDetail](
	[CheckBillDetailGuid] [nvarchar](50) NOT NULL,
	[CheckBillGuid] [nvarchar](50) NOT NULL,
	[MaterialGuid] [nvarchar](50) NOT NULL,
	[MaterialId] [nvarchar](50) NOT NULL,
	[MaterialName] [nvarchar](200) NOT NULL,
	[BarNo] [nvarchar](50) NOT NULL,
	[Spec] [nvarchar](50) NOT NULL,
	[Unit] [nvarchar](50) NOT NULL,
	[Price] [decimal](18, 6) NOT NULL,
	[SurplusQty] [numeric](18, 2) NOT NULL,
	[DeficientQty] [numeric](18, 2) NOT NULL,
	[Total] [decimal](18, 6) NOT NULL,
	[Remark] [char](10) NOT NULL,
	[SortID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_CheckBillDetail] PRIMARY KEY CLUSTERED 
(
	[CheckBillDetailGuid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[Guid] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[SimpName] [char](10) NOT NULL,
	[LinkMan] [nvarchar](50) NOT NULL,
	[Telephone] [nvarchar](50) NOT NULL,
	[Fax] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
	[Zip] [nvarchar](50) NOT NULL,
	[Remark] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[Guid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Depot]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Depot](
	[DepotGuid] [nvarchar](50) NOT NULL,
	[DepotName] [nvarchar](200) NOT NULL,
	[DepotPerson] [nvarchar](50) NOT NULL,
	[Telephone] [nvarchar](100) NOT NULL,
	[Remark] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Depot] PRIMARY KEY CLUSTERED 
(
	[DepotGuid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dept]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dept](
	[DeptGuid] [nvarchar](50) NOT NULL,
	[DeptName] [nvarchar](50) NOT NULL,
	[DeptPerson] [nvarchar](50) NOT NULL,
	[Telephone] [nvarchar](50) NOT NULL,
	[Fax] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Dept] PRIMARY KEY CLUSTERED 
(
	[DeptGuid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmpGuid] [nvarchar](50) NOT NULL,
	[EmpID] [nvarchar](50) NOT NULL,
	[EmpName] [nvarchar](50) NOT NULL,
	[Sex] [nvarchar](10) NOT NULL,
	[Telephone] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
	[CardID] [nvarchar](50) NOT NULL,
	[Dept] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmpGuid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoginUser]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginUser](
	[USERID] [nvarchar](50) NOT NULL,
	[USERNAME] [nvarchar](50) NOT NULL,
	[EMAIL] [nvarchar](50) NOT NULL,
	[PASSWORD] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoginUser] PRIMARY KEY CLUSTERED 
(
	[USERID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Material]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Material](
	[MaterialGuid] [nvarchar](50) NOT NULL,
	[MaterialId] [nvarchar](50) NOT NULL,
	[MaterialName] [nvarchar](100) NOT NULL,
	[ClassId] [nvarchar](50) NOT NULL,
	[Spec] [nvarchar](50) NOT NULL,
	[Unit] [nvarchar](50) NOT NULL,
	[BarNo] [nvarchar](200) NOT NULL,
	[Place] [nvarchar](50) NOT NULL,
	[Encapsulation] [nvarchar](50) NOT NULL,
	[UpperLimit] [int] NOT NULL,
	[LowerLimit] [int] NOT NULL,
	[IConsultPrice] [decimal](18, 2) NOT NULL,
	[EConsultPrice] [decimal](18, 2) NOT NULL,
	[CalculateMethod] [nvarchar](50) NOT NULL,
	[Remark] [nvarchar](50) NOT NULL,
	[zj] [nvarchar](50) NULL,
	[gh] [nvarchar](50) NULL,
	[bz] [nvarchar](50) NULL,
	[cd] [nvarchar](50) NULL,
	[jz] [nvarchar](50) NULL,
	[mz] [nvarchar](50) NULL,
	[scrq] [date] NULL,
	[qd] [nvarchar](50) NULL,
 CONSTRAINT [PK_Material] PRIMARY KEY CLUSTERED 
(
	[MaterialGuid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Module]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Module](
	[ModuleID] [nvarchar](50) NOT NULL,
	[ModuleName] [nvarchar](50) NOT NULL,
	[sortid] [int] NOT NULL,
 CONSTRAINT [PK_Module] PRIMARY KEY CLUSTERED 
(
	[ModuleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RemoveBill]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RemoveBill](
	[RemoveBillGuid] [nvarchar](50) NOT NULL,
	[BillDate] [datetime] NULL,
	[DepotOut] [nvarchar](50) NOT NULL,
	[DepotIn] [nvarchar](50) NOT NULL,
	[HandlePerson] [nvarchar](50) NOT NULL,
	[BillID] [nvarchar](50) NOT NULL,
	[BillAutoID] [nvarchar](50) NOT NULL,
	[CreatePerson] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NULL,
	[CheckPerson] [nvarchar](50) NOT NULL,
	[CheckDate] [datetime] NULL,
	[Remark] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_RemoveBill] PRIMARY KEY CLUSTERED 
(
	[RemoveBillGuid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RemoveBillDetail]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RemoveBillDetail](
	[RemoveBillDetailGuid] [nvarchar](50) NOT NULL,
	[RemoveBillGuid] [nvarchar](50) NOT NULL,
	[MaterialGuid] [nvarchar](50) NOT NULL,
	[MaterialId] [nvarchar](50) NOT NULL,
	[MaterialName] [nvarchar](200) NOT NULL,
	[BarNo] [nvarchar](50) NOT NULL,
	[Spec] [nvarchar](50) NOT NULL,
	[Unit] [nvarchar](50) NOT NULL,
	[Price] [decimal](18, 6) NOT NULL,
	[Qty] [numeric](18, 2) NOT NULL,
	[Total] [decimal](18, 6) NOT NULL,
	[Remark] [char](10) NOT NULL,
	[SortID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_RemoveBillDetail] PRIMARY KEY CLUSTERED 
(
	[RemoveBillDetailGuid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StorageClass]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StorageClass](
	[InterID] [nvarchar](50) NOT NULL,
	[InterName] [nvarchar](100) NOT NULL,
	[FatherID] [nvarchar](50) NOT NULL,
	[AllFatherName] [nvarchar](200) NOT NULL,
	[OrderNo] [int] NOT NULL,
	[IsVisable] [int] NOT NULL,
	[IsDeleted] [int] NOT NULL,
 CONSTRAINT [PK_StorageClass] PRIMARY KEY CLUSTERED 
(
	[InterID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StorageType]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StorageType](
	[StorageTypeID] [int] NOT NULL,
	[StorageTypeName] [nvarchar](50) NOT NULL,
	[Flag] [nvarchar](1) NOT NULL,
 CONSTRAINT [PK_StorageType] PRIMARY KEY CLUSTERED 
(
	[StorageTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[Guid] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[SimpName] [nvarchar](50) NOT NULL,
	[LinkMan] [nvarchar](30) NOT NULL,
	[Telephone] [nvarchar](50) NOT NULL,
	[Fax] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Zip] [nvarchar](50) NOT NULL,
	[Remark] [nvarchar](2000) NOT NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[Guid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[temp1]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[temp1](
	[RemoveBillGuid] [nvarchar](50) NOT NULL,
	[BillDate] [datetime] NULL,
	[DepotOut] [nvarchar](50) NOT NULL,
	[DepotIn] [nvarchar](50) NOT NULL,
	[HandlePerson] [nvarchar](50) NOT NULL,
	[BillID] [nvarchar](50) NOT NULL,
	[BillAutoID] [nvarchar](50) NOT NULL,
	[CreatePerson] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NULL,
	[CheckPerson] [nvarchar](50) NOT NULL,
	[CheckDate] [datetime] NULL,
	[Remark] [nvarchar](200) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[temp2]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[temp2](
	[RemoveBillDetailGuid] [nvarchar](50) NOT NULL,
	[RemoveBillGuid] [nvarchar](50) NOT NULL,
	[MaterialGuid] [nvarchar](50) NOT NULL,
	[MaterialId] [nvarchar](50) NOT NULL,
	[MaterialName] [nvarchar](200) NOT NULL,
	[BarNo] [nvarchar](50) NOT NULL,
	[Spec] [nvarchar](50) NOT NULL,
	[Unit] [nvarchar](50) NOT NULL,
	[Price] [decimal](18, 6) NOT NULL,
	[Qty] [numeric](18, 2) NOT NULL,
	[Total] [decimal](18, 6) NOT NULL,
	[Remark] [char](10) NOT NULL,
	[SortID] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRight]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRight](
	[UserID] [nvarchar](20) NOT NULL,
	[lkdgl] [char](1) NOT NULL,
	[lkdxz] [char](1) NOT NULL,
	[lkdsh] [char](1) NOT NULL,
	[lkdmxb] [char](1) NOT NULL,
	[lkdhzb] [char](1) NOT NULL,
	[ckdgl] [char](1) NOT NULL,
	[ckdxz] [char](1) NOT NULL,
	[ckdsh] [char](1) NOT NULL,
	[ckdmxb] [char](1) NOT NULL,
	[ckdhzb] [char](1) NOT NULL,
	[dbdgl] [char](1) NOT NULL,
	[dbdxz] [char](1) NOT NULL,
	[dbzsh] [char](1) NOT NULL,
	[cccx] [char](1) NOT NULL,
	[cksfmxb] [char](1) NOT NULL,
	[bmsfmxb] [char](1) NOT NULL,
	[sfchzb] [char](1) NOT NULL,
	[sflxhzb] [char](1) NOT NULL,
	[chmxz] [char](1) NOT NULL,
	[kcpd] [char](1) NOT NULL,
	[kcpdxz] [char](1) NOT NULL,
	[kcpdsh] [char](1) NOT NULL,
	[hp] [char](1) NOT NULL,
	[ck] [char](1) NOT NULL,
	[kh] [char](1) NOT NULL,
	[gys] [char](1) NOT NULL,
	[yg] [char](1) NOT NULL,
	[bm] [char](1) NOT NULL,
	[yhgl] [char](1) NOT NULL,
	[qxgl] [char](1) NOT NULL,
 CONSTRAINT [PK_UserRight] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_ALLDepotDetail]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_ALLDepotDetail] AS 
SELECT dbo.Bill.BillGuid, dbo.Bill.BillDate, dbo.Bill.StorageTypeGuid, 
      dbo.BillDetail.MaterialGuid, dbo.BillDetail.MaterialId, dbo.BillDetail.MaterialName, 
      dbo.BillDetail.Spec, dbo.BillDetail.Unit, dbo.BillDetail.Qty, 
			dbo.BillDetail.zj,dbo.BillDetail.gh,dbo.BillDetail.bz,dbo.BillDetail.qd, dbo.BillDetail.cd,dbo.BillDetail.jz,
			dbo.BillDetail.mz,dbo.BillDetail.scrq,dbo.BillDetail.Total,
       dbo.BillDetail.Remark, dbo.Bill.DepotGuid, dbo.Bill.SupplierGuid, 
      dbo.Bill.DeptGuid, dbo.Bill.Bearing, dbo.Bill.BillID, dbo.Bill.BatchNo, 
      dbo.Bill.HandlePerson, dbo.Bill.Remark AS RemarkHead, dbo.Material.BarNo, 
      dbo.Bill.BillAutoID, dbo.StorageClass.InterName, dbo.Bill.Flag
FROM dbo.Material LEFT OUTER JOIN
      dbo.StorageClass ON 
      dbo.Material.ClassId = dbo.StorageClass.InterID LEFT OUTER JOIN
      dbo.BillDetail ON 
      dbo.Material.MaterialGuid = dbo.BillDetail.MaterialGuid LEFT OUTER JOIN
      dbo.Bill ON dbo.BillDetail.BillGuid = dbo.Bill.BillGuid
WHERE (1 = 1)
GO
/****** Object:  View [dbo].[V_CheckBill]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
功能：盘点单视图
日期：2008-11-24
*/
CREATE VIEW [dbo].[V_CheckBill]
AS
SELECT dbo.CheckBill.CheckBillGuid, dbo.CheckBill.BillDate, dbo.CheckBill.Depot, 
      dbo.CheckBill.HandlePerson, dbo.CheckBill.BillID, dbo.CheckBill.BillAutoID, 
      dbo.CheckBill.CreatePerson, dbo.CheckBill.CreateDate, dbo.CheckBill.CheckPerson, 
      dbo.CheckBill.CheckDate, dbo.CheckBill.Remark, 
      dbo.CheckBillDetail.CheckBillDetailGuid, dbo.CheckBillDetail.MaterialGuid, 
      dbo.CheckBillDetail.MaterialId, dbo.CheckBillDetail.MaterialName, 
      dbo.CheckBillDetail.Spec, dbo.CheckBillDetail.Unit, dbo.CheckBillDetail.Price, 
      dbo.CheckBillDetail.SurplusQty, dbo.CheckBillDetail.DeficientQty, 
      dbo.CheckBillDetail.Total, dbo.CheckBillDetail.Remark AS Expr1
FROM dbo.CheckBill RIGHT OUTER JOIN
      dbo.CheckBillDetail ON 
      dbo.CheckBill.CheckBillGuid = dbo.CheckBillDetail.CheckBillGuid
GO
/****** Object:  View [dbo].[V_DepotDetail]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_DepotDetail] AS 
SELECT dbo.Bill.BillGuid, dbo.Bill.BillDate, dbo.Bill.StorageTypeGuid, 
      dbo.BillDetail.MaterialGuid, dbo.BillDetail.MaterialId, dbo.BillDetail.MaterialName, 
      dbo.BillDetail.Spec, dbo.BillDetail.Unit, dbo.BillDetail.Qty,dbo.BillDetail.zj,dbo.BillDetail.gh,dbo.BillDetail.bz,dbo.BillDetail.qd, dbo.BillDetail.cd,dbo.BillDetail.jz,
			dbo.BillDetail.mz,dbo.BillDetail.scrq, dbo.BillDetail.Total,
      dbo.BillDetail.Remark, dbo.Bill.DepotGuid, dbo.Bill.SupplierGuid, 
      dbo.Bill.DeptGuid, dbo.Bill.Bearing, dbo.Bill.BillID, dbo.Bill.BatchNo, 
      dbo.Bill.HandlePerson, dbo.Bill.Remark AS RemarkHead, dbo.Material.BarNo, 
      dbo.Bill.BillAutoID, dbo.StorageClass.InterName
FROM dbo.Material LEFT OUTER JOIN
      dbo.StorageClass ON 
      dbo.Material.ClassId = dbo.StorageClass.InterID LEFT OUTER JOIN
      dbo.BillDetail ON 
      dbo.Material.MaterialGuid = dbo.BillDetail.MaterialGuid LEFT OUTER JOIN
      dbo.Bill ON dbo.BillDetail.BillGuid = dbo.Bill.BillGuid
WHERE (dbo.Bill.Flag = 'E')AND(dbo.Bill.Flag = 'I')
GO
/****** Object:  View [dbo].[V_InDepotDetail]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_InDepotDetail] AS 
SELECT dbo.Bill.BillGuid, dbo.Bill.BillDate, dbo.Bill.StorageTypeGuid, 
      dbo.BillDetail.MaterialGuid, dbo.BillDetail.MaterialId, dbo.BillDetail.MaterialName, 
      dbo.BillDetail.Spec, dbo.BillDetail.Unit,  dbo.BillDetail.Qty, 
      dbo.BillDetail.Remark,dbo.BillDetail.zj,dbo.BillDetail.gh,dbo.BillDetail.bz, dbo.BillDetail.qd,dbo.BillDetail.cd,dbo.BillDetail.jz,dbo.BillDetail.mz,dbo.BillDetail.scrq,
dbo.Bill.DepotGuid, dbo.Bill.SupplierGuid, dbo.BillDetail.Total,
      dbo.Bill.DeptGuid, dbo.Bill.Bearing, dbo.Bill.BillID, dbo.Bill.BatchNo, 
      dbo.Bill.HandlePerson, dbo.Bill.Remark AS RemarkHead, dbo.Material.BarNo, 
      dbo.Bill.BillAutoID, dbo.StorageClass.InterName
FROM dbo.Material LEFT OUTER JOIN
      dbo.StorageClass ON 
      dbo.Material.ClassId = dbo.StorageClass.InterID LEFT OUTER JOIN
      dbo.BillDetail ON 
      dbo.Material.MaterialGuid = dbo.BillDetail.MaterialGuid LEFT OUTER JOIN
      dbo.Bill ON dbo.BillDetail.BillGuid = dbo.Bill.BillGuid
WHERE (dbo.Bill.Flag = 'I')
GO
/****** Object:  View [dbo].[V_MaterialClass]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_MaterialClass]
AS
SELECT dbo.Material.MaterialGuid, dbo.Material.MaterialName, dbo.Material.ClassId, 
      dbo.StorageClass.InterName AS ClassName
FROM dbo.Material INNER JOIN
      dbo.StorageClass ON dbo.Material.ClassId = dbo.StorageClass.InterID
GO
/****** Object:  View [dbo].[V_OutDepotDetail]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_OutDepotDetail] AS 
SELECT dbo.Bill.BillGuid, dbo.Bill.BillDate, dbo.Bill.StorageTypeGuid, 
      dbo.BillDetail.MaterialGuid, dbo.BillDetail.MaterialId, dbo.BillDetail.MaterialName, 
      dbo.BillDetail.Spec, dbo.BillDetail.Unit,  dbo.BillDetail.Qty, dbo.BillDetail.zj,dbo.BillDetail.gh,dbo.BillDetail.bz,dbo.BillDetail.qd, dbo.BillDetail.cd,dbo.BillDetail.jz,
			dbo.BillDetail.mz,dbo.BillDetail.scrq,dbo.BillDetail.Total,
       dbo.BillDetail.Remark, dbo.Bill.DepotGuid, dbo.Bill.SupplierGuid, 
      dbo.Bill.DeptGuid, dbo.Bill.Bearing, dbo.Bill.BillID, dbo.Bill.BatchNo, 
      dbo.Bill.HandlePerson, dbo.Bill.Remark AS RemarkHead, dbo.Material.BarNo, 
      dbo.Bill.BillAutoID, dbo.StorageClass.InterName
FROM dbo.Material LEFT OUTER JOIN
      dbo.StorageClass ON 
      dbo.Material.ClassId = dbo.StorageClass.InterID LEFT OUTER JOIN
      dbo.BillDetail ON 
      dbo.Material.MaterialGuid = dbo.BillDetail.MaterialGuid LEFT OUTER JOIN
      dbo.Bill ON dbo.BillDetail.BillGuid = dbo.Bill.BillGuid
WHERE (dbo.Bill.Flag = 'E')
GO
/****** Object:  View [dbo].[V_RemoveBill]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
功能： 调拨全部明细表视图
日期：2008-11-24
*/
CREATE VIEW [dbo].[V_RemoveBill]
AS
SELECT dbo.RemoveBill.RemoveBillGuid, dbo.RemoveBill.BillDate, 
      dbo.RemoveBill.DepotOut, dbo.RemoveBill.DepotIn, dbo.RemoveBill.HandlePerson, 
      dbo.RemoveBill.BillID, dbo.RemoveBill.BillAutoID, dbo.RemoveBill.CreatePerson, 
      dbo.RemoveBill.CreateDate, dbo.RemoveBill.CheckPerson, 
      dbo.RemoveBill.CheckDate, dbo.RemoveBill.Remark, 
      dbo.RemoveBillDetail.RemoveBillDetailGuid, dbo.RemoveBillDetail.MaterialGuid, 
      dbo.RemoveBillDetail.MaterialId, dbo.RemoveBillDetail.MaterialName, 
      dbo.RemoveBillDetail.Spec, dbo.RemoveBillDetail.Unit, dbo.RemoveBillDetail.Price, 
      dbo.RemoveBillDetail.Qty, dbo.RemoveBillDetail.Total, 
      dbo.RemoveBillDetail.SortID
FROM dbo.RemoveBill RIGHT OUTER JOIN
      dbo.RemoveBillDetail ON 
      dbo.RemoveBill.RemoveBillGuid = dbo.RemoveBillDetail.RemoveBillGuid
GO
SET IDENTITY_INSERT [dbo].[BasicData] ON 

INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (1, N'个', 1)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (2, N'只', 1)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (3, N'条', 1)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (4, N'根', 1)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (5, N'块', 1)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (6, N'平方米', 1)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (7, N'克', 1)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (8, N'公斤', 1)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (9, N'包', 1)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (10, N'箱', 1)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (11, N'张', 1)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (12, N'盒', 1)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (13, N'套', 1)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (14, N'米', 1)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (200, N'封边', 3)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (201, N'封口', 3)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (202, N'封底', 3)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (203, N'去边', 3)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (204, N'拆边', 3)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (300, N'加权平均法', 4)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (301, N'移动加权平均法', 4)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (302, N'先进先出法', 4)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (303, N'后进先出法', 4)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (305, N'', 3)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (306, N'', 3)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (307, N'', 3)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (308, N'', 3)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (309, N'', 3)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (310, N'', 3)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (311, N'', 3)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (312, N'', 3)
INSERT [dbo].[BasicData] ([UnitID], [UnitName], [flag]) VALUES (313, N'123', 2)
SET IDENTITY_INSERT [dbo].[BasicData] OFF
INSERT [dbo].[Bill] ([BillGuid], [BillAutoID], [BillDate], [DepotGuid], [StorageTypeGuid], [SupplierGuid], [DeptGuid], [Bearing], [BillID], [BatchNo], [HandlePerson], [CreatePerson], [CreateDate], [CheckPerson], [CheckDate], [Flag], [Remark]) VALUES (N'0c108997-5439-4bb8-ba39-9dcfbfb3863d', N'201810316235', CAST(N'2018-10-31T00:00:00.000' AS DateTime), N'1', N'', N'', N'', N'', N'', N'', N'方栋', N'系统管理员', CAST(N'2018-10-31T15:37:14.000' AS DateTime), N'', NULL, N'I         ', N'')
INSERT [dbo].[Bill] ([BillGuid], [BillAutoID], [BillDate], [DepotGuid], [StorageTypeGuid], [SupplierGuid], [DeptGuid], [Bearing], [BillID], [BatchNo], [HandlePerson], [CreatePerson], [CreateDate], [CheckPerson], [CheckDate], [Flag], [Remark]) VALUES (N'18f2ad58-609e-48c7-954b-87bb2d665766', N'201810316229', CAST(N'2018-10-31T00:00:00.000' AS DateTime), N'1', N'', N'', N'', N'', N'', N'', N'方栋', N'系统管理员', CAST(N'2018-10-31T15:22:42.000' AS DateTime), N'', NULL, N'I         ', N'')
INSERT [dbo].[Bill] ([BillGuid], [BillAutoID], [BillDate], [DepotGuid], [StorageTypeGuid], [SupplierGuid], [DeptGuid], [Bearing], [BillID], [BatchNo], [HandlePerson], [CreatePerson], [CreateDate], [CheckPerson], [CheckDate], [Flag], [Remark]) VALUES (N'5f8e2074-e171-4790-ad89-0b2b38c4f4bc', N'201810316233', CAST(N'2018-10-31T00:00:00.000' AS DateTime), N'1', N'', N'', N'', N'', N'', N'', N'方栋', N'系统管理员', CAST(N'2018-10-31T15:34:05.000' AS DateTime), N'', NULL, N'I         ', N'')
INSERT [dbo].[Bill] ([BillGuid], [BillAutoID], [BillDate], [DepotGuid], [StorageTypeGuid], [SupplierGuid], [DeptGuid], [Bearing], [BillID], [BatchNo], [HandlePerson], [CreatePerson], [CreateDate], [CheckPerson], [CheckDate], [Flag], [Remark]) VALUES (N'956b792c-acbb-4a50-bff7-dfd30554cd37', N'201810316236', CAST(N'2018-10-31T00:00:00.000' AS DateTime), N'1', N'', N'', N'', N'', N'', N'', N'方栋', N'系统管理员', CAST(N'2018-10-31T15:38:20.000' AS DateTime), N'', NULL, N'I         ', N'')
SET IDENTITY_INSERT [dbo].[BillAutoID] ON 

INSERT [dbo].[BillAutoID] ([id], [BillAutoID], [Flag]) VALUES (1, 6243, N'I         ')
INSERT [dbo].[BillAutoID] ([id], [BillAutoID], [Flag]) VALUES (2, 2027, N'E         ')
INSERT [dbo].[BillAutoID] ([id], [BillAutoID], [Flag]) VALUES (3, 33967, N'M         ')
INSERT [dbo].[BillAutoID] ([id], [BillAutoID], [Flag]) VALUES (4, 283, N'P         ')
SET IDENTITY_INSERT [dbo].[BillAutoID] OFF
SET IDENTITY_INSERT [dbo].[BillDetail] ON 

INSERT [dbo].[BillDetail] ([BillDetailGuid], [BillGuid], [MaterialGuid], [MaterialId], [MaterialName], [BarNo], [Spec], [Unit], [Qty], [Remark], [SortID], [zj], [gh], [bz], [qd], [cd], [jz], [mz], [scrq], [Total]) VALUES (N'18b20775-fb2b-4335-bf64-752473b598ac', N'956b792c-acbb-4a50-bff7-dfd30554cd37', N'a810669a-2bb4-4caa-8661-e7884518d88c', N'', N'', N'', N'123', N'条', CAST(0.00 AS Numeric(18, 2)), N'          ', 654208, N'半成品', N'2', N'1', N'4', N'5', N'8', N'7', N'2018-10-24 0:00:00', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[BillDetail] ([BillDetailGuid], [BillGuid], [MaterialGuid], [MaterialId], [MaterialName], [BarNo], [Spec], [Unit], [Qty], [Remark], [SortID], [zj], [gh], [bz], [qd], [cd], [jz], [mz], [scrq], [Total]) VALUES (N'380751ab-bb9e-4d2d-9e9a-b2d586c3832c', N'956b792c-acbb-4a50-bff7-dfd30554cd37', N'a810669a-2bb4-4caa-8661-e7884518d88c', N'', N'', N'123', N'条', N'0.00', CAST(0.00 AS Numeric(18, 2)), N'半成品    ', 654209, N'2', N'1', N'4', N'5', N'8', N'7', N'2018-10-24 0:00:00', N'          ', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[BillDetail] ([BillDetailGuid], [BillGuid], [MaterialGuid], [MaterialId], [MaterialName], [BarNo], [Spec], [Unit], [Qty], [Remark], [SortID], [zj], [gh], [bz], [qd], [cd], [jz], [mz], [scrq], [Total]) VALUES (N'4cc17b63-d6a4-4c76-aaaf-6d5c24c6817b', N'0c108997-5439-4bb8-ba39-9dcfbfb3863d', N'8f42e752-3d86-4413-8b3f-31524a449c88', N'', N'', N'123', N'条', N'', CAST(0.00 AS Numeric(18, 2)), N'2         ', 654205, N'1', N'4', N'4', N'5', N'6', N'7', N'2018-10-24 0:00:00', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[BillDetail] ([BillDetailGuid], [BillGuid], [MaterialGuid], [MaterialId], [MaterialName], [BarNo], [Spec], [Unit], [Qty], [Remark], [SortID], [zj], [gh], [bz], [qd], [cd], [jz], [mz], [scrq], [Total]) VALUES (N'5a866c90-cc3b-42ee-92a6-01ca1d824884', N'5f8e2074-e171-4790-ad89-0b2b38c4f4bc', N'8f42e752-3d86-4413-8b3f-31524a449c88', N'', N'', N'123', N'条', N'', CAST(0.00 AS Numeric(18, 2)), N'2         ', 654204, N'1', N'4', N'4', N'5', N'6', N'7', N'2018-10-24 0:00:00', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[BillDetail] ([BillDetailGuid], [BillGuid], [MaterialGuid], [MaterialId], [MaterialName], [BarNo], [Spec], [Unit], [Qty], [Remark], [SortID], [zj], [gh], [bz], [qd], [cd], [jz], [mz], [scrq], [Total]) VALUES (N'6015d670-99e6-4a98-ab2e-4580e2ae0dd9', N'5f8e2074-e171-4790-ad89-0b2b38c4f4bc', N'a810669a-2bb4-4caa-8661-e7884518d88c', N'', N'', N'', N'123', N'条', CAST(0.00 AS Numeric(18, 2)), N'          ', 654202, N'半成品', N'2', N'1', N'4', N'5', N'8', N'7', N'2018-10-24 0:00:00', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[BillDetail] ([BillDetailGuid], [BillGuid], [MaterialGuid], [MaterialId], [MaterialName], [BarNo], [Spec], [Unit], [Qty], [Remark], [SortID], [zj], [gh], [bz], [qd], [cd], [jz], [mz], [scrq], [Total]) VALUES (N'64609297-eb6b-4782-9c0a-535d4b91ff09', N'5f8e2074-e171-4790-ad89-0b2b38c4f4bc', N'a810669a-2bb4-4caa-8661-e7884518d88c', N'', N'', N'123', N'条', N'0.00', CAST(0.00 AS Numeric(18, 2)), N'半成品    ', 654203, N'2', N'1', N'4', N'5', N'8', N'7', N'2018-10-24 0:00:00', N'          ', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[BillDetail] ([BillDetailGuid], [BillGuid], [MaterialGuid], [MaterialId], [MaterialName], [BarNo], [Spec], [Unit], [Qty], [Remark], [SortID], [zj], [gh], [bz], [qd], [cd], [jz], [mz], [scrq], [Total]) VALUES (N'69657398-9f66-4dca-a702-c152df6a6100', N'0c108997-5439-4bb8-ba39-9dcfbfb3863d', N'e6b34a77-fa12-49e7-b84c-1e5775ceaebd', N'', N'', N'123', N'条', N'', CAST(0.00 AS Numeric(18, 2)), N'2         ', 654207, N'1', N'4', N'1', N'5', N'8', N'7', N'2018-10-24 0:00:00', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[BillDetail] ([BillDetailGuid], [BillGuid], [MaterialGuid], [MaterialId], [MaterialName], [BarNo], [Spec], [Unit], [Qty], [Remark], [SortID], [zj], [gh], [bz], [qd], [cd], [jz], [mz], [scrq], [Total]) VALUES (N'e82da947-b8fc-4242-8e2f-eb123b9f9ecb', N'0c108997-5439-4bb8-ba39-9dcfbfb3863d', N'8f42e752-3d86-4413-8b3f-31524a449c88', N'', N'', N'条', N'', N'0.00', CAST(0.00 AS Numeric(18, 2)), N'1         ', 654206, N'4', N'4', N'5', N'6', N'7', N'2018-10-24 0:00:00', N'', N'2         ', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[BillDetail] ([BillDetailGuid], [BillGuid], [MaterialGuid], [MaterialId], [MaterialName], [BarNo], [Spec], [Unit], [Qty], [Remark], [SortID], [zj], [gh], [bz], [qd], [cd], [jz], [mz], [scrq], [Total]) VALUES (N'ef17a412-5c68-47e2-b6bd-d3106bf56bd9', N'956b792c-acbb-4a50-bff7-dfd30554cd37', N'55f461b5-c473-4192-b68a-bed17f3daebc', N'', N'', N'123', N'条', N'', CAST(0.00 AS Numeric(18, 2)), N'4         ', 654210, N'5', N'6', N'3', N'7', N'1', N'9', N'2018-10-25 0:00:00', N'', CAST(0 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[BillDetail] OFF
INSERT [dbo].[Client] ([Guid], [Name], [SimpName], [LinkMan], [Telephone], [Fax], [Address], [Zip], [Remark]) VALUES (N'03c59d13-41ea-4ac6-80ce-22a725b0f59e', N'科瓴', N'科瓴      ', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[Client] ([Guid], [Name], [SimpName], [LinkMan], [Telephone], [Fax], [Address], [Zip], [Remark]) VALUES (N'065591f6-3043-4974-8e3a-c5963c86d121', N'罗友', N'罗友      ', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[Client] ([Guid], [Name], [SimpName], [LinkMan], [Telephone], [Fax], [Address], [Zip], [Remark]) VALUES (N'300fda93-cab0-4a40-947e-acde9a0a7baf', N'嘉兴良友', N'嘉兴良友  ', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[Depot] ([DepotGuid], [DepotName], [DepotPerson], [Telephone], [Remark]) VALUES (N'14082f05-7ed7-46cb-a484-2515c4b8b56c', N'1', N'', N'0', N'0')
INSERT [dbo].[Depot] ([DepotGuid], [DepotName], [DepotPerson], [Telephone], [Remark]) VALUES (N'2d84506b-9ba5-4b7d-9b16-7fd2aa377c9c', N'2', N'', N'0', N'0')
INSERT [dbo].[Depot] ([DepotGuid], [DepotName], [DepotPerson], [Telephone], [Remark]) VALUES (N'397eb674-9d48-4149-b0a3-6bc2376d2f87', N'3', N'', N'0', N'0')
INSERT [dbo].[Depot] ([DepotGuid], [DepotName], [DepotPerson], [Telephone], [Remark]) VALUES (N'39811954-3688-44f6-ab6f-89b3a8f2e6a4', N'4', N'', N'0', N'0')
INSERT [dbo].[Depot] ([DepotGuid], [DepotName], [DepotPerson], [Telephone], [Remark]) VALUES (N'4542feff-f38b-4e10-9c2f-40fb616ce93b', N'5', N'', N'0', N'0')
INSERT [dbo].[Depot] ([DepotGuid], [DepotName], [DepotPerson], [Telephone], [Remark]) VALUES (N'4dd85545-bba1-46c2-82aa-6e5bf1695999', N'6', N'', N'0', N'0')
INSERT [dbo].[Depot] ([DepotGuid], [DepotName], [DepotPerson], [Telephone], [Remark]) VALUES (N'4e348402-5bfa-40b5-94f9-5e8e2e232139', N'7', N'', N'0', N'0')
INSERT [dbo].[Depot] ([DepotGuid], [DepotName], [DepotPerson], [Telephone], [Remark]) VALUES (N'63ac39c0-ed3e-4c46-8bfa-96277b9cf622', N'8', N'', N'0', N'0')
INSERT [dbo].[Depot] ([DepotGuid], [DepotName], [DepotPerson], [Telephone], [Remark]) VALUES (N'75b9cc5c-a7e5-4482-a25a-8b35373ce1ef', N'9', N'', N'0', N'0')
INSERT [dbo].[Depot] ([DepotGuid], [DepotName], [DepotPerson], [Telephone], [Remark]) VALUES (N'90664540-a852-43d2-bac9-96d6b67159e0', N'10', N'', N'0', N'0')
INSERT [dbo].[Dept] ([DeptGuid], [DeptName], [DeptPerson], [Telephone], [Fax], [Address]) VALUES (N'b44f8143-e593-447e-bc91-cc6030a1dbb1', N'D001', N'方栋', N'', N'', N'')
INSERT [dbo].[Employee] ([EmpGuid], [EmpID], [EmpName], [Sex], [Telephone], [Address], [CardID], [Dept]) VALUES (N'2adf3a4a-630a-4a62-af59-a83a57d11f48', N'001', N'方栋', N'女', N'', N'', N'', N'')
INSERT [dbo].[Employee] ([EmpGuid], [EmpID], [EmpName], [Sex], [Telephone], [Address], [CardID], [Dept]) VALUES (N'55a516b0-90f7-432e-a431-7439c9e6cad3', N'002', N'方总', N'女', N'', N'', N'', N'')
INSERT [dbo].[LoginUser] ([USERID], [USERNAME], [EMAIL], [PASSWORD]) VALUES (N'admin', N'系统管理员', N'', N'Bm5fDyT98Cg=')
INSERT [dbo].[LoginUser] ([USERID], [USERNAME], [EMAIL], [PASSWORD]) VALUES (N'User', N'操作员', N'', N'Bm5fDyT98Cg=')
INSERT [dbo].[Material] ([MaterialGuid], [MaterialId], [MaterialName], [ClassId], [Spec], [Unit], [BarNo], [Place], [Encapsulation], [UpperLimit], [LowerLimit], [IConsultPrice], [EConsultPrice], [CalculateMethod], [Remark], [zj], [gh], [bz], [cd], [jz], [mz], [scrq], [qd]) VALUES (N'1b67a7d0-bbc5-45ed-9a9c-db49c615dc90', N'234', N'123', N'5', N'123', N'条', N'', N'', N'', 0, 0, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'', N'', N'1', N'2', N'3', N'4', N'5', N'6', CAST(N'2018-10-24' AS Date), N'2')
INSERT [dbo].[Material] ([MaterialGuid], [MaterialId], [MaterialName], [ClassId], [Spec], [Unit], [BarNo], [Place], [Encapsulation], [UpperLimit], [LowerLimit], [IConsultPrice], [EConsultPrice], [CalculateMethod], [Remark], [zj], [gh], [bz], [cd], [jz], [mz], [scrq], [qd]) VALUES (N'5426d875-38f8-40a8-b226-d792787f0204', N'D003', N'断路器', N'2', N'5SY4203-7', N'个', N'', N'', N'', 0, 0, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'', N'', N'1', N'1', N'1', N'1', N'1', N'1', CAST(N'2018-10-31' AS Date), N'2')
INSERT [dbo].[Material] ([MaterialGuid], [MaterialId], [MaterialName], [ClassId], [Spec], [Unit], [BarNo], [Place], [Encapsulation], [UpperLimit], [LowerLimit], [IConsultPrice], [EConsultPrice], [CalculateMethod], [Remark], [zj], [gh], [bz], [cd], [jz], [mz], [scrq], [qd]) VALUES (N'55f461b5-c473-4192-b68a-bed17f3daebc', N'6', N'1', N'5', N'123', N'条', N'', N'', N'', 0, 0, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'', N'', N'4', N'5', N'6', N'7', N'1', N'9', CAST(N'2018-10-25' AS Date), N'3')
INSERT [dbo].[Material] ([MaterialGuid], [MaterialId], [MaterialName], [ClassId], [Spec], [Unit], [BarNo], [Place], [Encapsulation], [UpperLimit], [LowerLimit], [IConsultPrice], [EConsultPrice], [CalculateMethod], [Remark], [zj], [gh], [bz], [cd], [jz], [mz], [scrq], [qd]) VALUES (N'8f42e752-3d86-4413-8b3f-31524a449c88', N'1', N'1', N'5', N'123', N'条', N'', N'', N'', 0, 0, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'', N'', N'2', N'1', N'4', N'5', N'6', N'7', CAST(N'2018-10-24' AS Date), N'4')
INSERT [dbo].[Material] ([MaterialGuid], [MaterialId], [MaterialName], [ClassId], [Spec], [Unit], [BarNo], [Place], [Encapsulation], [UpperLimit], [LowerLimit], [IConsultPrice], [EConsultPrice], [CalculateMethod], [Remark], [zj], [gh], [bz], [cd], [jz], [mz], [scrq], [qd]) VALUES (N'9bf7e7b4-e526-4220-83e6-837d2fa5b1ff', N'P001', N'显卡', N'6', N'123', N'块', N'', N'', N'', 0, 0, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'', N'', N'1', N'1', N'1', N'1', N'1', N'1', CAST(N'2018-10-24' AS Date), N'1')
INSERT [dbo].[Material] ([MaterialGuid], [MaterialId], [MaterialName], [ClassId], [Spec], [Unit], [BarNo], [Place], [Encapsulation], [UpperLimit], [LowerLimit], [IConsultPrice], [EConsultPrice], [CalculateMethod], [Remark], [zj], [gh], [bz], [cd], [jz], [mz], [scrq], [qd]) VALUES (N'a810669a-2bb4-4caa-8661-e7884518d88c', N'1', N'1', N'5', N'123', N'条', N'', N'', N'', 0, 0, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'', N'', N'2', N'1', N'4', N'5', N'8', N'7', CAST(N'2018-10-24' AS Date), N'1')
INSERT [dbo].[Material] ([MaterialGuid], [MaterialId], [MaterialName], [ClassId], [Spec], [Unit], [BarNo], [Place], [Encapsulation], [UpperLimit], [LowerLimit], [IConsultPrice], [EConsultPrice], [CalculateMethod], [Remark], [zj], [gh], [bz], [cd], [jz], [mz], [scrq], [qd]) VALUES (N'e416984e-ce2b-411e-baac-d94f979fe8b1', N'1', N'1', N'5', N'123', N'条', N'', N'', N'', 0, 0, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'', N'', N'2', N'1', N'4', N'5', N'1', N'7', CAST(N'2018-10-24' AS Date), N'1')
INSERT [dbo].[Material] ([MaterialGuid], [MaterialId], [MaterialName], [ClassId], [Spec], [Unit], [BarNo], [Place], [Encapsulation], [UpperLimit], [LowerLimit], [IConsultPrice], [EConsultPrice], [CalculateMethod], [Remark], [zj], [gh], [bz], [cd], [jz], [mz], [scrq], [qd]) VALUES (N'e6b34a77-fa12-49e7-b84c-1e5775ceaebd', N'1', N'1', N'5', N'123', N'条', N'', N'', N'', 0, 0, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'', N'', N'2', N'1', N'4', N'5', N'8', N'7', CAST(N'2018-10-24' AS Date), N'1')
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'bm', N'部门', 28)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'bmsfmxb', N'部门收发明细表', 16)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'cccx', N'库存查询', 14)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'chmxz', N'存货明细账', 19)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'ck', N'仓库', 24)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'ckdgl', N'出库单管理', 6)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'ckdhzb', N'出库单汇总表', 10)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'ckdmxb', N'出库单明细表', 9)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'ckdsh', N'出库单审核', 8)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'ckdxz', N'出库单新增', 7)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'cksfmxb', N'仓库收发明细表', 15)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'dbdgl', N'调拨单管理', 11)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'dbdxz', N'调拨单新增', 12)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'dbzsh', N'调拨单审核', 13)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'gys', N'供应商', 26)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'hp', N'货品', 23)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'kcpd', N'库存盘点', 20)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'kcpdsh', N'库存盘点审核', 22)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'kcpdxz', N'库存盘点新增', 21)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'kh', N'客户', 25)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'lkdgl', N'入库单管理', 1)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'lkdhzb', N'入库汇总表', 5)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'lkdmxb', N'入库单明细表', 4)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'lkdsh', N'入库单审核', 3)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'lkdxz', N'入库单新增', 2)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'qxgl', N'权限管理', 30)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'sfchzb', N'收发存汇总表', 17)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'sflxhzb', N'收发类型汇总表', 18)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'yg', N'员工', 27)
INSERT [dbo].[Module] ([ModuleID], [ModuleName], [sortid]) VALUES (N'yhgl', N'用户管理', 29)
INSERT [dbo].[StorageClass] ([InterID], [InterName], [FatherID], [AllFatherName], [OrderNo], [IsVisable], [IsDeleted]) VALUES (N'0000', N'货品分类', N'0', N'', 0, 0, 0)
INSERT [dbo].[StorageClass] ([InterID], [InterName], [FatherID], [AllFatherName], [OrderNo], [IsVisable], [IsDeleted]) VALUES (N'2', N'原材料', N'0000', N'', 0, 0, 0)
INSERT [dbo].[StorageClass] ([InterID], [InterName], [FatherID], [AllFatherName], [OrderNo], [IsVisable], [IsDeleted]) VALUES (N'5', N'半成品', N'0000', N'', 0, 0, 0)
INSERT [dbo].[StorageClass] ([InterID], [InterName], [FatherID], [AllFatherName], [OrderNo], [IsVisable], [IsDeleted]) VALUES (N'6', N'成品', N'0000', N'', 0, 0, 0)
INSERT [dbo].[StorageType] ([StorageTypeID], [StorageTypeName], [Flag]) VALUES (1, N'入库', N'I')
INSERT [dbo].[StorageType] ([StorageTypeID], [StorageTypeName], [Flag]) VALUES (2, N'出库', N'E')
INSERT [dbo].[Supplier] ([Guid], [Name], [SimpName], [LinkMan], [Telephone], [Fax], [Address], [Zip], [Remark]) VALUES (N'02f66433-8480-465a-b5d8-0dcba568a8b5', N'激光', N'威达激光', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[UserRight] ([UserID], [lkdgl], [lkdxz], [lkdsh], [lkdmxb], [lkdhzb], [ckdgl], [ckdxz], [ckdsh], [ckdmxb], [ckdhzb], [dbdgl], [dbdxz], [dbzsh], [cccx], [cksfmxb], [bmsfmxb], [sfchzb], [sflxhzb], [chmxz], [kcpd], [kcpdxz], [kcpdsh], [hp], [ck], [kh], [gys], [yg], [bm], [yhgl], [qxgl]) VALUES (N'admin', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1')
INSERT [dbo].[UserRight] ([UserID], [lkdgl], [lkdxz], [lkdsh], [lkdmxb], [lkdhzb], [ckdgl], [ckdxz], [ckdsh], [ckdmxb], [ckdhzb], [dbdgl], [dbdxz], [dbzsh], [cccx], [cksfmxb], [bmsfmxb], [sfchzb], [sflxhzb], [chmxz], [kcpd], [kcpdxz], [kcpdsh], [hp], [ck], [kh], [gys], [yg], [bm], [yhgl], [qxgl]) VALUES (N'User', N'1', N'1', N'1', N'1', N'0', N'0', N'0', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1')
INSERT [dbo].[UserRight] ([UserID], [lkdgl], [lkdxz], [lkdsh], [lkdmxb], [lkdhzb], [ckdgl], [ckdxz], [ckdsh], [ckdmxb], [ckdhzb], [dbdgl], [dbdxz], [dbzsh], [cccx], [cksfmxb], [bmsfmxb], [sfchzb], [sflxhzb], [chmxz], [kcpd], [kcpdxz], [kcpdsh], [hp], [ck], [kh], [gys], [yg], [bm], [yhgl], [qxgl]) VALUES (N'zm', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1')
ALTER TABLE [dbo].[BasicData] ADD  CONSTRAINT [DF_Unit_UnitName]  DEFAULT ('') FOR [UnitName]
GO
ALTER TABLE [dbo].[BasicData] ADD  CONSTRAINT [DF_Unit_flag]  DEFAULT ((0)) FOR [flag]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_BillGuid]  DEFAULT ('') FOR [BillGuid]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_BillAutoID]  DEFAULT ('') FOR [BillAutoID]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_DepotGuid]  DEFAULT ('') FOR [DepotGuid]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_StorageTypeGuid]  DEFAULT ('') FOR [StorageTypeGuid]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_SupplierGuid]  DEFAULT ('') FOR [SupplierGuid]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_DeptGuid]  DEFAULT ('') FOR [DeptGuid]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_Bearing]  DEFAULT ('') FOR [Bearing]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_BillID]  DEFAULT ('') FOR [BillID]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_BatchNo]  DEFAULT ('') FOR [BatchNo]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_HandlePerson]  DEFAULT ('') FOR [HandlePerson]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_BillPerson]  DEFAULT ('') FOR [CreatePerson]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_CreateDate]  DEFAULT ('') FOR [CreateDate]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_CheckPerson]  DEFAULT ('') FOR [CheckPerson]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_CheckDate]  DEFAULT ('') FOR [CheckDate]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_Flag]  DEFAULT ('') FOR [Flag]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_Remark]  DEFAULT ('') FOR [Remark]
GO
ALTER TABLE [dbo].[BillAutoID] ADD  CONSTRAINT [DF_BillAutoID_Flag]  DEFAULT ('') FOR [Flag]
GO
ALTER TABLE [dbo].[BillDetail] ADD  CONSTRAINT [DF_BillDetail_BillGuid]  DEFAULT ('') FOR [BillGuid]
GO
ALTER TABLE [dbo].[BillDetail] ADD  CONSTRAINT [DF_BillDetail_MaterialGuid]  DEFAULT ('') FOR [MaterialGuid]
GO
ALTER TABLE [dbo].[BillDetail] ADD  CONSTRAINT [DF_BillDetail_MaterialId]  DEFAULT ('') FOR [MaterialId]
GO
ALTER TABLE [dbo].[BillDetail] ADD  CONSTRAINT [DF_BillDetail_MaterialName]  DEFAULT ('') FOR [MaterialName]
GO
ALTER TABLE [dbo].[BillDetail] ADD  CONSTRAINT [DF_BillDetail_BarNo]  DEFAULT ('') FOR [BarNo]
GO
ALTER TABLE [dbo].[BillDetail] ADD  CONSTRAINT [DF_BillDetail_Spec]  DEFAULT ('') FOR [Spec]
GO
ALTER TABLE [dbo].[BillDetail] ADD  CONSTRAINT [DF_BillDetail_Unit]  DEFAULT ('') FOR [Unit]
GO
ALTER TABLE [dbo].[BillDetail] ADD  CONSTRAINT [DF_BillDetail_Qty]  DEFAULT ((0)) FOR [Qty]
GO
ALTER TABLE [dbo].[BillDetail] ADD  CONSTRAINT [DF_BillDetail_Remark]  DEFAULT ('') FOR [Remark]
GO
ALTER TABLE [dbo].[CheckBill] ADD  CONSTRAINT [DF_CheckBill_DepotOut]  DEFAULT ('') FOR [Depot]
GO
ALTER TABLE [dbo].[CheckBill] ADD  CONSTRAINT [DF_CheckBill_HandlePerson]  DEFAULT ('') FOR [HandlePerson]
GO
ALTER TABLE [dbo].[CheckBill] ADD  CONSTRAINT [DF_CheckBill_BillID]  DEFAULT ('') FOR [BillID]
GO
ALTER TABLE [dbo].[CheckBill] ADD  CONSTRAINT [DF_CheckBill_BillAutoID]  DEFAULT ('') FOR [BillAutoID]
GO
ALTER TABLE [dbo].[CheckBill] ADD  CONSTRAINT [DF_CheckBill_CreatePerson]  DEFAULT ('') FOR [CreatePerson]
GO
ALTER TABLE [dbo].[CheckBill] ADD  CONSTRAINT [DF_CheckBill_CreateDate]  DEFAULT ('') FOR [CreateDate]
GO
ALTER TABLE [dbo].[CheckBill] ADD  CONSTRAINT [DF_CheckBill_CheckPerson]  DEFAULT ('') FOR [CheckPerson]
GO
ALTER TABLE [dbo].[CheckBill] ADD  CONSTRAINT [DF_CheckBill_CheckDate]  DEFAULT ('') FOR [CheckDate]
GO
ALTER TABLE [dbo].[CheckBill] ADD  CONSTRAINT [DF_CheckBill_Remark]  DEFAULT ('') FOR [Remark]
GO
ALTER TABLE [dbo].[CheckBillDetail] ADD  CONSTRAINT [DF_CheckBillDetail_CheckBillGuid]  DEFAULT ('') FOR [CheckBillGuid]
GO
ALTER TABLE [dbo].[CheckBillDetail] ADD  CONSTRAINT [DF_CheckBillDetail_MaterialGuid]  DEFAULT ('') FOR [MaterialGuid]
GO
ALTER TABLE [dbo].[CheckBillDetail] ADD  CONSTRAINT [DF_CheckBillDetail_MaterialId]  DEFAULT ('') FOR [MaterialId]
GO
ALTER TABLE [dbo].[CheckBillDetail] ADD  CONSTRAINT [DF_CheckBillDetail_MaterialName]  DEFAULT ('') FOR [MaterialName]
GO
ALTER TABLE [dbo].[CheckBillDetail] ADD  CONSTRAINT [DF_CheckBillDetail_BarNo]  DEFAULT ('') FOR [BarNo]
GO
ALTER TABLE [dbo].[CheckBillDetail] ADD  CONSTRAINT [DF_CheckBillDetail_Spec]  DEFAULT ('') FOR [Spec]
GO
ALTER TABLE [dbo].[CheckBillDetail] ADD  CONSTRAINT [DF_CheckBillDetail_Unit]  DEFAULT ('') FOR [Unit]
GO
ALTER TABLE [dbo].[CheckBillDetail] ADD  CONSTRAINT [DF_CheckBillDetail_Price]  DEFAULT ((0)) FOR [Price]
GO
ALTER TABLE [dbo].[CheckBillDetail] ADD  CONSTRAINT [DF_CheckBillDetail_SurplusQty]  DEFAULT ((0)) FOR [SurplusQty]
GO
ALTER TABLE [dbo].[CheckBillDetail] ADD  CONSTRAINT [DF_CheckBillDetail_DeficientQty]  DEFAULT ((0)) FOR [DeficientQty]
GO
ALTER TABLE [dbo].[CheckBillDetail] ADD  CONSTRAINT [DF_CheckBillDetail_Total]  DEFAULT ((0)) FOR [Total]
GO
ALTER TABLE [dbo].[CheckBillDetail] ADD  CONSTRAINT [DF_CheckBillDetail_Remark]  DEFAULT ('') FOR [Remark]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_ClientName]  DEFAULT ('') FOR [Name]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_SimpName]  DEFAULT ('') FOR [SimpName]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_LinkMan]  DEFAULT ('') FOR [LinkMan]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_Telephone]  DEFAULT ('') FOR [Telephone]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_Fax]  DEFAULT ('') FOR [Fax]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_Address]  DEFAULT ('') FOR [Address]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_Zip]  DEFAULT ('') FOR [Zip]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_Remark]  DEFAULT ('') FOR [Remark]
GO
ALTER TABLE [dbo].[Depot] ADD  CONSTRAINT [DF_Depot_DepotGuid]  DEFAULT ('') FOR [DepotGuid]
GO
ALTER TABLE [dbo].[Depot] ADD  CONSTRAINT [DF_Depot_DepotName]  DEFAULT ('') FOR [DepotName]
GO
ALTER TABLE [dbo].[Depot] ADD  CONSTRAINT [DF_Depot_DepotPerson]  DEFAULT ('') FOR [DepotPerson]
GO
ALTER TABLE [dbo].[Depot] ADD  CONSTRAINT [DF_Depot_Telephone]  DEFAULT ('') FOR [Telephone]
GO
ALTER TABLE [dbo].[Depot] ADD  CONSTRAINT [DF_Depot_Remark]  DEFAULT ('') FOR [Remark]
GO
ALTER TABLE [dbo].[Dept] ADD  CONSTRAINT [DF_Dept_DeptName]  DEFAULT ('') FOR [DeptName]
GO
ALTER TABLE [dbo].[Dept] ADD  CONSTRAINT [DF_Dept_DeptPerson]  DEFAULT ('') FOR [DeptPerson]
GO
ALTER TABLE [dbo].[Dept] ADD  CONSTRAINT [DF_Dept_Telephone]  DEFAULT ('') FOR [Telephone]
GO
ALTER TABLE [dbo].[Dept] ADD  CONSTRAINT [DF_Dept_Fax]  DEFAULT ('') FOR [Fax]
GO
ALTER TABLE [dbo].[Dept] ADD  CONSTRAINT [DF_Dept_Address]  DEFAULT ('') FOR [Address]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_EmpGuid]  DEFAULT ('') FOR [EmpGuid]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_EmpID]  DEFAULT ('') FOR [EmpID]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_EmpName]  DEFAULT ('') FOR [EmpName]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_Sex]  DEFAULT ('') FOR [Sex]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_Telephone]  DEFAULT ('') FOR [Telephone]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_Address]  DEFAULT ('') FOR [Address]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_CardID]  DEFAULT ('') FOR [CardID]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_Dept]  DEFAULT ('') FOR [Dept]
GO
ALTER TABLE [dbo].[LoginUser] ADD  CONSTRAINT [DF_LoginUser_USERID]  DEFAULT ('') FOR [USERID]
GO
ALTER TABLE [dbo].[LoginUser] ADD  CONSTRAINT [DF_LoginUser_USERNAME]  DEFAULT ('') FOR [USERNAME]
GO
ALTER TABLE [dbo].[LoginUser] ADD  CONSTRAINT [DF_LoginUser_EMAIL]  DEFAULT ('') FOR [EMAIL]
GO
ALTER TABLE [dbo].[LoginUser] ADD  CONSTRAINT [DF_LoginUser_PASSWORD]  DEFAULT ('') FOR [PASSWORD]
GO
ALTER TABLE [dbo].[Material] ADD  CONSTRAINT [DF_Material_MaterialId]  DEFAULT ('') FOR [MaterialId]
GO
ALTER TABLE [dbo].[Material] ADD  CONSTRAINT [DF_Material_MateriaName]  DEFAULT ('') FOR [MaterialName]
GO
ALTER TABLE [dbo].[Material] ADD  CONSTRAINT [DF_Material_ClassId]  DEFAULT ('') FOR [ClassId]
GO
ALTER TABLE [dbo].[Material] ADD  CONSTRAINT [DF_Material_Spec]  DEFAULT ('') FOR [Spec]
GO
ALTER TABLE [dbo].[Material] ADD  CONSTRAINT [DF_Material_Unit]  DEFAULT ('') FOR [Unit]
GO
ALTER TABLE [dbo].[Material] ADD  CONSTRAINT [DF_Material_BarNo]  DEFAULT ('') FOR [BarNo]
GO
ALTER TABLE [dbo].[Material] ADD  CONSTRAINT [DF_Material_Place]  DEFAULT ('') FOR [Place]
GO
ALTER TABLE [dbo].[Material] ADD  CONSTRAINT [DF_Material_Encapsulation]  DEFAULT ('') FOR [Encapsulation]
GO
ALTER TABLE [dbo].[Material] ADD  CONSTRAINT [DF_Material_UpperLimit]  DEFAULT ((0)) FOR [UpperLimit]
GO
ALTER TABLE [dbo].[Material] ADD  CONSTRAINT [DF_Material_LowerLimit]  DEFAULT ((0)) FOR [LowerLimit]
GO
ALTER TABLE [dbo].[Material] ADD  CONSTRAINT [DF_Material_IConsultPrice]  DEFAULT ((0)) FOR [IConsultPrice]
GO
ALTER TABLE [dbo].[Material] ADD  CONSTRAINT [DF_Material_EConsultPrice]  DEFAULT ((0)) FOR [EConsultPrice]
GO
ALTER TABLE [dbo].[Material] ADD  CONSTRAINT [DF_Material_CalculateMethod]  DEFAULT ('') FOR [CalculateMethod]
GO
ALTER TABLE [dbo].[Material] ADD  CONSTRAINT [DF_Material_Note]  DEFAULT ('') FOR [Remark]
GO
ALTER TABLE [dbo].[Module] ADD  CONSTRAINT [DF_Module_ModuleName]  DEFAULT ('') FOR [ModuleName]
GO
ALTER TABLE [dbo].[Module] ADD  CONSTRAINT [DF_Module_sortid]  DEFAULT ((0)) FOR [sortid]
GO
ALTER TABLE [dbo].[RemoveBill] ADD  CONSTRAINT [DF_RemoveBill_DepotOut]  DEFAULT ('') FOR [DepotOut]
GO
ALTER TABLE [dbo].[RemoveBill] ADD  CONSTRAINT [DF_RemoveBill_DepotIn]  DEFAULT ('') FOR [DepotIn]
GO
ALTER TABLE [dbo].[RemoveBill] ADD  CONSTRAINT [DF_RemoveBill_HandlePerson]  DEFAULT ('') FOR [HandlePerson]
GO
ALTER TABLE [dbo].[RemoveBill] ADD  CONSTRAINT [DF_RemoveBill_BillID]  DEFAULT ('') FOR [BillID]
GO
ALTER TABLE [dbo].[RemoveBill] ADD  CONSTRAINT [DF_RemoveBill_BillAutoID]  DEFAULT ('') FOR [BillAutoID]
GO
ALTER TABLE [dbo].[RemoveBill] ADD  CONSTRAINT [DF_RemoveBill_CreatePerson]  DEFAULT ('') FOR [CreatePerson]
GO
ALTER TABLE [dbo].[RemoveBill] ADD  CONSTRAINT [DF_RemoveBill_CreateDate]  DEFAULT ('') FOR [CreateDate]
GO
ALTER TABLE [dbo].[RemoveBill] ADD  CONSTRAINT [DF_RemoveBill_CheckPerson]  DEFAULT ('') FOR [CheckPerson]
GO
ALTER TABLE [dbo].[RemoveBill] ADD  CONSTRAINT [DF_RemoveBill_CheckDate]  DEFAULT ('') FOR [CheckDate]
GO
ALTER TABLE [dbo].[RemoveBill] ADD  CONSTRAINT [DF_RemoveBill_Remark]  DEFAULT ('') FOR [Remark]
GO
ALTER TABLE [dbo].[RemoveBillDetail] ADD  CONSTRAINT [DF_RemoveBillDetail_RemoveBillGuid]  DEFAULT ('') FOR [RemoveBillGuid]
GO
ALTER TABLE [dbo].[RemoveBillDetail] ADD  CONSTRAINT [DF_RemoveBillDetail_MaterialGuid]  DEFAULT ('') FOR [MaterialGuid]
GO
ALTER TABLE [dbo].[RemoveBillDetail] ADD  CONSTRAINT [DF_RemoveBillDetail_MaterialId]  DEFAULT ('') FOR [MaterialId]
GO
ALTER TABLE [dbo].[RemoveBillDetail] ADD  CONSTRAINT [DF_RemoveBillDetail_MaterialName]  DEFAULT ('') FOR [MaterialName]
GO
ALTER TABLE [dbo].[RemoveBillDetail] ADD  CONSTRAINT [DF_RemoveBillDetail_BarNo]  DEFAULT ('') FOR [BarNo]
GO
ALTER TABLE [dbo].[RemoveBillDetail] ADD  CONSTRAINT [DF_RemoveBillDetail_Spec]  DEFAULT ('') FOR [Spec]
GO
ALTER TABLE [dbo].[RemoveBillDetail] ADD  CONSTRAINT [DF_RemoveBillDetail_Unit]  DEFAULT ('') FOR [Unit]
GO
ALTER TABLE [dbo].[RemoveBillDetail] ADD  CONSTRAINT [DF_RemoveBillDetail_Price]  DEFAULT ((0)) FOR [Price]
GO
ALTER TABLE [dbo].[RemoveBillDetail] ADD  CONSTRAINT [DF_RemoveBillDetail_Qty]  DEFAULT ((0)) FOR [Qty]
GO
ALTER TABLE [dbo].[RemoveBillDetail] ADD  CONSTRAINT [DF_RemoveBillDetail_Total]  DEFAULT ((0)) FOR [Total]
GO
ALTER TABLE [dbo].[RemoveBillDetail] ADD  CONSTRAINT [DF_RemoveBillDetail_Remark]  DEFAULT ('') FOR [Remark]
GO
ALTER TABLE [dbo].[StorageClass] ADD  CONSTRAINT [DF_StorageClass_InterID]  DEFAULT ('') FOR [InterID]
GO
ALTER TABLE [dbo].[StorageClass] ADD  CONSTRAINT [DF_StorageClass_InterName]  DEFAULT ('') FOR [InterName]
GO
ALTER TABLE [dbo].[StorageClass] ADD  CONSTRAINT [DF_StorageClass_FatherID]  DEFAULT ('') FOR [FatherID]
GO
ALTER TABLE [dbo].[StorageClass] ADD  CONSTRAINT [DF_StorageClass_AllFatherName]  DEFAULT ('') FOR [AllFatherName]
GO
ALTER TABLE [dbo].[StorageClass] ADD  CONSTRAINT [DF_StorageClass_OrderNo]  DEFAULT ((0)) FOR [OrderNo]
GO
ALTER TABLE [dbo].[StorageClass] ADD  CONSTRAINT [DF_StorageClass_IsVisable]  DEFAULT ((0)) FOR [IsVisable]
GO
ALTER TABLE [dbo].[StorageClass] ADD  CONSTRAINT [DF_StorageClass_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[StorageType] ADD  CONSTRAINT [DF_StorageType_StorageTypeGuid]  DEFAULT ('') FOR [StorageTypeID]
GO
ALTER TABLE [dbo].[StorageType] ADD  CONSTRAINT [DF_StorageType_StorageTypeName]  DEFAULT ('') FOR [StorageTypeName]
GO
ALTER TABLE [dbo].[StorageType] ADD  CONSTRAINT [DF_StorageType_Flag]  DEFAULT ('') FOR [Flag]
GO
ALTER TABLE [dbo].[Supplier] ADD  CONSTRAINT [DF_Supplier_SupplierGuId]  DEFAULT ('') FOR [Guid]
GO
ALTER TABLE [dbo].[Supplier] ADD  CONSTRAINT [DF_Supplier_SupplierName]  DEFAULT ('') FOR [Name]
GO
ALTER TABLE [dbo].[Supplier] ADD  CONSTRAINT [DF_Supplier_SimpName]  DEFAULT ('') FOR [SimpName]
GO
ALTER TABLE [dbo].[Supplier] ADD  CONSTRAINT [DF_Supplier_LinkMan]  DEFAULT ('') FOR [LinkMan]
GO
ALTER TABLE [dbo].[Supplier] ADD  CONSTRAINT [DF_Supplier_Telephone]  DEFAULT ('') FOR [Telephone]
GO
ALTER TABLE [dbo].[Supplier] ADD  CONSTRAINT [DF_Supplier_Fax]  DEFAULT ('') FOR [Fax]
GO
ALTER TABLE [dbo].[Supplier] ADD  CONSTRAINT [DF_Supplier_Address]  DEFAULT ('') FOR [Address]
GO
ALTER TABLE [dbo].[Supplier] ADD  CONSTRAINT [DF_Supplier_Zip]  DEFAULT ('') FOR [Zip]
GO
ALTER TABLE [dbo].[Supplier] ADD  CONSTRAINT [DF_Supplier_Remark]  DEFAULT ('') FOR [Remark]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_UserID]  DEFAULT ('') FOR [UserID]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_lkdgl]  DEFAULT ('') FOR [lkdgl]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_lkdxz]  DEFAULT ('') FOR [lkdxz]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_lkdsh]  DEFAULT ('') FOR [lkdsh]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_lkdmxb]  DEFAULT ('') FOR [lkdmxb]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_lkdhzb]  DEFAULT ('') FOR [lkdhzb]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_lkdgl1]  DEFAULT ('') FOR [ckdgl]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_lkdxz1]  DEFAULT ('') FOR [ckdxz]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_lkdsh1]  DEFAULT ('') FOR [ckdsh]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_lkdmxb1]  DEFAULT ('') FOR [ckdmxb]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_lkdhzb1]  DEFAULT ('') FOR [ckdhzb]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_dbdgl]  DEFAULT ('') FOR [dbdgl]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_dbdxz]  DEFAULT ('') FOR [dbdxz]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_dbzsh]  DEFAULT ('') FOR [dbzsh]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_bmsfmxb]  DEFAULT ('') FOR [bmsfmxb]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_sfchzb]  DEFAULT ('') FOR [sfchzb]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_sflxhzb]  DEFAULT ('') FOR [sflxhzb]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_chmxz]  DEFAULT ('') FOR [chmxz]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_kcpd]  DEFAULT ('') FOR [kcpd]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_kcpdxz]  DEFAULT ('') FOR [kcpdxz]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_kcpdsh]  DEFAULT ('') FOR [kcpdsh]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_hp]  DEFAULT ('') FOR [hp]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_ck]  DEFAULT ('') FOR [ck]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_kh]  DEFAULT ('') FOR [kh]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_gys]  DEFAULT ('') FOR [gys]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_yg]  DEFAULT ('') FOR [yg]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_bm]  DEFAULT ('') FOR [bm]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_yhgl]  DEFAULT ('') FOR [yhgl]
GO
ALTER TABLE [dbo].[UserRight] ADD  CONSTRAINT [DF_UserRight_qxgl]  DEFAULT ('') FOR [qxgl]
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllDepotSum]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
   功能：各仓库汇总表

*/
CREATE   PROCEDURE [dbo].[sp_GetAllDepotSum]
@MaterialGuid        nvarchar(50),
@BeginDate nvarchar(20),
@EndDate      nvarchar(20)
AS
                               declare @strCreateTable nvarchar(2000)
                              declare @DepotName   nvarchar(50)
                              declare @intvalue int 
                              declare  @strFieldname_en nvarchar(30)
                             declare  @strFieldname_cn nvarchar(30)
                              declare @strMaterialGuid    nvarchar(50)
                             declare @strMaterialName    nvarchar(50)
                            declare @strSpec    nvarchar(50)
                            declare @strBarNo    nvarchar(50)
                                declare @InQty      decimal(9,2)
                               declare @OutQty   decimal(9,2)
                               declare @RemoveInQty   decimal(9,2)
                               declare @RemoveOutQty    decimal(9,2)
                               declare @DepotQty   decimal(9,2)
                               declare @SInQty   decimal(9,2)
                               declare @SOutQty   decimal(9,2)
                                declare  @InSUM    decimal(9,2)
                                  declare  @OutSUM    decimal(9,2)
		      declare @strSql  nvarchar(2000)
                               declare  @InOutSUM    decimal(9,2)
                           
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[tempMaterialINOUT]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
begin
     drop table [dbo].[tempMaterialINOUT]
end
              set  @intvalue=1
                    Create Table  #tempDepot ( noid      int   IDENTITY (1, 1) NOT NULL,
				          FieldName_en   nvarchar(50)  default '',
                                                                          FieldName_cn   nvarchar(50)  default '')
                SET QUOTED_IDENTIFIER OFF  
	 --创建临时表：存放汇总结果表
               set  @strCreateTable='  Create Table  tempMaterialINOUT ( noid      int   IDENTITY (1, 1) NOT NULL,MaterialGuid   nvarchar(50)  default null,MaterialName  nvarchar(50)  default null,BarNo   nvarchar(50) default  null,Spec  nvarchar(50)  default  null '
                            declare curMaterialINOUT   cursor    FOR      select   DepotName   from depot where   ltrim(rtrim(remark))='1'  order by   convert(int,telephone) 
                            open curMaterialINOUT   fetch next from  curMaterialINOUT    INTO   @DepotName
		while @@fetch_status = 0 
		begin 
                                                      
                                           set  @strCreateTable=@strCreateTable+' ,['+@DepotName+'收入]   nvarchar(30)  default ''''' 
    		                           set  @strCreateTable=@strCreateTable+' ,['+@DepotName+'发出]   nvarchar(30)  default ''''' 
    			                  set  @strCreateTable=@strCreateTable+' ,['+@DepotName+'结存]   nvarchar(30)  default ''''' 
                                         fetch next from curMaterialINOUT   INTO       @DepotName
                                end
		         set  @strCreateTable=@strCreateTable+')'
                                    close curMaterialINOUT
		         deallocate curMaterialINOUT  
                                   exec (@strCreateTable)
                         print     @strCreateTable
        --    exec ('select * from tempMaterialINOUT')
            
               
                                  -----将数据放入到表中
                                  declare  @strSqL2 nvarchar(2000)
                                  declare  @strSqL3 nvarchar(500)
                                  set  @strSqL2=''
                                 
                            declare curField2   cursor    FOR      select   MaterialGuid,MaterialName,Spec,BarNo from Material   where   MaterialGuid like @MaterialGuid+'%'
                            open curField2   fetch next from  curField2    INTO   @strMaterialGuid,@strMaterialName,@strSpec,@strBarNo
		 while @@fetch_status = 0 
		 begin 
                                              set @strSqL2=''
                                              set   @strSqL2='insert into  tempMaterialINOUT(MaterialGuid,MaterialName,BarNo,Spec) values('''+@strMaterialGuid+''','''+@strMaterialName+''','''+@strBarNo+''','''+@strSpec+''')'
                                              exec(@strSqL2)
                                              fetch next from curField2   INTO    @strMaterialGuid,@strMaterialName,@strSpec,@strBarNo
                             end
                                    close curField2
		         deallocate curField2  
  
 
                      -- exec('select   *    from   tempMaterialINOUT ')
                              --计算每个货品在各个仓库中的数量
                            declare  curDepotSum   cursor    FOR      select   MaterialGuid    from Material   where  MaterialGuid like @MaterialGuid+'%'
                            open     curDepotSum   fetch next from  curDepotSum    INTO   @strMaterialGuid
		 while @@fetch_status = 0 
		 begin 
                                                       
                                                         declare curMaterialINOUT1   cursor    FOR      select   DepotName   from depot  where   ltrim(rtrim(remark))='1'  order by   convert(int,telephone) 
		                              open curMaterialINOUT1   fetch next from  curMaterialINOUT1    INTO   @DepotName
				  while @@fetch_status = 0 
				  begin 
		                                                      
                                                                                
		                                                        
		 				 ---------计算当前日期中间的本期料件收入---------------------------------------------------------------------------------------------------------------------
		                                                      set @InQty=0
		                                                      --算出当前料件全部的入库数量与金额   @InQty=sum(Qty),@InTotal=sum(Total) 
		                                                     select   @InQty=sum(Qty)
		                                                                                from V_InDepotDetail   where      DepotGuid=@DepotName     and  MaterialGuID=@strMaterialGuid 
				                                                                       and    billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
		                                                                                                      group by MaterialGuID  
		
		
		                                                      --算出调拨进的料件数量
		     		                        set  @RemoveInQty=0
		                                                   
		
					             --计算调拨单调入数量  @RemoveInQty=sum(Qty),@RemoveInTotal=sum(Total)
						select     @RemoveInQty=sum(Qty)
						     from V_RemoveBill  where   DepotIn=@DepotName     and   MaterialGuID=@strMaterialGuid    and    billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
						                            group by MaterialGuID
		
		                                                            set  @SInQty=0
		                                                 
		
		
						--计算出盘盈的数量与金额
						  select  @SInQty=sum(SurplusQty)
						                from   V_CheckBill  
						               where  SurplusQty>0 and MaterialGuid=@strMaterialGuid    and  Depot=@DepotName      and    billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
						                Group by MaterialGuid
		
		
		  				   --将最后的本期收入值更新到临时表中
     						    set @InSUM=@InQty+@RemoveInQty+@SInQty 
                                                                                   set @strSql='update  tempMaterialINOUT  set       ['+@DepotName+'收入]='+convert(nvarchar(20),@InSUM)+'   where     MaterialGuID='''+@strMaterialGuid+''''
 					                 exec (@strSql)
		
		                                               ---------计算当前日期中间的本期料件发出---------------------------------------------------------------------------------------------------------------------
		                                                      set @OutQty=0
		                                                  
		                                                       --算出当前料件全部的出库数量与金额
		                                                     select    @OutQty=sum(Qty)
		                                                                                from V_OutDepotDetail   where    DepotGuid=@DepotName   and   MaterialGuID=@strMaterialGuid    and    billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
		                                                                                                       group by MaterialGuID 
		
		                                                            set  @RemoveOutQty=0
		                                                      
		                                                                 --计算调拨单调出数量
		           				select  @RemoveOutQty=sum(Qty)
						     from V_RemoveBill  where  MaterialGuID=@strMaterialGuid   and  DepotOut=@DepotName     and    billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
						                            group by MaterialGuID
		
		
		
		                                                            set  @SOutQty =0
		                                                    
						--计算出盘亏的数量与金额
		                                                                  select  @SOutQty=sum(DeficientQty)
						                from   V_CheckBill  
						               where  DeficientQty>0 and MaterialGuid=@strMaterialGuid  and  Depot=@DepotName      and    billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
						                Group by MaterialGuid
		
		
		                                                                  --将最后的本期发出值更新到临时表中
				                             
		                                                        set @OutSUM=@OutQty+@RemoveOutQty+@SOutQty
                                                                                   set @strSql='update  tempMaterialINOUT  set       ['+@DepotName+'发出]='+convert(nvarchar(20),@OutSUM)+'   where     MaterialGuID='''+@strMaterialGuid+''''
 					                 exec (@strSql)
                                                                                    
					                --结存
                                                                                     set @InOutSUM=@InSUM-@OutSUM
                                                                                   set @strSql='update  tempMaterialINOUT  set       ['+@DepotName+'结存]='+convert(nvarchar(20),@InOutSUM)+'   where     MaterialGuID='''+@strMaterialGuid+''''
 					                 exec (@strSql)
--print @DepotName
    
                                                       		fetch next from curMaterialINOUT1   INTO       @DepotName
		                           	     end
	
		                                    close curMaterialINOUT1
				         deallocate curMaterialINOUT1  
                                              fetch next from curDepotSum   INTO    @strMaterialGuid
                             end
                                    close curDepotSum
		         deallocate curDepotSum  
                                  exec('select   *    from   tempMaterialINOUT ')
                                  exec('drop table  tempMaterialINOUT')
                                 drop table #tempDepot
                                SET QUOTED_IDENTIFIER on
GO
/****** Object:  StoredProcedure [dbo].[sp_GetDepotClassDetailSum]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
/*
   功能： 收发存汇总表
             计算当前仓库的库存（已经包括了调拨单）
  日期 :   2009-06-08
  修改： 修改了算法，提升了速度，是原来的好几倍速度

  日期：2009-07-27
  修改：修改了本期收入中不算盘盈的，本期发出中不减盘亏的，最后本期结存=上期结存+本期收入-本期支出+本月盘盈-本月盘亏

  日期：2011-1-4
  修改：修改了物料单价的计算，是为了计算出最后的金额.
*/
CREATE   PROCEDURE [dbo].[sp_GetDepotClassDetailSum]
@BeginDate nvarchar(20),
@EndDate      nvarchar(20),
@Depot          varchar(50),
@BarNo       varchar(50),
@MaterialID       varchar(50),
@MaterialName       varchar(50),
@Spec       varchar(50),
@ClassID   varchar(50)
AS

                           
                                --如果统计的是：原材料与辅料则按 规格排序显示出来
            if (substring(@ClassID,1,1)='2' or  substring(@ClassID,1,1)='3' )  
               begin
                                                  
                                  select   Material.MaterialGuid,Material.MaterialID,Material.MaterialName,Material.Spec ,
			convert(decimal(18,2),P1.StartQtySum)  as StartQtySum ,
			--case P1.StartQtySum  when 0 then  0  else   convert(decimal(18,2),P1.StartTotalSum)  end as StartTotalSum,
                                                 case P1.StartQtySum  when 0 then  0  else   convert(decimal(18,2),QP.BeginPrice*P1.StartQtySum)  end as StartTotalSum,
			 convert(decimal(18,2),P2.InQtySum) as InQtySum,
                                              case P2.InQtySum  when 0 then  0  else    convert(decimal(18,2),P2.InTotalSum)  end as InTotalSum,
			 convert(decimal(18,2),P3.OutQtySum) as OutQtySum,
                                              case P3.OutQtySum  when 0 then  0  else   convert(decimal(18,2),P3.OutTotalSum) end as OutTotalSum,
			convert(decimal(18,2),(   P1.StartQtySum+ P2.InQtySum- P3.OutQtySum+P2.SInQty111-P3.SOutQty111)) as DepotQtySum,
                                                 convert(decimal(18,2),(   P1.StartQtySum+ P2.InQtySum- P3.OutQtySum+P2.SInQty111-P3.SOutQty111)) * AllPrice  as DepotTotalSum
                                           --                                                 case P1.StartQtySum+ P2.InQtySum  when 0 then  0  else    ( convert(decimal(18,2),P1.StartTotalSum)+ convert(decimal(18,2),P2.InTotalSum))/(convert(decimal(18,2),P1.StartQtySum)+ convert(decimal(18,2),P2.InQtySum))*convert(decimal(18,2),(   P1.StartQtySum+ P2.InQtySum- P3.OutQtySum+P2.SInQty111-P3.SOutQty111))   end as DepotTotalSum    
                                             --  case (   P1.StartQtySum+ P2.InQtySum- P3.OutQtySum+P2.SInTotal111-P3.SOutTotal111)  when 0 then  0  else  convert(decimal(18,2),(   P1.StartTotalSum+P2.InTotalSum- P3.OutTotalSum+P2.SInTotal111-P3.SOutTotal111))  end as DepotTotalSum    
                                    from  Material   
                                  left join
                                   (            --计算所有入库金额的单价，总金额/数量-----计算本期结余
	                                   select MaterialGuid,case when  sum(Qty)=0  then 0 else  (sum(Total) /sum(Qty))  end  AllPrice
		                 from  V_InDepotDetail 
		                 where   DepotGuid =@Depot   and   billdate<@EndDate +'  00:00:00'
		                 Group by MaterialGuid,DepotGuid      

                                   )  AP on AP.MaterialGuid=Material.MaterialGuid
                                    left join
                                   (            --计算所有入库金额的单价，总金额/数量-----计算期初
	                                   select MaterialGuid,case when  sum(Qty)=0  then 0 else  (sum(Total) /sum(Qty))  end  BeginPrice
		                 from  V_InDepotDetail 
		                 where   DepotGuid =@Depot   and      billdate<@BeginDate +'  00:00:00'
		                 Group by MaterialGuid,DepotGuid      

                                   )  QP  on QP.MaterialGuid=Material.MaterialGuid
                                  left join  (       --计算期初结存
                                                      
        				 select   M.MaterialGuid,M.MaterialID,M.MaterialName,M.Spec,
                                                                        (isnull(BIn.InQty,0)+isnull(Bremovein.RemoveInQty,0)+isnull(Bsin.SInQty1,0)-isnull(Bout.OutQty,0)-isnull(Bremoveout.RemoveOutQty,0)-isnull(Bsout.SOutQty1,0)) as  StartQtySum,
                                                                        (isnull(BIn.InTotal,0)+isnull(Bremovein.RemoveInTotal,0)+isnull(Bsin.SInTotal1,0)-isnull(Bout.OutTotal,0)-isnull(Bremoveout.RemoveOutTotal,0)-isnull(Bsout.SOutTotal1,0)) as  StartTotalSum
                                                                         from  Material      M 
                                                        left join 
                                                             (
                                                                    select  MaterialGuID, sum(Qty) as InQty ,sum(Total)  as InTotal   from V_InDepotDetail   
                                                                                where   DepotGuid=@Depot         and     billdate<@BeginDate +'  00:00:00'
                                                                                           group by MaterialGuID 
                                                               )   BIn     On  M.MaterialGuID=BIn.MaterialGuID
                                                          left join 
                                                                (  
                                                                          select   MaterialGuID, sum(Qty)  as OutQty,  sum(Total)   as OutTotal
                                                                                from V_OutDepotDetail   where     depotGuid=@Depot  and      billdate<@BeginDate +'  00:00:00'
                                                                                         group by MaterialGuID 
                                                                 )  Bout    On  M.MaterialGuID=Bout.MaterialGuID
                                                                left join 
                                                                (  
                                                                            select  MaterialGuID,  sum(Qty) as RemoveInQty,sum(Total)  as RemoveInTotal
				                             from V_RemoveBill  where      DepotIn=@Depot     and     billdate<@BeginDate +'  00:00:00'
				                                          group by MaterialGuID

                                                                 )  Bremovein    On  M.MaterialGuID=Bremovein.MaterialGuID

                                                                  left join 
                                                                (  
                                                                     select      MaterialGuID, sum(Qty) as RemoveOutQty,sum(Total)  as RemoveOutTotal
				                                 from V_RemoveBill  where     DepotOut=@Depot     and     billdate<@BeginDate +'  00:00:00'
				                                group by MaterialGuID

                                                                 )  Bremoveout    On  M.MaterialGuID=Bremoveout.MaterialGuID

                                                                left join 
                                                                (  
                                                                     select   MaterialGuID,  sum(SurplusQty) as  SInQty1,sum(Total)  as SInTotal1
				                          from   V_CheckBill  
				                                  where  SurplusQty>0  and  Depot=@Depot       and    billdate<@BeginDate +'  00:00:00'
				                                          Group by MaterialGuid

 					)  Bsin    On  M.MaterialGuID=Bsin.MaterialGuID
                                                                    left join 
                                                                (  
                                                                      select   MaterialGuID, sum(DeficientQty)  as SOutQty1,sum(Total)  as SOutTotal1
				                       from   V_CheckBill  
				                      where  DeficientQty>0     and  Depot=@Depot       and    billdate<@BeginDate +'  00:00:00'
				                         Group by MaterialGuid
 
 					)  Bsout    On  M.MaterialGuID=Bsout.MaterialGuID



                                              )   P1   on  P1.MaterialGuid=Material.MaterialGuid
                                                  left join  (       --计算本期收入
                                                      
        				 select   M.MaterialGuid,M.MaterialID,M.MaterialName,M.Spec,
                                                                        (isnull(BIn.InQty,0)+isnull(Bremovein.RemoveInQty,0) ) as  InQtySum,              --+isnull(Bsin.SInQty1,0)) as  InQtySum,     
                                                                        (isnull(BIn.InTotal,0)+isnull(Bremovein.RemoveInTotal,0) ) as  InTotalSum,   --+isnull(Bsin.SInTotal1,0)) as  InTotalSum
                                                                       isnull(Bsin.SInQty1,0) as  SInQty111,
                                                                      isnull(Bsin.SInTotal1,0) as SInTotal111
                                                                         from  Material      M 
                                                        left join 
                                                             (
                                                                    select  MaterialGuID, sum(Qty) as InQty ,sum(Total)  as InTotal   from V_InDepotDetail   
                                                                                where   DepotGuid=@Depot         and      billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
                                                                                           group by MaterialGuID 
                                                               )   BIn     On  M.MaterialGuID=BIn.MaterialGuID
                                                                left join 
                                                                (  
                                                                            select  MaterialGuID,  sum(Qty) as RemoveInQty,sum(Total)  as RemoveInTotal
				                             from V_RemoveBill  where      DepotIn=@Depot     and     billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
				                                          group by MaterialGuID

                                                                 )  Bremovein    On  M.MaterialGuID=Bremovein.MaterialGuID
                                                                left join 
                                                                (  
                                                                     select   MaterialGuID,  sum(SurplusQty) as  SInQty1,sum(Total)  as SInTotal1
				                          from   V_CheckBill  
				                                  where  SurplusQty>0  and  Depot=@Depot       and   billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
				                                          Group by MaterialGuid

 					)  Bsin    On  M.MaterialGuID=Bsin.MaterialGuID
                                              )   P2   on  P2.MaterialGuid=Material.MaterialGuid

                                            left join  (       --计算本期发出
                                                      
        				 select   M.MaterialGuid,M.MaterialID,M.MaterialName,M.Spec,
                                                                        (isnull(Bout.OutQty,0)+isnull(Bremoveout.RemoveOutQty,0)  ) as  OutQtySum,                 --+isnull(Bsout.SOutQty1,0)) as  OutQtySum,
                                                                        (isnull(Bout.OutTotal,0)+isnull(Bremoveout.RemoveOutTotal,0) ) as  OutTotalSum,          --+isnull(Bsout.SOutTotal1,0)) as  OutTotalSum
                                                                        isnull(Bsout.SOutQty1,0) as  SOutQty111,
                                                                        isnull(Bsout.SOutTotal1,0) as SOutTotal111
                                                                         from  Material      M 
                                                          left join 
                                                                (  
                                                                          select   MaterialGuID, sum(Qty)  as OutQty,  sum(Total)   as OutTotal
                                                                                from V_OutDepotDetail   where     depotGuid=@Depot  and     billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
                                                                                         group by MaterialGuID 
                                                                 )  Bout    On  M.MaterialGuID=Bout.MaterialGuID
                                                                  left join 
                                                                (  
                                                                     select      MaterialGuID, sum(Qty) as RemoveOutQty,sum(Total)  as RemoveOutTotal
				                                 from V_RemoveBill  where     DepotOut=@Depot     and     billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
				                                group by MaterialGuID

                                                                 )  Bremoveout    On  M.MaterialGuID=Bremoveout.MaterialGuID
                                                                    left join 
                                                                (  
                                                                      select   MaterialGuID, sum(DeficientQty)  as SOutQty1,sum(Total)  as SOutTotal1
				                       from   V_CheckBill  
				                      where  DeficientQty>0     and  Depot=@Depot       and    billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
				                         Group by MaterialGuid
 
 					)  Bsout    On  M.MaterialGuID=Bsout.MaterialGuID



                                              )   P3   on  P3.MaterialGuid=Material.MaterialGuid
                       
                                    where  Material.ClassID like  @ClassID+'%'    and     Material.BarNo like  @BarNo+'%'  and  Material.MaterialID like  @MaterialID+'%'    and  Material.MaterialName like  @MaterialName+'%'   and  Material.Spec like  @Spec+'%'
                                      order by  Material.Spec         
                     end
              else 
                  begin
                                              
                                  select   Material.MaterialGuid,Material.MaterialID,Material.MaterialName,Material.Spec ,
			convert(decimal(18,2),P1.StartQtySum)  as StartQtySum ,
			--case P1.StartQtySum  when 0 then  0  else   convert(decimal(18,2),P1.StartTotalSum)  end as StartTotalSum,
                                                 case P1.StartQtySum  when 0 then  0  else   convert(decimal(18,2),QP.BeginPrice*P1.StartQtySum)  end as StartTotalSum,
			 convert(decimal(18,2),P2.InQtySum) as InQtySum,
                                              case P2.InQtySum  when 0 then  0  else    convert(decimal(18,2),P2.InTotalSum)  end as InTotalSum,
			 convert(decimal(18,2),P3.OutQtySum) as OutQtySum,
                                              case P3.OutQtySum  when 0 then  0  else   convert(decimal(18,2),P3.OutTotalSum) end as OutTotalSum,
			convert(decimal(18,2),(   P1.StartQtySum+ P2.InQtySum- P3.OutQtySum+P2.SInQty222-P3.SOutQty222)) as DepotQtySum,
                                                 convert(decimal(18,2),(   P1.StartQtySum+ P2.InQtySum- P3.OutQtySum+P2.SInQty222-P3.SOutQty222))  * AllPrice  as DepotTotalSum
                                              --  case P1.StartQtySum+ P2.InQtySum  when 0 then  0  else    ( convert(decimal(18,2),P1.StartTotalSum)+ convert(decimal(18,2),P2.InTotalSum))/(convert(decimal(18,2),P1.StartQtySum)+ convert(decimal(18,2),P2.InQtySum))*convert(decimal(18,2),(   P1.StartQtySum+ P2.InQtySum- P3.OutQtySum+P2.SInQty222-P3.SOutQty222))   end as DepotTotalSum    
                                              -- case (   P1.StartQtySum+ P2.InQtySum- P3.OutQtySum+P2.SInTotal222-P3.SOutTotal222)  when 0 then  0  else  convert(decimal(18,2),(   P1.StartTotalSum+P2.InTotalSum- P3.OutTotalSum+P2.SInTotal222-P3.SOutTotal222))  end as DepotTotalSum    
                                  from  Material   
                                  left join
                                   (            --计算所有入库金额的单价，总金额/数量
	                                   select MaterialGuid,case when  sum(Qty)=0  then 0 else  (sum(Total) /sum(Qty))  end  AllPrice
		                 from  V_InDepotDetail 
		                 where   DepotGuid =@Depot   and   billdate<@EndDate +'  00:00:00'
		                 Group by MaterialGuid,DepotGuid      

                                   )  AP on AP.MaterialGuid=Material.MaterialGuid
                                  left join
                                   (            --计算所有入库金额的单价，总金额/数量-----计算期初
	                                   select MaterialGuid,case when  sum(Qty)=0  then 0 else  (sum(Total) /sum(Qty))  end  BeginPrice
		                 from  V_InDepotDetail 
		                 where   DepotGuid =@Depot   and      billdate<@BeginDate +'  00:00:00'
		                 Group by MaterialGuid,DepotGuid      

                                   )  QP  on QP.MaterialGuid=Material.MaterialGuid
                                  left join  (       --计算期初结存
                                                      
        				 select   M.MaterialGuid,M.MaterialID,M.MaterialName,M.Spec,
                                                                        (isnull(BIn.InQty,0)+isnull(Bremovein.RemoveInQty,0)+isnull(Bsin.SInQty1,0)-isnull(Bout.OutQty,0)-isnull(Bremoveout.RemoveOutQty,0)-isnull(Bsout.SOutQty1,0)) as  StartQtySum,
                                                                        (isnull(BIn.InTotal,0)+isnull(Bremovein.RemoveInTotal,0)+isnull(Bsin.SInTotal1,0)-isnull(Bout.OutTotal,0)-isnull(Bremoveout.RemoveOutTotal,0)-isnull(Bsout.SOutTotal1,0)) as  StartTotalSum
                                                                         from  Material      M 
                                                        left join 
                                                             (
                                                                    select  MaterialGuID, sum(Qty) as InQty ,sum(Total)  as InTotal   from V_InDepotDetail   
                                                                                where   DepotGuid=@Depot         and     billdate<@BeginDate +'  00:00:00'
                                                                                           group by MaterialGuID 
                                                               )   BIn     On  M.MaterialGuID=BIn.MaterialGuID
                                                          left join 
                                                                (  
                                                                          select   MaterialGuID, sum(Qty)  as OutQty,  sum(Total)   as OutTotal
                                                                                from V_OutDepotDetail   where     depotGuid=@Depot  and      billdate<@BeginDate +'  00:00:00'
                                                                                         group by MaterialGuID 
                                                                 )  Bout    On  M.MaterialGuID=Bout.MaterialGuID
                                                                left join 
                                                                (  
                                                                            select  MaterialGuID,  sum(Qty) as RemoveInQty,sum(Total)  as RemoveInTotal
				                             from V_RemoveBill  where      DepotIn=@Depot     and     billdate<@BeginDate +'  00:00:00'
				                                          group by MaterialGuID

                                                                 )  Bremovein    On  M.MaterialGuID=Bremovein.MaterialGuID

                                                                  left join 
                                                                (  
                                                                     select      MaterialGuID, sum(Qty) as RemoveOutQty,sum(Total)  as RemoveOutTotal
				                                 from V_RemoveBill  where     DepotOut=@Depot     and     billdate<@BeginDate +'  00:00:00'
				                                group by MaterialGuID

                                                                 )  Bremoveout    On  M.MaterialGuID=Bremoveout.MaterialGuID

                                                                left join 
                                                                (  
                                                                     select   MaterialGuID,  sum(SurplusQty) as  SInQty1,sum(Total)  as SInTotal1
				                          from   V_CheckBill  
				                                  where  SurplusQty>0  and  Depot=@Depot       and    billdate<@BeginDate +'  00:00:00'
				                                          Group by MaterialGuid

 					)  Bsin    On  M.MaterialGuID=Bsin.MaterialGuID
                                                                    left join 
                                                                (  
                                                                      select   MaterialGuID, sum(DeficientQty)  as SOutQty1,sum(Total)  as SOutTotal1
				                       from   V_CheckBill  
				                      where  DeficientQty>0     and  Depot=@Depot       and    billdate<@BeginDate +'  00:00:00'
				                         Group by MaterialGuid
 
 					)  Bsout    On  M.MaterialGuID=Bsout.MaterialGuID



                                              )   P1   on  P1.MaterialGuid=Material.MaterialGuid
                                                  left join  (       --计算本期收入
                                                      
        				 select   M.MaterialGuid,M.MaterialID,M.MaterialName,M.Spec,
                                                                        (isnull(BIn.InQty,0)+isnull(Bremovein.RemoveInQty,0) ) as  InQtySum,   --+isnull(Bsin.SInQty1,0)) as  InQtySum,
                                                                        (isnull(BIn.InTotal,0)+isnull(Bremovein.RemoveInTotal,0) ) as  InTotalSum,   --+isnull(Bsin.SInTotal1,0)) as  InTotalSum
                                                                        isnull(Bsin.SInQty1,0) as  SInQty222,
                                                                       isnull(Bsin.SInTotal1,0) as SInTotal222
                                                                         from  Material      M 
                                                        left join 
                                                             (
                                                                    select  MaterialGuID, sum(Qty) as InQty ,sum(Total)  as InTotal   from V_InDepotDetail   
                                                                                where   DepotGuid=@Depot         and      billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
                                                                                           group by MaterialGuID 
                                                               )   BIn     On  M.MaterialGuID=BIn.MaterialGuID
                                                                left join 
                                                                (  
                                                                            select  MaterialGuID,  sum(Qty) as RemoveInQty,sum(Total)  as RemoveInTotal
				                             from V_RemoveBill  where      DepotIn=@Depot     and     billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
				                                          group by MaterialGuID

                                                                 )  Bremovein    On  M.MaterialGuID=Bremovein.MaterialGuID
                                                                left join 
                                                                (  
                                                                     select   MaterialGuID,  sum(SurplusQty) as  SInQty1,sum(Total)  as SInTotal1
				                          from   V_CheckBill  
				                                  where  SurplusQty>0  and  Depot=@Depot       and   billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
				                                          Group by MaterialGuid

 					)  Bsin    On  M.MaterialGuID=Bsin.MaterialGuID
                                              )   P2   on  P2.MaterialGuid=Material.MaterialGuid

                                            left join  (       --计算本期发出
                                                      
        				 select   M.MaterialGuid,M.MaterialID,M.MaterialName,M.Spec,
                                                                        (isnull(Bout.OutQty,0)+isnull(Bremoveout.RemoveOutQty,0)   ) as  OutQtySum,     --+isnull(Bsout.SOutQty1,0)) as  OutQtySum,
                                                                        (isnull(Bout.OutTotal,0)+isnull(Bremoveout.RemoveOutTotal,0) ) as  OutTotalSum,       --+isnull(Bsout.SOutTotal1,0)) as  OutTotalSum
                                                                         isnull(Bsout.SOutQty1,0) as  SOutQty222,
                                                                        isnull(Bsout.SOutTotal1,0) as SOutTotal222
                                                                         from  Material      M 
                                                          left join 
                                                                (  
                                                                          select   MaterialGuID, sum(Qty)  as OutQty,  sum(Total)   as OutTotal
                                                                                from V_OutDepotDetail   where     depotGuid=@Depot  and     billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
                                                                                         group by MaterialGuID 
                                                                 )  Bout    On  M.MaterialGuID=Bout.MaterialGuID
                                                                  left join 
                                                                (  
                                                                     select      MaterialGuID, sum(Qty) as RemoveOutQty,sum(Total)  as RemoveOutTotal
				                                 from V_RemoveBill  where     DepotOut=@Depot     and     billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
				                                group by MaterialGuID

                                                                 )  Bremoveout    On  M.MaterialGuID=Bremoveout.MaterialGuID
                                                                    left join 
                                                                (  
                                                                      select   MaterialGuID, sum(DeficientQty)  as SOutQty1,sum(Total)  as SOutTotal1
				                       from   V_CheckBill  
				                      where  DeficientQty>0     and  Depot=@Depot       and    billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
				                         Group by MaterialGuid
 
 					)  Bsout    On  M.MaterialGuID=Bsout.MaterialGuID



                                              )   P3   on  P3.MaterialGuid=Material.MaterialGuid
                       
                                    where  Material.ClassID like  @ClassID+'%'    and     Material.BarNo like  @BarNo+'%'  and  Material.MaterialID like  @MaterialID+'%'    and  Material.MaterialName like  @MaterialName+'%'   and  Material.Spec like  @Spec+'%'
                                      order by  Material.MaterialName

                                      end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetDepotClassTypeDetailSum]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
/*
   功能： 收发类型汇总表
             计算当前仓库的库存（已经包括了调拨单）
  日期 :   2008-11-25
*/
CREATE   PROCEDURE [dbo].[sp_GetDepotClassTypeDetailSum]
@BeginDate nvarchar(20),
@EndDate      nvarchar(20),
@Depot          varchar(50),
@BarNo       varchar(50),
@MaterialID       varchar(50),
@MaterialName       varchar(50),
@Spec       varchar(50),
@ClassID    varchar(50)
AS
             
	 --创建临时表：存放收发类型汇总结果
	  Create Table #tempReportDetail
	             (
	                 noid      int   default 0,  --序号
                                 MaterialGuID          nvarchar(50)  default '',  --guid
		 MaterialID            nvarchar(50)  default '',  --货号
		 MaterialName     nvarchar(100)  default '',	 --品名
		 Spec      	  nvarchar(20)  default '',	 --规格
		 StartQtySum       decimal(18,6)  default 0,	 --期初结存数量
		 StartTotalSum    decimal(18,6)  default 0,	 --期初结存金额
                                 InQtySum          decimal(18,6)  default 0,	 --本期入库数量
		 InTotalSum      decimal(18,6)  default 0,	 --本期入库金额
                                 OutQtySum       decimal(18,6)  default 0,	 --本期出库数量
		 OutTotalSum     decimal(18,6)  default 0,	 --本期出库金额
                                 RemoveInQtySum           decimal(18,6)  default 0,	 --本期拨入数量
		 RemoveInTotalSum     decimal(18,6)  default 0,	 --本期拨入金额
                                 RemoveOutQtySum        decimal(18,6)  default 0,	 --本期拨出数量
		 RemoveOutTotalSum    decimal(18,6)  default 0,	 --本期拨出金额
                                SurplusQtySum           decimal(18,6)  default 0,	 --本期盘盈数量
		SurplusTotalSum      decimal(18,6)  default 0,	 --本期盘盈金额
                                DeficientQtySum        decimal(18,6)  default 0,	 --本期盘亏数量
		DeficientTotalSum    decimal(18,6)  default 0,	 --本期盘亏金额
                                 DepotQtySum       decimal(18,6)  default 0,           --期末结存数量
		 DepotTotalSum      decimal(18,6)  default 0         --期末结存金额
	              )
           
                               declare  @intValue  int   --序号
                               declare @strMaterialGuid   nvarchar(50)   --料件guid
                                declare @strMaterialID   nvarchar(50)   --货号
                               declare @strMaterialName   nvarchar(50)   --料件名称
                               declare @strSpec   nvarchar(50)   --规格
                                 
                               declare @InQty       decimal(18,6)
                               declare @OutQty    decimal(18,6)
                               declare @RemoveInQty   decimal(18,6)
                               declare @RemoveOutQty    decimal(18,6)
                               declare @InTotal     decimal(18,6)
                               declare @OutTotal    decimal(18,6)
                               declare @RemoveInTotal    decimal(18,6)
                               declare @RemoveOutTotal    decimal(18,6)
                               declare @DepotQty    decimal(18,6)
                               declare @DepotTotal   decimal(18,6)
                             
                                  declare @SurplusQtySum        decimal(18,6)                --本期盘盈数量
		   declare @SurplusTotalSum     decimal(18,6)  --本期盘盈金额
                                 declare  @DeficientQtySum       decimal(18,6)                     --本期盘亏数量
		   declare @DeficientTotalSum    decimal(18,6)   --本期盘亏金额
                                    declare @SurplusQtySum1        decimal(18,6)                --本期盘盈数量
		   declare @SurplusTotalSum1     decimal(18,6)  --本期盘盈金额
                                 declare  @DeficientQtySum1       decimal(18,6)                     --本期盘亏数量
		   declare @DeficientTotalSum1    decimal(18,6)   --本期盘亏金额
                              set @intValue=1
                                 --定义光标，对所有料件表进行循环读取料件
                                  declare curDepot   cursor    FOR     
                                                                       select   MaterialGuid,MaterialID,MaterialName,Spec 
                                                                                     from  Material   
                                                                                    where  ClassID like @ClassID+'%'  and  BarNo like  @BarNo+'%'  and  MaterialID like  @MaterialID+'%'    and  MaterialName like  @MaterialName+'%'   and  Spec like  @Spec+'%'
                                                                           
                                 open curDepot   fetch next from  curDepot    INTO    @strMaterialGuid,@strMaterialID,@strMaterialName,@strSpec
		while @@fetch_status = 0 
		begin 
                                                   insert   into #tempReportDetail(noid,MaterialGuID,MaterialID,MaterialName,Spec,StartQtySum,StartTotalSum,InQtySum,InTotalSum,OutQtySum,OutTotalSum,
                                                                                     RemoveInQtySum,RemoveInTotalSum,RemoveOutQtySum,RemoveOutTotalSum,SurplusQtySum,SurplusTotalSum,DeficientQtySum,DeficientTotalSum,
                                                                                      DepotQtySum,DepotTotalSum)
                                                                                  values( @intValue,@strMaterialGuid, @strMaterialID,@strMaterialName,@strSpec, 0,0,0,0,0,0,0,0, 0,0,0,0,0,0,0,0)                             
                                                   ----------计算当前日期前的期初结存---------------------------------------------------------------------------------------------------------------------
                                                     set @InQty=0
                                                     set @InTotal=0
                                                      --算出当前料件全部的入库数量与金额   @InQty=sum(Qty),@InTotal=sum(Total) 
                                                     select   @InQty=sum(Qty),@InTotal=sum(Total) 
                                                                                from V_InDepotDetail   where   DepotGuid=@Depot     and     MaterialGuID=@strMaterialGuid
		                                                                         and     billdate<@BeginDate +'  00:00:00'
                                                                                                       group by MaterialGuID 
   			     set @OutQty=0
                                                     set @OutTotal=0
                                                       --算出当前料件全部的出库数量与金额
                                                     select    @OutQty=sum(Qty),@OutTotal=sum(Total) 
                                                                                from V_OutDepotDetail   where    DepotGuid=@Depot     and    MaterialGuID=@strMaterialGuid
                                                                                                  and   depotGuid=@Depot
		                                                                  and      billdate<@BeginDate +'  00:00:00'
                                                                                                       group by MaterialGuID 
                                                        --算出调拨进的料件数量
     		                        set  @RemoveInQty=0
                                                         set @RemoveInTotal =0
			             --计算调拨单调入数量  @RemoveInQty=sum(Qty),@RemoveInTotal=sum(Total)
				select     @RemoveInQty=sum(Qty),@RemoveInTotal=sum(Total)
				     from V_RemoveBill  where    MaterialGuID=@strMaterialGuid  and   DepotIn=@Depot     and     billdate<@BeginDate +'  00:00:00'
				                            group by MaterialGuID
                                                             set  @RemoveOutQty=0
                                                            set  @RemoveOutTotal =0
                                                                 --计算调拨单调出数量
           				select  @RemoveOutQty=sum(Qty),@RemoveOutTotal=sum(Total)
				     from V_RemoveBill  where  MaterialGuID=@strMaterialGuid  and  DepotOut=@Depot     and     billdate<@BeginDate +'  00:00:00'
				                            group by MaterialGuID
                                                   set  @SurplusQtySum1=0
			   set  @SurplusTotalSum1=0
			    --盘盈数量与金额
                                                         select   @SurplusQtySum1=sum(SurplusQty),@SurplusTotalSum1=sum(Total) 
                                                                                from V_CheckBill   where   Depot=@Depot     and     MaterialGuID=@strMaterialGuid
		                                                                        and  billdate<@BeginDate +'  00:00:00'
					                           and    SurplusQty<>0
                                                                                                       group by MaterialGuID 
                                                    --盘亏数量与金额
                                                   set   @DeficientQtySum1=0
			   set  @DeficientTotalSum1=0
  			    select   @DeficientQtySum1=sum(DeficientQty),@DeficientTotalSum1=sum(Total) 
                                                                                from V_CheckBill   where   Depot=@Depot     and     MaterialGuID=@strMaterialGuid
		                                                                            and  billdate<@BeginDate +'  00:00:00'
					                           and    DeficientQty<>0
                                                                                                       group by MaterialGuID 
                                                           --计算实际结存
			            set   @DepotQty=0
                                                            set   @DepotTotal=0
                                                            set   @DepotQty=@InQty+@RemoveInQty+@SurplusQtySum1-@OutQty-@RemoveOutQty-@DeficientQtySum1
                                                            set   @DepotTotal=@InTotal+@RemoveInTotal+@SurplusTotalSum1-@OutTotal-@RemoveOutTotal-@DeficientTotalSum1
                                               
		                               --将最后的计算结存值更新到临时表中
                                                                  if @DepotQty<>0
		                                       update  #tempReportDetail  set       StartQtySum=@DepotQty,StartTotalSum= @DepotTotal       where     MaterialGuID=@strMaterialGuid
                                                                 else
		                                       update  #tempReportDetail  set       StartQtySum=0,StartTotalSum= 0       where     MaterialGuID=@strMaterialGuid
                                               ---------计算当前日期中间的本期料件收入---------------------------------------------------------------------------------------------------------------------
                                                      set @InQty=0
                                                     set @InTotal=0
                                                      --算出当前料件全部的入库数量与金额   @InQty=sum(Qty),@InTotal=sum(Total) 
                                                     select   @InQty=sum(Qty),@InTotal=sum(Total) 
                                                                                from V_InDepotDetail   where   DepotGuid=@Depot     and     MaterialGuID=@strMaterialGuid
		                                                                       and    billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
                                                                                                       group by MaterialGuID 
                                                      --算出调拨进的料件数量
     		                        set  @RemoveInQty=0
                                                         set @RemoveInTotal =0
			             --计算调拨单调入数量  @RemoveInQty=sum(Qty),@RemoveInTotal=sum(Total)
				select     @RemoveInQty=sum(Qty),@RemoveInTotal=sum(Total)
				     from V_RemoveBill  where    MaterialGuID=@strMaterialGuid  and   DepotIn=@Depot    and    billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
				                            group by MaterialGuID
  				   --将最后的本期收入值更新到临时表中
		                                update  #tempReportDetail  set       InQtySum=@InQty,InTotalSum= @InTotal    ,
								   RemoveInQtySum=@RemoveInQty,RemoveInTotalSum=@RemoveInTotal
 					   where     MaterialGuID=@strMaterialGuid
                                               ---------计算当前日期中间的本期料件发出---------------------------------------------------------------------------------------------------------------------
                                                      set @OutQty=0
                                                     set @OutTotal=0
                                                       --算出当前料件全部的出库数量与金额
                                                     select    @OutQty=sum(Qty),@OutTotal=sum(Total) 
                                                                                from V_OutDepotDetail   where    DepotGuid=@Depot     and    MaterialGuID=@strMaterialGuid
                                                                                                  and   depotGuid=@Depot
		                                                                 and    billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
                                                                                                       group by MaterialGuID 
                                                            set  @RemoveOutQty=0
                                                            set  @RemoveOutTotal =0
                                                                 --计算调拨单调出数量
           				select  @RemoveOutQty=sum(Qty),@RemoveOutTotal=sum(Total)
				     from V_RemoveBill  where  MaterialGuID=@strMaterialGuid  and  DepotOut=@Depot    and    billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
				                            group by MaterialGuID
                                                                  --将最后的本期发出值更新到临时表中
		                                update  #tempReportDetail  set       OutQtySum=@OutQty,OutTotalSum= @OutTotal   ,
								      RemoveOutQtySum=@RemoveOutQty,RemoveOutTotalSum=@RemoveOutTotal
								    where     MaterialGuID=@strMaterialGuid
                                              ---------计算本期盘盈盘亏数量与金额---------------------------------------------------------------------------------------------------------------------
	                                   set  @SurplusQtySum=0
			   set  @SurplusTotalSum=0
			    --盘盈数量与金额
                                                         select   @SurplusQtySum=sum(SurplusQty),@SurplusTotalSum=sum(Total) 
                                                                                from V_CheckBill   where   Depot=@Depot     and     MaterialGuID=@strMaterialGuid
		                                                                           and    billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
					                           and    SurplusQty<>0
                                                                                                       group by MaterialGuID 
                                                    --盘亏数量与金额
                                                   set   @DeficientQtySum=0
			   set  @DeficientTotalSum=0
  			    select   @DeficientQtySum=sum(DeficientQty),@DeficientTotalSum=sum(Total) 
                                                                                from V_CheckBill   where   Depot=@Depot     and     MaterialGuID=@strMaterialGuid
		                                                                           and    billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
					                           and    DeficientQty<>0
                                                                                                       group by MaterialGuID 
	                                    --将盘盈盘亏值更新到临时表中
		                       update  #tempReportDetail  set      
                                                                       SurplusQtySum=@SurplusQtySum,SurplusTotalSum= @SurplusTotalSum,DeficientQtySum=@DeficientQtySum,DeficientTotalSum=@DeficientTotalSum
                                                                            where     MaterialGuID=@strMaterialGuid
                                            ---------计算当前日期中间的期末结存---------------------------------------------------------------------------------------------------------------------
                                          /*            set @InQty=0
                                                     set @InTotal=0
                                                      --算出当前料件全部的入库数量与金额   @InQty=sum(Qty),@InTotal=sum(Total) 
                                                     select   @InQty=sum(Qty),@InTotal=sum(Total) 
                                                                                from V_InDepotDetail   where   DepotGuid=@Depot     and     MaterialGuID=@strMaterialGuid
		                                                                           and    billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
                                                                                                       group by MaterialGuID 
   			     set @OutQty=0
                                                     set @OutTotal=0
                                                       --算出当前料件全部的出库数量与金额
                                                     select    @OutQty=sum(Qty),@OutTotal=sum(Total) 
                                                                                from V_OutDepotDetail   where    DepotGuid=@Depot     and    MaterialGuID=@strMaterialGuid
                                                                                                  and   depotGuid=@Depot
		                                                                    and    billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
                                                                                                       group by MaterialGuID 
                                                        --算出调拨进的料件数量
     		                        set  @RemoveInQty=0
                                                         set @RemoveInTotal =0
			             --计算调拨单调入数量  @RemoveInQty=sum(Qty),@RemoveInTotal=sum(Total)
				select     @RemoveInQty=sum(Qty),@RemoveInTotal=sum(Total)
				     from V_RemoveBill  where    MaterialGuID=@strMaterialGuid  and   DepotIn=@Depot       and    billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
				                            group by MaterialGuID
                                                             set  @RemoveOutQty=0
                                                            set  @RemoveOutTotal =0
                                                                 --计算调拨单调出数量
           				select  @RemoveOutQty=sum(Qty),@RemoveOutTotal=sum(Total)
				     from V_RemoveBill  where  MaterialGuID=@strMaterialGuid  and  DepotOut=@Depot       and    billdate>=@BeginDate +' 00:00:00'  and  billdate<=@EndDate +'  23:59:59'
				                            group by MaterialGuID
                                                  */
                                                           --计算实际结存
			                  --set   @DepotQty=0
                                                          --  set   @DepotTotal=0
                                                            set   @DepotQty=@DepotQty+@InQty+@RemoveInQty-@OutQty-@RemoveOutQty+@SurplusQtySum-@DeficientQtySum
                                                            set   @DepotTotal=@DepotTotal+@InTotal+@RemoveInTotal-@OutTotal-@RemoveOutTotal+@SurplusTotalSum-@DeficientTotalSum
                                               
		                               --将最后的计算结存值更新到临时表中
                                                               if (@DepotQty<>0)
		                                      update  #tempReportDetail  set       DepotQtySum=@DepotQty,DepotTotalSum= @DepotTotal       where     MaterialGuID=@strMaterialGuid
                                                               else
                                                                       update  #tempReportDetail  set       DepotQtySum=0,DepotTotalSum= 0       where     MaterialGuID=@strMaterialGuid
	                           set  @intValue=@intValue+1					
	                           fetch next from curDepot   INTO    @strMaterialGuid,@strMaterialID,@strMaterialName,@strSpec
	                end
	
	                  close curDepot
		   deallocate curDepot
                               select * from #tempReportDetail
                                 /*
                                            select noid,MaterialGuID,MaterialID,MaterialName,Spec,
                                                               case when StartQtySum=0 then '' else StartQtySum  end as StartQtySum, 
				case when StartTotalSum=0.00  then '' else StartTotalSum  end as StartTotalSum, 
				case when InQtySum=0 then '' else InQtySum  end as InQtySum, 
				case when InTotalSum=0.00 then '' else InTotalSum  end as InTotalSum, 
				case when OutQtySum=0 then '' else OutQtySum  end as OutQtySum, 
				case when OutTotalSum=0.00 then '' else OutTotalSum  end as OutTotalSum, 
				case when RemoveInQtySum=0 then '' else RemoveInQtySum  end as RemoveInQtySum, 
				case when RemoveInTotalSum=0.00 then '' else RemoveInTotalSum  end as RemoveInTotalSum, 
				case when RemoveOutQtySum=0 then '' else RemoveOutQtySum  end as RemoveOutQtySum, 
				case when RemoveOutTotalSum=0.00 then '' else RemoveOutTotalSum  end as RemoveOutTotalSum, 
				case when SurplusQtySum=0 then '' else SurplusQtySum  end as SurplusQtySum, 
				case when SurplusTotalSum=0.00 then '' else SurplusTotalSum  end as SurplusTotalSum, 
				case when DeficientQtySum=0 then '' else DeficientQtySum  end as DeficientQtySum, 
				case when DeficientTotalSum=0.00 then '' else DeficientTotalSum  end as DeficientTotalSum, 
				case when DepotQtySum=0 then '' else DepotQtySum  end as DepotQtySum, 
				case when DepotTotalSum=0.00 then '' else DepotTotalSum  end as DepotTotalSum
                                              from #tempReportDetail
                                       */
drop table  #tempReportDetail
GO
/****** Object:  StoredProcedure [dbo].[sp_GetDepotDetailSum]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
   功能：库存查询
            计算当前仓库的库存（已经包括了调拨单）
  日期 :   2008-11-24
*/
CREATE   PROCEDURE [dbo].[sp_GetDepotDetailSum]
@WhereSql  varchar(500),
@WhereSql2  varchar(500),
@WhereSql3  varchar(500),
@Depot varchar(50),
@WhereSql4  varchar(100),
@WhereSql5   varchar(200)
AS
declare @strsql varchar(8000)
set @strsql='  SET QUOTED_IDENTIFIER OFF  
select S.MaterialGuID,S.MaterialID,S.BarNo,S.MaterialName,S.Spec,S.Unit,
 S.Qty , case when  S.Qty=0 then 0 when  S.Qty   <> 0  then convert(decimal(18,6),( S.Total/S.Qty)) end as Price,case when  S.Qty=0  then 0  else   S.Total  end as  Total
  from 
(
  select P.MaterialGuID,P.MaterialID,P.BarNo,P.MaterialName,P.Spec,P.Unit,
   (isnull(P.Qty,0)+isnull(InDepot.Qty,0)-isnull(OutDepot.Qty,0) + isnull(SINDepot.Qty,0)- isnull(SOUTDepot.Qty,0)) as Qty 
   ,(isnull(P.Total,0)+isnull(InDepot.Total,0)-isnull(OutDepot.Total,0)+ isnull(SINDepot.Total,0)- isnull(SOUTDepot.Total,0)) as Total
 
from 
(
        --计算出当前仓库的库存（不包括调拨）
	select mat.MaterialGuID,mat.MaterialID,mat.BarNo,mat.MaterialName,mat.Spec,mat.Unit,isnull(Qty,0) Qty,"'+@Depot+'" as depot,
	   case when Qty=0 then 0 when Qty is null then 0 when Qty <> 0 then convert(decimal(9,2),(Total/Qty)) end as Price,
	   isnull(Total,0) Total
	from Material mat
	left join 
	(
	 
		select InD.MaterialGuID,(isnull(InD.Qty,0)-isnull(OutD.Qty,0)) as Qty
	               ,(isnull(InD.Total,0)-isnull(OutD.Total,0)) as Total
		from
		(
                                    select m.MaterialGuID,isnull(Qty,0)  as Qty,isnull(Total,0) as Total
                                               from   Material m left join  (
		                                        select MaterialGuID,BarNo,MaterialName,Spec,Unit,sum(Qty) as Qty
		                                        ,sum(Total) as Total from V_ALLDepotDetail   where BillGuid is not null and flag="I"  ' +@WhereSql+'
		                                          group by MaterialGuID,BarNo,MaterialName,Spec,Unit)  PI
                                              on   m.MaterialGuID= PI. MaterialGuID
		 ) InD
		left join 
		(
                                        select m.MaterialGuID,isnull(Qty,0)   as Qty,isnull(Total,0) as Total
                                                  from   Material m left join  (
		                                    select MaterialGuID,BarNo,MaterialName,Spec,Unit,sum(Qty) as Qty
		                                                ,sum(Total) as Total from V_ALLDepotDetail   where BillGuid is not null and flag="E"  '+@WhereSql+'
		                                                 group by MaterialGuID,BarNo,MaterialName,Spec,Unit  ) PE
                                           on   m.MaterialGuID= PE. MaterialGuID
		) OutD on  InD.MaterialGuID=OutD.MaterialGuID
	        
	) InOutD
	on mat.MaterialGuID=InOutD.MaterialGuID where 1=1  '+@WhereSql4+'  
)  P
left join 
(            --计算调拨单调入数量
	select MaterialGuID,MaterialName,DepotIn,sum(Qty) as Qty,sum(Total) as Total
	     from V_RemoveBill  where 1=1 '+@WhereSql2+'
	          group by MaterialGuID,MaterialName,DepotIn  
) InDepot
on  p.MaterialGuID=InDepot.MaterialGuID and p.depot=InDepot.DepotIn
left join 
(        --计算调拨单调出数量
       select MaterialGuID,MaterialName,DepotOut ,sum(Qty) as Qty,sum(Total) as Total
	     from V_RemoveBill where   1=1 '+@WhereSql3+'
	          group by MaterialGuID,MaterialName,DepotOut 
) OutDepot
on  p.MaterialGuID=OutDepot.MaterialGuID and p.depot=OutDepot.DepotOut
left join 
(        --计算盘盈数量
 select  MaterialGuid,MaterialName,Depot,sum(SurplusQty) as Qty,sum(Total) as Total  
                from   V_CheckBill  
               where  SurplusQty>0  '+@WhereSql5+'
                Group by MaterialGuid,MaterialName,Depot 
 )  SINDepot  On  p.MaterialGuID=SINDepot.MaterialGuID and p.depot=SINDepot.Depot
left join 
(        --计算盘亏数量
 select  MaterialGuid,MaterialName,Depot,sum(DeficientQty) as Qty,sum(Total) as Total  
                from   V_CheckBill  
               where  DeficientQty>0  '+@WhereSql5+'
                Group by MaterialGuid,MaterialName,Depot 
 )  SOUTDepot  On  p.MaterialGuID=SOUTDepot.MaterialGuID and p.depot=SOUTDepot.Depot
)  S
'
exec(@strsql)
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[sp_GetDepotMaterialDetailSum]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
/*
   功能：存货明细账
             计算当前仓库的库存（已经包括了调拨单）
  日期 :   2008-11-26
*/
CREATE   PROCEDURE [dbo].[sp_GetDepotMaterialDetailSum]
@Depot          nvarchar(50),
@MaterialID      nvarchar(50)
AS
       
    
             
	 --创建临时表：存放收发存汇总结果
	  Create Table #tempMaterialDetail
	             (
	                 noid      int   IDENTITY (1, 1) NOT NULL ,  --序号
                                 MBillGuid nvarchar(50)  default '' , 
                                 BillGuid  nvarchar(50)  default '' , 
                                 BillDate  datetime default null,
                                 StorageTypeGuid    nvarchar(50)  default '' , 
                                 Flag     nvarchar(10)  default '' ,
		MaterialGuid nvarchar(50)  default '' , 
		InQty decimal(18,2) default 0,
		InPrice decimal(18,6) default 0,
		InTotal  decimal(18,6)  default 0 , 
		OutQty  decimal(18,2)  default 0,
		OutPrice decimal(18,6) default 0,
		OutTotal  decimal(9,2) default 0,
		DepotQty  decimal(18,2)  default 0,
		DepotPrice  decimal(18,6) default 0,
		DepotTotal  decimal(18,6) default 0
	              )
              
	  insert into  #tempMaterialDetail (MBillGuid,BillGuid,BillDate,StorageTypeGuid,Flag,MaterialGuid,InQty,InPrice,InTotal,OutQty,OutPrice,OutTotal,DepotQty,DepotPrice,DepotTotal)
                      select  * from
                      (
                        --插入出入库数据
                      -- insert into  #tempMaterialDetail (BillGuid,BillDate,StorageTypeGuid,Flag,MaterialGuid,InQty,InPrice,InTotal,OutQty,OutPrice,OutTotal,DepotQty,DepotPrice,DepotTotal)
                                    SELECT    dbo.BillDetail.BillDetailGuid ,dbo.Bill.BillGuid, dbo.Bill.BillDate, dbo.Bill.StorageTypeGuid, dbo.Bill.Flag, dbo.BillDetail.MaterialGuid,
			      dbo.BillDetail.Qty as InQty, dbo.BillDetail.Price as InPrice, dbo.BillDetail.Total as  InTotal,
			       '0' as OutQty,'0' as OutPrice,'0' as OutTotal,'0' as DepotQty,'0' as DepotPrice,'0' as DepotTotal
			FROM dbo.Bill left OUTER JOIN
			      dbo.BillDetail ON dbo.Bill.BillGuid = dbo.BillDetail.BillGuid 
			where dbo.Bill.Flag='I'   and  dbo.Bill.DepotGuid=@Depot   and   dbo.BillDetail.MaterialGuid=@MaterialID
			union 
			SELECT  dbo.BillDetail.BillDetailGuid ,dbo.Bill.BillGuid, dbo.Bill.BillDate, dbo.Bill.StorageTypeGuid, dbo.Bill.Flag,  dbo.BillDetail.MaterialGuid,
			       '0' as InQty,'0' as InPrice,'0' as InTotal,
			       dbo.BillDetail.Qty as OutQty, dbo.BillDetail.Price as OutPrice, dbo.BillDetail.Total as  OutTotal,
			      '0' as DepotQty,'0' as DepotPrice,'0' as DepotTotal
			FROM dbo.Bill left OUTER JOIN
			      dbo.BillDetail ON dbo.Bill.BillGuid = dbo.BillDetail.BillGuid 
			where dbo.Bill.Flag='E'     and  dbo.Bill.DepotGuid=@Depot  and   dbo.BillDetail.MaterialGuid=@MaterialID 
		union   
                       --插入调拨数据
                     -- insert into  #tempMaterialDetail (BillGuid,BillDate,StorageTypeGuid,Flag,MaterialGuid,InQty,InPrice,InTotal,OutQty,OutPrice,OutTotal,DepotQty,DepotPrice,DepotTotal)
			SELECT dbo.RemoveBillDetail.RemoveBillDetailGuid,dbo.RemoveBill.RemoveBillGuid, dbo.RemoveBill.BillDate,'调入' as RemoveIn, 'RI' as flag , 
			      dbo.RemoveBillDetail.MaterialGuid,
			      dbo.RemoveBillDetail.Qty, dbo.RemoveBillDetail.Price, dbo.RemoveBillDetail.Total,
			      '0' as OutQty,'0' as OutPrice,'0' as OutTotal,'0' as DepotQty,'0' as DepotPrice,'0' as DepotTotal
			       
			FROM  dbo.RemoveBill left OUTER JOIN
			      dbo.RemoveBillDetail ON 
			      dbo.RemoveBill.RemoveBillGuid = dbo.RemoveBillDetail.RemoveBillGuid  where DepotIn=@Depot  and    dbo.RemoveBillDetail.MaterialGuid=@MaterialID
			union
			SELECT dbo.RemoveBillDetail.RemoveBillDetailGuid,dbo.RemoveBill.RemoveBillGuid, dbo.RemoveBill.BillDate,'调出' as RemoveIn, 'RE' as flag , 
			      dbo.RemoveBillDetail.MaterialGuid,
			       '0' as InQty,'0' as InPrice,'0' as InTotal,
			        dbo.RemoveBillDetail.Qty, dbo.RemoveBillDetail.Price, dbo.RemoveBillDetail.Total,
			      '0' as DepotQty,'0' as DepotPrice,'0' as DepotTotal
			FROM dbo.RemoveBill left OUTER JOIN
			      dbo.RemoveBillDetail ON 
			      dbo.RemoveBill.RemoveBillGuid = dbo.RemoveBillDetail.RemoveBillGuid  where DepotOut=@Depot  and  dbo.RemoveBillDetail.MaterialGuid=@MaterialID
                                       
 		union 
                         --插入盘盈盘亏数据
                           --  insert into  #tempMaterialDetail (BillGuid,BillDate,StorageTypeGuid,Flag,MaterialGuid,InQty,InPrice,InTotal,OutQty,OutPrice,OutTotal,DepotQty,DepotPrice,DepotTotal)
			SELECT  dbo.CheckBillDetail.CheckBillDetailGuid,dbo.CheckBill.CheckBillGuid, dbo.CheckBill.BillDate, '盘盈' as SurplusIn,'SI' as flag, 
			      dbo.CheckBillDetail.MaterialGuid, 
			      dbo.CheckBillDetail.SurplusQty, dbo.CheckBillDetail.Price, dbo.CheckBillDetail.Total,
			      '0' as OutQty,'0' as OutPrice,'0' as OutTotal,'0' as DepotQty,'0' as DepotPrice,'0' as DepotTotal
			FROM dbo.CheckBill left OUTER JOIN
			      dbo.CheckBillDetail ON 
			      dbo.CheckBill.CheckBillGuid = dbo.CheckBillDetail.CheckBillGuid
                                                where     dbo.CheckBillDetail.SurplusQty>0 and    dbo.CheckBill.Depot=@Depot  and   dbo.CheckBillDetail.MaterialGuid=@MaterialID
			union
			SELECT dbo.CheckBillDetail.CheckBillDetailGuid,dbo.CheckBill.CheckBillGuid, dbo.CheckBill.BillDate, '盘亏' as SurplusIn,'SE' as flag, 
			    dbo.CheckBillDetail.MaterialGuid, 
			      '0' as InQty,'0' as InPrice,'0' as InTotal,
			         dbo.CheckBillDetail.DeficientQty, dbo.CheckBillDetail.Price,  dbo.CheckBillDetail.Total,
			      '0' as DepotQty,'0' as DepotPrice,'0' as DepotTotal
			FROM dbo.CheckBill left OUTER JOIN
			      dbo.CheckBillDetail ON 
			      dbo.CheckBill.CheckBillGuid = dbo.CheckBillDetail.CheckBillGuid
   			   where       dbo.CheckBillDetail.DeficientQty>0 and   dbo.CheckBill.Depot=@Depot  and   dbo.CheckBillDetail.MaterialGuid=@MaterialID 
			)  P   order by  P.BillDate
                                  --计算出某个料入库的平均单价
                                declare  @ALLPrice  decimal(18,6)
		set  @ALLPrice=0
                               select  @ALLPrice=case when  sum(Qty)=0  then 0 else  (sum(Total) /sum(Qty))  end 
	                 from  V_InDepotDetail 
	                 where MaterialGuid=@MaterialID  and  DepotGuid =@Depot
	                 Group by MaterialGuid,DepotGuid 
--select * from #tempMaterialDetail order by noid
                           ---------------------进行计算出最后的结存数据，一行行读取，然后行行更新------------------------------------------
                                     declare @strMaterialGuid  nvarchar(50)  
                                     declare @intValue  int 
	                     declare @noid     int
                                     declare @InQty  decimal(9,2) 
                                     declare  @InPrice  decimal(18,6)
		     declare @InTotal  decimal(18,6)
		     declare @OutQty  decimal(9,2) 
		     declare @OutPrice  decimal(18,6)
		     declare @OutTotal  decimal(18,6)
		     declare @DepotQty  decimal(9,2) 
		     declare @DepotPrice  decimal(18,6)
		     declare @DepotTotal  decimal(18,6)
                                     declare @DepotQtySum   decimal(9,2) 
		     declare @DepotPriceSum  decimal(18,6)
		     declare @DepotTotalSum  decimal(18,6)
                                    declare @FactDepotMoney  decimal(18,6)
                                    declare @flag     nvarchar(10)
 		     declare @strflag  nvarchar(10)
		     	
                                   --定义光标，对#tempMaterialDetail表进行循环读数据
                                  declare curMaterial   cursor    FOR     
                                                                       select   Noid,MaterialGuid ,flag,InQty,InPrice,InTotal,OutQty,OutPrice,OutTotal
                                                                                     from  #tempMaterialDetail    order by   noid
                                                                                  
                                                                           
                                 open curMaterial   fetch next from  curMaterial    INTO    @noid,@strMaterialGuid,@flag,@InQty,@InPrice,@InTotal,@OutQty,@OutPrice,@OutTotal
		while @@fetch_status = 0 
		begin 
                                           set  @strflag=ltrim(rtrim(@flag))
                                            if (@noid=1)
                                             begin
	                                                if (@strflag='I'   or    @strflag='RI'  or @strflag='SI')
	                                                        begin
					   --如果是入库则将第一行的数量，单价，金额直接更新到结存的三栏中
					            set      @DepotQtySum=@InQty
		                                                            set      @DepotTotalSum=@InTotal
					         update  #tempMaterialDetail  set   DepotQty=@DepotQtySum,DepotTotal=@DepotTotalSum,DepotPrice=@ALLPrice         where Noid=@noid
                             						                                   
	                                                         end
	                                                 else
	                                                               begin
					   --如果是入库则将第一行的数量，单价，金额直接更新到结存的三栏中
					    set      @DepotQtySum=0-@OutQty
		                                                    set      @DepotTotalSum=0-@OutTotal
					    update  #tempMaterialDetail  set   DepotQty=@DepotQtySum,DepotTotal=@DepotTotalSum,DepotPrice=@ALLPrice       where Noid=@noid
	                                                                end
	
	 	                   end
                                            else
                                                         if (@strflag='I'   or    @strflag='RI'  or @strflag='SI')
	                                                        begin
					   --如果是入库则将第一行的数量，单价，金额直接更新到结存的三栏中
					            set      @DepotQtySum  =   @DepotQtySum+@InQty
                                                                                            set      @DepotTotalSum=   @DepotQtySum*@ALLPrice
		                                                         --    set      @DepotTotalSum=   @DepotTotalSum+@InTotal
					           -- set      @FactDepotMoney=@FactDepotMoney+
--print   '------IN-------------'
--print  @InTotal
--print @DepotTotalSum
					    update  #tempMaterialDetail  set   DepotQty=@DepotQtySum,DepotTotal=@DepotTotalSum,DepotPrice=@ALLPrice       where Noid=@noid
	                                                         end
	                                                 else
	                                                               begin
					   --如果是入库则将第一行的数量，单价，金额直接更新到结存的三栏中
					    set      @DepotQtySum  =    @DepotQtySum-@OutQty
                                                                                    set      @DepotTotalSum=   @DepotQtySum*@ALLPrice
		                                                   -- set      @DepotTotalSum=@DepotTotalSum-@OutTotal
--print   '------OUt-------------'
--print ' set @DepotTotalSum='+convert(nvarchar(10),@DepotQtySum)+'-'+convert(nvarchar(10),@OutTotal)
--print  @OutTotal
--print @DepotTotalSum
					    update  #tempMaterialDetail  set   DepotQty=@DepotQtySum,DepotTotal=@DepotTotalSum,DepotPrice=@ALLPrice       where Noid=@noid
	                                                                end
                                                     
                                                                     
  
                                       			
	                           fetch next from curMaterial   INTO       @noid,@strMaterialGuid,@flag,@InQty,@InPrice,@InTotal,@OutQty,@OutPrice,@OutTotal
	                end
	
	                  close curMaterial
		   deallocate curMaterial  
                      
                        select    BillGuid,BillDate,StorageTypeGuid,Flag,MaterialGuid,InQty,
                                       InPrice,InTotal,OutQty,OutPrice,OutTotal,DepotQty,DepotPrice,
                                      -- case when DepotQty=0 then 0 when  DepotQty   <> 0  then convert(decimal(18,6),( DepotTotal/DepotQty)) end as DepotPrice,
                                       DepotTotal
                                    from #tempMaterialDetail  order by noid
drop table  #tempMaterialDetail
GO
/****** Object:  StoredProcedure [dbo].[sp_GetMaterialSumByDepot]    Script Date: 2018-11-05 23:19:02 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
/*
   功能：计算某个料件所有仓库的库存数量
  日期 :   2008-11-26
*/
CREATE   PROCEDURE [dbo].[sp_GetMaterialSumByDepot]
@MaterialGuID      nvarchar(50)
AS     
select 
	DepotName,
	QTYSum,
                Price,
	TotalSum  
           
 from 
(         
	select   DepotName,
	     (isnull(PIN.InQty,0)+isnull(RIN.RInQty,0)+isnull(SuIN.SInQty,0)- isnull(POUT.OutQty,0)-isnull(ROUT.ROutQty,0)-isnull(SuOUT.SOutQty,0))  as QTYSum,
	     (isnull(PIN.InTotal,0)+isnull(RIN.RInTotal,0)+isnull(SuIN.SInTotal,0)- isnull(POUT.OutTotal,0)-isnull(ROUT.ROutTotal,0)-isnull(SuOUT.SOutTotal,0))  as TotalSum,
                    case when (isnull(PIN.InQty,0)+isnull(RIN.RInQty,0)+isnull(SuIN.SInQty,0))=0 then 0 else   ( (isnull(PIN.InTotal,0)+isnull(RIN.RInTotal,0)+isnull(SuIN.SInTotal,0) )/(isnull(PIN.InQty,0)+isnull(RIN.RInQty,0)+isnull(SuIN.SInQty,0)))  end as Price
  
               from Depot 
	left join  
	     (   --计算入库数量与金额
	         select  MaterialGuid,DepotGuid as Depot,sum(Qty) as InQty,sum(Total) as InTotal   
	                 from  V_InDepotDetail 
	                 where MaterialGuid=@MaterialGuID
	                 Group by MaterialGuid,DepotGuid 
	      )  PIN  On Depot.DepotName=PIN.Depot 
	
	left join 
	     (   --计算调拨入数量与金额
	        select  MaterialGuid,DepotIn as Depot,sum(Qty) as RInQty,sum(Total) as RInTotal   
	                 from   V_RemoveBill 
	                 where   MaterialGuid=@MaterialGuID
	     		 Group by MaterialGuid,DepotIn 
	     )  RIN  On Depot.DepotName=RIN.Depot
	left join 
	     (   --计算盘盈数量与金额
	        select  MaterialGuid,Depot,sum(SurplusQty) as SInQty,sum(Total) as SInTotal  
	                from   V_CheckBill  
	               where  SurplusQty>0 and MaterialGuid=@MaterialGuID
	                Group by MaterialGuid,Depot 
	     )  SuIN  On Depot.DepotName=SuIN.Depot
	left join 
	     (   --计算出库数量与金额
	        select  MaterialGuid,DepotGuid as Depot,sum(Qty) as OutQty,sum(Total) as OutTotal  
	                from  V_OutDepotDetail  
	                where  MaterialGuid=@MaterialGuID
	                Group by MaterialGuid,DepotGuid 
	     )  POUT  On Depot.DepotName=POUT.Depot
	left join 
	     (  --计算调拨出数量与金额
	       select  MaterialGuid,DepotOut as Depot,sum(Qty) as ROutQty,sum(Total) as ROutTotal   
	               from   V_RemoveBill 
	               where  MaterialGuid=@MaterialGuID
	               Group by MaterialGuid,DepotOut 
	     ) ROUT  On Depot.DepotName=ROUT.Depot
	left join 
	     ( --计算盘亏数量与金额
	       select  MaterialGuid,Depot,sum(DeficientQty) as SOutQty,sum(Total)  as SOutTotal  
	               from   V_CheckBill 
	               where  DeficientQty>0  and MaterialGuid=@MaterialGuID
	               Group by MaterialGuid,Depot 
	     ) SuOUT  On Depot.DepotName=SuOUT.Depot
   ) P
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'计量单位名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BasicData', @level2type=N'COLUMN',@level2name=N'UnitName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'辅助数据类别：(1-单位 2-规格 3:封装 4:计价法)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BasicData', @level2type=N'COLUMN',@level2name=N'flag'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单据编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill', @level2type=N'COLUMN',@level2name=N'BillAutoID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'制单日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill', @level2type=N'COLUMN',@level2name=N'BillDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'仓库Guid' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill', @level2type=N'COLUMN',@level2name=N'DepotGuid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类型guid' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill', @level2type=N'COLUMN',@level2name=N'StorageTypeGuid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'供应商guid' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill', @level2type=N'COLUMN',@level2name=N'SupplierGuid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'部门Guid' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill', @level2type=N'COLUMN',@level2name=N'DeptGuid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'方向' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill', @level2type=N'COLUMN',@level2name=N'Bearing'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill', @level2type=N'COLUMN',@level2name=N'BillID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'批号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill', @level2type=N'COLUMN',@level2name=N'BatchNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'经手人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill', @level2type=N'COLUMN',@level2name=N'HandlePerson'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'经手人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill', @level2type=N'COLUMN',@level2name=N'CreatePerson'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'制单日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'审核人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill', @level2type=N'COLUMN',@level2name=N'CheckPerson'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'审核日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill', @level2type=N'COLUMN',@level2name=N'CheckDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'入库单或出库单(I:入库单 E：出库单)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill', @level2type=N'COLUMN',@level2name=N'Flag'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bill', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'I:入库单 E:出库单 M:调拨单 P:盘点' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BillAutoID', @level2type=N'COLUMN',@level2name=N'Flag'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单据表头Guid' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BillDetail', @level2type=N'COLUMN',@level2name=N'BillGuid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'货品guid' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BillDetail', @level2type=N'COLUMN',@level2name=N'MaterialGuid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'货号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BillDetail', @level2type=N'COLUMN',@level2name=N'MaterialId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'品名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BillDetail', @level2type=N'COLUMN',@level2name=N'MaterialName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'助查码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BillDetail', @level2type=N'COLUMN',@level2name=N'BarNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'规格' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BillDetail', @level2type=N'COLUMN',@level2name=N'Spec'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BillDetail', @level2type=N'COLUMN',@level2name=N'Unit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BillDetail', @level2type=N'COLUMN',@level2name=N'Qty'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BillDetail', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单据日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CheckBill', @level2type=N'COLUMN',@level2name=N'BillDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'调出仓库' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CheckBill', @level2type=N'COLUMN',@level2name=N'Depot'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'经手人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CheckBill', @level2type=N'COLUMN',@level2name=N'HandlePerson'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CheckBill', @level2type=N'COLUMN',@level2name=N'BillID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单据编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CheckBill', @level2type=N'COLUMN',@level2name=N'BillAutoID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'经手人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CheckBill', @level2type=N'COLUMN',@level2name=N'CreatePerson'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'制单日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CheckBill', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'审核人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CheckBill', @level2type=N'COLUMN',@level2name=N'CheckPerson'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'审核日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CheckBill', @level2type=N'COLUMN',@level2name=N'CheckDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CheckBill', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单据表头Guid' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CheckBillDetail', @level2type=N'COLUMN',@level2name=N'CheckBillGuid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'货品guid' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CheckBillDetail', @level2type=N'COLUMN',@level2name=N'MaterialGuid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'货号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CheckBillDetail', @level2type=N'COLUMN',@level2name=N'MaterialId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'品名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CheckBillDetail', @level2type=N'COLUMN',@level2name=N'MaterialName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'助查码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CheckBillDetail', @level2type=N'COLUMN',@level2name=N'BarNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'规格' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CheckBillDetail', @level2type=N'COLUMN',@level2name=N'Spec'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CheckBillDetail', @level2type=N'COLUMN',@level2name=N'Unit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CheckBillDetail', @level2type=N'COLUMN',@level2name=N'Price'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'盘盈数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CheckBillDetail', @level2type=N'COLUMN',@level2name=N'SurplusQty'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'盘亏数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CheckBillDetail', @level2type=N'COLUMN',@level2name=N'DeficientQty'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CheckBillDetail', @level2type=N'COLUMN',@level2name=N'Total'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CheckBillDetail', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Client', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'简称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Client', @level2type=N'COLUMN',@level2name=N'SimpName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'联系人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Client', @level2type=N'COLUMN',@level2name=N'LinkMan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'联系电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Client', @level2type=N'COLUMN',@level2name=N'Telephone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'传真' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Client', @level2type=N'COLUMN',@level2name=N'Fax'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'联系地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Client', @level2type=N'COLUMN',@level2name=N'Address'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'邮编' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Client', @level2type=N'COLUMN',@level2name=N'Zip'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Client', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'仓库名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Depot', @level2type=N'COLUMN',@level2name=N'DepotName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'负责人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Depot', @level2type=N'COLUMN',@level2name=N'DepotPerson'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'负责人电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Depot', @level2type=N'COLUMN',@level2name=N'Telephone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Depot', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'部门名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Dept', @level2type=N'COLUMN',@level2name=N'DeptName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'部门负责人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Dept', @level2type=N'COLUMN',@level2name=N'DeptPerson'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Dept', @level2type=N'COLUMN',@level2name=N'Telephone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'传真' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Dept', @level2type=N'COLUMN',@level2name=N'Fax'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Dept', @level2type=N'COLUMN',@level2name=N'Address'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'唯一号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'EmpGuid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'员工编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'EmpID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'员工姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'EmpName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'性别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'Sex'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'联系电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'Telephone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'联系地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'Address'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'身份证号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'CardID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'所在部门' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'Dept'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'货号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Material', @level2type=N'COLUMN',@level2name=N'MaterialId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'品名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Material', @level2type=N'COLUMN',@level2name=N'MaterialName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'货物类别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Material', @level2type=N'COLUMN',@level2name=N'ClassId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'规格型号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Material', @level2type=N'COLUMN',@level2name=N'Spec'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Material', @level2type=N'COLUMN',@level2name=N'Unit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'助查码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Material', @level2type=N'COLUMN',@level2name=N'BarNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'货位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Material', @level2type=N'COLUMN',@level2name=N'Place'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'封装' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Material', @level2type=N'COLUMN',@level2name=N'Encapsulation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'库存上限' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Material', @level2type=N'COLUMN',@level2name=N'UpperLimit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'库存下限' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Material', @level2type=N'COLUMN',@level2name=N'LowerLimit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'入库参考价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Material', @level2type=N'COLUMN',@level2name=N'IConsultPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'出库参考价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Material', @level2type=N'COLUMN',@level2name=N'EConsultPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'计价方法' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Material', @level2type=N'COLUMN',@level2name=N'CalculateMethod'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Material', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单据日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RemoveBill', @level2type=N'COLUMN',@level2name=N'BillDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'调出仓库' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RemoveBill', @level2type=N'COLUMN',@level2name=N'DepotOut'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'调入仓库' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RemoveBill', @level2type=N'COLUMN',@level2name=N'DepotIn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'经手人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RemoveBill', @level2type=N'COLUMN',@level2name=N'HandlePerson'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RemoveBill', @level2type=N'COLUMN',@level2name=N'BillID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单据编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RemoveBill', @level2type=N'COLUMN',@level2name=N'BillAutoID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'经手人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RemoveBill', @level2type=N'COLUMN',@level2name=N'CreatePerson'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'制单日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RemoveBill', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'审核人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RemoveBill', @level2type=N'COLUMN',@level2name=N'CheckPerson'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'审核日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RemoveBill', @level2type=N'COLUMN',@level2name=N'CheckDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RemoveBill', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单据表头Guid' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RemoveBillDetail', @level2type=N'COLUMN',@level2name=N'RemoveBillGuid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'货品guid' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RemoveBillDetail', @level2type=N'COLUMN',@level2name=N'MaterialGuid'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'货号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RemoveBillDetail', @level2type=N'COLUMN',@level2name=N'MaterialId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'品名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RemoveBillDetail', @level2type=N'COLUMN',@level2name=N'MaterialName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'助查码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RemoveBillDetail', @level2type=N'COLUMN',@level2name=N'BarNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'规格' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RemoveBillDetail', @level2type=N'COLUMN',@level2name=N'Spec'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RemoveBillDetail', @level2type=N'COLUMN',@level2name=N'Unit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RemoveBillDetail', @level2type=N'COLUMN',@level2name=N'Price'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RemoveBillDetail', @level2type=N'COLUMN',@level2name=N'Qty'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RemoveBillDetail', @level2type=N'COLUMN',@level2name=N'Total'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RemoveBillDetail', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'出入库类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'StorageType', @level2type=N'COLUMN',@level2name=N'StorageTypeName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'出入库标记(I-入库 E-出库)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'StorageType', @level2type=N'COLUMN',@level2name=N'Flag'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'供应商名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Supplier', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'简称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Supplier', @level2type=N'COLUMN',@level2name=N'SimpName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'联系人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Supplier', @level2type=N'COLUMN',@level2name=N'LinkMan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'联系电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Supplier', @level2type=N'COLUMN',@level2name=N'Telephone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'传真' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Supplier', @level2type=N'COLUMN',@level2name=N'Fax'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'联系地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Supplier', @level2type=N'COLUMN',@level2name=N'Address'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'邮编' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Supplier', @level2type=N'COLUMN',@level2name=N'Zip'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Supplier', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户账号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserRight', @level2type=N'COLUMN',@level2name=N'UserID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'入库单管理' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserRight', @level2type=N'COLUMN',@level2name=N'lkdgl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'入库单新增' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserRight', @level2type=N'COLUMN',@level2name=N'lkdxz'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'入库单审核' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserRight', @level2type=N'COLUMN',@level2name=N'lkdsh'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'出库单管理' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserRight', @level2type=N'COLUMN',@level2name=N'ckdgl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'出库单新增' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserRight', @level2type=N'COLUMN',@level2name=N'ckdxz'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'出库单审核' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserRight', @level2type=N'COLUMN',@level2name=N'ckdsh'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=NULL , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserRight', @level2type=N'COLUMN',@level2name=N'hp'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[25] 4[16] 2[28] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[25] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1 [56] 4 [18] 2))"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Material"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 116
               Right = 209
            End
            DisplayFlags = 280
            TopColumn = 11
         End
         Begin Table = "StorageClass"
            Begin Extent = 
               Top = 6
               Left = 247
               Bottom = 116
               Right = 406
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "BillDetail"
            Begin Extent = 
               Top = 6
               Left = 444
               Bottom = 116
               Right = 609
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Bill"
            Begin Extent = 
               Top = 6
               Left = 647
               Bottom = 116
               Right = 818
            End
            DisplayFlags = 280
            TopColumn = 13
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      RowHeights = 240
      Begin ColumnWidths = 25
         Width = 284
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_ALLDepotDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'440
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_ALLDepotDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_ALLDepotDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[25] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1 [56] 4 [18] 2))"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "CheckBill"
            Begin Extent = 
               Top = 6
               Left = 157
               Bottom = 116
               Right = 316
            End
            DisplayFlags = 280
            TopColumn = 7
         End
         Begin Table = "CheckBillDetail"
            Begin Extent = 
               Top = 7
               Left = 413
               Bottom = 117
               Right = 608
            End
            DisplayFlags = 280
            TopColumn = 9
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      RowHeights = 240
      Begin ColumnWidths = 23
         Width = 284
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_CheckBill'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_CheckBill'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[49] 4[4] 2[17] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[25] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1 [56] 4 [18] 2))"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Material"
            Begin Extent = 
               Top = 10
               Left = 528
               Bottom = 247
               Right = 699
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "BillDetail"
            Begin Extent = 
               Top = 11
               Left = 272
               Bottom = 246
               Right = 437
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Bill"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 249
               Right = 209
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "StorageClass"
            Begin Extent = 
               Top = 13
               Left = 785
               Bottom = 252
               Right = 944
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      RowHeights = 240
      Begin ColumnWidths = 24
         Width = 284
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
      End
   End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_InDepotDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_InDepotDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_InDepotDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[25] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1 [56] 4 [18] 2))"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Material"
            Begin Extent = 
               Top = 6
               Left = 450
               Bottom = 116
               Right = 621
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "BillDetail"
            Begin Extent = 
               Top = 6
               Left = 247
               Bottom = 116
               Right = 412
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Bill"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 116
               Right = 209
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "StorageClass"
            Begin Extent = 
               Top = 6
               Left = 659
               Bottom = 116
               Right = 818
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      RowHeights = 240
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_OutDepotDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_OutDepotDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[23] 4[38] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[25] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1 [56] 4 [18] 2))"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "RemoveBill"
            Begin Extent = 
               Top = 15
               Left = 136
               Bottom = 125
               Right = 301
            End
            DisplayFlags = 280
            TopColumn = 8
         End
         Begin Table = "RemoveBillDetail"
            Begin Extent = 
               Top = 16
               Left = 436
               Bottom = 126
               Right = 637
            End
            DisplayFlags = 280
            TopColumn = 8
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      RowHeights = 240
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_RemoveBill'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_RemoveBill'
GO
USE [master]
GO
ALTER DATABASE [Storehouse] SET  READ_WRITE 
GO
