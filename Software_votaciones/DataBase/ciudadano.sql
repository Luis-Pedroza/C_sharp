USE [votaciones]
GO

/****** Object:  Table [dbo].[ciudadano]    Script Date: 20/01/2023 12:17:32 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ciudadano](
	[claveRegistro] [nvarchar](50) NOT NULL,
	[nombre] [nvarchar](250) NOT NULL,
	[apellidoPaterno] [nvarchar](250) NOT NULL,
	[apellidoMaterno] [nvarchar](250) NOT NULL,
	[ROLid] [int] NOT NULL,
	[foto] [nvarchar](50) NULL,
 CONSTRAINT [PK_ciudadano] PRIMARY KEY CLUSTERED 
(
	[claveRegistro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ciudadano]  WITH CHECK ADD  CONSTRAINT [FK_ciudadano_rol] FOREIGN KEY([ROLid])
REFERENCES [dbo].[rol] ([id])
GO

ALTER TABLE [dbo].[ciudadano] CHECK CONSTRAINT [FK_ciudadano_rol]
GO

