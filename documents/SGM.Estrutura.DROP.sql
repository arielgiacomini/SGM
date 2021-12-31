BEGIN
	BEGIN TRANSACTION
		
		BEGIN TRY
			
			DROP TABLE OrcamentoMaodeObra
			DROP TABLE OrcamentoPeca	
			DROP TABLE Orcamento
			
			DROP TABLE ServicoMaodeObra
			DROP TABLE ServicoPeca
			DROP TABLE ServicoPagamentoParcela
			DROP TABLE ServicoPagamento
			DROP TABLE Servico
			
			DROP TABLE Colaborador
			
			DROP TABLE MaodeObra
			DROP TABLE Peca

			DROP TABLE ControleStatus

			DROP TABLE ClienteVeiculo
			
			DROP TABLE Veiculo

			DROP TABLE Cliente

			DROP TABLE FormaPagamentoParcela

			DROP TABLE FormaPagamento

			DROP TABLE VeiculoMarca
	
			COMMIT

			PRINT 'EXECUTOU COM SUCESSO!!'

		END TRY
	
		BEGIN CATCH 

			ROLLBACK
			SELECT ERROR_MESSAGE()
		
		END CATCH
END