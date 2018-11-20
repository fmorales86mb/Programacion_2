USE [master]
GO
/****** Object:  Database [parcial]    Script Date: 11/11/2018 2:33:32 PM ******/
CREATE DATABASE [parcial]
GO
USE [parcial]
GO
/****** Object:  Table [dbo].[trenes]    Script Date: 11/11/2018 2:33:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[trenes](
	[id] [numeric](18, 0) NULL,
	[arribo] [datetime] NULL,
	[mensaje] [nvarchar](100) NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [parcial] SET  READ_WRITE 
GO
