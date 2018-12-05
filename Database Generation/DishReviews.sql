USE [KhanaMangwanaDatabase]
GO

/****** Object:  Table [dbo].[DishReview]    Script Date: 05-Dec-2018 12:39:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DishReview](
	[ReviewID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[ItemID] [varchar](15) NOT NULL,
	[OrderDateTime] [datetime] NOT NULL,
	[Review] [text] NULL,
	[Stars] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ReviewID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[DishReview]  WITH CHECK ADD  CONSTRAINT [FK__DishReviews__Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO

ALTER TABLE [dbo].[DishReview] CHECK CONSTRAINT [FK__DishReviews__Customers]
GO

ALTER TABLE [dbo].[DishReview]  WITH CHECK ADD  CONSTRAINT [FK__DishReviews__Menu] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Menu] ([ItemID])
GO

ALTER TABLE [dbo].[DishReview] CHECK CONSTRAINT [FK__DishReviews__Menu]
GO

