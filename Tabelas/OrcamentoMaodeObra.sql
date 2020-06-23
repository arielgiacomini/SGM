USE [DB_A57E2C_SGMLoquinho]
GO

/****** Object:  Table [dbo].[OrcamentoMaodeObra]    Script Date: 23/06/2020 08:06:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OrcamentoMaodeObra](
	[OrcamentoId] [int] NOT NULL,
	[MaodeObraId] [int] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[OrcamentoMaodeObra]  WITH CHECK ADD FOREIGN KEY([MaodeObraId])
REFERENCES [dbo].[MaodeObra] ([MaodeObraId])
GO

ALTER TABLE [dbo].[OrcamentoMaodeObra]  WITH CHECK ADD  CONSTRAINT [FK__Orcamento__OrcamentoMaodeObra] FOREIGN KEY([OrcamentoId])
REFERENCES [dbo].[Orcamento] ([OrcamentoId])
GO

ALTER TABLE [dbo].[OrcamentoMaodeObra] CHECK CONSTRAINT [FK__Orcamento__OrcamentoMaodeObra]
GO


