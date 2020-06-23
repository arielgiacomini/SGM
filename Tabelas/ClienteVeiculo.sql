USE [DB_A57E2C_SGMLoquinho]
GO

/****** Object:  Table [dbo].[ClienteVeiculo]    Script Date: 23/06/2020 08:03:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClienteVeiculo](
	[ClienteVeiculoId] [int] IDENTITY(1,1) NOT NULL,
	[ClienteId] [int] NULL,
	[VeiculoId] [int] NULL,
	[AnoVeiculo] [int] NOT NULL,
	[PlacaVeiculo] [varchar](10) NOT NULL,
	[CorVeiculo] [varchar](200) NOT NULL,
	[KmRodados] [int] NOT NULL,
 CONSTRAINT [PK__ClienteV__FFF8CA1F23C02A39] PRIMARY KEY CLUSTERED 
(
	[ClienteVeiculoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ClienteVeiculo] ADD  CONSTRAINT [DF__ClienteVe__AnoVe__44FF419A]  DEFAULT ((0)) FOR [AnoVeiculo]
GO

ALTER TABLE [dbo].[ClienteVeiculo] ADD  CONSTRAINT [DF__ClienteVe__Placa__45F365D3]  DEFAULT ('') FOR [PlacaVeiculo]
GO

ALTER TABLE [dbo].[ClienteVeiculo] ADD  CONSTRAINT [DF__ClienteVe__CorVe__46E78A0C]  DEFAULT ('') FOR [CorVeiculo]
GO

ALTER TABLE [dbo].[ClienteVeiculo] ADD  CONSTRAINT [DF__ClienteVe__KmRod__47DBAE45]  DEFAULT ((0)) FOR [KmRodados]
GO

ALTER TABLE [dbo].[ClienteVeiculo]  WITH CHECK ADD  CONSTRAINT [FK__ClienteVe__Clien__49C3F6B7] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[Cliente] ([ClienteId])
GO

ALTER TABLE [dbo].[ClienteVeiculo] CHECK CONSTRAINT [FK__ClienteVe__Clien__49C3F6B7]
GO

ALTER TABLE [dbo].[ClienteVeiculo]  WITH CHECK ADD  CONSTRAINT [FK__ClienteVe__Veicu__48CFD27E] FOREIGN KEY([VeiculoId])
REFERENCES [dbo].[Veiculo] ([VeiculoId])
GO

ALTER TABLE [dbo].[ClienteVeiculo] CHECK CONSTRAINT [FK__ClienteVe__Veicu__48CFD27E]
GO


