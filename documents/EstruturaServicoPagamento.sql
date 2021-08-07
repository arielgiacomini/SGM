CREATE TABLE [Cliente] (
  [ClienteId] INT PRIMARY KEY IDENTITY(1, 1),
  [NomeCliente] VARCHAR(200),
  [Apelido] VARCHAR(200),
  [DocumentoCliente] VARCHAR(200),
  [Sexo] VARCHAR(200),
  [EstadoCivil] VARCHAR(200),
  [DataNascimento] DATETIME,
  [Email] VARCHAR(200),
  [TelefoneFixo] VARCHAR(200),
  [TelefoneCelular] VARCHAR(200),
  [TelefoneOutros] VARCHAR(200),
  [LogradouroCEP] VARCHAR(200),
  [LogradouroNome] VARCHAR(200),
  [LogradouroNumero] VARCHAR(200),
  [LogradouroComplemento] VARCHAR(200),
  [LogradouroMunicipio] VARCHAR(200),
  [LogradouroBairro] VARCHAR(200),
  [LogradouroUF] CHAR(2),
  [RecebeNotificacoes] BIT DEFAULT 1,
  [ClienteAtivo] BIT DEFAULT 1,
  [DataCadastro] DATETIME,
  [DataAlteracao] DATETIME
)
GO

CREATE TABLE [ClienteVeiculo] (
  [ClienteVeiculoId] INT PRIMARY KEY IDENTITY(1, 1),
  [ClienteId] INT,
  [VeiculoId] INT,
  [PlacaVeiculo] VARCHAR(10),
  [CorVeiculo] VARCHAR(200),
  [KmRodados] INT,
  [AnoVeiculo] INT,
  [DataCadastro] DATETIME,
  [Ativo] BIT DEFAULT 1,
  [DataAlteracao] DATETIME
)
GO

CREATE TABLE [Colaborador] (
  [ColaboradorId] INT PRIMARY KEY IDENTITY(1, 1),
  [Usuario] VARCHAR(200),
  [Nome] VARCHAR(200),
  [NomeCompleto] VARCHAR(200),
  [Apelido] VARCHAR(50),
  [CPF] VARCHAR(14),
  [RG] VARCHAR(20),
  [DataAdmissao] DATETIME,
  [DataDemissao] DATETIME,
  [DataCadastro] DATETIME,
  [DataAlteracao] DATETIME,
  [Senha] VARCHAR(500)
)
GO

CREATE TABLE [MaodeObra] (
  [MaodeObraId] INT PRIMARY KEY IDENTITY(1, 1),
  [Descricao] VARCHAR(500),
  [Tipo] VARCHAR(500),
  [Valor] DECIMAL(18,2),
  [VigenciaInicial] DATETIME,
  [VigenciaFinal] DATETIME,
  [Ativo] BIT DEFAULT 1,
  [DataCadastro] DATETIME
)
GO

CREATE TABLE [Peca] (
  [PecaId] INT PRIMARY KEY IDENTITY(1, 1),
  [Descricao] VARCHAR(500),
  [Fornecedor] VARCHAR(500),
  [Valor] DECIMAL(18,2),
  [ValorFrete] DECIMAL(18,2),
  [Ativo] BIT DEFAULT 1,
  [DataCadastro] DATETIME
)
GO

CREATE TABLE [Orcamento] (
  [OrcamentoId] INT PRIMARY KEY IDENTITY(1, 1),
  [ClienteVeiculoId] INT,
  [ColaboradorId] INT,
  [Descricao] VARCHAR(250),
  [ValorMaodeObra] DECIMAL(18,2),
  [ValorPeca] DECIMAL(18,2),
  [ValorAdicional] DECIMAL(18,2),
  [PercentualDesconto] DECIMAL(18,2),
  [ValorDesconto] DECIMAL(18,2),
  [ValorTotal] DECIMAL(18,2),
  [Ativo] BIT DEFAULT 1,
  [DataCadastro] DATETIME,
  [DataAlteracao] DATETIME,
  [Status] INT
)
GO

CREATE TABLE [OrcamentoMaodeObra] (
  [Id] INT,
  [OrcamentoId] INT,
  [MaodeObraId] INT
)
GO

CREATE TABLE [OrcamentoPeca] (
  [Id] INT,
  [OrcamentoId] INT,
  [PecaId] INT
)
GO

CREATE TABLE [Servico] (
  [ServicoId] INT PRIMARY KEY IDENTITY(1, 1),
  [ClienteVeiculoId] INT,
  [ColaboradorId] INT,
  [Descricao] VARCHAR(250),
  [ValorMaodeObra] DECIMAL(18,2),
  [ValorPeca] DECIMAL(18,2),
  [ValorAdicional] DECIMAL(18,2),
  [PercentualDesconto] DECIMAL(18,2),
  [ValorDesconto] DECIMAL(18,2),
  [ValorTotal] DECIMAL(18,2),
  [Ativo] BIT DEFAULT 1,
  [DataCadastro] DATETIME,
  [DataAlteracao] DATETIME,
  [Status] INT
)
GO

CREATE TABLE [ServicoMaodeObra] (
  [Id] INT,
  [ServicoId] INT,
  [MaodeObraId] INT
)
GO

CREATE TABLE [ServicoPeca] (
  [Id] INT,
  [ServicoId] INT,
  [PecaId] INT
)
GO

CREATE TABLE [Veiculo] (
  [VeiculoId] INT PRIMARY KEY IDENTITY(1, 1),
  [CodigoFipe] BIGINT,
  [MarcaId] INT,
  [Modelo] VARCHAR(8000),
  [VeiculoAtivo] BIT DEFAULT 1,
  [DataCadastro] DATETIME
)
GO

