USE [DB_A57E2C_SGMLoquinhoRC]
GO

	CREATE TABLE ControleStatus 
	(
		 StatusId INT PRIMARY KEY IDENTITY(1,1)
		,TipoStatus VARCHAR(100) NOT NULL
		,Descricao VARCHAR(500) NOT NULL
		,DataCadastro DATETIME NOT NULL
		,DataAlteracao DATETIME NULL
	)

		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('Table:Orcamento:Status', 'Iniciado - Pendente de Término', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('Table:Orcamento:Status', 'Expirado', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('Table:Orcamento:Status', 'Desistido pelo Cliente', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('Table:Orcamento:Status', 'Concluido - Gerado mas ainda não houve serviço', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('Table:Orcamento:Status', 'Concluido e Gerou Ordem de Serviço', GETDATE())

		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('Table:Servico:Status', 'Iniciado - Pendente de Término', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('Table:Servico:Status', 'Expirado', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('Table:Servico:Status', 'Desistido pelo Cliente', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('Table:Servico:Status', 'Concluido - Serviço executado SEM Pagamento', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('Table:Servico:Status', 'Concluido - Serviço executado com Pagamento efetuado', GETDATE())

		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('EnumControleTelas:SGM', 'Botões Inserir e Localizar', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('EnumControleTelas:SGM', 'Botões Salvar, Cancelar e Excluir', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('EnumControleTelas:SGM', 'Botões Alterar, Excluir e Cancelar', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('EnumControleTelas:SGM', 'Botão Localizar', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('EnumControleTelas:SGM', 'Botões Cancelar e Salvar', GETDATE())

		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('EnumTipoServico:SGM', 'Serviço - Mão de Obra', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('EnumTipoServico:SGM', 'Serviço - Peças', GETDATE())