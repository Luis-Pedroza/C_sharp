USE [votaciones]
GO

/****** Object:  Table [dbo].[votacion]    Script Date: 20/01/2023 12:18:19 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[votacion](
	[claveRegistroID] [nvarchar](50) NOT NULL,
	[candidatoID] [int] NOT NULL,
	[fecha] [datetime] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[votacion]  WITH CHECK ADD  CONSTRAINT [FK_votacion_candidato] FOREIGN KEY([candidatoID])
REFERENCES [dbo].[candidato] ([id])
GO

ALTER TABLE [dbo].[votacion] CHECK CONSTRAINT [FK_votacion_candidato]
GO

ALTER TABLE [dbo].[votacion]  WITH CHECK ADD  CONSTRAINT [FK_votacion_ciudadano] FOREIGN KEY([claveRegistroID])
REFERENCES [dbo].[ciudadano] ([claveRegistro])
GO

ALTER TABLE [dbo].[votacion] CHECK CONSTRAINT [FK_votacion_ciudadano]
GO

