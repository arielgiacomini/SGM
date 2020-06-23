USE [DB_A57E2C_SGMLoquinho]
GO

/****** Object:  Table [dbo].[Servico]    Script Date: 23/06/2020 08:09:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Servico](
	[ServicoId] [int] IDENTITY(1,1) NOT NULL,
	[ClienteId] [int] NOT NULL,
	[Descricao] [varchar](500) NOT NULL,
	[ValorAdicional] [decimal](18, 0) NOT NULL,
	[PercentualDesconto] [decimal](18, 0) NOT NULL,
	[ValorDesconto] [decimal](18, 0) NOT NULL,
	[ValorTotal] [decimal](18, 0) NOT NULL,
	[Status] [varchar](20) NOT NULL,
	[Ativo] [bit] NOT NULL,
	[DataCadastro] [datetime] NOT NULL,
 CONSTRAINT [PK__Servico__C59767B62AD0E52C] PRIMARY KEY CLUSTERED 
(
	[ServicoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Servico] ADD  CONSTRAINT [DF__Servico__Descric__72C60C4A]  DEFAULT ('') FOR [Descricao]
GO

ALTER TABLE [dbo].[Servico] ADD  CONSTRAINT [DF__Servico__ValorAd__73BA3083]  DEFAULT ((0.00)) FOR [ValorAdicional]
GO

ALTER TABLE [dbo].[Servico] ADD  CONSTRAINT [DF__Servico__Percent__74AE54BC]  DEFAULT ((0.00)) FOR [PercentualDesconto]
GO

ALTER TABLE [dbo].[Servico] ADD  CONSTRAINT [DF__Servico__ValorDe__75A278F5]  DEFAULT ((0.00)) FOR [ValorDesconto]
GO

ALTER TABLE [dbo].[Servico] ADD  CONSTRAINT [DF__Servico__ValorTo__76969D2E]  DEFAULT ((0.00)) FOR [ValorTotal]
GO

ALTER TABLE [dbo].[Servico] ADD  CONSTRAINT [DF__Servico__Status__778AC167]  DEFAULT ('') FOR [Status]
GO

ALTER TABLE [dbo].[Servico] ADD  CONSTRAINT [DF__Servico__Ativo__787EE5A0]  DEFAULT ((1)) FOR [Ativo]
GO

ALTER TABLE [dbo].[Servico] ADD  CONSTRAINT [DF__Servico__DataCad__797309D9]  DEFAULT (getutcdate()) FOR [DataCadastro]
GO

ALTER TABLE [dbo].[Servico]  WITH CHECK ADD  CONSTRAINT [FK__Servico__Cliente__7A672E12] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[Cliente] ([ClienteId])
GO

ALTER TABLE [dbo].[Servico] CHECK CONSTRAINT [FK__Servico__Cliente__7A672E12]
GO


