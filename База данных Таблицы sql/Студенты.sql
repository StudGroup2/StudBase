USE [StudBase]
GO

/****** Object:  Table [dbo].[Студенты]    Script Date: 14.06.2017 18:05:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Студенты](
	[Код] [int] NOT NULL,
	[ФИО С] [nchar](50) NOT NULL,
	[№ Группы] [nchar](50) NULL,
	[Год рождения] [nchar](50) NULL,
 CONSTRAINT [код с] PRIMARY KEY CLUSTERED 
(
	[Код] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [фио с] UNIQUE NONCLUSTERED 
(
	[ФИО С] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

