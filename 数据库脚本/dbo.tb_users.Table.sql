USE [c#]
GO
/****** Object:  Table [dbo].[tb_users]    Script Date: 2021/5/30 21:36:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_users](
	[username] [varchar](20) NOT NULL,
	[password] [varchar](10) NULL,
	[limit] [smallint] NOT NULL,
	[email] [nchar](10) NULL,
 CONSTRAINT [PK_tb_users] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tb_users] ([username], [password], [limit], [email]) VALUES (N'adm', N'123456', 0, N'123@qq.com')
INSERT [dbo].[tb_users] ([username], [password], [limit], [email]) VALUES (N'student1', N'123456', 1, N'123@qq.com')
INSERT [dbo].[tb_users] ([username], [password], [limit], [email]) VALUES (N'student2', N'123456', 1, N'123@qq.com')
INSERT [dbo].[tb_users] ([username], [password], [limit], [email]) VALUES (N'teacher', N'123456', 0, N'123@qq.com')
INSERT [dbo].[tb_users] ([username], [password], [limit], [email]) VALUES (N'zs', N'123456', 1, N'123@qq.com')
