USE [KhanaMangwanaDatabase]
GO

/****** Object:  Table [dbo].[HasPrivilege]    Script Date: 05-Dec-2018 12:39:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HasPrivilege](
	[CustomerID] [int] NOT NULL,
	[PrivilegeID] [int] NOT NULL,
 CONSTRAINT [PK_HasPrivilege] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC,
	[PrivilegeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[HasPrivilege]  WITH CHECK ADD  CONSTRAINT [FK_HasPrivilege_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO

ALTER TABLE [dbo].[HasPrivilege] CHECK CONSTRAINT [FK_HasPrivilege_Customers]
GO

ALTER TABLE [dbo].[HasPrivilege]  WITH CHECK ADD  CONSTRAINT [FK_HasPrivilege_Privileges] FOREIGN KEY([PrivilegeID])
REFERENCES [dbo].[Privileges] ([PrivilegeID])
GO

ALTER TABLE [dbo].[HasPrivilege] CHECK CONSTRAINT [FK_HasPrivilege_Privileges]
GO

