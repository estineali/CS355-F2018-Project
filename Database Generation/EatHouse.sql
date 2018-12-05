USE [KhanaMangwanaDatabase]
GO

/****** Object:  Table [dbo].[EatHouses]    Script Date: 05-Dec-2018 12:39:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EatHouses](
	[EatHouseID] [int] NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[OpeningTime] [time](7) NOT NULL,
	[ClosingTime] [time](7) NOT NULL,
	[isOpen] [bit] NOT NULL,
 CONSTRAINT [PK_EatHouses] PRIMARY KEY CLUSTERED 
(
	[EatHouseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

