USE [KhanaMangwanaDatabase]
GO

/****** Object:  Table [dbo].[EatHouseCredit]    Script Date: 05-Dec-2018 12:39:18 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EatHouseCredit](
	[CustomerID] [int] NOT NULL,
	[EatHouseID] [int] NOT NULL,
	[Credit] [int] NULL,
 CONSTRAINT [PK_EatHouseCredit] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC,
	[EatHouseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[EatHouseCredit]  WITH CHECK ADD  CONSTRAINT [FK_EatHouseCredit_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO

ALTER TABLE [dbo].[EatHouseCredit] CHECK CONSTRAINT [FK_EatHouseCredit_Customers]
GO

ALTER TABLE [dbo].[EatHouseCredit]  WITH CHECK ADD  CONSTRAINT [FK_EatHouseCredit_EatHouses] FOREIGN KEY([EatHouseID])
REFERENCES [dbo].[EatHouses] ([EatHouseID])
GO

ALTER TABLE [dbo].[EatHouseCredit] CHECK CONSTRAINT [FK_EatHouseCredit_EatHouses]
GO

