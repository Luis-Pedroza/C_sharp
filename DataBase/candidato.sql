USE [votaciones]
GO

/****** Object:  Table [dbo].[candidato]    Script Date: 20/01/2023 12:17:14 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[candidato](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[claveRegistroID] [nvarchar](50) NOT NULL,
	[eleccionID] [int] NOT NULL,
 CONSTRAINT [PK_candidato] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[candidato]  WITH CHECK ADD  CONSTRAINT [FK_candidato_ciudadano] FOREIGN KEY([claveRegistroID])
REFERENCES [dbo].[ciudadano] ([claveRegistro])
GO

ALTER TABLE [dbo].[candidato] CHECK CONSTRAINT [FK_candidato_ciudadano]
GO

ALTER TABLE [dbo].[candidato]  WITH CHECK ADD  CONSTRAINT [FK_candidato_eleccion] FOREIGN KEY([eleccionID])
REFERENCES [dbo].[eleccion] ([id])
GO

ALTER TABLE [dbo].[candidato] CHECK CONSTRAINT [FK_candidato_eleccion]
GO

