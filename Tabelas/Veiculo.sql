USE [DB_A57E2C_SGMLoquinho]
GO

/****** Object:  Table [dbo].[Veiculo]    Script Date: 23/06/2020 08:02:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Veiculo](
	[VeiculoId] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [varchar](200) NOT NULL,
	[Modelo] [varchar](200) NOT NULL,
	[VeiculoAtivo] [bit] NOT NULL,
	[DataCadastro] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[VeiculoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Veiculo] ADD  DEFAULT ('') FOR [Marca]
GO

ALTER TABLE [dbo].[Veiculo] ADD  DEFAULT ('') FOR [Modelo]
GO

ALTER TABLE [dbo].[Veiculo] ADD  DEFAULT ((1)) FOR [VeiculoAtivo]
GO

ALTER TABLE [dbo].[Veiculo] ADD  DEFAULT (getdate()) FOR [DataCadastro]
GO


