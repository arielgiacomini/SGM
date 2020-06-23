USE [DB_A57E2C_SGMLoquinho]
GO

/****** Object:  Table [dbo].[ServicoPeca]    Script Date: 23/06/2020 08:12:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ServicoPeca](
	[PecaId] [int] NULL,
	[ServicoId] [int] NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ServicoPeca]  WITH CHECK ADD FOREIGN KEY([PecaId])
REFERENCES [dbo].[Peca] ([PecaId])
GO

ALTER TABLE [dbo].[ServicoPeca]  WITH CHECK ADD  CONSTRAINT [FK__ServicoPe__Servi__02FC7413] FOREIGN KEY([ServicoId])
REFERENCES [dbo].[Servico] ([ServicoId])
GO

ALTER TABLE [dbo].[ServicoPeca] CHECK CONSTRAINT [FK__ServicoPe__Servi__02FC7413]
GO


