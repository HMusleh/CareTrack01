
/****** Object:  Database [CareTrack Database]    Script Date: 4/15/2025 10:21:23 PM ******/
CREATE DATABASE [CareTrack Database]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CareTrack Database', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\CareTrack Database.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CareTrack Database_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\CareTrack Database_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [CareTrack Database] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CareTrack Database].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CareTrack Database] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CareTrack Database] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CareTrack Database] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CareTrack Database] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CareTrack Database] SET ARITHABORT OFF 
GO
ALTER DATABASE [CareTrack Database] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CareTrack Database] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CareTrack Database] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CareTrack Database] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CareTrack Database] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CareTrack Database] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CareTrack Database] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CareTrack Database] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CareTrack Database] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CareTrack Database] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CareTrack Database] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CareTrack Database] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CareTrack Database] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CareTrack Database] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CareTrack Database] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CareTrack Database] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CareTrack Database] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CareTrack Database] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CareTrack Database] SET  MULTI_USER 
GO
ALTER DATABASE [CareTrack Database] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CareTrack Database] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CareTrack Database] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CareTrack Database] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CareTrack Database] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CareTrack Database] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CareTrack Database] SET QUERY_STORE = ON
GO
ALTER DATABASE [CareTrack Database] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [CareTrack Database]
GO
/****** Object:  Table [dbo].[Billing]    Script Date: 4/15/2025 10:21:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Billing](
	[BillingID] [int] NOT NULL,
	[ClientID] [int] NULL,
	[amount] [decimal](10, 2) NULL,
	[due_date] [date] NULL,
	[status] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[BillingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Care_Plan_Tasks]    Script Date: 4/15/2025 10:21:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Care_Plan_Tasks](
	[CareplanID] [int] NOT NULL,
	[TaskID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CareplanID] ASC,
	[TaskID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Caregiver]    Script Date: 4/15/2025 10:21:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Caregiver](
	[CaregiverID] [int] NOT NULL,
	[name] [varchar](100) NULL,
	[phone] [varchar](20) NULL,
	[email] [varchar](100) NULL,
	[SupervisorID] [int] NULL,
	[employment_date] [date] NULL,
	[signature] [varbinary](max) NULL,
	[status] [varchar](20) NULL,
	[hourly_rate] [decimal](5, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[CaregiverID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarePlans]    Script Date: 4/15/2025 10:21:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarePlans](
	[PlanID] [int] NOT NULL,
	[ClientID] [int] NULL,
	[details] [text] NULL,
	[last_updated] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[PlanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 4/15/2025 10:21:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ClientID] [int] NOT NULL,
	[name] [varchar](100) NULL,
	[phone] [varchar](20) NULL,
	[address] [text] NULL,
	[CaregiverID] [int] NULL,
	[service_start_date] [date] NULL,
	[signature] [varbinary](max) NULL,
	[status] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[completed_tasks]    Script Date: 4/15/2025 10:21:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[completed_tasks](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CaregiverID] [int] NOT NULL,
	[PlanID] [int] NOT NULL,
	[TaskID] [int] NOT NULL,
	[completed] [bit] NOT NULL,
	[completionTime] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payroll]    Script Date: 4/15/2025 10:21:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payroll](
	[PayrollID] [int] NOT NULL,
	[CaregiverID] [int] NULL,
	[amount] [decimal](10, 2) NULL,
	[pay_period] [date] NULL,
	[status] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[PayrollID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 4/15/2025 10:21:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleID] [int] NOT NULL,
	[role_name] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service_Logs]    Script Date: 4/15/2025 10:21:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service_Logs](
	[CaregiverID] [int] NULL,
	[ClientID] [int] NULL,
	[date_time] [datetime] NULL,
	[tasks_performed] [text] NULL,
	[caregiver_signature] [varbinary](max) NULL,
	[client_signature] [varbinary](max) NULL,
	[notes] [text] NULL,
	[SignedBy] [varchar](100) NULL,
	[SignatureType] [varchar](50) NULL,
	[TypedSignatureText] [varchar](255) NULL,
	[SignedDate] [datetime] NULL,
	[SignatureData] [varbinary](max) NULL,
	[ShiftID] [int] NULL,
	[LogID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[LogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shifts_Assignment]    Script Date: 4/15/2025 10:21:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shifts_Assignment](
	[CaregiverID] [int] NULL,
	[ClientID] [int] NULL,
	[shift_date] [date] NULL,
	[status] [varchar](20) NULL,
	[start_time] [time](7) NULL,
	[end_time] [time](7) NULL,
	[pay_amount] [decimal](10, 2) NULL,
	[ShiftID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Shifts_Assignment] PRIMARY KEY CLUSTERED 
(
	[ShiftID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supervisors]    Script Date: 4/15/2025 10:21:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supervisors](
	[SupervisorID] [int] NOT NULL,
	[name] [varchar](100) NULL,
	[Phone] [varchar](20) NULL,
	[email] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[SupervisorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaskAssignment]    Script Date: 4/15/2025 10:21:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaskAssignment](
	[TaskAssignment_ID] [int] IDENTITY(1,1) NOT NULL,
	[CaregiverID] [int] NOT NULL,
	[ClientID] [int] NOT NULL,
	[TaskID] [int] NOT NULL,
	[scheduled_date] [date] NOT NULL,
	[completion_status] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[TaskAssignment_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tasks]    Script Date: 4/15/2025 10:21:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tasks](
	[TaskID] [int] NOT NULL,
	[description] [text] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TaskID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TimePunches]    Script Date: 4/15/2025 10:21:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimePunches](
	[PunchID] [int] IDENTITY(1,1) NOT NULL,
	[CaregiverID] [int] NOT NULL,
	[clock_in] [datetime] NOT NULL,
	[clock_out] [datetime] NULL,
	[ShiftID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PunchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 4/15/2025 10:21:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[CaregiverID] [int] NULL,
	[username] [varchar](50) NOT NULL,
	[RoleID] [int] NOT NULL,
	[isActive] [bit] NULL,
	[password_hash] [varbinary](256) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (1, 1)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (1, 2)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (1, 3)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (1, 5)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (2, 1)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (2, 2)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (2, 3)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (2, 4)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (2, 5)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (2, 6)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (2, 7)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (2, 8)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (2, 9)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (2, 10)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (2, 11)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (2, 12)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (2, 13)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (2, 14)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (2, 15)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (2, 16)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (2, 17)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (2, 18)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (2, 19)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (2, 20)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (2, 21)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (2, 22)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (2, 23)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (3, 8)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (3, 14)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (4, 1)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (4, 2)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (4, 3)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (4, 4)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (4, 5)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (4, 6)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (4, 7)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (4, 10)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (4, 11)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (4, 12)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (4, 13)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (4, 14)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (4, 15)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (4, 16)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (4, 17)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (4, 18)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (5, 19)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (5, 20)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (5, 21)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (5, 22)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (5, 23)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (6, 4)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (6, 5)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (6, 7)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (6, 9)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (7, 1)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (7, 2)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (7, 3)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (7, 4)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (7, 5)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (7, 6)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (8, 1)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (8, 3)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (8, 4)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (8, 5)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (8, 8)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (8, 14)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (9, 12)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (9, 13)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (9, 15)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (9, 16)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (10, 1)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (10, 2)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (10, 3)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (10, 4)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (10, 5)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (10, 6)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (10, 9)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (11, 1)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (11, 2)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (11, 3)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (11, 4)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (11, 5)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (11, 6)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (11, 7)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (11, 8)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (11, 10)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (11, 11)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (11, 12)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (11, 13)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (11, 14)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (11, 15)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (11, 16)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (11, 17)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (11, 18)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (11, 19)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (11, 20)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (11, 21)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (11, 22)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (11, 23)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (12, 7)
GO
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (12, 8)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (12, 14)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (12, 19)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (12, 20)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (12, 21)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (12, 22)
INSERT [dbo].[Care_Plan_Tasks] ([CareplanID], [TaskID]) VALUES (12, 23)
GO
INSERT [dbo].[Caregiver] ([CaregiverID], [name], [phone], [email], [SupervisorID], [employment_date], [signature], [status], [hourly_rate]) VALUES (1, N'Janice Smith', N'555-987-4563', N'Janice.Smith@gmail.com', 1, CAST(N'2018-04-22' AS Date), NULL, N'Active', CAST(18.00 AS Decimal(5, 2)))
INSERT [dbo].[Caregiver] ([CaregiverID], [name], [phone], [email], [SupervisorID], [employment_date], [signature], [status], [hourly_rate]) VALUES (2, N'Joshua Rogers', N'888-754-8456', N'Joshua.Rogers@yahoo.com', 1, CAST(N'2018-06-14' AS Date), NULL, N'Active', CAST(19.00 AS Decimal(5, 2)))
INSERT [dbo].[Caregiver] ([CaregiverID], [name], [phone], [email], [SupervisorID], [employment_date], [signature], [status], [hourly_rate]) VALUES (3, N'Brooklin Harrold', N'123-548-9634', N'Brooklin.Harrold@outlook.com', 1, CAST(N'2018-07-23' AS Date), NULL, N'Active', CAST(19.50 AS Decimal(5, 2)))
INSERT [dbo].[Caregiver] ([CaregiverID], [name], [phone], [email], [SupervisorID], [employment_date], [signature], [status], [hourly_rate]) VALUES (4, N'David Duncan', N'444-777-4444', N'David.Duncan@gmail.com', 2, CAST(N'2020-04-12' AS Date), NULL, N'Active', CAST(18.75 AS Decimal(5, 2)))
INSERT [dbo].[Caregiver] ([CaregiverID], [name], [phone], [email], [SupervisorID], [employment_date], [signature], [status], [hourly_rate]) VALUES (5, N'Michael Barry', N'555-888-9999', N'Michael.Barry@gmail.com', 2, CAST(N'2021-11-15' AS Date), NULL, N'Active', CAST(20.00 AS Decimal(5, 2)))
INSERT [dbo].[Caregiver] ([CaregiverID], [name], [phone], [email], [SupervisorID], [employment_date], [signature], [status], [hourly_rate]) VALUES (6, N'Bethany Jones', N'632-874-5214', N'Bethany.Jones@outlook.com', 2, CAST(N'2023-05-02' AS Date), NULL, N'Active', CAST(21.50 AS Decimal(5, 2)))
GO
INSERT [dbo].[CarePlans] ([PlanID], [ClientID], [details], [last_updated]) VALUES (1, 1, N'Basic Hygiene', CAST(N'2025-03-25T00:00:00.000' AS DateTime))
INSERT [dbo].[CarePlans] ([PlanID], [ClientID], [details], [last_updated]) VALUES (2, 2, N'Full Care Plan with meals', CAST(N'2025-03-25T19:46:48.410' AS DateTime))
INSERT [dbo].[CarePlans] ([PlanID], [ClientID], [details], [last_updated]) VALUES (3, 3, N'Assistance with mobility', CAST(N'2025-03-25T19:46:48.410' AS DateTime))
INSERT [dbo].[CarePlans] ([PlanID], [ClientID], [details], [last_updated]) VALUES (4, 4, N'Housekeeping and Hygiene', CAST(N'2025-03-25T19:46:48.410' AS DateTime))
INSERT [dbo].[CarePlans] ([PlanID], [ClientID], [details], [last_updated]) VALUES (5, 5, N'Medication Supervision', CAST(N'2025-03-25T19:46:48.410' AS DateTime))
INSERT [dbo].[CarePlans] ([PlanID], [ClientID], [details], [last_updated]) VALUES (6, 6, N'Daily morning assistance', CAST(N'2025-03-25T19:46:48.410' AS DateTime))
INSERT [dbo].[CarePlans] ([PlanID], [ClientID], [details], [last_updated]) VALUES (7, 7, N'Bathing and grooming', CAST(N'2025-03-25T19:46:48.410' AS DateTime))
INSERT [dbo].[CarePlans] ([PlanID], [ClientID], [details], [last_updated]) VALUES (8, 8, N'Mobility and Hygiene', CAST(N'2025-03-25T19:46:48.410' AS DateTime))
INSERT [dbo].[CarePlans] ([PlanID], [ClientID], [details], [last_updated]) VALUES (9, 9, N'Light Housekeeping', CAST(N'2025-03-25T19:46:48.410' AS DateTime))
INSERT [dbo].[CarePlans] ([PlanID], [ClientID], [details], [last_updated]) VALUES (10, 10, N'Hygiene and nutrition', CAST(N'2025-03-25T19:46:48.410' AS DateTime))
INSERT [dbo].[CarePlans] ([PlanID], [ClientID], [details], [last_updated]) VALUES (11, 11, N'Full Service Plan', CAST(N'2025-03-25T19:46:48.410' AS DateTime))
INSERT [dbo].[CarePlans] ([PlanID], [ClientID], [details], [last_updated]) VALUES (12, 12, N'Partial Support Only', CAST(N'2025-03-25T19:46:48.410' AS DateTime))
GO
INSERT [dbo].[Clients] ([ClientID], [name], [phone], [address], [CaregiverID], [service_start_date], [signature], [status]) VALUES (1, N'Brandy Bonilla', N'443-294-7683', N'4194 Retreat Avenue', 1, CAST(N'2018-07-06' AS Date), NULL, N'Active')
INSERT [dbo].[Clients] ([ClientID], [name], [phone], [address], [CaregiverID], [service_start_date], [signature], [status]) VALUES (2, N'Corine Vincent', N'443-003-6440', N'4643 Forest Avenue', 1, CAST(N'2019-01-23' AS Date), NULL, N'Active')
INSERT [dbo].[Clients] ([ClientID], [name], [phone], [address], [CaregiverID], [service_start_date], [signature], [status]) VALUES (3, N'Otis Flowers', N'443-155-3736', N'2419 Henry Ford Avenue', 2, CAST(N'2020-02-27' AS Date), NULL, N'Active')
INSERT [dbo].[Clients] ([ClientID], [name], [phone], [address], [CaregiverID], [service_start_date], [signature], [status]) VALUES (4, N'Rae Mcdonald', N'443-839-0126', N'3578 Briarwood Drive', 2, CAST(N'2020-04-09' AS Date), NULL, N'Active')
INSERT [dbo].[Clients] ([ClientID], [name], [phone], [address], [CaregiverID], [service_start_date], [signature], [status]) VALUES (5, N'Lori Salas', N'443-088-1392', N'3590 Tenmile Road', 3, CAST(N'2020-07-24' AS Date), NULL, N'Active')
INSERT [dbo].[Clients] ([ClientID], [name], [phone], [address], [CaregiverID], [service_start_date], [signature], [status]) VALUES (6, N'Jimmy Oconnor', N'443-095-4630', N'4522 Wines Lane', 3, CAST(N'2021-01-21' AS Date), NULL, N'Active')
INSERT [dbo].[Clients] ([ClientID], [name], [phone], [address], [CaregiverID], [service_start_date], [signature], [status]) VALUES (7, N'Carole Vega', N'443-618-3431', N'1705 Hurry Street', 4, CAST(N'2021-09-17' AS Date), NULL, N'Active')
INSERT [dbo].[Clients] ([ClientID], [name], [phone], [address], [CaregiverID], [service_start_date], [signature], [status]) VALUES (8, N'Marlin Chase', N'443-795-0046', N'2771 Gateway Road', 4, CAST(N'2022-03-17' AS Date), NULL, N'Active')
INSERT [dbo].[Clients] ([ClientID], [name], [phone], [address], [CaregiverID], [service_start_date], [signature], [status]) VALUES (9, N'Harry Marsh', N'443-470-2918', N'4129 Angus Road', 5, CAST(N'2023-09-05' AS Date), NULL, N'Active')
INSERT [dbo].[Clients] ([ClientID], [name], [phone], [address], [CaregiverID], [service_start_date], [signature], [status]) VALUES (10, N'Dennis Hinton', N'443-517-5512', N'3827 Langtown Road', 5, CAST(N'2024-04-08' AS Date), NULL, N'Active')
INSERT [dbo].[Clients] ([ClientID], [name], [phone], [address], [CaregiverID], [service_start_date], [signature], [status]) VALUES (11, N'Lisa Harper', N'443-445-8026', N'824 Reeves Street', 6, CAST(N'2024-10-31' AS Date), NULL, N'Active')
INSERT [dbo].[Clients] ([ClientID], [name], [phone], [address], [CaregiverID], [service_start_date], [signature], [status]) VALUES (12, N'Selena Maria', N'443-179-6537', N'3000 Saint James Drive', 6, CAST(N'2024-12-06' AS Date), NULL, N'Active')
GO
SET IDENTITY_INSERT [dbo].[completed_tasks] ON 

INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (1, 4, 1, 1, 1, CAST(N'2025-04-09T02:40:58.780' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (2, 4, 1, 2, 1, CAST(N'2025-04-09T02:40:58.787' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (3, 4, 1, 3, 1, CAST(N'2025-04-09T02:40:58.787' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (4, 4, 1, 5, 1, CAST(N'2025-04-09T02:40:58.790' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (5, 6, 11, 1, 1, CAST(N'2025-04-09T00:58:38.150' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (6, 6, 11, 2, 1, CAST(N'2025-04-09T00:58:38.157' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (7, 6, 11, 3, 1, CAST(N'2025-04-09T00:58:38.163' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (8, 6, 11, 4, 1, CAST(N'2025-04-09T00:58:38.170' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (9, 6, 11, 5, 1, CAST(N'2025-04-09T00:58:38.173' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (10, 6, 11, 6, 0, CAST(N'2025-04-09T00:58:38.180' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (11, 6, 11, 7, 0, CAST(N'2025-04-09T00:58:38.183' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (12, 6, 11, 8, 0, CAST(N'2025-04-09T00:58:38.190' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (13, 6, 11, 10, 0, CAST(N'2025-04-09T00:58:38.197' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (14, 6, 11, 11, 0, CAST(N'2025-04-09T00:58:38.200' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (15, 6, 11, 12, 0, CAST(N'2025-04-09T00:58:38.207' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (16, 6, 11, 13, 0, CAST(N'2025-04-09T00:58:38.213' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (17, 6, 11, 14, 0, CAST(N'2025-04-09T00:58:38.217' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (18, 6, 11, 15, 0, CAST(N'2025-04-09T00:58:38.220' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (19, 6, 11, 16, 0, CAST(N'2025-04-09T00:58:38.220' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (20, 6, 11, 17, 0, CAST(N'2025-04-09T00:58:38.223' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (21, 6, 11, 18, 0, CAST(N'2025-04-09T00:58:38.223' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (22, 6, 11, 19, 0, CAST(N'2025-04-09T00:58:38.227' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (23, 6, 11, 20, 0, CAST(N'2025-04-09T00:58:38.227' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (24, 6, 11, 21, 0, CAST(N'2025-04-09T00:58:38.230' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (25, 6, 11, 22, 0, CAST(N'2025-04-09T00:58:38.230' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (26, 6, 11, 23, 0, CAST(N'2025-04-09T00:58:38.233' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (27, 5, 11, 1, 1, CAST(N'2025-04-14T20:38:59.843' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (28, 5, 11, 2, 1, CAST(N'2025-04-14T20:38:59.850' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (29, 5, 11, 3, 1, CAST(N'2025-04-14T20:38:59.850' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (30, 5, 11, 4, 1, CAST(N'2025-04-14T20:38:59.853' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (31, 5, 11, 5, 1, CAST(N'2025-04-14T20:38:59.853' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (32, 5, 11, 6, 1, CAST(N'2025-04-14T20:38:59.857' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (33, 5, 11, 7, 1, CAST(N'2025-04-14T20:38:59.857' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (34, 5, 11, 8, 1, CAST(N'2025-04-14T20:38:59.860' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (35, 5, 11, 10, 1, CAST(N'2025-04-14T20:38:59.860' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (36, 5, 11, 11, 1, CAST(N'2025-04-14T20:38:59.863' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (37, 5, 11, 12, 1, CAST(N'2025-04-14T20:38:59.863' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (38, 5, 11, 13, 1, CAST(N'2025-04-14T20:38:59.863' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (39, 5, 11, 14, 1, CAST(N'2025-04-14T20:38:59.867' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (40, 5, 11, 15, 1, CAST(N'2025-04-14T20:38:59.867' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (41, 5, 11, 16, 1, CAST(N'2025-04-14T20:38:59.870' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (42, 5, 11, 17, 1, CAST(N'2025-04-14T20:38:59.870' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (43, 5, 11, 18, 1, CAST(N'2025-04-14T20:38:59.873' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (44, 5, 11, 19, 1, CAST(N'2025-04-14T20:38:59.873' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (45, 5, 11, 20, 1, CAST(N'2025-04-14T20:38:59.873' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (46, 5, 11, 21, 1, CAST(N'2025-04-14T20:38:59.877' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (47, 5, 11, 22, 1, CAST(N'2025-04-14T20:38:59.877' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (48, 5, 11, 23, 1, CAST(N'2025-04-14T20:38:59.880' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (49, 5, 10, 1, 1, CAST(N'2025-04-15T22:00:13.073' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (50, 5, 10, 2, 1, CAST(N'2025-04-15T22:00:13.087' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (51, 5, 10, 3, 1, CAST(N'2025-04-15T22:00:13.087' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (52, 5, 10, 4, 1, CAST(N'2025-04-15T22:00:13.090' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (53, 5, 10, 5, 1, CAST(N'2025-04-15T22:00:13.090' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (54, 5, 10, 6, 1, CAST(N'2025-04-15T22:00:13.090' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (55, 5, 10, 9, 1, CAST(N'2025-04-15T22:00:13.093' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (56, 3, 2, 1, 1, CAST(N'2025-04-15T22:07:43.783' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (57, 3, 2, 2, 1, CAST(N'2025-04-15T22:07:43.790' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (58, 3, 2, 3, 1, CAST(N'2025-04-15T22:07:43.793' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (59, 3, 2, 4, 1, CAST(N'2025-04-15T22:07:43.793' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (60, 3, 2, 5, 1, CAST(N'2025-04-15T22:07:43.797' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (61, 3, 2, 6, 1, CAST(N'2025-04-15T22:07:43.797' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (62, 3, 2, 7, 1, CAST(N'2025-04-15T22:07:43.800' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (63, 3, 2, 8, 1, CAST(N'2025-04-15T22:07:43.800' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (64, 3, 2, 9, 1, CAST(N'2025-04-15T22:07:43.800' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (65, 3, 2, 10, 1, CAST(N'2025-04-15T22:07:43.803' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (66, 3, 2, 11, 1, CAST(N'2025-04-15T22:07:43.803' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (67, 3, 2, 12, 1, CAST(N'2025-04-15T22:07:43.807' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (68, 3, 2, 13, 1, CAST(N'2025-04-15T22:07:43.807' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (69, 3, 2, 14, 1, CAST(N'2025-04-15T22:07:43.810' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (70, 3, 2, 15, 1, CAST(N'2025-04-15T22:07:43.810' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (71, 3, 2, 16, 1, CAST(N'2025-04-15T22:07:43.810' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (72, 3, 2, 17, 1, CAST(N'2025-04-15T22:07:43.813' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (73, 3, 2, 18, 1, CAST(N'2025-04-15T22:07:43.813' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (74, 3, 2, 19, 1, CAST(N'2025-04-15T22:07:43.817' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (75, 3, 2, 20, 1, CAST(N'2025-04-15T22:07:43.817' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (76, 3, 2, 21, 1, CAST(N'2025-04-15T22:07:43.820' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (77, 3, 2, 22, 1, CAST(N'2025-04-15T22:07:43.820' AS DateTime))
INSERT [dbo].[completed_tasks] ([ID], [CaregiverID], [PlanID], [TaskID], [completed], [completionTime]) VALUES (78, 3, 2, 23, 1, CAST(N'2025-04-15T22:07:43.820' AS DateTime))
SET IDENTITY_INSERT [dbo].[completed_tasks] OFF
GO
INSERT [dbo].[Roles] ([RoleID], [role_name]) VALUES (2, N'Caregiver')
INSERT [dbo].[Roles] ([RoleID], [role_name]) VALUES (1, N'Supervisor')
GO
SET IDENTITY_INSERT [dbo].[Service_Logs] ON 

INSERT [dbo].[Service_Logs] ([CaregiverID], [ClientID], [date_time], [tasks_performed], [caregiver_signature], [client_signature], [notes], [SignedBy], [SignatureType], [TypedSignatureText], [SignedDate], [SignatureData], [ShiftID], [LogID]) VALUES (5, 10, CAST(N'2025-04-15T21:58:00.727' AS DateTime), N'Bathing
Shaving
Hair Care
Skin Care
Mouth Care
Nail Maintenance
Prepare Meals', 0x89504E470D0A1A0A0000000D49484452000001DA000000A70806000000B62F9D04000000017352474200AECE1CE90000000467414D410000B18F0BFC61050000000970485973000012740000127401DE661F7800000E8549444154785EEDD8018EDDAC0E86E12EB6FBDFC2BD4AFB4F27F31D20060C31F03E92AB9E04089804ABFDF5FBF7EFFF110441100431267E5D7F0000007F145A000006A2D002003010851600808128B400000C44A1050060200A2D000003516801001888420B00C040145A000006A2D0020030108536E3D7AF5F7F0200801E14DA0C0A2D00C003853683420B00F040A1CDA0D002003C50683328B4C0F777C0B700B4A3D06670B800145AC003853683C305A7BB1759BE05A0DD63A1D58F8D5833805ABC3F800F0A2D3124B03EF613F0F158682F7A889EF0F1EDB446DDB7688158747FD823A08FA9D0DE9DF201EEBEBE91F41DA90DBC8BFD007C5517DACB091FE2CE6B8B44DF2572FE3EF603F0D55468BFECFC21EEBCB68838D8E3A0D002BE5C0AADC60E765A4B743BBE3FAB622F007F5D85F6A21FE62E1FE82EEB58C14EEFCDEA76FB8E8108BA0BEDDD4E1FE82EEB886EA77766755A64D913C0876BA1BDECF291EEB086C838D063D1FD604F003FEE85F6B2C387BAC31AA2E2408FE7BE17EC0BE06B68A15DF9835D79EE51EDF05EEC48F784FD017C4D29B42B7EB4ABCE3BAAD5DF879DE99EE86F007D8614DABB550FD715E71C110536B6D4DEE86F007D8617DACB8A1FEE8A738E428B2BB98C2BB537A96B00DA516833569CF3DBB4B092C3D8727B94BA06A0DDD442BBD2C7BBDA7CDF46715D4B69AF72D701B49952682F2B7DBCA54308DFB4B892AF7594F6AB740F40BDE98576850F789579BE458B2BF95A4B69CF4AF700B49956682FAB7CC42BCC71262DA8ABEC233E3DED5DE91E8036530BED65850F798539CEA045F5E990466C96FD7BBA0FA01E85366185398EA445F5E45CECE4692FD96F600C0A6DC20A731C418BEB8939D895654F9FEE0368F35AA18DFC51479E9B27DD8BE8FB8236D67DB5B401506F7AA1BD583FFCB7449E5B0B2DA2A5C07EAC7B6B6D07A0CE2B85F612F9A38E3CB71A5A4453318B3E77E788C43A2F6B3B00F528B40991E766A1077F84B5E87C887C78B28E39EAF90028B44991E796A20775B44333DA7C46D2FCF7468F9A71ACED00D4A3D026449D9B1EC2A58824EABC22D27D6CCD5B6DDF9AB600EABC5E68A37DDC2BCC2B1591AD30C768747F354AACEDEE6ADB03B07BADD05E227EDC51E6A4076B9479B55879EE11E83B507A1F4AF74A5AFA00B0A1D08A37E7A487A8C6AA569F7F34FA5EDCF3DB9AEBD67E009E5168C5AC39E921998A5DECB69E08F45DD1A8D1DA0F804D88421BE9031F351F3D08735143FBBE154FACEDD046F7A336D72D7D00D8BD5A682FD13E72AFF9E8C1978A163A46B44879BA8F3EBA07B5B9AE6D0FA00E85F6A6E590BAE801978A563A8EC69B742EA53995EEA18FE6F6692F544D5B00F528B4FFA93D9CBEDCFB69B4D031521191CE51E799BB8E3EB9BCA6AEE5D4B405502F4CA17DFB43B7CCE13E578D163A462E56A273FF9ABFFE46BF524E4BF794B51D8036AF17DA4B840F3D3787FB81958B5ADA5F6307A935EDB4BEB7696E539EEE7FB1B603D08642FB1F2D0CB9A8A5FD3576A6EBD4DF6863CDA3A5CDC5DA0E409BE30BEDFDD0CAC5136D6F8953DCD77BE2FABDD5E4D0BB1D80364717DAFBA1D53207ED9B8B53A57290BA06BB9ADC59DB5ADB01687364A1BD1FF62D07BFF6ABE97B92547E52D760539B3B6B5B6B3B006D8E2AB4F783EAFE4CEBF3B5AFA5CFC97239CA5D475AEB3B6769DF322E803A5B165A3D9852916A5F52EA8F4FA55CE5AEE353CF7B67E9636903A0CF7685560F268D94D2BDCB537F7C2AE5AC740FDF7AF364E96B6903A0CF3685F67E28D58CF5D4E7E93ED29E72465EF35ADF6565E96F6903A0CFD285560FA496714A7D5AC73C9D356FD676A7F1CA8B650C4B1B007D962CB4F783A8E750D2BE3A5EEBB8A7D2BC3DE5CEDAEE1435B9B3B08C636903A04FE842AB078F462F1D2F15B06BC95D6DFB9D68BE347A59C6B1B401D067D942EB41C7F41AF754AD393C2DFFFACE8D58BF654C4B1B00FDC216DAD187C0A803EE349AC7965CF6F68F4CD7960A6FD6F19FEE03F011AAD0E6C2DBC8B14FA17BE491D3DEFE51683E523192F539963600FA852EB4DE74FC11CFD89DE6CF338F9E63CDA039C8C54C35CFB5B603D0E7D542AB0792F747AF63A7027546E66FD4B89E74FDB9784BCD1CACED00F479ADD0EAC1E4F9D1EB983ABEE7B34E91CAE308B39E63A17349453435F3AA690BA0DD2B85367550E9EF569683B0740F7F691E35467AF3599688A8658E356D01B49B5E68738741EA5A0BEB38963627D1835AE30D9ECFD6F55863152D73AE6D0FA0CDD4425B3AC452D76AE5C6569636BBD3BDD088C0633EBAAE54ECA0652D2D7D00D49B56689F0EB6D23D2BEB18D676BBB8E7BE1411D5CC4FD7A3B1B39635B6F401506F7AA1CD79BAFFA4E640B5B65BC57DED35B18ADC9C753DB9D85DEB5A5BFA00A8B76CA1D5C3B4A67F4DDBC874EDA5589DAE2717276A5D7B6B3F0075B62AB416356D23D035E66257BA4E8DD3B5E6A2B51F807AE10A6DA9CD5D4DDBBBD67E9EEE6BED8D1DE89A2C71BADE7CB4F603506F4AA1B51E0A4FF7BF58C6CA69EDD74AD7DE12BBD1F53D45A9EF893407AD7968ED07A0CE2B859638F780D33CB4E4A3A7EF0E3CD6DEDB1F80DD94427BA787E40981BFBC73726A9E3DD6EB3106009BE985B6A4F4F17B1CA8BDFD514F8BA177FE478E1D95C75A3DC60060B35CA1EDE131066CB4008ECEFD8C6744E0B54E8F3100D82C51683D0E97DEFE28BBEF91C62C6F3C73368FF59D90272092F085D6EBD0EEED8F4FBA371A6F78F3D9A379E5D6630C0076A10BADF7C1D23B0E7EBAE7354A7E753E11E6E4C1733D5EE300B059A2D0F6F21A077F452F643ABF8873ACE1BD0ECFB1003CA3D0A2DA4A456CC579EA7CF5772FEFF100946D5F683DC6C0B75421886E8539DFE7980B2FDEE301280B5968357A788C81F4DEAC24FADC757EA9F0E23D1E80B2F085B687D738A7F3DC9337455FC77D5E3A57CFF97A8F07A02C74A1EDE535CEC93CF7238AA86BD2F7FF6B7EDE73F51E0F40D9B685D66B9C93ED9C43CF77CD93CE2B15BDBCC60160B37DA1451BAF7D88CCF37DF3A273CA450F8F3100D86D59683DC638D969F98BB2DED43CF49ADE6FE1310600BBAD0B2DEA78E57F456FAFBBF47CDD97525B8B9EBE00EA5168F18757EE57A639989987D233754EA5B6163D7D01D40B5B687B788C7112AFBCEF400BD9ACDC589EA1F3B1F44969ED07A0CD7685D6638C9390AF3C2D68A3725433BECEA7A6EF97DAF600FA6C5B68F1CC23DFA7682D6A16AD63B6CEA9B63D803E14DA43B51ED2271B91B3DEF1744E9671ACED00F8A0D01EC823CF27AB2D6C39A3C6791AEFE93E005F5B15DADEFEBBB31EC4B0D17CD6E4B4A54F89CEA33476E91E007F5B165AA4590E61D4D19C5AF35AD3D64AE7918A7B3B0073842DB42D07416BBF53909FB16AF25BD3B646AAA0E602C01C14DA83909FB1F4FDCDBDCBB9EB1E4A6397E604609CD085B6E63068E9731A72349EBEBFA518A5F40C9D43A92D001FDB155AE4696EC9D71C9AF319B92F3D43E7A101C057F8426BF9F06BDA9E4E734BCEE69A95F7D27352D7F59DD0FB00DA852AB417FDD82D1FBDA50D3E698EC9E1189AE3548C901B3B77FDA2F31A3D47E004610B6DEE778AA50DD2F430E560F597CAAB5E1B91EFDCD8A96B4AE7961B0BC0330A2DFED10395BCF6B3E47164BE75CCD6E7E81C3500E42D5368F57AEA3EFC68DEC9AF9DE6CD9ABB963E4F74BCDEB1758E4F016081427BBFA6D7EFF730060767BD9E9C69DFDAFE29F771BCC6BCD3F9E60238D51285F67E5DEFA5AEC19F1E9AE4FD27CD4B6F6E74AC9E31758CD6716AE933673F1F88226CA14D7D8C7A4F7F632C3D2C354EA579F0CC878ED93A766FFF5EFAFC37E702CC16AED05E4A1FA07EA4B976184FF7E1C4BD98B9FEDE67F5F4F5A4EBD00076B35CA1BDF061C6A37BB2FBBEBCB9D6D667B7F4194DD7520A60555B14DAA7F69843F763B7BDD135BDBD369D87862ADD8B42D7F014C00A962CB417FDE09EDA632EDD9B1DF629E23A744E1AAA742F325D57298068962FB4F7BF5BFA613EDD9F95F648E7BDCADC73735D6D1D25BA2FA90022D8A2D0DE7FEB75C4B2CA3EE93C5798F39DCEF96BDEA96B3BD1F5E5029869C9425BFA60F8A0D6A0FBF4C65EE9F373B12A5D472A76A66BAD09D869EEC8E1A7A50B6D8E6E389B1F93EECDAC7DD267E56227BAB65DD769A1EB1F1DBBD2756AE0DB9685F68B6E3C2F415CBA3F9E7BA5E3798EBD1A5DFFA97928D1DC106D816F5B175AA52F022F454CBA37B978A2ED6BFAEEEABE7ECDC9C9791945F3BB6BA06CB942EBB1B9FA9268200EDD1B8DDA76A7D37C689EF43ECEA0FBCFBBE06BD942EB495FAC11CFC033CDBF47E027CD4DEAEFA9C09E749F35E083422BF445E3A5F3A5391D1128BBE7299533CD27B95D93EE9DEEB906C6A1D066E84B980A9469BE2CD142C7E81D6F779AA3A75C59DB2106DDAFA7C078145A237D395B6377BADE548CA4CFD2C05FF77C58F3432EE3D0BDC8056258AAD0467A81F485EE8915E91A72F1369D4F2A4EA46BD7DF259A3F6B3FB4D15C5B02B12C596857A41FC2CE1199CE7595797BD375D7E6407357DB1F659AD754601D14DA97E9C7B352EC40D7B4DBFA4AEEEBEC59B7E6AD658CD369FE34B0B6D085565FB0D435C0831E6C1A3BD2B5E9EF5A9AB39EB14EA0B9D2C03E4216DA4BEA654B5D0346D0436FC70350D7A3BF5B69BE3CC6DC89E686FCEC6F9942CB4B89B7E8A1988A15E9DCBDD7A339F21E3F2A5D6B297086E50A2DF0363D2C573D3853734E5DEBA5395A355F56BAC654E02C145AA0931EA2B9882635B7D4356F9A9791CF0222A0D0024EB4783C4504A9B9A4AE8D10311FC008145A60022D2AA97843EAD9B3E7A47998F55C6096F0855603D881BED76FBDE3B967E6AE8FA23998F96C60B4A50A2DB02B7DD773E12D3776EEFA0CBAE637E600780A5B682F7C6C388DBEF335D12A3746EADA2CBAB637E702F45AA6D002A7D3A2538A5AA97EA96B6FD0B54599176045A10536A0456844BC2DDA7C002B0A2DB0192D48A363B6B79F0FD4A2D002F843BF352D685103882E74A1053097162FFDADB4E8BD114074145A00FF68F1D2DF00EA516801FCA385957F3902FD28B4007ED0C2AABF01D4A1D002F821555853D700D8506801FC90FAEF62FD0DC08E420BE0831656FD0DC08E420BE0831656FD0DC08E420BE083FEF73185166847A1059044A1057C50680124DDFF554BA105DA516801645168817E145A0045145AA0CFBF424B10044110C498F83FFFC42278504DDADF0000000049454E44AE426082, 0x89504E470D0A1A0A0000000D49484452000001DA000000A70806000000B62F9D04000000017352474200AECE1CE90000000467414D410000B18F0BFC61050000000970485973000012740000127401DE661F7800000ADB49444154785EEDDB0BAEA5B61205D00C36F39FC27B42D14948859FED3236B096E4A82FD86530ADDABA2DE58F3FFFFCF37F8661188661F4197F2CFF0100F2095A00E848D00240478216003A12B400D091A005808E042D0074246801A023410B001D095A00E848D00240478216003A12B400D091A005808E042D9FF6C71F7FFC3D007A10B47CD63A64052DD08BA0E59362C80A5AA01741CB27C59015B4402F8296CF89012B68819E042D9F12C355C802BD095A3E2586ABA0057A13B4BC5EFCED751DACF167806C8296D78B211B7F9B15B4404F8296D7DB0BD3BDEB0099042DAFB5F55BECD67D809E042DAF25688119085A5EEB28488F02182093A0E555E26FB15B417A740F209BA0E555CE427671740F209BA0E555CE42F42C8401B2095A5EE52C44CFEE036413B4BCCA59909EDD07C82668798DB37F163EBB0FD083A0E515AE84E8D97D801E042D8F7725641757E6006413B43CDAD5905D5C9D079049D0F25835217B652E402641CB63950467C95C804C82B6D0FA37A338B84FE9B997CC05C8D42D68DFD4D862A0EE0DEE537AE6A5F301B208DA95189C7B23DABB4E3FA5675E3A1F20CBE7833686E8DED873650EB96ACEBC743E40964F066D0CD19AC6FDD3B29672B5E75DB30620C3E78236066BCB73B6AEA74CED79D7AE03C8D02568676B6C3154AF3E5B9C3FD3F89A9677AF5D0790A16BD08E16C3A9E4B9E29AD9C753C5F7381B355AD602B47A4DD0C6861C4789B3B547F7EE109FEF4BA354CB5A800C7F076D6C682D0DAA765DADF8BC2DCFBE385A7F746F94F8CE4F1B474AE66EA95D0790E552D09E8D68EF7A2F47CF52EAACD6D13DF29DFD5D3B53BB0E20CBE93F1DC74697313265D78DF5E2B367EEC5B9D6336F590B90E13468CFC4009A795CB19E1BD797D42147EB99B7AE0768D51CB45B8E9A5B0CAD59C6D9F371BFD6F36F5D0F90E1F6A06DD1127E716DC9E05EF1FC6BBF41CB5A802C8F09DA8CC6BB25D6EDB107D7C56F50FB2D5AD602647A44D0F66E9AB1A9F7DA8763F11BB47C8B96B500991E15B477B8732FFE11C3B5F53BB4AE07C83275D06635DD1277EEC53FD6E79EF10D326A00649836684784ECE2EEFDF8EFB7CEF806193500324C19B459CDB6C6A87DBF6C7DE659DF3EA3064086A9837684917B7FD53A5C33CE3FAB0E4086A98236B3D9D61AB9F717C56F9E71F6597500324C1BB4A38CDEFF6B7A856C462D800C53046D76B36D31CB737C45F6B7CFAA039045D06E98E539DE2E7EF78C33CFAA039065AAA09D4566E3675B76C0FE64D70368353C687B34DB0C333ED35BC490CD3CE7EC7A00ADA609DAD9F40801FE124336EB8CB3EB016410B407667EB6A7EA11B03F3D6A02B41A1AB4BD1A6E96D99FEF6962C8669E6B8F9A00198605ED531AE3539E73763160B3CF34BB1E4096BF8336B3499D35BD1E8DB6A7273DEBACD667D8E33C7BD404C8F0AFA0CD6A5467B504EDF7ACBF798FF3EC511320C3D0A07D8A5EE1F0253164B3CFB2474D800C82F6A2273EF32C7A06EC4FCFDA002D6E0FDADE0DB797A73EF70C7A076DCFDA00AD8605ED1369E8E57A87ECA2676D8056FF09DA8CA67554E3E8DE13649DD11764FE9D3AD2BB3E408B7FFD7FB4598D716F7D46ED19BCE53D7ACBFAFB74A4777D8056FF0ADA9FD6E6B5B776EFFA13B59ED1DBADCFA7E719F5AE0FD06A3368172D0D6C6FEDDEF5A7BA23489EEAAEB3B9630F801682B6D11BDFA9D55D21BBB86B1F805AA7415BD3C4B6D6B5D49BD91BDFA9D6FA1BDF752E77ED03506B376817B50D736BCDD6B537B83B586636E22CEEDC0BA0C661D02E6A1AD9D69AAD6B6F3122606634E20CEEDE0FA0D4E5A02D69665BF3B7AEBD4DCD59BDC1FABDEF7EFFBBF70328751AB48BD206BA3577EBDA1B959ED5D3C580BDF3BD47EC0950EA52D02E4A1ADAD6DCAD6B6FF5D577BDFBBDEFDE0FA04671D05E696C715EC9DA37F8CAFBAEDF73C43BDFBD1F408DCB41BBB8DA50E3FDF8F3175C39A7278BEF37E25D47EC0950AA286817B1C16E89F7E3CF5FB13EABB7BCFFD63BC59FEF32624F8052C541BB386BACF15EFCF94BB682E989E27BCCF07D47ED0B50A22A6817474D2EDE8B3F7FD156403DC5FAD9B79E7FEF7A6FA3F60528D11CB45BCD2E5E8B3F7FD5DE79CDEAE81BAF9DDDEFE1CA7301CCA03A68177BCD2E5EDF9AF355F16C66B47EC6B367BD32A787117B02D4680ADAC556A38DD7E2FDAF9BF93CD6DFEECA335E9D976DD4BE00A5528376DDFCF6FECC7FCF6C06A5CF543A3FDBA87D014A3507ED62ABE9EEFD99BF6C9DD92835CF52B326D3A87D014AA504ED4F6CBEBF46A829EEDB3AAF3BC47D4BF7AE5993A5F699014610B4938867D653FC46357BD6AECB30726F8052A941FB131BB8C6784D3CB76CADE1BA9651A3D6C8BD014A09DAC9C4B3CB100336A376569D1A23F7062825682794755E315C336AFE64D72B31726F80525D8236D218CBC470AC39BF96B557F4AA7BC5C8BD014A09DA49C5A02C39C3D2F9357AD73F32726F805282F621AE04EE953959EED863CFC8BD014A09DA87D90AD218B0779CF55DFB6C19B93740A95B835673CC114375C4D98ED8F367E4DE00A56E0F5A0DB24D3CCB51E7F9D5BD014ADD12B48B19C2E1C9E2F9C571B751FB2E46EE0D50EAB6A05D8C0C86278A61BA75767BD77B1BB1E7CFC8BD014ADD1AB48BA3D0E02FF18CCECEEACA9C6C77EFB736726F8052B707EDE26A807C493C93D2B3A95D57EBAE7DB68CDC1BA0D490A05DDC1D0CB38AE7D0721EB1464BAD333D6B9F19B93740A96141FB734728CC24BE6F8F778F75336BFFF4AA7BC5C8BD014A0D0FDA450C85B735D1F86E71F494BD57AC9755B7C4883D016A4D11B43FB1793FBDA1C6F718F93E59FBC777D91B3DDDB1074096A982F62736EDBD319BF87CB33D6BD633C53A574796EC7A003D4D19B43FB151EF8D91E2B3C431A38CE78BEF593B6AB4AC05B8DBD441BB2736EBB3D12AD63B1A4F91F1DCB1C651AD38E7689CB93A0F60068F0CDA9FD8A0478D276B798FB82E9ECB59CD38376300CCE6D1417B456CC4B5E3CD6ADF756B7E6DADB558A3C7A0BF78E65B03BEE0F541CB75A50DF0686ECF86BA5733EE39C3F8A278064703BE40D0F22F254DF06C5EAFA6DA5A2F3E97316EC017085A365D698667F7173D1A6B66AD9EE2BB7F6900FF10B4EC3A6B9E7BD7B71CD529955507E00E829643316CD701B775ED48C9DC23597500EE2068B9E42C6CAFD8AB51AA753DC09D042D45625096865E46D8B6AC05B89BA0A5580CCB9AD0CB580BF00482962A31684B832F632DC013085A9AC4C02C0DC19635004F2068691643B634087BCF071849D09222866C4918C63567EBAECC019885A025CD3A004B827311E71FAD39BB0F3013414B9A18805783333A9B7F761F60268296347BA1BA777DCFD9DCB3FB003311B4A4DA0BC175D86EDD5F3B9B77740F6036829654472119C3766BCECFD19CBDEB003312B4A43B0BC218B67B73F7EE6F5D039895A025DD5E4046B561BB750D605682962E4A82F02C38B702F9683EC04C042D5DC4603CB315A67BF7D73F03CC4ED0D24D4D18C640DDBA17FF0C3033414B37B561B817B65B411BE700CC46D0D2CD3A0C4B03716B4DACB73507603682966E62209684625CF75B1BAF95D4041841D0728B9A508C81BA5EBF771D603682965BB486620CD63800662568B94546306ED568A907700741CBAD6250D68881DB5A0FA02741CBED5A833106ACB005662668B95D66300A5A607682962132C331866D464D802C829661328331066D464D800C8296A1B2C231D669AD079045D0325C0CC7DA808C355AEB016410B44C2106634D38C6F52DB500B2085AA613433263008C2268994E0CC98C01308AA0E57562C80A5A602441CB2B095A60168296578A412B708151042DAF154356D00223085A5E2D06ADB005EE2668793D410B8CF477D01A86611886D167FC1FA766CE1D7B0FAA400000000049454E44AE426082, N'This is a test', N'Caregiver', N'Drawn', N'', CAST(N'2025-04-15T21:58:00.727' AS DateTime), NULL, 38, 1)
INSERT [dbo].[Service_Logs] ([CaregiverID], [ClientID], [date_time], [tasks_performed], [caregiver_signature], [client_signature], [notes], [SignedBy], [SignatureType], [TypedSignatureText], [SignedDate], [SignatureData], [ShiftID], [LogID]) VALUES (5, 10, CAST(N'2025-04-15T22:01:30.447' AS DateTime), N'Bathing
Shaving
Hair Care
Skin Care
Mouth Care
Nail Maintenance
Prepare Meals', 0x89504E470D0A1A0A0000000D49484452000001DA000000A70806000000B62F9D04000000017352474200AECE1CE90000000467414D410000B18F0BFC61050000000970485973000012740000127401DE661F7800000C7549444154785EEDD9EDCEA4B81106D0B9D8B9FF5B48D43F3ACB3A06FC5105863E47225AC02E17F48B1F8DF2E7EFDFBFFF71381C0E87C39173FCF9FC0F00104FD0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D00240A24707ED9F3F7FAA0700ACE29541DB7B004096C7066D2D28CB00ED3D0020DAE38236321C236B0140CDA383368AC00520CBA382362B0CCBA08DAE0FC0EF7A4CD05E1184E51A59EB00F03B1E19B499042D00911E17B45711B600447844D0DE157A77AD0BC07B3C2A68AFB60DDA3BD607E0F904ED89326CEFEA837C7E6720C3F241BBC2C6576EC077F7430EBF2F9061D9A05D75D35BB12700D625680794BDADD61F00EB583E68575486ACC005608FA09D5406ED137A06E03A823688B005A066C9A07D72603DB56F00722C1DB400F074CB05ED93FF350B00A565831600DE40D0024022410B0089960A5AFFFF2C006FB364D002C05B2C13B4FE350BC01B2D17B400F02682160012095A8046DBFF8BCB7E452B410BD0A00CD9F2803D8216E04419AA7B07D42C11B4FE508155B58469CB187ED7ED41EB8F135855EBFE5406EDD9787ECB32410BB09ADEFD49D0522368012A464373640EEF2668010AA321FB313A8FF712B4939EDE3FF06F33210B358276D2F6A37CF2730042961C827692A0853EAB7E2FABF6C5F309DA4965D0FA58E1FF95DFC68ADFC88A3DF10E823640B979944786CCDA10A9FC1EB2BF8D112BF6C47B08DA00E5E6511E19326B3F5DF9FE5B0F72D4DE71797EA75A7F1049D0062B37EFAC67CBACFD44E53B8F3846CCCC7D9BBDF759BB76A7957AE19D046D82BD0D265266ED4857BE8BF26855CEEB9DBF353BFF2DF6DE65EDDADD56EB87F711B493F6FADFDB68A244D5CDE8B3AC591E9122EB46F4393BFFE98EDEE1D1BD3BACD60FEF756BD0BEE10FFCE819323FE4889A657FB3F53ECA7AB5234246CDAFD99AB3F39FACF69B64FE56A356EB877713B493CE9E216B9399AD97D9D35EDDA37BBDCED69A315B7766EE531DFD1E47F7EEB2522FBCDF6D41BBDA8737EAEC19B23699997A19FD7CB4D43DBBDF2AAA4E4DCB731C9999FB44DBF7557BF6DAB53BEDF509596E0FDA276BFD60CB4DE86C7C8BD13A913D7C94CF7556B7654C8BA83A353DCF533333F789CE9EF7E8DED5CE7A850C827642EB336C3FEED6396746EA44AEFFD5F35CADE35A44D5A9E979A69A88B94FB2D7F3EC7BCCB0522FFC0E413BA1F519B6E3A2369EDE3ABDE35BF4D4EC197B26B256CDB6FEE81AA37347E79DC9A8F9B1F79E22DE61B4D5FAE17708DA01BD9B4839BE75DE99D63A916B6E9DD52D9F776F5CAFE87AA5889E47E78FCC3933DA4B8BBDBAD16B46D49B9D0FA304ED80DE8FBE1CDF33F7486B9DD671BD8EEA6E9FF968DC88E87AA5A8BE47E647ACBB155D6FAB563BEADD9566EBCECC85598276C048EFDB39B39BC6D7D9FCA8756A6A75CBF5CAFB51B2EA7E95FD8FAE353A77745ECDEC33ECD9AB1BF1DE8E8CD61D9D071104ED8091DECB39119BD1D1FC6DFDA371A36A35CBF5CAFB11326B7F6DEBCFAC35DAEBC89C3D91B5B6F6EAEE5D8FB2C23B855E8276C048EFB539A39BC6D7D1DCD9DA47B6B56B47A6ABD7985D6F64FEC89C9AACDF64AFEEDEF568236B8CCC812882B6D3E866529B335AEB6B6FFEDEF508DBDAB523D3D5EB94FF3D62647ED47346D529D56A66AD55B35DAB65BD9EB19041D0761AFD68F7E6EC5D6FB1D7CBDEF559DBBAE57185ABD6DAAE33BBE6E8FCD9F73B33F748D957795CA567CDD6719045D0761AED7B6F5ECF8651539B5BBB1661DB6B46FD3357ADBB5D6776CD99F933EF7A66EE9EB2E6F63C729D563DEBB68E830C82B6D368DF47F36636ABDADCF23C4A6DAD2B5DB5F6769DD935EF9A3F3AEF4CF95E32D668D5DA43CB18C824683B8DF67D36EFECFE91726E791E29B3F699ABD6DEAEF3FDEFD175A3E6F71A9D7764FB2C19F547B4F4D132063209DA4EA37D9FCD9BD9BCCA79E579A4CCDA67AE5ABB5CA73CEF35337F74EEDEBCEFF5BDFB4766E66669E9E7EC3E6413B49D46FB3E9BD7B261EC29E795E751667A8C70D5DAE53AE579AF99F923EFFC68CEF6DEDE989A724EEBBC2B9CF573761FB209DA4EA37DB7CC6B1953536E7EA375CE94EB5CEDAAB5CB75CAF35E33F3B7EFBCB546CBD8B2EEDE9CF2FED1D8BB9CF573761FB209DA4EA37DB7CC1BDDC4CA7923355A64D56D95BDFEF63D6ED729CF7BCDCEFFE8A93132B6F558D1516FABF7CE6F10B427CA3ECBF3562DF3B69BC2D9D8D276CEC8FC1659755B65AFBFF7FECBF35EB3F33F7A6AF48CFD2A9F7DEF58D1516F47F7E02A82F644D96779DEAA75DEE8A6B69D3732BF4556DD56D9EBEFD5DFBBDE2AE237E999DF33B64544FF998EFADBBB0E5712B427CA3ECBF3563DF38EC6EEDDFB5EDF1ED1B2EAB6CA5E7FAF7EC43B8D9ADF52A3755C8B9E75EFB4D7E3DE75B892A03D50DB646AD75AF4CCD9AE51CEA95DFB3A9A1721AB6EABECF5F7EA47BCD3A8F92D355AC7B588AC9569AFCFBDEB7025417BA0D6E376C3ABDDAFE919FB7154BF76EDEB685E84ACBAADB2D66F796F47F75ACCCEFF68E9F3E3EC7E8FC85A99F6DE4D790E77B83D6857FE088EFADBFBB06B5AC7956AF3CAF3AD9E9E4664D56D95B57ECB7B3BBAD7E2AC7EAB963A67F77B44D6CA567B37E539DCE1B6A0FD58F923A87DB4A5ED989671BD6AB5CBF3526D4E94ACBA35B5B5B29EADA566CB983311353ECEEA9CDDEF1159EB0A65BFE539DC41D0567CFB6AE96D3B766F5EED5AABB2E659ADA33E6665D4DC535B2BE3B95A6BB68C391351E3E3ACCED9FD1E91B5AE50F65B9EC31D9608DA553E846D3F3D3D95F3F68E11E5FCB35A116BEEC9A8B9676FADC867EBA9D53AEE48448D8FB33A67F77B44D6BA42D96F790E77B835683F56FA10BEBDCCF454D698ADF751D639AAD53A6E4446CD9AB3FE8FEEB53A5BA3D433764F448D8FB3DE8FEEF58AAC7585B2DFF21CEE20683756EA656BBBB19EF5D83A6E4446CD9AB3FECFEE1F197D3FBDE36B46D6DD7354E7E85EAFC85A5728DFF1D3FAE79D9609DABB3F8655FAD8B3EDEFACC7D671BD326AD69CADD3F32E4AA37347E6D444D4F838EA67EFFA88C85A57D9F6FCC4FE791F413BB1F95EADB5C7D671BDB2EA965AD768ED673BAE65FC9E99B95F1135BEF66AED5D1F1159EB2AE56FFDB4FE799FDB83F6E3CE0FE2CEB5B3643D5356DD52CF1A673D6DEF1F8D6B313BFF23A28FAFBD5AB56B23F6EA3FC1B6F727F6CFBB2C17B4577D1477ACF90657BCB39EFA47BFE3D1BD11ABD6296BD5AE8D88AA7387E8DF1E662C11B45F577E143EC43199EF6CE63729E79647849E5A47638FEEF5AA3D63793E2AAA4E86B3DEB6EFE5681C5C61C9A0BDE2C3B86A9D37CAFA9D6636C772EE689D233DF58EC61EDDEB557BD6A8FA5175A295CF5B537B2F7097A582F623F3E3283FBE8C357E41D63B8CAE17ADA7BFA37754BB366B5B33AA7E549D0C47EFB7E53E5CE9A783967119EF32B25686DEFEF6DE4FEDDAAC6DCDA8FA5175326CDF6DADC7B3FB70A5E582F623E3E3F0D1C52B37B3D1773C33F74A23FDD59EAB3C8F50BEC388FA5175321D3DF3DE75B8DAD2411BF59144D6E2DFCADF6AF658D9688FE5F38DD63913FD2EA3EA64DB7BE6BDEB70B52583F663F62329379DD13AF429DF79CFB1BAD13ECB672CCFA344BFCFA83A57A8F51AF92E60C6B241FB31B27194737AE6C29199BFA5F2EF71A6D691C8DA5175AE507BEEDA35B8C3A38276E48028B37F53E5DFE64CAD3D91B5A3EA5CA5EC37F25DC08CA583F6ABDC9C5A0E8816F9B715596B2BF21B88AA7395A7F5CBEF7844D0C20A9EB0910BDAE7F4CBEF10B4D0E8091BF9AF066DE4734334410B8D7E6D237FD2F30A5A562668A1D1AF6DE44F0AAFA7F4C96F12B4D0E81737F3A73CF353FAE437095A68F48B9BF913FE55FB841EF96D82161AFDEA66BEEA736F0376D51EE143D042A35FDDCC570D3221CB53085A68F0CB1BFAAA81B65A3FB047D042039BFA3AEF60D5E0873D82161AD8D4D7F957BDA0E569042DAF90BDE966D77F8ABBDE4319AE77F400A3042DAF90B9F9DADCFF7147D8956B5EB52E4411B4BC42E6066C83FFB7AB42EFAA75209BA0E515B236631B7D5D1982B3EFA7AC551EF064829657C8D8906DF6C7CAF79371C01B085A5E216363B6E1B729C371E6803712B4BC42F4466DF307A2085A5E213A18A3EB01BF4BD0F20ABDC1B81D7F7400CC12B4BC462D1CCBE0EC390022085A5EA30CCA9603209BA0E535CA1015A8C00A042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D0024FA5FD03A1C0E87C3E1C839FE0BCC2E9366B6A525D10000000049454E44AE426082, 0x89504E470D0A1A0A0000000D49484452000001DA000000A70806000000B62F9D04000000017352474200AECE1CE90000000467414D410000B18F0BFC61050000000970485973000012740000127401DE661F78000009BD49444154785EEDDA018EE4281205D03EECDCFF0A3BAA95B2E571D96930814DC07B122B551A438493F2EF1AED9F7FFEF9E77F8661188661F4197F7EFE070088276801A023410B001D095A00E848D00240478216003A12B400D091A0DDF8F3E7CFE500801A82B63060052D007708DA83A03D52320700F6960FDAD2F0DC07EDD57C00F821682B83B3763E006B13B43742F3CE3D00AC69D9A06DF9CFC02DF702B016417B332C5BEE05601DCB076D8B883500989BA06DE0AF5A00AE08DA46C216806F046D80C8B50098CB92411BFD5768F47A00CC63B9A0ED158A3DD60420BFA582B657C8FED8AEDD637D00725A32687B11B400EC09DA604FEC01401E823698BF6A01D812B4C1042D005B82B68396B0BD7B1F00635A26685BC2AF56CB5E77EF03604CCB05ED53EE86ED9D7B0018D712417B37F45ADDD9F3CE3D008C6BA9A07DDA9D80AF9D0FC0D8A60FDA3B6117A976FF9AB9008C6F99A07D8BA005589BA07D404DD896CE03200741FB90D23A4AE7019083A07D48E95FB5257300C843D03EA8246CAFAE03908BA07DD8553D57D701C845D03EECEAAFDA6FD700C867EAA0BD0AB5375CD5F4ED1A00F92C11B4A3D986EDBEBEA3CF00C84BD0BE44D002AC41D0BEE8A8BEA3CF6014CE27D49B3668CFFE621CC9518DFB9F6124CE27D49B3E6847B60DDA4FAD19EA665DCE27D49B3268F7E135B27DAD59EA664DCE27D49B3A68B3D8866DB6DA598BF309F504ED00F6219BA976D6E27C423D413B08414B06CE27D413B40311B48CCEF9847A8276202D417BF73EA8D172466155827630996B670DCE28D4992E68B3FF8B7B5B7FD61E989BB30975A60DDAAC042DA37336A18EA01D8CA06574CE26D411B48311B48CCED9843A5305ED0C0195BD7EE6E78C429D298336B3197A606E33FC83169E24680733430FCCCF39857282763033F4C0FC9C532827680733430FCCCF39857282763033F4C0FC9C5328374DD07E7EF1B3FFF2CFD003F3734EA1DC74419BDD2C7D3037E714CA09DAC1CCD20773734EA1DC1441FBF9A59FE1177F963E989B730AE5A60ADA19CCD40BF3724EA19CA01DCCA8BD7CEADA0FD6E4FB8772827630A5BD94CE8BB20FD8A391D5BE8FDAB1A2957B875A827630A5BD94CE8BB2DF6F1F364FD6D26A5F77D458C98A3DC35D827630A5BD3CF982BFDAEBDBB5516C7B381A7745AC91D18A3DC35DE98376B6175D692F514171A5648FABEB6FDA3FA7927E6A45AF97C18A3DC35DD304ED2C6AFAE9111A7B25EB97CC79CBF619F5AAF1893D46B352AFD04AD00EA6B69FDE2FF892B54BE6BCA1F7B3D97A72AF11ACD42BB44A1DB433BEDCEEF473E79E52256B97CC79D2F65C3C59D71B7BBE65953E21C214413B933B3DF50C9692354BE63CA5E7B3B8F2D6BE6F58A54F8820680773B7A75E2FF992354BE694685D67FB0C5AD669F1E6DE4F5AA54F88206807D3D253CBBD674AD62C9953E2B3CEDDB55AEF8FB0ADE1CD3A7A9BBD3F88246807D3D2538F177CC97A25734ADCAD7F7B5FEDBD3D8C544B2FB3F7079104ED605A7A8A7EC197AE5732A744E97E7BDBFB6AEFED65A45A7A98BD3F88246807D3DA5364E094AE533AEFCADDDAEFDCD3DB8835459ABD3F8824680713D153C41A3F4AD6F9CCB99A5762BB56CD7AB5F39F30624D9166EF0F2209DAC144F414B1C68F6FEB7CAE6D47AB3BEBD5CE7FCAA8754599B9378826680713D153C41A3FBEADB30D92B339B5F66B5EAD5B33F769A3D61565E6DE209AA01D4C444F916B1CADF3ED5A8BED9A577B5C5D1F41861AEF9AB52FE841D00E26A2A7DA17FC767EED88B25F73FFF3DEB76B23C95267AD59FB821E04ED60227ABA0AA9BDEDFC9A11E968DDFDCFFB79FB6B23CA5267AD59FB821E04ED60A27A6A5DA7F5FE5A47FB7DFBECE8DA88B2D4596BD6BEA007413B98A89E5AD769BDBFD6D17EFBCF3E3FEFE78D2C5BBDA566ED0B7A10B4376C5FF8FBD16A94755AEFAF75B4DFFEB3C8E7FC948C359798B127E8256DD0BEF102DBEE79365A8DB24EEBFDB58EF6DB7FB6FF3983E8F3318AD9FA819ED2076D4FFB97E47EF410B576EB3AADF7D73ADA6FFFAC8FE66491B9F623B3F5033D09DA2FB62FFA27F6FB11B54FEB3AADF7D73ADB6FFBF9D99C0C32D77E64B67EA027417BE2B37ECF3D8E44EDD9BA4EEBFDB5CEF6DB7E0F677332C85EFFDE4CBD406F82F6C05B2FF6C83D5BD769BDBFD6D97E6F7D17D166E8E163A65EE0098276E7CD177BE49EAD6BB5DE5FEB6CBFB7BE8B1EF4016B12B41BDB977AF4DA2522F76D5DABF5FE5A67FBBDF97D44D3C7F8B6E76DA6B3C7BB04EDC6DBBF58917BB7AED57A7FADB3FDCE3ECF28BA97ED79FD3622F55A37D2BEFF6FA3743EB44819B43D7E017AAC592B72FFD6B55AEF2F75F5423BFB3CA36F7DDEB17F76572342E45AADB6B5EC7B6D19677BC05DA98336D2D92FDA93DEDE7FEBA9E771B5CFB76B193DDDCFF6F9D68C3357D77BD9D77735A244AFC79A046DC1CBFE2923D4F0F1D433B9DAE3EA7A366FF5B3FD3E671ABD3DB50F7313B40F86CA95116AD87AA29EAB3DAEAE6733CA59FB665BE348E30D6FEECD3C046D87F5EE1AA58E8F27EAB9DAE3EA7A46997BCA5CFB1DABF54B1FCB07ED67ADA8F55A8C52C747EF7A4A9EFDD5F58C32F794B97678CBD2415BF2A27FD248B5FCE85D4FC9F3BFBA9E51E69E32D70E6F593268B72FF89675A2AD564FC9FA2573B219F5FC95C85833BC4DD036AC136DA57A4A9F7FC99C6CF6E72F537FD9EA85112C1DB4A319ADAE5E4150B36EE9BC4C6AFA1F4DD6BAE14DCB056DE697DC1B7A3CAF9AF56AE666D1E3993E256BDDF0A6D4415BFB0B7FF7BED5453FB3E8F5B2C97C0EB3D60D6F4A1FB4572FADFD9CB3799C8B7E6ED1EB6593F92C66AD1BDE9432687FECC3B374502FF2F945AE9555E66790B56E7853DAA0DDDA87E9D1E0BEA86719B1C60CB23E87AC75C3DBA6085AFA8B78C9B6DE3F8B8867F9868C35C308042DC55A03A2E5DE99B43EC7B764AC1946206829D61A102DF7CE26E3B3C858338C40D052A5366CB7F34BEF5945B6E7E13B847B042DD56A8253D0CEC17708F7095AAAD58467C91CC6E77B84FB042DB75D05EEB76BE4E27B84FB042DB795062DB97DFB8E816B829666FBC0DD0F72F33D421B414BB37DB00AD9B9F82EA18DA0054EF94713B413B4C029210BED042D704AD0423B410B9C12B4D04ED002A7042DB413B4C029410BED042D704AD0423B410B9C12B4D04ED002873E212B68A18DA0050E09598821688143821662085AE090A0851882163824682186A0050E095A882168815FFC3F8E218EA0057E11B21047D002BF085A882368815F042DC411B4C02F8216E2085AE017410B71042D2CEE28548F3E03EE11B4B0B84FA86EC355D0421C410BFC0A5B410B71042DF07FFB9015B41043D0027F095A88276881BF042DC413B4C07F085A88256881FF10B4104BD00240478216003A12B400D091A005808E042D0074246801A023410B001D095A00E848D00240478216003A12B400D091A005808E042D0074246801A0A3BF416B18866118469FF12FB57FFF786BC964440000000049454E44AE426082, N'This is a test', N'Caregiver', N'Drawn', N'', CAST(N'2025-04-15T22:01:30.447' AS DateTime), NULL, 38, 2)
INSERT [dbo].[Service_Logs] ([CaregiverID], [ClientID], [date_time], [tasks_performed], [caregiver_signature], [client_signature], [notes], [SignedBy], [SignatureType], [TypedSignatureText], [SignedDate], [SignatureData], [ShiftID], [LogID]) VALUES (3, 2, CAST(N'2025-04-15T22:08:48.067' AS DateTime), N'Bathing
Shaving
Hair Care
Skin Care
Mouth Care
Nail Maintenance
Dressing
Assistance with ambulation/transferring
Prepare Meals
Wash, dry, and put dishes away
Wipe the exterior of appliances
Take garbage out
Changing bed linen
Toileting/incontinence care
Assisting with housekeeping
Vaccuming clients bedroom and bathroom
Assistance with laundry
Wet and dry mop bedroom and bathroom
Medication reminder
Gathering medications
Read medication for instructions
Open medication bottles for clients
Reassure that medication has been taken', 0x89504E470D0A1A0A0000000D49484452000001DA000000A70806000000B62F9D04000000017352474200AECE1CE90000000467414D410000B18F0BFC61050000000970485973000012740000127401DE661F780000095849444154785EEDDC6172A3BA1206D02C2F0BCA72B2976C253BF12B02764008D112EEC97DE573AAF833012C09AA3F4BE079BB010069DECA7F00009E47D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042DFDBE3F6FEF6F6FB7B7EAF67EFBFC2EF7FDB87DADFEE992AF8FDBDBC7D3CEF6FF6F1A8FDD35586FDBB1FFFE7C377EF08F095A82BE6E1FAB025EAFD5DB7D1EDBFBE76D9DBDE396F3D73F7CE7EBA3D296D6D6D9CEEEF31F6EC5979333C5179DF7A3830F42B8357CD13ECDE7F8BE7DBEEFFF56DDAA1F7A70BFDCB7E57A44DB74BED5C7B9FBFC9DF709085A4EAC8B69BD50957E664DABC27418045D7EDBD177BE4A18EC0A6551F0777F3FB10BB4B319FCE8E745BEECEC6D83E4AC6D8B5D9FA6AD71FDABFBC73EABBC5F0E8FDB7DC6C17E0F3DE3FC0FEE135E96A0E5D8BAB075169575718F0642CBBA18F79FAF2890D5131485B6ABBF63C73EFA546D4F6113326701535AB52FD8B65D9F5A21BBD806FAF9FEBF7EAF4FFB4B54F63867DF27BC2A414BD5669631524C1EC1D01B0A15C55269B5FE35056782C58CA95DF4D7B6E7EF3DEEB03D8BCBD762B28C61BC6D45A09C35B26C67CF755FC6FDBC6DB9E35C9EFF70FFE1FB84572568D9192E981B4BD11A0D8687FE99D5CE26A85BC70F2E0D0E7F1198FAD66ACFB3AEC564EA5BFBB3B682A1B3B299D146C7EE7E7D231F9038CE3FB2EF135E96A065ABF8B61E2F66A5B9805EFDB6BF7F51A555000F8497C0CB500F06DBF0B2EED7EDA3D19EF2D9E5F8B5984CE1D0D1B64D9F6263BEB956C1C6FEF4B131061B49E3FC907D9FF0B2042DBFCA9FED048B65DD5C8C2E9DE2A7F0BDDF3E3F470BEC6C1D00EDE01F2BA0230173EAA9D762395FC739FA67A7FD4BCD731F63213E4919E795ECFB84D725685994C5235E00EBA6F35D2940F3F2DC4FC11B9EC94C7A9640479604479F1BB694D7A2B7CF578DF4A9F798E873D3BBDEF3F7CABE4F7865829659F9D38976A549B604CD52C02EBD0CD413D2232FB9849758BF6F9F1FC1B6FFF5B5187A16DA1354CBECF16CA7B58C715ECBBE4F78698296CA0CEABC50669A83F5B7985E5932DC84F4C9B1233F4F09BFACF4F5112CC8E5B588B5E399C27D5AEB08E7F9FCC1F32EC26D0A8FF356F67DC26B13B4EC8A64F7ACF19996B6AC6BDD78D06E43AB5980876629F1E792531F1A7FFEF5E7D722DEA78DE88CB3F3B9EC2CDEA6F0386F64DF27BC3A41CBEEEDD65621CBB514BCCDE77714C152F4E71AA3C5B308C5C3E3EE2F751DFC79ADBC1687E7CCD23133DD082DBDAE9EBBF74818E78DECFB849727685F5EB954D9515C9F6C9EB996457A3C684F9FED96B3C75691ADD88662FDD8C76CBCF6F93BFF816B119D9916224BBBDDCF6517CF1FE7ADECFB0404EDCB2BDEA0FCAB22B214F87D1DEE7BC9666DFB2CADB1D58A6B40F8FCD3166AF8856BB10B83C6D6E86FFFCF7A66676135F25CF6EEF9E3BC153E7FA55F1021685FDDAE408F15C36B5A4B8AA3417B7C5C64F6752EF27393DF7D42ED7ED6B528DF5A0EB721D2A7BAE673F4A1E7B2779136758EF346F67D028296B228FFC1B7F69F227DF4B9D1E767A5D633C3D1E7906BD125D69E907956D0EE42E228A00AD13EEDB45E566A7D890A88B6A9679CD7B2EF1310B4FC75D0CE81D02890AD42D8D09C6135832126BEC41AFCEFFF264F0CDAED7268EC3C67CBBFC78E9FA38F3E97BD4B19E795ECFB042682F6D5FD65D0EE82E56C8B054659206BF5F1DAB2E071B0EC4C7DAC35A066371EBDEDBA1B09889163EEEACBAF579ECBCE92C6F921FB3E8199A07D756571FF67415BFB29CFDED02C2BB2DC1CD9E748CF9262D77FA050BE75DCD9AE87C873CD424F9F4AB563977FEB3A4FA976DE235DE3BC88DC03917DE084A07D796571FF37DFDAE725BBF3CF1A09DAD8311DB3A542E62CA77C03B6192E47A2CF35572EF5691746179FCB2E2EB52920FB3E813B41CBEEC599A1E2DEE3F0A73C7BED676835F1C2182BB4A52B4BAC014FF84F1146FAD53FCE2BC573F48FD6CB6D61C9E39C7E9FC02F41CB6E89EE5A519B0A586B16D533DB1928B6BBD955B9C34ACFBE0FF5E7917DA6731CCDD0AEAE300C8CD9C53E955FD4FADB5C73AD4DB3C638F75CFB9E7DA142D0F263BB64395E4CBE3E5AC72E21109E15C4671D0F5D6F290F84D2C0B26C691AEB665F8A2F3ECD7D4B3DCF35EF2EF6A90CDAD0679EB9D8A649739CB3EF135811B42CAECEA4E6C2D6AA417398F714CDDE977AFA0B62EF73C0F8CF4DEA869E4D07F67FE80A90D973FA14BD4631CF69D351FFF3EF135813B4AC8C86ED1C88C7F56A75DE9EA2D9FBBCB277FF49CFB279CFBE3BAB2F0DD1E3AE8666E473AECC9E7F0C5EDB96EC71CEBE4FA02068D92997028F0BE8BDA83542A02C50CD405EA91CD73CB6BA7FA35D0FE5978BA3FE6E67D7C7FB15CADF2977CDE827C5E71E0EC0BE7DA701323C666BF7F1EB3DEEC8BE1F4F1DE7E13E47EF13D813B41CAB16A560811A3CB6FC79CBE1B6044E74FFC37CAA7DB1786CCB1BB4BB7FBFB0B51A72E2B89DBFDBF9E92B4176B49D9FEC71BED0AE0DD1EB18DE8A0645CFDFEAC7F1F8D7EF65B813B4009048D0024022410B0089042D002412B42F6AFF4287CD66BBB2C11177C78B2A8B84CD66BBB6C1117707002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D002412B4009048D0024022410B0089042D0024FA1FD3768F278D755B970000000049454E44AE426082, 0x89504E470D0A1A0A0000000D49484452000001DA000000A70806000000B62F9D04000000017352474200AECE1CE90000000467414D410000B18F0BFC61050000000970485973000012740000127401DE661F780000077649444154785EEDDDE171EA380085D19497822827BDA49574C20E101223644B16DC7D2873CE8CFF6CB063396FFC21DBB06F470020E6ADFC0F00C0F3082D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D0004092D7FD3D7C7F1FDEDEDF8565DDE8F1F5FE56B0FC7CFC57F027816A1E50FF93C1E16413D54CB79FB9A9FE5FDE3B86CEFE66B6B4B75FD759F87CA362ACB720CBDEBB497DA1B8DF235DF4BFD20DEDBDAC6F7F2B3A9CFC3DDCF1E5B8AF1C08B115AFE80AFE3C7FBBE93EED7C7FBCDC9FABDB152F9FAF3B233AE55D5E834C670B74E6B365EBC61D8D8EFFB98B7B65D5AFE2DEAA1BE3D9695ED17D1AE6CE2F6351BE3815720B4CC6D199D9D27DC6554AA27F31BE5ECB612882145985A913D2BD6E91CF74FE01A832DDF54345E7E67FBF75CF77D7D9CCD105F5DFFF6D5DF03AF436899D6CD09B93336377E22BD7132BF2A6659AD1970BFF60CF0DE6DF4FBF7E5B25EFB578C85FCEAF277590BE9691FD67E767133ABDEDAD9EFBFC9D64BE015082D53EA9EF56CFA0E564F486E2ED76E87629F9EFBCA859E4BAB55A78076ECFBDDFDD68E7516CEA15C3BA6A7E3B8B9C33B8E8787D89884D0329FE21EE5E6C978D365E6D63323BC9965AD4564C448C06FD6D9139ACFE3A163DFAF33D2F7C5ACB6E7185D5C42B9F6FACF43638C7B8E4733DAF01A8496B994B3AD874EB497D0B637317279B7CF48C0BB2FAD0EF91EEBE173ECAAC1F9EFB316C8AFE3C7617B8C7B8EC769FF9E3E7C08105A2632F2E0D096D3F63A02327CA9B665E45EEBC83A7B2CEEE30E8CFB12E78E635A75FBF77DFED8E0DF105AE6517EACA5E7CCFF044333BB1E0321EBBFB4DA9E3D569DB7FF3BC67DB3E7DFD9F0909BE3B13536988BD032897236DB19A687E52E1B8F04BC7B9DCFC3D08CF0EE41A6EEB0FF8672F410758F0D2623B4CCA1BC37DBB87FF73CA94BB52301EF5FE714CC8D1FAFA83DC8D43FFE675E36DE1A1BCC46689942F9250AFFDB8978CF8C6E8F91CBC6BD9FE53DEFF3C0BEAEACD7F779E5072F1BEFF9580F4C466899C0BFBA6CBCEF29D85D06027EFB66A3BECECFFE0EECEB79FBB5F5BADE14F47E19C68AE18F2CC1EB135A26507EFD613D32CFD77FD974AF9180DF7F0FF1C6B2BB78DB33D2E643512BB3E15E23C7036621B4BCBEF2FEECFF35E3893D053B12F09E757E5F536BE1A6D6834C8D19F8DD4354BBF48C0DE625B4BCBEF2633DC327F47D624FC136A255D5BBCEE61746AC6B3FC8B415C3DA43543BF48E0D2625B4BCBE7F12DADC53B07D0F17DDEABFB4DAF7358BA5F3F61B635CDDEF072F1BAF6E17FE08A1E5F5FD8BD0763D00346224E03BBE31E9B4DF5DDB5CEA7C9069E5983C76D978E478C05C8496D757DEA31D3EA9EF907A0A7625569BF6AC33F24515DD33D25A14B71FA26ADA33369894D03281F2E33D4F0CDF8AFE4BB5FB8CDCF71D59678F5D33D2F20D48EB21AA86F4D8E015082D5328BFB062F4C4DE67EBC19F0EA7F8AC84ABF931993BB559E433ED7D90A9FCA8D56381DC7F3C603E42CB1CCACBC70F9D944FF1DAB854FAE053B0EB5F7F38F2ED4723EB944EDB5889E1C053CA779FE71DDBA9BBB1F5C71EE622B44CE3F604BF2F0E4BADFFF9F843978DCF915E89DA48C047D6299CC6B316B1F6C77A2A9E755FF509638319082D1379FC5EEDFA6CF3AAB834BAFDE2C2F7BA2BEB8C047C649DA5CBFA6BC769F441A6E5DF613C908F8E0D6621B44C6634B67D1F6129EF05AFCD04EF2C6679D5DF51CC02BBB6FBD0E5F2C51B86B5F5AE33CAB59F6FF8394EA3817C686C3017A1654A6510D74FF8D7E07404B9FCBC6E57008A19706D3FCAA874ED4FE5A1A3DAB64B7763589971964F0F973F6FDAFB10D542F578ACEC27FC0142CBDCAA27EDE5D2884873FD7DCB6F782AA15C5B1631BF7BD0E8D165F946A163ACCDF7150BAD7BDD373A7EF7E87EC0AB135A0008125A0008125A0008125A0008125A5E56F9808CC5725D6026FEC5F2B2CA93ABC5725D6026FEC5024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D0024090D00240D07F8336690147C131F90000000049454E44AE426082, N'THIS IS A TEST', N'Caregiver', N'Typed', N'CAREGIVER', CAST(N'2025-04-15T22:08:48.067' AS DateTime), NULL, 21, 3)
SET IDENTITY_INSERT [dbo].[Service_Logs] OFF
GO
SET IDENTITY_INSERT [dbo].[Shifts_Assignment] ON 

INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (1, 9, CAST(N'2025-04-06' AS Date), N'Scheduled', CAST(N'10:00:00' AS Time), CAST(N'18:00:00' AS Time), NULL, 1)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (1, 3, CAST(N'2025-04-13' AS Date), N'Scheduled', CAST(N'11:00:00' AS Time), CAST(N'19:00:00' AS Time), NULL, 2)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (1, 11, CAST(N'2025-04-16' AS Date), N'Scheduled', CAST(N'08:00:00' AS Time), CAST(N'16:00:00' AS Time), NULL, 3)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (1, 8, CAST(N'2025-04-18' AS Date), N'Scheduled', CAST(N'13:00:00' AS Time), CAST(N'21:00:00' AS Time), NULL, 4)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (1, 1, CAST(N'2025-04-19' AS Date), N'Scheduled', CAST(N'09:00:00' AS Time), CAST(N'17:00:00' AS Time), NULL, 5)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (1, 8, CAST(N'2025-04-22' AS Date), N'Scheduled', CAST(N'11:00:00' AS Time), CAST(N'19:00:00' AS Time), NULL, 6)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (1, 3, CAST(N'2025-04-27' AS Date), N'Scheduled', CAST(N'11:00:00' AS Time), CAST(N'19:00:00' AS Time), NULL, 7)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (1, 5, CAST(N'2025-05-01' AS Date), N'Scheduled', CAST(N'07:00:00' AS Time), CAST(N'15:00:00' AS Time), NULL, 8)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (1, 2, CAST(N'2025-05-02' AS Date), N'Scheduled', CAST(N'11:00:00' AS Time), CAST(N'19:00:00' AS Time), NULL, 9)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (2, 4, CAST(N'2025-04-07' AS Date), N'Scheduled', CAST(N'12:00:00' AS Time), CAST(N'20:00:00' AS Time), NULL, 10)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (2, 5, CAST(N'2025-04-16' AS Date), N'Scheduled', CAST(N'06:00:00' AS Time), CAST(N'14:00:00' AS Time), NULL, 11)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (2, 5, CAST(N'2025-04-17' AS Date), N'Scheduled', CAST(N'09:00:00' AS Time), CAST(N'17:00:00' AS Time), NULL, 12)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (2, 2, CAST(N'2025-04-19' AS Date), N'Scheduled', CAST(N'07:00:00' AS Time), CAST(N'15:00:00' AS Time), NULL, 13)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (2, 4, CAST(N'2025-04-23' AS Date), N'Scheduled', CAST(N'09:00:00' AS Time), CAST(N'17:00:00' AS Time), NULL, 14)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (2, 10, CAST(N'2025-04-24' AS Date), N'Scheduled', CAST(N'12:00:00' AS Time), CAST(N'20:00:00' AS Time), NULL, 15)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (2, 8, CAST(N'2025-04-29' AS Date), N'Scheduled', CAST(N'07:00:00' AS Time), CAST(N'15:00:00' AS Time), NULL, 16)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (2, 7, CAST(N'2025-05-02' AS Date), N'Scheduled', CAST(N'13:00:00' AS Time), CAST(N'21:00:00' AS Time), NULL, 17)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (2, 3, CAST(N'2025-05-03' AS Date), N'Scheduled', CAST(N'08:00:00' AS Time), CAST(N'16:00:00' AS Time), NULL, 18)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (2, 4, CAST(N'2025-05-04' AS Date), N'Scheduled', CAST(N'11:00:00' AS Time), CAST(N'19:00:00' AS Time), NULL, 19)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (3, 9, CAST(N'2025-04-08' AS Date), N'Scheduled', CAST(N'12:00:00' AS Time), CAST(N'20:00:00' AS Time), NULL, 20)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (3, 2, CAST(N'2025-04-15' AS Date), N'Scheduled', CAST(N'06:00:00' AS Time), CAST(N'14:00:00' AS Time), NULL, 21)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (3, 5, CAST(N'2025-04-19' AS Date), N'Scheduled', CAST(N'12:00:00' AS Time), CAST(N'20:00:00' AS Time), NULL, 22)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (3, 2, CAST(N'2025-04-28' AS Date), N'Scheduled', CAST(N'06:00:00' AS Time), CAST(N'14:00:00' AS Time), NULL, 23)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (3, 1, CAST(N'2025-04-29' AS Date), N'Scheduled', CAST(N'09:00:00' AS Time), CAST(N'17:00:00' AS Time), NULL, 24)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (3, 5, CAST(N'2025-05-05' AS Date), N'Scheduled', CAST(N'07:00:00' AS Time), CAST(N'15:00:00' AS Time), NULL, 25)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (3, 6, CAST(N'2025-05-06' AS Date), N'Scheduled', CAST(N'12:00:00' AS Time), CAST(N'18:00:00' AS Time), NULL, 26)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (4, 1, CAST(N'2025-04-09' AS Date), N'Scheduled', CAST(N'11:00:00' AS Time), CAST(N'19:00:00' AS Time), NULL, 27)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (4, 11, CAST(N'2025-04-10' AS Date), N'Scheduled', CAST(N'07:00:00' AS Time), CAST(N'15:00:00' AS Time), NULL, 28)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (4, 10, CAST(N'2025-04-14' AS Date), N'Scheduled', CAST(N'12:00:00' AS Time), CAST(N'20:00:00' AS Time), NULL, 29)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (4, 1, CAST(N'2025-04-16' AS Date), N'Scheduled', CAST(N'12:00:00' AS Time), CAST(N'20:00:00' AS Time), NULL, 30)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (4, 12, CAST(N'2025-04-30' AS Date), N'Scheduled', CAST(N'11:00:00' AS Time), CAST(N'19:00:00' AS Time), NULL, 31)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (4, 12, CAST(N'2025-05-02' AS Date), N'Scheduled', CAST(N'06:00:00' AS Time), CAST(N'14:00:00' AS Time), NULL, 32)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (4, 7, CAST(N'2025-05-07' AS Date), N'Scheduled', CAST(N'07:00:00' AS Time), CAST(N'15:00:00' AS Time), NULL, 33)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (4, 8, CAST(N'2025-05-08' AS Date), N'Scheduled', CAST(N'12:00:00' AS Time), CAST(N'18:00:00' AS Time), NULL, 34)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (5, 9, CAST(N'2025-04-07' AS Date), N'Scheduled', CAST(N'08:00:00' AS Time), CAST(N'16:00:00' AS Time), NULL, 35)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (5, 5, CAST(N'2025-04-11' AS Date), N'Scheduled', CAST(N'11:00:00' AS Time), CAST(N'19:00:00' AS Time), NULL, 36)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (5, 11, CAST(N'2025-04-14' AS Date), N'Scheduled', CAST(N'09:00:00' AS Time), CAST(N'17:00:00' AS Time), NULL, 37)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (5, 10, CAST(N'2025-04-15' AS Date), N'Scheduled', CAST(N'09:00:00' AS Time), CAST(N'17:00:00' AS Time), NULL, 38)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (5, 5, CAST(N'2025-04-19' AS Date), N'Scheduled', CAST(N'06:00:00' AS Time), CAST(N'14:00:00' AS Time), NULL, 39)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (5, 10, CAST(N'2025-04-23' AS Date), N'Scheduled', CAST(N'08:00:00' AS Time), CAST(N'16:00:00' AS Time), NULL, 40)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (5, 12, CAST(N'2025-04-24' AS Date), N'Scheduled', CAST(N'07:00:00' AS Time), CAST(N'15:00:00' AS Time), NULL, 41)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (5, 12, CAST(N'2025-05-03' AS Date), N'Scheduled', CAST(N'08:00:00' AS Time), CAST(N'16:00:00' AS Time), NULL, 42)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (5, 9, CAST(N'2025-05-09' AS Date), N'Scheduled', CAST(N'11:00:00' AS Time), CAST(N'19:00:00' AS Time), NULL, 43)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (5, 10, CAST(N'2025-05-10' AS Date), N'Scheduled', CAST(N'11:00:00' AS Time), CAST(N'19:00:00' AS Time), NULL, 44)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (6, 11, CAST(N'2025-04-09' AS Date), N'Scheduled', CAST(N'10:00:00' AS Time), CAST(N'18:00:00' AS Time), NULL, 45)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (6, 2, CAST(N'2025-04-10' AS Date), N'Scheduled', CAST(N'08:00:00' AS Time), CAST(N'16:00:00' AS Time), NULL, 46)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (6, 9, CAST(N'2025-04-11' AS Date), N'Scheduled', CAST(N'13:00:00' AS Time), CAST(N'21:00:00' AS Time), NULL, 47)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (6, 9, CAST(N'2025-04-12' AS Date), N'Scheduled', CAST(N'12:00:00' AS Time), CAST(N'20:00:00' AS Time), NULL, 48)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (6, 5, CAST(N'2025-04-14' AS Date), N'Scheduled', CAST(N'11:00:00' AS Time), CAST(N'19:00:00' AS Time), NULL, 49)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (6, 2, CAST(N'2025-04-16' AS Date), N'Scheduled', CAST(N'10:00:00' AS Time), CAST(N'18:00:00' AS Time), NULL, 50)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (6, 8, CAST(N'2025-04-21' AS Date), N'Scheduled', CAST(N'07:00:00' AS Time), CAST(N'15:00:00' AS Time), NULL, 51)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (6, 1, CAST(N'2025-04-22' AS Date), N'Scheduled', CAST(N'11:00:00' AS Time), CAST(N'19:00:00' AS Time), NULL, 52)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (6, 9, CAST(N'2025-05-03' AS Date), N'Scheduled', CAST(N'11:00:00' AS Time), CAST(N'19:00:00' AS Time), NULL, 53)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (6, 11, CAST(N'2025-05-11' AS Date), N'Scheduled', CAST(N'08:00:00' AS Time), CAST(N'16:00:00' AS Time), NULL, 54)
INSERT [dbo].[Shifts_Assignment] ([CaregiverID], [ClientID], [shift_date], [status], [start_time], [end_time], [pay_amount], [ShiftID]) VALUES (6, 12, CAST(N'2025-05-12' AS Date), N'Scheduled', CAST(N'08:00:00' AS Time), CAST(N'16:00:00' AS Time), NULL, 55)
SET IDENTITY_INSERT [dbo].[Shifts_Assignment] OFF
GO
INSERT [dbo].[Supervisors] ([SupervisorID], [name], [Phone], [email]) VALUES (1, N'Alexander Wright', N'555-748-5821', N'Alexander.Wright@gmail.com')
INSERT [dbo].[Supervisors] ([SupervisorID], [name], [Phone], [email]) VALUES (2, N'Lucinda Mack', N'456-753-1598', N'Lucina.Mack@outlook.com')
GO
SET IDENTITY_INSERT [dbo].[TaskAssignment] ON 

INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (1, 1, 1, 1, CAST(N'2025-05-01' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (2, 1, 1, 2, CAST(N'2025-05-01' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (3, 1, 1, 3, CAST(N'2025-05-01' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (4, 1, 1, 5, CAST(N'2025-05-01' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (5, 1, 2, 1, CAST(N'2025-05-02' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (6, 1, 2, 2, CAST(N'2025-05-02' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (7, 1, 2, 3, CAST(N'2025-05-02' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (8, 1, 2, 4, CAST(N'2025-05-02' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (9, 1, 2, 5, CAST(N'2025-05-02' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (10, 1, 2, 6, CAST(N'2025-05-02' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (11, 1, 2, 7, CAST(N'2025-05-02' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (12, 1, 2, 8, CAST(N'2025-05-02' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (13, 1, 2, 9, CAST(N'2025-05-02' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (14, 1, 2, 10, CAST(N'2025-05-02' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (15, 1, 2, 11, CAST(N'2025-05-02' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (16, 1, 2, 12, CAST(N'2025-05-02' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (17, 1, 2, 13, CAST(N'2025-05-02' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (18, 1, 2, 14, CAST(N'2025-05-02' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (19, 1, 2, 15, CAST(N'2025-05-02' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (20, 1, 2, 16, CAST(N'2025-05-02' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (21, 1, 2, 17, CAST(N'2025-05-02' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (22, 1, 2, 18, CAST(N'2025-05-02' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (23, 1, 2, 19, CAST(N'2025-05-02' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (24, 1, 2, 20, CAST(N'2025-05-02' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (25, 1, 2, 21, CAST(N'2025-05-02' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (26, 1, 2, 22, CAST(N'2025-05-02' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (27, 1, 2, 23, CAST(N'2025-05-02' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (28, 2, 3, 8, CAST(N'2025-05-03' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (29, 2, 3, 14, CAST(N'2025-05-03' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (30, 2, 4, 1, CAST(N'2025-05-04' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (31, 2, 4, 2, CAST(N'2025-05-04' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (32, 2, 4, 3, CAST(N'2025-05-04' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (33, 2, 4, 4, CAST(N'2025-05-04' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (34, 2, 4, 5, CAST(N'2025-05-04' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (35, 2, 4, 6, CAST(N'2025-05-04' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (36, 2, 4, 7, CAST(N'2025-05-04' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (37, 2, 4, 10, CAST(N'2025-05-04' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (38, 2, 4, 11, CAST(N'2025-05-04' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (39, 2, 4, 12, CAST(N'2025-05-04' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (40, 2, 4, 13, CAST(N'2025-05-04' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (41, 2, 4, 14, CAST(N'2025-05-04' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (42, 2, 4, 15, CAST(N'2025-05-04' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (43, 2, 4, 16, CAST(N'2025-05-04' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (44, 2, 4, 17, CAST(N'2025-05-04' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (45, 2, 4, 18, CAST(N'2025-05-04' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (46, 3, 5, 19, CAST(N'2025-05-05' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (47, 3, 5, 20, CAST(N'2025-05-05' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (48, 3, 5, 21, CAST(N'2025-05-05' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (49, 3, 5, 22, CAST(N'2025-05-05' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (50, 3, 5, 23, CAST(N'2025-05-05' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (51, 3, 6, 4, CAST(N'2025-05-06' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (52, 3, 6, 5, CAST(N'2025-05-06' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (53, 3, 6, 7, CAST(N'2025-05-06' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (54, 3, 6, 9, CAST(N'2025-05-06' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (55, 4, 7, 1, CAST(N'2025-05-07' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (56, 4, 7, 2, CAST(N'2025-05-07' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (57, 4, 7, 3, CAST(N'2025-05-07' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (58, 4, 7, 4, CAST(N'2025-05-07' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (59, 4, 7, 5, CAST(N'2025-05-07' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (60, 4, 7, 6, CAST(N'2025-05-07' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (61, 4, 8, 1, CAST(N'2025-05-08' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (62, 4, 8, 3, CAST(N'2025-05-08' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (63, 4, 8, 4, CAST(N'2025-05-08' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (64, 4, 8, 5, CAST(N'2025-05-08' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (65, 4, 8, 8, CAST(N'2025-05-08' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (66, 4, 8, 14, CAST(N'2025-05-08' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (67, 5, 9, 12, CAST(N'2025-05-09' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (68, 5, 9, 13, CAST(N'2025-05-09' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (69, 5, 9, 15, CAST(N'2025-05-09' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (70, 5, 9, 16, CAST(N'2025-05-09' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (71, 5, 10, 1, CAST(N'2025-05-10' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (72, 5, 10, 2, CAST(N'2025-05-10' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (73, 5, 10, 3, CAST(N'2025-05-10' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (74, 5, 10, 4, CAST(N'2025-05-10' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (75, 5, 10, 5, CAST(N'2025-05-10' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (76, 5, 10, 6, CAST(N'2025-05-10' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (77, 5, 10, 9, CAST(N'2025-05-10' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (78, 6, 11, 1, CAST(N'2025-05-11' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (79, 6, 11, 2, CAST(N'2025-05-11' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (80, 6, 11, 3, CAST(N'2025-05-11' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (81, 6, 11, 4, CAST(N'2025-05-11' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (82, 6, 11, 5, CAST(N'2025-05-11' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (83, 6, 11, 6, CAST(N'2025-05-11' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (84, 6, 11, 7, CAST(N'2025-05-11' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (85, 6, 11, 8, CAST(N'2025-05-11' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (86, 6, 11, 10, CAST(N'2025-05-11' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (87, 6, 11, 11, CAST(N'2025-05-11' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (88, 6, 11, 12, CAST(N'2025-05-11' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (89, 6, 11, 13, CAST(N'2025-05-11' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (90, 6, 11, 14, CAST(N'2025-05-11' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (91, 6, 11, 15, CAST(N'2025-05-11' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (92, 6, 11, 16, CAST(N'2025-05-11' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (93, 6, 11, 17, CAST(N'2025-05-11' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (94, 6, 11, 18, CAST(N'2025-05-11' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (95, 6, 11, 19, CAST(N'2025-05-11' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (96, 6, 11, 20, CAST(N'2025-05-11' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (97, 6, 11, 21, CAST(N'2025-05-11' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (98, 6, 11, 22, CAST(N'2025-05-11' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (99, 6, 11, 23, CAST(N'2025-05-11' AS Date), N'Pending')
GO
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (100, 6, 12, 7, CAST(N'2025-05-12' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (101, 6, 12, 8, CAST(N'2025-05-12' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (102, 6, 12, 14, CAST(N'2025-05-12' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (103, 6, 12, 19, CAST(N'2025-05-12' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (104, 6, 12, 20, CAST(N'2025-05-12' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (105, 6, 12, 21, CAST(N'2025-05-12' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (106, 6, 12, 22, CAST(N'2025-05-12' AS Date), N'Pending')
INSERT [dbo].[TaskAssignment] ([TaskAssignment_ID], [CaregiverID], [ClientID], [TaskID], [scheduled_date], [completion_status]) VALUES (107, 6, 12, 23, CAST(N'2025-05-12' AS Date), N'Pending')
SET IDENTITY_INSERT [dbo].[TaskAssignment] OFF
GO
INSERT [dbo].[Tasks] ([TaskID], [description]) VALUES (1, N'Bathing')
INSERT [dbo].[Tasks] ([TaskID], [description]) VALUES (2, N'Shaving')
INSERT [dbo].[Tasks] ([TaskID], [description]) VALUES (3, N'Hair Care')
INSERT [dbo].[Tasks] ([TaskID], [description]) VALUES (4, N'Skin Care')
INSERT [dbo].[Tasks] ([TaskID], [description]) VALUES (5, N'Mouth Care')
INSERT [dbo].[Tasks] ([TaskID], [description]) VALUES (6, N'Nail Maintenance')
INSERT [dbo].[Tasks] ([TaskID], [description]) VALUES (7, N'Dressing')
INSERT [dbo].[Tasks] ([TaskID], [description]) VALUES (8, N'Assistance with ambulation/transferring')
INSERT [dbo].[Tasks] ([TaskID], [description]) VALUES (9, N'Prepare Meals')
INSERT [dbo].[Tasks] ([TaskID], [description]) VALUES (10, N'Wash, dry, and put dishes away')
INSERT [dbo].[Tasks] ([TaskID], [description]) VALUES (11, N'Wipe the exterior of appliances')
INSERT [dbo].[Tasks] ([TaskID], [description]) VALUES (12, N'Take garbage out')
INSERT [dbo].[Tasks] ([TaskID], [description]) VALUES (13, N'Changing bed linen')
INSERT [dbo].[Tasks] ([TaskID], [description]) VALUES (14, N'Toileting/incontinence care')
INSERT [dbo].[Tasks] ([TaskID], [description]) VALUES (15, N'Assisting with housekeeping')
INSERT [dbo].[Tasks] ([TaskID], [description]) VALUES (16, N'Vaccuming clients bedroom and bathroom')
INSERT [dbo].[Tasks] ([TaskID], [description]) VALUES (17, N'Assistance with laundry')
INSERT [dbo].[Tasks] ([TaskID], [description]) VALUES (18, N'Wet and dry mop bedroom and bathroom')
INSERT [dbo].[Tasks] ([TaskID], [description]) VALUES (19, N'Medication reminder')
INSERT [dbo].[Tasks] ([TaskID], [description]) VALUES (20, N'Gathering medications')
INSERT [dbo].[Tasks] ([TaskID], [description]) VALUES (21, N'Read medication for instructions')
INSERT [dbo].[Tasks] ([TaskID], [description]) VALUES (22, N'Open medication bottles for clients')
INSERT [dbo].[Tasks] ([TaskID], [description]) VALUES (23, N'Reassure that medication has been taken')
GO
SET IDENTITY_INSERT [dbo].[TimePunches] ON 

INSERT [dbo].[TimePunches] ([PunchID], [CaregiverID], [clock_in], [clock_out], [ShiftID]) VALUES (1, 1, CAST(N'2025-04-05T20:48:16.503' AS DateTime), CAST(N'2025-04-05T20:48:22.757' AS DateTime), NULL)
INSERT [dbo].[TimePunches] ([PunchID], [CaregiverID], [clock_in], [clock_out], [ShiftID]) VALUES (2, 1, CAST(N'2025-04-05T20:50:35.160' AS DateTime), CAST(N'2025-04-05T20:50:57.363' AS DateTime), NULL)
INSERT [dbo].[TimePunches] ([PunchID], [CaregiverID], [clock_in], [clock_out], [ShiftID]) VALUES (3, 1, CAST(N'2025-04-05T21:39:14.283' AS DateTime), CAST(N'2025-04-05T21:39:16.673' AS DateTime), NULL)
INSERT [dbo].[TimePunches] ([PunchID], [CaregiverID], [clock_in], [clock_out], [ShiftID]) VALUES (4, 1, CAST(N'2025-04-05T23:19:14.683' AS DateTime), CAST(N'2025-04-05T23:19:15.983' AS DateTime), NULL)
INSERT [dbo].[TimePunches] ([PunchID], [CaregiverID], [clock_in], [clock_out], [ShiftID]) VALUES (5, 1, CAST(N'2025-04-05T23:29:16.593' AS DateTime), CAST(N'2025-04-05T23:29:19.310' AS DateTime), NULL)
INSERT [dbo].[TimePunches] ([PunchID], [CaregiverID], [clock_in], [clock_out], [ShiftID]) VALUES (6, 5, CAST(N'2025-04-08T20:02:30.020' AS DateTime), CAST(N'2025-04-08T20:02:31.330' AS DateTime), NULL)
INSERT [dbo].[TimePunches] ([PunchID], [CaregiverID], [clock_in], [clock_out], [ShiftID]) VALUES (7, 1, CAST(N'2025-04-08T21:50:06.843' AS DateTime), CAST(N'2025-04-08T21:50:08.247' AS DateTime), NULL)
INSERT [dbo].[TimePunches] ([PunchID], [CaregiverID], [clock_in], [clock_out], [ShiftID]) VALUES (8, 6, CAST(N'2025-04-09T03:35:29.273' AS DateTime), CAST(N'2025-04-09T03:35:30.700' AS DateTime), NULL)
INSERT [dbo].[TimePunches] ([PunchID], [CaregiverID], [clock_in], [clock_out], [ShiftID]) VALUES (9, 5, CAST(N'2025-04-15T20:30:18.340' AS DateTime), CAST(N'2025-04-15T20:42:02.883' AS DateTime), NULL)
INSERT [dbo].[TimePunches] ([PunchID], [CaregiverID], [clock_in], [clock_out], [ShiftID]) VALUES (10, 5, CAST(N'2025-04-15T20:49:46.950' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[TimePunches] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [CaregiverID], [username], [RoleID], [isActive], [password_hash]) VALUES (1, 1, N'JSmith', 2, 1, 0x15E2B0D3C33891EBB0F1EF609EC419420C20E320CE94C65FBC8C3312448EB225)
INSERT [dbo].[Users] ([UserID], [CaregiverID], [username], [RoleID], [isActive], [password_hash]) VALUES (2, 2, N'JRogers', 2, 1, 0x15E2B0D3C33891EBB0F1EF609EC419420C20E320CE94C65FBC8C3312448EB225)
INSERT [dbo].[Users] ([UserID], [CaregiverID], [username], [RoleID], [isActive], [password_hash]) VALUES (3, 3, N'BHarrold', 2, 1, 0x15E2B0D3C33891EBB0F1EF609EC419420C20E320CE94C65FBC8C3312448EB225)
INSERT [dbo].[Users] ([UserID], [CaregiverID], [username], [RoleID], [isActive], [password_hash]) VALUES (4, 4, N'DDuncan', 2, 1, 0x15E2B0D3C33891EBB0F1EF609EC419420C20E320CE94C65FBC8C3312448EB225)
INSERT [dbo].[Users] ([UserID], [CaregiverID], [username], [RoleID], [isActive], [password_hash]) VALUES (5, 5, N'MBarry', 2, 1, 0x15E2B0D3C33891EBB0F1EF609EC419420C20E320CE94C65FBC8C3312448EB225)
INSERT [dbo].[Users] ([UserID], [CaregiverID], [username], [RoleID], [isActive], [password_hash]) VALUES (6, 6, N'BJones', 2, 1, 0x15E2B0D3C33891EBB0F1EF609EC419420C20E320CE94C65FBC8C3312448EB225)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Roles__783254B145CC9858]    Script Date: 4/15/2025 10:21:23 PM ******/
ALTER TABLE [dbo].[Roles] ADD UNIQUE NONCLUSTERED 
(
	[role_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ_OneShiftPerDay]    Script Date: 4/15/2025 10:21:23 PM ******/
ALTER TABLE [dbo].[Shifts_Assignment] ADD  CONSTRAINT [UQ_OneShiftPerDay] UNIQUE NONCLUSTERED 
(
	[CaregiverID] ASC,
	[shift_date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__F3DBC572FD0C6B24]    Script Date: 4/15/2025 10:21:23 PM ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ__Users__F72B74D06A9591FF]    Script Date: 4/15/2025 10:21:23 PM ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[CaregiverID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[completed_tasks] ADD  DEFAULT (getdate()) FOR [completionTime]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((1)) FOR [isActive]
GO
ALTER TABLE [dbo].[Billing]  WITH CHECK ADD FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ClientID])
GO
ALTER TABLE [dbo].[Care_Plan_Tasks]  WITH CHECK ADD FOREIGN KEY([CareplanID])
REFERENCES [dbo].[CarePlans] ([PlanID])
GO
ALTER TABLE [dbo].[Care_Plan_Tasks]  WITH CHECK ADD FOREIGN KEY([TaskID])
REFERENCES [dbo].[Tasks] ([TaskID])
GO
ALTER TABLE [dbo].[Caregiver]  WITH CHECK ADD FOREIGN KEY([SupervisorID])
REFERENCES [dbo].[Supervisors] ([SupervisorID])
GO
ALTER TABLE [dbo].[CarePlans]  WITH CHECK ADD FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ClientID])
GO
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD FOREIGN KEY([CaregiverID])
REFERENCES [dbo].[Caregiver] ([CaregiverID])
GO
ALTER TABLE [dbo].[completed_tasks]  WITH CHECK ADD FOREIGN KEY([CaregiverID])
REFERENCES [dbo].[Caregiver] ([CaregiverID])
GO
ALTER TABLE [dbo].[completed_tasks]  WITH CHECK ADD FOREIGN KEY([PlanID])
REFERENCES [dbo].[CarePlans] ([PlanID])
GO
ALTER TABLE [dbo].[completed_tasks]  WITH CHECK ADD FOREIGN KEY([TaskID])
REFERENCES [dbo].[Tasks] ([TaskID])
GO
ALTER TABLE [dbo].[Payroll]  WITH CHECK ADD FOREIGN KEY([CaregiverID])
REFERENCES [dbo].[Caregiver] ([CaregiverID])
GO
ALTER TABLE [dbo].[Service_Logs]  WITH CHECK ADD FOREIGN KEY([CaregiverID])
REFERENCES [dbo].[Caregiver] ([CaregiverID])
GO
ALTER TABLE [dbo].[Service_Logs]  WITH CHECK ADD FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ClientID])
GO
ALTER TABLE [dbo].[Service_Logs]  WITH CHECK ADD  CONSTRAINT [FK_ServiceLogs_Shifts] FOREIGN KEY([ShiftID])
REFERENCES [dbo].[Shifts_Assignment] ([ShiftID])
GO
ALTER TABLE [dbo].[Service_Logs] CHECK CONSTRAINT [FK_ServiceLogs_Shifts]
GO
ALTER TABLE [dbo].[Shifts_Assignment]  WITH CHECK ADD FOREIGN KEY([CaregiverID])
REFERENCES [dbo].[Caregiver] ([CaregiverID])
GO
ALTER TABLE [dbo].[Shifts_Assignment]  WITH CHECK ADD FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ClientID])
GO
ALTER TABLE [dbo].[TaskAssignment]  WITH CHECK ADD FOREIGN KEY([CaregiverID])
REFERENCES [dbo].[Caregiver] ([CaregiverID])
GO
ALTER TABLE [dbo].[TaskAssignment]  WITH CHECK ADD FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ClientID])
GO
ALTER TABLE [dbo].[TaskAssignment]  WITH CHECK ADD FOREIGN KEY([TaskID])
REFERENCES [dbo].[Tasks] ([TaskID])
GO
ALTER TABLE [dbo].[TimePunches]  WITH CHECK ADD FOREIGN KEY([CaregiverID])
REFERENCES [dbo].[Caregiver] ([CaregiverID])
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD FOREIGN KEY([CaregiverID])
REFERENCES [dbo].[Caregiver] ([CaregiverID])
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
GO
ALTER TABLE [dbo].[Billing]  WITH CHECK ADD CHECK  (([status]='Overdue' OR [status]='Paid' OR [status]='Unpaid'))
GO
ALTER TABLE [dbo].[Caregiver]  WITH CHECK ADD CHECK  (([status]='Inactive' OR [status]='Active'))
GO
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD CHECK  (([status]='Inactive' OR [status]='Active'))
GO
ALTER TABLE [dbo].[Payroll]  WITH CHECK ADD CHECK  (([status]='Failed' OR [status]='Paid' OR [status]='Pending'))
GO
ALTER TABLE [dbo].[Shifts_Assignment]  WITH CHECK ADD CHECK  (([status]='Missed' OR [status]='Completed' OR [status]='Scheduled'))
GO
ALTER TABLE [dbo].[TaskAssignment]  WITH CHECK ADD CHECK  (([completion_status]='Completed' OR [completion_status]='Pending'))
GO
USE [master]
GO
ALTER DATABASE [CareTrack Database] SET  READ_WRITE 
GO
