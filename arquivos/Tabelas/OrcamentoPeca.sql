USE [DB_A57E2C_SGMLoquinho]
GO

/****** Object:  Table [dbo].[OrcamentoPeca]    Script Date: 23/06/2020 08:07:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OrcamentoPeca](
	[OrcamentoId] [int] NOT NULL,
	[PecaId] [int] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[OrcamentoPeca]  WITH CHECK ADD  CONSTRAINT [FK__Orcamento__OrcamentoPeca] FOREIGN KEY([OrcamentoId])
REFERENCES [dbo].[Orcamento] ([OrcamentoId])
GO

ALTER TABLE [dbo].[OrcamentoPeca] CHECK CONSTRAINT [FK__Orcamento__OrcamentoPeca]
GO

ALTER TABLE [dbo].[OrcamentoPeca]  WITH CHECK ADD FOREIGN KEY([PecaId])
REFERENCES [dbo].[Peca] ([PecaId])
GO


