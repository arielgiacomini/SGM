USE [DB_A57E2C_SGMLoquinho]
GO

/****** Object:  Table [dbo].[Orcamento]    Script Date: 23/06/2020 08:05:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Orcamento](
	[OrcamentoId] [int] IDENTITY(1,1) NOT NULL,
	[ClienteId] [int] NOT NULL,
	[Descricao] [varchar](500) NOT NULL,
	[ValorAdicional] [decimal](18, 2) NOT NULL,
	[PercentualDesconto] [decimal](18, 2) NOT NULL,
	[ValorDesconto] [decimal](18, 2) NOT NULL,
	[ValorTotal] [decimal](18, 2) NOT NULL,
	[Status] [varchar](20) NOT NULL,
	[Ativo] [bit] NOT NULL,
	[DataCadastro] [datetime] NOT NULL,
 CONSTRAINT [PK__Orcament__4E96F77939E02BD8] PRIMARY KEY CLUSTERED 
(
	[OrcamentoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Orcamento] ADD  CONSTRAINT [DF__Orcamento__Descr__5812160E]  DEFAULT ('') FOR [Descricao]
GO

ALTER TABLE [dbo].[Orcamento] ADD  CONSTRAINT [DF__Orcamento__Valor__59063A47]  DEFAULT ((0.0)) FOR [ValorAdicional]
GO

ALTER TABLE [dbo].[Orcamento] ADD  CONSTRAINT [DF__Orcamento__Perce__59FA5E80]  DEFAULT ((0.0)) FOR [PercentualDesconto]
GO

ALTER TABLE [dbo].[Orcamento] ADD  CONSTRAINT [DF__Orcamento__Valor__5AEE82B9]  DEFAULT ((0.0)) FOR [ValorDesconto]
GO

ALTER TABLE [dbo].[Orcamento] ADD  CONSTRAINT [DF__Orcamento__Valor__5BE2A6F2]  DEFAULT ((0.0)) FOR [ValorTotal]
GO

ALTER TABLE [dbo].[Orcamento] ADD  CONSTRAINT [DF__Orcamento__Ativo__5DCAEF64]  DEFAULT ((1)) FOR [Ativo]
GO

ALTER TABLE [dbo].[Orcamento] ADD  CONSTRAINT [DF__Orcamento__DataC__5EBF139D]  DEFAULT (getutcdate()) FOR [DataCadastro]
GO

ALTER TABLE [dbo].[Orcamento]  WITH CHECK ADD  CONSTRAINT [FK__Orcamento__Cliente] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[Cliente] ([ClienteId])
GO

ALTER TABLE [dbo].[Orcamento] CHECK CONSTRAINT [FK__Orcamento__Cliente]
GO


