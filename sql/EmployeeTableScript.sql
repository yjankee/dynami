USE [Attrition]

/****** Object:  Table [dbo].[Employee]    Script Date: 7/15/2020 2:01:46 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

IF OBJECT_ID('EmployeeTable') IS NOT NULL DROP table [EmployeeTable]

CREATE TABLE [dbo].[EmployeeTable](
	[EmployeeNumber] [int] NOT NULL,
	[FirstName] [nvarchar](255) NOT NULL,
	[LastName] [nvarchar](255) NOT NULL,
	[DepartmentName] [nvarchar](255) NOT NULL,
	[District] [nvarchar](255) NOT NULL,
	[Site] [nvarchar](255) NOT NULL,
	[OnSiteDepartment] [nvarchar](255) NOT NULL,
	[HireDate] [datetime] NOT NULL,
	[LocationName] [nvarchar](255) NOT NULL,
	[PositionName] [nvarchar](255) NOT NULL,
	[ManagerDisplayName] [nvarchar](255) NOT NULL,
	[TerminationDate] [datetime]  NULL,
	[EmploymentStatusName] [nvarchar](255)  NULL,
	[IsVoluntaryTermination] [bit]  NULL, 
	[TerminationRegretType] [nvarchar](255)  NULL,
	[EmployeeGender] [nvarchar](255) NOT NULL,
	[EmployeeBirthDate] [datetime] NOT NULL,
	[PrimaryAddressCity] [nvarchar](255) NOT NULL,
	[MaritialStatusName] [nvarchar](255) NOT NULL,
	[ShiftRotationName] [nvarchar](255) NOT NULL,
	[JobLevel] [nvarchar](255) NOT NULL	
PRIMARY KEY CLUSTERED 
(
	[EmployeeNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

