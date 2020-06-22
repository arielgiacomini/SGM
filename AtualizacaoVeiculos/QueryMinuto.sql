USE [Ofertas]
GO

	SELECT DISTINCT 
					Marca.Nome AS MarcaNome,
					Veiculo.Nome AS VeiculoNome, 
					Veiculo.AutoComplete AS NomeVeiculoSimplificado, 
					AnoModeloInicial, 
					AnoModeloFinal, 
					CodigoFIPE 
		FROM [Automovel.Corretor]..Veiculo 
				INNER JOIN [Automovel.Corretor]..Marca ON Marca.Id = Veiculo.MarcaId
				WHERE 1=1					
	ORDER BY Veiculo.Nome, AnoModeloInicial, AnoModeloFinal


	SELECT 
					Marca.Nome AS MarcaNome,
					COUNT(*) AS Quantidade
		FROM [Automovel.Corretor]..Veiculo 
				INNER JOIN [Automovel.Corretor]..Marca ON Marca.Id = Veiculo.MarcaId
				WHERE 1=1
	GROUP BY Marca.Nome
	ORDER BY Quantidade DESC