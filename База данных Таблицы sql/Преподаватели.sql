USE [StudBase]
GO

/****** Object:  Table [dbo].[Преподаватели]    Script Date: 14.06.2017 18:05:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Преподаватели](
	[Код] [int] NOT NULL,
	[ФИО П] [nchar](50) NOT NULL,
	[Должность] [nchar](50) NULL,
	[Предметы] [nchar](50) NULL,
	[Стаж (лет)] [int] NULL,
 CONSTRAINT [PK_Преподаватели] PRIMARY KEY CLUSTERED 
(
	[Код] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Преподаватели]  WITH CHECK ADD  CONSTRAINT [FK_Преподаватели_Дисциплины1] FOREIGN KEY([Предметы])
REFERENCES [dbo].[Дисциплины] ([Название дисциплины])
GO

ALTER TABLE [dbo].[Преподаватели] CHECK CONSTRAINT [FK_Преподаватели_Дисциплины1]
GO

ALTER TABLE [dbo].[Преподаватели]  WITH CHECK ADD  CONSTRAINT [FK_Преподаватели_Должность] FOREIGN KEY([Должность])
REFERENCES [dbo].[Должность] ([Должность])
GO

ALTER TABLE [dbo].[Преподаватели] CHECK CONSTRAINT [FK_Преподаватели_Должность]
GO

