USE [master]
GO
/****** Object:  Database [ChinaMarinetime]    Script Date: 2018/10/22 16:05:56 ******/
GO
CREATE TABLE [dbo].[FileRoute](
	[FileNo] [nchar](5) NOT NULL,
	[FileRoute] [varchar](200) NULL,
	[CallNo] [nchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[FileNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[FileRoute] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KeyWord]    Script Date: 2018/10/22 16:05:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KeyWord](
	[CallNo] [nchar](5) NOT NULL,
	[Keyword] [varchar](20) NOT NULL,
 CONSTRAINT [KW] PRIMARY KEY CLUSTERED 
(
	[CallNo] ASC,
	[Keyword] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PageInfo]    Script Date: 2018/10/22 16:05:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PageInfo](
	[CallNo] [nchar](5) NOT NULL,
	[BookName] [varchar](120) NOT NULL,
	[StartTime] [smallint] NULL,
	[EndTime] [smallint] NULL,
	[BookNo] [tinyint] NOT NULL,
	[StartPage] [smallint] NULL,
	[EndPage] [smallint] NULL,
	[Condition] [varchar](100) NULL,
	[Region] [varchar](50) NULL,
	[Title] [varchar](50) NULL,
	[Tag] [nchar](1) NULL,
	[Category] [varchar](10) NULL,
	[Remark1] [varchar](30) NULL,
	[Remark2] [varchar](30) NULL,
	[Composition] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[CallNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[PageInfo] ADD  DEFAULT ((1)) FOR [BookNo]
GO
/****** Object:  StoredProcedure [dbo].[fileno_procA]    Script Date: 2018/10/22 16:05:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[fileno_procA]
@_cn NCHAR(20)
AS
	SELECT FileNo
	FROM FileRoute
	WHERE CallNo = @_cn
GO
/****** Object:  StoredProcedure [dbo].[fileroute_procA]    Script Date: 2018/10/22 16:05:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[fileroute_procA]
@_fn NCHAR(5),
@_fr VARCHAR(200) OUTPUT
AS
	SELECT @_fr = FileRoute
	FROM FileRoute
	WHERE FileNo = @_fn
GO
/****** Object:  StoredProcedure [dbo].[fileroute_procB]    Script Date: 2018/10/22 16:05:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[fileroute_procB]
@_cn NCHAR(5),
@_fr VARCHAR(200) OUTPUT
AS
	SELECT @_fr = FileRoute
	FROM FileRoute
	WHERE CallNo = @_cn
GO
/****** Object:  StoredProcedure [dbo].[pageinfo_procA]    Script Date: 2018/10/22 16:05:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pageinfo_procA]
@_kw VARCHAR(20)
AS
	SELECT CallNo, Condition, Region, Title, Tag, Category, Remark1, Remark2
	FROM PageInfo
	WHERE CallNo IN
	(SELECT kw.CallNo FROM KeyWord AS kw WHERE kw.Keyword = @_kw)
GO
USE [master]
GO
ALTER DATABASE [ChinaMarinetime] SET  READ_WRITE 
GO
