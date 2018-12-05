USE [KhanaMangwanaDatabase]
GO

/****** Object:  Table [dbo].[Complaints]    Script Date: 05-Dec-2018 12:38:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Complaints](
	[ComplaintID] [int] IDENTITY(1,1) NOT NULL,
	[AdminID] [int] NOT NULL,
	[Complain] [text] NULL,
	[Resolved] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ComplaintID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Complaints]  WITH CHECK ADD  CONSTRAINT [FK_Complaints_Users] FOREIGN KEY([AdminID])
REFERENCES [dbo].[Users] ([PersonID])
GO

ALTER TABLE [dbo].[Complaints] CHECK CONSTRAINT [FK_Complaints_Users]
GO

