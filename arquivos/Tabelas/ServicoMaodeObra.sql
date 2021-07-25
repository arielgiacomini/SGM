USE [DB_A57E2C_SGMLoquinho]
GO

/****** Object:  Table [dbo].[ServicoMaodeObra]    Script Date: 23/06/2020 08:11:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ServicoMaodeObra](
	[MaodeObraId] [int] NULL,
	[ServicoId] [int] NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ServicoMaodeObra]  WITH CHECK ADD FOREIGN KEY([MaodeObraId])
REFERENCES [dbo].[MaodeObra] ([MaodeObraId])
GO

ALTER TABLE [dbo].[ServicoMaodeObra]  WITH CHECK ADD  CONSTRAINT [FK__ServicoMa__Servi__00200768] FOREIGN KEY([ServicoId])
REFERENCES [dbo].[Servico] ([ServicoId])
GO

ALTER TABLE [dbo].[ServicoMaodeObra] CHECK CONSTRAINT [FK__ServicoMa__Servi__00200768]
GO


