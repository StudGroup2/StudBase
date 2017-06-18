USE [StudBase]
GO

/****** Object:  Table [dbo].[Уроки]    Script Date: 14.06.2017 18:09:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Уроки](
	[Код] [int] NOT NULL,
	[Название дисциплины] [nchar](50) NULL,
	[Дата урока] [date] NULL,
	[ФИО П] [nchar](50) NULL,
	[ФИО С] [nchar](50) NULL,
	[Оценки] [int] NULL,
	[Присутствие на занятии] [bit] NULL,
 CONSTRAINT [PK_Уроки] PRIMARY KEY CLUSTERED 
(
	[Код] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Уроки]  WITH CHECK ADD  CONSTRAINT [FK_Уроки_Дисциплины1] FOREIGN KEY([Название дисциплины])
REFERENCES [dbo].[Дисциплины] ([Название дисциплины])
GO

ALTER TABLE [dbo].[Уроки] CHECK CONSTRAINT [FK_Уроки_Дисциплины1]
GO

ALTER TABLE [dbo].[Уроки]  WITH CHECK ADD  CONSTRAINT [FK_Уроки_Преподаватели1] FOREIGN KEY([ФИО П])
REFERENCES [dbo].[Преподаватели] ([ФИО П])
GO

ALTER TABLE [dbo].[Уроки] CHECK CONSTRAINT [FK_Уроки_Преподаватели1]
GO

ALTER TABLE [dbo].[Уроки]  WITH CHECK ADD  CONSTRAINT [FK_Уроки_Студенты1] FOREIGN KEY([ФИО С])
REFERENCES [dbo].[Студенты] ([ФИО С])
GO

ALTER TABLE [dbo].[Уроки] CHECK CONSTRAINT [FK_Уроки_Студенты1]
GO

