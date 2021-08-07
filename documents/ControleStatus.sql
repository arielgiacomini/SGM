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

		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('Table:Orcamento:Status', 'Iniciado - Pendente de T�rmino', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('Table:Orcamento:Status', 'Expirado', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('Table:Orcamento:Status', 'Desistido pelo Cliente', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('Table:Orcamento:Status', 'Concluido - Gerado mas ainda n�o houve servi�o', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('Table:Orcamento:Status', 'Concluido e Gerou Ordem de Servi�o', GETDATE())

		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('Table:Servico:Status', 'Iniciado - Pendente de T�rmino', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('Table:Servico:Status', 'Expirado', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('Table:Servico:Status', 'Desistido pelo Cliente', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('Table:Servico:Status', 'Concluido - Servi�o executado SEM Pagamento', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('Table:Servico:Status', 'Concluido - Servi�o executado com Pagamento efetuado', GETDATE())

		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('EnumControleTelas:SGM', 'Bot�es Inserir e Localizar', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('EnumControleTelas:SGM', 'Bot�es Salvar, Cancelar e Excluir', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('EnumControleTelas:SGM', 'Bot�es Alterar, Excluir e Cancelar', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('EnumControleTelas:SGM', 'Bot�o Localizar', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('EnumControleTelas:SGM', 'Bot�es Cancelar e Salvar', GETDATE())

		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('EnumTipoServico:SGM', 'Servi�o - M�o de Obra', GETDATE())
		INSERT INTO ControleStatus (TipoStatus, Descricao, DataCadastro) VALUES ('EnumTipoServico:SGM', 'Servi�o - Pe�as', GETDATE())