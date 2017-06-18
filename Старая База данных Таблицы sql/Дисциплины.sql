USE [StudBase]
GO

/****** Object:  Table [dbo].[Дисциплины]    Script Date: 14.06.2017 18:01:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Дисциплины](
	[Код] [int] NOT NULL,
	[Название дисциплины] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Дисциплины] PRIMARY KEY CLUSTERED 
(
	[Код] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

