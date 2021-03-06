USE [dbEjercicio]
GO
/****** Object:  Table [dbo].[alumnos]    Script Date: 12/11/2018 22:06:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alumnos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[apellido] [nvarchar](50) NULL,
	[dni] [numeric](18, 0) NOT NULL,
	[nacimiento] [date] NULL,
	[direccion] [nvarchar](50) NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[alumnos] ON 

GO
INSERT [dbo].[alumnos] ([id], [nombre], [apellido], [dni], [nacimiento], [direccion]) VALUES (1, N'nombre', N'apellido', CAST(325 AS Numeric(18, 0)), NULL, N'asdf')
GO
SET IDENTITY_INSERT [dbo].[alumnos] OFF
GO
