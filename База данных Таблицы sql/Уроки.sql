USE [StudBase]
GO

/****** Object:  Table [dbo].[Уроки]    Script Date: 18.06.2017 18:18:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Уроки](
	[Код] [int] IDENTITY(1,1) NOT NULL,
	[Дисциплина] [nvarchar](15) NULL,
	[ФИО П] [int] NULL,
	[№ Группы] [nvarchar](15) NULL,
	[ФИО С] [int] NULL,
	[Оценки] [int] NULL,
	[Присутствие на занятии] [bit] NULL,
 CONSTRAINT [PK_Уроки] PRIMARY KEY CLUSTERED 
(
	[Код] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Уроки]  WITH CHECK ADD  CONSTRAINT [FK_Уроки_Дисциплины] FOREIGN KEY([Дисциплина])
REFERENCES [dbo].[Дисциплины] ([Дисциплина])
GO

ALTER TABLE [dbo].[Уроки] CHECK CONSTRAINT [FK_Уроки_Дисциплины]
GO

ALTER TABLE [dbo].[Уроки]  WITH CHECK ADD  CONSTRAINT [FK_Уроки_Преподаватели] FOREIGN KEY([ФИО П])
REFERENCES [dbo].[Преподаватели] ([Код])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Уроки] CHECK CONSTRAINT [FK_Уроки_Преподаватели]
GO

ALTER TABLE [dbo].[Уроки]  WITH CHECK ADD  CONSTRAINT [FK_Уроки_Студенты] FOREIGN KEY([ФИО С])
REFERENCES [dbo].[Студенты] ([Код])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Уроки] CHECK CONSTRAINT [FK_Уроки_Студенты]
GO

