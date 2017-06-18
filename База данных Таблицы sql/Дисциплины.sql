USE [StudBase]
GO

/****** Object:  Table [dbo].[Дисциплины]    Script Date: 18.06.2017 18:17:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Дисциплины](
	[Дисциплина] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_Дисциплины_1] PRIMARY KEY CLUSTERED 
(
	[Дисциплина] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