CREATE TABLE [VeiculoMarca] (
  [MarcaId] INT PRIMARY KEY IDENTITY(1, 1),
  [Marca] VARCHAR(8000),
  [PesoOrdenacao] INT
)
GO

CREATE TABLE [ServicoPagamento] (
  [ServicoPagamentoId] INT PRIMARY KEY IDENTITY(1, 1),
  [ServicoId] INT,
  [FormaPagamentoId] INT,
  [ValorTotalOriginal] DECIMAL(18,2),
  [ValorTotalPago] DECIMAL(18,2),
  [SaldoDevedorTotal] DECIMAL(18,2),
  [DataPagamento] DATETIME,
  [EhPagamentoParcelado] BIT DEFAULT 0,
  [EhPagamentoEmDuasFormaPagamento] BIT DEFAULT 0,
  [ValorPagoNaSegundaFormaPagamento] DECIMAL(18,2),
  [ColaboradorCadastroId] INT,
  [DataCadastro] DATETIME,
  [ColaboradorAlteracaoId] INT,
  [DataAlteracao] DATETIME
)
GO

CREATE TABLE [ServicoPagamentoParcela] (
  [ServicoPagamentoParcelaId] INT PRIMARY KEY IDENTITY(1, 1),
  [ServicoPagamentoId] INT,
  [Parcela] INT,
  [ValorOriginalParcela] DECIMAL(18,2),
  [DataPagamento] DATETIME,
  [Descricao] VARCHAR(250),
  [ParcelaGeradaAutomaticamente] BIT DEFAULT 1,
  [DataCadastro] DATETIME,
  [DataAlteracao] DATETIME
)
GO

CREATE TABLE [FormaPagamento] (
  [FormaPagamentoId] INT PRIMARY KEY IDENTITY(1, 1),
  [Descricao] VARCHAR(500),
  [TemTaxaAdicional] BIT DEFAULT 0,
  [PercentualTaxaAdicional] DECIMAL(18,2),
  [ValorTaxaAdicional] DECIMAL(18,2),
  [FormaPagamentoAtiva] BIT DEFAULT 1,
  [DataCadastro] DATETIME,
  [DataAlteracao] DATETIME
)
GO

CREATE TABLE [ControleStatus] (
  [StatusId] INT PRIMARY KEY IDENTITY(1, 1),
  [TipoStatus] VARCHAR(100),
  [Descricao] VARCHAR(500),
  [DataCadastro] DATETIME,
  [DataAlteracao] DATETIME
)
GO

ALTER TABLE [ServicoPagamentoParcela] ADD FOREIGN KEY ([ServicoPagamentoId]) REFERENCES [ServicoPagamento] ([ServicoPagamentoId])
GO

ALTER TABLE [ServicoPagamento] ADD FOREIGN KEY ([ServicoId]) REFERENCES [Servico] ([ServicoId])
GO

ALTER TABLE [ServicoPagamento] ADD FOREIGN KEY ([FormaPagamentoId]) REFERENCES [FormaPagamento] ([FormaPagamentoId])
GO

ALTER TABLE [ServicoMaodeObra] ADD FOREIGN KEY ([ServicoId]) REFERENCES [Servico] ([ServicoId])
GO

ALTER TABLE [ServicoPeca] ADD FOREIGN KEY ([ServicoId]) REFERENCES [Servico] ([ServicoId])
GO

ALTER TABLE [ServicoMaodeObra] ADD FOREIGN KEY ([MaodeObraId]) REFERENCES [MaodeObra] ([MaodeObraId])
GO

ALTER TABLE [ServicoPeca] ADD FOREIGN KEY ([PecaId]) REFERENCES [Peca] ([PecaId])
GO

ALTER TABLE [OrcamentoMaodeObra] ADD FOREIGN KEY ([OrcamentoId]) REFERENCES [Orcamento] ([OrcamentoId])
GO

ALTER TABLE [OrcamentoPeca] ADD FOREIGN KEY ([OrcamentoId]) REFERENCES [Orcamento] ([OrcamentoId])
GO

ALTER TABLE [OrcamentoMaodeObra] ADD FOREIGN KEY ([MaodeObraId]) REFERENCES [MaodeObra] ([MaodeObraId])
GO

ALTER TABLE [Orcamento] ADD FOREIGN KEY ([ClienteVeiculoId]) REFERENCES [ClienteVeiculo] ([ClienteVeiculoId])
GO

ALTER TABLE [OrcamentoPeca] ADD FOREIGN KEY ([PecaId]) REFERENCES [Peca] ([PecaId])
GO

ALTER TABLE [Veiculo] ADD FOREIGN KEY ([MarcaId]) REFERENCES [VeiculoMarca] ([MarcaId])
GO

ALTER TABLE [ClienteVeiculo] ADD FOREIGN KEY ([ClienteId]) REFERENCES [Cliente] ([ClienteId])
GO

ALTER TABLE [ClienteVeiculo] ADD FOREIGN KEY ([VeiculoId]) REFERENCES [Veiculo] ([VeiculoId])
GO

ALTER TABLE [Servico] ADD FOREIGN KEY ([ClienteVeiculoId]) REFERENCES [ClienteVeiculo] ([ClienteVeiculoId])
GO

ALTER TABLE [Servico] ADD FOREIGN KEY ([Status]) REFERENCES [ControleStatus] ([StatusId])
GO

ALTER TABLE [Orcamento] ADD FOREIGN KEY ([Status]) REFERENCES [ControleStatus] ([StatusId])
GO