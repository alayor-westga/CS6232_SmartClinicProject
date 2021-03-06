USE [master]
GO
/****** Object:  Database [cs6232-g1]    Script Date: 4/28/2021 10:45:58 AM ******/
CREATE DATABASE [cs6232-g1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SmartClinc', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SmartClinc.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SmartClinc_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SmartClinc_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [cs6232-g1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cs6232-g1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cs6232-g1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [cs6232-g1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [cs6232-g1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cs6232-g1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [cs6232-g1] SET ARITHABORT OFF 
GO
ALTER DATABASE [cs6232-g1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [cs6232-g1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [cs6232-g1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [cs6232-g1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [cs6232-g1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cs6232-g1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cs6232-g1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cs6232-g1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cs6232-g1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cs6232-g1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [cs6232-g1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [cs6232-g1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [cs6232-g1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [cs6232-g1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [cs6232-g1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [cs6232-g1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [cs6232-g1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [cs6232-g1] SET RECOVERY FULL 
GO
ALTER DATABASE [cs6232-g1] SET  MULTI_USER 
GO
ALTER DATABASE [cs6232-g1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cs6232-g1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cs6232-g1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cs6232-g1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [cs6232-g1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [cs6232-g1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'cs6232-g1', N'ON'
GO
ALTER DATABASE [cs6232-g1] SET QUERY_STORE = OFF
GO
USE [cs6232-g1]
GO
/****** Object:  UserDefinedFunction [dbo].[getLabTestCountByPatientAgeRange]    Script Date: 4/28/2021 10:45:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[getLabTestCountByPatientAgeRange](@LabTestCodeParam VARCHAR(45), @StartAge INT, @EndAge INT, @InsideRange BIT)
RETURNS INT
AS
BEGIN
    DECLARE @LabTestCount INT;
    
    IF  @LabTestCodeParam IS NULL OR @StartAge IS NULL OR @EndAge IS NULL
        RETURN CAST('You must specify the @LabTestCodeParam, @StartAge, and @EndAge.' AS INT);

    IF  @StartAge > @EndAge 
        RETURN CAST('@EndAge must be greater or equal than @StartAge.' AS INT);
    
    SELECT @LabTestCount = COUNT(r.lab_test_code)
    FROM LabTestResults r
        INNER JOIN Appointments a ON (a.appointment_id = r.appointment_id)
        INNER JOIN Patients p ON (p.patient_id = a.patient_id)
        INNER JOIN ClinicPersons c ON (p.clinic_person_id = c.clinic_person_id)
    WHERE lab_test_code = @LabTestCodeParam
    AND (@InsideRange = 1 AND [dbo].getYearDiff(c.date_of_birth, r.date_performed) BETWEEN @StartAge AND @EndAge
        OR @InsideRange = 0 AND [dbo].getYearDiff(c.date_of_birth, r.date_performed) NOT BETWEEN @StartAge AND @EndAge);
            
    RETURN @LabTestCount;
END

GO
/****** Object:  UserDefinedFunction [dbo].[getLabTestResultTypeCount]    Script Date: 4/28/2021 10:45:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[getLabTestResultTypeCount](@LabTestCodeParam VARCHAR(45), @IsNormal BIT)
RETURNS INT
BEGIN
    DECLARE @LabTestCount INT;

    IF  @LabTestCodeParam IS NULL OR @IsNormal IS NULL
        -- Adding this hack as throwing errors is not allowed in functions.
        RETURN CAST('You must specify both the @LabTestCodeParam and the @IsNormal.' AS INT);
    
    SELECT @LabTestCount = COUNT(*)
    FROM LabTestResults 
    WHERE lab_test_code = @LabTestCodeParam
    AND is_normal = @IsNormal;
            
    RETURN @LabTestCount;
END

GO
/****** Object:  UserDefinedFunction [dbo].[getYearDiff]    Script Date: 4/28/2021 10:45:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[getYearDiff](@FirstDate DATETIME, @SecondDate DATETIME)
RETURNS INT
BEGIN
    IF  @FirstDate IS NULL OR @SecondDate IS NULL
        RETURN CAST('You must specify both the @FirstDate and the @SecondDate.' AS INT);
        
    RETURN CAST(DATEDIFF(DAY, @FirstDate, @SecondDate) / 365.25 AS INT);
END

GO
/****** Object:  Table [dbo].[Administrators]    Script Date: 4/28/2021 10:45:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrators](
	[administrator_id] [int] IDENTITY(100,1) NOT NULL,
	[clinic_person_id] [int] NULL,
	[username] [varchar](100) NOT NULL,
	[password] [varchar](500) NOT NULL,
 CONSTRAINT [PK_Administrators] PRIMARY KEY CLUSTERED 
(
	[administrator_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appointments]    Script Date: 4/28/2021 10:46:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointments](
	[appointment_id] [int] IDENTITY(1,1) NOT NULL,
	[patient_id] [int] NOT NULL,
	[date] [datetime] NOT NULL,
	[doctor_id] [int] NOT NULL,
	[reason] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Appointments] PRIMARY KEY CLUSTERED 
(
	[appointment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClinicPersons]    Script Date: 4/28/2021 10:46:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClinicPersons](
	[clinic_person_id] [int] IDENTITY(1000,1) NOT NULL,
	[first_name] [varchar](45) NOT NULL,
	[last_name] [varchar](45) NULL,
	[date_of_birth] [date] NOT NULL,
	[gender] [char](1) NOT NULL,
	[street1] [varchar](45) NOT NULL,
	[street2] [varchar](45) NULL,
	[city] [varchar](45) NOT NULL,
	[state] [char](2) NOT NULL,
	[zip_code] [varchar](10) NOT NULL,
	[phone_number] [char](10) NOT NULL,
	[ssn] [char](9) NOT NULL,
 CONSTRAINT [PK_ClinicPersons_clinic_person_id] PRIMARY KEY CLUSTERED 
(
	[clinic_person_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctors]    Script Date: 4/28/2021 10:46:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctors](
	[doctor_id] [int] IDENTITY(200,1) NOT NULL,
	[clinic_person_id] [int] NULL,
 CONSTRAINT [PK_Doctors] PRIMARY KEY CLUSTERED 
(
	[doctor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoctorSpecialties]    Script Date: 4/28/2021 10:46:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoctorSpecialties](
	[doctor_id] [int] NOT NULL,
	[speciality] [varchar](100) NOT NULL,
 CONSTRAINT [PK_DoctorSpecialties] PRIMARY KEY CLUSTERED 
(
	[doctor_id] ASC,
	[speciality] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LabTestResults]    Script Date: 4/28/2021 10:46:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LabTestResults](
	[appointment_id] [int] NOT NULL,
	[lab_test_code] [varchar](45) NOT NULL,
	[date_performed] [datetime] NULL,
	[result] [varchar](45) NULL,
	[is_normal] [bit] NULL,
 CONSTRAINT [PK_LabTestResults_1] PRIMARY KEY CLUSTERED 
(
	[appointment_id] ASC,
	[lab_test_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LabTests]    Script Date: 4/28/2021 10:46:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LabTests](
	[lab_test_code] [varchar](45) NOT NULL,
	[name] [varchar](45) NOT NULL,
 CONSTRAINT [PK_LabTests] PRIMARY KEY CLUSTERED 
(
	[lab_test_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nurses]    Script Date: 4/28/2021 10:46:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nurses](
	[nurse_id] [int] IDENTITY(300,1) NOT NULL,
	[clinic_person_id] [int] NULL,
	[username] [varchar](100) NULL,
	[password] [varchar](500) NULL,
 CONSTRAINT [PK_Nurses] PRIMARY KEY CLUSTERED 
(
	[nurse_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patients]    Script Date: 4/28/2021 10:46:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients](
	[patient_id] [int] IDENTITY(400,1) NOT NULL,
	[clinic_person_id] [int] NULL,
 CONSTRAINT [PK_Patients] PRIMARY KEY CLUSTERED 
(
	[patient_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visits]    Script Date: 4/28/2021 10:46:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visits](
	[appointment_id] [int] NOT NULL,
	[nurse_id] [int] NOT NULL,
	[weight] [decimal](5, 2) NOT NULL,
	[systolic_bp] [int] NOT NULL,
	[diastolic_bp] [int] NOT NULL,
	[body_temp] [decimal](5, 1) NOT NULL,
	[pulse] [int] NOT NULL,
	[symptoms] [varchar](500) NOT NULL,
	[initial_diagnosis] [varchar](500) NOT NULL,
	[final_diagnosis] [varchar](500) NULL,
 CONSTRAINT [PK_Visits] PRIMARY KEY CLUSTERED 
(
	[appointment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Administrators] ON 

INSERT [dbo].[Administrators] ([administrator_id], [clinic_person_id], [username], [password]) VALUES (100, 1006, N'doe', N'XNáæBhw“æ\¥Ê!!îÂòê®‹”Ê€°µÄË‰ÓXÇ†?S¯½[:-1A?iÜ¦ãº¹£“TìKšæóü$•')
SET IDENTITY_INSERT [dbo].[Administrators] OFF
GO
SET IDENTITY_INSERT [dbo].[Appointments] ON 

INSERT [dbo].[Appointments] ([appointment_id], [patient_id], [date], [doctor_id], [reason]) VALUES (1, 401, CAST(N'2021-04-28T09:00:00.000' AS DateTime), 201, N'Stomachache')
INSERT [dbo].[Appointments] ([appointment_id], [patient_id], [date], [doctor_id], [reason]) VALUES (2, 400, CAST(N'2021-05-01T13:00:00.000' AS DateTime), 200, N'Headache')
SET IDENTITY_INSERT [dbo].[Appointments] OFF
GO
SET IDENTITY_INSERT [dbo].[ClinicPersons] ON 

INSERT [dbo].[ClinicPersons] ([clinic_person_id], [first_name], [last_name], [date_of_birth], [gender], [street1], [street2], [city], [state], [zip_code], [phone_number], [ssn]) VALUES (1000, N'Jane', N'Doe', CAST(N'1990-07-28' AS Date), N'F', N'123 Main St.', N'', N'San Francisco', N'CA', N'94102', N'5555555555', N'         ')
INSERT [dbo].[ClinicPersons] ([clinic_person_id], [first_name], [last_name], [date_of_birth], [gender], [street1], [street2], [city], [state], [zip_code], [phone_number], [ssn]) VALUES (1001, N'Bruce', N'Wayne', CAST(N'1980-01-03' AS Date), N'M', N'456 Main Blvd.', N'', N'San Jose', N'CA', N'96102', N'5551234567', N'123456789')
INSERT [dbo].[ClinicPersons] ([clinic_person_id], [first_name], [last_name], [date_of_birth], [gender], [street1], [street2], [city], [state], [zip_code], [phone_number], [ssn]) VALUES (1002, N'Clark', N'Kent', CAST(N'1983-04-08' AS Date), N'M', N'3000 Washington Blvd.', N'', N'Austin', N'TX', N'78702', N'5557654321', N'987654321')
INSERT [dbo].[ClinicPersons] ([clinic_person_id], [first_name], [last_name], [date_of_birth], [gender], [street1], [street2], [city], [state], [zip_code], [phone_number], [ssn]) VALUES (1003, N'Robert', N'Banner', CAST(N'1975-12-03' AS Date), N'M', N'999 Hulk Ave.', N'', N'New York', N'NY', N'10001', N'5551114447', N'         ')
INSERT [dbo].[ClinicPersons] ([clinic_person_id], [first_name], [last_name], [date_of_birth], [gender], [street1], [street2], [city], [state], [zip_code], [phone_number], [ssn]) VALUES (1004, N'Karla', N'Sofen', CAST(N'1985-10-21' AS Date), N'F', N'4677 Marvel St.', N'', N'Dallas', N'TX', N'75201', N'5553454332', N'         ')
INSERT [dbo].[ClinicPersons] ([clinic_person_id], [first_name], [last_name], [date_of_birth], [gender], [street1], [street2], [city], [state], [zip_code], [phone_number], [ssn]) VALUES (1005, N'Mario', N'Molina', CAST(N'1943-03-19' AS Date), N'M', N'221 Chemistry Blvd.', N'', N'Albuquerque', N'NM', N'87107', N'5559879796', N'         ')
INSERT [dbo].[ClinicPersons] ([clinic_person_id], [first_name], [last_name], [date_of_birth], [gender], [street1], [street2], [city], [state], [zip_code], [phone_number], [ssn]) VALUES (1006, N'Max', N'Power', CAST(N'1975-01-05' AS Date), N'M', N'456 Lincoln Blvd.', N'', N'San Mateo', N'CA', N'92342', N'5555556666', N'         ')
INSERT [dbo].[ClinicPersons] ([clinic_person_id], [first_name], [last_name], [date_of_birth], [gender], [street1], [street2], [city], [state], [zip_code], [phone_number], [ssn]) VALUES (1007, N'Wanda', N'Maximoff', CAST(N'1980-04-18' AS Date), N'F', N'2800 Earth Street', N'', N'Westview', N'NJ', N'33147', N'9987987789', N'096646578')
SET IDENTITY_INSERT [dbo].[ClinicPersons] OFF
GO
SET IDENTITY_INSERT [dbo].[Doctors] ON 

INSERT [dbo].[Doctors] ([doctor_id], [clinic_person_id]) VALUES (200, 1003)
INSERT [dbo].[Doctors] ([doctor_id], [clinic_person_id]) VALUES (201, 1004)
INSERT [dbo].[Doctors] ([doctor_id], [clinic_person_id]) VALUES (202, 1005)
SET IDENTITY_INSERT [dbo].[Doctors] OFF
GO
INSERT [dbo].[LabTestResults] ([appointment_id], [lab_test_code], [date_performed], [result], [is_normal]) VALUES (1, N'BC', CAST(N'2021-04-22T13:47:09.000' AS DateTime), N'333', 1)
INSERT [dbo].[LabTestResults] ([appointment_id], [lab_test_code], [date_performed], [result], [is_normal]) VALUES (1, N'BCT', CAST(N'2021-04-13T13:47:19.000' AS DateTime), N'23', 1)
INSERT [dbo].[LabTestResults] ([appointment_id], [lab_test_code], [date_performed], [result], [is_normal]) VALUES (1, N'CT', CAST(N'2021-04-28T10:47:25.000' AS DateTime), N'132', 1)
INSERT [dbo].[LabTestResults] ([appointment_id], [lab_test_code], [date_performed], [result], [is_normal]) VALUES (2, N'BC', CAST(N'2021-04-19T10:09:22.000' AS DateTime), N'180', 0)
INSERT [dbo].[LabTestResults] ([appointment_id], [lab_test_code], [date_performed], [result], [is_normal]) VALUES (2, N'BCT', CAST(N'2021-04-28T10:16:23.000' AS DateTime), N'34', 0)
GO
INSERT [dbo].[LabTests] ([lab_test_code], [name]) VALUES (N'BCT', N'Blood cholesterol test')
INSERT [dbo].[LabTests] ([lab_test_code], [name]) VALUES (N'BC', N'Blood culture')
INSERT [dbo].[LabTests] ([lab_test_code], [name]) VALUES (N'CT', N'Chromosome testing')
GO
SET IDENTITY_INSERT [dbo].[Nurses] ON 

INSERT [dbo].[Nurses] ([nurse_id], [clinic_person_id], [username], [password]) VALUES (300, 1000, N'jane', N' K [¾ÙÓÅ-ë‡Ðw¼àx;BÜ­4ÿ‹nk9HîzËûêj¤_lðôõgt’R¾[z£Ð«‡=x¢Îhì&')
INSERT [dbo].[Nurses] ([nurse_id], [clinic_person_id], [username], [password]) VALUES (301, 1007, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Nurses] OFF
GO
SET IDENTITY_INSERT [dbo].[Patients] ON 

INSERT [dbo].[Patients] ([patient_id], [clinic_person_id]) VALUES (400, 1001)
INSERT [dbo].[Patients] ([patient_id], [clinic_person_id]) VALUES (401, 1002)
SET IDENTITY_INSERT [dbo].[Patients] OFF
GO
INSERT [dbo].[Visits] ([appointment_id], [nurse_id], [weight], [systolic_bp], [diastolic_bp], [body_temp], [pulse], [symptoms], [initial_diagnosis], [final_diagnosis]) VALUES (1, 300, CAST(178.00 AS Decimal(5, 2)), 120, 90, CAST(96.0 AS Decimal(5, 1)), 98, N'Vomiting; Weight loss; Abdominal pain', N'Ulcers', N'')
INSERT [dbo].[Visits] ([appointment_id], [nurse_id], [weight], [systolic_bp], [diastolic_bp], [body_temp], [pulse], [symptoms], [initial_diagnosis], [final_diagnosis]) VALUES (2, 300, CAST(150.00 AS Decimal(5, 2)), 100, 80, CAST(97.0 AS Decimal(5, 1)), 78, N'Headache', N'Stress', N'Workaholic')
GO
/****** Object:  Index [UQ_Administrators_clinic_person_id]    Script Date: 4/28/2021 10:46:01 AM ******/
ALTER TABLE [dbo].[Administrators] ADD  CONSTRAINT [UQ_Administrators_clinic_person_id] UNIQUE NONCLUSTERED 
(
	[clinic_person_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_Administrators_username]    Script Date: 4/28/2021 10:46:01 AM ******/
ALTER TABLE [dbo].[Administrators] ADD  CONSTRAINT [UQ_Administrators_username] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ_Appointments_date_doctor_id]    Script Date: 4/28/2021 10:46:01 AM ******/
ALTER TABLE [dbo].[Appointments] ADD  CONSTRAINT [UQ_Appointments_date_doctor_id] UNIQUE NONCLUSTERED 
(
	[doctor_id] ASC,
	[date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ_Appointments_date_patient_id]    Script Date: 4/28/2021 10:46:01 AM ******/
ALTER TABLE [dbo].[Appointments] ADD  CONSTRAINT [UQ_Appointments_date_patient_id] UNIQUE NONCLUSTERED 
(
	[date] ASC,
	[patient_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ_Doctors_clinic_person_id]    Script Date: 4/28/2021 10:46:01 AM ******/
ALTER TABLE [dbo].[Doctors] ADD  CONSTRAINT [UQ_Doctors_clinic_person_id] UNIQUE NONCLUSTERED 
(
	[clinic_person_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_LabTests_name]    Script Date: 4/28/2021 10:46:01 AM ******/
ALTER TABLE [dbo].[LabTests] ADD  CONSTRAINT [UQ_LabTests_name] UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ_Nurses_clinic_person_id]    Script Date: 4/28/2021 10:46:01 AM ******/
ALTER TABLE [dbo].[Nurses] ADD  CONSTRAINT [UQ_Nurses_clinic_person_id] UNIQUE NONCLUSTERED 
(
	[clinic_person_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Nurse_Username_IUC]    Script Date: 4/28/2021 10:46:01 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [Nurse_Username_IUC] ON [dbo].[Nurses]
(
	[username] ASC
)
WHERE ([username] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ_Patients_clinic_person_id]    Script Date: 4/28/2021 10:46:01 AM ******/
ALTER TABLE [dbo].[Patients] ADD  CONSTRAINT [UQ_Patients_clinic_person_id] UNIQUE NONCLUSTERED 
(
	[clinic_person_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ_Visits_appointment_id]    Script Date: 4/28/2021 10:46:01 AM ******/
ALTER TABLE [dbo].[Visits] ADD  CONSTRAINT [UQ_Visits_appointment_id] UNIQUE NONCLUSTERED 
(
	[appointment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Administrators]  WITH CHECK ADD  CONSTRAINT [FK_Administrators_ClinicPersons1] FOREIGN KEY([clinic_person_id])
REFERENCES [dbo].[ClinicPersons] ([clinic_person_id])
GO
ALTER TABLE [dbo].[Administrators] CHECK CONSTRAINT [FK_Administrators_ClinicPersons1]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appointments_Doctors] FOREIGN KEY([doctor_id])
REFERENCES [dbo].[Doctors] ([doctor_id])
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_Appointments_Doctors]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appointments_Patients] FOREIGN KEY([patient_id])
REFERENCES [dbo].[Patients] ([patient_id])
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_Appointments_Patients]
GO
ALTER TABLE [dbo].[Doctors]  WITH CHECK ADD  CONSTRAINT [FK_Doctors_ClinicPersons] FOREIGN KEY([clinic_person_id])
REFERENCES [dbo].[ClinicPersons] ([clinic_person_id])
GO
ALTER TABLE [dbo].[Doctors] CHECK CONSTRAINT [FK_Doctors_ClinicPersons]
GO
ALTER TABLE [dbo].[DoctorSpecialties]  WITH CHECK ADD  CONSTRAINT [FK_DoctorSpecialties_Doctors] FOREIGN KEY([doctor_id])
REFERENCES [dbo].[Doctors] ([doctor_id])
GO
ALTER TABLE [dbo].[DoctorSpecialties] CHECK CONSTRAINT [FK_DoctorSpecialties_Doctors]
GO
ALTER TABLE [dbo].[LabTestResults]  WITH CHECK ADD  CONSTRAINT [FK_LabTestResults_LabTests] FOREIGN KEY([lab_test_code])
REFERENCES [dbo].[LabTests] ([lab_test_code])
GO
ALTER TABLE [dbo].[LabTestResults] CHECK CONSTRAINT [FK_LabTestResults_LabTests]
GO
ALTER TABLE [dbo].[LabTestResults]  WITH CHECK ADD  CONSTRAINT [FK_LabTestResults_Visits1] FOREIGN KEY([appointment_id])
REFERENCES [dbo].[Visits] ([appointment_id])
GO
ALTER TABLE [dbo].[LabTestResults] CHECK CONSTRAINT [FK_LabTestResults_Visits1]
GO
ALTER TABLE [dbo].[Nurses]  WITH CHECK ADD  CONSTRAINT [FK_Nurses_ClinicPersons] FOREIGN KEY([clinic_person_id])
REFERENCES [dbo].[ClinicPersons] ([clinic_person_id])
GO
ALTER TABLE [dbo].[Nurses] CHECK CONSTRAINT [FK_Nurses_ClinicPersons]
GO
ALTER TABLE [dbo].[Patients]  WITH CHECK ADD  CONSTRAINT [FK_Patients_ClinicPersons] FOREIGN KEY([clinic_person_id])
REFERENCES [dbo].[ClinicPersons] ([clinic_person_id])
GO
ALTER TABLE [dbo].[Patients] CHECK CONSTRAINT [FK_Patients_ClinicPersons]
GO
ALTER TABLE [dbo].[Visits]  WITH CHECK ADD  CONSTRAINT [FK_Visits_Appointments] FOREIGN KEY([appointment_id])
REFERENCES [dbo].[Appointments] ([appointment_id])
GO
ALTER TABLE [dbo].[Visits] CHECK CONSTRAINT [FK_Visits_Appointments]
GO
ALTER TABLE [dbo].[Visits]  WITH CHECK ADD  CONSTRAINT [FK_Visits_Nurses] FOREIGN KEY([nurse_id])
REFERENCES [dbo].[Nurses] ([nurse_id])
GO
ALTER TABLE [dbo].[Visits] CHECK CONSTRAINT [FK_Visits_Nurses]
GO
/****** Object:  StoredProcedure [dbo].[getMostPerformedTestsDuringDates]    Script Date: 4/28/2021 10:46:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getMostPerformedTestsDuringDates] @StartDate DATE, @EndDate DATE
AS
SET NOCOUNT ON;
    DECLARE @AllTestsCount INT;

    IF  @StartDate IS NULL OR @EndDate IS NULL
        THROW 70001, 'You must specify a @StartDate and @EndDate.', 1;

    IF  @StartDate > @EndDate 
        THROW 70001, '@EndDate must be greater or equal than @StartDate.', 1;
    
    SELECT @AllTestsCount = COUNT(lab_test_code)
    FROM LabTestResults
    WHERE date_performed BETWEEN @StartDate AND @EndDate;
    
    SELECT 
        t.lab_test_code,
        t.name AS lab_test_name,
        COUNT(t.lab_test_code) AS tests_count,
        @AllTestsCount as all_tests_count,
        FORMAT(CAST(COUNT(t.lab_test_code) AS DECIMAL) / @AllTestsCount, 'P') AS test_count_percentage,
        [dbo].getLabTestResultTypeCount(t.lab_test_code, 1) AS normal_results_count,
        [dbo].getLabTestResultTypeCount(t.lab_test_code, 0) AS abnormal_results_count,
        FORMAT([dbo].getLabTestCountByPatientAgeRange(t.lab_test_code, 18, 29, 1) / CAST(COUNT(t.lab_test_code) AS DECIMAL), 'P') AS tests_on_18_29_percent,
        FORMAT([dbo].getLabTestCountByPatientAgeRange(t.lab_test_code, 30, 39, 1) / CAST(COUNT(t.lab_test_code) AS DECIMAL), 'P') AS tests_on_30_39_percent,
        FORMAT([dbo].getLabTestCountByPatientAgeRange(t.lab_test_code, 18, 39, 0) / CAST(COUNT(t.lab_test_code) AS DECIMAL), 'P') AS tests_on_not_18_39_percent
    FROM LabTestResults r
        INNER JOIN LabTests t ON (t.lab_test_code = r.lab_test_code)
    WHERE r.date_performed BETWEEN @StartDate AND @EndDate
    GROUP BY t.lab_test_code, t.name
    HAVING COUNT(t.lab_test_code) > 1
    ORDER BY tests_count DESC, t.lab_test_code DESC;

GO
USE [master]
GO
ALTER DATABASE [cs6232-g1] SET  READ_WRITE 
GO
