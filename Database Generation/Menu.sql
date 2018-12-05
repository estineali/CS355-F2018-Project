USE [KhanaMangwanaDatabase]
GO

/****** Object:  Table [dbo].[Menu]    Script Date: 05-Dec-2018 12:42:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Menu](
	[ItemID] [varchar](15) NOT NULL,
	[EathouseID] [int] NOT NULL,
	[ItemName] [varchar](max) NOT NULL,
	[Cost] [int] NOT NULL,
	[Calories] [float] NULL,
	[PrepTime] [float] NULL,
	[isAvailable] [bit] NOT NULL,
	[ItemType] [varchar](20) NULL,
	[Stars] [int] NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Menu]  WITH CHECK ADD  CONSTRAINT [FK_Menu_EatHouses] FOREIGN KEY([EathouseID])
REFERENCES [dbo].[EatHouses] ([EatHouseID])
GO

ALTER TABLE [dbo].[Menu] CHECK CONSTRAINT [FK_Menu_EatHouses]
GO

