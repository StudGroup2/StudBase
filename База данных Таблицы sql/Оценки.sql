USE [StudBase]
GO

/****** Object:  Table [dbo].[Оценки]    Script Date: 14.06.2017 18:04:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Оценки](
	[Код] [int] NOT NULL,
	[ФИО С] [nchar](50) NOT NULL,
	[№ Группы] [nchar](50) NULL,
	[ФИО П] [nchar](50) NULL,
	[Дисциплина] [nchar](50) NULL,
	[Оценки] [int] NOT NULL,
 CONSTRAINT [код] PRIMARY KEY CLUSTERED 
(
	[Код] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Оценки]  WITH CHECK ADD  CONSTRAINT [FK_Оценки_Дисциплины1] FOREIGN KEY([Дисциплина])
REFERENCES [dbo].[Дисциплины] ([Название дисциплины])
GO

ALTER TABLE [dbo].[Оценки] CHECK CONSTRAINT [FK_Оценки_Дисциплины1]
GO

ALTER TABLE [dbo].[Оценки]  WITH CHECK ADD  CONSTRAINT [FK_Оценки_Преподаватели1] FOREIGN KEY([ФИО П])
REFERENCES [dbo].[Преподаватели] ([ФИО П])
GO

ALTER TABLE [dbo].[Оценки] CHECK CONSTRAINT [FK_Оценки_Преподаватели1]
GO

ALTER TABLE [dbo].[Оценки]  WITH CHECK ADD  CONSTRAINT [FK_Оценки_Студенты2] FOREIGN KEY([ФИО С])
REFERENCES [dbo].[Студенты] ([ФИО С])
GO

ALTER TABLE [dbo].[Оценки] CHECK CONSTRAINT [FK_Оценки_Студенты2]
GO

ALTER TABLE [dbo].[Оценки]  WITH CHECK ADD  CONSTRAINT [FK_Оценки_Студенты3] FOREIGN KEY([№ Группы])
REFERENCES [dbo].[Студенты] ([№ Группы])
GO

ALTER TABLE [dbo].[Оценки] CHECK CONSTRAINT [FK_Оценки_Студенты3]
GO

ALTER TABLE [dbo].[Оценки]  WITH CHECK ADD  CONSTRAINT [FK_Оценки_Уроки1] FOREIGN KEY([Оценки])
REFERENCES [dbo].[Уроки] ([Оценки])
GO

ALTER TABLE [dbo].[Оценки] CHECK CONSTRAINT [FK_Оценки_Уроки1]
GO

