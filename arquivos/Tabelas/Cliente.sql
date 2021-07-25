USE [DB_A57E2C_SGMLoquinho]
GO

/****** Object:  Table [dbo].[Cliente]    Script Date: 23/06/2020 08:00:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cliente](
	[ClienteId] [int] IDENTITY(1,1) NOT NULL,
	[NomeCliente] [varchar](200) NULL,
	[Apelido] [varchar](200) NULL,
	[DocumentoCliente] [varchar](200) NULL,
	[Sexo] [varchar](20) NULL,
	[EstadoCivil] [varchar](20) NULL,
	[DataNascimento] [datetime] NULL,
	[Email] [varchar](200) NULL,
	[TelefoneFixo] [varchar](20) NULL,
	[TelefoneCelular] [varchar](20) NULL,
	[TelefoneOutros] [varchar](20) NULL,
	[LogradouroCEP] [varchar](15) NULL,
	[LogradouroNome] [varchar](500) NULL,
	[LogradouroNumero] [varchar](20) NULL,
	[LogradouroComplemento] [varchar](500) NULL,
	[LogradouroMunicipio] [varchar](500) NULL,
	[LogradouroBairro] [varchar](500) NULL,
	[LogradouroUF] [char](2) NULL,
	[RecebeNotificacoes] [bit] NULL,
	[ClienteAtivo] [bit] NULL,
	[DataCadastro] [datetime] NULL,
	[DataAlteracao] [datetime] NULL,
 CONSTRAINT [PK__Cliente__71ABD087120AED41] PRIMARY KEY CLUSTERED 
(
	[ClienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [DF__Cliente__NomeCli__24927208]  DEFAULT ('') FOR [NomeCliente]
GO

ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [DF__Cliente__Apelido__25869641]  DEFAULT ('') FOR [Apelido]
GO

ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [DF__Cliente__Documen__267ABA7A]  DEFAULT ('') FOR [DocumentoCliente]
GO

ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [DF__Cliente__Sexo__276EDEB3]  DEFAULT ('') FOR [Sexo]
GO

ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [DF__Cliente__EstadoC__286302EC]  DEFAULT ('') FOR [EstadoCivil]
GO

ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [DF__Cliente__Email__29572725]  DEFAULT ('') FOR [Email]
GO

ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [DF__Cliente__Telefon__2A4B4B5E]  DEFAULT ('(00)0000-0000') FOR [TelefoneFixo]
GO

ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [DF__Cliente__Telefon__2B3F6F97]  DEFAULT ('(00)0-0000-0000') FOR [TelefoneCelular]
GO

ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [DF__Cliente__Telefon__2C3393D0]  DEFAULT ('(00)0-0000-0000') FOR [TelefoneOutros]
GO

ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [DF__Cliente__Logrado__2D27B809]  DEFAULT ('') FOR [LogradouroCEP]
GO

ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [DF__Cliente__Logrado__2E1BDC42]  DEFAULT ('') FOR [LogradouroNome]
GO

ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [DF__Cliente__Logrado__2F10007B]  DEFAULT ('') FOR [LogradouroNumero]
GO

ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [DF__Cliente__Logrado__300424B4]  DEFAULT ('') FOR [LogradouroComplemento]
GO

ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [DF__Cliente__Logrado__30F848ED]  DEFAULT ('') FOR [LogradouroMunicipio]
GO

ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [DF__Cliente__Logrado__31EC6D26]  DEFAULT ('') FOR [LogradouroBairro]
GO

ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [DF__Cliente__Logrado__32E0915F]  DEFAULT ('') FOR [LogradouroUF]
GO

ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [DF__Cliente__RecebeN__33D4B598]  DEFAULT ((0)) FOR [RecebeNotificacoes]
GO

ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [DF__Cliente__Cliente__34C8D9D1]  DEFAULT ((1)) FOR [ClienteAtivo]
GO

ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [DF_Cliente_DataCadastro]  DEFAULT (getutcdate()) FOR [DataCadastro]
GO

ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [DF_Cliente_DataAlteracao]  DEFAULT (getutcdate()) FOR [DataAlteracao]
GO


