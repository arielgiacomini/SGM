USE [DB_A57E2C_SGMLoquinho]
GO

/****** Object:  Table [dbo].[Peca]    Script Date: 23/06/2020 08:05:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Peca](
	[PecaId] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](500) NOT NULL,
	[Fornecedor] [varchar](500) NOT NULL,
	[Valor] [decimal](8, 2) NOT NULL,
	[ValorFrete] [decimal](8, 2) NOT NULL,
	[Ativo] [bit] NOT NULL,
	[DataCadastro] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PecaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Peca] ADD  DEFAULT ('') FOR [Descricao]
GO

ALTER TABLE [dbo].[Peca] ADD  DEFAULT ('') FOR [Fornecedor]
GO

ALTER TABLE [dbo].[Peca] ADD  DEFAULT ((0)) FOR [Valor]
GO

ALTER TABLE [dbo].[Peca] ADD  DEFAULT ((0)) FOR [ValorFrete]
GO

ALTER TABLE [dbo].[Peca] ADD  DEFAULT ((1)) FOR [Ativo]
GO

ALTER TABLE [dbo].[Peca] ADD  DEFAULT (getdate()) FOR [DataCadastro]
GO


