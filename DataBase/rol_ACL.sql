USE [votaciones]
GO

/****** Object:  Table [dbo].[rol_ACL]    Script Date: 20/01/2023 12:18:07 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[rol_ACL](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ROLid] [int] NOT NULL,
	[ACLid] [int] NOT NULL,
 CONSTRAINT [PK_rol_ACL] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[rol_ACL]  WITH CHECK ADD  CONSTRAINT [FK_rol_ACL_ACL] FOREIGN KEY([ACLid])
REFERENCES [dbo].[ACL] ([id])
GO

ALTER TABLE [dbo].[rol_ACL] CHECK CONSTRAINT [FK_rol_ACL_ACL]
GO

ALTER TABLE [dbo].[rol_ACL]  WITH CHECK ADD  CONSTRAINT [FK_rol_ACL_rol] FOREIGN KEY([ROLid])
REFERENCES [dbo].[rol] ([id])
GO

ALTER TABLE [dbo].[rol_ACL] CHECK CONSTRAINT [FK_rol_ACL_rol]
GO
