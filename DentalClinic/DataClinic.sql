USE [master]
GO

/****** Object:  Database [DentalClinic]    Script Date: 7/12/2024 6:07:25 PM ******/
CREATE DATABASE [DentalClinic]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DentalClinic', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\DentalClinic.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DentalClinic_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\DentalClinic_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DentalClinic].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [DentalClinic] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [DentalClinic] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [DentalClinic] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [DentalClinic] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [DentalClinic] SET ARITHABORT OFF 
GO

ALTER DATABASE [DentalClinic] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [DentalClinic] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [DentalClinic] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [DentalClinic] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [DentalClinic] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [DentalClinic] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [DentalClinic] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [DentalClinic] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [DentalClinic] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [DentalClinic] SET  DISABLE_BROKER 
GO

ALTER DATABASE [DentalClinic] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [DentalClinic] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [DentalClinic] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [DentalClinic] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [DentalClinic] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [DentalClinic] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [DentalClinic] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [DentalClinic] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [DentalClinic] SET  MULTI_USER 
GO

ALTER DATABASE [DentalClinic] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [DentalClinic] SET DB_CHAINING OFF 
GO

ALTER DATABASE [DentalClinic] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [DentalClinic] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [DentalClinic] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [DentalClinic] SET QUERY_STORE = OFF
GO

ALTER DATABASE [DentalClinic] SET  READ_WRITE 
GO

/* Patient Table 
-Patiet first name
-Patiet middle name
-Patiet last name
-Birth date
-Patient sex
-Address
-Phone number
**********************************************/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Patient](
	[PatientID] [int] IDENTITY(1,1) NOT NULL,
    [P_FName] [varchar](60) NOT NULL,
    [P_MName] [varchar](60) NOT NULL,
	[P_LName] [varchar](60) NOT NULL,	
	[P_BirthDate] [date] NOT NULL,
	[P_Sex] [varchar](10) NOT NULL,
	[P_Add] [varchar](300) NOT NULL,
	[P_Contact] [int] NOT NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[PatientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


/* Staff Table 
-Staff first name
-Staff middle name
-Staff last name
-Address
-Phone number
-Staff username
-Staff Password
-Restriction {admin,user,dintest}
**********************************************/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Staff](
	[StaffID] [int] IDENTITY(1,1) NOT NULL,
	[S_LName] [varchar](60) NOT NULL,
	[S_Fname] [varchar](60) NOT NULL,
	[S_Mname] [varchar](60) NOT NULL,
	[S_Add] [varchar](300) NOT NULL,
	[S_Contact] [int] NOT NULL,
	[S_Username] [varchar](30) NOT NULL,
	[S_Password] [varchar](30) NOT NULL,
	[S_Restriction] [varchar](40) NOT NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/* Appointment Table 
-Patient id
-Appointment date
-Dentist id (from staff table)
-Appointment type (new,return)(جديد،عودة)
-Appointment fee / Entiry key
-Status (active,finished,delied)(ساري,منتهي,مؤجل)
-Staff id / resepcinist id (from staff table)
**********************************************/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Appointment](
	[AppointmentID] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NOT NULL,
	[AppointmentDate] [date] NOT NULL,
	[DentistId] [int] NOT NULL,
	[AppointmentType] [varchar](10) NOT NULL,
	[AppointmentFee] [bit] NOT NULL,
	[Status] [varchar](10) NOT NULL,
	[StaffID] [int] NOT NULL,
CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED 
(
	[AppointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


/* Consultation Table 
-Patient id
-Consultation date
-Dentist id (from staff table)
-MedicalHistory / Patient's medical history
-Diagnosis / causes of the problem
-Chief complaint / the main problem 
-Past Dental History
-Treatment / healing proceduers

**********************************************/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Consultation](
	[ConsultID] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NOT NULL,
	[ConsultatDate] [date] NOT NULL,
	[DentistId] [int] NOT NULL,
	[PastDentalHistory] [varchar](500) NOT NULL,
	[ChiefComplaint] [varchar](500) NOT NULL,
	[MedicalHistory] [varchar](500) NOT NULL,
	[Diagnosis] [varchar](500) NOT NULL,
	[Treatment] [varchar](500) NOT NULL,	
CONSTRAINT [PK_Consultation] PRIMARY KEY CLUSTERED 
(
	[ConsultID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/* Image Table 
-Consultation id 
-Image Path

**********************************************/

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Image](
	[ImageID] [int] IDENTITY(1,1) NOT NULL,
	[ConsultID] [int] NOT NULL,
	[Path] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Image] PRIMARY KEY CLUSTERED 
(
	[ImageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/* Bill Table 
-Consultation id 
-Bill date
-Total amount of the invoice
-Paid for / why did the patient pay?
-Payment status / (منتهية،جارية)
-Discount 

**********************************************/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Bill](
	[BillID] [int] IDENTITY(1,1) NOT NULL,
	[ConsultationID] [int] NOT NULL,
	[BillDate] [date] NOT NULL,
	[TotalAmount] [int] NOT NULL,
	[PaidFor] [varchar](250) NOT NULL,
	[PaymentStatus] [varchar](15) NOT NULL,
	[Discount] [int] NOT NULL,	
CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[BillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


/* Payment Table 
-Consultation id 
-Bill date
-Total amount of the invoice
-Paid for / why did the patient pay?
-Payment status / (منتهية،جارية)
-Discount 
-Treatment / healing proceduers

**********************************************/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Payment](
	[PaymentID] [int] IDENTITY(1,1) NOT NULL,
	[BillID] [int] NOT NULL,
	[PaymebtDate] [date] NOT NULL,
	[Amount] [int] NOT NULL,
	[PaidBy] [varchar](250) NOT NULL,		
CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO