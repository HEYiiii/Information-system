USE [c#]
GO
/****** Object:  Table [dbo].[academy]    Script Date: 2021/5/30 21:36:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[academy](
	[name] [nchar](30) NOT NULL,
	[sum] [nchar](10) NULL,
	[employedSum] [nchar](10) NULL,
 CONSTRAINT [PK_academy] PRIMARY KEY CLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[academy] ([name], [sum], [employedSum]) VALUES (N'电电                            ', N'500       ', N'0         ')
INSERT [dbo].[academy] ([name], [sum], [employedSum]) VALUES (N'计算机                           ', N'500       ', N'5         ')
INSERT [dbo].[academy] ([name], [sum], [employedSum]) VALUES (N'语言文化学院                        ', N'200       ', N'0         ')
