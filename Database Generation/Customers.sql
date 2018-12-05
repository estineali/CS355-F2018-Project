USE [KhanaMangwanaDatabase]
GO

/****** Object:  Table [dbo].[Customers]    Script Date: 05-Dec-2018 12:38:51 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] NOT NULL,
	[RoyaltyLevel] [int] NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_Users] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Users] ([PersonID])
GO

ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_Users]
GO

