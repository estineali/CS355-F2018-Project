USE [KhanaMangwanaDatabase]
GO

/****** Object:  Table [dbo].[Privileges]    Script Date: 05-Dec-2018 12:43:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Privileges](
	[PrivilegeID] [int] IDENTITY(1,1) NOT NULL,
	[Privilege] [varchar](max) NULL,
	[IsActive] [bit] NOT NULL,
	[EatHouseID] [int] NOT NULL,
	[ReqRoyaltyLevel] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PrivilegeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Privileges]  WITH CHECK ADD  CONSTRAINT [FK_Privilege_EatHouses] FOREIGN KEY([EatHouseID])
REFERENCES [dbo].[EatHouses] ([EatHouseID])
GO

ALTER TABLE [dbo].[Privileges] CHECK CONSTRAINT [FK_Privilege_EatHouses]
GO

