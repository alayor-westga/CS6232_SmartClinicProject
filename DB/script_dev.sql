USE [master]
--- Close all connections ---
DECLARE @kill varchar(8000) = '';  
SELECT @kill = @kill + 'kill ' + CONVERT(varchar(5), session_id) + ';'  
FROM sys.dm_exec_sessions
WHERE database_id  = db_id('cs6232-g1')
EXEC(@kill);
GO
DROP DATABASE IF EXISTS [cs6232-g1];
GO
/****** Object:  Database [cs6232-g1]    Script Date: 3/4/2021 9:44:11 PM ******/
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
/****** Object:  Table [dbo].[Administrators]    Script Date: 3/4/2021 9:44:11 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Administrators_clinic_person_id] UNIQUE NONCLUSTERED 
(
	[clinic_person_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Administrators_username] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appointments]    Script Date: 3/4/2021 9:44:11 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Appointments_date_doctor_id] UNIQUE NONCLUSTERED 
(
	[doctor_id] ASC,
	[date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Appointments_date_patient_id] UNIQUE NONCLUSTERED 
(
	[date] ASC,
	[patient_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClinicPersons]    Script Date: 3/4/2021 9:44:11 PM ******/
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
/****** Object:  Table [dbo].[Doctors]    Script Date: 3/4/2021 9:44:11 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Doctors_clinic_person_id] UNIQUE NONCLUSTERED 
(
	[clinic_person_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoctorSpecialties]    Script Date: 3/4/2021 9:44:11 PM ******/
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
/****** Object:  Table [dbo].[LabTestResults]    Script Date: 3/4/2021 9:44:11 PM ******/
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
/****** Object:  Table [dbo].[LabTests]    Script Date: 3/4/2021 9:44:11 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_LabTests_name] UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nurses]    Script Date: 3/4/2021 9:44:11 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Nurses_clinic_person_id] UNIQUE NONCLUSTERED 
(
	[clinic_person_id] ASC
)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

CREATE UNIQUE NONCLUSTERED INDEX Nurse_Username_IUC
ON [dbo].[Nurses](username)
WHERE username IS NOT NULL

GO
/****** Object:  Table [dbo].[Patients]    Script Date: 3/4/2021 9:44:11 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Patients_clinic_person_id] UNIQUE NONCLUSTERED 
(
	[clinic_person_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visits]    Script Date: 3/4/2021 9:44:11 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Visits_appointment_id] UNIQUE NONCLUSTERED 
(
	[appointment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
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
USE [master]
GO
ALTER DATABASE [cs6232-g1] SET  READ_WRITE 
GO

--- SEEDS ---
USE [cs6232-g1]
--- Create a Nurse ---
GO
DECLARE @clinic_person_id int
DECLARE @table table (id int)
INSERT INTO [dbo].[clinicpersons]
	(first_name,
	last_name,
	date_of_birth,
    gender,
    street1,
    street2,
    city,
    state,
    zip_code,
    phone_number,
	ssn)
OUTPUT inserted.clinic_person_id into @table
VALUES      
	('Jane',
	'Doe',
	'1990-07-28',
	'F',
	'123 Main St.',
	'',
	'San Francisco',
	'CA',
	'94102',
	'5555555555',
	'')
SELECT @clinic_person_id = id from @table
INSERT INTO [dbo].[Nurses]
	(clinic_person_id,
	username,
	password)
VALUES
	(@clinic_person_id,
	'jane',
	'test1234')

--- Create Patients ---
GO
DECLARE @clinic_person_id int
DECLARE @table table (id int)
INSERT INTO [dbo].[clinicpersons]
	(first_name,
	last_name,
	date_of_birth,
    gender,
    street1,
    street2,
    city,
    state,
    zip_code,
    phone_number,
	ssn)
OUTPUT inserted.clinic_person_id into @table
VALUES      
	('Bruce',
	'Wayne',
	'1980-01-03',
	'M',
	'456 Main Blvd.',
	'',
	'San Jose',
	'CA',
	'96102',
	'5551234567',
	'123456789')
SELECT @clinic_person_id = id from @table
INSERT INTO [dbo].[Patients]
	(clinic_person_id)
VALUES
	(@clinic_person_id)

INSERT INTO [dbo].[clinicpersons]
	(first_name,
	last_name,
	date_of_birth,
    gender,
    street1,
    street2,
    city,
    state,
    zip_code,
    phone_number,
	ssn)
OUTPUT inserted.clinic_person_id into @table
VALUES      
	('Clark',
	'Kent',
	'1983-04-08',
	'M',
	'3000 Washington Blvd.',
	'',
	'Austin',
	'TX',
	'78702',
	'5557654321',
	'987654321')
SELECT @clinic_person_id = id from @table
INSERT INTO [dbo].[Patients]
	(clinic_person_id)
VALUES
	(@clinic_person_id)


--- Create Doctors ---
GO
DECLARE @clinic_person_id int
DECLARE @table table (id int)
INSERT INTO [dbo].[clinicpersons]
	(first_name,
	last_name,
	date_of_birth,
    gender,
    street1,
    street2,
    city,
    state,
    zip_code,
    phone_number,
	ssn)
OUTPUT inserted.clinic_person_id into @table
VALUES      
	('Robert',
	'Banner',
	'1975-12-03',
	'M',
	'999 Hulk Ave.',
	'',
	'New York',
	'NY',
	'10001',
	'5551114447',
	'')
SELECT @clinic_person_id = id from @table
INSERT INTO [dbo].[Doctors]
	(clinic_person_id)
VALUES
	(@clinic_person_id)

INSERT INTO [dbo].[clinicpersons]
	(first_name,
	last_name,
	date_of_birth,
    gender,
    street1,
    street2,
    city,
    state,
    zip_code,
    phone_number,
	ssn)
OUTPUT inserted.clinic_person_id into @table
VALUES      
	('Karla',
	'Sofen',
	'1985-10-21',
	'F',
	'4677 Marvel St.',
	'',
	'Dallas',
	'TX',
	'75201',
	'5553454332',
	'')
SELECT @clinic_person_id = id from @table
INSERT INTO [dbo].[Doctors]
	(clinic_person_id)
VALUES
	(@clinic_person_id)

INSERT INTO [dbo].[clinicpersons]
	(first_name,
	last_name,
	date_of_birth,
    gender,
    street1,
    street2,
    city,
    state,
    zip_code,
    phone_number,
	ssn)
OUTPUT inserted.clinic_person_id into @table
VALUES      
	('Mario',
	'Molina',
	'1943-03-19',
	'M',
	'221 Chemistry Blvd.',
	'',
	'Albuquerque',
	'NM',
	'87107',
	'5559879796',
	'')
SELECT @clinic_person_id = id from @table
INSERT INTO [dbo].[Doctors]
	(clinic_person_id)
VALUES
	(@clinic_person_id)

--- Create an Admin ---
GO
DECLARE @clinic_person_id int
DECLARE @table table (id int)
INSERT INTO [dbo].[clinicpersons]
	(first_name,
	last_name,
	date_of_birth,
    gender,
    street1,
    street2,
    city,
    state,
    zip_code,
    phone_number,
	ssn)
OUTPUT inserted.clinic_person_id into @table
VALUES      
	('Max',
	'Power',
	'1975-01-05',
	'M',
	'456 Lincoln Blvd.',
	'',
	'San Mateo',
	'CA',
	'92342',
	'5555556666',
	'')
SELECT @clinic_person_id = id from @table
INSERT INTO [dbo].[Administrators]
	(clinic_person_id,
	username,
	password)
VALUES
	(@clinic_person_id,
	'doe',
	'test1234')

UPDATE Nurses
SET password = HASHBYTES('SHA2_512', password+CAST(username AS NVARCHAR(36)))

UPDATE Administrators
SET password = HASHBYTES('SHA2_512', password+CAST(username AS NVARCHAR(36)))

INSERT INTO LabTests
VALUES 
('BCT', 'Blood cholesterol test'),
('BC', 'Blood culture'),
('CT', 'Chromosome testing')