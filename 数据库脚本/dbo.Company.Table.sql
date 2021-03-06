USE [c#]
GO
/****** Object:  Table [dbo].[Company]    Script Date: 2021/5/30 21:36:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](100) NOT NULL,
	[Address] [nchar](100) NOT NULL,
	[Postcode] [char](6) NOT NULL,
	[StudentNum] [char](10) NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Company] ON 

INSERT [dbo].[Company] ([id], [Name], [Address], [Postcode], [StudentNum]) VALUES (10, N'another                                                                                             ', N'another                                                                                             ', N'123456', N'1         ')
INSERT [dbo].[Company] ([id], [Name], [Address], [Postcode], [StudentNum]) VALUES (9, N'new                                                                                                 ', N'new                                                                                                 ', N'123456', N'2         ')
INSERT [dbo].[Company] ([id], [Name], [Address], [Postcode], [StudentNum]) VALUES (14, N'test                                                                                                ', N'test                                                                                                ', N'123456', N'1         ')
INSERT [dbo].[Company] ([id], [Name], [Address], [Postcode], [StudentNum]) VALUES (12, N'一家公司                                                                                                ', N'一家公司                                                                                                ', N'654321', N'1         ')
INSERT [dbo].[Company] ([id], [Name], [Address], [Postcode], [StudentNum]) VALUES (13, N'一家旧公司                                                                                               ', N'一家旧公司                                                                                               ', N'123456', N'1         ')
SET IDENTITY_INSERT [dbo].[Company] OFF
