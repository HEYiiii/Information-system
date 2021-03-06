USE [c#]
GO
/****** Object:  Table [dbo].[teacher]    Script Date: 2021/5/30 21:36:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[teacher](
	[name] [nchar](20) NOT NULL,
	[sex] [nchar](10) NULL,
	[phone] [nchar](11) NULL,
 CONSTRAINT [PK_teacher] PRIMARY KEY CLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[teacher] ([name], [sex], [phone]) VALUES (N'ltm                 ', N'女         ', N'15948627310')
INSERT [dbo].[teacher] ([name], [sex], [phone]) VALUES (N'trj                 ', N'女         ', N'12648795310')
