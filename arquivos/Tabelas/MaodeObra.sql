USE [DB_A57E2C_SGMLoquinho]
GO

/****** Object:  Table [dbo].[MaodeObra]    Script Date: 23/06/2020 08:04:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MaodeObra](
	[MaodeObraId] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](500) NOT NULL,
	[Tipo] [varchar](100) NOT NULL,
	[Valor] [decimal](10, 2) NOT NULL,
	[VigenciaInicial] [datetime] NOT NULL,
	[VigenciaFinal] [datetime] NOT NULL,
	[Ativo] [bit] NOT NULL,
	[DataCadastro] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaodeObraId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[MaodeObra] ADD  DEFAULT ('') FOR [Descricao]
GO

ALTER TABLE [dbo].[MaodeObra] ADD  DEFAULT ('') FOR [Tipo]
GO

ALTER TABLE [dbo].[MaodeObra] ADD  DEFAULT ((0)) FOR [Valor]
GO

ALTER TABLE [dbo].[MaodeObra] ADD  DEFAULT ('') FOR [VigenciaInicial]
GO

ALTER TABLE [dbo].[MaodeObra] ADD  DEFAULT ('') FOR [VigenciaFinal]
GO

ALTER TABLE [dbo].[MaodeObra] ADD  DEFAULT ((1)) FOR [Ativo]
GO

ALTER TABLE [dbo].[MaodeObra] ADD  DEFAULT (getdate()) FOR [DataCadastro]
GO


