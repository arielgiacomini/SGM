USE [DB_A57E2C_SGMLoquinho]
GO

/****** Object:  Table [dbo].[Colaborador]    Script Date: 23/06/2020 08:13:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Colaborador](
	[ColaboradorId] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](200) NOT NULL,
	[Senha] [int] NOT NULL,
	[Nome] [varchar](200) NOT NULL,
	[NomeCompleto] [varchar](200) NULL,
	[Apelido] [varchar](50) NULL,
	[CPF] [varchar](14) NULL,
	[RG] [varchar](20) NULL,
	[DataAdmissao] [datetime] NOT NULL,
	[DataDemissao] [datetime] NULL,
	[DataCadastro] [datetime] NOT NULL,
	[DataAlteracao] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ColaboradorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


