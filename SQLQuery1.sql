CREATE TABLE [dbo].[Employees](
[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
[Name] [nvarchar](50) NOT NULL,
[Address] [nvarchar](250) NULL,
[Designation] [nvarchar](50) NULL,
[Salary] [decimal](18, 0) NOT NULL,
[JoiningDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED
(
[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employees] ADD  DEFAULT (getdate()) FOR [JoiningDate]
GO