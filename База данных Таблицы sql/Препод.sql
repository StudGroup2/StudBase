USE [StudBase]
GO

/****** Object:  Table [dbo].[Преподаватели]    Script Date: 18.06.2017 18:17:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Преподаватели](
	[Код] [int] IDENTITY(1,1) NOT NULL,
	[ФИО П] [nvarchar](15) NOT NULL,
	[Должность] [nvarchar](15) NULL,
	[Дисциплина] [nvarchar](15) NULL,
	[Стаж (лет)] [int] NULL,
 CONSTRAINT [PK_Преподаватели] PRIMARY KEY CLUSTERED 
(
	[Код] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [фио п п] UNIQUE NONCLUSTERED 
(
	[ФИО П] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Преподаватели]  WITH CHECK ADD  CONSTRAINT [FK_Преподаватели_Дисциплины] FOREIGN KEY([Дисциплина])
REFERENCES [dbo].[Дисциплины] ([Дисциплина])
GO

ALTER TABLE [dbo].[Преподаватели] CHECK CONSTRAINT [FK_Преподаватели_Дисциплины]
GO

ALTER TABLE [dbo].[Преподаватели]  WITH CHECK ADD  CONSTRAINT [FK_Преподаватели_Должность] FOREIGN KEY([Должность])
REFERENCES [dbo].[Должность] ([Должность])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Преподаватели] CHECK CONSTRAINT [FK_Преподаватели_Должность]
GO

